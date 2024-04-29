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
    public partial class frmbusqueda : Form
    {
        private List<Articulos> lista_articulos;
        private int cantart = 0;
        private List<Imagen> lista_imagen;
        private int cantimag = 1;

        public frmbusqueda()
        {
            InitializeComponent();
        }

   
        private void btn_buscarid_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            if (!(solonumeros(txt_buscarid.Text)))
            lista_articulos = negocio.listarid(int.Parse(txt_buscarid.Text));
            imagen_negocio imagenlis = new imagen_negocio();

            try
            {
                if (lista_articulos != null)
                {
                    dgv_busqueda.DataSource = lista_articulos;
                    dgv_busqueda.Columns["imagen_a"].Visible = false;
                    Articulos seleccionado = (Articulos)dgv_busqueda.CurrentRow.DataBoundItem;
                    rtb_Detalles.Text = lista_articulos[0].descripcion_a;
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
            catch (Exception ex)
            {
              
                MessageBox.Show("el id de articulo es incorrecto, intente nuevamente");

            }

        }

        private void btn_buscarco_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarco((string)txt_buscarco.Text);
            imagen_negocio imagenlis = new imagen_negocio();
            try
            {
                if (lista_articulos!=null)
                {
                dgv_busqueda.DataSource = lista_articulos;
                Articulos seleccionado = (Articulos)dgv_busqueda.CurrentRow.DataBoundItem;
                dgv_busqueda.Columns["imagen_a"].Visible = false;
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
                
                    rtb_Detalles.Text = lista_articulos[0].descripcion_a;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("el codigo ingresado es invalido intente de nuevo");
                
            }
        }

        private void btn_buscarno_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listarno((string)txt_buscarno.Text);
            imagen_negocio imagenlis = new imagen_negocio();

            try
            {
                if (lista_articulos != null)
                {
                    dgv_busqueda.DataSource = lista_articulos;
                    Articulos seleccionado = (Articulos)dgv_busqueda.CurrentRow.DataBoundItem;
                    dgv_busqueda.Columns["imagen_a"].Visible = false;
                    rtb_Detalles.Text = lista_articulos[0].descripcion_a;
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
            catch (Exception ex)
            {

                MessageBox.Show("el nombre del articulo es invalido, intente de nuevo");

            }
        }
        private void cargarimagenlis(int index)
        {
            try
            {
                if (lista_imagen.Count() != 0 && index >= 0 && index < lista_imagen.Count())
                {

                    if (lista_imagen[cantart].Nombre_imagen != "")
                        pb_Busqueda.Load(lista_imagen[index].Nombre_imagen);

                }
                else
                    pb_Busqueda.Image = null;
            }
            catch (System.Net.WebException)
            {
            pb_Busqueda.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

            }
        }
     
        public bool solonumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!(char.IsNumber(c)))
                {
                    MessageBox.Show("solo numeros por favor...");
                    return true;
                }

            }
            return false;

        }

        private void b_adelante_Click(object sender, EventArgs e)
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

        private void frmbusqueda_Load(object sender, EventArgs e)
        {

        }
    }
}
