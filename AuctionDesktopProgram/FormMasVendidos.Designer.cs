namespace AuctionDesktopProgram
{
    partial class FormMasVendidos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            NombreProducto = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            NombreGanador = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ApellidoGanador = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PrecioBase = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            MontoFinal = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            GananciaVendedor = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Column1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelIdProductoMasVendido = new Label();
            label1 = new Label();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelIdVendedorProducto = new Label();
            label3 = new Label();
            label4 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LoadingPanel = new Panel();
            LoadingProcess = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            cyberGroupBox3.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.AllowUserToAddRows = false;
            kryptonDataGridView1.AllowUserToDeleteRows = false;
            kryptonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 36;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, NombreGanador, ApellidoGanador, PrecioBase, MontoFinal, GananciaVendedor, Column1 });
            tableLayoutPanel1.SetColumnSpan(kryptonDataGridView1, 2);
            kryptonDataGridView1.Dock = DockStyle.Fill;
            kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            kryptonDataGridView1.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            kryptonDataGridView1.Location = new Point(93, 191);
            kryptonDataGridView1.MultiSelect = false;
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Palette = kryptonCustomPaletteBase1;
            kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDataGridView1.RowHeadersVisible = false;
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kryptonDataGridView1.Size = new Size(718, 368);
            kryptonDataGridView1.TabIndex = 1;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.DefaultCellStyle = dataGridViewCellStyle1;
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 102;
            // 
            // NombreGanador
            // 
            NombreGanador.DataPropertyName = "NombreGanador";
            NombreGanador.DefaultCellStyle = dataGridViewCellStyle2;
            NombreGanador.HeaderText = "Nombre";
            NombreGanador.Name = "NombreGanador";
            NombreGanador.ReadOnly = true;
            NombreGanador.Width = 103;
            // 
            // ApellidoGanador
            // 
            ApellidoGanador.DataPropertyName = "ApellidoGanador";
            ApellidoGanador.DefaultCellStyle = dataGridViewCellStyle3;
            ApellidoGanador.HeaderText = "Apellido";
            ApellidoGanador.Name = "ApellidoGanador";
            ApellidoGanador.ReadOnly = true;
            ApellidoGanador.Width = 102;
            // 
            // PrecioBase
            // 
            PrecioBase.DataPropertyName = "PrecioBase";
            dataGridViewCellStyle4.ForeColor = Color.Lime;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle4;
            PrecioBase.HeaderText = "Precio Base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.ReadOnly = true;
            PrecioBase.Width = 103;
            // 
            // MontoFinal
            // 
            MontoFinal.DataPropertyName = "MontoFinal";
            dataGridViewCellStyle5.ForeColor = Color.Lime;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            MontoFinal.DefaultCellStyle = dataGridViewCellStyle5;
            MontoFinal.HeaderText = "Monto final";
            MontoFinal.Name = "MontoFinal";
            MontoFinal.ReadOnly = true;
            MontoFinal.Width = 102;
            // 
            // GananciaVendedor
            // 
            GananciaVendedor.DataPropertyName = "GananciaVendedor";
            dataGridViewCellStyle6.ForeColor = Color.Lime;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            GananciaVendedor.DefaultCellStyle = dataGridViewCellStyle6;
            GananciaVendedor.HeaderText = "Ganacia del vendedor";
            GananciaVendedor.Name = "GananciaVendedor";
            GananciaVendedor.ReadOnly = true;
            GananciaVendedor.Width = 103;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "GananciaEmpresa";
            dataGridViewCellStyle7.ForeColor = Color.Lime;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            Column1.DefaultCellStyle = dataGridViewCellStyle7;
            Column1.HeaderText = "Ganancia de la empresa";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 102;
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
            // cyberGroupBox3
            // 
            cyberGroupBox3.Alpha = 20;
            cyberGroupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cyberGroupBox3.AutoSize = true;
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
            cyberGroupBox3.Controls.Add(labelIdProductoMasVendido);
            cyberGroupBox3.Controls.Add(label1);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(355, 3);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.Padding = new Padding(20, 0, 0, 10);
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 30;
            cyberGroupBox3.Size = new Size(338, 47);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 11;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // labelIdProductoMasVendido
            // 
            labelIdProductoMasVendido.AutoSize = true;
            labelIdProductoMasVendido.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdProductoMasVendido.ForeColor = Color.Gold;
            labelIdProductoMasVendido.Location = new Point(296, 0);
            labelIdProductoMasVendido.Name = "labelIdProductoMasVendido";
            labelIdProductoMasVendido.Size = new Size(39, 37);
            labelIdProductoMasVendido.TabIndex = 0;
            labelIdProductoMasVendido.Text = "--";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 13);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTO MAS RENTABLE";
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.Anchor = AnchorStyles.Right;
            cyberGroupBox1.AutoSize = true;
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
            cyberGroupBox1.Controls.Add(labelIdVendedorProducto);
            cyberGroupBox1.Controls.Add(label3);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(3, 3);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.Padding = new Padding(20, 0, 0, 10);
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 30;
            cyberGroupBox1.Size = new Size(346, 47);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 12;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // labelIdVendedorProducto
            // 
            labelIdVendedorProducto.AutoSize = true;
            labelIdVendedorProducto.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdVendedorProducto.ForeColor = Color.Gold;
            labelIdVendedorProducto.Location = new Point(304, 0);
            labelIdVendedorProducto.Name = "labelIdVendedorProducto";
            labelIdVendedorProducto.Size = new Size(39, 37);
            labelIdVendedorProducto.TabIndex = 0;
            labelIdVendedorProducto.Text = "--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 13);
            label3.Name = "label3";
            label3.Size = new Size(266, 20);
            label3.TabIndex = 0;
            label3.Text = "COMPRADOR DEL PRODUCTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(93, 22);
            label4.Name = "label4";
            label4.Size = new Size(718, 29);
            label4.TabIndex = 13;
            label4.Text = "Productos mas rentables";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton1.Enabled = false;
            kryptonButton1.Location = new Point(291, 13);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Palette = kryptonCustomPaletteBase1;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton1.Size = new Size(173, 47);
            kryptonButton1.TabIndex = 14;
            kryptonButton1.Values.Text = "Descargar informe";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(tableLayoutPanel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(905, 643);
            MainPanel.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(kryptonDataGridView1, 2, 3);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 20, 0, 0);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.079027F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.079027F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.34042F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5015192F));
            tableLayoutPanel1.Size = new Size(905, 643);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(93, 52);
            label2.Margin = new Padding(3, 0, 3, 10);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(500, 20);
            label2.TabIndex = 15;
            label2.Text = "Aqui podras crear y ver detalles de las subastas";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(kryptonButton1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(93, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 75);
            panel1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(cyberGroupBox1);
            flowLayoutPanel1.Controls.Add(cyberGroupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(93, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(718, 100);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // LoadingPanel
            // 
            LoadingPanel.Dock = DockStyle.Fill;
            LoadingPanel.Location = new Point(0, 0);
            LoadingPanel.Name = "LoadingPanel";
            LoadingPanel.Size = new Size(905, 643);
            LoadingPanel.TabIndex = 15;
            // 
            // LoadingProcess
            // 
            LoadingProcess.DoWork += LoadingProcess_DoWork;
            LoadingProcess.RunWorkerCompleted += LoadingProcess_RunWorkerCompleted;
            // 
            // FormMasVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(905, 643);
            Controls.Add(MainPanel);
            Controls.Add(LoadingPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMasVendidos";
            Text = "FormMasVendidos";
            Load += FormMasVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox3.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private Label labelIdProductoMasVendido;
        private Label label1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private Label labelIdVendedorProducto;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Panel MainPanel;
        private Panel LoadingPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker LoadingProcess;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NombreProducto;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NombreGanador;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ApellidoGanador;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MontoFinal;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GananciaVendedor;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Column1;
    }
}