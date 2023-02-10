using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
  public   class Library
    {
        public string Name { get; set; }
        [Key]
        public int AddressID { get; set; }
        public List<Catalog> Catalogs { get; set; }

        public List<BookItem> BookItems = new List<BookItem>();//aggregation 

        public List<Account> Account = new List<Account>();//aggregation 



    }
}
