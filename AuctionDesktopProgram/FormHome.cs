using Auction.Core.Business;
using Auction.Core.Business.Interfaces;
using Auction.Core.Entities;
using AuctionDesktopProgram.Helper;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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


            var listaSubastas = subastas.Select(s => new SubastaDisplay
            {
                IdSubasta = s.IdSubasta,
                FechaInicio = s.FechaInicio.ToString("dd/MM/yyyy"),
                FechaCierre = s.FechaCierre.ToString("dd/MM/yyyy"),
                Descripcion = s.Descripcion,
                ModoEntrega = string.Join(", ", s.ModoEntrega),
                FormaDePago = string.Join(", ", s.FormaDePago),
                Estado = s.Estado.HasValue ? (s.Estado.Value ? "Activa" : "Finalizada") : "Próxima"
            }).ToList();

            var sortableListSubasta = new SortableBindingList<SubastaDisplay>(listaSubastas);


            SubastaDataGrid.DataSource = sortableListSubasta;
            //if (!SubastaDataGrid.Columns.Contains("Editar") && !SubastaDataGrid.Columns.Contains("VerResumen"))
            //{
            //    var editarButtonColumn = new KryptonDataGridViewButtonColumn
            //    {
            //        Name = "Editar",
            //        HeaderText = "Editar",
            //        Text = "Editar",
            //        UseColumnTextForButtonValue = true
            //    };
            //    SubastaDataGrid.Columns.Add(editarButtonColumn);

            //    var verResumenButtonColumn = new KryptonDataGridViewButtonColumn
            //    {
            //        Name = "VerResumen",
            //        HeaderText = "Ver Resumen",
            //        Text = "Ver resumen",
            //        UseColumnTextForButtonValue = true,
            //    };
            //    SubastaDataGrid.Columns.Add(verResumenButtonColumn);
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string filtroDescripcion = txtFiltroDescipcion.Text.Trim();
            CargarSubastas(filtroDescripcion);
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
            var subastaSeleccionada = _subastaBusiness.GetAll().FirstOrDefault(s => s.IdSubasta == idSubasta);


            if (subastaSeleccionada != null)
            {
                Resumen resumenForm = new Resumen(_subastaBusiness, _productoBusiness, idSubasta);
                resumenForm.ShowDialog();

                CargarSubastas();
            }

            //var formProductos = _serviceProvider.GetService<FormProductos>();
            //var mainpag = _serviceProvider.GetService<Mainpage>();
            //var idsubasta = idSubasta;


            //if (formProductos == null)
            //{
            //    MessageBox.Show("No se pudo obtener la instancia de FormProductos.");
            //    return;
            //}

            //if (mainpag == null)
            //{
            //    MessageBox.Show("No se pudo obtener la instancia de Mainpage.");
            //    return;
            //}


            //try
            //{
            //    formProductos.TopLevel = false;
            //    formProductos.Dock = DockStyle.Fill;

            //    formProductos.SetSubastaId(idsubasta);

            //    mainpag.openPanel2(formProductos);


            //    formProductos.Visible = true;
            //    formProductos.BringToFront();


            //    if (!formProductos.Visible)
            //    {
            //        MessageBox.Show("FormProductos no se mostró correctamente.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al intentar abrir FormProductos: " + ex.Message);
            //}
        }

        private void btnCrearSubasta_Click(object sender, EventArgs e)
        {
            CrearSubastaForm crearSubastaForm = new CrearSubastaForm(_subastaBusiness);
            crearSubastaForm.ShowDialog();
            CargarSubastas();
        }
    }
}