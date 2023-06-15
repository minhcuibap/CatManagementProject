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
        public StaffDashboard()
        {
            InitializeComponent();
        }
    }
}
