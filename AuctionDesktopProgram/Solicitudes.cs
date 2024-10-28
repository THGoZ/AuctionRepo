using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionDesktopProgram
{
    public partial class Solicitudes : Form
    {
        private readonly IProductoBusiness _productoBusiness;
        private IContainer components;
        private Krypton.Toolkit.KryptonDataGridView SubastaDataGrid;
        private DataGridViewTextBoxColumn ColumnIdProducto;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnBasePrice;
        private DataGridViewTextBoxColumn ColumnDateOfApplication;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn ColumnApplicationStatus;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private Label label5;
        private Producto productoSeleccionado;

        public Solicitudes(IProductoBusiness productoBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;

            CargarProductosSolicitados();
        }
        #region boludeces
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new ReaLTaiizor.Controls.GroupBox();
            kryptonButtonRechazar = new Krypton.Toolkit.KryptonButton();
            kryptonButtonAceptar = new Krypton.Toolkit.KryptonButton();
            kryptonRichTextBoxDescripcion = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonPictureBoxImagen = new Krypton.Toolkit.KryptonPictureBox();
            label4 = new Label();
            kryptonMaskedTextBoxPrecioBase = new Krypton.Toolkit.KryptonMaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            kryptonMaskedTextBoxName = new Krypton.Toolkit.KryptonMaskedTextBox();
            label1 = new Label();
            SubastaDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            ColumnIdProducto = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnBasePrice = new DataGridViewTextBoxColumn();
            ColumnDateOfApplication = new DataGridViewTextBoxColumn();
            ColumnApplicationStatus = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).BeginInit();
            ((ISupportInitialize)SubastaDataGrid).BeginInit();
            foreverGroupBox1.SuspendLayout();
            foreverGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackGColor = Color.FromArgb(39, 42, 45);
            groupBox1.BaseColor = Color.Transparent;
            groupBox1.BorderColorG = Color.FromArgb(159, 159, 161);
            groupBox1.BorderColorH = Color.FromArgb(182, 180, 186);
            groupBox1.Controls.Add(kryptonButtonRechazar);
            groupBox1.Controls.Add(kryptonButtonAceptar);
            groupBox1.Controls.Add(kryptonRichTextBoxDescripcion);
            groupBox1.Controls.Add(kryptonPictureBoxImagen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(kryptonMaskedTextBoxPrecioBase);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(kryptonMaskedTextBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.HeaderColor = Color.Orange;
            groupBox1.Location = new Point(594, 70);
            groupBox1.MinimumSize = new Size(136, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 28, 5, 5);
            groupBox1.Size = new Size(667, 608);
            groupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            groupBox1.TabIndex = 2;
            groupBox1.Text = "Cargar Producto";
            // 
            // kryptonButtonRechazar
            // 
            kryptonButtonRechazar.Location = new Point(159, 349);
            kryptonButtonRechazar.Name = "kryptonButtonRechazar";
            kryptonButtonRechazar.Size = new Size(90, 25);
            kryptonButtonRechazar.StateCommon.Back.Color1 = Color.Red;
            kryptonButtonRechazar.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonRechazar.TabIndex = 12;
            kryptonButtonRechazar.Values.Text = "Rechazar";
            kryptonButtonRechazar.Click += kryptonButtonRechazar_Click;
            // 
            // kryptonButtonAceptar
            // 
            kryptonButtonAceptar.Location = new Point(406, 346);
            kryptonButtonAceptar.Name = "kryptonButtonAceptar";
            kryptonButtonAceptar.Size = new Size(90, 25);
            kryptonButtonAceptar.StateCommon.Back.Color1 = Color.Lime;
            kryptonButtonAceptar.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonAceptar.StateCommon.Border.Color1 = Color.DimGray;
            kryptonButtonAceptar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButtonAceptar.TabIndex = 11;
            kryptonButtonAceptar.Values.Text = "Aceptar";
            kryptonButtonAceptar.Click += kryptonButtonAceptar_Click;
            // 
            // kryptonRichTextBoxDescripcion
            // 
            kryptonRichTextBoxDescripcion.Location = new Point(48, 142);
            kryptonRichTextBoxDescripcion.Name = "kryptonRichTextBoxDescripcion";
            kryptonRichTextBoxDescripcion.Size = new Size(239, 94);
            kryptonRichTextBoxDescripcion.TabIndex = 10;
            kryptonRichTextBoxDescripcion.Text = "";
            kryptonRichTextBoxDescripcion.TextChanged += kryptonRichTextBoxDescripcion_TextChanged;
            // 
            // kryptonPictureBoxImagen
            // 
            kryptonPictureBoxImagen.Location = new Point(309, 115);
            kryptonPictureBoxImagen.Name = "kryptonPictureBoxImagen";
            kryptonPictureBoxImagen.Size = new Size(223, 187);
            kryptonPictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBoxImagen.TabIndex = 9;
            kryptonPictureBoxImagen.TabStop = false;
            kryptonPictureBoxImagen.Click += kryptonPictureBoxImagen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(309, 48);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 7;
            label4.Text = "Imagen";
            // 
            // kryptonMaskedTextBoxPrecioBase
            // 
            kryptonMaskedTextBoxPrecioBase.Location = new Point(47, 285);
            kryptonMaskedTextBoxPrecioBase.Name = "kryptonMaskedTextBoxPrecioBase";
            kryptonMaskedTextBoxPrecioBase.Size = new Size(202, 23);
            kryptonMaskedTextBoxPrecioBase.TabIndex = 5;
            kryptonMaskedTextBoxPrecioBase.MaskInputRejected += kryptonMaskedTextBoxPrecioBase_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 252);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 4;
            label3.Text = "Precio Base";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 109);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            label2.Click += label2_Click;
            // 
            // kryptonMaskedTextBoxName
            // 
            kryptonMaskedTextBoxName.Location = new Point(48, 75);
            kryptonMaskedTextBoxName.Name = "kryptonMaskedTextBoxName";
            kryptonMaskedTextBoxName.Size = new Size(202, 23);
            kryptonMaskedTextBoxName.TabIndex = 1;
            kryptonMaskedTextBoxName.MaskInputRejected += kryptonMaskedTextBoxName_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // SubastaDataGrid
            // 
            SubastaDataGrid.AutoGenerateColumns = false;
            SubastaDataGrid.BorderStyle = BorderStyle.None;
            SubastaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubastaDataGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnIdProducto, ColumnName, ColumnBasePrice, ColumnDateOfApplication, ColumnApplicationStatus });
            SubastaDataGrid.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.HideOuterBorders = true;
            SubastaDataGrid.Location = new Point(18, 36);
            SubastaDataGrid.Name = "SubastaDataGrid";
            SubastaDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black;
            SubastaDataGrid.RowHeadersVisible = false;
            SubastaDataGrid.RowHeadersWidth = 51;
            SubastaDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubastaDataGrid.Size = new Size(538, 547);
            SubastaDataGrid.TabIndex = 1;
            SubastaDataGrid.CellContentClick += SubastaDataGrid_CellContentClickAsync;
            // 
            // ColumnIdProducto
            // 
            ColumnIdProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnIdProducto.DataPropertyName = "IdProducto";
            ColumnIdProducto.HeaderText = "Id";
            ColumnIdProducto.MinimumWidth = 6;
            ColumnIdProducto.Name = "ColumnIdProducto";
            ColumnIdProducto.Width = 50;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Nombre";
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnBasePrice
            // 
            ColumnBasePrice.DataPropertyName = "PrecioBase";
            ColumnBasePrice.HeaderText = "Precio Base";
            ColumnBasePrice.MinimumWidth = 6;
            ColumnBasePrice.Name = "ColumnBasePrice";
            ColumnBasePrice.Width = 125;
            // 
            // ColumnDateOfApplication
            // 
            ColumnDateOfApplication.DataPropertyName = "FechaSolicitud";
            ColumnDateOfApplication.HeaderText = "Fecha de Solicitud";
            ColumnDateOfApplication.MinimumWidth = 6;
            ColumnDateOfApplication.Name = "ColumnDateOfApplication";
            ColumnDateOfApplication.Width = 125;
            // 
            // ColumnApplicationStatus
            // 
            ColumnApplicationStatus.DataPropertyName = "EstadoDeSolicitud";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            ColumnApplicationStatus.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnApplicationStatus.FalseValue = "false";
            ColumnApplicationStatus.HeaderText = "Estado de Solicitud";
            ColumnApplicationStatus.IndeterminateValue = "null";
            ColumnApplicationStatus.MinimumWidth = 6;
            ColumnApplicationStatus.Name = "ColumnApplicationStatus";
            ColumnApplicationStatus.Resizable = DataGridViewTriState.True;
            ColumnApplicationStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnApplicationStatus.TrueValue = "true";
            ColumnApplicationStatus.Width = 125;
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.AutoScroll = true;
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(26, 26, 26);
            foreverGroupBox1.Controls.Add(foreverGroupBox2);
            foreverGroupBox1.Controls.Add(groupBox1);
            foreverGroupBox1.Dock = DockStyle.Fill;
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(0, 0);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = false;
            foreverGroupBox1.ShowText = false;
            foreverGroupBox1.Size = new Size(872, 761);
            foreverGroupBox1.TabIndex = 3;
            foreverGroupBox1.Text = "foreverGroupBox1";
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // foreverGroupBox2
            // 
            foreverGroupBox2.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox2.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox2.BackColor = Color.Transparent;
            foreverGroupBox2.BaseColor = Color.FromArgb(39, 42, 45);
            foreverGroupBox2.Controls.Add(label5);
            foreverGroupBox2.Controls.Add(SubastaDataGrid);
            foreverGroupBox2.Font = new Font("Segoe UI", 10F);
            foreverGroupBox2.Location = new Point(12, 78);
            foreverGroupBox2.Name = "foreverGroupBox2";
            foreverGroupBox2.ShowArrow = false;
            foreverGroupBox2.ShowText = false;
            foreverGroupBox2.Size = new Size(576, 600);
            foreverGroupBox2.TabIndex = 3;
            foreverGroupBox2.Text = "foreverGroupBox2";
            foreverGroupBox2.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(18, -9);
            label5.Name = "label5";
            label5.Size = new Size(139, 42);
            label5.TabIndex = 3;
            label5.Text = "Productos";
            // 
            // Solicitudes
            // 
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(872, 761);
            Controls.Add(foreverGroupBox1);
            Name = "Solicitudes";
            Text = "Jopara Ndeve";
            Load += Solicitudes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).EndInit();
            ((ISupportInitialize)SubastaDataGrid).EndInit();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox2.ResumeLayout(false);
            foreverGroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private ReaLTaiizor.Controls.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBoxPrecioBase;
        private Label label3;
        private Label label2;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBoxName;
        private Label label1;
        private Label label4;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxDescripcion;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBoxImagen;
        private Krypton.Toolkit.KryptonButton kryptonButtonAceptar;
        private Krypton.Toolkit.KryptonButton kryptonButtonRechazar;
        #endregion

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Click(object sender, EventArgs e)
        {

        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kryptonMaskedTextBoxPrecioBase_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonMaskedTextBoxImagen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonMaskedTextBoxName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void SubastaDataGrid_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el producto seleccionado de la fila
                productoSeleccionado = (Producto)SubastaDataGrid.Rows[e.RowIndex].DataBoundItem;

                if (productoSeleccionado != null)
                {
                    // Actualizar los campos de texto e imagen
                    kryptonMaskedTextBoxName.Text = productoSeleccionado.Nombre;
                    kryptonRichTextBoxDescripcion.Text = productoSeleccionado.Descripcion;
                    kryptonMaskedTextBoxPrecioBase.Text = productoSeleccionado.PrecioBase.ToString();

                    if (productoSeleccionado.Imagen != null)
                    {
                        using (var ms = new MemoryStream(productoSeleccionado.Imagen))
                        {
                            kryptonPictureBoxImagen.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        kryptonPictureBoxImagen.Image = null;
                    }

                    SubastaDataGrid.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Orange;

                    // Mostrar un mensaje opcional
                    //MessageBox.Show($"Producto seleccionado: {productoSeleccionado.Nombre} (ID: {productoSeleccionado.IdProducto})", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void CargarProductosSolicitados()
        {
            // Obtener la lista de productos solicitados (pueden ser aquellos con solicitudes pendientes)
            var productosSolicitados = _productoBusiness.GetProductosSolicitados();

            // Verificar si hay productos
            if (productosSolicitados.Count() != 0)
            {
                SubastaDataGrid.DataSource = productosSolicitados;
            }
            else
            {
                MessageBox.Show("No se encontraron productos solicitados pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void kryptonMaskedTextBoxDescripcion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonPictureBoxImagen_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButtonRechazar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                productoSeleccionado.EstadoDeSolicitud = false; // Cambiar a "false" si rechazado

                // Aquí puedes realizar alguna operación para guardar el cambio en la base de datos
                _productoBusiness.ActualizarEstadoProducto(productoSeleccionado);

                MessageBox.Show($"El producto {productoSeleccionado.Nombre} ha sido rechazado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarProductosSolicitados();
        }

        private void kryptonButtonAceptar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                productoSeleccionado.EstadoDeSolicitud = true; // Cambiar a "true" si aceptado

                // Aquí puedes realizar alguna operación para guardar el cambio en la base de datos
                _productoBusiness.ActualizarEstadoProducto(productoSeleccionado);

                MessageBox.Show($"El producto {productoSeleccionado.Nombre} ha sido aceptado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CargarProductosSolicitados();
        }

        private void crownMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {

        }
    }
}
