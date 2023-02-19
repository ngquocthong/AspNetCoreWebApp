using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Category
    {
<<<<<<< HEAD
        
=======

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string cate_name { get; set; }
        public string cate_des { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
>>>>>>> ba88119f06eca110e4ee0199cddc122839e07848
    }
}
