using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAl.Model
{
    public class Payment
    {
        public Payment()
        { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_Id { get; set; }


       public int User_id { get; set; }
        [ForeignKey("User_id")]
        public User User { get; set; }

        public double Paid_Amount { get; set; }

        public double Due_Amount { get; set; }
    }
}
