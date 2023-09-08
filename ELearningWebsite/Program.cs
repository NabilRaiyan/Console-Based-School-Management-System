using ELearningWebsite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Courses course1 = new Courses( new CourseInfo("Python 100 days", 1, "Raiyan Al Sultan", 12, 45, 4), new PublishDate(2, 2, 2020));
            course1.ShowCourseInfo();


            Console.WriteLine();
            /*
                        Person student1 = new Student("Raiyan", 23, "Male", new AddressFormat("Dhaka", "Bangladesh"), "Student", "C#");
                        student1.PrintInfo();


                        Person teacher = new Teacher("Nabil Raiyan", 30, "Male", new AddressFormat("Dhaka", "Bangladesh"), "Teacher", 30000, new JoiningDate(2, 2, 2019));
                        teacher.PrintInfo();
            */

            Person[] persons = new Person[2];
            persons[0] = new Student("Raiyan", 23, "Male", new AddressFormat("Dhaka", "Bangladesh"), "Student", "C#");
            persons[1] = new Teacher("Nabil Raiyan", 30, "Male", new AddressFormat("Dhaka", "Bangladesh"), "Teacher", 30000, new JoiningDate(2, 2, 2019));

            foreach (Person person in persons)
            {
                person.PrintInfo();
                
            }
        }
    }
}
