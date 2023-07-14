using Services.Helper;
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
    public partial class CatListCustomer : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();
        public CatListCustomer()
        {
            InitializeComponent();
            initCatListCustomer();
        }

        private void initCatListCustomer()
        {
            var listCat = _catHelper.GetAll();
            dgvCatListCustomer.DataSource = new BindingSource { DataSource = listCat };
        }
        private void btnBackCustomer_Click(object sender, EventArgs e)
        {
            Form home = new Home();
            this.Hide();
            home.Show();
            this.Close();
        }
    }
}
