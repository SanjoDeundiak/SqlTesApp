using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestApp
{
    enum PreparedSelectStatement
    {
        SEL_CLIENT,
        SIZE
    }
    enum PreparedInsertStatement
    {
        INS_INDIVIDUAL,
        SIZE
    }
    static class PreparedStatements
    {
        static String[] selectStatements = new String[(int)PreparedSelectStatement.SIZE];
        static String[] insertStatements = new String[(int)PreparedInsertStatement.SIZE];

        static PreparedStatements()
        {
            // Select statements here
            selectStatements[(int)PreparedSelectStatement.SEL_CLIENT] = "SELECT id_client, name, middle_name, surname, date_of_birth, address FROM Individual";

            // Insert statements here
            insertStatements[(int)PreparedInsertStatement.INS_INDIVIDUAL] = 
                @"INSERT INTO Client (time_of_registration) VALUES(CURRENT_TIMESTAMP);
                  INSERT INTO Individual (id_client, name, middle_name, surname, date_of_birth, address) Values(IDENT_CURRENT('Client'), @name, @middleName, @surname, @dateOfBirth, @address)";
        }

        static public String GetStatement(PreparedSelectStatement statement)
        {
            return selectStatements[(int)statement];
        }

        static public String GetStatement(PreparedInsertStatement statement)
        {
            return insertStatements[(int)statement];
        }
    }
}
