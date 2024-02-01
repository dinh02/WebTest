namespace WebTest.Models.ApplicationUserViewModel
{
    public class FilterUserViewModel
    {
        public int TagId { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
        public int ConditionalDate { get; set; } // 1 là trước, 2 là trong, 3 là sau
        public int CourseId { get; set; }
        public int ProgressCourse { get; set; }
        public int ConditionalCourse { get; set; }
        public int ActiveCodeId { get; set; }
        public int NumberOfCoruse { get; set; }
        public int NumberOfCourseCondition { set; get; }
        public int RateOnline { get; set; }
        public int RateLearn { get; set; }
        public int RateNumberOnline { get; set; }
        public int RateLearnNumber { get; set; }
        public string Point { get; set; }
        public string SanPham { get; set; }
        public string ViTriCongViec { get; set; }
        public string NganhKinhDoanh { get; set; }

        public string JsonCourse { get; set; }
        public string JsonTag { get; set; }
        public string JsonActiveCode { get; set; }
    }

    public class FilterCourses
    {
        public int courseId { get; set; }
        public int condition { get; set; }
        public int percent { get; set; }
    }

    public class FilterTag
    {
        public int TagId { get; set; }
    }

    public class FilterActiveCode
    {
        public int activeCodeId { get; set; }
    }


}
