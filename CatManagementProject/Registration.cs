using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatManagementProject
{
    public partial class Registration : Form
    {
        AccountHelper accountHelper = new AccountHelper();
        List<Account> accountList = new List<Account>();
        string usernameFormat = @"^[a-zA-Z0-9@]+$";
        string passwordFormat = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$";

        public Registration()
        {
            InitializeComponent();

            accountList = accountHelper.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string confirm = "";
            string fullname = "";
            Account newAccount = new Account();

            if (Utils.isValidUsername(txtUsername.Text, usernameFormat))
            {
                foreach (Account account in accountList)
                {
                    if (account.Username == txtUsername.Text)
                    {
                        MessageBox.Show("Duplicate username", "Attention", MessageBoxButtons.OK);
                        return;
                    }
                }
                username = txtUsername.Text;
            }
            else
            {
                MessageBox.Show("Invalid Username", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (Utils.isValidPassword(txtPassword.Text, passwordFormat))
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    password = txtPassword.Text;
                }
                else
                {
                    MessageBox.Show("Confirm doesn't match Password", "Attention", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Password must have 1 capital letter, 1 special character and a number", "Attention", MessageBoxButtons.OK);
                return;
            }

            if (Utils.isValidFullname(txtFullname.Text))
            {
                fullname = txtFullname.Text;
            }
            else
            {
                MessageBox.Show("Invalid Fullname", "Attention", MessageBoxButtons.OK);
                return;
            }

            Account lastAccount = accountList.Last();

            newAccount.AccountId = lastAccount.AccountId + 1;
            newAccount.Username = username;
            newAccount.Password = password;
            newAccount.Fullname = fullname;
            newAccount.RoleId = 2;

            accountHelper.Create(newAccount);
            accountList = accountHelper.GetAll();
            DialogResult result = MessageBox.Show("Account regiter successfully", "Attention", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtFullname.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
