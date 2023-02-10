using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;

namespace BookLIbrary12
{
    public class BookAuther
    {  
        public  int ISBNID { get; set; }
        public Book Book { get; set; }
        public int autherID { get; set; }
        public Auther Auther { get; set; }
        
    }
}