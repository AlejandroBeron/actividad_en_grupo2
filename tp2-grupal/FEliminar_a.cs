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
        private int cantart = 0;
        private List<Imagen> lista_imagen;
        private int cantimag = 1;
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

        private void PBox_A_Eliminar_Click(object sender, EventArgs e)
        {
          
        }
  

        private void dgv_eliminara_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentSelectedRow = dgv_eliminara.CurrentRow;
            imagen_negocio imagenlis = new imagen_negocio();

            try
            {
                if (currentSelectedRow != null)
                {
                    Articulos seleccionado = (Articulos)dgv_eliminara.CurrentRow.DataBoundItem;
                    lista_imagen = imagenlis.ListarItems(seleccionado.ID());

                    cantart = 0;

                    cargarimagenlis(cantart);

                    if (lista_imagen.Count() > 0)
                    {
                        cantimag = 1;
                        text_imagen.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();
                    }
                    else
                    {
                        text_imagen.Text = 0 + "/" + 0;
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                throw ex;

            }

        }

        private void cargarimagenlis(int index)
        {
            try
            {
                if (lista_imagen.Count() != 0 && index >= 0 && index < lista_imagen.Count())
                {
                    // Carga la URL en función del índice actual

                    if (lista_imagen[cantart].Nombre_imagen != "")
                        pb_Eliminar.Load(lista_imagen[index].Nombre_imagen);



                }
                else
                    pb_Eliminar.Image = null;
            }
            catch (System.Net.WebException)
            {

                pb_Eliminar.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");



            }
        }

        private void b_siguiente_Click(object sender, EventArgs e)
        {
            if (cantart < lista_imagen.Count - 1)
            {
                cantimag++;
                cantart++;
                cargarimagenlis(cantart);
                text_imagen.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }

        private void b_atras_Click(object sender, EventArgs e)
        {
            if (cantart > 0)
            {
                cantimag--;
                cantart--;
                cargarimagenlis(cantart);
                text_imagen.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }
    }
}
