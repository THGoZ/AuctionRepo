using Auction.Core.Business;
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
    public partial class EditarSubastaForm : KryptonForm
    {
        private Subasta _subasta;
        private readonly ISubastaBusiness _subastaBusiness;

        public EditarSubastaForm(Subasta subasta, ISubastaBusiness subastaBusiness)
        {
            InitializeComponent();
            _subasta = subasta;
            _subastaBusiness = subastaBusiness;

            dtpFechaInicio.Value = _subasta.FechaInicio;
            dtpFechaCierre.Value = _subasta.FechaCierre;
            txtFormaPago.Text = string.Join(", ", subasta.FormaDePago);
            txtModoEntrega.Text = string.Join(", ", subasta.ModoEntrega);
            txtDescripcion.Text = _subasta.Descripcion.ToString();
        }

        private void EditarSubastaForm_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            _subasta.FechaInicio = dtpFechaInicio.Value;
            _subasta.FechaCierre = dtpFechaCierre.Value;
            _subasta.Descripcion = txtDescripcion.Text;

            _subasta.FormaDePago = txtFormaPago.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            _subasta.ModoEntrega = txtModoEntrega.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
                    _subastaBusiness.EditarSubasta(_subasta);
                    MessageBox.Show($"Subasta N°{_subasta.IdSubasta} actualizada correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar los datos\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinalizarSubasta_Click(object sender, EventArgs e)
        {
            // Confirmar que desea finalizar la subasta
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas finalizar esta subasta?",
                                                 "Confirmar finalización",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Marcar la subasta como finalizada
                _subasta.Estado = false; // Activa = true / Finalizada = false

                // Guardar los cambios en la base de datos
                _subastaBusiness.EditarSubasta(_subasta); // Método para editar subasta
                MessageBox.Show("La subasta ha sido finalizada.");

                this.Close(); // Cerrar el formulario
            }
        }

        private List<string> ValidateInput()
        {
            var validationErrors = new List<string>();

            DateTime startDate = dtpFechaInicio.Value;
            DateTime endDate = dtpFechaCierre.Value;

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
