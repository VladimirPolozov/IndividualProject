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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseSystemDBDataSet = new WindowsFormsApp1.WarehouseSystemDBDataSet();
            this.productsTableAdapter = new WindowsFormsApp1.WarehouseSystemDBDataSetTableAdapters.ProductsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsLabel.Location = new System.Drawing.Point(12, 9);
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.warehouseSystemDBDataSet;
            // 
            // warehouseSystemDBDataSet
            // 
            this.warehouseSystemDBDataSet.DataSetName = "WarehouseSystemDBDataSet";
            this.warehouseSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.ProductThresholdValueTextBox.Location = new System.Drawing.Point(622, 224);
            this.ProductThresholdValueTextBox.Name = "ProductThresholdValueTextBox";
            this.ProductThresholdValueTextBox.Size = new System.Drawing.Size(300, 20);
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
            this.ProductPriceTextBox.Location = new System.Drawing.Point(622, 168);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(300, 20);
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
            this.ProductWeightTextBox.Location = new System.Drawing.Point(622, 114);
            this.ProductWeightTextBox.Name = "ProductWeightTextBox";
            this.ProductWeightTextBox.Size = new System.Drawing.Size(300, 20);
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
            this.ProductNameTextBox.Location = new System.Drawing.Point(622, 60);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(300, 20);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 468);
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
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private WarehouseSystemDBDataSet warehouseSystemDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WarehouseSystemDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdValueDataGridViewTextBoxColumn;
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
    }
}

