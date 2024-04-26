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
    public partial class Frm_marcas : Form
    {
        public Frm_marcas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_Agregar_M))
                    return;
            }
            F_Agregar_M FAgregar = new F_Agregar_M();
            FAgregar.Show();

        }
        

        private void b_volve_m_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_listar_m_Click(object sender, EventArgs e)
        {

        }

        private void b_eliminar_m_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(F_Eliminar_M))
                    return;
            }
            F_Eliminar_M FEliminar = new F_Eliminar_M();
            FEliminar.Show();
        }

        private void b_listar_m_Click_1(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(F_Listar_M))
                    return;
            }
            F_Listar_M FListar = new F_Listar_M();
            FListar.Show();
        }
    }
}
