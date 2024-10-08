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
        private DataGridViewTextBoxColumn ColumnIdProducto;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnBasePrice;
        private DataGridViewTextBoxColumn ColumnDateOfApplication;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn ColumnApplicationStatus;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            cREARSUBASTAToolStripMenuItem = new ToolStripMenuItem();
            sOLICITUDESToolStripMenuItem = new ToolStripMenuItem();
            iNFORMESToolStripMenuItem = new ToolStripMenuItem();
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
            groupBox2 = new ReaLTaiizor.Controls.GroupBox();
            SubastaDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            ColumnIdProducto = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnBasePrice = new DataGridViewTextBoxColumn();
            ColumnDateOfApplication = new DataGridViewTextBoxColumn();
            ColumnApplicationStatus = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            crownMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).BeginInit();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)SubastaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // crownMenuStrip1
            // 
            crownMenuStrip1.BackColor = Color.Transparent;
            crownMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownMenuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, cREARSUBASTAToolStripMenuItem, sOLICITUDESToolStripMenuItem, iNFORMESToolStripMenuItem });
            crownMenuStrip1.Location = new Point(0, 0);
            crownMenuStrip1.Name = "crownMenuStrip1";
            crownMenuStrip1.Padding = new Padding(3, 2, 0, 2);
            crownMenuStrip1.Size = new Size(1267, 28);
            crownMenuStrip1.TabIndex = 0;
            crownMenuStrip1.Text = "crownMenuStrip1";
            crownMenuStrip1.ItemClicked += crownMenuStrip1_ItemClicked;
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            iNICIOToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(66, 24);
            iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // cREARSUBASTAToolStripMenuItem
            // 
            cREARSUBASTAToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cREARSUBASTAToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cREARSUBASTAToolStripMenuItem.Name = "cREARSUBASTAToolStripMenuItem";
            cREARSUBASTAToolStripMenuItem.Size = new Size(134, 24);
            cREARSUBASTAToolStripMenuItem.Text = "CREAR SUBASTA";
            // 
            // sOLICITUDESToolStripMenuItem
            // 
            sOLICITUDESToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            sOLICITUDESToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            sOLICITUDESToolStripMenuItem.Name = "sOLICITUDESToolStripMenuItem";
            sOLICITUDESToolStripMenuItem.Size = new Size(111, 24);
            sOLICITUDESToolStripMenuItem.Text = "SOLICITUDES";
            // 
            // iNFORMESToolStripMenuItem
            // 
            iNFORMESToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            iNFORMESToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            iNFORMESToolStripMenuItem.Size = new Size(94, 24);
            iNFORMESToolStripMenuItem.Text = "INFORMES";
            iNFORMESToolStripMenuItem.Click += iNFORMESToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackGColor = Color.FromArgb(64, 64, 64);
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
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.ForeColor = Color.FromArgb(53, 53, 53);
            groupBox1.HeaderColor = Color.SlateGray;
            groupBox1.Location = new Point(651, 99);
            groupBox1.MinimumSize = new Size(136, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 28, 5, 5);
            groupBox1.Size = new Size(604, 401);
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
            label4.Size = new Size(97, 30);
            label4.TabIndex = 7;
            label4.Text = "Imagen";
            // 
            // kryptonMaskedTextBoxPrecioBase
            // 
            kryptonMaskedTextBoxPrecioBase.Location = new Point(47, 285);
            kryptonMaskedTextBoxPrecioBase.Name = "kryptonMaskedTextBoxPrecioBase";
            kryptonMaskedTextBoxPrecioBase.Size = new Size(202, 27);
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
            label3.Size = new Size(141, 30);
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
            label2.Size = new Size(141, 30);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            label2.Click += label2_Click;
            // 
            // kryptonMaskedTextBoxName
            // 
            kryptonMaskedTextBoxName.Location = new Point(48, 75);
            kryptonMaskedTextBoxName.Name = "kryptonMaskedTextBoxName";
            kryptonMaskedTextBoxName.Size = new Size(202, 27);
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
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.BackGColor = Color.FromArgb(64, 64, 64);
            groupBox2.BaseColor = Color.Transparent;
            groupBox2.BorderColorG = Color.FromArgb(159, 159, 161);
            groupBox2.BorderColorH = Color.FromArgb(182, 180, 186);
            groupBox2.Controls.Add(SubastaDataGrid);
            groupBox2.Font = new Font("Tahoma", 9F);
            groupBox2.ForeColor = Color.FromArgb(53, 53, 53);
            groupBox2.HeaderColor = Color.SlateGray;
            groupBox2.Location = new Point(12, 99);
            groupBox2.MinimumSize = new Size(136, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 28, 5, 5);
            groupBox2.Size = new Size(604, 401);
            groupBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            groupBox2.TabIndex = 9;
            groupBox2.Text = "Solicitudes";
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
            SubastaDataGrid.Location = new Point(34, 48);
            SubastaDataGrid.Name = "SubastaDataGrid";
            SubastaDataGrid.RowHeadersVisible = false;
            SubastaDataGrid.RowHeadersWidth = 51;
            SubastaDataGrid.Size = new Size(530, 313);
            SubastaDataGrid.StateCommon.Background.Color1 = Color.FromArgb(26, 26, 26);
            SubastaDataGrid.StateCommon.Background.Color2 = Color.FromArgb(26, 26, 26);
            SubastaDataGrid.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.StateCommon.DataCell.Back.Color1 = SystemColors.GrayText;
            SubastaDataGrid.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            SubastaDataGrid.TabIndex = 1;
            SubastaDataGrid.CellContentClick += SubastaDataGrid_CellContentClickAsync;
            // 
            // ColumnIdProducto
            // 
            ColumnIdProducto.DataPropertyName = "IdProducto";
            ColumnIdProducto.HeaderText = "IdProducto";
            ColumnIdProducto.MinimumWidth = 6;
            ColumnIdProducto.Name = "ColumnIdProducto";
            ColumnIdProducto.Width = 125;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            ColumnApplicationStatus.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnApplicationStatus.FalseValue = "Rechazado";
            ColumnApplicationStatus.HeaderText = "Estado de Solicitud";
            ColumnApplicationStatus.IndeterminateValue = "Pendiente";
            ColumnApplicationStatus.MinimumWidth = 6;
            ColumnApplicationStatus.Name = "ColumnApplicationStatus";
            ColumnApplicationStatus.Resizable = DataGridViewTriState.True;
            ColumnApplicationStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnApplicationStatus.TrueValue = "Aprobado";
            ColumnApplicationStatus.Width = 125;
            // 
            // Solicitudes
            // 
            ClientSize = new Size(1267, 624);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(crownMenuStrip1);
            MainMenuStrip = crownMenuStrip1;
            Name = "Solicitudes";
            Text = "Jopara Ndeve";
            crownMenuStrip1.ResumeLayout(false);
            crownMenuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).EndInit();
            groupBox2.ResumeLayout(false);
            ((ISupportInitialize)SubastaDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem cREARSUBASTAToolStripMenuItem;
        private ToolStripMenuItem sOLICITUDESToolStripMenuItem;
        private ToolStripMenuItem iNFORMESToolStripMenuItem;
        private ReaLTaiizor.Controls.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBoxPrecioBase;
        private Label label3;
        private Label label2;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBoxName;
        private Label label1;
        private Label label4;
        private ReaLTaiizor.Controls.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDataGridView SubastaDataGrid;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxDescripcion;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBoxImagen;
        private Krypton.Toolkit.KryptonButton kryptonButtonAceptar;
        private Krypton.Toolkit.KryptonButton kryptonButtonRechazar;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
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

                    // Mostrar un mensaje opcional
                    MessageBox.Show($"Producto seleccionado: {productoSeleccionado.Nombre} (ID: {productoSeleccionado.IdProducto})", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
