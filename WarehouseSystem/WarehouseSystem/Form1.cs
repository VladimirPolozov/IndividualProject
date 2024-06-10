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
            connection.Open();
             
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into ()" +
                " values('')";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Connection was successful!");
            }

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
