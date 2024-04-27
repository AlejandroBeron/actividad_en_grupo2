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

            try
            {

                cb_marcas.DataSource = marcanegocio.Listar();
                cb_marcas.ValueMember = "Codigo";
                cb_marcas.DisplayMember = "Nombre";

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
            //articulos.marca_a = (Marca)cb_marcas.SelectedItem;
            lista_articulos =negocio.listar((Marca)cb_marcas.SelectedItem);
            try
            {
                dgv_agruparmarca.DataSource = lista_articulos;
                dgv_agruparmarca.Columns["Id_a"].Visible = false;

                //dgv_agruparmarca.Columns["Categoria"].Visible = false;    
              

               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());ç
                throw ex;
            }

        }
    }
}
