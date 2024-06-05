using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FORMS;

namespace formAdo
{
    public class InventoryRepository : IRepository<Inventory>
    {
        private readonly string _connectionString;

        public InventoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Inventory entity)
        {
            string queryString = "INSERT INTO Inventory (MakeId, Color, PetName) VALUES (@makeId, @color, @petName)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@makeId", entity.MakeId);
                    command.Parameters.AddWithValue("@color", entity.Color);
                    command.Parameters.AddWithValue("@petName", entity.PetName);
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
            string queryString = "DELETE FROM Inventory WHERE Id = @id";
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

        public IEnumerable<Inventory> GetAll()
        {
            List<Inventory> inventories = new List<Inventory>();
            string queryString = "SELECT Id, MakeId, Color, PetName, TimeStamp FROM Inventory";

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


                            Inventory inventory = new Inventory
                            {
                                Id = reader.GetInt32(0),
                                MakeId = reader.GetInt32(1),
                                Color = reader.GetString(2),
                                PetName = reader.GetString(3),
                                TimeStamp = (byte[])reader["TimeStamp"]

                            };

                            inventories.Add(inventory);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener registros de la base de datos: {ex.Message}");
            }

            return inventories;
        }

        public Inventory GetById(int id)
        {
            string queryString = "SELECT Id, MakeId, Color, PetName, TimeStamp FROM Inventory WHERE Id = @id";

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



                        Inventory inventory = new Inventory
                        {
                            Id = reader.GetInt32(0),
                            MakeId = reader.GetInt32(1),
                            Color = reader.GetString(2),
                            PetName = reader.GetString(3),
                            TimeStamp = (byte[])reader["TimeStamp"]
                        };

                        return inventory;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener registro de la base de datos: {ex.Message}");
            }
        }

        public void Update(Inventory entity)
        {
            string queryString = "UPDATE Inventory SET MakeId = @makeId, Color = @color, PetName = @petName WHERE Id = @id AND TimeStamp = @timestamp";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@makeId", entity.MakeId);
                    command.Parameters.AddWithValue("@color", entity.Color);
                    command.Parameters.AddWithValue("@petName", entity.PetName);
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
