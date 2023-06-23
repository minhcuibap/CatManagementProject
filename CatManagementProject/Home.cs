using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CatManagementProject
{
    public partial class Home : Form
    {
        public string Username { get; set; }
        public Home()
        {
            InitializeComponent();
        }
        public Home(string username)
        {
            InitializeComponent();
            Username = username;
<<<<<<< HEAD


=======
>>>>>>> 7539cf1 (Added Receipt form)
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("You sure you want to log out", "Log Out",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Login();
                login.ShowDialog();
            }
        }

        private void button_Receipt(object sender, EventArgs e)
        {
<<<<<<< HEAD
            String username = Username;
=======
            string username = (Application.OpenForms["Login"] as Login)?.Username;
>>>>>>> 7539cf1 (Added Receipt form)
            this.Hide();
            Form receipt = new Receipt(username);
            receipt.ShowDialog();
        }
<<<<<<< HEAD

        private void buttonHome_click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new Home();
            home.ShowDialog();
        }
=======
>>>>>>> 7539cf1 (Added Receipt form)
    }
}
