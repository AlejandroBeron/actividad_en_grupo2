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
    public partial class FListar_a : Form
    {
        private List<Articulos> lista_articulos;
        
        public FListar_a()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FListar_a_Load(object sender, EventArgs e)
        {
            cargar();
           
        }
            private void cargar()
            {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

            lista_articulos = negocio.listar();
            dgv_articulos.DataSource = lista_articulos;
            dgv_articulos.Columns["Id_a"].Visible = false;
            dgv_articulos.Columns["imagen_a"].Visible = false;
            cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }

        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgv_articulos.CurrentRow.DataBoundItem;
           cargarImagen(seleccionado.imagen_a.Nombre_imagen);
        }
        private void cargarImagen (string imagen)
         {
            try
            {
              
                pbx_articulos.Load(imagen);

            }
            catch (Exception ex)
            {
               pbx_articulos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }

        }
    }  
    
