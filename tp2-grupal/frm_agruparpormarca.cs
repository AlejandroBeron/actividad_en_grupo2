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
    public partial class frm_agruparpormarca : Form
    {
        private List<Articulos> lista_articulos;

        public frm_agruparpormarca()
        {
            InitializeComponent();
        }

        private void dgv_agruparmarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_agruparpormarca_Load(object sender, EventArgs e)
        {
            marca_negocio marcanegocio = new marca_negocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();


            try
            {

                cb_marcas.DataSource = marcanegocio.Listar();
                cb_marcas.ValueMember = "Codigo";
                cb_marcas.DisplayMember = "Nombre";
               
                cb_categorias.DataSource = categorianegocio.listar();
                cb_categorias.ValueMember = "codigo_categoria";
                cb_categorias.DisplayMember = "nombre_categoria";


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    

        private void b_lmarca_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            
            lista_articulos =negocio.listar((Marca)cb_marcas.SelectedItem);
            try
            {
                if (lista_articulos.Count != 0)
                {
                    dgv_agruparmarca.DataSource = lista_articulos;
                dgv_agruparmarca.Columns["Id_a"].Visible = false;
                dgv_agruparmarca.Columns["imagen_a"].Visible = false;
                dgv_agruparmarca.Columns["urlimagen"].Visible = false;
                }
                else
                {
                    MessageBox.Show("La marca solicitada no cuenta con ningun articulo");
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        private void b_lcate_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarcategoria((Categoria)cb_categorias.SelectedItem);

            try
            {
                if (lista_articulos.Count!=0)
                {
                    dgv_agruparmarca.DataSource = lista_articulos;
                    dgv_agruparmarca.Columns["Id_a"].Visible = false;
                    dgv_agruparmarca.Columns["imagen_a"].Visible = false;
                    dgv_agruparmarca.Columns["urlimagen"].Visible = false;
                }
                else { 
                    MessageBox.Show("La categoria solicitada no cuenta con ningun articulo");
                }




            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        private void cb_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
