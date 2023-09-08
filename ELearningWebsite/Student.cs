using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningWebsite
{
    internal class Student : Person
    {
        private string courseTaken;

        internal string CourseTaken
        {
            set { this.courseTaken = value; }
            get { return this.courseTaken; }
        }


        internal Student(string name, byte age, string gender, AddressFormat address, string role, string courseTaken) : base(name, age, gender, address, role)
        {
            this.CourseTaken = courseTaken;
        }

        internal override void PrintInfo()
        {
            Console.WriteLine("Student Information: ");
            base.PrintInfo();
            Console.WriteLine($"Course Taken: {this.courseTaken}\n");

        }

    }
}
