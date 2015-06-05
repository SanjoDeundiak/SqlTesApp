﻿using System;
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

        static public DataTable getEventTypes()
        {
            SqlDataReader reader = Connection.executeStatementAndGetReader(PreparedStatements.GetStatement(PreparedSelectStatement.SEL_EVENT_TYPES));

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

        static public int addPeriodicEvent(String name, Int16 type)
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters["@name"] = name;
            parameters["@type"] = type.ToString();

            return Connection.executeStatement(PreparedStatements.GetStatement(PreparedInsertStatement.INS_PERIODIC_EVENT), parameters);
        }
    }
}
