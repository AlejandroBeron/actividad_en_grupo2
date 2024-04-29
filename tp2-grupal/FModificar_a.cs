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
        private int cantart = 0;
        private List<Imagen> lista_imagen;
        private int cantimag = 1;
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
               // cargarImagen(lista_articulos[0].imagen_a.Nombre_imagen);
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

        private void dgv_modificar_SeleccionCanged(object sender, EventArgs e)
        {
            DataGridViewRow currentSelectedRow = dgv_modificar_a.CurrentRow;
            imagen_negocio imagenlis = new imagen_negocio();

            try
            {
                if (currentSelectedRow != null)
                {
                    Articulos seleccionado = (Articulos)dgv_modificar_a.CurrentRow.DataBoundItem;
                    lista_imagen = imagenlis.ListarItems(seleccionado.ID());

                    cantart = 0;

                    cargarimagenlis(cantart);

                    if (lista_imagen.Count() > 0)
                    {
                        cantimag = 1;
                        tb_cont.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();
                    }
                    else
                    {
                        tb_cont.Text = 0 + "/" + 0;
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
                
                    if (lista_imagen[cantart].Nombre_imagen != "")
                        pb_modificar.Load(lista_imagen[index].Nombre_imagen);



                }
                else
                    pb_modificar.Image = null;
            }
            catch (System.Net.WebException)
            {

                pb_modificar.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

            }
        }
 
        private void b_adelante_Click(object sender, EventArgs e)
        {
            if (cantart < lista_imagen.Count - 1)
            {
                cantimag++;
                cantart++;
                cargarimagenlis(cantart);
                tb_cont.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }

        private void b_atras_Click(object sender, EventArgs e)
        {
            if (cantart > 0)
            {
                cantimag--;
                cantart--;
                cargarimagenlis(cantart);
                tb_cont.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }
    }
    
}
