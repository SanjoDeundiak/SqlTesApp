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
        static public DataTable getWeekDayNames()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_WEEK_DAYS));

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);

            return dt;
        }
        static public DataTable getIndividualClients()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_IND_CLIENT));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getLog()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_LOG));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public int addSport(String name)
        {
            if (name == null || name == "")
                return -1;

            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_SPORT), parameters);
        }

        static public int addEquipment(String name)
        {
            if (name == null || name == "")
                return -1;

            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_EQUIPMENT), parameters);
        }
        
        static public int addTime(TimeEntity time)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@day"] = time.dayOfWeek.ToString();
            parameters["@start"] = time.start.ToString();
            parameters["@duration"] = time.duration.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_TIME), parameters);
        }

        static public int addIndividual(Individual individual)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = individual.Name;
            parameters["@middleName"] = individual.MiddleName;
            parameters["@surname"] = individual.Surname;
            parameters["@dateOfBirth"] = individual.DateOfBirth;
            parameters["@address"] = individual.Address;

           return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_INDIVIDUAL), parameters);
        }

        static public int updateIndividual(Individual individual)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = individual.id.ToString();
            parameters["@name"] = individual.Name;
            parameters["@middleName"] = individual.MiddleName;
            parameters["@surname"] = individual.Surname;
            parameters["@dateOfBirth"] = individual.DateOfBirth;
            parameters["@address"] = individual.Address;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_INDIVIDUAL), parameters);
        }

        static public int deleteIndividual(Int32 id)
        {
            Dictionary<String, String> parameters = new Dictionary<string, String>();
            parameters["@id"] = id.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedDeleteStatement.DEL_INDIVIDUAL), parameters);
        }

        static public PeriodicEvent getPeriodicEvent(Int16 eventId)
        {
            PeriodicEvent ev = new PeriodicEvent();

            Dictionary<String, String> parameters = new Dictionary<string,string>();
            parameters["@id_event"] = eventId.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_PERIODIC_EVENT), parameters);

            DataTable dt = new DataTable("");

            if (reader != null)
            {
                dt.Load(reader);
                var row = dt.Rows[0];
                ev.id = Convert.ToInt16(row["id_event"]);
                ev.Name = Convert.ToString(row["name"]);
                ev.type = Convert.ToInt16(row["type"]);
                ev.LessonTimes = Convert.ToString(row["LessonTimes"]);
            }

            return ev;
        }

        static public DataTable getPeriodicEvents()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_PERIODIC_EVENTS));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getEquipment()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_EQUIPMENT));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getEventTypes()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_EVENT_TYPES));

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getSportForEvent(Int16 eventId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id_event"] = eventId.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_SPORT_FOR_EVENT), parameters);

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getTimesForEvent(Int16 eventId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id_event"] = eventId.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_TIME_FOR_EVENT), parameters);

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getSportNamesForKeys(List<Int16> fk_sports)
        {
            if (fk_sports.Count == 0)
            {
                DataColumn cl = new DataColumn("name");
                DataTable DT = new DataTable();
                DT.Columns.Add(cl);
                return DT;
            }

            String statement = PreparedStatements.GetStatement(PreparedSelectStatement.SEL_SPORT_NAMES_FOR_KEYS);
            String list = string.Join(",", fk_sports);

            statement = String.Format(statement, list);

            SqlDataReader reader = Connection.executeStatementAndGetReader(statement);

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);
            
            return dt;
        }
        static public DataTable getTimes()
        {            
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_TIMES));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }
        static public DataTable getTimesForKeys(List<Int16> fk_times)
        {
            if (fk_times.Count == 0)
            {
                DataColumn cl = new DataColumn("time");
                DataTable DT = new DataTable();
                DT.Columns.Add(cl);
                return DT;
            }

            String statement = PreparedStatements.GetStatement(PreparedSelectStatement.SEL_TIMES_FOR_KEYS);
            String list = string.Join(",", fk_times);

            statement = String.Format(statement, list);

            SqlDataReader reader = Connection.executeStatementAndGetReader(statement);

            DataTable dt = new DataTable("");

            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getSportNames()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_SPORT_NAMES));

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(Int32);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            if (reader != null)
                dt.Load(reader);

            return dt;
        }
        static public int updatePeriodicEvent(Int16 eventId, Int16 type, String name)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = eventId.ToString();
            parameters["@name"] = name;
            parameters["@type"] = type.ToString();
            
            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_PERIODIC_EVENT), parameters);
        }
        static public DataTable addPeriodicEvent(String name, Int16 type)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;
            parameters["@type"] = type.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedInsertStatement.INS_PERIODIC_EVENT), parameters);

            DataTable dt = new DataTable("");
            if (reader != null)
                dt.Load(reader);

            return dt;
        }
        static public void setEventSports(Int16 eventId, List<Int16> fk_sports)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@event_id"] = eventId.ToString();
            parameters["@list"] = String.Join(",", fk_sports);

            Connection.executeStoredProcedure(PreparedStatements.GetStatement(StoredProcedure.PROC_UPDATE_SPORTS), parameters);
        }
        static public void setEventTimes(Int16 eventId, List<Int16> fk_times)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@event_id"] = eventId.ToString();
            parameters["@list"] = String.Join(",", fk_times);

            Connection.executeStoredProcedure(PreparedStatements.GetStatement(StoredProcedure.PROC_UPDATE_TIMES), parameters);
        }
    }
}
