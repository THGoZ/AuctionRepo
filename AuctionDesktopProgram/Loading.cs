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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.backgroundWorker1.RunWorkerAsync();
        }
    }
}
