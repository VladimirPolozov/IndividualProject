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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseSystemDataSet = new WarehouseSystem.WarehouseSystemDataSet();
            this.productsTableAdapter = new WarehouseSystem.WarehouseSystemDataSetTableAdapters.ProductsTableAdapter();
            this.WarehousesLabel = new System.Windows.Forms.Label();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousesTableAdapter = new WarehouseSystem.WarehouseSystemDataSetTableAdapters.WarehousesTableAdapter();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.fKEntriesWarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entriesTableAdapter = new WarehouseSystem.WarehouseSystemDataSetTableAdapters.EntriesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEntriesWarehousesBindingSource)).BeginInit();
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.warehouseSystemDataSet;
            // 
            // warehouseSystemDataSet
            // 
            this.warehouseSystemDataSet.DataSetName = "WarehouseSystemDataSet";
            this.warehouseSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // WarehousesLabel
            // 
            this.WarehousesLabel.AutoSize = true;
            this.WarehousesLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehousesLabel.Location = new System.Drawing.Point(12, 320);
            this.WarehousesLabel.Name = "WarehousesLabel";
            this.WarehousesLabel.Size = new System.Drawing.Size(91, 26);
            this.WarehousesLabel.TabIndex = 14;
            this.WarehousesLabel.Text = "Склады";
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.warehouseSystemDataSet;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
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
            this.ProductsDataGridView.Location = new System.Drawing.Point(17, 39);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(443, 278);
            this.ProductsDataGridView.TabIndex = 28;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // fKEntriesWarehousesBindingSource
            // 
            this.fKEntriesWarehousesBindingSource.DataMember = "FK_Entries_Warehouses";
            this.fKEntriesWarehousesBindingSource.DataSource = this.warehousesBindingSource;
            // 
            // entriesTableAdapter
            // 
            this.entriesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // thresholdValueDataGridViewTextBoxColumn
            // 
            this.thresholdValueDataGridViewTextBoxColumn.DataPropertyName = "ThresholdValue";
            this.thresholdValueDataGridViewTextBoxColumn.HeaderText = "ThresholdValue";
            this.thresholdValueDataGridViewTextBoxColumn.Name = "thresholdValueDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 715);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.WarehousesLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEntriesWarehousesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsLabel;
        private WarehouseSystemDataSet warehouseSystemDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WarehouseSystemDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label WarehousesLabel;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private WarehouseSystemDataSetTableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.BindingSource fKEntriesWarehousesBindingSource;
        private WarehouseSystemDataSetTableAdapters.EntriesTableAdapter entriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdValueDataGridViewTextBoxColumn;
    }
}

