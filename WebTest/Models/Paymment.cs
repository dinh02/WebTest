using System.ComponentModel.DataAnnotations.Schema;

namespace WebTest.Models
{
    public class Paymment
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public int CourseId { get; set; }
        public int ChienDichId { get; set; }
        public int? CodeActive { get; set; }
        public string Is_Active { get; set; }
        public string Transfer { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CvtId { get; set; }
        public string? Total { get; set; }
        public int? BuoiMuaHangId { get; set; }


        [ForeignKey("CourseId")]
        public virtual Course PaymentCourse { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser UserPayment { get; set; }

       

    }
}
