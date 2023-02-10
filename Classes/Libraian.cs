using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
    public class Libraian// : ISearch, IManage
    {
        [Key]
        public int AddressID { get; set; }
        public int Position { get; set; }
        public string Username { get; set; }
        public int  Password { get; set; }
        public IList<Book> Books { get; set; }



    }
}
