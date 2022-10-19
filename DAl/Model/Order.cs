using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAl.Model
{
    public class Order
    {
        public Order()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_id { get; set; }

        public DateTime Order_date { get; set; }

        public String Order_Status { get; set; }


        public int Product_Id { get; set; }
        [ForeignKey("Product_Id")]
        public Product Product { get; set; }
    
    }
}
