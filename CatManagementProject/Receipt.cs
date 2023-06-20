using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Services.Helper;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CatManagementProject
{
    public partial class Receipt : Form
    {
        CatManagementDBContext _dbContext = new CatManagementDBContext();
        RegisteredServiceHelper serviceHelper = new RegisteredServiceHelper();
        List<RegisteredService> registeredServiceList;
        public String Username { get; set; }
        public Receipt(String username)
        {
            InitializeComponent();
            Username = username;
            Login login = new Login();
            _dbContext = new CatManagementDBContext();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            int accountId = _dbContext.Accounts
           .Where(a => a.Username == Username)
           .Select(a => a.AccountId)
           .FirstOrDefault();



            var registeredServices = _dbContext.RegisteredServices
         .Where(rs => rs.AccountId == accountId)
         .Include(rs => rs.Account)
         .Include(rs => rs.Cat)
         .Include(rs => rs.Service)
         .Select(rs => new
         {
             RegisteredServiceId = rs.AccountId,
             AccountName = rs.Account.Fullname,
             CatId = rs.Cat.CatId,
             ServiceName = rs.Service.ServiceName,
             ServicePrice = rs.Service.ServicePrice,
             Status = rs.Status == 1 ? "done" : "not done"
         })
        .ToList();

            dgvReceipt.DataSource = new BindingSource() { DataSource = registeredServices };
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHome_click(object sender, EventArgs e)
        {
            String username = Username;
            this.Hide();
            Form home = new Home(username);
            home.ShowDialog();

        }
    }
}

