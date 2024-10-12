using fedex.Api.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fedex.Gui
{
    public partial class createForm : Form
    {
        public event Action DataUpdated;
        public createForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text != "" && numericPrice.Text != "" &&
               tbDescription.Text != "" && numericStock.Text != "" && dateTimePicker1.Text != "")
            {
                var product = new ProductDTO
                {
                    ProductName = tbProductName.Text,
                    Price = (int)(numericPrice.Value),
                    Description = tbDescription.Text,
                    StockQuantity = (int)(numericStock.Value),
                    CreatedAt = dateTimePicker1.Value.Date
                };

                try
                {
                    HttpClient client = new HttpClient();
                    var request = client.PostAsJsonAsync("https://localhost:7225/api/Product/CreateProduct", product);

                    request.Wait();

                    var response = request.Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data Created");
                        DataUpdated?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error creating product");
                    }


                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please fill all text boxes!");
            }
        }
    }
}
