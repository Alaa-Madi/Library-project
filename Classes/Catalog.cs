using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
   public  class Catalog // : ISearch, IManage
    {
        [Key]
        public int CatalogID { get; set; }
        public string Name { get; set; }
        public ICollection<BookItem> bookItems { get; set; }
        public Library Library { get; set; }

    }
}