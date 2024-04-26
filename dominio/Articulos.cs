using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        [DisplayName("Nombre")]
        public string nombre_a {get; set; }
        [DisplayName("Codigo")]
        public string codigo_a { get; set; }
        public int Id_a{ get; set; }
        [DisplayName("Precio")]
        public decimal precio_a { get; set; }
        [DisplayName("Descripción")]
        public string descripcion_a { get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria_a { get; set; }
        [DisplayName("Marca")]
        public Marca marca_a { get; set; }
        [DisplayName("Imagen")]
        public Imagen imagen_a{ get; set; }
      
    }
}
