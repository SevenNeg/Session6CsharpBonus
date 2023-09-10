using Library_session6.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_session6
{
    public partial class Add_a_book : Form
    {
        public Add_a_book()
        {
            InitializeComponent();
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            Book Person1 = new Book();
            Person1.Name = NametextBox.Text;
            Person1.BookCode = codetextbox.Text;
            Person1.Sdisc = shortdiscTextbox.Text;
            Person1.Author = AuthortextBox.Text;
            List <Book> books = new List <Book>();
            books.Add(Person1);
            int bookcode;
            bool code = int.TryParse(Person1.BookCode, out bookcode);
            if (code == false)
            {
                MessageBox.Show("Please insert numbers for the Book's Code");
            }

            if (string.IsNullOrEmpty(Person1.Name) || string.IsNullOrEmpty(Person1.BookCode) || string.IsNullOrEmpty(Person1.Sdisc) || string.IsNullOrEmpty(Person1.Author))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }
        }

        private void Userbackbutton_Click(object sender, EventArgs e)
        {
            Main Form = new Main();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
    }
}
