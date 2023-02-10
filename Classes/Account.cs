using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLIbrary12
{
     public class Account 
    {
        [Key]
        public int AccountID { get; set; }
        public string history { get; set; }
        public DateTime date { get; set; }
        public AccountState state { get; set; }// object account state 
        public Library Library { get; set; }
         public ICollection<BookItem> BookItems { get; set; }
         public Patron Patron { get; set; }
        
        

    }
}
