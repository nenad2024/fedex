using fedex.Api.Model.DTOs;
using Org.BouncyCastle.Asn1.Crmf;
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
using static fedex.Gui.Form1;

namespace fedex.Gui
{
    public partial class updateForm : Form
    {
        public event Action DataUpdated;
        public updateForm()
        {
            InitializeComponent();
            fillProductIdLabel();
        }
        private void fillProductIdLabel()
        {
            labelProductId.Text = ControlID.TextData;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (tbProductName.Text != "" && numericPrice.Text != "" &&
                tbDescription.Text != "" && numericStock.Text != "" && dateTimePicker1.Text != "")
            {
                var product = new ProductDTO
                {
                    ProductId = Convert.ToInt32(ControlID.TextData),
                    ProductName = tbProductName.Text,
                    Price = (int)(numericPrice.Value),
                    Description = tbDescription.Text,
                    StockQuantity = (int)(numericStock.Value),
                    CreatedAt = dateTimePicker1.Value.Date
                };

                try
                {
                    HttpClient client = new HttpClient();
                    var request = client
                       .PutAsJsonAsync($"https://localhost:7225/api/Product/UpdateProduct/{ControlID.TextData}", product);

                    request.Wait();

                    var response = request.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data UPDATED");
                        DataUpdated?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error updating product");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error updating product" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all text boxes!");
            }
        }
    }
}
