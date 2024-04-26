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
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        } 
        public Frm_categorias(Categoria seleccionado)
        {
            InitializeComponent();
        }


        private void btn_listar_modi_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_listar_c))
                    return;
            }
            F_listar_c Flisc = new F_listar_c();
            Flisc.Show();
        }

        private void b_volver_c_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_agregar_c_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FAgregar_Categoria))
                    return;
            }
            FAgregar_Categoria Fagrec = new FAgregar_Categoria();
            Fagrec.Show();
        }

        private void b_eliminar_c_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_listar_c))
                    return;
            }
            F_listar_c Flisc = new F_listar_c();
            Flisc.Show();
        }
    }
}
