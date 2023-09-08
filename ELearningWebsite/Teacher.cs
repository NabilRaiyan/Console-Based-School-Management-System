using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningWebsite
{

    struct JoiningDate
    {
        private byte day;
        private byte month;
        private int year;

        internal JoiningDate(byte day, byte month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        internal void PrintJoiningDate()
        {
            Console.WriteLine($"Joining Date: {this.day}-{this.month}-{this.year}");
        }
    }
    internal class Teacher : Person
    {
        private int salary;
        private JoiningDate date;



        // Property
        internal int Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }

        internal JoiningDate Date
        {
            set { this.date = value; }
            get { return this.date; }
        }


        internal Teacher(string name, byte age, string gender, AddressFormat address, string role, int salary, JoiningDate date) : base(name, age, gender, address, role)
        {
            this.Salary = salary;
            this.Date = date;
        }


        internal override void PrintInfo()
        {
            Console.WriteLine("Teacher Information: ");
            base.PrintInfo();
            Console.WriteLine($"Salary: {this.Salary} TK");
            this.Address.PrintAddress();
            this.Date.PrintJoiningDate();
        }

    }
}
