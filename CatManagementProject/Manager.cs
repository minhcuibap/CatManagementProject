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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
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

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form services = new Services();
            services.ShowDialog();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cat = new CatList();
            cat.ShowDialog();
        }
    }
}
