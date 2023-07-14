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
    public partial class AccountManager : Form
    {
        List<Account> AccountList;
        List<Account> FilteredAccountList = new List<Account>();
        AccountHelper AccountHelper = new AccountHelper();
        List<Tuple<int, string>> roleList = new List<Tuple<int, string>>()
        {
            new Tuple<int, string>(0, "Inactive"),
            new Tuple<int, string>(2, "Customer"),
        };

        public AccountManager()
        {
            InitializeComponent();

            AccountList = AccountHelper.GetAll();
            removeManager(AccountList);
            FilteredAccountList = AccountList;
            dgvUser.DataSource = new BindingSource() { DataSource = FilteredAccountList };

            cbFilterBy.ValueMember = "Item1";
            cbFilterBy.DisplayMember = "Item2";
            cbFilterBy.DataSource = roleList;

            dgvUser.Columns["Cats"].Visible = false;
            dgvUser.Columns["RegisteredServices"].Visible = false;
            btnUpdateStatus.Enabled = false;
        }

        public void removeManager(List<Account> filterList)
        {
            var account = filterList.FirstOrDefault(account => account.RoleId == 1);
            if (account != null)
            {
                filterList.Remove(account);
            }
        }

        private void filterAccountList(int roleID)
        {
            List<Account> resultList = new List<Account>();
            foreach (var account in AccountList)
            {
                if (account.RoleId == roleID)
                {
                    resultList.Add(account);
                }
            }

            FilteredAccountList = resultList.OrderBy(i => i.AccountId).ToList();
            dgvUser.DataSource = new BindingSource() { DataSource = FilteredAccountList };
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int roleId = int.Parse(cbFilterBy.SelectedValue.ToString());
            filterAccountList(roleId);
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != null && e.RowIndex >= 0)
            {
                var account = FilteredAccountList[e.RowIndex];
                txtAccountID.Text = account.AccountId.ToString();
                txtUsername.Text = account.Username;
                if (account.RoleId == 0)
                {
                    txtStatus.Text = "Inactive";
                }
                else
                {
                    txtStatus.Text = "Active";
                }

                txtAccountID.Enabled = false;
                txtUsername.Enabled = false;
                txtStatus.Enabled = false;
                btnUpdateStatus.Enabled = true;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            int accountID = int.Parse(txtAccountID.Text);

            if (accountID != 0)
            {
                string username = txtUsername.Text;
                string status = txtStatus.Text;

                if (status.Equals("Inactive"))
                {
                    DialogResult result = MessageBox.Show("Do you want to reactivate the account " + username + "?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var updateAccount = AccountList.FirstOrDefault(account => account.AccountId == accountID);
                        updateAccount.RoleId = 2;
                        AccountHelper.Update(updateAccount);
                        FilteredAccountList = AccountHelper.GetAll();
                        filterAccountList(0);

                        MessageBox.Show("Account updated successfully", "Attention", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update cancelled", "Attention", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to deactivate the account " + username + "?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var updateAccount = AccountList.FirstOrDefault(account => account.AccountId == accountID);
                        updateAccount.RoleId = 0;
                        AccountHelper.Update(updateAccount);
                        FilteredAccountList = AccountHelper.GetAll();
                        filterAccountList(2);

                        MessageBox.Show("Account updated successfully", "Attention", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update cancelled", "Attention", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid accountID", "Attention", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccountID.Text = "";
            txtUsername.Text = "";
            txtStatus.Text = "";

            txtAccountID.Enabled = true;
            txtUsername.Enabled = true;
            txtStatus.Enabled = true;
            btnUpdateStatus.Enabled = false;

            dgvUser.DataSource = new BindingSource() { DataSource = AccountList };
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form manager = new Manager();
            manager.ShowDialog();
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
    }
}
