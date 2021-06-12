using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace vistas
{
    public class Artista
    {
        public int codArtista;
        public string nombreArtista;
        public string foto;

        public Artista()
        {

        }

        public Artista(int codArtista, string nombreArtista, string foto)
        {
            this.codArtista = codArtista;
            this.nombreArtista = nombreArtista;
            this.foto = foto;
        }
        public static Artista getArtista(int codArtista)
        {
            Artista artista = null;
            string query = "select * from Artista where cod_artista= @codArtista";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codArtista", codArtista));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cod = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string foto = reader.GetString(2);
                    artista = new Artista(cod, nombre, foto);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return artista;

        }
        public static List<Artista> buscarArtista(string pal)
        {
            List<Artista> listaArtistas = new List<Artista>();
            string query = "select * from Artista where lower(nombre_artista) like '%"+pal+"%'";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cod = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string foto = reader.GetString(2);
                    Artista unArtista = new Artista(cod, nombre, foto);
                    listaArtistas.Add(unArtista);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return listaArtistas;
        }
        public static List<Artista> getArtistasSeguidos(int codUsuario)
        {
            List<Artista> listaArtistas = new List<Artista>();
            string query = "select A.cod_artista, A.nombre_artista, A.img "+
                           "from Artista as A, Usuario_Sigue_Artista as US "+
                           "where cod_usuario = @codUsuario and A.cod_artista = US.cod_artista";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cod= reader.GetInt32(0);
                    string nombre= reader.GetString(1);
                    string foto= reader.GetString(2);
                    Artista unArtista = new Artista(cod,nombre,foto);
                    listaArtistas.Add(unArtista);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("hay un error " + e.Message);
            }

            return listaArtistas;
        }
        public List<Album> getAlbumes()
        {
            List<Album> albumes = new List<Album>();
            string query = "select * from album where cod_artista = @codArtista";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codArtista", codArtista));
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
                    Album unAlbum = new Album(codAl,codAr,anio,tituloA);
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

        public bool seguirArtista(int codUsuario)
        {
            bool resp = false;
            string query = "insert into Usuario_Sigue_Artista values (@codUsuario,@codArtista)";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codArtista", codArtista));
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

        public bool esArtistaSeguido(int codUsuario)
        {
            int cont = 0;
            string query = "select * from Usuario_Sigue_Artista "+
                           "where cod_usuario = @codUsuario and cod_artista = @codArtista";
            SqlConnection conn = Conexion.getConexion();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@codUsuario", codUsuario));
            command.Parameters.Add(new SqlParameter("@codArtista", codArtista));
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
                throw new Exception("hay un error en Artista DB" + e.Message);
            }
            return cont != 0;
        }
    }
}
