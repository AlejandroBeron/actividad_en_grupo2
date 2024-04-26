using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
     public class Imagen
    {
        [DisplayName("Url Imagen")]
        public string Nombre_imagen { get; set; }
        [DisplayName("ID Imagen")]
        public int id_imagen { get; set; }
        [DisplayName("Articulo")]
        public string nombre_articulo { get; set; }
        [DisplayName("Id Articulo")]
        public int id_articulo {  get; set; }

        public override string ToString()
        {
            return Nombre_imagen;
        }
        public void Cargar_imagen()
        {

        }
        public void Eliminar_imagen()
        {

        }
    }
}
