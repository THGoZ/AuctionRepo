namespace AuctionDesktopProgram
{
    partial class CrearSubastaForm
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
            Cancelar = new Button();
            Guardar = new Button();
            txtModoEntrega = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFormaPago = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            dtpFechaCierre = new DateTimePicker();
            label1 = new Label();
            dtpFechaInicio = new DateTimePicker();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.FromArgb(255, 192, 128);
            Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelar.ForeColor = Color.Black;
            Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Cancelar.Location = new Point(568, 253);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(111, 36);
            Cancelar.TabIndex = 23;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.FromArgb(255, 192, 128);
            Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guardar.ForeColor = Color.Black;
            Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            Guardar.Location = new Point(568, 151);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(111, 36);
            Guardar.TabIndex = 22;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += Guardar_Click;
            // 
            // txtModoEntrega
            // 
            txtModoEntrega.Location = new Point(122, 371);
            txtModoEntrega.Name = "txtModoEntrega";
            txtModoEntrega.Size = new Size(250, 27);
            txtModoEntrega.TabIndex = 21;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 329);
            label5.Name = "label5";
            label5.Size = new Size(155, 39);
            label5.TabIndex = 20;
            label5.Text = "Modo Entrega";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 257);
            label4.Name = "label4";
            label4.Size = new Size(155, 39);
            label4.TabIndex = 19;
            label4.Text = "Forma de Pago";
            // 
            // txtFormaPago
            // 
            txtFormaPago.Location = new Point(122, 299);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Size = new Size(250, 27);
            txtFormaPago.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 188);
            label3.Name = "label3";
            label3.Size = new Size(155, 36);
            label3.TabIndex = 17;
            label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(122, 227);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 27);
            txtDescripcion.TabIndex = 16;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 121);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 15;
            label2.Text = "Fecha de Fin";
            // 
            // dtpFechaCierre
            // 
            dtpFechaCierre.Location = new Point(122, 160);
            dtpFechaCierre.Name = "dtpFechaCierre";
            dtpFechaCierre.Size = new Size(250, 27);
            dtpFechaCierre.TabIndex = 14;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 52);
            label1.Name = "label1";
            label1.Size = new Size(155, 36);
            label1.TabIndex = 13;
            label1.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(122, 91);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 12;
            // 
            // CrearSubastaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelar);
            Controls.Add(Guardar);
            Controls.Add(txtModoEntrega);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFormaPago);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(dtpFechaCierre);
            Controls.Add(label1);
            Controls.Add(dtpFechaInicio);
            Name = "CrearSubastaForm";
            Text = "CrearSubastaForm";
            Load += CrearSubastaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Button Guardar;
        private TextBox txtModoEntrega;
        private Label label5;
        private Label label4;
        private TextBox txtFormaPago;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private DateTimePicker dtpFechaCierre;
        private Label label1;
        private DateTimePicker dtpFechaInicio;
    }
}