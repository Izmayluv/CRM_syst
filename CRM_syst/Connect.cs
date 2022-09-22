using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRM_syst
{
    class Connect
    {
        public static SqlConnection sqlConnection;

        string connectionString = "Server=DESKTOP-CPO7E1M, 1433;Database=crp_system;User Id=olek;Password=123;"; 

        public void StartSQLconnection() //открыть подключение
        {
            sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }

            catch (SqlException)
            {
                MessageBox.Show("ConnectionError");
            }
        }

        public void CheckSQLconnection() //проверка связи
        {
            sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }

            catch (SqlException)
            {
                MessageBox.Show("ConnectionError");
            }
            finally
            {

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Success");
                    sqlConnection.Close();
                }
            }
        }

        public void CloseSQLconnection() //закрыть подключение
        {

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();

            }
        }
    }
}