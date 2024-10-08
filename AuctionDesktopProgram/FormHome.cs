using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;

namespace AuctionDesktopProgram
{
    public partial class FormHome : KryptonForm
    {
        private readonly ISubastaBusiness _subastaBusiness;

        public FormHome(ISubastaBusiness subastaBusiness)
        {
            _subastaBusiness = subastaBusiness;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarSubastas();
        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            CargarSubastas();
        }

        private void SubastaDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var idSubasta = (int)SubastaDataGrid.Rows[e.RowIndex].Cells["IdSubasta"].Value;

                var subastaSeleccionada = _subastaBusiness.GetAll().FirstOrDefault(s => s.IdSubasta == idSubasta);

                if (subastaSeleccionada != null)
                {
                    EditarSubastaForm editarForm = new EditarSubastaForm(subastaSeleccionada, _subastaBusiness);
                    editarForm.ShowDialog();

                    CargarSubastas();
                }
            }
        }
        private void CargarSubastas()
        {
            var subastas = _subastaBusiness.GetAll();

            var listaSubastas = subastas.Select(s => new
            {
                IdSubasta = s.IdSubasta,
                FechaInicio = s.FechaInicio.ToString("dd/MM/yyyy"),
                FechaCierre = s.FechaCierre.ToString("dd/MM/yyyy"),
                Descripcion = s.Descripcion,
                ModoEntrega = string.Join(", ", s.ModoEntrega),
                FormaDePago = string.Join(", ", s.FormaDePago),
                Estado = s.Estado.HasValue ? (s.Estado.Value ? "Activa" : "Finalizada") : "Próxima"
            }).ToList();

            SubastaDataGrid.DataSource = listaSubastas;
        }
    }
}