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
    public partial class FAgregar_Categoria : Form
    {
        private Categoria categorias = null;
        public FAgregar_Categoria()
        {
            InitializeComponent();
        }
        public FAgregar_Categoria (Categoria Cat)
        {
            InitializeComponent();
            this.categorias = Cat;
        }

        private void b_cancelar_c_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_categoria_Click(object sender, EventArgs e)
        {
            
            CategoriaNegocio categoriaN = new CategoriaNegocio();

            try
            {
                if (categorias == null) 
                    categorias = new Categoria();
                categorias.nombre_categoria = tb_nom_cat.Text;
                if (categorias.nombre_categoria != "") { 
              
                if (categorias.codigo_categoria != 0)
                {
                    categoriaN.modificar(categorias);
                    MessageBox.Show("MODIFICADO CON EXITO");
                    Close();

                }
                else
                {
                    categoriaN.agregar(categorias);
                    MessageBox.Show("AGREGADO CON EXITO");
                    Close();

                }}
                else { MessageBox.Show("ingrese un nombre antes de agregar"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              
            }



        }

        private void FAgregar_Categoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categorias != null)
                {
                    tb_nom_cat.Text = categorias.nombre_categoria;
                   
                }
                 }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
