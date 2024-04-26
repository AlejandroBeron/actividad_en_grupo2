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
    public partial class FModificar_a : Form

    { 
        private List<Articulos> lista_articulos;

        public FModificar_a()
        {
            InitializeComponent();
        }

        private void b_cancel_ma_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FModificar_a_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

                lista_articulos = negocio.listar();
                dgv_modificar_a.DataSource = lista_articulos;
                dgv_modificar_a.Columns["Id_a"].Visible = false;
                dgv_modificar_a.Columns["imagen_a"].Visible = false;
                cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }


        private void b_modif_a_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgv_modificar_a.CurrentRow.DataBoundItem;

            FAgregar_a modificar = new FAgregar_a(seleccionado);
            modificar.ShowDialog();
            cargar();
            
        }

        private void pb_modificar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_modificar_SeleccionCanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgv_modificar_a.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagen_a.Nombre_imagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {

                pb_modificar.Load(imagen);
            }
            catch (Exception ex)
            {

                pb_modificar.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }

        private void dgv_modificar_a_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
