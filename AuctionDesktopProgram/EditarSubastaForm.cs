using Auction.Core.Business;
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
    public partial class EditarSubastaForm : Form
    {
        private Subasta _subasta;
        private readonly ISubastaBusiness _subastaBusiness;

        public EditarSubastaForm(Subasta subasta, ISubastaBusiness subastaBusiness)
        {
            InitializeComponent();
            _subasta = subasta;
            _subastaBusiness = subastaBusiness;

            dtpFechaInicio.Text = _subasta.FechaInicio.ToString();
            dtpFechaCierre.Text = _subasta.FechaCierre.ToString();
            txtFormaPago.Text = string.Join(", ", subasta.FormaDePago);
            txtModoEntrega.Text = string.Join(", ", subasta.ModoEntrega); 
            txtDescripcion.Text = _subasta.Descripcion.ToString();
        }

        private void EditarSubastaForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
           
            _subasta.FechaInicio = dtpFechaInicio.Value;
            _subasta.FechaCierre = dtpFechaCierre.Value;
            _subasta.Descripcion = txtDescripcion.Text;

            _subasta.FormaDePago = txtFormaPago.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            _subasta.ModoEntrega = txtModoEntrega.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            _subastaBusiness.EditarSubasta(_subasta);

        
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
