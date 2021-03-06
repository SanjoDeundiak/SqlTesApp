﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_IND_CLIENTS));

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

        static public DataTable getIndividualClientsShort()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_IND_CLIENTS_SHORT));

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

            if (name.Length > 40)
            {
                name = name.Substring(0, 40);
            }

            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_EQUIPMENT), parameters);
        }

        static public int dismiss(Int16 idWorkPlace, String endTime)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = idWorkPlace.ToString();
            parameters["@endTime"] = endTime.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_DISMISS), parameters);
        }
        static public int addWorkPlace(Int16 idWork, Int16 idClient, String startTime)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@idWork"] = idWork.ToString();
            parameters["@idClient"] = idClient.ToString();
            parameters["@startTime"] = startTime;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_WORK_PLACE), parameters);
        }
        
        static public int addTime(TimeEntity time)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@day"] = time.dayOfWeek.ToString();
            parameters["@start"] = time.start.ToString();
            parameters["@duration"] = time.duration.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_TIME), parameters);
        }

        static public int addRequest(Int16 clientId, Int16 eventId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@clientId"] = clientId.ToString();
            parameters["@eventId"] = eventId.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_REQUEST), parameters);
        }

        static public int addEquipmentRequest(Int16 clientId, Int16 eventId, Int16 equipmentId, Int16 quantity)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@clientId"] = clientId.ToString();
            parameters["@eventId"] = (eventId == 0 ? DBNull.Value.ToString()  : eventId.ToString());
            parameters["@equipmentId"] = equipmentId.ToString();
            parameters["@quantity"] = quantity.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_EQUIPMENT_REQUEST), parameters);
        }

        static public int acceptRequest(Int16 requestId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = requestId.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_ACCEPT_REQUEST), parameters);
        }

        static public int rejectRequest(Int16 requestId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = requestId.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_REJECT_REQUEST), parameters);
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

                var workPlaceId = row["workPlaceId"];
                ev.workPlaceId = (workPlaceId == DBNull.Value) ? (Int16)0 : Convert.ToInt16(workPlaceId);
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
            {
                dt.Load(reader);
                reader.Close();
            }

            return dt;
        }

        static public DataTable getSingleEvents(bool passed)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();

            String statement = passed ? PreparedStatements.GetStatement(PreparedSelectStatement.SEL_SINGLE_EVENTS) : PreparedStatements.GetStatement(PreparedSelectStatement.SEL_NOT_PASSED_SINGLE_EVENTS);
            SqlDataReader reader = Connection.executeStatementAndGetReader(statement);

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

        static public SingleEvent getSingleEvent(Int16 eventId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = eventId.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_SINGLE_EVENT), parameters);

            SingleEvent ev = new SingleEvent();

            DataTable dt = new DataTable("");

            if (reader != null)
            {
                dt.Load(reader);
                var row = dt.Rows[0];
                ev.Name = Convert.ToString(row["name"]);
                ev.id = Convert.ToInt16(row["id_event"]);
                ev.start = Convert.ToDateTime(row["start_time"]);
                ev.end = Convert.ToDateTime(row["end_time"]);
            }

            return ev;
        }

        static public DataTable getEquipmentAcceptedRequests()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_EQUIPMENT_ACCEPTED_REQUESTS));

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

        static public DataTable getEquipmentAllRequests()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_EQUIPMENT_ALL_REQUESTS));

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

        static public DataTable getAcceptedRequests()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_ACCEPTED_REQUEST));

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

        static public DataTable getNotAcceptedRequests()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_NOTACCEPTED_REQUEST));

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

        static public DataTable getWorkPlaces()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_WORK_PLACES));

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

        static public DataTable getWorkPlace(Int16 workPlaceId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = workPlaceId.ToString();
            
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_WORK_PLACE), parameters);

            DataTable dt = new DataTable("");


            if (reader != null)
                dt.Load(reader);

            return dt;
        }

        static public DataTable getWorkPlaces(List<Int16> fk_sports)
        {
            if (fk_sports.Count == 0)
            {
                DataTable DT = new DataTable();
                DataColumn cl = new DataColumn("clientName");
                DT.Columns.Add(cl);
                cl = new DataColumn("id");
                DT.Columns.Add(cl);
                return DT;
            }

            String statement = PreparedStatements.GetStatement(PreparedSelectStatement.SEL_WORK_PLACES_SPORT);

            String list = string.Join(",", fk_sports);

            statement = String.Format(statement, list);

            SqlDataReader reader = Connection.executeStatementAndGetReader(statement);

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

        static public DataTable getWork()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_WORK));

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

        static public int updatePeriodicEvent(Int16 eventId, Int16 type, String name, Int16 workPlaceId)
        {
            Dictionary<String, object> parameters = new Dictionary<string, object>();
            parameters["@id"] = eventId.ToString();
            parameters["@name"] = name;
            parameters["@type"] = type.ToString();
            parameters["@workPlaceId"] = workPlaceId == 0 ? (object)DBNull.Value : workPlaceId.ToString();
            
            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_PERIODIC_EVENT), parameters);
        }
        static public int updateSingleEvent(Int16 eventId, String name, String start, String end)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@id"] = eventId.ToString();
            parameters["@name"] = name;
            parameters["@start"] = start;
            parameters["@end"] = end;

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedUpdateStatement.UPD_SINGLE_EVENT), parameters);
        }
        static public int addWork(Int16 sportId, String name, float salary)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@sportId"] = sportId.ToString();
            parameters["@name"] = name;
            parameters["@salary"] = salary.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_WORK), parameters); ;
        }
        static public DataTable addPeriodicEvent(String name, Int16 type, Int16 workPlaceId)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;
            parameters["@type"] = type.ToString();
            parameters["@workPlaceId"] = workPlaceId == 0 ? DBNull.Value.ToString() : workPlaceId.ToString();

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedInsertStatement.INS_PERIODIC_EVENT), parameters);

            DataTable dt = new DataTable("");
            if (reader != null)
                dt.Load(reader);

            return dt;
        }
        static public DataTable addSingleEvent(String name, String start, String end)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;
            parameters["@start"] = start;
            parameters["@end"] = end;

            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedInsertStatement.INS_SINGLE_EVENT), parameters);

            DataTable dt = new DataTable("");
            if (reader != null)
            {
                try
                {
                    dt.Load(reader);
                }
                catch (Exception ex)
                {
                    reader.Close();
                    MessageBox.Show(ex.Message);
                }
            }

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
