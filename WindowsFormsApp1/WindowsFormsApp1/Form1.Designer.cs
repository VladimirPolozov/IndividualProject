namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ChangeProductButtton = new System.Windows.Forms.Button();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.ProductThresholdValueTextBox = new System.Windows.Forms.TextBox();
            this.ProductThresholdValueLabel = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductWeightTextBox = new System.Windows.Forms.TextBox();
            this.ProductWeightLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.WarehouseAdressTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseAdressLabel = new System.Windows.Forms.Label();
            this.WarehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseNameLabel = new System.Windows.Forms.Label();
            this.WarehousesLabel = new System.Windows.Forms.Label();
            this.WarehousesDataGridView = new System.Windows.Forms.DataGridView();
            this.AddNewWarehouseButton = new System.Windows.Forms.Button();
            this.ChangeWarehouseButton = new System.Windows.Forms.Button();
            this.DeleteWarehouseButton = new System.Windows.Forms.Button();
            this.warehouseSystemDBDataSet = new WindowsFormsApp1.WarehouseSystemDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp1.WarehouseSystemDBDataSetTableAdapters.ProductsTableAdapter();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousesTableAdapter = new WindowsFormsApp1.WarehouseSystemDBDataSetTableAdapters.WarehousesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountInfoLabel = new System.Windows.Forms.Label();
            this.EntriesGridView = new System.Windows.Forms.DataGridView();
            this.entriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entriesTableAdapter = new WindowsFormsApp1.WarehouseSystemDBDataSetTableAdapters.EntriesTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseProductLabel = new System.Windows.Forms.Label();
            this.ChooseProductComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseWarehouseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsLabel.Location = new System.Drawing.Point(7, 9);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(87, 26);
            this.ProductsLabel.TabIndex = 1;
            this.ProductsLabel.Text = "Товары";
            this.ProductsLabel.Click += new System.EventHandler(this.ProductsLabel_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.AutoGenerateColumns = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.thresholdValueDataGridViewTextBoxColumn});
            this.ProductsDataGridView.DataSource = this.productsBindingSource;
            this.ProductsDataGridView.Location = new System.Drawing.Point(13, 39);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(594, 278);
            this.ProductsDataGridView.TabIndex = 2;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(826, 290);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(96, 27);
            this.DeleteProductButton.TabIndex = 51;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ChangeProductButtton
            // 
            this.ChangeProductButtton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeProductButtton.Location = new System.Drawing.Point(724, 290);
            this.ChangeProductButtton.Name = "ChangeProductButtton";
            this.ChangeProductButtton.Size = new System.Drawing.Size(96, 27);
            this.ChangeProductButtton.TabIndex = 50;
            this.ChangeProductButtton.Text = "Изменить";
            this.ChangeProductButtton.UseVisualStyleBackColor = true;
            this.ChangeProductButtton.Click += new System.EventHandler(this.ChangeProductButtton_Click);
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProductButton.Location = new System.Drawing.Point(622, 290);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(96, 27);
            this.AddNewProductButton.TabIndex = 49;
            this.AddNewProductButton.Text = "Добавить";
            this.AddNewProductButton.UseVisualStyleBackColor = true;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // ProductThresholdValueTextBox
            // 
            this.ProductThresholdValueTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.ProductThresholdValueTextBox.Location = new System.Drawing.Point(622, 224);
            this.ProductThresholdValueTextBox.Name = "ProductThresholdValueTextBox";
            this.ProductThresholdValueTextBox.Size = new System.Drawing.Size(300, 21);
            this.ProductThresholdValueTextBox.TabIndex = 48;
            this.ProductThresholdValueTextBox.TextChanged += new System.EventHandler(this.ProductThresholdValueTextBox_TextChanged);
            // 
            // ProductThresholdValueLabel
            // 
            this.ProductThresholdValueLabel.AutoSize = true;
            this.ProductThresholdValueLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductThresholdValueLabel.Location = new System.Drawing.Point(622, 203);
            this.ProductThresholdValueLabel.Name = "ProductThresholdValueLabel";
            this.ProductThresholdValueLabel.Size = new System.Drawing.Size(130, 18);
            this.ProductThresholdValueLabel.TabIndex = 47;
            this.ProductThresholdValueLabel.Text = "Пороговое кол-во";
            this.ProductThresholdValueLabel.Click += new System.EventHandler(this.ProductThresholdValueLabel_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceTextBox.Location = new System.Drawing.Point(622, 168);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(300, 21);
            this.ProductPriceTextBox.TabIndex = 46;
            this.ProductPriceTextBox.TextChanged += new System.EventHandler(this.ProductPriceTextBox_TextChanged);
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceLabel.Location = new System.Drawing.Point(622, 147);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(78, 18);
            this.ProductPriceLabel.TabIndex = 45;
            this.ProductPriceLabel.Text = "Стоимость";
            this.ProductPriceLabel.Click += new System.EventHandler(this.ProductPriceLabel_Click);
            // 
            // ProductWeightTextBox
            // 
            this.ProductWeightTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductWeightTextBox.Location = new System.Drawing.Point(622, 114);
            this.ProductWeightTextBox.Name = "ProductWeightTextBox";
            this.ProductWeightTextBox.Size = new System.Drawing.Size(300, 21);
            this.ProductWeightTextBox.TabIndex = 44;
            this.ProductWeightTextBox.TextChanged += new System.EventHandler(this.ProductWeightTextBox_TextChanged);
            // 
            // ProductWeightLabel
            // 
            this.ProductWeightLabel.AutoSize = true;
            this.ProductWeightLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductWeightLabel.Location = new System.Drawing.Point(622, 93);
            this.ProductWeightLabel.Name = "ProductWeightLabel";
            this.ProductWeightLabel.Size = new System.Drawing.Size(33, 18);
            this.ProductWeightLabel.TabIndex = 43;
            this.ProductWeightLabel.Text = "Вес";
            this.ProductWeightLabel.Click += new System.EventHandler(this.ProductWeightLabel_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(622, 60);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(300, 21);
            this.ProductNameTextBox.TabIndex = 42;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLabel.Location = new System.Drawing.Point(622, 39);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(113, 18);
            this.ProductNameLabel.TabIndex = 41;
            this.ProductNameLabel.Text = "Наименование";
            this.ProductNameLabel.Click += new System.EventHandler(this.ProductNameLabel_Click);
            // 
            // WarehouseAdressTextBox
            // 
            this.WarehouseAdressTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.WarehouseAdressTextBox.Location = new System.Drawing.Point(619, 441);
            this.WarehouseAdressTextBox.Name = "WarehouseAdressTextBox";
            this.WarehouseAdressTextBox.Size = new System.Drawing.Size(303, 21);
            this.WarehouseAdressTextBox.TabIndex = 56;
            this.WarehouseAdressTextBox.TextChanged += new System.EventHandler(this.WarehouseAdressTextBox_TextChanged);
            // 
            // WarehouseAdressLabel
            // 
            this.WarehouseAdressLabel.AutoSize = true;
            this.WarehouseAdressLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseAdressLabel.Location = new System.Drawing.Point(619, 420);
            this.WarehouseAdressLabel.Name = "WarehouseAdressLabel";
            this.WarehouseAdressLabel.Size = new System.Drawing.Size(51, 18);
            this.WarehouseAdressLabel.TabIndex = 55;
            this.WarehouseAdressLabel.Text = "Адрес";
            this.WarehouseAdressLabel.Click += new System.EventHandler(this.WarehouseAdressLabel_Click);
            // 
            // WarehouseNameTextBox
            // 
            this.WarehouseNameTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.WarehouseNameTextBox.Location = new System.Drawing.Point(619, 387);
            this.WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            this.WarehouseNameTextBox.Size = new System.Drawing.Size(303, 21);
            this.WarehouseNameTextBox.TabIndex = 54;
            this.WarehouseNameTextBox.TextChanged += new System.EventHandler(this.WarehouseNameTextBox_TextChanged);
            // 
            // WarehouseNameLabel
            // 
            this.WarehouseNameLabel.AutoSize = true;
            this.WarehouseNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseNameLabel.Location = new System.Drawing.Point(619, 366);
            this.WarehouseNameLabel.Name = "WarehouseNameLabel";
            this.WarehouseNameLabel.Size = new System.Drawing.Size(76, 18);
            this.WarehouseNameLabel.TabIndex = 53;
            this.WarehouseNameLabel.Text = "Название";
            this.WarehouseNameLabel.Click += new System.EventHandler(this.WarehouseNameLabel_Click);
            // 
            // WarehousesLabel
            // 
            this.WarehousesLabel.AutoSize = true;
            this.WarehousesLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehousesLabel.Location = new System.Drawing.Point(7, 337);
            this.WarehousesLabel.Name = "WarehousesLabel";
            this.WarehousesLabel.Size = new System.Drawing.Size(91, 26);
            this.WarehousesLabel.TabIndex = 52;
            this.WarehousesLabel.Text = "Склады";
            this.WarehousesLabel.Click += new System.EventHandler(this.WarehousesLabel_Click);
            // 
            // WarehousesDataGridView
            // 
            this.WarehousesDataGridView.AllowUserToAddRows = false;
            this.WarehousesDataGridView.AllowUserToDeleteRows = false;
            this.WarehousesDataGridView.AutoGenerateColumns = false;
            this.WarehousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehousesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.adressDataGridViewTextBoxColumn});
            this.WarehousesDataGridView.DataSource = this.warehousesBindingSource;
            this.WarehousesDataGridView.Location = new System.Drawing.Point(12, 366);
            this.WarehousesDataGridView.Name = "WarehousesDataGridView";
            this.WarehousesDataGridView.ReadOnly = true;
            this.WarehousesDataGridView.Size = new System.Drawing.Size(593, 278);
            this.WarehousesDataGridView.TabIndex = 60;
            this.WarehousesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehousesDataGridView_CellContentClick);
            // 
            // AddNewWarehouseButton
            // 
            this.AddNewWarehouseButton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewWarehouseButton.Location = new System.Drawing.Point(622, 617);
            this.AddNewWarehouseButton.Name = "AddNewWarehouseButton";
            this.AddNewWarehouseButton.Size = new System.Drawing.Size(96, 27);
            this.AddNewWarehouseButton.TabIndex = 57;
            this.AddNewWarehouseButton.Text = "Добавить";
            this.AddNewWarehouseButton.UseVisualStyleBackColor = true;
            this.AddNewWarehouseButton.Click += new System.EventHandler(this.AddNewWarehouseButton_Click);
            // 
            // ChangeWarehouseButton
            // 
            this.ChangeWarehouseButton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeWarehouseButton.Location = new System.Drawing.Point(724, 617);
            this.ChangeWarehouseButton.Name = "ChangeWarehouseButton";
            this.ChangeWarehouseButton.Size = new System.Drawing.Size(96, 27);
            this.ChangeWarehouseButton.TabIndex = 58;
            this.ChangeWarehouseButton.Text = "Изменить";
            this.ChangeWarehouseButton.UseVisualStyleBackColor = true;
            this.ChangeWarehouseButton.Click += new System.EventHandler(this.ChangeWarehouseButton_Click);
            // 
            // DeleteWarehouseButton
            // 
            this.DeleteWarehouseButton.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWarehouseButton.Location = new System.Drawing.Point(826, 617);
            this.DeleteWarehouseButton.Name = "DeleteWarehouseButton";
            this.DeleteWarehouseButton.Size = new System.Drawing.Size(96, 27);
            this.DeleteWarehouseButton.TabIndex = 59;
            this.DeleteWarehouseButton.Text = "Удалить";
            this.DeleteWarehouseButton.UseVisualStyleBackColor = true;
            this.DeleteWarehouseButton.Click += new System.EventHandler(this.DeleteWarehouseButton_Click);
            // 
            // warehouseSystemDBDataSet
            // 
            this.warehouseSystemDBDataSet.DataSetName = "WarehouseSystemDBDataSet";
            this.warehouseSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.warehouseSystemDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.warehouseSystemDBDataSet;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thresholdValueDataGridViewTextBoxColumn
            // 
            this.thresholdValueDataGridViewTextBoxColumn.DataPropertyName = "ThresholdValue";
            this.thresholdValueDataGridViewTextBoxColumn.HeaderText = "Порог";
            this.thresholdValueDataGridViewTextBoxColumn.Name = "thresholdValueDataGridViewTextBoxColumn";
            this.thresholdValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Width = 250;
            // 
            // CountInfoLabel
            // 
            this.CountInfoLabel.AutoSize = true;
            this.CountInfoLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountInfoLabel.Location = new System.Drawing.Point(7, 661);
            this.CountInfoLabel.Name = "CountInfoLabel";
            this.CountInfoLabel.Size = new System.Drawing.Size(287, 26);
            this.CountInfoLabel.TabIndex = 61;
            this.CountInfoLabel.Text = "Информация о количестве";
            this.CountInfoLabel.Click += new System.EventHandler(this.CountInfoLabel_Click);
            // 
            // EntriesGridView
            // 
            this.EntriesGridView.AutoGenerateColumns = false;
            this.EntriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.warehouseIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.EntriesGridView.DataSource = this.entriesBindingSource;
            this.EntriesGridView.Location = new System.Drawing.Point(12, 690);
            this.EntriesGridView.Name = "EntriesGridView";
            this.EntriesGridView.Size = new System.Drawing.Size(593, 218);
            this.EntriesGridView.TabIndex = 62;
            this.EntriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EntriesGridView_CellContentClick);
            // 
            // entriesBindingSource
            // 
            this.entriesBindingSource.DataMember = "Entries";
            this.entriesBindingSource.DataSource = this.warehouseSystemDBDataSet;
            // 
            // entriesTableAdapter
            // 
            this.entriesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // warehouseIdDataGridViewTextBoxColumn
            // 
            this.warehouseIdDataGridViewTextBoxColumn.DataPropertyName = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.HeaderText = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.Name = "warehouseIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // ChooseProductLabel
            // 
            this.ChooseProductLabel.AutoSize = true;
            this.ChooseProductLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseProductLabel.Location = new System.Drawing.Point(619, 690);
            this.ChooseProductLabel.Name = "ChooseProductLabel";
            this.ChooseProductLabel.Size = new System.Drawing.Size(48, 18);
            this.ChooseProductLabel.TabIndex = 63;
            this.ChooseProductLabel.Text = "Товар";
            this.ChooseProductLabel.Click += new System.EventHandler(this.ChooseProductLabel_Click);
            // 
            // ChooseProductComboBox
            // 
            this.ChooseProductComboBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.ChooseProductComboBox.FormattingEnabled = true;
            this.ChooseProductComboBox.Location = new System.Drawing.Point(619, 712);
            this.ChooseProductComboBox.Name = "ChooseProductComboBox";
            this.ChooseProductComboBox.Size = new System.Drawing.Size(303, 23);
            this.ChooseProductComboBox.TabIndex = 64;
            this.ChooseProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseProductComboBox_SelectedIndexChanged);
            // 
            // ChooseWarehouseComboBox
            // 
            this.ChooseWarehouseComboBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.ChooseWarehouseComboBox.FormattingEnabled = true;
            this.ChooseWarehouseComboBox.Location = new System.Drawing.Point(619, 767);
            this.ChooseWarehouseComboBox.Name = "ChooseWarehouseComboBox";
            this.ChooseWarehouseComboBox.Size = new System.Drawing.Size(303, 23);
            this.ChooseWarehouseComboBox.TabIndex = 66;
            this.ChooseWarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseWarehouseComboBox_SelectedIndexChanged);
            // 
            // ChooseWarehouseLabel
            // 
            this.ChooseWarehouseLabel.AutoSize = true;
            this.ChooseWarehouseLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseWarehouseLabel.Location = new System.Drawing.Point(619, 745);
            this.ChooseWarehouseLabel.Name = "ChooseWarehouseLabel";
            this.ChooseWarehouseLabel.Size = new System.Drawing.Size(50, 18);
            this.ChooseWarehouseLabel.TabIndex = 65;
            this.ChooseWarehouseLabel.Text = "Склад";
            this.ChooseWarehouseLabel.Click += new System.EventHandler(this.ChooseWarehouseLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 985);
            this.Controls.Add(this.ChooseWarehouseComboBox);
            this.Controls.Add(this.ChooseWarehouseLabel);
            this.Controls.Add(this.ChooseProductComboBox);
            this.Controls.Add(this.ChooseProductLabel);
            this.Controls.Add(this.EntriesGridView);
            this.Controls.Add(this.CountInfoLabel);
            this.Controls.Add(this.WarehousesDataGridView);
            this.Controls.Add(this.DeleteWarehouseButton);
            this.Controls.Add(this.ChangeWarehouseButton);
            this.Controls.Add(this.AddNewWarehouseButton);
            this.Controls.Add(this.WarehouseAdressTextBox);
            this.Controls.Add(this.WarehouseAdressLabel);
            this.Controls.Add(this.WarehouseNameTextBox);
            this.Controls.Add(this.WarehouseNameLabel);
            this.Controls.Add(this.WarehousesLabel);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ChangeProductButtton);
            this.Controls.Add(this.AddNewProductButton);
            this.Controls.Add(this.ProductThresholdValueTextBox);
            this.Controls.Add(this.ProductThresholdValueLabel);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductWeightTextBox);
            this.Controls.Add(this.ProductWeightLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.ProductsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ChangeProductButtton;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.TextBox ProductThresholdValueTextBox;
        private System.Windows.Forms.Label ProductThresholdValueLabel;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductWeightTextBox;
        private System.Windows.Forms.Label ProductWeightLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox WarehouseAdressTextBox;
        private System.Windows.Forms.Label WarehouseAdressLabel;
        private System.Windows.Forms.TextBox WarehouseNameTextBox;
        private System.Windows.Forms.Label WarehouseNameLabel;
        private System.Windows.Forms.Label WarehousesLabel;
        private System.Windows.Forms.DataGridView WarehousesDataGridView;
        private System.Windows.Forms.Button AddNewWarehouseButton;
        private System.Windows.Forms.Button ChangeWarehouseButton;
        private System.Windows.Forms.Button DeleteWarehouseButton;
        private WarehouseSystemDBDataSet warehouseSystemDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WarehouseSystemDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private WarehouseSystemDBDataSetTableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label CountInfoLabel;
        private System.Windows.Forms.DataGridView EntriesGridView;
        private System.Windows.Forms.BindingSource entriesBindingSource;
        private WarehouseSystemDBDataSetTableAdapters.EntriesTableAdapter entriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ChooseProductLabel;
        private System.Windows.Forms.ComboBox ChooseProductComboBox;
        private System.Windows.Forms.ComboBox ChooseWarehouseComboBox;
        private System.Windows.Forms.Label ChooseWarehouseLabel;
    }
}

