using Microsoft.Identity.Client;
using Services.Helper;
using Services.Models;
using Services.Services;
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
    public partial class RegisteredServiceList : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();

        public RegisteredServiceList()
        {
            InitializeComponent();
            initRegisteredServiceList();
        }
        public void initRegisteredServiceList()
        {
            var listRegisteredService = _registeredServiceHelper.GetAll();
            dgvRegisteredServiceList.DataSource = new BindingSource { DataSource = listRegisteredService };
            dgvRegisteredServiceList.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            reInitForm();
        }

        private static String transferID = "";

        private void dgvRegisteredServiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String registeredServiceIDStr = "";
            int accountID;
            int serviceID;
            var listAccount = _accountHelper.GetAll();
            var listRegisteredService = _registeredServiceHelper.GetAll();
            var listService = _serviceHelper.GetAll();

            foreach (DataGridViewRow row in dgvRegisteredServiceList.SelectedRows)
            {
                registeredServiceIDStr = row.Cells["RegisteredID"].Value.ToString();
                txtRegisteredServiceID.Text = row.Cells["RegisteredID"].Value.ToString();
            }
            int registeredServiceID = Convert.ToInt32(registeredServiceIDStr);
            RegisteredService registeredService = listRegisteredService.FirstOrDefault
                (x => x.RegisteredId.Equals(registeredServiceID));

            accountID = Convert.ToInt32(registeredService.AccountId);
            Account account = listAccount.FirstOrDefault(x => x.AccountId.Equals(accountID));
            txtAccountID.Text = account.AccountId.ToString();
            txtAccountFullname.Text = account.Fullname;

            txtCatID.Text = registeredService.CatId.ToString();

            serviceID = Convert.ToInt32(registeredService.ServiceId);
            Service service = listService.FirstOrDefault(x => x.ServiceId.Equals(serviceID));
            txtServiceID.Text = service.ServiceId.ToString();
            txtServiceName.Text = service.ServiceName.ToString();

            if (checkStatusNotDone(registeredService.Status.Value))
            {
                buttonStylingStatusNotDone();
            }
            else
            {
                buttonStylingStatusDone();
            }

            txtDate.Text = registeredService.Date.ToString();
        }

        private Boolean checkStatusNotDone(int status)
        {
            Boolean result = false;
            if (status == 0)
            {
                result = true;
            }
            return result;
        }

        private void buttonStylingStatusNotDone()
        {
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;

            btnDone.Enabled = true;
            btnDone.BackColor = Color.Green;
            btnCancel.ForeColor = Color.White;

            txtStatus.Text = "Not Done";
            txtStatus.ForeColor = Color.Red;
        }

        private void buttonStylingStatusDone()
        {
            btnCancel.Enabled = false;
            btnCancel.BackColor = Color.White;
            btnCancel.ForeColor = Color.Black;

            btnDone.Enabled = false;
            btnDone.BackColor = Color.White;
            btnCancel.ForeColor = Color.Black;

            txtStatus.Text = "Done";
            txtStatus.ForeColor = Color.Green;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var listRegisteredService = _registeredServiceHelper.GetAll();
            var confirmResult = MessageBox.Show("Confirm cancellation of service. " +
                "This action cannot be undone.",
                                     "Confirm Cancel",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int registeredServiceID = Convert.ToInt32(txtRegisteredServiceID.Text);
                RegisteredService registeredService = listRegisteredService.FirstOrDefault
                    (x => x.RegisteredId.Equals(registeredServiceID));
                _registeredServiceHelper.Delete(registeredService);
                initRegisteredServiceList();
            }
            else
            {
                reInitForm();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var listRegisteredService = _registeredServiceHelper.GetAll();
            var confirmResult = MessageBox.Show("Confirm completion of service. " +
                "This action cannot be undone.",
                                     "Confirm Status",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int registeredServiceID = Convert.ToInt32(txtRegisteredServiceID.Text);
                RegisteredService registeredService = listRegisteredService.FirstOrDefault
                    (x => x.RegisteredId.Equals(registeredServiceID));
                registeredService.Status = 1;
                _registeredServiceHelper.Update(registeredService);
                initRegisteredServiceList();
            }
            else
            {
                reInitForm();
            }
        }

        private void reInitForm()
        {
            txtRegisteredServiceID.Text = string.Empty;
            txtAccountID.Text = string.Empty;
            txtAccountFullname.Text = string.Empty;
            txtCatID.Text = string.Empty;
            txtServiceID.Text = string.Empty;
            txtServiceName.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtStatus.ForeColor = Color.Black;
            txtDate.Text = string.Empty;
            buttonStylingStatusDone();
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
    }
}
