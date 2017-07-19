using Npgsql;
using System;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = $"host={Environment.GetEnvironmentVariable("DB_HOST")};port=5432;database=test;username=test;password=test;pooling=false";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                foreach (var i in Enumerable.Range(0, 100))
                {
                    Console.WriteLine(i);

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select 1;";
                        using (var reader = cmd.ExecuteReader())
                        {
                            cmd.Cancel();
                        }
                    }
                }
            }
        }
    }
}

