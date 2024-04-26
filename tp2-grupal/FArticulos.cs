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
    public partial class FArticulos : Form
    {
        public FArticulos()
        {
            InitializeComponent();
        }

        private void b_Detalles_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Fdetalles_a))
                    return;
            }
            Fdetalles_a Fdeta = new Fdetalles_a();
            Fdeta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           Close();
        }

        private void b_Agregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FAgregar_a))
                    return;
            }
            FAgregar_a FAgra = new FAgregar_a();
            FAgra.ShowDialog();
        }

        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FEliminar_a))
                    return;
            }
            FEliminar_a Felima = new FEliminar_a();
            Felima.Show();
        }

        private void b_Modificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FModificar_a))
                    return;
            }
            FModificar_a Fmodia = new FModificar_a();
            Fmodia.Show();
        }

        private void b_Listar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FListar_a))
                    return;
            }
            FListar_a Flisa = new FListar_a();
            Flisa.Show();
        }
    }
}
