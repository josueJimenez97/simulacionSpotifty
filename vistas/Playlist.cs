using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace vistas
{
    public class Playlist
    {
        public int codPlaylist, codUsuario;
        public string titulo;
        public int nroCanciones;
        public bool activa;
        public DateTime fechaEliminacion;

        public static List<Playlist> getPlaylistUsuario(int codUsuario)
        {
            List<Playlist> playlists = new List<Playlist>();
            string query = "select * from Playlist where cod_usuario = @codUsuario ";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Playlist playlist = new Playlist();
                    playlist.codPlaylist = reader.GetInt32(0);
                    playlist.codUsuario = reader.GetInt32(1);
                    playlist.titulo = reader.GetString(2);
                    playlist.nroCanciones = reader.GetInt32(3);
                    playlist.activa = reader.GetBoolean(4);

                    playlists.Add(playlist);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return playlists;
        }

        public static bool crearPlaylist(string titulo, int codUsuario)
        {
            bool res = true;
            string query = "insert into Playlist (cod_usuario,titulo,nro_canciones,activa) "+
                            "values(@codUsuario, @titulo, 0, 1); ";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
            command.Parameters.Add(new SqlParameter("@titulo", titulo));

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

       

        public List<Cancion> getCanciones()
        {
            List<Cancion> canciones = new List<Cancion>();
            string query = "select C.cod_cancion,C.cod_album,C.cod_genero,C.titulo,C.duracion,C.nro_reproducciones "+
                           "from Cancion as C ,Canciones_Playlist as CP "+
                           "where CP.cod_playlist = @codPlaylist and CP.cod_cancion = C.cod_cancion";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codPlaylist", codPlaylist));
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
