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
    public partial class BanUserForm : Form
    {
        List<Account> AccountList;
        AccountHelper AccountHelper = new AccountHelper();
        public BanUserForm()
        {
            InitializeComponent();
            AccountList = AccountHelper.GetAll();
            dgvUser.DataSource = new BindingSource() { DataSource = AccountList };
            dgvUser.Columns["Cats"].Visible = false;
            dgvUser.Columns["RegisteredServices"].Visible = false;
        }
    }
}
