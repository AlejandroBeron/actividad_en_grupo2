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
    public partial class frm_agruparpormarca : Form
    {
        private List<Marca> lista_agrupada;
        public frm_agruparpormarca()
        {
            InitializeComponent();
        }

        private void dgv_agruparmarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_agruparpormarca_Load(object sender, EventArgs e)
        {
            marca_negocio negocio = new marca_negocio();
            lista_agrupada = negocio.listar();

            try
            {
                dgv_agruparmarca.DataSource = lista_agrupada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
