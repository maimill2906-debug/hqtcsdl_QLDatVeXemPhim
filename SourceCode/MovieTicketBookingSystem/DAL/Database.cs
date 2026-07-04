using System;
using System.Data;
using System.Data.SqlClient;

namespace MovieTicketBookingSystem.DAL
{
    public class Database
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLDatVePhim;Integrated Security=True";

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                // Remove common formatting characters like commas, parentheses, or semicolons
                                string cleanedPara = item.Replace(",", "").Replace("(", "").Replace(")", "").Replace(";", "");
                                command.Parameters.AddWithValue(cleanedPara, parameter[i]);
                                i++;
                            }
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }

        public DataSet ExecuteQueryDataSet(string query, object[] parameter = null)
        {
            DataSet data = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                string cleanedPara = item.Replace(",", "").Replace("(", "").Replace(")", "").Replace(";", "");
                                command.Parameters.AddWithValue(cleanedPara, parameter[i]);
                                i++;
                            }
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                string cleanedPara = item.Replace(",", "").Replace("(", "").Replace(")", "").Replace(";", "");
                                command.Parameters.AddWithValue(cleanedPara, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();
                }
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                string cleanedPara = item.Replace(",", "").Replace("(", "").Replace(")", "").Replace(";", "");
                                command.Parameters.AddWithValue(cleanedPara, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();
                }
            }

            return data;
        }
    }
}
