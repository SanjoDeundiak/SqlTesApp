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

        static public SqlDataReader Test()
        {
            SqlCommand command = new SqlCommand(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_CLIENT), connection);
            return command.ExecuteReader();
        }

    }
}
