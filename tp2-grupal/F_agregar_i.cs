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

        /*private void b_acep_ai_Click(object sender, EventArgs e)
         {
             List<Imagen> Lista_imagen = new List<Imagen>();
             Imagen  ima = new Imagen(); 
             imagen_negocio negocio = new imagen_negocio();
             try
             {

                 ima.id_articulo = int.Parse(txt_idarticulo.Text);
                 ima.Nombre_imagen = txt_imagen.Text;
                 negocio.agregar(ima);

                 Lista_imagen.Add(ima);
                 MessageBox.Show("agregado exitosamente");
                 Close();
             }

             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }
         }*/

        ///------------------------- nuevo agregar--------------------
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

                ima.id_articulo =int.Parse(txt_idarticulo.Text);
                ima.Nombre_imagen = txt_imagen.Text;
            
                negocio.agregar(ima);

                MessageBox.Show("agregado exitosamente");
                Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        ///---------------------------fin de el intento-------------
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void F_agregar_i_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_idarticulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
