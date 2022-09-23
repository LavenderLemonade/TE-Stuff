using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.CLasses
{
    public class person
    {
        //name
        public string Name { get; set; }
        //age
        public int Age
        { //derived property. only get = readonly
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }
        private int birthYear { get; set; }
        //height
        public double Height { get; set; }
        //eye color

        //SSN
        private string ssn { get; set; }

        //Constructor 

        public person(int yearOfBirth)
        {
            birthYear = yearOfBirth;
        }
    }
}
