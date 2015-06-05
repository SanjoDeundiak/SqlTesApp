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
        SEL_PERIODIC_EVENTS,
        SEL_EVENT_TYPES,
        SEL_SPORT_NAMES,
        SIZE
    }
    enum PreparedInsertStatement
    {
        INS_INDIVIDUAL,
        INS_PERIODIC_EVENT,
        INS_PERIODIC_EVENT_SPORT,
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
            selectStatements[(int)PreparedSelectStatement.SEL_PERIODIC_EVENTS] = "SELECT name, sport_names, id_event, LessonTimes, type_name FROM PeriodicEventView";
            selectStatements[(int)PreparedSelectStatement.SEL_EVENT_TYPES] = "SELECT type, name FROM PeriodicEventTypeNames";
            selectStatements[(int)PreparedSelectStatement.SEL_SPORT_NAMES] = "SELECT id_sport, name FROM Sport";

            // Insert statements here
            insertStatements[(int)PreparedInsertStatement.INS_INDIVIDUAL] = 
                @"INSERT INTO Client (time_of_registration) VALUES(CURRENT_TIMESTAMP);
                  INSERT INTO Individual (id_client, name, middle_name, surname, date_of_birth, address) VALUES(IDENT_CURRENT('Client'), @name, @middleName, @surname, @dateOfBirth, @address)";
            insertStatements[(int)PreparedInsertStatement.INS_PERIODIC_EVENT] =
                @"INSERT INTO Event (name) VALUES(@name);
                  INSERT INTO Periodic_event (id_event, type) VALUES(IDENT_CURRENT('Event'), @type)";

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
