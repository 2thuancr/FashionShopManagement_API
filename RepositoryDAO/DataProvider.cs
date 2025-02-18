using DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameters = null, List<SqlParameter> sqlParameters = null, bool isStoredProcedure = false)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(Account.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                if (isStoredProcedure)
                {
                    command.CommandType = CommandType.StoredProcedure;
                }

                if (parameters != null)
                {
                    var listPara = query.Split(' ').Where(x => x.StartsWith("@")).Distinct().ToList();
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i] ?? DBNull.Value);
                            i++;
                        }
                    }
                }

                if (sqlParameters != null)
                {
                    foreach (var item in sqlParameters)
                    {
                        command.Parameters.Add(item);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int row = 0;
            using (SqlConnection connection = new SqlConnection(Account.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                row = command.ExecuteNonQuery();
                connection.Close();
            }
            return row;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(Account.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}