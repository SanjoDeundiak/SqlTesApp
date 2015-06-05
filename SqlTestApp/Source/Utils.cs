﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SqlTestApp
{
    static class Utils
    {
        static public String ValidateString(String st)
        {
            return st == "" ? null : st;
        }

        static DataTable hours = null;
        static DataTable minutes = null;
        static public DataTable Hours
        {
            get
            {
                if (hours == null)
                {
                    hours = new DataTable();
                    DataColumn cl = new DataColumn("hour");
                    hours.Columns.Add(cl);
                    for (Int16 i = 0; i < 24; i++)
                        hours.Rows.Add(i.ToString());
                }

                return hours.Copy();
            }
        }
        
        static public DataTable Minutes
        {
            get
            {
                if (minutes == null)
                {
                    minutes = new DataTable();
                    DataColumn cl = new DataColumn("minute");
                    minutes.Columns.Add(cl);
                    for (Int16 i = 0; i < 60; i += 5)
                        minutes.Rows.Add(i.ToString());
                }

                return minutes.Copy();
            }
        }
    }
}
