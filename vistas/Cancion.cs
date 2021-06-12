using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace vistas
{
    public class Cancion
    {
        public int codCancion,codAlbum,codGenero, nroReproducciones;
        public string titulo;
        public double duracion;
        public Cancion()
        {

        }
        public static List<Cancion> buscarCanciones(string pal)
        {
            List<Cancion> canciones = new List<Cancion>();
            string query = "select * from Cancion where lower(titulo) like '%"+pal+"%'";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cancion unaCancion = new Cancion();
                    unaCancion.codCancion = reader.GetInt32(0);
                    unaCancion.codAlbum = reader.GetInt32(1);
                    unaCancion.codGenero = reader.GetInt32(2);
                    unaCancion.titulo = reader.GetString(3);
                    unaCancion.duracion = reader.GetDouble(4);
                    unaCancion.nroReproducciones = reader.GetInt32(5);
                    canciones.Add(unaCancion);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }
            return canciones;
        }
        public bool reproducir()
        {
            bool resp = false;
            string query = "update Cancion set nro_reproducciones = @reproducciones where cod_cancion = @codCancion";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            int repr = nroReproducciones + 1; 
            command.Parameters.Add(new SqlParameter("@reproducciones",repr));
            command.Parameters.Add(new SqlParameter("@codCancion", codCancion));

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                nroReproducciones = repr;
                resp = true;
            }
            catch
            {
                resp = false;
                //throw new Exception("hay un error " + e.Message);
            }
            return resp;
             
        }

        public bool darMeGusta(int codUsuario)
        {
            bool resp = false;
            string query = "insert into Canciones_Favoritas values (@codCancion,@codUsuario)";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codCancion", codCancion));
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                resp = true;
            }
            catch
            {
                resp = false;
                //throw new Exception("hay un error " + e.Message);
            }
            return resp;
        }

        public bool esCancionFavorita(int codUsuario)
        {
            int cont = 0;
            string query = "select * from Canciones_Favoritas where cod_cancion=@codCancion and cod_usuario=@codUsuario";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codCancion", codCancion));
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
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
        public bool existeEnPlaylist(int codPlaylist)
        {
            int cont = 0;
            string query = "select * from Canciones_Playlist where cod_playlist = @codPlaylist and cod_cancion = @codCancion";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codCancion", codCancion));
            command.Parameters.Add(new SqlParameter("@codPlaylist", codPlaylist));
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

        public bool agregarCancionPlaylist(int codPlaylist)
        {
            bool res = true;
            string query = "insert into Canciones_Playlist values (@codPlaylist,@codCancion)";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codPlaylist", codPlaylist));
            command.Parameters.Add(new SqlParameter("@codCancion", codCancion));

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

        public static List<Cancion> getFavoritos(int codUsuario)
        {
            List<Cancion> canciones = new List<Cancion>();
            string query = "select C.cod_cancion,C.cod_album, C.cod_genero,C.titulo, C.duracion, C.nro_reproducciones "+
                           "from Cancion as C, Canciones_Favoritas as CF "+
                           "where CF.cod_usuario = @codUsuario and CF.cod_cancion = C.cod_cancion";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cancion unaCancion = new Cancion();
                    unaCancion.codCancion = reader.GetInt32(0);
                    unaCancion.codAlbum = reader.GetInt32(1);
                    unaCancion.codGenero = reader.GetInt32(2);
                    unaCancion.titulo = reader.GetString(3);
                    unaCancion.duracion = reader.GetDouble(4);
                    unaCancion.nroReproducciones = reader.GetInt32(5);
                    canciones.Add(unaCancion);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }
            return canciones;
        }
    }
}
