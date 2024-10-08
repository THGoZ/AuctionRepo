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
    public partial class CrearSubastaForm : Form
    {
        private readonly ISubastaBusiness _subastaBusiness;

        public CrearSubastaForm(ISubastaBusiness subastaBusiness)
        {
            InitializeComponent();
            _subastaBusiness = subastaBusiness;
        }

        private void CrearSubastaForm_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var nuevaSubasta = new Subasta
            {
                FechaInicio = dtpFechaInicio.Value,
                FechaCierre = dtpFechaCierre.Value,
                Descripcion = txtDescripcion.Text,
                ModoEntrega = txtModoEntrega.Text.Split(',').ToArray(), 
                FormaDePago = txtFormaPago.Text.Split(',').ToArray(),   
                Estado = null 
            };

          
            _subastaBusiness.CrearSubasta(nuevaSubasta);

            MessageBox.Show("Subasta creada exitosamente!");
            this.Close();
        }
    }
}
