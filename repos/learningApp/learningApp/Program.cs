using System.Text;
using System;
using Npgsql;

namespace learningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=testdb";

            using var connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to postgressql succesfully");

                string query = "Select * from students";

                using var command = new NpgsqlCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    int rollNo = reader.GetInt32(1);

                    Console.WriteLine($"{name} - {rollNo}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("oh no there is an error");
            }

            var builder = new StringBuilder();
            for (int i = 0; i <= 5; i++)
            {
                builder.Append("item ").Append(i).Append(",");
            }
            var result = builder.ToString();
            Console.WriteLine(result);
            string name2 = "Hasan";
            if (name2 is not null)
            {
                Console.WriteLine($"Name has {name2.Length} characters.");
            }
            else
            {
                Console.WriteLine("Name is null.");
            }
            string a = "Hello";
            String b = "Hello";
            Console.WriteLine(a == b);
            Console.WriteLine(typeof(string) == typeof(String));
        }
    }
}
