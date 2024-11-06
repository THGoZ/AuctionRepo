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
            components = new System.ComponentModel.Container();
            ProductosDatagrid = new DataGridView();
            GanadoresdataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ProductosSOdatagrid = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            ((System.ComponentModel.ISupportInitialize)ProductosDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GanadoresdataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductosSOdatagrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductosDatagrid
            // 
            ProductosDatagrid.BackgroundColor = SystemColors.ActiveBorder;
            ProductosDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDatagrid.Location = new Point(11, 61);
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
            GanadoresdataGrid.Location = new Point(457, 61);
            GanadoresdataGrid.Name = "GanadoresdataGrid";
            GanadoresdataGrid.RowHeadersWidth = 51;
            GanadoresdataGrid.Size = new Size(423, 468);
            GanadoresdataGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 41);
            label1.TabIndex = 2;
            label1.Text = "Oferentes";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(602, 19);
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
            ProductosSOdatagrid.Location = new Point(907, 61);
            ProductosSOdatagrid.Name = "ProductosSOdatagrid";
            ProductosSOdatagrid.RowHeadersWidth = 51;
            ProductosSOdatagrid.Size = new Size(423, 468);
            ProductosSOdatagrid.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1003, 19);
            label3.Name = "label3";
            label3.Size = new Size(246, 41);
            label3.TabIndex = 5;
            label3.Text = "Productos sin Ofertas";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ProductosSOdatagrid);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ProductosDatagrid);
            panel1.Controls.Add(GanadoresdataGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 1022);
            panel1.TabIndex = 6;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2010;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 9F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(255, 180, 85);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 180, 85);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(255, 192, 192);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.Red;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 90F;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(1287, 1022);
            Controls.Add(panel1);
            GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            MinimumSize = new Size(775, 744);
            Name = "FormProductos";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)ProductosDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)GanadoresdataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductosSOdatagrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductosDatagrid;
        private DataGridView GanadoresdataGrid;
        private Label label1;
        private Label label2;
        private DataGridView ProductosSOdatagrid;
        private Label label3;
        private Panel panel1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}