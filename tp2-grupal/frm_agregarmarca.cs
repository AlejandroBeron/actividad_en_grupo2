using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace tp2_grupal
{
    public partial class F_Agregar_M : Form
    {
        public F_Agregar_M()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca nueva_marca = new Marca();
            marca_negocio negocio = new marca_negocio();
            try
            { 
                
                nueva_marca.Nombre = txt_agregarmarca.Text;
                
                if (nueva_marca.Nombre!="")
                {
                    negocio.Agregar(nueva_marca);
                MessageBox.Show("agregado exitosamente");
                Close();}
                else
                {
                    MessageBox.Show("ingrese un nombre antes de agregar");
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();    
        }

        private void txt_agregarmarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Agregar_M_Load(object sender, EventArgs e)
        {

        }
    }
}
