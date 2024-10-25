namespace AuctionDesktopProgram
{
    partial class FormProductos
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
            ProductosDatagrid = new DataGridView();
            GanadoresdataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ProductosSOdatagrid = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductosDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GanadoresdataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductosSOdatagrid).BeginInit();
            SuspendLayout();
            // 
            // ProductosDatagrid
            // 
            ProductosDatagrid.BackgroundColor = SystemColors.ActiveBorder;
            ProductosDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDatagrid.Location = new Point(12, 62);
            ProductosDatagrid.Name = "ProductosDatagrid";
            ProductosDatagrid.RowHeadersWidth = 51;
            ProductosDatagrid.Size = new Size(423, 468);
            ProductosDatagrid.TabIndex = 0;
            ProductosDatagrid.CellContentClick += ProductosDatagrid_CellContentClick;
            // 
            // GanadoresdataGrid
            // 
            GanadoresdataGrid.BackgroundColor = SystemColors.ActiveBorder;
            GanadoresdataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GanadoresdataGrid.Location = new Point(457, 62);
            GanadoresdataGrid.Name = "GanadoresdataGrid";
            GanadoresdataGrid.RowHeadersWidth = 51;
            GanadoresdataGrid.Size = new Size(423, 468);
            GanadoresdataGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 41);
            label1.TabIndex = 2;
            label1.Text = "Oferentes";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(602, 18);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 3;
            label2.Text = "Ganancias";
            label2.Click += label2_Click;
            // 
            // ProductosSOdatagrid
            // 
            ProductosSOdatagrid.BackgroundColor = SystemColors.ActiveBorder;
            ProductosSOdatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosSOdatagrid.Location = new Point(907, 62);
            ProductosSOdatagrid.Name = "ProductosSOdatagrid";
            ProductosSOdatagrid.RowHeadersWidth = 51;
            ProductosSOdatagrid.Size = new Size(423, 468);
            ProductosSOdatagrid.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1003, 18);
            label3.Name = "label3";
            label3.Size = new Size(246, 41);
            label3.TabIndex = 5;
            label3.Text = "Productos sin Ofertas";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1370, 700);
            Controls.Add(label3);
            Controls.Add(ProductosSOdatagrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GanadoresdataGrid);
            Controls.Add(ProductosDatagrid);
            MinimumSize = new Size(775, 747);
            Name = "FormProductos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)ProductosDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)GanadoresdataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductosSOdatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductosDatagrid;
        private DataGridView GanadoresdataGrid;
        private Label label1;
        private Label label2;
        private DataGridView ProductosSOdatagrid;
        private Label label3;
    }
}