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
    public partial class F_listar_c : Form
    {
        private List<Categoria> lista_Categoria;
        public F_listar_c()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                lista_Categoria = negocio.listar();
                dgv_Categoria.DataSource = lista_Categoria;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        private void F_listar_c_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            lista_Categoria = negocio.listar();
            dgv_Categoria.DataSource = lista_Categoria;
            

        }

        private void btn_salir_LC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void M_categoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgv_Categoria.CurrentRow.DataBoundItem;

            FAgregar_Categoria modificar = new FAgregar_Categoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void Eliminar_c_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria selec;
            int aux;

            try
            {
                DialogResult respuesta = MessageBox.Show("se eliminara la categoria seleccionada, ¿continuar?", "ELIMINAR MARCA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selec = (Categoria)dgv_Categoria.CurrentRow.DataBoundItem;
                    aux = selec.codigo_categoria;
                    negocio.Eliminar(aux);
                    dgv_Categoria.DataSource = negocio.listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
