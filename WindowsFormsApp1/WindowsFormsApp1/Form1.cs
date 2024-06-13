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

        public int ChosenProductId { get; set; }
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
            string selectQuery = "SELECT * FROM Products";
            ProductDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            ProductDataSet = new DataSet();
            ProductDataAdapter.Fill(ProductDataSet, "Products");
            ProductsDataGridView.DataSource = ProductDataSet.Tables["Products"];
            ProductsDataGridView.CellClick += new DataGridViewCellEventHandler(ProductsDataGridView_CellContentClick);
            ProductsDataGridView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(ProductsDataGridView_OnRowHeaderMouseClick);

        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsDataGridView_OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = ProductsDataGridView.SelectedRows[0];
            ChosenProductId = int.Parse(selectedRow.Cells[0].Value.ToString());
            ProductNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
            ProductWeightTextBox.Text = selectedRow.Cells[2].Value.ToString();
            ProductPriceTextBox.Text = selectedRow.Cells[3].Value.ToString();
            ProductThresholdValueTextBox.Text = selectedRow.Cells[4].Value.ToString();

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

        private void ProductThresholdValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductThresholdValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrWhiteSpace(ProductNameTextBox.Text) )
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("insert into Products(Name,Weight,Price,ThresholdValue) values(@Name,@Weight,@Price,@ThresholdValue)", connectionToDataBase);
                command.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                command.Parameters.AddWithValue("@Weight", ProductWeightTextBox.Text);
                command.Parameters.AddWithValue("@Price", ProductPriceTextBox.Text);
                command.Parameters.AddWithValue("@ThresholdValue", ProductThresholdValueTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show($"Товар {ProductNameTextBox.Text} добавлен в базу данных", "Сообщение");
                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
            } else
            {
                MessageBox.Show("Поле \"Наименование\" не может быть пустым. Заполните его", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeProductButtton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("update Products set Name=@Name,Weight=@Weight,Price=@Price,ThresholdValue=@ThresholdValue", connectionToDataBase);
                command.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                command.Parameters.AddWithValue("@Weight", ProductWeightTextBox.Text);
                command.Parameters.AddWithValue("@Price", ProductPriceTextBox.Text);
                command.Parameters.AddWithValue("@ThresholdValue", ProductThresholdValueTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show($"Данные о товаре {ProductNameTextBox.Text} обновлены", "Сообщение");
                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
            } else
            {
                MessageBox.Show("Поле \"Наименование\" не может быть пустым. Заполните его", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("delete Products where Id=@Id", connectionToDataBase);
                command.Parameters.AddWithValue("@Id", ChosenProductId);
                command.ExecuteNonQuery();

                MessageBox.Show($"Товар был {ProductNameTextBox.Text} удалён", "Сообщение");
                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
            } else
            {
                MessageBox.Show("Вы не выбрали товар. Выберите товар, который хотите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataInProductsDataGridView()
        {
            string selectQuery = "SELECT * FROM Products";
            ProductDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            ProductDataSet = new DataSet();
            ProductDataAdapter.Fill(ProductDataSet, "Products");
            ProductsDataGridView.DataSource = ProductDataSet.Tables["Products"];
        }

        private void ClearProductsFields()
        {
            ProductNameTextBox.Text = "";
            ProductWeightTextBox.Text = "";
            ProductPriceTextBox.Text = "";
            ProductThresholdValueTextBox.Text = "";
        }
    }
}
