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
    public partial class Informes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductoBusiness _productoBusiness;
        private Form? activeForm;
        public Informes(IServiceProvider serviceProvider, IProductoBusiness productoBusiness)
        {
            _serviceProvider = serviceProvider;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            var formGanacias = _serviceProvider.GetService<Ganancias>();
            openPanel2(formGanacias);
            kryptonCheckButton1.Checked = true;
            kryptonCheckButton4.Enabled = true;
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
            kryptonCheckButton2.Checked = false;
            kryptonCheckButton3.Checked = false;
            kryptonCheckButton4.Checked = false;
            kryptonCheckButton5.Checked = false;
            var formGanacias = _serviceProvider.GetService<Ganancias>();
            openPanel2(formGanacias);
        }

        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            kryptonCheckButton1.Checked = false;
            kryptonCheckButton3.Checked = false;
            kryptonCheckButton4.Checked = false;
            kryptonCheckButton5.Checked = false;
            var formProductosvendidos = _serviceProvider.GetService<FormVendidos>();
            openPanel2(formProductosvendidos);
        }


        private void kryptonCheckButton3_Click(object sender, EventArgs e)
        {
            kryptonCheckButton1.Checked = false;
            kryptonCheckButton2.Checked = false;
            kryptonCheckButton4.Checked = false;
            kryptonCheckButton5.Checked = false;
            var formProductosNoOfertados = _serviceProvider.GetService<ProductosNoOfertados>();
            openPanel2(formProductosNoOfertados);
        }

        private void openPanel2(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Dispose();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        private void kryptonCheckButton4_Click(object sender, EventArgs e)
        {
            kryptonCheckButton1.Checked = false;
            kryptonCheckButton2.Checked = false;
            kryptonCheckButton3.Checked = false;
            kryptonCheckButton4.Checked = true;
            kryptonCheckButton5.Checked = false;
            var formMasVendidos = _serviceProvider.GetService<FormMasVendidos>();
            openPanel2(formMasVendidos);
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }

        private void kryptonCheckButton5_Click(object sender, EventArgs e)
        {
            kryptonCheckButton1.Checked = false;
            kryptonCheckButton2.Checked = false;
            kryptonCheckButton3.Checked = false;
            kryptonCheckButton4.Checked = false;
            kryptonCheckButton5.Checked = true;
            var formResumenProductos = _serviceProvider.GetRequiredService<FormProductos>();
            openPanel2(formResumenProductos);
        }
    }
}
