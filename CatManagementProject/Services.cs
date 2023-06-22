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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form services = new Services();
            services.ShowDialog();
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

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form manager = new Manager();
            manager.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form serviceList = new ServiceList();
            serviceList.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registeredServiceList = new RegisteredServiceList();
            registeredServiceList.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form createService = new CreateService();
            createService.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateService = new UpdateService();
            updateService.ShowDialog();
        }
    }
}
