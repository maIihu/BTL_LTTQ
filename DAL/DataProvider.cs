using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionString;

        private DataProvider()
        {
            var settings = ConfigurationManager.ConnectionStrings["MyConnectionString"];
            if (settings != null)
            {
                connectionString = settings.ConnectionString;
            }
            else
            {
                throw new Exception("Connection string not found");
            }

        }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set => instance = value;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Thực hiện lệnh SQl mà không trả về như insert hoặc update
        // Lưu ý 1 chút dùng hàm này thì nên cách cái @ gì đó ra vì nó cắt theo dấu cách
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)                {

                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.StartsWith("@"))
                        {
                            command.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }


        // Thực hiện câu lệnh SQL và trả về 1 bảng dữ liệu
        public DataTable ExecuteQuery(string query, object[] paramentor = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramentor != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            command.Parameters.AddWithValue(para, paramentor[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        // Thực hiện câu lệnh SQL và trả về 1 dòng dữ liệu
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
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
