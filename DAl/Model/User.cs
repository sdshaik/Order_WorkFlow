using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAl.Model
{
    public class User
    {
        public User()
            { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_Id { get; set; }

        public string  User_Name { get; set; }

        
        public int Order_Id { get; set; }
        [ForeignKey("Order_Id")]
        public Order Order { get; set; }

    }
    
    
}
