using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
    public class Patron //: ISearch
    {
        [Key]
        public int PatronID { get; set; }
        public string Name { get; set; }
        public int AccountID { get; set; }
        public Account Account { get; set; }
    }
}