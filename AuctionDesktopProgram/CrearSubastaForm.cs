using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;
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
    public partial class CrearSubastaForm : KryptonForm
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
            var errors = ValidateInput();

            if (errors.Count > 0)
            {
                var feedback = new StringBuilder();
                foreach (var error in errors)
                {
                    feedback.AppendLine($"*{error.ToString()}");
                }

                MessageBox.Show($"Datos invalidos:\n{feedback}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
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
                catch(Exception ex) {
                    MessageBox.Show($"Error al crear la subasta {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private List<string> ValidateInput()
        {
            var validationErrors = new List<string>();

            DateTime startDate = dtpFechaInicio.Value;
            DateTime endDate = dtpFechaCierre.Value;

            if (startDate <= DateTime.Now.AddDays(1))
            {
                validationErrors.Add("La fecha de inicio debe ser como minimo dentro de un día");
            }

            if (startDate >= endDate)
            {
                validationErrors.Add("La fecha de cierre no puede ser menor o igual a la de inicio");
            }


            const int maxDescriptionLength = 255;
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                validationErrors.Add("La descripción no puede estar vacía");
            }
            else if (txtDescripcion.Text.Length > maxDescriptionLength)
            {
                validationErrors.Add($"La descripción no puede exceder {maxDescriptionLength} caracteres");
            }

            if (string.IsNullOrWhiteSpace(txtFormaPago.Text))
            {
                validationErrors.Add("Debe ingresar una forma de pago");
            }

            if (string.IsNullOrWhiteSpace(txtModoEntrega.Text))
            {
                validationErrors.Add("Debe ingresar un modo de entrega");
            }

            return validationErrors;
        }
    }
}
