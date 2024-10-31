using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionDesktopProgram
{
    public partial class FormHome : KryptonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISubastaBusiness _subastaBusiness;
        private readonly IProductoBusiness _productoBusiness;

        public FormHome(ISubastaBusiness subastaBusiness, IProductoBusiness productoBusiness, IServiceProvider serviceProvider)
        {
            _subastaBusiness = subastaBusiness;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            btnBuscar.Click += btnBuscar_Click;
            _productoBusiness = productoBusiness;
            _serviceProvider = serviceProvider;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarSubastas();
        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            CargarSubastas();
        }

        /* private void SubastaDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
         }*/

        private void SubastaDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (SubastaDataGrid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int idSubasta = (int)SubastaDataGrid.Rows[e.RowIndex].Cells["IdSubasta"].Value;
                    EditarSubasta(idSubasta);
                }

                else if (SubastaDataGrid.Columns[e.ColumnIndex].Name == "VerResumen")
                {
                    int idSubasta = (int)SubastaDataGrid.Rows[e.RowIndex].Cells["IdSubasta"].Value;
                    VerResumenSubasta(idSubasta);
                }
            }
        }

        private void CargarSubastas(string filtroDescripcion = "")
        {

            var subastas = _subastaBusiness.GetAll();


            if (!string.IsNullOrEmpty(filtroDescripcion))
            {
                subastas = subastas.Where(s => s.Descripcion.Contains(filtroDescripcion, StringComparison.OrdinalIgnoreCase)).ToList();
            }


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
            if (!SubastaDataGrid.Columns.Contains("Editar") && !SubastaDataGrid.Columns.Contains("VerResumen"))
            {
                var editarButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                SubastaDataGrid.Columns.Add(editarButtonColumn);

                var verResumenButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "VerResumen",
                    HeaderText = "Ver Resumen",
                    Text = "Ver resumen",
                    UseColumnTextForButtonValue = true,
                };
                SubastaDataGrid.Columns.Add(verResumenButtonColumn);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string filtroDescripcion = txtFiltroDescipcion.Text.Trim();
            CargarSubastas(filtroDescripcion);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void EditarSubasta(int idSubasta)
        {
            var subastaSeleccionada = _subastaBusiness.GetAll().FirstOrDefault(s => s.IdSubasta == idSubasta);

            if (subastaSeleccionada != null)
            {
                EditarSubastaForm editarForm = new EditarSubastaForm(subastaSeleccionada, _subastaBusiness);
                editarForm.ShowDialog();

                CargarSubastas();
            }
        }

        private void VerResumenSubasta(int idSubasta)
        {
            // Obtener las instancias
            var formProductos = _serviceProvider.GetService<FormProductos>();
            var mainpag = _serviceProvider.GetService<Mainpage>();
            var idsubasta = idSubasta;

            // Verificar instancias
            if (formProductos == null)
            {
                MessageBox.Show("No se pudo obtener la instancia de FormProductos.");
                return;
            }

            if (mainpag == null)
            {
                MessageBox.Show("No se pudo obtener la instancia de Mainpage.");
                return;
            }

            // Intentar mostrar el formulario
            try
            {
                formProductos.TopLevel = false;
                formProductos.Dock = DockStyle.Fill;

                formProductos.SetSubastaId(idsubasta);

                mainpag.openPanel2(formProductos);

                // Forzar visibilidad y enviar al frente
                formProductos.Visible = true;
                formProductos.BringToFront();

                // Comprobar visibilidad de nuevo
                if (!formProductos.Visible)
                {
                    MessageBox.Show("FormProductos no se mostró correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir FormProductos: " + ex.Message);
            }
        }





    }
}