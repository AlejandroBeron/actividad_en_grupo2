
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;



namespace negocio
{
    public class imagen_negocio
    {    

       // private List<Imagen> imagenList;
       //no se usaba y lo comente chequear
        public void eliminar(int id)
        {
            try
            {
                Acceso_Datos datos = new Acceso_Datos();
                datos.setearconsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                datos.setearparametro("@Id", id);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void agregar(Imagen nuevo)
        {
            Acceso_Datos datos = new Acceso_Datos();  
            
            try
            {
                datos.setearconsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(@IdA, @Imagen)");
                datos.setearparametro("@IdA", nuevo.id_articulo);
               datos.setearparametro("@Imagen", nuevo.Nombre_imagen);
                datos.ejecutaraccion();
               // datos.setearconsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(" + nuevo.id_articulo + ",'"+ nuevo.Nombre_imagen + "')");
               // datos.setearconsulta("select Nombres from ARTICULOS WHERE Id = @Id");
                //datos.setearconsulta("insert into ARTICULOS(Nombre,Id)values ('" + nuevo.nombre_articulo + "','Id = @Id')");
               //cambie la consulta y seteo de paraetros
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        /* public  List <Imagen> Listar()
         {
             List<Imagen> Lista_imagen = new List<Imagen>();
             Acceso_Datos datos = new Acceso_Datos();
             try
             {
                 datos.setearconsulta("SELECT IdArticulo,Id, ImagenUrl FROM IMAGENES");
                 datos.ejecutarlectura();
                 while(datos.lector.Read())
                 {
                     Imagen aux = new Imagen();
                     aux.id_imagen = (int)datos.lector["Id"];
                     aux.id_articulo = (int)datos.lector["IdArticulo"];        
                     aux.Nombre_imagen = (string)datos.lector["ImagenUrl"];

                     Lista_imagen.Add(aux);
                 }                
                 return Lista_imagen;
             }
             catch (Exception ex)
             {

                 throw ex;

             }
             finally
             {
                 datos.cerrarconexion();

             }
         }*/
        //---------------------------------otro intento--------------------

        public List<Imagen> Listar()
        {
            List<Imagen> Lista_imagen = new List<Imagen>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                //datos.setearconsulta("select  A.Nombre , I.Id , I.ImagenUrl,I.IdArticulo,A.Id from ARTICULOS A,IMAGENES I,MARCAS M, CATEGORIAS C  where I.Idarticulo=A.Id and A.Id=M.Id and A.Id=C.Id");
               //cambie la consulta
                datos.setearconsulta("select  A.Nombre , I.Id , I.ImagenUrl,I.IdArticulo,A.Id from IMAGENES as I left join ARTICULOS as A on I.Idarticulo = A.Id");
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Imagen aux = new Imagen();
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Nombre"))))
                     aux.nombre_articulo = (string)datos.lector["Nombre"];
                    aux.id_imagen = (int)datos.lector["Id"];
                    aux.id_articulo = (int)datos.lector["IdArticulo"];
                    aux.Nombre_imagen = (string)datos.lector["ImagenUrl"];

                    Lista_imagen.Add(aux);
                }
                return Lista_imagen;
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
        //------------------aca termina--------
    }
}
