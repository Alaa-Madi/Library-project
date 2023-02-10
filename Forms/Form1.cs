using BookLIbrary12.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLIbrary12
{
    public partial class Form1 : Form
    {
        Bookcontext ctx = new Bookcontext();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            int password = Int32.Parse(textBox2.Text);
            var c = ctx.Libraians.Where(L => L.Username == userName && L.Password == password).SingleOrDefault();
           
            if (userName == "Admin" && password == 1234)
            {
                Admin admin = new Admin();
                admin.Show();
            }
             else if (c != null)
                {
                    Librarian libraian = new Librarian();
                    libraian.Show();
                }
             else
                {
                    MessageBox.Show("Sorry, don't allow to enter library ");
                }
            
            
           
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
