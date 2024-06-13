using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Надежда\\Documents\\WarehouseSystemDB.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection connectionToDataBase;
        public SqlCommand command;

        public DataSet ProductDataSet;
        public SqlDataAdapter ProductDataAdapter;

        public DataSet WarehouseDataSet;
        public SqlDataAdapter WarehouseDataAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseSystemDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.warehouseSystemDBDataSet.Products);

        }
    }
}
