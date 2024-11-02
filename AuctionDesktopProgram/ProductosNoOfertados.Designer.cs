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
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
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
            kryptonDataGridView1.Location = new Point(109, 68);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Size = new Size(552, 263);
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
            // ProductosNoOfertados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonDataGridView1);
            Name = "ProductosNoOfertados";
            Text = "ProductosNoOfertados";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nombre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn FechaDeSolicitud;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Subasta;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn FechaDeFinalizacionSubasta;
    }
}