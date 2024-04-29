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
        private int cantart = 0;
        private List<Imagen> lista_imagen;
        private int cantimag = 1;

        public FListar_a()
        {
            InitializeComponent();
        }

        private void FListar_a_Load(object sender, EventArgs e)
        {
            cargar();
           
        }
         private void cargar()
         {
            ArticulosNegocio negocio = new ArticulosNegocio();
            lista_articulos = negocio.listar();
            try
            {
            dgv_articulos.DataSource = lista_articulos;
            dgv_articulos.Columns["descripcion_a"].Visible = false;
            
            }
            catch (Exception ex)
            {
               
                throw ex;
               
            }

        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentSelectedRow = dgv_articulos.CurrentRow;
            imagen_negocio imagenlis = new imagen_negocio();

            try
            {
                if (currentSelectedRow != null)
                {
                    Articulos seleccionado = (Articulos)dgv_articulos.CurrentRow.DataBoundItem;
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
                        pbx_articulos.Load(lista_imagen[index].Nombre_imagen);



                }
                else
                    pbx_articulos.Image = null;
            }
            catch (System.Net.WebException)
            {

                pbx_articulos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");



            }
        }
    

        private void B_atras_Click(object sender, EventArgs e)
        {
            if (cantart > 0)
            {
                cantimag--;
                cantart--;
                cargarimagenlis(cantart);
                text_imagen.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }

        private void B_siguiente_Click(object sender, EventArgs e)
        {
            if (cantart < lista_imagen.Count - 1)
            {
                cantimag++;
                cantart++;
                cargarimagenlis(cantart);
                text_imagen.Text = cantimag.ToString() + "/" + lista_imagen.Count().ToString();

            }
        }

        private void text_imagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }  
    
