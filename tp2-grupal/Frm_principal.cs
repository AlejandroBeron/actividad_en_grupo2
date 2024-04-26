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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void b_articulos_Click(object sender, EventArgs e)
        { 
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(FArticulos))
                    return;
            }
            FArticulos FArt = new FArticulos();
            FArt.Show();
        }

        private void btn_marcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_marcas))
                    return;
            }
            Frm_marcas Fmarca = new Frm_marcas();
            Fmarca.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_categorias_Click(object sender, EventArgs e)
        {
            foreach( var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_categorias))
                    return; 
            }

            Frm_categorias Fcate = new Frm_categorias();
            Fcate.Show();
        }

        private void b_imagen_p_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_Imagen))
                    return;
            }

            Frm_Imagen FIma = new Frm_Imagen();
            FIma.Show();

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }
    }
}
