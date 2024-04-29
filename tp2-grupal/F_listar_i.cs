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
    public partial class F_listar_i : Form
    {
        private List<Imagen> imagens;
       
        public F_listar_i()
            
        {
            InitializeComponent();
        }

       
        private void F_listar_i_Load(object sender, EventArgs e)
        {
            cargar();
          
        }
  
        private void cargar()
        {
            imagen_negocio negocio = new imagen_negocio();
            imagens = negocio.Listar();
            dgv_listar.DataSource = imagens;
            cargarimagen(imagens[0].Nombre_imagen);


        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            imagen_negocio negocio = new imagen_negocio();
            Imagen seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("se eliminara la marca seleccionada, ¿continuar?", "ELIMINAR MARCA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Imagen)dgv_listar.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.id_imagen);
                    dgv_listar.DataSource = negocio.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_listar_SelectionChanged(object sender, EventArgs e)
        {
            Imagen seleccionado = (Imagen)dgv_listar.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.Nombre_imagen);
        }
       
        private void cargarimagen(string imagen)
        {
            try
            {

                pbx_imagen.Load(imagen);

            }
            catch (Exception ex)
            {
                pbx_imagen.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }
    }
}
