using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAl.Model
{
    public class Product
    {
        public Product()
        { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_Id { get; set; }

        public double Product_Price { get; set; }

        public string Product_stock_qun { get; set; }
    }
}
