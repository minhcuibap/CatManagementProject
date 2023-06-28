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
    public partial class CatList : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();

        public CatList()
        {
            InitializeComponent();
            initCatList();
        }

        private void initCatList()
        {
            var listCat = _catHelper.GetAll();
            dgvCatList.DataSource = new BindingSource { DataSource = listCat };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form manager = new Manager();
            this.Hide();
            manager.Show();
            this.Close();
        }
    }
}
