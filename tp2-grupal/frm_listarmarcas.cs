using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp2_grupal
{
    public partial class F_Listar_M : Form
    {
        public F_Listar_M()
        {
            InitializeComponent();
        }

        private void btn_salir_listarmarcas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_Listar_M_Load(object sender, EventArgs e)
        {
            marca_negocio negocio = new marca_negocio();
            dgv_marcas.DataSource = negocio.Listar();
        }

        private void l_listarmarca_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            marca_negocio negocio = new marca_negocio();
            Marca selec;
            int aux;

            try
            {
                DialogResult respuesta =MessageBox.Show("se eliminara la marca seleccionada, ¿continuar?","ELIMINAR MARCA",MessageBoxButtons.YesNo,MessageBoxIcon.Warning );

                if (respuesta == DialogResult.Yes)
                { 
                selec = (Marca)dgv_marcas.CurrentRow.DataBoundItem;
                aux = selec.Codigo;
                negocio.Eliminar(aux);
                dgv_marcas.DataSource = negocio.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
