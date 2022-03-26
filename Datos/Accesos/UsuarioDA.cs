using Examen2_EP.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_EP.Accesos
{
    public class UsuarioDA
    {
        readonly string Cadena = "Server=localhost; Port=3306; Database=Examen2; Uid=root; Pwd=123456789;";

        MySqlConnection conexion;
        MySqlCommand comando;

        public Usuario Login(string Codigo, string Clave)
        {
            Usuario user = null;

            //dentro del try se escribe todo el codigo
            try
            {
                //Consulta a MySQL
                string sql = "SELECT * FROM usuario WHERE Codigo= @Codigo AND Clave=@Clave";

                //instanciacion del objeto de coneccion recibiendo como parametro la cadena de conexion
                conexion = new MySqlConnection(Cadena);
                conexion.Open(); //abriendo la conexion

                comando = new MySqlCommand(sql, conexion);  //manda a ejecutar a la BD por medio de comando 
                comando.Parameters.AddWithValue("@Codigo", Codigo);
                comando.Parameters.AddWithValue("@Clave", Clave);

                MySqlDataReader reader = comando.ExecuteReader(); //almacena en reader lo que traiga la consulta sql

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = Convert.ToInt32(reader[0].ToString());
                    user.Nombre = reader[1].ToString();
                    user.Clave = Convert.ToInt32(reader[2].ToString());

                }
                reader.Close();
                conexion.Close();

            }
            catch (Exception ex) //dentroo del catch se capturan los errores
            {


            }

            return user;
        }
    }
}
