//using BookLIbrary12.Service_layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BookLIbrary12.Forms
{
    public partial class Librarian : Form
    {
        Bookcontext ctx = new Bookcontext();
        List<BookAuther> al = new List<BookAuther>();
        public Librarian()
        {
            InitializeComponent();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //book data
            BookItem B = new BookItem();
            string title = textBox1.Text;
            string sammary = textBox2.Text;
            string publisher = textBox3.Text;
            DateTime publicationDate = dateTimePicker1.Value;
            int numberofbages = Int32.Parse(textBox4.Text);
            string barcode = textBox5.Text;
            int tag = Int32.Parse(textBox6.Text);
            string languge = textBox27.Text ;   
            //catalog data 
            int catID = Int32.Parse(textBox11.Text);
            var c= ctx.Catalogs.Where(E => E.CatalogID == catID).Single();
           
           //account data
            int ACID= Int32.Parse(textBox12.Text);
            var acc = ctx.Accounts.Where(r => r.AccountID == ACID).Single();
            //library data
            int LIBID = Int32.Parse(textBox13.Text);
            var lib = ctx.Libraries.Where(t => t.AddressID == LIBID).Single();
            //authername ddata
            int autherID =Int32.Parse(textBox10.Text);
            var a = ctx.Authers.Where(y => y.autherID == autherID).Single();

            int librarianID = Int32.Parse(textBox14.Text);
            var libr = ctx.Libraians.Where(t => t.AddressID == librarianID).Single(); 
            BookItem BI = new BookItem()
            {
                title = title,
                Summary = sammary,
                publisher = publisher,
                publicationDate = publicationDate,
                numberOfPage = numberofbages,
                barcode = barcode,
                tag = tag,
                language = languge,
                Catalog = c,
                Account = acc,
                Library = lib,
                Libraian = libr,
                BookAuthers = al
            };

            BookAuther BO = new BookAuther() {  autherID = a.autherID, ISBNID = BI.ISBNID };
            ctx.BookAuthers.Add(BO);
            ctx.BookItems.Add(BI);
            ctx.SaveChanges();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BookID = Int32.Parse(textBox16.Text);
           // BookItem b = new BookItem();
            String bookName = textBox17.Text;
            var x = ctx.BookItems.Where(d => d.ISBNID == BookID).Single();
            if (x != null)
            {
                x.title = bookName;
                ctx.SaveChanges();
            }
               
           
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bookID = Int32.Parse(textBox15.Text);

            var x = ctx.BookItems.Where(x => x.ISBNID == bookID).Single();
            var h = ctx.BookAuthers.Where(x => x.ISBNID == bookID).ToList();
           
                foreach (var h2 in h)
                {
                    ctx.BookAuthers.Remove(h2);

                }
                ctx.BookItems.Remove(x);
                ctx.SaveChanges();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int BookID = Int32.Parse(textBox18.Text);
            BookItem B = new BookItem();
            var x = ctx.BookAuthers.Where(b => b.ISBNID == BookID).Select(v => v.Auther.Name).ToList();
            if (x != null)
            {
                MessageBox.Show("auther name of this bookID  is :: " + x);
            }
            else
            {
                MessageBox.Show("this information about book is invalid");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = ctx.Patrons.Select(N => N.Name).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = ctx.Accounts.Where(s => s.state == (AccountState)2).ToList();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name = textBox7.Text;
            string biography = textBox8.Text;
            Auther a = new Auther();
            a.Name = name;
            a.Biography = biography;
            ctx.Authers.Add(a);
            ctx.SaveChanges();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int BookID = Int32.Parse(textBox19.Text);
            String BookTitle = textBox20.Text;
            var y = ctx.BookItems.Where(p => p.ISBNID == BookID || p.title == BookTitle).Single();
            if (y != null)
            {
                MessageBox.Show("this book is exist");
            }
            else
            {
                MessageBox.Show("this book does not exist");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var a = ctx.BookItems.Where(z => z.language == "French").Single();
            if (a != null)
            {
                MessageBox.Show("the book with french languge is : " + a.title);
            }
            else
            {
                MessageBox.Show(" NO Books  in french languge");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var N = ctx.BookItems.Select(s => s.numberOfPage).Max();
            if (N != null)
            {
                MessageBox.Show("the book with maximum number  of bages is :" + N);
            }
            else
            {
                MessageBox.Show("  NO books in database");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int patronid = Int32.Parse(textBox9.Text);
            var p = ctx.Patrons.Where(d => d.PatronID == patronid).Single();
          
            if (p != null)
            {  
                p.Name = textBox21.Text;
                ctx.SaveChanges();
            }
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string authername = textBox23.Text;
            Auther A = new Auther();
            var autheridforsearch = ctx.Authers.Where(d => d.Name == authername).Select(s => s.autherID).Single();
            if(autheridforsearch != null)
            {
                listBox3.DataSource = ctx.BookAuthers.Where(q => q.autherID == autheridforsearch).Select(w => w.Book.title).ToList();
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int bookid = Int32.Parse(textBox26.Text);
            var boo = ctx.BookItems.Where(s => s.ISBNID == bookid).Single();
            if(boo==null)
            {
                MessageBox.Show("you return book ");
            }
            else
            {
                MessageBox.Show("invalid book id you returned it ");
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           int BOOKID = Int32.Parse(textBox24.Text);
          
           int Patronid = Int32.Parse(textBox25.Text);
            var q = ctx.BookItems.Where(s => s.ISBNID == BOOKID).Select(p=>p.Account.AccountID ==Patronid).Single();
            if (q != null)
            {
                MessageBox.Show("borrow processing Done");
            }
            else
            {
                MessageBox.Show("borrow processing not occer");
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            var All_Authors = ctx.Authers.ToList();
            var All_Books = ctx.BookItems.ToList();
            for (int i = 0; i < All_Authors.Count; i++)
            {
                if (All_Authors[i].autherID == Int32.Parse(textBox10.Text))
                {
                    BookAuther b = new BookAuther();
                    b.ISBNID = All_Books.Count + 1;
                    b.ISBNID = All_Authors[i].autherID;
                    al.Add(b);
                }
            }
        }
    }
    
}
