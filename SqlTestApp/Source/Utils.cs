using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestApp
{
    static class Utils
    {
        static public String ValidateString(String st)
        {
            return st == "" ? null : st;
        }
    }
}
