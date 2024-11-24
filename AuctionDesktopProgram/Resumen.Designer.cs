using Krypton.Toolkit;

namespace AuctionDesktopProgram
{
    partial class Resumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtFiltroDescipcion = new KryptonTextBox();
            btnBuscar = new KryptonButton();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            Ok = new KryptonButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            pictureBox1 = new PictureBox();
            btnOfertas = new KryptonButton();
            kryptonDataGridView1 = new KryptonDataGridView();
            idProducto = new KryptonDataGridViewTextBoxColumn();
            Nombre = new KryptonDataGridViewTextBoxColumn();
            PrecioBase = new KryptonDataGridViewTextBoxColumn();
            CantidadOfertas = new KryptonDataGridViewTextBoxColumn();
            MaxOferta = new KryptonDataGridViewTextBoxColumn();
            fechaSolicitud = new KryptonDataGridViewDateTimePickerColumn();
            LoadingProcess = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(43, 53);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(456, 20);
            label2.TabIndex = 7;
            label2.Text = "Aqui podra ver los productos en la subasta y su informacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(33, 20);
            label3.Name = "label3";
            label3.Size = new Size(302, 33);
            label3.TabIndex = 6;
            label3.Text = "Detalles de la subasta";
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 20, 15, 0);
            panel1.Size = new Size(1113, 100);
            panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(txtFiltroDescipcion);
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Location = new Point(691, 45);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 55);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // txtFiltroDescipcion
            // 
            txtFiltroDescipcion.CueHint.Color1 = Color.Silver;
            txtFiltroDescipcion.CueHint.CueHintText = "Buscar productos...";
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
            txtFiltroDescipcion.TextChanged += txtFiltroDescipcion_TextChanged;
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
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color2 = Color.FromArgb(255, 200, 100);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Width = 2;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
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
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color1 = Color.FromArgb(167, 132, 82);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color2 = Color.FromArgb(167, 132, 82);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Border.Color1 = Color.FromArgb(167, 132, 82);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Border.Color2 = Color.FromArgb(167, 132, 82);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Content.LongText.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Content.LongText.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Content.ShortText.Color1 = Color.Black;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom2.StateDisabled.Content.ShortText.Color2 = Color.Black;
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(26, 26, 26);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(Ok, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 591);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1113, 53);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // Ok
            // 
            Ok.ButtonStyle = ButtonStyle.Custom2;
            Ok.Dock = DockStyle.Fill;
            Ok.Location = new Point(467, 10);
            Ok.Margin = new Padding(100, 10, 100, 10);
            Ok.Name = "Ok";
            Ok.Palette = kryptonCustomPaletteBase1;
            Ok.PaletteMode = PaletteMode.Custom;
            Ok.Size = new Size(178, 33);
            Ok.TabIndex = 0;
            Ok.Values.Text = "Ok";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 370F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblPrecio, 0, 3);
            tableLayoutPanel2.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDescripcion, 0, 2);
            tableLayoutPanel2.Controls.Add(cyberGroupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnOfertas, 0, 4);
            tableLayoutPanel2.Controls.Add(kryptonDataGridView1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 100);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(30, 0, 15, 0);
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1113, 491);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Dock = DockStyle.Bottom;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.FromArgb(128, 255, 128);
            lblPrecio.Location = new Point(33, 382);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Padding = new Padding(30, 0, 0, 30);
            lblPrecio.Size = new Size(364, 69);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "- - - - -";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Silver;
            lblNombre.Location = new Point(33, 338);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(364, 24);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "------";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoEllipsis = true;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 12.25F);
            lblDescripcion.ForeColor = Color.Gray;
            lblDescripcion.Location = new Point(33, 362);
            lblDescripcion.MaximumSize = new Size(500, 60);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(364, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Seleccione un producto para ver los detalles";
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.Anchor = AnchorStyles.None;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = false;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = false;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(64, 64, 64);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(pictureBox1);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = true;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(53, 13);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 5;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 15;
            cyberGroupBox1.Size = new Size(324, 312);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 11;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(500, 400);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnOfertas
            // 
            btnOfertas.Anchor = AnchorStyles.None;
            btnOfertas.ButtonStyle = ButtonStyle.Custom2;
            btnOfertas.Enabled = false;
            btnOfertas.Location = new Point(150, 454);
            btnOfertas.Name = "btnOfertas";
            btnOfertas.Palette = kryptonCustomPaletteBase1;
            btnOfertas.PaletteMode = PaletteMode.Custom;
            btnOfertas.Size = new Size(129, 34);
            btnOfertas.TabIndex = 12;
            btnOfertas.Values.Text = "Ver ofertas";
            btnOfertas.Click += btnOfertas_Click;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.AllowUserToAddRows = false;
            kryptonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridView1.AutoGenerateColumns = false;
            kryptonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, Nombre, PrecioBase, CantidadOfertas, MaxOferta, fechaSolicitud });
            kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            kryptonDataGridView1.GridStyles.StyleColumn = GridStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleDataCells = GridStyle.Custom1;
            kryptonDataGridView1.GridStyles.StyleRow = GridStyle.Custom1;
            kryptonDataGridView1.Location = new Point(403, 3);
            kryptonDataGridView1.MultiSelect = false;
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Palette = kryptonCustomPaletteBase1;
            kryptonDataGridView1.PaletteMode = PaletteMode.Custom;
            kryptonDataGridView1.RowHeadersVisible = false;
            tableLayoutPanel2.SetRowSpan(kryptonDataGridView1, 5);
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kryptonDataGridView1.Size = new Size(692, 485);
            kryptonDataGridView1.TabIndex = 0;
            kryptonDataGridView1.CurrentCellChanged += kryptonDataGridView1_CurrentCellChanged;
            // 
            // idProducto
            // 
            idProducto.DataPropertyName = "Id";
            idProducto.DefaultCellStyle = dataGridViewCellStyle1;
            idProducto.HeaderText = "#";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Width = 115;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            Nombre.HeaderText = "Producto";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 115;
            // 
            // PrecioBase
            // 
            PrecioBase.DataPropertyName = "PrecioBase";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle3;
            PrecioBase.HeaderText = "Precio base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.ReadOnly = true;
            PrecioBase.Width = 115;
            // 
            // CantidadOfertas
            // 
            CantidadOfertas.DataPropertyName = "TotalDeOfertas";
            CantidadOfertas.DefaultCellStyle = dataGridViewCellStyle4;
            CantidadOfertas.HeaderText = "Cantidad de ofertas";
            CantidadOfertas.Name = "CantidadOfertas";
            CantidadOfertas.ReadOnly = true;
            CantidadOfertas.Width = 116;
            // 
            // MaxOferta
            // 
            MaxOferta.DataPropertyName = "Monto";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            MaxOferta.DefaultCellStyle = dataGridViewCellStyle5;
            MaxOferta.HeaderText = "Maxima Oferta";
            MaxOferta.Name = "MaxOferta";
            MaxOferta.ReadOnly = true;
            MaxOferta.Width = 115;
            // 
            // fechaSolicitud
            // 
            fechaSolicitud.Checked = false;
            fechaSolicitud.DataPropertyName = "Fecha";
            fechaSolicitud.Format = DateTimePickerFormat.Short;
            fechaSolicitud.HeaderText = "Fecha de solicitud";
            fechaSolicitud.Name = "fechaSolicitud";
            fechaSolicitud.ReadOnly = true;
            fechaSolicitud.SortMode = DataGridViewColumnSortMode.Automatic;
            fechaSolicitud.Width = 115;
            // 
            // LoadingProcess
            // 
            LoadingProcess.DoWork += backgroundWorker1_DoWork;
            LoadingProcess.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Resumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            CancelButton = Ok;
            ClientSize = new Size(1113, 644);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            CornerRoundingRadius = 15F;
            ForeColor = SystemColors.ButtonFace;
            Name = "Resumen";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            StateCommon.Back.Color2 = Color.FromArgb(26, 26, 26);
            StateCommon.Border.Color1 = Color.Gray;
            StateCommon.Border.Color2 = Color.Silver;
            StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 15F;
            StateCommon.Header.Back.Color1 = Color.Black;
            StateCommon.Header.Back.Color2 = Color.Black;
            StateCommon.Header.Content.ShortText.Color1 = Color.White;
            Text = "Resumen";
            Load += Resumen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonTextBox txtFiltroDescipcion;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private KryptonDataGridView kryptonDataGridView1;
        private PictureBox pictureBox1;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Krypton.Toolkit.KryptonButton Ok;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private KryptonButton btnOfertas;
        private KryptonDataGridViewTextBoxColumn idProducto;
        private KryptonDataGridViewTextBoxColumn Nombre;
        private KryptonDataGridViewTextBoxColumn PrecioBase;
        private KryptonDataGridViewTextBoxColumn CantidadOfertas;
        private KryptonDataGridViewTextBoxColumn MaxOferta;
        private KryptonDataGridViewDateTimePickerColumn fechaSolicitud;
        private System.ComponentModel.BackgroundWorker LoadingProcess;
    }
}