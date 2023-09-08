using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningWebsite
{
    struct AddressFormat
    {
        private string city;
        private string country;

        public AddressFormat(string city, string country)
        {
            this.city = city;
            this.country = country;
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Country: {this.city}, {this.country}");
        }
    }
    internal class Person
    {
        private string name;
        private byte age;
        private string gender;
        private AddressFormat address;
        private string role;



        // Property
        internal string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        internal byte Age
        {
            set { this.age = value; }
            get { return this.age; }
        }

        internal string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }

        internal string Role
        {
            set { this.role = value; }
            get { return this.role; }
        }

        internal AddressFormat Address
        {
            set { this.address = value; }
            get { return this.address; }
        }


        // Constructor
        internal Person(string name, byte age, string gender, AddressFormat address, string role)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
            this.Role = role;
        }


        internal virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {this.name}\nAge: {this.age}\nGender: {this.gender}\nRole: {this.role}");
            this.Address.PrintAddress();

        }
        



     
    }
}
