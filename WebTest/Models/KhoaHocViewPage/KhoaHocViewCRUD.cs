namespace WebTest.Models.KhoaHocViewPage
{
    public class KhoaHocViewCRUD
    {
        public List<Course> CourseItems { get; set; }
        public Course CourseDetails { get; set; }
        public List<Category> CategoryList { get; set; }

        public int CourseCount { get; set; }

        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public bool CheckActive { get; set; }

      
    }
}
