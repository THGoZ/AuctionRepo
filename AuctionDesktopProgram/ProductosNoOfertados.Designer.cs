namespace AuctionDesktopProgram
{
    partial class ProductosNoOfertados
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelProdNoVendidos = new Label();
            label5 = new Label();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            label3 = new Label();
            labelProdVendidos = new Label();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelProdVendidosPorcentual = new Label();
            label7 = new Label();
            cyberGroupBox4 = new ReaLTaiizor.Controls.CyberGroupBox();
            label4 = new Label();
            labelProdNoVendidosPorcentual = new Label();
            label9 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            MainPanel = new Panel();
            ProductosDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            Id = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Nombre = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Descripcion = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PrecioBase = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            FechaSolicitud = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            infoTablePanel = new TableLayoutPanel();
            panel1 = new Panel();
            LoadinPanel = new Panel();
            LoadingProcess = new System.ComponentModel.BackgroundWorker();
            cyberGroupBox3.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            cyberGroupBox2.SuspendLayout();
            cyberGroupBox4.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            infoTablePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(20, 6);
            label1.Name = "label1";
            label1.Size = new Size(268, 29);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una subasta";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.ButtonFace;
            comboBox1.Location = new Point(20, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(738, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "No hay subastas finalizadas disponibles";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(23, 78);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(249, 20);
            label2.TabIndex = 5;
            label2.Text = "Ninguna subasta seleccionada...";
            // 
            // cyberGroupBox3
            // 
            cyberGroupBox3.Alpha = 20;
            cyberGroupBox3.Anchor = AnchorStyles.None;
            cyberGroupBox3.BackColor = Color.Transparent;
            cyberGroupBox3.Background = true;
            cyberGroupBox3.Background_WidthPen = 3F;
            cyberGroupBox3.BackgroundPen = false;
            cyberGroupBox3.ColorBackground = Color.FromArgb(64, 64, 64);
            cyberGroupBox3.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox3.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox3.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox3.Controls.Add(labelProdNoVendidos);
            cyberGroupBox3.Controls.Add(label5);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(461, 74);
            cyberGroupBox3.Margin = new Padding(3, 10, 3, 10);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 30;
            cyberGroupBox3.Size = new Size(383, 44);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 10;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // labelProdNoVendidos
            // 
            labelProdNoVendidos.AutoSize = true;
            labelProdNoVendidos.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdNoVendidos.ForeColor = Color.Gold;
            labelProdNoVendidos.Location = new Point(305, 0);
            labelProdNoVendidos.Name = "labelProdNoVendidos";
            labelProdNoVendidos.Size = new Size(39, 37);
            labelProdNoVendidos.TabIndex = 0;
            labelProdNoVendidos.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 13);
            label5.Name = "label5";
            label5.Size = new Size(300, 20);
            label5.TabIndex = 0;
            label5.Text = "N° DE PRODUCTOS NO VENDIDOS";
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.Anchor = AnchorStyles.None;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = false;
            cyberGroupBox1.ColorBackground = Color.FromArgb(64, 64, 64);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(label3);
            cyberGroupBox1.Controls.Add(labelProdVendidos);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(26, 74);
            cyberGroupBox1.Margin = new Padding(3, 10, 3, 10);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 30;
            cyberGroupBox1.Size = new Size(383, 44);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 11;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(278, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 37);
            label3.TabIndex = 0;
            label3.Text = "--";
            // 
            // labelProdVendidos
            // 
            labelProdVendidos.AutoSize = true;
            labelProdVendidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdVendidos.Location = new Point(2, 13);
            labelProdVendidos.Name = "labelProdVendidos";
            labelProdVendidos.Size = new Size(270, 20);
            labelProdVendidos.TabIndex = 0;
            labelProdVendidos.Text = "N° DE PRODUCTOS VENDIDOS";
            // 
            // cyberGroupBox2
            // 
            cyberGroupBox2.Alpha = 20;
            cyberGroupBox2.Anchor = AnchorStyles.None;
            cyberGroupBox2.BackColor = Color.Transparent;
            cyberGroupBox2.Background = true;
            cyberGroupBox2.Background_WidthPen = 3F;
            cyberGroupBox2.BackgroundPen = false;
            cyberGroupBox2.ColorBackground = Color.FromArgb(64, 64, 64);
            cyberGroupBox2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.Controls.Add(labelProdVendidosPorcentual);
            cyberGroupBox2.Controls.Add(label7);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(26, 10);
            cyberGroupBox2.Margin = new Padding(3, 10, 3, 10);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 30;
            cyberGroupBox2.Size = new Size(383, 44);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 13;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // labelProdVendidosPorcentual
            // 
            labelProdVendidosPorcentual.AutoSize = true;
            labelProdVendidosPorcentual.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdVendidosPorcentual.ForeColor = Color.Gold;
            labelProdVendidosPorcentual.Location = new Point(278, 0);
            labelProdVendidosPorcentual.Name = "labelProdVendidosPorcentual";
            labelProdVendidosPorcentual.Size = new Size(39, 37);
            labelProdVendidosPorcentual.TabIndex = 0;
            labelProdVendidosPorcentual.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(2, 13);
            label7.Name = "label7";
            label7.Size = new Size(237, 20);
            label7.TabIndex = 0;
            label7.Text = "PRODUCTOS VENDIDOS %";
            // 
            // cyberGroupBox4
            // 
            cyberGroupBox4.Alpha = 20;
            cyberGroupBox4.Anchor = AnchorStyles.None;
            cyberGroupBox4.BackColor = Color.Transparent;
            cyberGroupBox4.Background = true;
            cyberGroupBox4.Background_WidthPen = 3F;
            cyberGroupBox4.BackgroundPen = false;
            cyberGroupBox4.ColorBackground = Color.FromArgb(64, 64, 64);
            cyberGroupBox4.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox4.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox4.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox4.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox4.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox4.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox4.Controls.Add(label4);
            cyberGroupBox4.Controls.Add(labelProdNoVendidosPorcentual);
            cyberGroupBox4.Controls.Add(label9);
            cyberGroupBox4.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox4.Lighting = false;
            cyberGroupBox4.LinearGradient_Background = false;
            cyberGroupBox4.LinearGradientPen = false;
            cyberGroupBox4.Location = new Point(461, 10);
            cyberGroupBox4.Margin = new Padding(3, 10, 3, 10);
            cyberGroupBox4.Name = "cyberGroupBox4";
            cyberGroupBox4.PenWidth = 15;
            cyberGroupBox4.RGB = false;
            cyberGroupBox4.Rounding = true;
            cyberGroupBox4.RoundingInt = 30;
            cyberGroupBox4.Size = new Size(383, 44);
            cyberGroupBox4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox4.TabIndex = 12;
            cyberGroupBox4.Tag = "Cyber";
            cyberGroupBox4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox4.Timer_RGB = 300;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(303, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 37);
            label4.TabIndex = 1;
            label4.Text = "--";
            // 
            // labelProdNoVendidosPorcentual
            // 
            labelProdNoVendidosPorcentual.AutoSize = true;
            labelProdNoVendidosPorcentual.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdNoVendidosPorcentual.ForeColor = Color.Gold;
            labelProdNoVendidosPorcentual.Location = new Point(26, 42);
            labelProdNoVendidosPorcentual.Name = "labelProdNoVendidosPorcentual";
            labelProdNoVendidosPorcentual.Size = new Size(17, 15);
            labelProdNoVendidosPorcentual.TabIndex = 0;
            labelProdNoVendidosPorcentual.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(2, 13);
            label9.Name = "label9";
            label9.Size = new Size(267, 20);
            label9.TabIndex = 0;
            label9.Text = "PRODUCTOS NO VENDIDOS %";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton2.Location = new Point(348, 15);
            kryptonButton2.Margin = new Padding(3, 15, 3, 40);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Palette = kryptonCustomPaletteBase1;
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton2.Size = new Size(173, 47);
            kryptonButton2.TabIndex = 14;
            kryptonButton2.Values.Text = "Descargar Informe";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(ProductosDataGrid);
            MainPanel.Controls.Add(tableLayoutPanel1);
            MainPanel.Controls.Add(infoTablePanel);
            MainPanel.Controls.Add(panel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(871, 653);
            MainPanel.TabIndex = 15;
            // 
            // ProductosDataGrid
            // 
            ProductosDataGrid.AllowUserToAddRows = false;
            ProductosDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ProductosDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductosDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductosDataGrid.AutoGenerateColumns = false;
            ProductosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosDataGrid.BorderStyle = BorderStyle.None;
            ProductosDataGrid.ColumnHeadersHeight = 40;
            ProductosDataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, PrecioBase, FechaSolicitud });
            ProductosDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductosDataGrid.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            ProductosDataGrid.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            ProductosDataGrid.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            ProductosDataGrid.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            ProductosDataGrid.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            ProductosDataGrid.Location = new Point(49, 257);
            ProductosDataGrid.MultiSelect = false;
            ProductosDataGrid.Name = "ProductosDataGrid";
            ProductosDataGrid.Palette = kryptonCustomPaletteBase1;
            ProductosDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ProductosDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle6.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            ProductosDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            ProductosDataGrid.RowTemplate.Height = 30;
            ProductosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductosDataGrid.Size = new Size(779, 272);
            ProductosDataGrid.TabIndex = 18;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdProducto";
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.FillWeight = 50F;
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.True;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Width = 85;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 169;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            Descripcion.FillWeight = 110F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 186;
            // 
            // PrecioBase
            // 
            PrecioBase.DataPropertyName = "PrecioBase";
            dataGridViewCellStyle5.ForeColor = Color.LimeGreen;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle5;
            PrecioBase.HeaderText = "Precio base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.ReadOnly = true;
            PrecioBase.Width = 169;
            // 
            // FechaSolicitud
            // 
            FechaSolicitud.Checked = false;
            FechaSolicitud.DataPropertyName = "FechaSolicitud";
            FechaSolicitud.HeaderText = "Fecha de solicitud";
            FechaSolicitud.Name = "FechaSolicitud";
            FechaSolicitud.ReadOnly = true;
            FechaSolicitud.Width = 169;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(kryptonButton2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 536);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 0, 15);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(871, 117);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // infoTablePanel
            // 
            infoTablePanel.AutoScroll = true;
            infoTablePanel.AutoSize = true;
            infoTablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            infoTablePanel.ColumnCount = 2;
            infoTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoTablePanel.Controls.Add(cyberGroupBox3, 1, 1);
            infoTablePanel.Controls.Add(cyberGroupBox1, 0, 1);
            infoTablePanel.Controls.Add(cyberGroupBox4, 1, 0);
            infoTablePanel.Controls.Add(cyberGroupBox2, 0, 0);
            infoTablePanel.Dock = DockStyle.Top;
            infoTablePanel.Location = new Point(0, 103);
            infoTablePanel.Name = "infoTablePanel";
            infoTablePanel.RowCount = 2;
            infoTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoTablePanel.Size = new Size(871, 128);
            infoTablePanel.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 10, 5);
            panel1.Size = new Size(871, 103);
            panel1.TabIndex = 15;
            // 
            // LoadinPanel
            // 
            LoadinPanel.Dock = DockStyle.Fill;
            LoadinPanel.Location = new Point(0, 0);
            LoadinPanel.Name = "LoadinPanel";
            LoadinPanel.Size = new Size(871, 653);
            LoadinPanel.TabIndex = 0;
            // 
            // LoadingProcess
            // 
            LoadingProcess.DoWork += LoadingProcess_DoWork;
            LoadingProcess.RunWorkerCompleted += LoadingProcess_RunWorkerCompleted;
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(39, 42, 45);
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(39, 42, 45);
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
            // ProductosNoOfertados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(871, 653);
            Controls.Add(MainPanel);
            Controls.Add(LoadinPanel);
            Name = "ProductosNoOfertados";
            Text = "ProductosNoOfertados";
            Load += ProductosNoOfertados_Load;
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox3.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox2.PerformLayout();
            cyberGroupBox4.ResumeLayout(false);
            cyberGroupBox4.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            infoTablePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private Label labelProdNoVendidos;
        private Label label5;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private Label label3;
        private Label labelProdVendidos;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private Label labelProdVendidosPorcentual;
        private Label label7;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox4;
        private Label labelProdNoVendidosPorcentual;
        private Label label9;
        private Label label4;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Panel MainPanel;
        private Panel LoadinPanel;
        private Panel panel1;
        private TableLayoutPanel infoTablePanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDataGridView ProductosDataGrid;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private System.ComponentModel.BackgroundWorker LoadingProcess;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nombre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Descripcion;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn FechaSolicitud;
    }
}