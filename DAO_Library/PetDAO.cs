using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Utility_Library;

namespace DAO_Library
{
    public class PetDAO
    {
        private string connectionString;

        public PetDAO(string connString)
        {
            connectionString = connString;
        }

        public void AddPet(Pet pet)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "INSERT INTO Pets (Name, Age, Breed, Type) VALUES (@Name, @Age, @Breed, @Type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", pet.Name);
                cmd.Parameters.AddWithValue("@Age", pet.Age);
                cmd.Parameters.AddWithValue("@Breed", pet.Breed);
                cmd.Parameters.AddWithValue("@Type", pet.Type);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void RemovePet(int petId)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "DELETE FROM Pets WHERE Id = @PetId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PetId", petId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Pet> GetAllPets()
        {
            List<Pet> pets = new List<Pet>();
            using (SqlConnection conn = DBConnUtil.GetConnection(connectionString))
            {
                string query = "SELECT * FROM Pets";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pet pet = new Pet(
                        reader["Name"].ToString(),
                        Convert.ToInt32(reader["Age"]),
                        reader["Breed"].ToString(),
                        reader["Type"].ToString()
                    );
                    pets.Add(pet);
                }

                conn.Close();
            }
            return pets;
        }
    }
}
