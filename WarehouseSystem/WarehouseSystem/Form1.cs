using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WarehouseSystem
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Надежда\\source\\repos\\IndividualProject\\WarehouseSystem\\WarehouseSystem\\WarehouseSystem.mdf;Integrated Security=True;Connect Timeout=30";
        public DataSet ProductDataSet;
        public DataSet WarehouseDataSet;
        public SqlDataAdapter ProductDataAdapter;
        public SqlDataAdapter WarehouseDataAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products";
            ProductDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            SqlCommandBuilder productCommandBuilder = new SqlCommandBuilder(ProductDataAdapter);
            ProductDataSet = new DataSet();
            ProductDataAdapter.Fill(ProductDataSet, "Products");
            ProductsDataGridView.DataSource = ProductDataSet.Tables["Products"];

            selectQuery = "SELECT * FROM Warehouses";
            WarehouseDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            SqlCommandBuilder warehousCommandBuilder = new SqlCommandBuilder(WarehouseDataAdapter);
            WarehouseDataSet = new DataSet();
            WarehouseDataAdapter.Fill(WarehouseDataSet, "Warehouses");
            WarehousesDataGridView.DataSource = WarehouseDataSet.Tables["Warehouses"];
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsDataGridView.SelectedRows[0];
            }
        }

        private void ProductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductWeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductThresholdValue_Click(object sender, EventArgs e)
        {

        }

        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductThresholdValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarehousesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
