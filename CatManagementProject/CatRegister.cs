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
    public partial class CatRegister : Form
    {
        public String Username { get; set; }
        List<Cat> CatList;
        CatHelper CatHelper = new CatHelper();

        public CatRegister()
        {
            InitializeComponent();
        }

        public CatRegister(String username)
        {
            InitializeComponent();
            Username = username;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int catID = Int32.Parse(textCatID.Text.Trim());
            int? accountID = Int32.Parse(textAccountID.Text.Trim());
            string breed = textBreed.Text.Trim();
            string color = textColor.Text.Trim();
            string sex = textSex.Text.Trim();

            bool checkSex = textSex.Text.Equals("Meow") || textSex.Text.Equals("Femeow");
            bool checkcatID = !CatHelper.GetAll().Any(b => b.CatId.Equals(catID));

            if (checkcatID && checkSex)
            {
                Cat cat = new Cat();
                cat.CatId = catID;
                cat.AccountId = accountID;
                cat.Sex = sex;
                cat.Color = color;
                cat.Breed = breed;
                CatHelper.Create(cat);

                MessageBox.Show("Registered", "Notice", MessageBoxButtons.OK);

                textAccountID.Text = string.Empty;
                textBreed.Text = string.Empty;
                textColor.Text = string.Empty;
                textSex.Text = string.Empty;
                textCatID.Text = string.Empty;
            }
            else
                MessageBox.Show("Error, can not register.", "Warning", MessageBoxButtons.OK);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textAccountID.Text = string.Empty;
            textBreed.Text = string.Empty;
            textColor.Text = string.Empty;
            textSex.Text = string.Empty;
            textCatID.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = Username;
            this.Hide();
            Form home = new Home(username);
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = Username;
            this.Hide();
            Form catRegister = new CatRegister(username);
            catRegister.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
