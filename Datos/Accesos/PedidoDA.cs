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
    public class PedidoDA
    {
        readonly string Cadena = "Server=localhost; Port=3306; Database=Examen2; Uid=root; Pwd=123456789;";
        

        MySqlConnection conexion;
        MySqlCommand comando;

        public DataTable ListarPedidos()
        {
            DataTable ListaPedidosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM Pedido;"; //sql sentense

                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);

                MySqlDataReader reader = comando.ExecuteReader();
                ListaPedidosDT.Load(reader);
            }
            catch (Exception ex)
            {


            }
            return ListaPedidosDT;
        }

        public bool InsertarPedido(Pedido pedido)
        {
            bool Insertado = false;
            //cod, cliente, desc, cantidad
            try
            {
                string sql = "INSERT INTO pedido (CodigoPedido,CodigoProducto, Descripcion, Cantidad, Precio, Total, Cliente) VALUES (@CodigoPedido, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total, @Cliente);";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);
                //se mandan como parametros todas las propiedades de un objeto producto

                comando.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
                comando.Parameters.AddWithValue("@CodigoProducto", pedido.CodigoProducto);
                comando.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                comando.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                comando.Parameters.AddWithValue("@Precio", pedido.Precio);
                comando.Parameters.AddWithValue("@Total", pedido.Total);
                comando.Parameters.AddWithValue("@Cliente", pedido.Cliente);

                comando.ExecuteNonQuery(); //ejecuta, pero no devuelve nada.

                Insertado = true;
                conexion.Close();
            }
            catch (Exception ex)
            {


            }

            return Insertado;
        }

        public bool EliminarPedido(string CodigoPedido)
        {
            bool Eliminado = false;

            try
            {
                string sql = "DELETE FROM Pedido  WHERE CodigoPedido= @CodigoPedido";
                conexion = new MySqlConnection(Cadena);
                conexion.Open();
                comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@CodigoPedido", CodigoPedido);

                comando.ExecuteNonQuery();

                Eliminado = true;
                conexion.Close();
            }
            catch (Exception ex)
            {


            }

            return Eliminado;
        }

        
    }
}
