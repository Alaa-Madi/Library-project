using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
    public abstract class Book
    {
        [Key]
        public int  ISBNID { get; set; }
        public string title { get; set; }
        public string Summary { get; set; }
        public string publisher { get; set; }
        public DateTime publicationDate { get; set; }
        public int numberOfPage { get; set; }
        public string language { get; set; }
        public IList<BookAuther> BookAuthers { get; set; }
        public Libraian Libraian { get; set; }
    }

}