using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    enum SecurityLevel
    {
        Guest , Developer , Secretary , DBA
    }
    enum Gender
    {
        M , F
    }
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate()
        {
            DateTime today = DateTime.Now; 
            Day = today.Day;     
            Month = today.Month; 
            Year = today.Year;  
        }
        public HiringDate(int day ,  int month , int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
    internal class Employee
    {
        public  int ID { get; init; }
        public string Name { get; set; }
        public SecurityLevel securityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender gender { get; init; }


        public Employee()
        {
            securityLevel = SecurityLevel.Guest;
            Name = "";
            Salary = Constants.MinumimWage;
            HiringDate = new HiringDate();

        }

        public Employee(int id , string name , SecurityLevel security_Level , decimal salary , HiringDate hireDate , Gender gen)
        {
            ID = id;
            Name = name;
            securityLevel = security_Level;
            Salary = salary;
            HiringDate = hireDate;
            gender = gen;
        }
        public override string ToString()
        {
            return String.Format(
                 "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date::{4}-{5}-{6}, Gender: {7}",
                 ID,
                Name,
                securityLevel,
                Salary,
                HiringDate.Year,
                HiringDate.Month,
                HiringDate.Day,
                gender
                 );
        }


    }
}
