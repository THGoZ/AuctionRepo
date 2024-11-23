namespace AuctionDesktopProgram
{
    partial class FormVendidos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ProductoDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            LoadingProcess = new System.ComponentModel.BackgroundWorker();
            NombreProducto = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            NombreGanador = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ApellidoGanador = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PrecioBase = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            MontoFinal = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            GananciaVendedor = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            GananciaEmpresa = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductoDataGrid).BeginInit();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton1.Enabled = false;
            kryptonButton1.Location = new Point(347, 551);
            kryptonButton1.Margin = new Padding(3, 15, 3, 40);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Palette = kryptonCustomPaletteBase1;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton1.Size = new Size(173, 47);
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.Text = "Descargar informe";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(ProductoDataGrid, 1, 2);
            tableLayoutPanel1.Controls.Add(kryptonButton1, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 30, 0, 15);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(871, 653);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // ProductoDataGrid
            // 
            ProductoDataGrid.AllowUserToAddRows = false;
            ProductoDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ProductoDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductoDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductoDataGrid.AutoGenerateColumns = false;
            ProductoDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductoDataGrid.BorderStyle = BorderStyle.None;
            ProductoDataGrid.ColumnHeadersHeight = 40;
            ProductoDataGrid.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, NombreGanador, ApellidoGanador, PrecioBase, MontoFinal, GananciaVendedor, GananciaEmpresa });
            tableLayoutPanel1.SetColumnSpan(ProductoDataGrid, 3);
            ProductoDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductoDataGrid.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            ProductoDataGrid.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            ProductoDataGrid.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            ProductoDataGrid.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            ProductoDataGrid.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            ProductoDataGrid.Location = new Point(111, 132);
            ProductoDataGrid.MultiSelect = false;
            ProductoDataGrid.Name = "ProductoDataGrid";
            ProductoDataGrid.Palette = kryptonCustomPaletteBase1;
            ProductoDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ProductoDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle9.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            ProductoDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            ProductoDataGrid.RowTemplate.Height = 30;
            ProductoDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductoDataGrid.Size = new Size(645, 374);
            ProductoDataGrid.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 3);
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(30, 30);
            label3.Margin = new Padding(30, 0, 3, 5);
            label3.Name = "label3";
            label3.Size = new Size(271, 33);
            label3.TabIndex = 6;
            label3.Text = "Productos vendidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(30, 68);
            label2.Margin = new Padding(30, 0, 3, 15);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(311, 20);
            label2.TabIndex = 7;
            label2.Text = "Mostrando todos los productos vendidos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 42, 45);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 653);
            panel2.TabIndex = 9;
            // 
            // LoadingProcess
            // 
            LoadingProcess.DoWork += LoadingProcess_DoWork;
            LoadingProcess.RunWorkerCompleted += LoadingProcess_RunWorkerCompleted;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.DefaultCellStyle = dataGridViewCellStyle2;
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 92;
            // 
            // NombreGanador
            // 
            NombreGanador.DataPropertyName = "NombreGanador";
            NombreGanador.DefaultCellStyle = dataGridViewCellStyle3;
            NombreGanador.HeaderText = "Nombre";
            NombreGanador.Name = "NombreGanador";
            NombreGanador.ReadOnly = true;
            NombreGanador.Width = 92;
            // 
            // ApellidoGanador
            // 
            ApellidoGanador.DataPropertyName = "ApellidoGanador";
            ApellidoGanador.DefaultCellStyle = dataGridViewCellStyle4;
            ApellidoGanador.HeaderText = "Apellido";
            ApellidoGanador.Name = "ApellidoGanador";
            ApellidoGanador.ReadOnly = true;
            ApellidoGanador.Width = 92;
            // 
            // PrecioBase
            // 
            PrecioBase.DataPropertyName = "PrecioBase";
            dataGridViewCellStyle5.ForeColor = Color.Lime;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionForeColor = Color.PaleGreen;
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle5;
            PrecioBase.HeaderText = "Precio base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.ReadOnly = true;
            PrecioBase.Width = 92;
            // 
            // MontoFinal
            // 
            MontoFinal.DataPropertyName = "MontoFinal";
            dataGridViewCellStyle6.ForeColor = Color.Lime;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionForeColor = Color.PaleGreen;
            MontoFinal.DefaultCellStyle = dataGridViewCellStyle6;
            MontoFinal.HeaderText = "Monto final";
            MontoFinal.Name = "MontoFinal";
            MontoFinal.ReadOnly = true;
            MontoFinal.Width = 92;
            // 
            // GananciaVendedor
            // 
            GananciaVendedor.DataPropertyName = "GananciaVendedor";
            dataGridViewCellStyle7.ForeColor = Color.Lime;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionForeColor = Color.PaleGreen;
            GananciaVendedor.DefaultCellStyle = dataGridViewCellStyle7;
            GananciaVendedor.HeaderText = "Ganancia del vendedor";
            GananciaVendedor.Name = "GananciaVendedor";
            GananciaVendedor.ReadOnly = true;
            GananciaVendedor.Width = 92;
            // 
            // GananciaEmpresa
            // 
            GananciaEmpresa.DataPropertyName = "GananciaEmpresa";
            dataGridViewCellStyle8.ForeColor = Color.Lime;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionForeColor = Color.PaleGreen;
            GananciaEmpresa.DefaultCellStyle = dataGridViewCellStyle8;
            GananciaEmpresa.HeaderText = "Ganancia de la empresa";
            GananciaEmpresa.Name = "GananciaEmpresa";
            GananciaEmpresa.ReadOnly = true;
            GananciaEmpresa.Width = 92;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2010;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Width = 20;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.Padding = new Padding(10, -1, -1, 8);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Switch90;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = Color.FromArgb(200, 130, 40);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = Color.FromArgb(200, 130, 40);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Width = 5;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.Padding = new Padding(10, -1, -1, 10);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 16.75F);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.Rounding = 5F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Back.Color1 = Color.FromArgb(202, 145, 65);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StatePressed.Back.Color2 = Color.FromArgb(202, 145, 65);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCheckedTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCheckedTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StatePressed.Back.Color1 = Color.FromArgb(202, 145, 65);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StatePressed.Back.Color2 = Color.FromArgb(202, 145, 65);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 9F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(23, 23, 23);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(23, 23, 23);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(23, 23, 23);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(23, 23, 23);
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color2 = Color.White;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 180, 85);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.Rounding = 10F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Content.LongText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Content.Padding = new Padding(7, -1, -1, -1);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Content.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 10F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.Padding = new Padding(7, -1, -1, -1);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateNormal.Content.LongText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(255, 192, 192);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.Red;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 90F;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // FormVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(871, 653);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(39, 42, 45);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVendidos";
            Text = "FormVendidos";
            Load += FormVendidos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductoDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDataGridView ProductoDataGrid;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker LoadingProcess;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NombreProducto;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NombreGanador;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ApellidoGanador;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MontoFinal;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GananciaVendedor;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GananciaEmpresa;
    }
}