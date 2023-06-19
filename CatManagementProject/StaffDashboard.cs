using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Helper;
using Services.Services;

namespace CatManagementProject
{
    public partial class StaffDashboard : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();
        public StaffDashboard()
        {
            InitializeComponent();
            initRegisteredServiceList();
            initServiceList();
        }

        public void initRegisteredServiceList()
        {
            var listRegisteredService = _registeredServiceHelper.GetAll();
            dgvRegisteredServiceList.DataSource = new BindingSource { DataSource = listRegisteredService };
        }

        public void initServiceList()
        {
            var listService = _serviceHelper.GetAll();
            dgvServiceList.DataSource = new BindingSource { DataSource = listService };
            dgvServiceList.Columns["ServiceName"].Width = 320;
        }

        private void btnInitCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form createServiceForm = new CreateService();
            createServiceForm.ShowDialog();
            this.Close();
        }

        private void btnInitUpdate_Click(object sender, EventArgs e)
        {
            transferID = txtID.Text;
            this.Hide();
            Form updateServiceForm = new UpdateService();
            updateServiceForm.ShowDialog();
            this.Close();
        }

        private void dgvServiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInitUpdate.Enabled = true;
            foreach (DataGridViewRow row in dgvServiceList.SelectedRows)
            {
                txtID.Text = row.Cells["ServiceID"].Value.ToString();
            }
        }

        public static String transferID = "";
    }
}
