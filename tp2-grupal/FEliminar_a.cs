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
    public partial class FEliminar_a : Form
    {
        private List<Articulos> lista_articulos;
        public FEliminar_a()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

                lista_articulos = negocio.listar();
                dgv_eliminara.DataSource = lista_articulos;
                dgv_eliminara.Columns["Id_a"].Visible = false;
                dgv_eliminara.Columns["imagen_a"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEliminar_a_Load(object sender, EventArgs e)
        {
            cargar();
                    dgv_eliminara.Columns["precio_a"].Visible = false;
                    dgv_eliminara.Columns["imagen_a"].Visible = false;
                    dgv_eliminara.Columns["descripcion_a"].Visible = false;
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos selec;
            int aux;

            try
            {
                DialogResult respuesta = MessageBox.Show("se eliminara el articulo seleccionado, ¿continuar?", "ELIMINAR MARCA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selec = (Articulos)dgv_eliminara.CurrentRow.DataBoundItem;
                    aux = selec.Id_a;
                    negocio.Eliminar(aux);
                    dgv_eliminara.DataSource = negocio.listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
