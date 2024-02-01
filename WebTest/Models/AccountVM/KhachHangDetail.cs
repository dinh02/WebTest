namespace WebTest.Models.AccountVM
{
    public class KhachHangDetail
    {
        public ApplicationUser user { get; set; }
        //public List<Paymment> paymments { get; set; }
        //public List<HistoryVideo> Video { get; set; }

        public List<Progress> Progresses { get; set; }

    }

    public class Progress
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public double Percent { get; set; }
    }
}
