using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FORMS
{
    public class RepositoryAdo<TEntty> : IRepository<TEntty>
    {
        private readonly string _connectionstring;


        public RepositoryAdo(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Add(TEntty entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntty entity)
        {
            try
            {

                string table_name = typeof(TEntty).Name;

                PropertyInfo id = typeof(TEntty).GetProperty(table_name);

                string querystring = $"DELETE FROM {table_name} WEHRE Id = @id";

                using (SqlConnection connection = new SqlConnection(_connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand(querystring, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar contacto de la base de datos: {ex.Message}");

            }
        }
    

        public List<TEntty> GetAll(TEntt)
        {
            List<>
            string queryString = "SELECT Id, Nombre, Apellido, FechaNacimiento, Telefono, Email FROM Contactos";

            try
            {
                using (SqlConnection connection
                        = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command
                        = new SqlCommand(queryString, connection);
                    using (SqlDataReader reader
                        = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contactos.Add(new Contacto()
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                FechaNacimiento = reader.GetDateTime(3),
                                Telefono = reader.GetInt32(4),
                                Email = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al obtener contactos de la base de datos: {ex.Message}");
            }

            return contactos;
        }

        public TEntty GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntty entity)
        {
            throw new NotImplementedException();
        }
    }
}
