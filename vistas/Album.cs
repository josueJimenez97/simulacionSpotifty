using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace vistas
{
    public class Album
    {
        public int codAlbum, codArtista ,anioPublicacion;
        public string titulo;
        public string img;
        public Album(int codAlbum, int codArtista, int anioPublicacion, string titulo)
        {
            this.codAlbum = codAlbum;
            this.codArtista = codArtista;
            this.anioPublicacion = anioPublicacion;
            this.titulo = titulo;
        }

        public static Album getAlbum(int codAlbum)
        {
            Album album = null;
            string query = "select * from album where cod_album = @codAlbum";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codAlbum", codAlbum));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int codAl = reader.GetInt32(0);
                    int codAr = reader.GetInt32(1);
                    string tituloA = reader.GetString(2);
                    int anio = reader.GetInt32(3);
                    album = new Album(codAl, codAr, anio, tituloA);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return album;

        }
        public static List<Album> buscarAlbum(string pal)
        {
            List<Album> albumes = new List<Album>();
            string query = "select * from Album where lower (titulo) like '%"+pal+"%'";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int codAl = reader.GetInt32(0);
                    int codAr = reader.GetInt32(1);
                    string tituloA = reader.GetString(2);
                    int anio = reader.GetInt32(3);
                    Album unAlbum = new Album(codAl, codAr, anio, tituloA);
                    albumes.Add(unAlbum);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return albumes;
        }
        public List<Cancion> getCancionesAlbum()
        {
            List<Cancion> canciones = new List<Cancion>();
            string query = "select * from cancion where cod_album = @codAlbum";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codAlbum", codAlbum));
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
        public bool darMegusta(int codUsuario)
        {
            bool resp = false;
            string query = "insert into Albumes_Favoritos values(@codUsuario,@codAlbum)";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codAlbum", codAlbum));
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
        public bool esAlbumFavorito(int codUsuario)
        {
            int cont = 0;
            string query = "select * from Albumes_Favoritos " +
                            "where cod_usuario = @codUsuario and cod_album= @codAlbum";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
            command.Parameters.Add(new SqlParameter("@codAlbum", codAlbum));
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

        public static List<Album> getFavoritos(int codUsuario)
        {
            List<Album> albumes = new List<Album>();
            string query = "select A.cod_album, A.cod_artista,A.titulo,A.anio_publicacion, A.img "+
                           "from Album as A, Albumes_Favoritos as AF "+
                           "where AF.cod_usuario = @codUsuario and A.cod_album = AF.cod_album";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int codAl = reader.GetInt32(0);
                    int codAr = reader.GetInt32(1);
                    string tituloA = reader.GetString(2);
                    int anio = reader.GetInt32(3);
                    Album unAlbum = new Album(codAl, codAr, anio, tituloA);
                    albumes.Add(unAlbum);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return albumes;
        }
    }
}
