using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information_Form
{
    public class Employee
    {
        private string id;
        private string fName;
        private string lName;
        private string gender;
        private double hourlySalary;
        private double noOfHoursPerWeek;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double HourlySalary
        {
            get { return hourlySalary; }
            set
            {
                if (value >= 1.5 && value <= 7)
                    hourlySalary = value;
                else
                    throw new ArgumentOutOfRangeException("HourlySalary must be between 1.5 and 7");
            }
        }

        public double NoOfHoursPerWeek
        {
            get { return noOfHoursPerWeek; }
            set
            {
                if (value >= 0 && value <= 40)
                    noOfHoursPerWeek = value;
                else
                    throw new ArgumentOutOfRangeException("NoOfHoursPerWeek must be between 0 and 40");
            }
        }

        public double SalaryPerWeek
        {
            get { return hourlySalary * noOfHoursPerWeek; }
        }

        public double AnnualSalary
        {
            get { return hourlySalary * noOfHoursPerWeek * 52; }
        }
    }

}
