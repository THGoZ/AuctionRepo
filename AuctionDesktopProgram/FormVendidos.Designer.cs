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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
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
            kryptonDataGridView1.ColumnHeadersHeight = 36;
            kryptonDataGridView1.Location = new Point(26, 103);
            kryptonDataGridView1.Margin = new Padding(3, 4, 3, 4);
            kryptonDataGridView1.MaximumSize = new Size(600, 500);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.Size = new Size(600, 500);
            kryptonDataGridView1.TabIndex = 1;
            kryptonDataGridView1.CellContentClick += kryptonDataGridView1_CellContentClick;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            kryptonButton1.Enabled = false;
            kryptonButton1.Location = new Point(660, 287);
            kryptonButton1.Margin = new Padding(3, 4, 3, 4);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(218, 63);
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.Text = "Descargar informe";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(418, 44);
            label1.TabIndex = 3;
            label1.Text = "Productos Vendidos";
            // 
            // FormVendidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(901, 668);
            Controls.Add(label1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonDataGridView1);
            ForeColor = Color.FromArgb(39, 42, 45);
            Name = "FormVendidos";
            Text = "FormVendidos";
            Load += FormVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;

        private Label label1;
    }
}