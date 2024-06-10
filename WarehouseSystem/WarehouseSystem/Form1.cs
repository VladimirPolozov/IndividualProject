using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseSystem
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Надежда\\source\\repos\\IndividualProject\\WarehouseSystem\\WarehouseSystem\\WarehouseSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public SqlCommand command;
        public SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            if (ProductNameTextBox.Text != "" && ProductWeightTextBox.Text != "" && ProductPriceTextBox.Text != "" && ProductTresholdValueTextBox.Text != "")
            {
                command = new SqlCommand("insert into Products(Nname,Weight,Price,TresholdValue) values(@name,@weight,@price,@tresholdValue", connection);
                connection.Open();
                command.Parameters.AddWithValue("@name", ProductNameTextBox.Text.ToString());
                command.Parameters.AddWithValue("@weight", ProductWeightTextBox.Text.ToString());
                command.Parameters.AddWithValue("@price", ProductPriceTextBox.Text.ToString());
                command.Parameters.AddWithValue("@tresholdValue", ProductTresholdValueTextBox.Text.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayProductsData();
                ClearProductsData();
            } else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseSystemDataSet.Warehouses' table. You can move, or remove it, as needed.
            // this.warehousesTableAdapter.Fill(this.warehouseSystemDataSet.Warehouses);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DisplayProductsData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Products", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ClearProductsData()
        {
            ProductNameTextBox.Text = "";
            ProductWeightTextBox.Text = "";
            ProductPriceTextBox.Text = "";
            ProductTresholdValueTextBox.Text = "";
        }
    }
}
