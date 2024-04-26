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
    public partial class F_Eliminar_M : Form
    {
        public F_Eliminar_M()
        {
            InitializeComponent();
        }

        private void l_eliminar_marca_Click(object sender, EventArgs e)
        {

        }

        private void frm_eliminarmarca_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca elim_marca = new Marca();

            try
            {
                elim_marca.Codigo = int.Parse (txt_idmarca.Text);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_cancelar_eliminarmarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
