using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebTest.Data;
using WebTest.Models;
using WebTest.Models.KhoaHocViewPage;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        [Route("/khoa-hoc")]
        [HttpGet]
        public IActionResult KhoaHoc()
        {
            ViewBag.userName = User.Identity.Name;

            var pageSize = 6;
            var count = _context.Course.Count();
            var totalPages = (int)Math.Ceiling((double)count / pageSize);

            var category = _context.Category.OrderByDescending(x => x.Id).ToList();

            var course = _context.Course
                .Include(x => x.CoachCourse)
                .Include(x => x.CategoryCourse)
                .OrderBy(x => x.SortCourse)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPage = totalPages;
            var responesive = new KhoaHocViewCRUD
            {
                CourseItems = course,
                CourseCount = count,
                TotalPages = totalPages,
                CategoryList = category

            };
            return View(responesive);
        }
        [Route("/khoa-hoc/filter")]
        [HttpGet]
        public IActionResult KhoaHocQuery([FromQuery] string sort, [FromQuery] string slugCategory, [FromQuery] string active, [FromQuery] string type, [FromQuery] int page = 1)
        {
            var pageSize = 6;
            var skip = (page - 1) * pageSize;

            var course = _context.Course
                .Include(x => x.CoachCourse)
                .Include(x => x.CategoryCourse);
            var user = _context.ApplicationUser
                   .SingleOrDefault(x => x.UserName == User.Identity.Name);
            List<Course> sortedPr;
            switch (sort)
            {
                case "new":
                    sortedPr = course.OrderByDescending(x => x.Id).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                    break;
                case "priceLow":
                    sortedPr = course.OrderBy(x => x.Price).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                    break;
                case "priceHight":
                    sortedPr = course.OrderByDescending(x => x.Price).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                    break;
                default:
                    sortedPr = course.OrderByDescending(x => x.Id).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                    break;
            }
            if (slugCategory != "0")
            {
                sortedPr = sortedPr.Where(x => x.CategoryCourse.Slug == slugCategory).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
            }
            if (user != null)
            {
                var userCheck = _context.Paymment.Where(x => x.UserId == user.Id && x.Is_Active == "Active").ToList();

                if (active != "0")
                {
                    switch (active)
                    {
                        case "Đã mua":
                            sortedPr = sortedPr.Where(x => userCheck.Any(uc => uc.CourseId == x.Id)).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                            break;
                        case "Chưa mua":
                            sortedPr = sortedPr.Where(x => userCheck.Any(uc => uc.CourseId != x.Id)).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
                            break;

                        default:
                            sortedPr = sortedPr.Where(x => userCheck.Any(uc => uc.CourseId != x.Id)).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).OrderBy(x => x.SortCourse).ToList();
                            break;
                    }
                }
            }

            if (type != null)
            {
                sortedPr = sortedPr.Where(x => x.CategoryType == type).OrderBy(x => x.SortCourse).Skip(skip).Take(pageSize).ToList();
            }
            var count = sortedPr.Count();
            var totalPages = (int)Math.Ceiling((double)count / pageSize);
            ViewBag.TotalPage = totalPages;

            return PartialView("_CoursePostPartial", sortedPr);
        }

        [Route("/khoa-hoc/load-more")]
        [HttpGet]

        public IActionResult LoadMore(int page)
        {
            var pageSize = 6;
            var skip = (page - 1) * pageSize;
            var course = _context.Course
               .Include(x => x.CoachCourse)
               .Include(x => x.CategoryCourse)
                .OrderByDescending(x => x.Id)
                .ThenBy(x => x.SortCourse)
               .Skip(skip)
               .Take(pageSize)
               .ToList();

            return PartialView("_CoursePostPartial", course);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}