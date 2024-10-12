using fedex.Api.Model.DTOs;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;


namespace fedex.Gui
{
    public partial class Form1 : Form
    {
        public static class ControlID
        {
            public static string TextData { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 & dataGridView1.SelectedRows.Count < 2)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = (selectedRow.Cells["ProductId"].Value).ToString();

                var confirmResult = MessageBox.Show("Are you sure?", "Confirm delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        HttpClient client = new HttpClient();
                        var request = client.DeleteAsync($"https://localhost:7225/api/Product/DeleteProduct/{cellValue}");
                        request.Wait();

                        var response = request.Result;

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Row is deleted!");
                            RefreshData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one row which you want to DELETE");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        public void RefreshData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7225/api/Product/GetProducts");

                var req = client.GetAsync(client.BaseAddress);
                req.Wait();

                var response = req.Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var emp = JsonConvert.DeserializeObject<List<ProductDTO>>(json);

                    dataGridView1.DataSource = emp;
                }
                else
                {
                    throw new Exception("Failed to retrieve data from API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check API!");
                Environment.Exit(1);
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 & dataGridView1.SelectedRows.Count < 2)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = (selectedRow.Cells["ProductId"].Value).ToString();
                ControlID.TextData = cellValue;
                updateForm form = new updateForm();
                form.DataUpdated += RefreshData;
                form.Show();
            }
            else
            {
                MessageBox.Show("Please select one row which you want to UPDATE");
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            createForm form = new createForm();
            form.DataUpdated += RefreshData;
            form.Show();
        }
    }
}