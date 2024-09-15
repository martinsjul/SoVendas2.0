using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void lblDupla_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
