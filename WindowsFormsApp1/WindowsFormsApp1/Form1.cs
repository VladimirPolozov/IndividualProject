using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Надежда\\source\\repos\\IndividualProjectV2\\WindowsFormsApp1\\WindowsFormsApp1\\WarehouseSystemDB.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection connectionToDataBase;
        public SqlCommand command;

        public int ChosenProductId { get; set; }
        public int ChosenWarehouseId { get; set; }

        public DataSet ProductDataSet;
        public DataSet WarehouseDataSet;
        public SqlDataAdapter ProductDataAdapter;
        public SqlDataAdapter WarehouseDataAdapter;
        public SqlDataAdapter EntiresDataAdapter;
        public DataTable EntriesTable;

        public SqlDataAdapter ProductComboBoxAdapter;
        public SqlDataAdapter WarehouseComboBoxAdapter;
        public DataTable ProductsTable;
        public DataTable WarehouseTable;

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
            ProductsDataGridView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(ProductsDataGridView_OnRowHeaderMouseClick);

            selectQuery = "SELECT * FROM Warehouses";
            WarehouseDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            WarehouseDataSet = new DataSet();
            WarehouseDataAdapter.Fill(WarehouseDataSet, "Warehouses");
            WarehousesDataGridView.DataSource = WarehouseDataSet.Tables["Warehouses"];
            WarehousesDataGridView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(WarehousesDataGridView_OnRowHeaderMouseClick);

            FillProductComboBox();
            FillWarehouseComboBox();
            FillEntriesDataGridView();
            EntriesGridView.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(EntriesGridView_OnRowHeaderMouseClick);
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

        private void WarehousesDataGridView_OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = WarehousesDataGridView.SelectedRows[0];
            ChosenWarehouseId = int.Parse(selectedRow.Cells[0].Value.ToString());
            WarehouseNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
            WarehouseAdressTextBox.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void EntriesGridView_OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*DataGridViewRow selectedRow = EntriesGridView.SelectedRows[0];
            ChooseProductComboBox.SelectedValue = int.Parse(selectedRow.Cells[4].Value.ToString());
            ChooseWarehouseComboBox.SelectedValue = int.Parse(selectedRow.Cells[5].Value.ToString());
            ProductCountTextBox.Text = selectedRow.Cells[3].Value.ToString();*/
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

                command = new SqlCommand("INSERT INTO Products(Name, Weight, Price, ThresholdValue) values(@Name, @Weight, @Price, @ThresholdValue)", connectionToDataBase);
                command.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                command.Parameters.AddWithValue("@Weight", ProductWeightTextBox.Text);
                command.Parameters.AddWithValue("@Price", ProductPriceTextBox.Text);
                command.Parameters.AddWithValue("@ThresholdValue", ProductThresholdValueTextBox.Text);
                command.ExecuteNonQuery();

                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
                FillProductComboBox();
                FillEntriesDataGridView();
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

                command = new SqlCommand("update Products set Name=@Name,Weight=@Weight,Price=@Price,ThresholdValue=@ThresholdValue WHERE Id=@Id", connectionToDataBase);
                command.Parameters.AddWithValue("@Id", ChosenProductId);
                command.Parameters.AddWithValue("@Name", ProductNameTextBox.Text);
                command.Parameters.AddWithValue("@Weight", ProductWeightTextBox.Text);
                command.Parameters.AddWithValue("@Price", ProductPriceTextBox.Text);
                command.Parameters.AddWithValue("@ThresholdValue", ProductThresholdValueTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show($"Данные о товаре {ProductNameTextBox.Text} обновлены", "Сообщение");
                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
                FillProductComboBox();
                FillEntriesDataGridView();
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

                command = new SqlCommand("DELETE Products where Id = @Id", connectionToDataBase);
                command.Parameters.AddWithValue("@Id", ChosenProductId);
                command.ExecuteNonQuery();

                command = new SqlCommand("DELETE Entries WHERE ProductId = @ProductId", connectionToDataBase);
                command.Parameters.AddWithValue("@ProductId", ChosenWarehouseId);
                command.ExecuteNonQuery();

                connectionToDataBase.Close();

                UpdateDataInProductsDataGridView();
                ClearProductsFields();
                FillProductComboBox();
                FillEntriesDataGridView();
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

        private void WarehousesLabel_Click(object sender, EventArgs e)
        {

        }

        private void WarehousesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WarehouseNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WarehouseAdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseAdressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewWarehouseButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WarehouseNameTextBox.Text))
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("INSERT INTO Warehouses(Name, Adress) values(@Name, @Adress)", connectionToDataBase);
                command.Parameters.AddWithValue("@Name", WarehouseNameTextBox.Text);
                command.Parameters.AddWithValue("@Adress", WarehouseAdressTextBox.Text);
                command.ExecuteNonQuery();

                connectionToDataBase.Close();

                UpdateDataInWarehousesDataGridView();
                ClearWarehousesFields();
                FillWarehouseComboBox();
                FillEntriesDataGridView();
            } else
            {
                MessageBox.Show("Поле Название (Name) не может быть пустым. Заполните его", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWarehouseButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WarehouseNameTextBox.Text))
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("UPDATE Warehouses SET Name = @Name, Adress = @Adress WHERE Id = @Id", connectionToDataBase);
                command.Parameters.AddWithValue("@Id", ChosenWarehouseId);
                command.Parameters.AddWithValue("@Name", WarehouseNameTextBox.Text);
                command.Parameters.AddWithValue("@Adress", WarehouseAdressTextBox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show($"Данные о складе {WarehouseNameTextBox.Text} обновлены", "Сообщение");
                connectionToDataBase.Close();

                UpdateDataInWarehousesDataGridView();
                ClearWarehousesFields();
                FillWarehouseComboBox();
                FillEntriesDataGridView();
            } else
            {
                MessageBox.Show("Поле Название (Name) не может быть пустым. Заполните его", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteWarehouseButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WarehouseNameTextBox.Text))
            {
                SqlConnection connectionToDataBase = new SqlConnection(connectionString);
                connectionToDataBase.Open();

                command = new SqlCommand("DELETE Warehouses WHERE Id = @Id", connectionToDataBase);
                command.Parameters.AddWithValue("@Id", ChosenWarehouseId);
                command.ExecuteNonQuery();

                command = new SqlCommand("DELETE Entries WHERE WarehouseId = @WarehouseId", connectionToDataBase);
                command.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
                command.ExecuteNonQuery();

                connectionToDataBase.Close();

                UpdateDataInWarehousesDataGridView();
                ClearWarehousesFields();
                FillWarehouseComboBox();
            } else
            {
                MessageBox.Show("Вы не выбрали склад. Выберите склад, который хотите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataInWarehousesDataGridView()
        {
            string selectQuery = "SELECT * FROM Warehouses";
            WarehouseDataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            WarehouseDataSet = new DataSet();
            WarehouseDataAdapter.Fill(WarehouseDataSet, "Warehouse");
            WarehousesDataGridView.DataSource = WarehouseDataSet.Tables["Warehouse"];
        }

        private void ClearWarehousesFields()
        {
            WarehouseNameTextBox.Text = "";
            WarehouseAdressTextBox.Text = "";
        }

        private void CountInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void EntriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChooseProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChooseProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseWarehouseLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChooseWarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillProductComboBox()
        {
            SqlConnection connectionToDataBase = new SqlConnection(connectionString);
            connectionToDataBase.Open();

            string query = "SELECT Id, Name FROM Products ORDER BY Name";
            ProductComboBoxAdapter = new SqlDataAdapter(query, connectionToDataBase);
            ProductsTable = new DataTable();
            ProductComboBoxAdapter.Fill(ProductsTable);

            ChooseProductComboBox.DataSource = ProductsTable;
            ChooseProductComboBox.DisplayMember = "Name";
            ChooseProductComboBox.ValueMember = "Id";
        }

        private void FillWarehouseComboBox()
        {
            SqlConnection connectionToDataBase = new SqlConnection(connectionString);
            connectionToDataBase.Open();

            string query = "SELECT Id, Name FROM Warehouses ORDER BY Name";
            WarehouseComboBoxAdapter = new SqlDataAdapter(query, connectionToDataBase);
            WarehouseTable = new DataTable();
            WarehouseComboBoxAdapter.Fill(WarehouseTable);

            ChooseWarehouseComboBox.DataSource = WarehouseTable;
            ChooseWarehouseComboBox.DisplayMember = "Name";
            ChooseWarehouseComboBox.ValueMember = "Id";
        }

        private void FillEntriesDataGridView()
        {
            SqlConnection connectionToDataBase = new SqlConnection(connectionString);
            connectionToDataBase.Open();

            string query = @"SELECT Entries.Id, Products.Name AS ProductName, Warehouses.Name AS WarehouseName, Entries.Count FROM Entries JOIN Products ON Entries.ProductId = Products.Id JOIN Warehouses ON Entries.WarehouseId = Warehouses.Id ORDER BY Entries.Id";

            EntiresDataAdapter = new SqlDataAdapter(query, connectionToDataBase);
            EntriesTable = new DataTable();
            EntiresDataAdapter.Fill(EntriesTable);
            EntriesGridView.DataSource = EntriesTable;
        }

        private void AddToWarehouseButton_Click(object sender, EventArgs e)
        {
            ChosenProductId = (int)ChooseProductComboBox.SelectedValue;
            ChosenWarehouseId = (int)ChooseWarehouseComboBox.SelectedValue;
            int inputedCount = int.Parse(ProductCountTextBox.Text);

            SqlConnection connectionToDataBase = new SqlConnection(connectionString);
            connectionToDataBase.Open();

            string selectQuery = "SELECT Count FROM Entries WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connectionToDataBase);
            selectCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
            selectCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
            object result = selectCommand.ExecuteScalar();

            if (result != null)
            {
                int currentCount = (int)result;
                int newCount = currentCount + inputedCount;

                string updateQuery = "UPDATE Entries SET Count = @Count WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connectionToDataBase);
                updateCommand.Parameters.AddWithValue("@Count", newCount);
                updateCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
                updateCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
                updateCommand.ExecuteNonQuery();
            } else
            {
                string insertQuery = "INSERT INTO Entries (ProductId, WarehouseId, Count) VALUES (@ProductId, @WarehouseId, @Count)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connectionToDataBase);
                insertCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
                insertCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
                insertCommand.Parameters.AddWithValue("@Count", inputedCount);
                insertCommand.ExecuteNonQuery();
            }

            FillEntriesDataGridView();
        }

        private void RemoveFromWarehouseButton_Click(object sender, EventArgs e)
        {
            ChosenProductId = (int)ChooseProductComboBox.SelectedValue;
            ChosenWarehouseId = (int)ChooseWarehouseComboBox.SelectedValue;
            int inputedCount = int.Parse(ProductCountTextBox.Text);

            SqlConnection connectionToDataBase = new SqlConnection(connectionString);
            connectionToDataBase.Open();

            string selectQuery = "SELECT Count FROM Entries WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connectionToDataBase);
            selectCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
            selectCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);

            object result = selectCommand.ExecuteScalar();

            if (result != null)
            {
                int currentCount = (int)result;
                int newCount = currentCount - inputedCount;

                if (newCount > 0)
                {
                    string updateQuery = "UPDATE Entries SET Count = @Count WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connectionToDataBase);
                    updateCommand.Parameters.AddWithValue("@Count", newCount);
                    updateCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
                    updateCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
                    updateCommand.ExecuteNonQuery();
                } else
                {
                    string deleteQuery = "DELETE FROM Entries WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connectionToDataBase);
                    deleteCommand.Parameters.AddWithValue("@ProductId", ChosenProductId);
                    deleteCommand.Parameters.AddWithValue("@WarehouseId", ChosenWarehouseId);
                    deleteCommand.ExecuteNonQuery();
                }
            }

            FillEntriesDataGridView();
        }
    }
}
