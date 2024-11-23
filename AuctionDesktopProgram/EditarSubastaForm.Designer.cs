namespace AuctionDesktopProgram
{
    partial class EditarSubastaForm
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
            dtpFechaInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtModoEntrega = new Krypton.Toolkit.KryptonTextBox();
            txtFormaPago = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            dtpFechaCierre = new Krypton.Toolkit.KryptonDateTimePicker();
            label2 = new Label();
            label7 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Guardar = new Krypton.Toolkit.KryptonButton();
            Cancelar = new Krypton.Toolkit.KryptonButton();
            FinalizarSubasta = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtDescripcion = new Krypton.Toolkit.KryptonTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.CalendarHeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            dtpFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaInicio.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            dtpFechaInicio.Location = new Point(33, 71);
            dtpFechaInicio.Margin = new Padding(3, 3, 10, 3);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Palette = kryptonCustomPaletteBase1;
            dtpFechaInicio.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            dtpFechaInicio.Size = new Size(351, 37);
            dtpFechaInicio.TabIndex = 13;
            dtpFechaInicio.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCalendarDay.StateCommon.Back.Color1 = Color.Yellow;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCalendarDay.StateTracking.Back.Color1 = Color.Red;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCalendarDay.StateTracking.Back.Color2 = Color.Red;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedTracking.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCheckedTracking.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.FromArgb(255, 190, 67);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 5F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Back.Color1 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Back.Color2 = Color.FromArgb(242, 185, 105);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateCheckedTracking.Border.Rounding = 5F;
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Back.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Border.Color1 = Color.FromArgb(255, 220, 150);
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Border.Color2 = Color.FromArgb(255, 220, 150);
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.CalendarDay.OverrideFocus.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.CalendarDay.OverrideToday.Border.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.CalendarDay.OverrideToday.Border.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.CalendarDay.OverrideToday.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.CalendarDay.OverrideToday.Border.Rounding = 5F;
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Border.Rounding = 5F;
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.CalendarDay.StateCommon.Content.ShortText.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.CalendarDay.StateDisabled.Content.ShortText.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.CalendarDay.StateDisabled.Content.ShortText.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.CalendarDay.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.CalendarDay.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.CalendarDay.StateTracking.Border.Color1 = Color.FromArgb(255, 220, 150);
            kryptonCustomPaletteBase1.CalendarDay.StateTracking.Border.Color2 = Color.FromArgb(255, 220, 150);
            kryptonCustomPaletteBase1.CalendarDay.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color1 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color2 = Color.FromArgb(39, 42, 45);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom2.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom2.StateCommon.Border.Rounding = 10F;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom2.StateCommon.Border.Width = 2;
            kryptonCustomPaletteBase1.ControlStyles.ControlGroupBox.StateCommon.Back.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.ControlStyles.ControlGroupBox.StateCommon.Back.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color2 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.Color1 = Color.FromArgb(240, 180, 100);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.Color2 = Color.FromArgb(240, 180, 100);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Content.LongText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Content.LongText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Content.ShortText.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Content.ShortText.Font = new Font("Roboto Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color1 = Color.FromArgb(41, 41, 41);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Back.Color2 = Color.FromArgb(41, 41, 41);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = Color.FromArgb(55, 55, 55);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color2 = Color.FromArgb(41, 41, 41);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 15F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Border.Width = 2;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Color1 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Color2 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.LongText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.LabelStyles.LabelSuperTip.StateCommon.LongText.Color1 = Color.White;
            kryptonCustomPaletteBase1.LabelStyles.LabelSuperTip.StateCommon.LongText.Color2 = Color.White;
            kryptonCustomPaletteBase1.LabelStyles.LabelSuperTip.StateCommon.ShortText.Color1 = Color.Gainsboro;
            kryptonCustomPaletteBase1.LabelStyles.LabelSuperTip.StateCommon.ShortText.Color2 = Color.Gainsboro;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(33, 15);
            label6.Name = "label6";
            label6.Size = new Size(177, 29);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Inicio";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtModoEntrega, 1, 3);
            tableLayoutPanel1.Controls.Add(txtFormaPago, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaCierre, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaInicio, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 15, 30, 0);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(788, 235);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // txtModoEntrega
            // 
            txtModoEntrega.AcceptsReturn = true;
            txtModoEntrega.AcceptsTab = true;
            txtModoEntrega.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtModoEntrega.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtModoEntrega.Location = new Point(404, 170);
            txtModoEntrega.Margin = new Padding(10, 3, 3, 3);
            txtModoEntrega.Name = "txtModoEntrega";
            txtModoEntrega.Palette = kryptonCustomPaletteBase1;
            txtModoEntrega.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtModoEntrega.ScrollBars = ScrollBars.Both;
            txtModoEntrega.Size = new Size(351, 39);
            txtModoEntrega.TabIndex = 20;
            // 
            // txtFormaPago
            // 
            txtFormaPago.AcceptsReturn = true;
            txtFormaPago.AcceptsTab = true;
            txtFormaPago.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFormaPago.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtFormaPago.Location = new Point(33, 170);
            txtFormaPago.Margin = new Padding(3, 3, 10, 3);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Palette = kryptonCustomPaletteBase1;
            txtFormaPago.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtFormaPago.ScrollBars = ScrollBars.Both;
            txtFormaPago.Size = new Size(351, 39);
            txtFormaPago.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(33, 135);
            label1.Margin = new Padding(3, 20, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 16;
            label1.Text = "Forma de pago";
            // 
            // dtpFechaCierre
            // 
            dtpFechaCierre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaCierre.CalendarHeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            dtpFechaCierre.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaCierre.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            dtpFechaCierre.Format = DateTimePickerFormat.Custom;
            dtpFechaCierre.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            dtpFechaCierre.Location = new Point(404, 68);
            dtpFechaCierre.Margin = new Padding(10, 3, 3, 10);
            dtpFechaCierre.Name = "dtpFechaCierre";
            dtpFechaCierre.Palette = kryptonCustomPaletteBase1;
            dtpFechaCierre.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            dtpFechaCierre.Size = new Size(351, 37);
            dtpFechaCierre.TabIndex = 15;
            dtpFechaCierre.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(404, 15);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 27);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 18F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(404, 135);
            label7.Margin = new Padding(10, 20, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(197, 29);
            label7.TabIndex = 17;
            label7.Text = "Modo de entrega";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(Guardar, 2, 0);
            tableLayoutPanel3.Controls.Add(Cancelar, 3, 0);
            tableLayoutPanel3.Controls.Add(FinalizarSubasta, 5, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 450);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(788, 96);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // Guardar
            // 
            Guardar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            Guardar.Dock = DockStyle.Fill;
            Guardar.Location = new Point(272, 10);
            Guardar.Margin = new Padding(10, 10, 10, 30);
            Guardar.Name = "Guardar";
            Guardar.Palette = kryptonCustomPaletteBase1;
            Guardar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Guardar.Size = new Size(111, 56);
            Guardar.TabIndex = 13;
            Guardar.Values.Text = "Guardar";
            Guardar.Click += Guardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            Cancelar.Dock = DockStyle.Fill;
            Cancelar.Location = new Point(403, 10);
            Cancelar.Margin = new Padding(10, 10, 10, 30);
            Cancelar.Name = "Cancelar";
            Cancelar.Palette = kryptonCustomPaletteBase1;
            Cancelar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Cancelar.Size = new Size(111, 56);
            Cancelar.TabIndex = 14;
            Cancelar.Values.Text = "Cancelar";
            Cancelar.Click += Cancelar_Click;
            // 
            // FinalizarSubasta
            // 
            FinalizarSubasta.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            FinalizarSubasta.Dock = DockStyle.Fill;
            FinalizarSubasta.Location = new Point(658, 10);
            FinalizarSubasta.Margin = new Padding(3, 10, 15, 30);
            FinalizarSubasta.Name = "FinalizarSubasta";
            FinalizarSubasta.Palette = kryptonCustomPaletteBase1;
            FinalizarSubasta.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            FinalizarSubasta.Size = new Size(115, 56);
            FinalizarSubasta.TabIndex = 15;
            FinalizarSubasta.ToolTipValues.Description = "Dar por finalizada la subasta";
            FinalizarSubasta.ToolTipValues.EnableToolTips = true;
            FinalizarSubasta.ToolTipValues.Heading = "Finalizar";
            FinalizarSubasta.ToolTipValues.ShowIntervalDelay = 50;
            FinalizarSubasta.Values.Text = "Finalizar";
            FinalizarSubasta.Click += FinalizarSubasta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(33, 10);
            label3.Margin = new Padding(3, 10, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 18;
            label3.Text = "Descripcion";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtDescripcion, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 235);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(30, 0, 30, 15);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(788, 215);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.CornerRoundingRadius = 5F;
            txtDescripcion.CueHint.Color1 = Color.Gray;
            txtDescripcion.CueHint.CueHintText = "Ingrese la descripcion de la subasta...";
            txtDescripcion.CueHint.Font = new Font("Roboto Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            txtDescripcion.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDescripcion.Location = new Point(33, 54);
            txtDescripcion.Margin = new Padding(3, 15, 3, 15);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Palette = kryptonCustomPaletteBase1;
            txtDescripcion.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            txtDescripcion.Size = new Size(722, 131);
            txtDescripcion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDescripcion.StateCommon.Border.Rounding = 5F;
            txtDescripcion.TabIndex = 19;
            // 
            // EditarSubastaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(788, 546);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            CornerRoundingRadius = 15F;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "EditarSubastaForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            StateCommon.Back.Color2 = Color.FromArgb(26, 26, 26);
            StateCommon.Border.Color1 = Color.Black;
            StateCommon.Border.Color2 = Color.Black;
            StateCommon.Border.Rounding = 15F;
            StateCommon.Header.Back.Color1 = Color.Black;
            StateCommon.Header.Back.Color2 = Color.Black;
            StateCommon.Header.Border.Draw = Krypton.Toolkit.InheritBool.False;
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            StateCommon.Header.Content.ShortText.Color2 = Color.White;
            Text = "Editar subasta";
            Load += EditarSubastaForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaInicio;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaCierre;
        private Label label2;
        private Label label1;
        private Label label7;
        private Krypton.Toolkit.KryptonTextBox txtDescripcion;
        private Krypton.Toolkit.KryptonTextBox txtFormaPago;
        private Krypton.Toolkit.KryptonTextBox txtModoEntrega;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton Guardar;
        private Krypton.Toolkit.KryptonButton Cancelar;
        private Krypton.Toolkit.KryptonButton FinalizarSubasta;
    }
}