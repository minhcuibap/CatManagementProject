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
    public partial class CreateService : Form
    {
        AccountHelper _accountHelper = new AccountHelper();
        CatHelper _catHelper = new CatHelper();
        RegisteredServiceHelper _registeredServiceHelper = new RegisteredServiceHelper();
        ServiceHelper _serviceHelper = new ServiceHelper();

        public CreateService()
        {
            InitializeComponent();
            initCreateForm();
        }

        private void initCreateForm()
        {
            txtID.Text = idGenerator().ToString();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
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
                _serviceHelper.Create(service);
                txtErrorMsg.ForeColor = System.Drawing.Color.Green;
                txtErrorMsg.Text = "Created Service Successfully";
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

        private int idGenerator()
        {
            List<Service> list = _serviceHelper.GetAll();
            int id = 0;
            int result = 1;
            if (!list.Any())
            {
                return id;
            }
            else
            {
                foreach (Service service in list)
                {
                    int idNumber = service.ServiceId;
                    if (result == idNumber)
                    {
                        result = idNumber + 1;
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            return result;
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
    }
}
