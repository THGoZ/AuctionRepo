using Krypton.Toolkit;

namespace AuctionDesktopProgram
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            SubastaDataGrid = new KryptonDataGridView();
            IdSubasta = new KryptonDataGridViewTextBoxColumn();
            descripcion = new KryptonDataGridViewTextBoxColumn();
            FechaInicio = new KryptonDataGridViewTextBoxColumn();
            FechaCierre = new KryptonDataGridViewTextBoxColumn();
            formapago = new KryptonDataGridViewTextBoxColumn();
            modoentrega = new KryptonDataGridViewTextBoxColumn();
            estado = new KryptonDataGridViewTextBoxColumn();
            Editar = new KryptonDataGridViewButtonColumn();
            VerResumen = new KryptonDataGridViewButtonColumn();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            panel1 = new Panel();
            btnCrearSubasta = new KryptonButton();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtFiltroDescipcion = new KryptonTextBox();
            btnBuscar = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)SubastaDataGrid).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SubastaDataGrid
            // 
            SubastaDataGrid.AllowUserToAddRows = false;
            SubastaDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            SubastaDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SubastaDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubastaDataGrid.AutoGenerateColumns = false;
            SubastaDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubastaDataGrid.BorderStyle = BorderStyle.None;
            SubastaDataGrid.ColumnHeadersHeight = 40;
            SubastaDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdSubasta, descripcion, FechaInicio, FechaCierre, formapago, modoentrega, estado, Editar, VerResumen });
            SubastaDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            SubastaDataGrid.GridStyles.Style = DataGridViewStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.GridStyles.StyleColumn = GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleDataCells = GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleRow = GridStyle.Custom1;
            SubastaDataGrid.Location = new Point(38, 138);
            SubastaDataGrid.MultiSelect = false;
            SubastaDataGrid.Name = "SubastaDataGrid";
            SubastaDataGrid.Palette = kryptonCustomPaletteBase1;
            SubastaDataGrid.PaletteMode = PaletteMode.Custom;
            SubastaDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle9.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            SubastaDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            SubastaDataGrid.RowTemplate.Height = 30;
            SubastaDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubastaDataGrid.Size = new Size(797, 585);
            SubastaDataGrid.TabIndex = 0;
            SubastaDataGrid.CellContentClick += SubastaDataGrid_CellContentClick_1;
            // 
            // IdSubasta
            // 
            IdSubasta.DataPropertyName = "IdSubasta";
            IdSubasta.DefaultCellStyle = dataGridViewCellStyle2;
            IdSubasta.FillWeight = 40F;
            IdSubasta.HeaderText = "#";
            IdSubasta.Name = "IdSubasta";
            IdSubasta.Resizable = DataGridViewTriState.True;
            IdSubasta.Width = 45;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "Descripcion";
            descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            descripcion.FillWeight = 79.283F;
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 88;
            // 
            // FechaInicio
            // 
            FechaInicio.DataPropertyName = "FechaInicio";
            FechaInicio.DefaultCellStyle = dataGridViewCellStyle4;
            FechaInicio.HeaderText = "Fecha de inicio";
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            FechaInicio.Width = 111;
            // 
            // FechaCierre
            // 
            FechaCierre.DataPropertyName = "FechaCierre";
            FechaCierre.DefaultCellStyle = dataGridViewCellStyle5;
            FechaCierre.HeaderText = "Fecha de cierre";
            FechaCierre.Name = "FechaCierre";
            FechaCierre.ReadOnly = true;
            FechaCierre.Width = 111;
            // 
            // formapago
            // 
            formapago.DataPropertyName = "FormaDePago";
            formapago.DefaultCellStyle = dataGridViewCellStyle6;
            formapago.FillWeight = 79.283F;
            formapago.HeaderText = "Formas de pago";
            formapago.Name = "formapago";
            formapago.ReadOnly = true;
            formapago.Width = 88;
            // 
            // modoentrega
            // 
            modoentrega.DataPropertyName = "ModoEntrega";
            modoentrega.DefaultCellStyle = dataGridViewCellStyle7;
            modoentrega.FillWeight = 79.283F;
            modoentrega.HeaderText = "Modo de entrega";
            modoentrega.Name = "modoentrega";
            modoentrega.ReadOnly = true;
            modoentrega.Width = 89;
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.DefaultCellStyle = dataGridViewCellStyle8;
            estado.FillWeight = 79.283F;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 88;
            // 
            // Editar
            // 
            Editar.ButtonStyle = ButtonStyle.Custom3;
            Editar.FillWeight = 79.283F;
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // VerResumen
            // 
            VerResumen.ButtonStyle = ButtonStyle.Custom3;
            VerResumen.FillWeight = 79.283F;
            VerResumen.HeaderText = "Ver productos";
            VerResumen.Name = "VerResumen";
            VerResumen.Text = "Productos";
            VerResumen.UseColumnTextForButtonValue = true;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = PaletteMode.Office2010Blue;
            kryptonCustomPaletteBase1.BasePaletteType = BasePaletteType.Office2010;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.DrawBorders = PaletteDrawBorders.Bottom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedNormal.Border.Width = 20;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 10;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.Padding = new Padding(10, -1, -1, 8);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Switch90;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = Color.FromArgb(200, 130, 40);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = Color.FromArgb(200, 130, 40);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = Color.FromArgb(255, 220, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top;
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
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
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
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Back.ImageStyle = PaletteImageStyle.Stretch;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom3.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
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
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.Draw = InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Draw = InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 9F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color2 = Color.White;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 180, 85);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateActive.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left;
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
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left;
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
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(btnCrearSubasta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SubastaDataGrid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 761);
            panel1.TabIndex = 3;
            // 
            // btnCrearSubasta
            // 
            btnCrearSubasta.Anchor = AnchorStyles.Left;
            btnCrearSubasta.ButtonStyle = ButtonStyle.Custom2;
            btnCrearSubasta.Location = new Point(38, 80);
            btnCrearSubasta.MaximumSize = new Size(131, 44);
            btnCrearSubasta.Name = "btnCrearSubasta";
            btnCrearSubasta.Palette = kryptonCustomPaletteBase1;
            btnCrearSubasta.PaletteMode = PaletteMode.Custom;
            btnCrearSubasta.Size = new Size(131, 44);
            btnCrearSubasta.TabIndex = 6;
            btnCrearSubasta.Values.Text = "Crear subasta";
            btnCrearSubasta.Click += btnCrearSubasta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(33, 46);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(369, 20);
            label2.TabIndex = 5;
            label2.Text = "Aqui podras crear y ver detalles de las subastas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(33, 13);
            label1.Name = "label1";
            label1.Size = new Size(289, 33);
            label1.TabIndex = 4;
            label1.Text = "Administrar subastas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(txtFiltroDescipcion);
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Location = new Point(437, 80);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 55);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // txtFiltroDescipcion
            // 
            txtFiltroDescipcion.CueHint.Color1 = Color.Silver;
            txtFiltroDescipcion.CueHint.CueHintText = "Buscar subastas...";
            txtFiltroDescipcion.CueHint.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtFiltroDescipcion.CueHint.Padding = new Padding(5, -1, -1, -1);
            txtFiltroDescipcion.CueHint.TextH = PaletteRelativeAlign.Near;
            txtFiltroDescipcion.Dock = DockStyle.Fill;
            txtFiltroDescipcion.Location = new Point(0, 0);
            txtFiltroDescipcion.Margin = new Padding(0);
            txtFiltroDescipcion.MaximumSize = new Size(338, 45);
            txtFiltroDescipcion.Name = "txtFiltroDescipcion";
            txtFiltroDescipcion.Size = new Size(338, 44);
            txtFiltroDescipcion.StateActive.Back.Color1 = Color.FromArgb(64, 64, 64);
            txtFiltroDescipcion.StateActive.Border.Color1 = Color.Gray;
            txtFiltroDescipcion.StateActive.Border.Color2 = Color.Gray;
            txtFiltroDescipcion.StateActive.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left;
            txtFiltroDescipcion.StateActive.Border.Rounding = 5F;
            txtFiltroDescipcion.StateActive.Content.Color1 = Color.White;
            txtFiltroDescipcion.StateActive.Content.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtFiltroDescipcion.StateActive.Content.Padding = new Padding(5, 15, -1, -1);
            txtFiltroDescipcion.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtFiltroDescipcion.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            txtFiltroDescipcion.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left;
            txtFiltroDescipcion.StateCommon.Border.Rounding = 10F;
            txtFiltroDescipcion.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltroDescipcion.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.ButtonStyle = ButtonStyle.Custom2;
            btnBuscar.Location = new Point(338, 0);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Palette = kryptonCustomPaletteBase1;
            btnBuscar.PaletteMode = PaletteMode.Custom;
            btnBuscar.Size = new Size(59, 44);
            btnBuscar.StateCommon.Back.Image = Properties.Resources.magnifying_glass_solid;
            btnBuscar.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterMiddle;
            btnBuscar.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Right;
            btnBuscar.StatePressed.Back.Image = Properties.Resources.magnifying_glass_solid2;
            btnBuscar.StateTracking.Back.Image = Properties.Resources.magnifying_glass_solid1;
            btnBuscar.StateTracking.Back.ImageStyle = PaletteImageStyle.CenterMiddle;
            btnBuscar.TabIndex = 1;
            btnBuscar.Values.Text = "";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(872, 761);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHome";
            Text = "Form1";
            Activated += FormHome_Activated;
            Load += btnBuscar_Click;
            ((System.ComponentModel.ISupportInitialize)SubastaDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KryptonDataGridView SubastaDataGrid;
        private Panel panel1;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private FlowLayoutPanel flowLayoutPanel1;
        private KryptonTextBox txtFiltroDescipcion;
        private KryptonButton btnBuscar;
        private Label label1;
        private Label label2;
        private KryptonDataGridViewTextBoxColumn IdSubasta;
        private KryptonDataGridViewTextBoxColumn descripcion;
        private KryptonDataGridViewTextBoxColumn FechaInicio;
        private KryptonDataGridViewTextBoxColumn FechaCierre;
        private KryptonDataGridViewTextBoxColumn formapago;
        private KryptonDataGridViewTextBoxColumn modoentrega;
        private KryptonDataGridViewTextBoxColumn estado;
        private KryptonDataGridViewButtonColumn Editar;
        private KryptonDataGridViewButtonColumn VerResumen;
        private KryptonButton btnCrearSubasta;
    }
}
