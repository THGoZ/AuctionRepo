using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using AuctionDesktopProgram.Helper;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.IdentityModel.Tokens;
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
        private readonly Loading loadingForm = new Loading();
        private Panel MainPanel;
        private Panel LoadingPanel;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonDataGridView SubastaDataGrid;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBoxImagen;
        private Label kryptonMaskedTextBoxName;
        private Label kryptonMaskedTextBoxPrecioBase;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxDescripcion;
        private Label lblDescripcion;
        private Krypton.Toolkit.KryptonButton kryptonButtonAceptar;
        private Krypton.Toolkit.KryptonButton kryptonButtonRechazar;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nombre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Descripcion;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn FechaSolicitud;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PrecioBase;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Usuario;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn subasta;
        private BackgroundWorker LoadingProcess;
        private FlowLayoutPanel flowLayoutPanel1;
        private KryptonTextBox txtFiltroDescipcion;
        private KryptonButton btnBuscar;
        private ProductoSolicitudDisplay productoSeleccionado;
        private SortableBindingList<ProductoSolicitudDisplay> productoWinnerBindingList;

        public Solicitudes(IProductoBusiness productoBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
        }
        #region boludeces
        private void InitializeComponent()
        {
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            MainPanel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDescripcion = new Label();
            kryptonPictureBoxImagen = new KryptonPictureBox();
            kryptonButtonAceptar = new KryptonButton();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            kryptonButtonRechazar = new KryptonButton();
            kryptonMaskedTextBoxName = new Label();
            kryptonMaskedTextBoxPrecioBase = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtFiltroDescipcion = new KryptonTextBox();
            btnBuscar = new KryptonButton();
            SubastaDataGrid = new KryptonDataGridView();
            Id = new KryptonDataGridViewTextBoxColumn();
            Nombre = new KryptonDataGridViewTextBoxColumn();
            Descripcion = new KryptonDataGridViewTextBoxColumn();
            FechaSolicitud = new KryptonDataGridViewDateTimePickerColumn();
            PrecioBase = new KryptonDataGridViewTextBoxColumn();
            Usuario = new KryptonDataGridViewTextBoxColumn();
            subasta = new KryptonDataGridViewTextBoxColumn();
            LoadingPanel = new Panel();
            kryptonRichTextBoxDescripcion = new KryptonRichTextBox();
            LoadingProcess = new BackgroundWorker();
            MainPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            foreverGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)SubastaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.Controls.Add(tableLayoutPanel3);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1128, 749);
            MainPanel.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(foreverGroupBox1, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(30, 0, 30, 30);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1128, 749);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(33, 3);
            panel1.Margin = new Padding(3, 3, 3, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 0, 0, 20);
            panel1.Size = new Size(514, 81);
            panel1.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(30, 25);
            label7.Margin = new Padding(20, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(333, 33);
            label7.TabIndex = 6;
            label7.Text = "Solicitudes de productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12.25F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(30, 58);
            label6.Margin = new Padding(3, 0, 3, 20);
            label6.MaximumSize = new Size(500, 60);
            label6.Name = "label6";
            label6.Size = new Size(481, 20);
            label6.TabIndex = 7;
            label6.Text = "Acepta y rechaza las solicitudes de productos de cada subasta";
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.Anchor = AnchorStyles.None;
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.FromArgb(23, 23, 23);
            foreverGroupBox1.Controls.Add(tableLayoutPanel1);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(740, 152);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = false;
            foreverGroupBox1.ShowText = false;
            foreverGroupBox1.Size = new Size(342, 498);
            foreverGroupBox1.TabIndex = 6;
            foreverGroupBox1.Text = "foreverGroupBox1";
            foreverGroupBox1.TextColor = Color.FromArgb(35, 168, 109);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 2);
            tableLayoutPanel1.Controls.Add(kryptonPictureBoxImagen, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonButtonAceptar, 0, 3);
            tableLayoutPanel1.Controls.Add(kryptonButtonRechazar, 1, 3);
            tableLayoutPanel1.Controls.Add(kryptonMaskedTextBoxName, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonMaskedTextBoxPrecioBase, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Roboto", 11.25F);
            tableLayoutPanel1.ForeColor = Color.LimeGreen;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(342, 498);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoEllipsis = true;
            lblDescripcion.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblDescripcion, 2);
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 12.25F);
            lblDescripcion.ForeColor = Color.Gray;
            lblDescripcion.Location = new Point(13, 350);
            lblDescripcion.Margin = new Padding(3, 10, 3, 0);
            lblDescripcion.MaximumSize = new Size(500, 60);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(316, 60);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Seleccione un producto para ver los detalles";
            // 
            // kryptonPictureBoxImagen
            // 
            kryptonPictureBoxImagen.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(kryptonPictureBoxImagen, 2);
            kryptonPictureBoxImagen.Image = Properties.Resources.placeholder_image;
            kryptonPictureBoxImagen.Location = new Point(13, 13);
            kryptonPictureBoxImagen.Name = "kryptonPictureBoxImagen";
            kryptonPictureBoxImagen.Size = new Size(316, 280);
            kryptonPictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBoxImagen.TabIndex = 9;
            kryptonPictureBoxImagen.TabStop = false;
            // 
            // kryptonButtonAceptar
            // 
            kryptonButtonAceptar.Anchor = AnchorStyles.None;
            kryptonButtonAceptar.ButtonStyle = ButtonStyle.Custom2;
            kryptonButtonAceptar.Enabled = false;
            kryptonButtonAceptar.Location = new Point(22, 444);
            kryptonButtonAceptar.Name = "kryptonButtonAceptar";
            kryptonButtonAceptar.OverrideDefault.Back.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideDefault.Back.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideDefault.Border.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideDefault.Border.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.OverrideFocus.Back.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideFocus.Back.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideFocus.Border.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideFocus.Border.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.Palette = kryptonCustomPaletteBase1;
            kryptonButtonAceptar.PaletteMode = PaletteMode.Custom;
            kryptonButtonAceptar.Size = new Size(136, 30);
            kryptonButtonAceptar.StateCommon.Back.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateCommon.Back.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateCommon.Border.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateCommon.Border.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.StateDisabled.Back.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateDisabled.Back.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateDisabled.Border.Color1 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateDisabled.Border.Color2 = Color.FromArgb(75, 191, 115);
            kryptonButtonAceptar.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.StateDisabled.Content.ShortText.Color1 = Color.Black;
            kryptonButtonAceptar.StateDisabled.Content.ShortText.Color2 = Color.Black;
            kryptonButtonAceptar.StatePressed.Back.Color1 = Color.FromArgb(64, 162, 98);
            kryptonButtonAceptar.StatePressed.Back.Color2 = Color.FromArgb(64, 162, 98);
            kryptonButtonAceptar.StatePressed.Border.Color1 = Color.FromArgb(64, 162, 98);
            kryptonButtonAceptar.StatePressed.Border.Color2 = Color.FromArgb(64, 162, 98);
            kryptonButtonAceptar.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.StateTracking.Back.Color1 = Color.FromArgb(110, 220, 140);
            kryptonButtonAceptar.StateTracking.Back.Color2 = Color.FromArgb(110, 220, 140);
            kryptonButtonAceptar.StateTracking.Border.Color1 = Color.FromArgb(110, 220, 140);
            kryptonButtonAceptar.StateTracking.Border.Color2 = Color.FromArgb(110, 220, 140);
            kryptonButtonAceptar.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonAceptar.TabIndex = 11;
            kryptonButtonAceptar.Values.Text = "Aceptar";
            kryptonButtonAceptar.Click += kryptonButtonAceptar_Click;
            // 
            // kryptonButtonRechazar
            // 
            kryptonButtonRechazar.Anchor = AnchorStyles.None;
            kryptonButtonRechazar.ButtonStyle = ButtonStyle.Custom2;
            kryptonButtonRechazar.Enabled = false;
            kryptonButtonRechazar.Location = new Point(183, 444);
            kryptonButtonRechazar.Name = "kryptonButtonRechazar";
            kryptonButtonRechazar.OverrideDefault.Back.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.OverrideDefault.Back.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.OverrideDefault.Border.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.OverrideDefault.Border.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonRechazar.Palette = kryptonCustomPaletteBase1;
            kryptonButtonRechazar.PaletteMode = PaletteMode.Custom;
            kryptonButtonRechazar.Size = new Size(136, 30);
            kryptonButtonRechazar.StateCommon.Back.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateCommon.Back.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateCommon.Border.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateCommon.Border.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonRechazar.StateDisabled.Back.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateDisabled.Back.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateDisabled.Border.Color1 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateDisabled.Border.Color2 = Color.FromArgb(217, 83, 79);
            kryptonButtonRechazar.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonRechazar.StateDisabled.Content.ShortText.Color1 = Color.Black;
            kryptonButtonRechazar.StateDisabled.Content.ShortText.Color2 = Color.Black;
            kryptonButtonRechazar.StatePressed.Back.Color1 = Color.FromArgb(184, 71, 67);
            kryptonButtonRechazar.StatePressed.Back.Color2 = Color.FromArgb(184, 71, 67);
            kryptonButtonRechazar.StatePressed.Border.Color1 = Color.FromArgb(184, 71, 67);
            kryptonButtonRechazar.StatePressed.Border.Color2 = Color.FromArgb(184, 71, 67);
            kryptonButtonRechazar.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonRechazar.StateTracking.Back.Color1 = Color.FromArgb(230, 100, 90);
            kryptonButtonRechazar.StateTracking.Back.Color2 = Color.FromArgb(230, 100, 90);
            kryptonButtonRechazar.StateTracking.Border.Color1 = Color.FromArgb(230, 100, 90);
            kryptonButtonRechazar.StateTracking.Border.Color2 = Color.FromArgb(230, 100, 90);
            kryptonButtonRechazar.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonRechazar.TabIndex = 12;
            kryptonButtonRechazar.Values.Text = "Rechazar";
            kryptonButtonRechazar.Click += kryptonButtonRechazar_Click;
            // 
            // kryptonMaskedTextBoxName
            // 
            kryptonMaskedTextBoxName.Anchor = AnchorStyles.None;
            kryptonMaskedTextBoxName.AutoEllipsis = true;
            kryptonMaskedTextBoxName.AutoSize = true;
            kryptonMaskedTextBoxName.Font = new Font("Roboto", 13.25F);
            kryptonMaskedTextBoxName.ForeColor = SystemColors.ButtonFace;
            kryptonMaskedTextBoxName.Location = new Point(37, 296);
            kryptonMaskedTextBoxName.Margin = new Padding(0);
            kryptonMaskedTextBoxName.Name = "kryptonMaskedTextBoxName";
            kryptonMaskedTextBoxName.Size = new Size(107, 44);
            kryptonMaskedTextBoxName.TabIndex = 13;
            kryptonMaskedTextBoxName.Text = "Nombre del producto";
            // 
            // kryptonMaskedTextBoxPrecioBase
            // 
            kryptonMaskedTextBoxPrecioBase.Anchor = AnchorStyles.None;
            kryptonMaskedTextBoxPrecioBase.AutoSize = true;
            kryptonMaskedTextBoxPrecioBase.Font = new Font("Roboto", 13.25F);
            kryptonMaskedTextBoxPrecioBase.Location = new Point(229, 307);
            kryptonMaskedTextBoxPrecioBase.Name = "kryptonMaskedTextBoxPrecioBase";
            kryptonMaskedTextBoxPrecioBase.Size = new Size(45, 22);
            kryptonMaskedTextBoxPrecioBase.TabIndex = 14;
            kryptonMaskedTextBoxPrecioBase.Text = "-------";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(SubastaDataGrid, 0, 1);
            tableLayoutPanel2.Location = new Point(33, 154);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(688, 494);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(txtFiltroDescipcion);
            flowLayoutPanel1.Controls.Add(btnBuscar);
            flowLayoutPanel1.Location = new Point(290, 9);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 55);
            flowLayoutPanel1.TabIndex = 9;
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
            SubastaDataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, FechaSolicitud, PrecioBase, Usuario, subasta });
            SubastaDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            SubastaDataGrid.GridStyles.Style = DataGridViewStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.GridStyles.StyleColumn = GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleDataCells = GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleRow = GridStyle.Custom1;
            SubastaDataGrid.Location = new Point(3, 77);
            SubastaDataGrid.MultiSelect = false;
            SubastaDataGrid.Name = "SubastaDataGrid";
            SubastaDataGrid.Palette = kryptonCustomPaletteBase1;
            SubastaDataGrid.PaletteMode = PaletteMode.Custom;
            SubastaDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle8.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            SubastaDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            SubastaDataGrid.RowTemplate.Height = 30;
            SubastaDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubastaDataGrid.Size = new Size(682, 414);
            SubastaDataGrid.TabIndex = 4;
            SubastaDataGrid.CurrentCellChanged += SubastaDataGrid_CurrentCellChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdProducto";
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.FillWeight = 40F;
            Id.HeaderText = "#";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 43;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 108;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 108;
            // 
            // FechaSolicitud
            // 
            FechaSolicitud.Checked = false;
            FechaSolicitud.DataPropertyName = "FechaDeSolicitud";
            FechaSolicitud.FillWeight = 130F;
            FechaSolicitud.HeaderText = "Fecha de solicitud";
            FechaSolicitud.Name = "FechaSolicitud";
            FechaSolicitud.ReadOnly = true;
            FechaSolicitud.Width = 141;
            // 
            // PrecioBase
            // 
            PrecioBase.DataPropertyName = "PrecioBase";
            PrecioBase.DefaultCellStyle = dataGridViewCellStyle5;
            PrecioBase.HeaderText = "Precio base";
            PrecioBase.Name = "PrecioBase";
            PrecioBase.ReadOnly = true;
            PrecioBase.Width = 108;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.DefaultCellStyle = dataGridViewCellStyle6;
            Usuario.FillWeight = 120F;
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 130;
            // 
            // subasta
            // 
            subasta.DataPropertyName = "IdSubasta";
            subasta.DefaultCellStyle = dataGridViewCellStyle7;
            subasta.FillWeight = 40F;
            subasta.HeaderText = "Subasta N°";
            subasta.Name = "subasta";
            subasta.ReadOnly = true;
            subasta.Width = 43;
            // 
            // LoadingPanel
            // 
            LoadingPanel.AutoScroll = true;
            LoadingPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadingPanel.Dock = DockStyle.Fill;
            LoadingPanel.Location = new Point(0, 0);
            LoadingPanel.Name = "LoadingPanel";
            LoadingPanel.Size = new Size(1128, 749);
            LoadingPanel.TabIndex = 0;
            // 
            // kryptonRichTextBoxDescripcion
            // 
            kryptonRichTextBoxDescripcion.CueHint.CueHintText = "Descripcion del producto...";
            kryptonRichTextBoxDescripcion.CueHint.TextH = PaletteRelativeAlign.Near;
            kryptonRichTextBoxDescripcion.CueHint.TextV = PaletteRelativeAlign.Near;
            kryptonRichTextBoxDescripcion.Dock = DockStyle.Fill;
            kryptonRichTextBoxDescripcion.Location = new Point(13, 317);
            kryptonRichTextBoxDescripcion.Name = "kryptonRichTextBoxDescripcion";
            kryptonRichTextBoxDescripcion.Size = new Size(316, 94);
            kryptonRichTextBoxDescripcion.TabIndex = 10;
            kryptonRichTextBoxDescripcion.Text = "";
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(23, 23, 23);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(23, 23, 23);
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(23, 23, 23);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(23, 23, 23);
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
            // LoadingProcess
            // 
            LoadingProcess.DoWork += LoadingProcess_DoWork;
            LoadingProcess.RunWorkerCompleted += LoadingProcess_RunWorkerCompleted;
            // 
            // Solicitudes
            // 
            BackColor = Color.FromArgb(39, 42, 45);
            ClientSize = new Size(1128, 749);
            Controls.Add(MainPanel);
            Controls.Add(LoadingPanel);
            Name = "Solicitudes";
            Text = "Solicitudes";
            Load += Solicitudes_Load;
            MainPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            foreverGroupBox1.ResumeLayout(false);
            foreverGroupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)kryptonPictureBoxImagen).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((ISupportInitialize)SubastaDataGrid).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private SortableBindingList<ProductoSolicitudDisplay> CargarProductosSolicitados()
        {
            var productosSolicitados = _productoBusiness.GetProductosSolicitados()
                .Select(prod => new ProductoSolicitudDisplay
                {
                    IdProducto = prod.IdProducto,
                    Nombre = prod.Nombre,
                    Descripcion = prod.Descripcion,
                    FechaDeSolicitud = prod.FechaSolicitud,
                    PrecioBase = prod.PrecioBase,
                    Imagen = prod.Imagen,
                    Usuario = ($"{prod.Usuario.Nombre}  {prod.Usuario.Apellido}"),
                    IdSubasta = prod.IdSubasta
                }).ToList();

            var sorableProductoList = new SortableBindingList<ProductoSolicitudDisplay>(productosSolicitados);
            productoWinnerBindingList = sorableProductoList;

            return sorableProductoList;
        }

        private void kryptonButtonRechazar_Click(object sender, EventArgs e)
        {
            DisableButtons();
            if (productoSeleccionado != null)
            {
                _productoBusiness.UpdateProducto(productoSeleccionado.IdProducto, false);

                MessageBox.Show($"El producto {productoSeleccionado.Nombre} ha sido rechazado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowLoading();
            this.LoadingProcess.RunWorkerAsync();
        }

        private void kryptonButtonAceptar_Click(object sender, EventArgs e)
        {
            DisableButtons();
            if (productoSeleccionado != null)
            {
                _productoBusiness.UpdateProducto(productoSeleccionado.IdProducto, true);

                MessageBox.Show($"El producto {productoSeleccionado.Nombre} ha sido aceptado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay un producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ShowLoading();
            this.LoadingProcess.RunWorkerAsync();
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            ShowLoading();
            this.LoadingProcess.RunWorkerAsync();
        }

        private void EnableButtons()
        {
            kryptonButtonAceptar.Enabled = true;
            kryptonButtonRechazar.Enabled = true;
        }

        private void DisableButtons()
        {
            kryptonButtonAceptar.Enabled = false;
            kryptonButtonRechazar.Enabled = false;
        }

        private void LoadingProcess_DoWork(object sender, DoWorkEventArgs e)
        {

            e.Result = CargarProductosSolicitados();
        }

        private void LoadingProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                var productosSolicitados = e.Result as SortableBindingList<ProductoSolicitudDisplay>;
                if (productosSolicitados.Count() != 0)
                {
                    SubastaDataGrid.DataSource = productosSolicitados;
                    LoadingPanel.SendToBack();
                    loadingForm.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontraron productos solicitados pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Error al cargar los datos.{e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ShowLoading()
        {
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            LoadingPanel.Controls.Add(loadingForm);
            LoadingPanel.Tag = loadingForm;
            LoadingPanel.BringToFront();
            LoadingPanel.Visible = true;
            loadingForm.Show();
        }

        private void ShowProductoDetails(ProductoSolicitudDisplay? producto = null)
        {
            if (producto == null)
            {
                DisableButtons();
                kryptonPictureBoxImagen.Image = Properties.Resources.placeholder_image;
                kryptonMaskedTextBoxName.Text = "Nombre del producto";
                lblDescripcion.Text = "Seleccione un producto para ver los detalles";
                kryptonMaskedTextBoxPrecioBase.Text = "-------";

            }
            else
            {
                kryptonMaskedTextBoxName.Text = productoSeleccionado.Nombre;
                lblDescripcion.Text = productoSeleccionado.Descripcion;
                kryptonMaskedTextBoxPrecioBase.Text = productoSeleccionado.PrecioBase.ToString("C");

                if (producto.Imagen != null)
                {
                    using (var ms = new MemoryStream(productoSeleccionado.Imagen))
                    {
                        kryptonPictureBoxImagen.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    kryptonPictureBoxImagen.Image = Properties.Resources.placeholder_image;
                }
            }
        }

        private void SubastaDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (SubastaDataGrid.CurrentCell != null)
            {
                productoSeleccionado = (ProductoSolicitudDisplay)SubastaDataGrid.CurrentRow.DataBoundItem;
                ShowProductoDetails(productoSeleccionado);
                EnableButtons();
            }
            else
            {
                ShowProductoDetails();
            }
        }

        private SortableBindingList<ProductoSolicitudDisplay> SearchProductos(string searchTerm = "")
        {
            if (searchTerm.IsNullOrEmpty())
            {
                return productoWinnerBindingList;
            }
            else
            {
                var source = productoWinnerBindingList.Where(p => p.Nombre.ToLower().Contains(searchTerm.Trim().ToLower()) || p.Descripcion.ToLower().Contains(searchTerm.Trim().ToLower())).ToList();
                var sortablelist = new SortableBindingList<ProductoSolicitudDisplay>(source);
                return sortablelist;
            }
        }

        private void txtFiltroDescipcion_TextChanged(object sender, EventArgs e)
        {
            SubastaDataGrid.DataSource = SearchProductos(txtFiltroDescipcion.Text);
        }
    }
}
