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
    public partial class Admin : Form
    {
        Bookcontext ctx = new Bookcontext();
        public Admin()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library lib = new Library(){ Name=textBox8.Text} ;
            string name = textBox1.Text;
            Catalog cat = new Catalog() { Name = name,Library=lib };
            ctx.Catalogs.Add(cat);
            ctx.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            Library lib = new Library();
            lib.Name = name;
            ctx.Libraries.Add(lib);
            ctx.SaveChanges();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            int password =Int32.Parse( textBox4.Text);
            int  possition = Int32.Parse(textBox5.Text);
            Libraian libr = new Libraian();
            libr.Password = password;
            libr.Position = possition;
            libr.Username = username;
            ctx.Libraians.Add(libr);
            ctx.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e) {
            string Patronname = textBox6.Text;
            Account a = new Account();
            if (comboBox1.SelectedValue == "Active")
            {
                a.state = AccountState.Active;
            }
            else if (comboBox1.SelectedValue == "Frozen")
            {
                a.state = AccountState.Frozen;
            }
            else {
                a.state = AccountState.Closed; }

            a.history = textBox9.Text;
            a.date = dateTimePicker1.Value;

            Patron pt = new Patron() { Name = Patronname ,Account = a };
            ctx.Patrons.Add(pt);
            ctx.Accounts.Add(a);
           
            ctx.SaveChanges();
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
