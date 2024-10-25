using Auction.Core.Business.Interfaces;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class Mainpage : KryptonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductoBusiness _productoBusiness;
        private Form activeForm = null;

        public Mainpage(IServiceProvider serviceProvider, IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
            _serviceProvider = serviceProvider;
            InitializeComponent();

            // Muestra formHome en panel2 al iniciar el formulario Mainpage
            var formHome = _serviceProvider.GetRequiredService<FormHome>();
            openPanel2(formHome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formHome = _serviceProvider.GetRequiredService<FormHome>();
            openPanel2(formHome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formProductos = _serviceProvider.GetService<FormProductos>();
            openPanel2(formProductos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_productoBusiness.GetProductosSolicitados().Any())
            {
                var solicitudes = new Solicitudes(_productoBusiness);
                openPanel2(solicitudes);
            }
            else
            {
                MessageBox.Show("No se encontraron productos solicitados pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formCrearSubasta = _serviceProvider.GetService<CrearSubastaForm>();
            openPanel2(formCrearSubasta);
        }

        private void openPanel2(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }
    }

}

