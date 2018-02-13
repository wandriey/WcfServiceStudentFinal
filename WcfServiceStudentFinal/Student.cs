using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceStudentFinal
{
    public class Student
    {
        private string _navn;
        private string _klassenavn;
        private int _rum;

        public Student(string navn, string klassenavn, int rum)
        {
            _navn = navn;
            _klassenavn = klassenavn;
            _rum = rum;
        }
        public Student()
        {

        }

        public string Name { get { return _navn; } set { _navn = value; } }
        public string Klassenavn { get { return _klassenavn; } set { _klassenavn = value; } }
        public int Rum { get { return _rum; } set { _rum = value; } }
    }
}