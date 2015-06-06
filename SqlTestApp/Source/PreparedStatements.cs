﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestApp
{
    enum StoredProcedure
    {
        PROC_UPDATE_SPORTS,
        PROC_UPDATE_TIMES,
        SIZE
    }
    enum PreparedSelectStatement
    {
        SEL_IND_CLIENT,
        SEL_LOG,
        SEL_PERIODIC_EVENTS,
        SEL_PERIODIC_EVENT,
        SEL_EVENT_TYPES,
        SEL_SPORT_NAMES,
        SEL_SPORT_FOR_EVENT,
        SEL_TIME_FOR_EVENT,
        SEL_SPORT_NAMES_FOR_KEYS,
        SEL_TIMES_FOR_KEYS,
        SEL_TIMES,
        SEL_WEEK_DAYS,
        SEL_EQUIPMENT,
        SIZE
    }
    enum PreparedInsertStatement
    {
        INS_INDIVIDUAL,
        INS_PERIODIC_EVENT,
        INS_SPORT,
        INS_TIME,
        INS_EQUIPMENT,
        SIZE
    }
    enum PreparedUpdateStatement
    {
        UPD_INDIVIDUAL,
        UPD_PERIODIC_EVENT,
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
        static String[] storedProcedures = new String[(int)StoredProcedure.SIZE];

        static PreparedStatements()
        {
            // Stored procedures
            storedProcedures[(int)StoredProcedure.PROC_UPDATE_SPORTS] = "UpdateSports";
            storedProcedures[(int)StoredProcedure.PROC_UPDATE_TIMES] = "UpdateTimes";

            // Select statements here
            selectStatements[(int)PreparedSelectStatement.SEL_IND_CLIENT] = "SELECT id_client, name, middle_name, surname, date_of_birth, address, time_of_registration FROM IndividualClient";
            selectStatements[(int)PreparedSelectStatement.SEL_LOG] = "SELECT * FROM IndividualLog";
            selectStatements[(int)PreparedSelectStatement.SEL_PERIODIC_EVENTS] = "SELECT name, sport_names, id_event, LessonTimes, type_name FROM PeriodicEventView";
            selectStatements[(int)PreparedSelectStatement.SEL_EVENT_TYPES] = "SELECT type, name FROM PeriodicEventTypeNames";
            selectStatements[(int)PreparedSelectStatement.SEL_SPORT_NAMES] = "SELECT id_sport, name FROM Sport";
            selectStatements[(int)PreparedSelectStatement.SEL_SPORT_FOR_EVENT] = "SELECT fk_sport FROM Event_Sport WHERE fk_event = @id_event";
            selectStatements[(int)PreparedSelectStatement.SEL_TIME_FOR_EVENT] = "SELECT fk_lesson FROM Periodic_event_time_lesson WHERE fk_event = @id_event";
            selectStatements[(int)PreparedSelectStatement.SEL_SPORT_NAMES_FOR_KEYS] = "SELECT name FROM Sport WHERE id_sport in ({0})";
            selectStatements[(int)PreparedSelectStatement.SEL_TIMES_FOR_KEYS] = "SELECT time, id_lesson FROM TimesForLessons WHERE id_lesson in ({0})";
            selectStatements[(int)PreparedSelectStatement.SEL_TIMES] = "SELECT time, id_lesson FROM TimesForLessons";
            selectStatements[(int)PreparedSelectStatement.SEL_PERIODIC_EVENT] = @"SELECT id_event, name, type, LessonTimes FROM PeriodicEventView WHERE id_event = @id_event";
            selectStatements[(int)PreparedSelectStatement.SEL_WEEK_DAYS] = @"SELECT day_of_week, name_of_day FROM DayOfWeekName";
            selectStatements[(int)PreparedSelectStatement.SEL_EQUIPMENT] = @"SELECT id_equipment, name FROM Equipment";

            // Insert statements here
            insertStatements[(int)PreparedInsertStatement.INS_INDIVIDUAL] =
                @"INSERT INTO Client (time_of_registration) VALUES(CURRENT_TIMESTAMP);
                  INSERT INTO Individual (id_client, name, middle_name, surname, date_of_birth, address) VALUES(IDENT_CURRENT('Client'), @name, @middleName, @surname, CONVERT(date, @dateOfBirth, 104), @address)";
            insertStatements[(int)PreparedInsertStatement.INS_PERIODIC_EVENT] =
                @"INSERT INTO Event(name) OUTPUT INSERTED.id_event VALUES(@name);
                  INSERT INTO Periodic_event (id_event, type) VALUES(IDENT_CURRENT('Event'), @type)";
            insertStatements[(int)PreparedInsertStatement.INS_SPORT] = @"INSERT INTO Sport(name) VALUES(@name)";
            insertStatements[(int)PreparedInsertStatement.INS_TIME] = @"INSERT INTO Time_Lesson(day_of_week, start_time, duration) VALUES(@day, @start, @duration)";
            insertStatements[(int)PreparedInsertStatement.INS_EQUIPMENT] = @"INSERT INTO EQUIPMENT(name) VALUES(@name)";

            // Update statements here
            updateStatements[(int)PreparedUpdateStatement.UPD_INDIVIDUAL] =
                "UPDATE Individual SET name = @name, middle_name = @middleName, surname = @surname, date_of_birth = CONVERT(date, @dateOfBirth, 104), address = @address WHERE id_client = @id";
            updateStatements[(int)PreparedUpdateStatement.UPD_PERIODIC_EVENT] =
                @"UPDATE Periodic_event SET type = @type WHERE id_event = @id;
                  UPDATE Event SET name = @name WHERE id_event = @id";

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
        static public String GetStatement(StoredProcedure statement)
        {
            return storedProcedures[(int)statement];
        }
    }
}
