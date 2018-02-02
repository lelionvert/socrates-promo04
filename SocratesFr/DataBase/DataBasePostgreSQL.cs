using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace SocratesFr.DataBase
{
    public class DataBasePostgreSQL
    {
        private const string connString = "Host=postgres-lacombe.westeurope.cloudapp.azure.com;" +
                                  "Username=learner;" +
                                  "Password=learn;" +
                                  "Pooling=true;" +
                                  "Minimum Pool Size=100;" +
                                  "Database=playground-4";

        private const string schema = "\"Arnaud\"";
        private const string candidatTable = ".\"Candidat\"";
        private const string candidatFields = "(name, email)";
        private const string candidatSequence = "\'\"Arnaud\".\"Candidat_id_seq\"\'";

        public int InsertIntoCandidat(string name, string email)
        {           
            using (var conn = new NpgsqlConnection(connString))
            {

                conn.Open();
                
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("INSERT INTO {0} {1} {2} VALUES (@name, @email); SELECT CURRVAL({3}) ; ",
                        schema, candidatTable, candidatFields, candidatSequence);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("email", email);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
        }

        public int EraseCandidat(string email)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("DELETE FROM {0} {1} WHERE email = :email;",
                        schema, candidatTable, email);
                    cmd.Parameters.AddWithValue("email", email);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
