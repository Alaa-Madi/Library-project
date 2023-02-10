using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
     public class Auther
    {
 
        [Key]
        public int autherID { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public IList<BookAuther> BookAuthers { get; set; }

    }
}
