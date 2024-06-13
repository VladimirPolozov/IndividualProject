namespace WarehouseSystem
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
            this.WarehousesLabel = new System.Windows.Forms.Label();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseSystemDataSet1 = new WarehouseSystem.WarehouseSystemDataSet1();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehousesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entriesTableAdapter = new WarehouseSystem.WarehouseSystemDataSet1TableAdapters.EntriesTableAdapter();
            this.productsTableAdapter = new WarehouseSystem.WarehouseSystemDataSet1TableAdapters.ProductsTableAdapter();
            this.warehousesTableAdapter = new WarehouseSystem.WarehouseSystemDataSet1TableAdapters.WarehousesTableAdapter();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductWeightTextBox = new System.Windows.Forms.TextBox();
            this.ProductWeightLabel = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductThresholdValueTextBox = new System.Windows.Forms.TextBox();
            this.ProductThresholdValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsLabel.Location = new System.Drawing.Point(12, 9);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(87, 26);
            this.ProductsLabel.TabIndex = 0;
            this.ProductsLabel.Text = "Товары";
            this.ProductsLabel.Click += new System.EventHandler(this.ProductsLabel_Click);
            // 
            // WarehousesLabel
            // 
            this.WarehousesLabel.AutoSize = true;
            this.WarehousesLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehousesLabel.Location = new System.Drawing.Point(12, 333);
            this.WarehousesLabel.Name = "WarehousesLabel";
            this.WarehousesLabel.Size = new System.Drawing.Size(91, 26);
            this.WarehousesLabel.TabIndex = 14;
            this.WarehousesLabel.Text = "Склады";
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AutoGenerateColumns = false;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.thresholdValueDataGridViewTextBoxColumn});
            this.ProductsDataGridView.DataSource = this.productsBindingSource;
            this.ProductsDataGridView.Location = new System.Drawing.Point(17, 38);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(543, 278);
            this.ProductsDataGridView.TabIndex = 28;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // thresholdValueDataGridViewTextBoxColumn
            // 
            this.thresholdValueDataGridViewTextBoxColumn.DataPropertyName = "ThresholdValue";
            this.thresholdValueDataGridViewTextBoxColumn.HeaderText = "ThresholdValue";
            this.thresholdValueDataGridViewTextBoxColumn.Name = "thresholdValueDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.warehouseSystemDataSet1;
            // 
            // warehouseSystemDataSet1
            // 
            this.warehouseSystemDataSet1.DataSetName = "WarehouseSystemDataSet1";
            this.warehouseSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // WarehousesDataGridView
            // 
            this.WarehousesDataGridView.AllowUserToAddRows = false;
            this.WarehousesDataGridView.AllowUserToDeleteRows = false;
            this.WarehousesDataGridView.AutoGenerateColumns = false;
            this.WarehousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehousesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.adressDataGridViewTextBoxColumn});
            this.WarehousesDataGridView.DataSource = this.warehousesBindingSource;
            this.WarehousesDataGridView.Location = new System.Drawing.Point(17, 362);
            this.WarehousesDataGridView.Name = "WarehousesDataGridView";
            this.WarehousesDataGridView.ReadOnly = true;
            this.WarehousesDataGridView.Size = new System.Drawing.Size(519, 150);
            this.WarehousesDataGridView.TabIndex = 29;
            this.WarehousesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehousesDataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.warehouseSystemDataSet1;
            // 
            // entriesBindingSource
            // 
            this.entriesBindingSource.DataMember = "Entries";
            this.entriesBindingSource.DataSource = this.warehouseSystemDataSet1;
            // 
            // entriesTableAdapter
            // 
            this.entriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLabel.Location = new System.Drawing.Point(566, 38);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(165, 18);
            this.ProductNameLabel.TabIndex = 30;
            this.ProductNameLabel.Text = "Наименование (Name)";
            this.ProductNameLabel.Click += new System.EventHandler(this.ProductNameLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(566, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 31;
            // 
            // ProductWeightTextBox
            // 
            this.ProductWeightTextBox.Location = new System.Drawing.Point(566, 113);
            this.ProductWeightTextBox.Name = "ProductWeightTextBox";
            this.ProductWeightTextBox.Size = new System.Drawing.Size(245, 20);
            this.ProductWeightTextBox.TabIndex = 33;
            this.ProductWeightTextBox.TextChanged += new System.EventHandler(this.ProductWeightTextBox_TextChanged);
            // 
            // ProductWeightLabel
            // 
            this.ProductWeightLabel.AutoSize = true;
            this.ProductWeightLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductWeightLabel.Location = new System.Drawing.Point(566, 92);
            this.ProductWeightLabel.Name = "ProductWeightLabel";
            this.ProductWeightLabel.Size = new System.Drawing.Size(93, 18);
            this.ProductWeightLabel.TabIndex = 32;
            this.ProductWeightLabel.Text = "Вес (Weight)";
            this.ProductWeightLabel.Click += new System.EventHandler(this.ProductWeightLabel_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(566, 167);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(245, 20);
            this.ProductPriceTextBox.TabIndex = 35;
            this.ProductPriceTextBox.TextChanged += new System.EventHandler(this.ProductPriceTextBox_TextChanged);
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceLabel.Location = new System.Drawing.Point(566, 146);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(122, 18);
            this.ProductPriceLabel.TabIndex = 34;
            this.ProductPriceLabel.Text = "Стоимость (Price)";
            // 
            // ProductThresholdValueTextBox
            // 
            this.ProductThresholdValueTextBox.Location = new System.Drawing.Point(566, 223);
            this.ProductThresholdValueTextBox.Name = "ProductThresholdValueTextBox";
            this.ProductThresholdValueTextBox.Size = new System.Drawing.Size(245, 20);
            this.ProductThresholdValueTextBox.TabIndex = 37;
            this.ProductThresholdValueTextBox.TextChanged += new System.EventHandler(this.ProductThresholdValueTextBox_TextChanged);
            // 
            // ProductThresholdValue
            // 
            this.ProductThresholdValue.AutoSize = true;
            this.ProductThresholdValue.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductThresholdValue.Location = new System.Drawing.Point(566, 202);
            this.ProductThresholdValue.Name = "ProductThresholdValue";
            this.ProductThresholdValue.Size = new System.Drawing.Size(245, 18);
            this.ProductThresholdValue.TabIndex = 36;
            this.ProductThresholdValue.Text = "Пороговое кол-во (ThresholdValue)";
            this.ProductThresholdValue.Click += new System.EventHandler(this.ProductThresholdValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 715);
            this.Controls.Add(this.ProductThresholdValueTextBox);
            this.Controls.Add(this.ProductThresholdValue);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductWeightTextBox);
            this.Controls.Add(this.ProductWeightLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.WarehousesDataGridView);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.WarehousesLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label WarehousesLabel;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView WarehousesDataGridView;
        private WarehouseSystemDataSet1 warehouseSystemDataSet1;
        private System.Windows.Forms.BindingSource entriesBindingSource;
        private WarehouseSystemDataSet1TableAdapters.EntriesTableAdapter entriesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WarehouseSystemDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private WarehouseSystemDataSet1TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ProductWeightTextBox;
        private System.Windows.Forms.Label ProductWeightLabel;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductThresholdValueTextBox;
        private System.Windows.Forms.Label ProductThresholdValue;
    }
}

