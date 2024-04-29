using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_grupal
{
    public partial class F_agregar_i : Form
    {
        public F_agregar_i()
        {
            InitializeComponent();
        }

        private void b_cancel_ai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        
        private bool validarfiltro()
        {
            if (txt_idarticulo.Text.ToString() == "IdArticulo")
            {
                if (!(solonumeros(txt_idarticulo.Text)))
                { 
                    MessageBox.Show("solo numeros por favor...");
                    return true;
                   

                        
                        }
               
            } 
            return false;

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
        private void b_acep_ai_Click(object sender, EventArgs e)
        {
            List<Imagen> Lista_imagen = new List<Imagen>();
            Imagen ima = new Imagen();
            Articulos auxi = new Articulos();
            imagen_negocio negocio = new imagen_negocio();
            ArticulosNegocio negocioarticulo = new ArticulosNegocio();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                if ( ima.Nombre_imagen != "" && ima.nombre_articulo != "")
                {

                   if (solonumeros(txt_idarticulo.Text.ToString())) {
                        return; }
                ima.id_articulo =int.Parse(txt_idarticulo.Text);
            
                
                ima.Nombre_imagen = txt_imagen.Text;           
                negocio.agregar(ima);
                MessageBox.Show("agregado exitosamente");
                Close();
               }
                else { MessageBox.Show("ingrese valores en todos los campos"); }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void F_agregar_i_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_idarticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_imagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txt_imagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {

                pb_imagen.Load(imagen);

            }
            catch (Exception ex)
            {
                pb_imagen.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }
    }
}
