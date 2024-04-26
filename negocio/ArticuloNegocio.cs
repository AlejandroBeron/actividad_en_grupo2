using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticulosNegocio

    {

        public List <Articulos> listar()
        {
            List <Articulos> lista = new List <Articulos>();
            Acceso_Datos datos = new Acceso_Datos(); 
           
            try
            {
               
                datos.setearconsulta("select Codigo, Nombre, Precio, A.Id , A.Descripcion, I.ImagenUrl,M.Descripcion Marca,A.IdMarca idMarca, C.Descripcion Categoria, A.IdCategoria IdCategoria from ARTICULOS AS A left JOIN MARCAS M ON A.IdMarca = M.Id left JOIN CATEGORIAS C ON A.IdCategoria = C.Id left JOIN IMAGENES I ON A.Id = I.Idarticulo");
                datos.ejecutarlectura();               
                    while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_a =(string)datos.lector["Nombre"];
                    aux.precio_a=(decimal)datos.lector["Precio"];
                    aux.codigo_a = (string)datos.lector["Codigo"];
                    aux.descripcion_a = (string)datos.lector["Descripcion"];
                    aux.Id_a = (int)datos.lector["Id"];
                        aux.imagen_a = new Imagen();
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("ImagenUrl"))))
                    {
                        aux.imagen_a.Nombre_imagen = (string)datos.lector["ImagenUrl"];
             
                    }

                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                    {
                        aux.categoria_a = new Categoria();
                        aux.categoria_a.nombre_categoria = (string)datos.lector["Categoria"];
                        aux.categoria_a.codigo_categoria = (int)datos.lector["IdCategoria"];

                    }
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Marca"))))
                    {
                        aux.marca_a = new Marca();
                        aux.marca_a.Nombre = (string)datos.lector["Marca"];
                        aux.marca_a.Codigo = (int)datos.lector["IdMarca"];
                    }
                    
                    lista.Add(aux);


                }
                
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        public void agregar(Articulos nuevo)
        {
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
               datos.setearconsulta("insert into ARTICULOS values ('" + nuevo.codigo_a + "','" + nuevo.nombre_a + "','" + nuevo.descripcion_a+ "',@categoria, @marca , " + nuevo.precio_a + ")");
               datos.setearparametro("@categoria", nuevo.categoria_a.codigo_categoria);
               datos.setearparametro("@marca", nuevo.marca_a.Codigo);
                
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {
               throw ex;

            }
            finally
            {
                datos.cerrarconexion();
            }

        }
        public void modificar (Articulos articulo)
        {
            Acceso_Datos datos = new Acceso_Datos();

            try
            {
                datos.setearconsulta("update ARTICULOS set Codigo=@Codigo, Nombre= @Nombre, Descripcion =@Descripcion,IdMarca=@IdMarca, IdCategoria= @IdCategoria, Precio= @Precio where Id=@Id ");
                datos.setearparametro("@Codigo",articulo.codigo_a);
                datos.setearparametro("@Nombre", articulo.nombre_a);
                datos.setearparametro("@Descripcion",articulo.descripcion_a);
                datos.setearparametro("@IdMarca", articulo.marca_a.Codigo);
                datos.setearparametro("@IdCategoria",articulo.categoria_a.codigo_categoria);
                datos.setearparametro("@Precio",articulo.precio_a);
                datos.setearparametro("@Id", articulo.Id_a);
                datos.ejecutaraccion();
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("DELETE FROM ARTICULOS WHERE Id = @Id ");
                datos.setearparametro("@Id", Id);
                datos.ejecutaraccion();



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
