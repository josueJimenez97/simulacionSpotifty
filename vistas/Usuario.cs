using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace vistas
{
    public class Usuario
    {
        public int codUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }

        public string fechaNac { get; set; }
        public char sexo { get; set; }
        public string pais { get; set; }
        public bool premium { get; set; }

        public  bool existeUsuario(string email, string contrasenia)
        {
            int cont = 0;
            string query = "select * from usuario " +
                "where email= @email and contrasenia=@password";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@email", email));
            command.Parameters.Add(new SqlParameter("@password", contrasenia));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    cont++;
                    codUsuario = reader.GetInt32(0);
                    nombreUsuario = reader.GetString(1);
                    this.email = reader.GetString(2);
                    this.contrasenia = reader.GetString(3);
                    fechaNac =  reader.GetDateTime(4).ToString();
                    sexo = char.Parse(reader.GetString(5));
                    pais = reader.GetString(6);
                    premium = reader.GetBoolean(7);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }
            return cont != 0;
        }

        public static bool emailRegistrado(string email)
        {
            int cont = 0;
            string query = "select * from usuario " +
                "where email= @email";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@email", email));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cont++;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }
            return cont != 0;
        }

        public static bool registrarUsuario(Usuario usr)
        {
            bool res = true;
            string query = "insert into Usuario " +
                "(nombre_usuario,email,contrasenia,fecha_nac,sexo, pais, premium)"+
                 "values(@nombreUsuario, @email, @pass, @fechaNac, @sexo, @pais, 0)";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@nombreUsuario", usr.nombreUsuario));
            command.Parameters.Add(new SqlParameter("@email", usr.email));
            command.Parameters.Add(new SqlParameter("@pass", usr.contrasenia));
            command.Parameters.Add(new SqlParameter("@fechaNac", usr.fechaNac));
            command.Parameters.Add(new SqlParameter("@sexo", usr.sexo));
            command.Parameters.Add(new SqlParameter("@pais", usr.pais));

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                res = false;
                //throw new Exception("hay un error " + e.Message);
            }
            return res;
        }


        
    }
}
