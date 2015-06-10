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

        private static bool canEditInitialized = false;
        private static bool canEdit;
        public static bool CanEdit
        {
            get
            {
                if (canEditInitialized)
                    return canEdit;

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connection.ConnectionString);
                String userName = builder.UserID;

                canEdit = executeCanEdit(userName);
                return canEdit;
            }
        }

        static public void Connect(String serverName, String login, String password)
        {
            String connectionString = "Addr=" + serverName + ";Database=BD;UID=" + login + ";PWD=" + password;
            if (connection != null)
            {
                Disconnect();
            }

            connection = new SqlConnection(connectionString);
            connection.Open();
            canEditInitialized = false;
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

        static public void Disconnect()
        {
            connection.Close();
            canEditInitialized = false;
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

        static public void executeStoredProcedure(String procedureName, Dictionary<String, String> parameters = null)
        {
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            fillInParameters(command, parameters);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public Boolean executeCanEdit(String userName)
        {
            SqlCommand command = new SqlCommand("CanEdit", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@RETURN_VALUE", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
            command.Parameters.AddWithValue("@userName", userName);
            

            Boolean res = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                res = false;
                MessageBox.Show(ex.Message);
            }

            if (res)
            {
                res = (Boolean)command.Parameters["@RETURN_VALUE"].Value;
            }

            return res;
        }
    }
}
