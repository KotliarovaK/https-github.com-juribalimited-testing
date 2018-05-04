using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DashworksTestAutomation.Providers;

namespace DashworksTestAutomation.Helpers
{
    internal class DatabaseHelper
    {
        private static readonly string _connectionString = Database.ConnectionsString;

        public static void ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = query,
                Connection = sqlConnection
            };

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// <summary>
        ///     columnIndex starts from 0.
        ///     columnIndex is the index of the column
        ///     [0] is the index of the row
        ///     Usage: DatabaseWorker.ExecuteReader(dbName.ECA_database, query, 0)[0]
        ///     To get data from the last row just use '.LastOrDefault()' instead of [0] index
        /// </summary>
        /// <returns></returns>
        public static List<string> ExecuteReader(string query, int columnIndex)
        {
            var results = ExecuteReaderWithoutZeroResultCheck(query, columnIndex);

            if (results.Any())
                return results;
            throw new Exception("Database query returns zero results");
        }

        public static List<string> ExecuteReaderWithoutZeroResultCheck(string query, int columnIndex)
        {
            SqlConnection sqlConnection1 = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            sqlConnection1.Close();

            return dt.AsEnumerable().ToList().Select(row => row[columnIndex].ToString()).ToList();
        }

        public static void RemoveLists(List<string> listsIds)
        {
            foreach (string id in listsIds)
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[API].[List_Remove]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ListId", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
        }
    }
}