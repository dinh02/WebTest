namespace WebTest.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public bool is_default { get; set; }


    }
}
