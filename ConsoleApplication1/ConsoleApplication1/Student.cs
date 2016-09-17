using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        #region Properties
        private int _year;

        public int GetYear() { return _year; }

        public int Year { get; set; }

        public string Model { get; set; }

        #region Constructors

        public Car(int year)
        {
            this.Year = year;
        }

        #endregion

    }
}
