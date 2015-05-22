using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestApp
{
    enum PreparedSelectStatement
    {
        SEL_IND_CLIENT,
        SEL_LOG,
        SIZE
    }
    enum PreparedInsertStatement
    {
        INS_INDIVIDUAL,
        SIZE
    }
    enum PreparedUpdateStatement
    {
        UPD_INDIVIDUAL,
        SIZE
    }
    enum PreparedDeleteStatement
    {
        DEL_INDIVIDUAL,
        SIZE
    }
    static class PreparedStatements
    {
        static String[] selectStatements = new String[(int)PreparedSelectStatement.SIZE];
        static String[] insertStatements = new String[(int)PreparedInsertStatement.SIZE];
        static String[] updateStatements = new String[(int)PreparedUpdateStatement.SIZE];
        static String[] deleteStatements = new String[(int)PreparedDeleteStatement.SIZE];

        static PreparedStatements()
        {
            // Select statements here
            selectStatements[(int)PreparedSelectStatement.SEL_IND_CLIENT] = "SELECT id_client, name, middle_name, surname, date_of_birth, address, time_of_registration FROM IndividualClient";
            selectStatements[(int)PreparedSelectStatement.SEL_LOG] = "SELECT * FROM IndividualLog";

            // Insert statements here
            insertStatements[(int)PreparedInsertStatement.INS_INDIVIDUAL] = 
                @"INSERT INTO Client (time_of_registration) VALUES(CURRENT_TIMESTAMP);
                  INSERT INTO Individual (id_client, name, middle_name, surname, date_of_birth, address) Values(IDENT_CURRENT('Client'), @name, @middleName, @surname, @dateOfBirth, @address)";

            // Update statements here
            updateStatements[(int)PreparedUpdateStatement.UPD_INDIVIDUAL] =
                "UPDATE Individual SET name = @name, middle_name = @middleName, surname = @surname, date_of_birth = @dateOfBirth, address = @address WHERE id_client = @id";

            // Delete statements here
            deleteStatements[(int)PreparedDeleteStatement.DEL_INDIVIDUAL] = "DELETE FROM Client WHERE id_client = @id";
        }

        static public String GetStatement(PreparedSelectStatement statement)
        {
            return selectStatements[(int)statement];
        }

        static public String GetStatement(PreparedInsertStatement statement)
        {
            return insertStatements[(int)statement];
        }
        static public String GetStatement(PreparedDeleteStatement statement)
        {
            return deleteStatements[(int)statement];
        }
        static public String GetStatement(PreparedUpdateStatement statement)
        {
            return updateStatements[(int)statement];
        }
    }
}
