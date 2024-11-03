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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            Id = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Nombre = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            PrecioBase = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            FechaDeSolicitud = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            Subasta = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            FechaDeFinalizacionSubasta = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelProdVendidos = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            cyberGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Transparent;
            kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrecioBase, FechaDeSolicitud, Subasta, FechaDeFinalizacionSubasta });
            kryptonDataGridView1.Location = new Point(55, 175);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Size = new Size(675, 263);
            kryptonDataGridView1.TabIndex = 0;
            kryptonDataGridView1.CellContentClick += kryptonDataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 40;
            // 
            // Nombre
            // 
            Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 100;
            // 
            // PrecioBase
            // 
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle4;
            PrecioBase.HeaderText = "Precio Base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.Width = 90;
            // 
            // FechaDeSolicitud
            // 
            FechaDeSolicitud.DefaultCellStyle = dataGridViewCellStyle5;
            FechaDeSolicitud.HeaderText = "Fecha De Solicitud";
            FechaDeSolicitud.Name = "FechaDeSolicitud";
            FechaDeSolicitud.Width = 90;
            // 
            // Subasta
            // 
            Subasta.DefaultCellStyle = dataGridViewCellStyle6;
            Subasta.HeaderText = "Subasta";
            Subasta.Name = "Subasta";
            Subasta.Width = 100;
            // 
            // FechaDeFinalizacionSubasta
            // 
            FechaDeFinalizacionSubasta.DefaultCellStyle = dataGridViewCellStyle7;
            FechaDeFinalizacionSubasta.HeaderText = "Fecha De Finalizacion Subasta";
            FechaDeFinalizacionSubasta.Name = "FechaDeFinalizacionSubasta";
            FechaDeFinalizacionSubasta.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 29);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una subasta";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.ButtonFace;
            comboBox1.Location = new Point(12, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "No hay subastas finalizadas disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 72);
            label2.MaximumSize = new Size(500, 60);
            label2.Name = "label2";
            label2.Size = new Size(249, 20);
            label2.TabIndex = 5;
            label2.Text = "Ninguna subasta seleccionada...";
            // 
            // cyberGroupBox3
            // 
            cyberGroupBox3.Alpha = 20;
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
            cyberGroupBox3.Controls.Add(labelProdVendidos);
            cyberGroupBox3.Controls.Add(label5);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(12, 95);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 30;
            cyberGroupBox3.Size = new Size(519, 60);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 10;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // labelProdVendidos
            // 
            labelProdVendidos.AutoSize = true;
            labelProdVendidos.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdVendidos.ForeColor = Color.Gold;
            labelProdVendidos.Location = new Point(452, 13);
            labelProdVendidos.Name = "labelProdVendidos";
            labelProdVendidos.Size = new Size(43, 39);
            labelProdVendidos.TabIndex = 0;
            labelProdVendidos.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 19.25F, FontStyle.Bold);
            label5.Location = new Point(2, 13);
            label5.Name = "label5";
            label5.Size = new Size(423, 30);
            label5.TabIndex = 0;
            label5.Text = "N° DE PRODUCTOS VENDIDOS";
            // 
            // ProductosNoOfertados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(cyberGroupBox3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(kryptonDataGridView1);
            Name = "ProductosNoOfertados";
            Text = "ProductosNoOfertados";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nombre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn FechaDeSolicitud;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Subasta;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn FechaDeFinalizacionSubasta;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private Label labelProdVendidos;
        private Label label5;
    }
}