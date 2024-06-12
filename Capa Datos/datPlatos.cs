using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class datPlatos
    {
        #region sigleton
        private static readonly datPlatos _instancia = new datPlatos();

        public static datPlatos Instancia
        {
            get
            {
                return datPlatos._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entPlatos> ListarPlato()
        {
            SqlCommand cmd = null;
            List<entPlatos> lista = new List<entPlatos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListaPlatos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlatos pla = new entPlatos();
                    pla.id_Producto = Convert.ToInt32(dr["idProducto"]);
                    pla.Categoria = dr["Descripcion"].ToString();
                    pla.Nombre_Producto = dr["NombreProducto"].ToString();
                    pla.Precio_Producto = Convert.ToSingle(dr["PrecioProducto"]);
                    lista.Add(pla);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarPlato(entPlatos pla)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPlatos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoProducto", pla.idTipoProducto);
                cmd.Parameters.AddWithValue("@NombreProducto", pla.Nombre_Producto);
                cmd.Parameters.AddWithValue("@PrecioProducto", pla.Precio_Producto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        
        public Boolean EditarPlato(entPlatos pla)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPlatos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", pla.id_Producto);
                cmd.Parameters.AddWithValue("@idTipoProducto", pla.idTipoProducto);
                cmd.Parameters.AddWithValue("@NombreProducto", pla.Nombre_Producto);
                cmd.Parameters.AddWithValue("@PrecioProducto", pla.Precio_Producto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        #endregion metodos
    }
}
