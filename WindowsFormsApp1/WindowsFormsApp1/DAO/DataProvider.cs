using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get {  if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider(){}

        private string connectionSTR = "Data Source=ADMIN\\MSSQLSERVER02;Initial Catalog=test1;Integrated Security=True ";

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))

            {

                connection.Open();

                SqlCommand conmand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(conmand);

                adapter.Fill(data);

                connection.Close();
            }

            return data;

        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))

            {

                connection.Open();

                SqlCommand conmand = new SqlCommand(query, connection);
                Console.WriteLine(conmand.CommandText);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = conmand.ExecuteNonQuery();

                connection.Close();
            }

            return data;

        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))

            {

                connection.Open();

                SqlCommand conmand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            conmand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = conmand.ExecuteScalar();

                connection.Close();
            }

            return data;


        }
    }
}

