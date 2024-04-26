using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_grupal
{
    public partial class Frm_Imagen : Form
    {
        public Frm_Imagen()
        {
            InitializeComponent();
        }

        private void b_Imagen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_agregar_im_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_agregar_i))
                    return;
            }
            F_agregar_i FAgri = new F_agregar_i();
            FAgri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_listar_i))
                    return;
            }
            F_listar_i Flisti = new F_listar_i();
            Flisti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_eliminar_i))
                    return;
            }
            F_eliminar_i Felimi = new F_eliminar_i();
            Felimi.Show();
        }
    }
}
