using Examen2_EP.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_EP.Accesos
{
    public class ProductoDA
    {
        readonly string Cadena = "Server=localhost; Port=3306; Database=Examen2; Uid=root; Pwd=123456789;";

        MySqlConnection conexion;
        MySqlCommand comando;
        //Un Data table permite traer un listado de una consulta de una BD,se importa el using

        public DataTable ListarProductos()
        {
            DataTable ListaProductosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM Producto;"; //sql sentense

                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);

                MySqlDataReader reader = comando.ExecuteReader();
                ListaProductosDT.Load(reader);
            }
            catch (Exception ex)
            {


            }
            return ListaProductosDT;
        }

        public bool InsertarProducto(Producto producto)
        {
            bool Insertado = false;
            try
            {
                string sql = "INSERT INTO Producto VALUES (@CodigoProducto, @Descripcion, @Precio, @Existencias)";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                //se mandan como parametros todas las propiedades de un objeto producto
                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Existencias", producto.Existencias);

                comando.ExecuteNonQuery(); //ejecuta, pero no devuelve nada.

                Insertado = true;
                conexion.Close();
            }
            catch (Exception ex)
            {


            }

            return Insertado;
        }

        public bool ModificarProducto(Producto producto)
        {
            bool Modificado = false;
            try
            {
                string sql = "UPDATE Producto SET CodigoProducto= @CodigoProducto, Descripcion= @Descripcion," +
                            " Precio= @Precio, Existencias= @Existencias WHERE CodigoProducto= @CodigoProducto";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Codigo", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Existencias", producto.Existencias);
               

                comando.ExecuteNonQuery();

                Modificado = true;
                conexion.Close();
            }
            catch (Exception ex)
            {


            }

            return Modificado;
        }



        public bool EliminarProducto(string CodigoProducto)
        {
            bool Eliminado = false;

            try
            {
                string sql = "DELETE FROM Producto  WHERE CodigoProducto= @CodigoProducto";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);

                comando.ExecuteNonQuery();

                Eliminado = true;
                conexion.Close();
            }
            catch (Exception ex)
            {


            }

            return Eliminado;
        }


        public Producto GetProductoPorCodigo(string codigo)
        {
            Producto producto = new Producto();
            try
            {
                string sql = "SELECT * FROM  producto WHERE CodigoProducto=@CodigoProducto;";

                conexion = new MySqlConnection(Cadena);
                conexion.Open();

                comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@CodigoProducto", codigo);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    producto.CodigoProducto =Convert.ToInt32(reader["CodigoProducto"]);
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = Convert.ToDecimal(reader["Precio"]);
                    producto.Existencias = Convert.ToInt32(reader["Existencias"].ToString());
                }

                conexion.Close();

            }
            catch (Exception)
            {
            }

            return producto;
        }











    }
}
