using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
    public class BookItem : Book
    {
        public string barcode { get; set; }
        public int tag { get; set; }
        public bool isRefrenceOnly { get; set; }
        public Catalog Catalog { get; set; }
        public AccountState State { get; set; }
        public Account Account { get; set; }
       public Library Library { get; set; }
     
    }
}

