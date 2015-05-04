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
    static class PreparedStatements
    {
        static String[] selectStatements = new String[(int)PreparedSelectStatement.SIZE];

        static PreparedStatements()
        {
            selectStatements[(int)PreparedSelectStatement.SEL_CLIENT] = "SELECT id_client, name, middle_name, surname, date_of_birth, address FROM Individual";
        }

        static public String GetStatement(PreparedSelectStatement statement)
        {
            return selectStatements[(int)statement];
        }
    }
}
