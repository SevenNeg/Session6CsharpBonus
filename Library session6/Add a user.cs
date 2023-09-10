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
    public partial class Add_a_user : Form
    {
        public Add_a_user()
        {
            InitializeComponent();
        }
       
        private void UserButtonn_Click(object sender, EventArgs e)
        {
            User person1 = new User();
            person1.FirstName = NameUserTxt.Text;
            person1.LastName = Lnameusertxt.Text;
            person1.Cellphone = Cellphoneusertxt.Text;
            person1.Subcode = Subcodetxt.Text;
            List <User> users = new List <User>();
            users.Add (person1);
            if (string.IsNullOrEmpty(person1.FirstName) || string.IsNullOrEmpty(person1.LastName) || string.IsNullOrEmpty(person1.Cellphone) || string.IsNullOrEmpty(person1.Subcode))
            {
                MessageBox.Show("Don't keep any box blank");
                return;
            }
            int cell;
            bool number = int.TryParse(person1.Cellphone, out cell);
            if (number == false)
            {
                MessageBox.Show("Please insert a valid number for cellphone");
            }
            int subscription;
            bool sub = int.TryParse(person1.Subcode, out subscription);
            if (sub == false)
            {
                MessageBox.Show("Please insert numbers (not chracters) for the subscription code");
            }
            if (person1.Cellphone.StartsWith("+98"))
            {
                person1.Cellphone.Replace("+98", "0");
            }
            while (person1.Cellphone.StartsWith("+98"))
            {
                if (person1.Cellphone.Length!= 13)
                {
                    MessageBox.Show("Please insert a valid number for cellphone");
                }
            }
            while (person1.Cellphone.StartsWith("0"))
            {
                if(person1.Cellphone.Length!= 11)
                {
                    MessageBox.Show("Please insert a valid number for cellphone");
                }
            }
        }

        private void UserBackbutton_Click(object sender, EventArgs e)
        {
            Main Form = new Main();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
    }
}
