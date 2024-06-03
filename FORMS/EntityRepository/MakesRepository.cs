using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FORMS.EntityRepository
{
    public class MakesRepository : IRepository<Makes>
    {
        private readonly string _connectionString;

        public MakesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Makes entity)
        {
            string queryString = "INSERT INTO Makes(Name) VALUES (@name)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", entity.Name);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar en la base de datos: {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            string queryString = "DELETE FROM Makes WHERE Id = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar de la base de datos: {ex.Message}");
            }
        }

        public IEnumerable<Makes> GetAll()
        {
            List<Makes> makes = new List<Makes>();
            string queryString = "SELECT Id, Name, TimeStamp FROM Makes";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            makes.Add(new Makes()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                TimeStamp = (byte[])reader["TimeStamp"]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener registros de la base de datos: {ex.Message}");
            }

            return makes;
        }

        public Makes GetById(int id)
        {
            string queryString = "SELECT Id, Name, TimeStamp FROM Makes WHERE Id = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Makes make = new Makes
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        };
                        return make;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener registro de la base de datos: {ex.Message}");
            }
            return null;
        }

        public void Update(Makes entity)
        {
            string queryString = "UPDATE Makes SET Name = @name WHERE Id = @id AND TimeStamp = @timestamp";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", entity.Name);
                    command.Parameters.AddWithValue("@id", entity.Id);
                    command.Parameters.AddWithValue("@timestamp", entity.TimeStamp);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("El registro ha sido modificado por otro usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar en la base de datos: {ex.Message}");
            }
        }
    }
}
