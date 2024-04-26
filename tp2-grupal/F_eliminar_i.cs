using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp2_grupal
{
    public partial class F_eliminar_i : Form
    {
        public F_eliminar_i()
        {
            InitializeComponent();
        }

        private void b_cancel_ei_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
