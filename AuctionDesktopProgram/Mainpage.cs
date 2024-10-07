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
    public partial class Mainpage : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Mainpage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formHome = _serviceProvider.GetRequiredService<FormHome>();
            formHome.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formProductos = _serviceProvider.GetService<FormProductos>();
            formProductos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var solicitudes = _serviceProvider.GetRequiredService<Solicitudes>();
            solicitudes.ShowDialog();
        }
    }
}
