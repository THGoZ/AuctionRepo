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
            dtpFechaInicio = new DateTimePicker();
            label1 = new Label();
            dtpFechaCierre = new DateTimePicker();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtFormaPago = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtModoEntrega = new TextBox();
            Guardar = new Button();
            Cancelar = new Button();
            FinalizarSubasta = new Button();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(71, 74);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 35);
            label1.Name = "label1";
            label1.Size = new Size(155, 36);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Inicio";
            // 
            // dtpFechaCierre
            // 
            dtpFechaCierre.Location = new Point(71, 143);
            dtpFechaCierre.Name = "dtpFechaCierre";
            dtpFechaCierre.Size = new Size(250, 27);
            dtpFechaCierre.TabIndex = 2;
            dtpFechaCierre.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 104);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Fin";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(71, 210);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 171);
            label3.Name = "label3";
            label3.Size = new Size(155, 36);
            label3.TabIndex = 5;
            label3.Text = "Descripcion";
            // 
            // txtFormaPago
            // 
            txtFormaPago.Location = new Point(71, 282);
            txtFormaPago.Name = "txtFormaPago";
            txtFormaPago.Size = new Size(250, 27);
            txtFormaPago.TabIndex = 6;
            txtFormaPago.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 240);
            label4.Name = "label4";
            label4.Size = new Size(155, 39);
            label4.TabIndex = 7;
            label4.Text = "Forma de Pago";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 312);
            label5.Name = "label5";
            label5.Size = new Size(155, 39);
            label5.TabIndex = 8;
            label5.Text = "Modo Entrega";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtModoEntrega
            // 
            txtModoEntrega.Location = new Point(71, 354);
            txtModoEntrega.Name = "txtModoEntrega";
            txtModoEntrega.Size = new Size(250, 27);
            txtModoEntrega.TabIndex = 9;
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.FromArgb(255, 192, 128);
            Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guardar.ForeColor = Color.Black;
            Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            Guardar.Location = new Point(517, 134);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(111, 36);
            Guardar.TabIndex = 10;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += Guardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.FromArgb(255, 192, 128);
            Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelar.ForeColor = Color.Black;
            Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Cancelar.Location = new Point(517, 202);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(111, 36);
            Cancelar.TabIndex = 11;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += Cancelar_Click;
            // 
            // FinalizarSubasta
            // 
            FinalizarSubasta.BackColor = Color.FromArgb(255, 192, 128);
            FinalizarSubasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinalizarSubasta.ForeColor = Color.Black;
            FinalizarSubasta.ImageAlign = ContentAlignment.MiddleLeft;
            FinalizarSubasta.Location = new Point(517, 273);
            FinalizarSubasta.Name = "FinalizarSubasta";
            FinalizarSubasta.Size = new Size(111, 36);
            FinalizarSubasta.TabIndex = 12;
            FinalizarSubasta.Text = "Finalizar";
            FinalizarSubasta.UseVisualStyleBackColor = false;
            FinalizarSubasta.Click += FinalizarSubasta_Click;
            // 
            // EditarSubastaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(823, 450);
            Controls.Add(FinalizarSubasta);
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
            Name = "EditarSubastaForm";
            Text = "EditarSubastaForm";
            Load += EditarSubastaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaInicio;
        private Label label1;
        private DateTimePicker dtpFechaCierre;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtFormaPago;
        private Label label4;
        private Label label5;
        private TextBox txtModoEntrega;
        private Button Guardar;
        private Button Cancelar;
        private Button FinalizarSubasta;
    }
}