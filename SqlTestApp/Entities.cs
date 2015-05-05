﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestApp
{
    public class Individual
    {
        private String name;
        private String middleName;
        private String surname;
        private String dateOfBirth;
        private String address;

        public Int32 id;
        public String Name
        {
            get { return name; }
            set { name = Utils.ValidateString(value); }
        }
        public String MiddleName
        {
            get { return middleName; }
            set { middleName = Utils.ValidateString(value); }
        }
        public String Surname
        {
            get { return surname; }
            set { surname = Utils.ValidateString(value); }
        }
        public String DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = Utils.ValidateString(value); }
        }
        public String Address
        {
            get { return address; }
            set { address = Utils.ValidateString(value); }
        }
    }
}