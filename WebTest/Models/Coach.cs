namespace WebTest.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string AvatartPath { get; set; }
        public string ShortDecription { get; set; }
        public DateTime CreateDate { get; set; }
        public bool is_default { get; set; }
    }
}
