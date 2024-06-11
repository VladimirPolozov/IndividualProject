using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class Form1 : Form
    {
        public DataSet ProductDataSet;
        public SqlDataAdapter ProductDataAdapter;
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Надежда\\source\\repos\\IndividualProject\\WarehouseSystem\\WarehouseSystem\\WarehouseSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products";
            ProductDataAdapter = new SqlDataAdapter(selectQuery, connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(ProductDataAdapter);
            ProductDataSet = new DataSet();
            ProductDataAdapter.Fill(ProductDataSet, "Products");

            ProductsDataGridView.DataSource = ProductDataSet.Tables["Products"];
        }

        private void ProductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductWeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductTresholdValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductTresholdValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsDataGridView.SelectedRows[0];
                ProductNameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                ProductWeightTextBox.Text = selectedRow.Cells["Weight"].Value.ToString();
                ProductPriceTextBox.Text = selectedRow.Cells["Price"].Value.ToString();
                ProductTresholdValueTextBox.Text = selectedRow.Cells["TresholdValue"].Value.ToString();
            }

        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = ProductDataSet.Tables["Products"].NewRow();
            newRow["Name"] = ProductNameTextBox.Text;
            newRow["Weight"] = int.Parse(ProductWeightTextBox.Text);
            newRow["Price"] = int.Parse(ProductPriceTextBox.Text);
            newRow["TresholdValue"] = int.Parse(ProductTresholdValueTextBox.Text);
            ProductDataSet.Tables["Products"].Rows.Add(newRow);

            ProductDataAdapter.Update(ProductDataSet, "Products");
            ProductDataSet.Tables["Products"].Clear();
            ProductDataAdapter.Fill(ProductDataSet, "Products");
        }

        private void ChangeProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = ProductsDataGridView.SelectedRows[0].Index;
                int productId = (int)ProductsDataGridView.Rows[selectedIndex].Cells["Id"].Value;

                DataRow row = ProductDataSet.Tables["Products"].Rows.Find(productId);
                row["Name"] = ProductNameTextBox.Text;
                row["Weight"] = int.Parse(ProductWeightTextBox.Text);
                row["Price"] = int.Parse(ProductPriceTextBox.Text);
                row["TresholdValue"] = int.Parse(ProductTresholdValueTextBox.Text);

                ProductDataAdapter.Update(ProductDataSet, "Products");
                ProductDataSet.Tables["Products"].Clear();
                ProductDataAdapter.Fill(ProductDataSet, "Products");
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = ProductsDataGridView.SelectedRows[0].Index;
                int entryId = (int)ProductsDataGridView.Rows[selectedIndex].Cells["Id"].Value;

                DataRow row = ProductDataSet.Tables["Products"].Rows.Find(entryId);
                row.Delete();

                ProductDataAdapter.Update(ProductDataSet, "Products");
                ProductDataSet.Tables["Products"].Clear();
                ProductDataAdapter.Fill(ProductDataSet, "Products");
            }
        }

        private void WarehousesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
