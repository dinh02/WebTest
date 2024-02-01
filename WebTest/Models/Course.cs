using System.ComponentModel.DataAnnotations.Schema;

namespace WebTest.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public int CategoryMain { get; set; }
        public string CategoryType { get; set; }
        public string? TimeTotal { get; set; }
        public string? CourseAmount { get; set; }
        public string? EbookFile { get; set; }
        public string? EbookMb { get; set; }
        public string? Banner { get; set; }
        public int CoachId { get; set; }
        public string? ContentInfo { get; set; }
        public string? ShortDecription { get; set; }
        public string? WillLearn { get; set; }
        public string? Requiments { get; set; }
        public string? FQA { get; set; }
        public string? LinkVideo { get; set; }
        public string? LinkThumb { get; set; }
        public string? LinkCover { get; set; }
        public double Price { get; set; }
        public bool Is_Popular{ get; set; }
        public int SortCourse { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("CategoryMain")]
        public virtual Category CategoryCourse { get; set; } 
        
        [ForeignKey("CoachId")]
        public virtual Coach CoachCourse { get; set; }


        public Course()
        {

        }



    }
}
