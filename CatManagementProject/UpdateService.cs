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
    public partial class UpdateService : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();

        public UpdateService()
        {
            InitializeComponent();
            initUpdateForm();
        }

        private void initUpdateForm()
        {
            txtID.Text = ServiceList.transferID.ToString();
        }

        private Boolean checkName(String name)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(name))
            {
                result = true;
            }
            return result;
        }

        private Boolean checkPrice(String price)
        {
            Boolean result = false;
            if (price.All(char.IsDigit))
            {
                int temp = -1;
                try
                {
                    temp = Int32.Parse(price);
                }
                catch (Exception ex)
                {
                    return result;
                }

                if (temp >= 0)
                {
                    result = true;
                }
            }
            return result;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var service = new Service();
            String idStr = txtID.Text;
            String name = txtName.Text;
            String priceStr = txtPrice.Text;

            int id = Convert.ToInt32(idStr);

            if (!checkName(name))
            {
                txtErrorMsg.Text = "Name is not valid!";
                return;
            }

            if (!checkPrice(priceStr))
            {
                txtErrorMsg.Text = "Price is not valid!";
                return;
            }
            int price = Convert.ToInt32(priceStr);

            try
            {
                txtErrorMsg.Text = "";
                service.ServiceId = id;
                service.ServiceName = name;
                service.ServicePrice = price;
                _serviceHelper.Update(service);
                txtErrorMsg.ForeColor = System.Drawing.Color.Green;
                txtErrorMsg.Text = "Updated Service Successfully";
                await Task.Delay(TimeSpan.FromSeconds(3));
                this.Hide();
                Form serviceListForm = new ServiceList();
                serviceListForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            String idStr = txtID.Text;
            int id = Convert.ToInt32(idStr);
            var listService = _serviceHelper.GetAll();
            Boolean check = listService.Any(x => x.ServiceId.Equals(id));
            Service service = listService.FirstOrDefault(x => x.ServiceId.Equals(id));
            var confirmResult = MessageBox.Show("Are you sure to delete this service? " +
                "This action cannot be undone.",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _serviceHelper.Delete(service);
                txtErrorMsg.ForeColor = System.Drawing.Color.Green;
                txtErrorMsg.Text = "Deleted Service Successfully";
            }
            else
            {
                txtErrorMsg.Text = "Delete Service Cancelled";
            }
            await Task.Delay(TimeSpan.FromSeconds(3));
            this.Hide();
            Form serviceListForm = new ServiceList();
            serviceListForm.ShowDialog();
            this.Close();
        }
    }
}
