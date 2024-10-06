namespace AuctionDesktopProgram
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            SubastaDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            IdSubasta = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            FechaInicio = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            FechaCierre = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            Descripcion = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ModoEntrega = new Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            FormaDePago = new Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            Estado = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)SubastaDataGrid).BeginInit();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2010;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Back.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 9F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color1 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.Background.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color2 = Color.FromArgb(26, 26, 26);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = Color.FromArgb(220, 184, 78);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = Color.FromArgb(242, 160, 50);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(240, 173, 78);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color2 = Color.FromArgb(255, 180, 85);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(255, 192, 192);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.Red;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 90F;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // SubastaDataGrid
            // 
            SubastaDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubastaDataGrid.AutoGenerateColumns = false;
            SubastaDataGrid.BorderStyle = BorderStyle.None;
            SubastaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubastaDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdSubasta, FechaInicio, FechaCierre, Descripcion, ModoEntrega, FormaDePago, Estado });
            SubastaDataGrid.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            SubastaDataGrid.HideOuterBorders = true;
            SubastaDataGrid.Location = new Point(66, 64);
            SubastaDataGrid.Name = "SubastaDataGrid";
            SubastaDataGrid.Palette = kryptonCustomPaletteBase1;
            SubastaDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            SubastaDataGrid.RowHeadersVisible = false;
            SubastaDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubastaDataGrid.Size = new Size(703, 407);
            SubastaDataGrid.StateCommon.Background.Color1 = Color.FromArgb(26, 26, 26);
            SubastaDataGrid.StateCommon.Background.Color2 = Color.FromArgb(26, 26, 26);
            SubastaDataGrid.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            SubastaDataGrid.TabIndex = 0;
            SubastaDataGrid.SelectionChanged += SubastaDataGrid_SelectionChanged;
            // 
            // IdSubasta
            // 
            IdSubasta.DataPropertyName = "IdSubasta";
            dataGridViewCellStyle1.Font = new Font("Noto Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdSubasta.DefaultCellStyle = dataGridViewCellStyle1;
            IdSubasta.HeaderText = "Id";
            IdSubasta.Name = "IdSubasta";
            IdSubasta.ReadOnly = true;
            IdSubasta.ToolTipText = "Id de la subasta";
            IdSubasta.Width = 100;
            // 
            // FechaInicio
            // 
            FechaInicio.Checked = false;
            FechaInicio.CustomFormat = "d/M/yyyy";
            FechaInicio.DataPropertyName = "FechaInicio";
            FechaInicio.HeaderText = "Fecha de inicio";
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            FechaInicio.Resizable = DataGridViewTriState.True;
            FechaInicio.SortMode = DataGridViewColumnSortMode.Automatic;
            FechaInicio.Width = 100;
            // 
            // FechaCierre
            // 
            FechaCierre.Checked = false;
            FechaCierre.CustomFormat = "d/M/yyyy";
            FechaCierre.DataPropertyName = "FechaCierre";
            FechaCierre.HeaderText = "Fecha de cierre";
            FechaCierre.Name = "FechaCierre";
            FechaCierre.ReadOnly = true;
            FechaCierre.SortMode = DataGridViewColumnSortMode.Automatic;
            FechaCierre.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 100;
            // 
            // ModoEntrega
            // 
            ModoEntrega.DataPropertyName = "ModoEntrega";
            ModoEntrega.HeaderText = "Entrega";
            ModoEntrega.Name = "ModoEntrega";
            ModoEntrega.ReadOnly = true;
            ModoEntrega.Width = 100;
            // 
            // FormaDePago
            // 
            FormaDePago.DataPropertyName = "FormaDePago";
            FormaDePago.HeaderText = "Pago";
            FormaDePago.Name = "FormaDePago";
            FormaDePago.ReadOnly = true;
            FormaDePago.SortMode = DataGridViewColumnSortMode.Automatic;
            FormaDePago.Width = 100;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            Estado.DefaultCellStyle = dataGridViewCellStyle3;
            Estado.FalseValue = "Cerrada";
            Estado.HeaderText = "Estado";
            Estado.IndeterminateValue = "Proxima";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.TrueValue = "Abierta";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(66, 64);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(165, 46);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "bigLabel1";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(859, 498);
            Controls.Add(bigLabel1);
            Controls.Add(SubastaDataGrid);
            GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHome";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SubastaDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDataGridView SubastaDataGrid;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn IdSubasta;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn FechaInicio;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn FechaCierre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Descripcion;
        private Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn ModoEntrega;
        private Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn FormaDePago;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Estado;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}
