using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SqlTestApp
{
    static class DatabaseManager
    {
        static public DataTable getIndividualClients()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_CLIENT));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(UInt64);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            dt.Load(reader);

            return dt;
        }

        static public void addClient(String name, String middleName, String surname, String dateOfBirth, String address)
        {
            Dictionary<String, String> parameters = new Dictionary<string,string>();
            parameters["@name"] = name;
            parameters["@middleName"] = middleName;
            parameters["@surname"] = surname;
            parameters["@dateOfBirth"] = dateOfBirth;
            parameters["@address"] = address;

            Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_INDIVIDUAL), parameters);
        }
    }
}
