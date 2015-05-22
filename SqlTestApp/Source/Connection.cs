using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SqlTestApp
{
    static class Connection
    {
        static SqlConnection connection;

        static public void Connect(String serverName, String login, String password)
        {
            String connectionString = "Addr=" + serverName + ";Database=BD;UID=" + login + ";PWD=" + password;
            if (connection != null)
            {
                connection.Close();
            }

            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        static private void fillInParameters(SqlCommand command, Dictionary<String, String> parameters)
        {
            if (parameters == null)
                return;

            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, (object)param.Value ?? DBNull.Value);
            }
        }

        static public SqlDataReader executeStatementAndGetReader(String statement, Dictionary<String, String> parameters = null)
        {
            SqlCommand command = new SqlCommand(statement, connection);

            fillInParameters(command, parameters);

            SqlDataReader res = null;

            try
            {
                res = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return res;
        }

        static public int executeStatement(String statement, Dictionary<String, String> parameters = null)
        {
            SqlCommand command = new SqlCommand(statement, connection);

            fillInParameters(command, parameters);

            int rowsAffected = 0;

            try
            {
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

            return rowsAffected;
        }

    }
}
