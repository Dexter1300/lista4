﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lista4
{
    public class Student
    {
        [XmlAttribute("id")]
        public int StudentId { get; set; }

        [XmlAttribute("imie")]
        public string FirstName { get; set; }

        [XmlAttribute("nazwisko")]
        public string LastName { get; set; }

        [XmlAttribute("wiek")]
        public int Age { get; set; }

        [XmlAttribute("pesel")]
        public long Pesel { get; set; }

        public Student(int nStudentId, string sFirstName, string sLastName, int nAge, long lPesel)
        {
            StudentId = nStudentId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
            Pesel = lPesel;
        }

        public Student()
        {
            StudentId = 0;
            FirstName = "Janusz";
            LastName = "Januszewski";
            Age = 120;
            Pesel = 999909090;
        }
    }
}
