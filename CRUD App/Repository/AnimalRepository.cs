using CRUD_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_App.Repository
{
    public class AnimalRepository : Base, InterfaceAnimalRepository
    {
        public AnimalRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(AnimalModel animalModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Pet values (@name, @type, @color, @age, @sex, @birthdate, @owner, @ownerphone)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = animalModel.AnimalName;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = animalModel.AnimalType;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = animalModel.AnimalColor;
                command.Parameters.Add("@age", SqlDbType.Int).Value = animalModel.AnimalAge;
                command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = animalModel.AnimalSex;
                command.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = animalModel.AnimalBirthDate;
                command.Parameters.Add("@owner", SqlDbType.NVarChar).Value = animalModel.AnimalOwner;
                command.Parameters.Add("@ownerphone", SqlDbType.NVarChar).Value = animalModel.AnimalOwnerPhone;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int animalModelID)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Pet where Pet_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = animalModelID;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(AnimalModel animalModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Pet set Pet_Name=@name, Pet_Type=@type, Pet_Colour=@color, Pet_Age=@age, Pet_Sex=@sex, Pet_BirthDate=@birthdate, Pet_Owner=@owner, Owner_Phone=@ownerphone where Pet_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = animalModel.AnimalName;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = animalModel.AnimalType;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = animalModel.AnimalColor;
                command.Parameters.Add("@age", SqlDbType.Int).Value = animalModel.AnimalAge;
                command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = animalModel.AnimalSex;
                command.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = animalModel.AnimalBirthDate;
                command.Parameters.Add("@owner", SqlDbType.NVarChar).Value = animalModel.AnimalOwner;
                command.Parameters.Add("@ownerphone", SqlDbType.NVarChar).Value = animalModel.AnimalOwnerPhone;
                command.Parameters.Add("@id", SqlDbType.Int).Value = animalModel.AnimalID;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<AnimalModel> GetAll()
        {
            var animalList = new List<AnimalModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Pet order by Pet_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var animalModel = new AnimalModel();
                        animalModel.AnimalID = (int)reader[0];
                        animalModel.AnimalName = (string)reader[1];
                        animalModel.AnimalType = (string)reader[2];
                        animalModel.AnimalColor = (string)reader[3];
                        animalModel.AnimalAge = (int)reader[4];
                        animalModel.AnimalSex = (string)reader[5];
                        animalModel.AnimalBirthDate = (DateTime)reader[6];
                        animalModel.AnimalOwner = (string)reader[7];
                        animalModel.AnimalOwnerPhone = (string)reader[8];
                        animalList.Add(animalModel);
                    }
                }
            }

            return animalList;
        }

        public IEnumerable<AnimalModel> GetByValue(string value)
        {
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string NAME = value;
            string TYPE = value;
            string COLOR = value;
            int AGE = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string OWNER = value;
            var animalList = new List<AnimalModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Pet where Pet_Id=@id or Pet_Name like @name+'%' or Pet_Type like @type+'%' or Pet_Colour like @color+'%' or Pet_Age=@age or Pet_Owner like @owner+'%' order by Pet_Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = NAME;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = TYPE;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = COLOR;
                command.Parameters.Add("@age", SqlDbType.Int).Value = AGE;
                command.Parameters.Add("@owner", SqlDbType.NVarChar).Value = OWNER;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var animalModel = new AnimalModel();
                        animalModel.AnimalID = (int)reader[0];
                        animalModel.AnimalName = (string)reader[1];
                        animalModel.AnimalType = (string)reader[2];
                        animalModel.AnimalColor = (string)reader[3];
                        animalModel.AnimalAge = (int)reader[4];
                        animalModel.AnimalSex = (string)reader[5];
                        animalModel.AnimalBirthDate = (DateTime)reader[6];
                        animalModel.AnimalOwner = (string)reader[7];
                        animalModel.AnimalOwnerPhone = (string)reader[8];
                        animalList.Add(animalModel);
                    }
                }
            }

            return animalList;
        }
    }
}
