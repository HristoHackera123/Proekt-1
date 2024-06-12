using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UspehNaPichoveteOt2raGrupa9A
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private double bgGrade;
        private double mathGrade;
        private double historyGrade;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double BgGrade
        {
            get { return bgGrade; }
            set { bgGrade = value; }
        }
        public double MathGrade
        {
            get { return mathGrade; }
            set { mathGrade = value; }
        }
        public double HistoryGrade
        {
            get { return historyGrade; }
            set { historyGrade = value; }
        }

        public Person(string fName, string lName, double bg, double math, double history)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BgGrade = bg;
            this.MathGrade = math;
            this.HistoryGrade = history;
        }
    }
}
