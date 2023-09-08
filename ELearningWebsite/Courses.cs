using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningWebsite
{
    // writing course publish date structure
    struct PublishDate
    {
        private byte day;
        private byte month;
        private int year;


        public PublishDate(byte day, byte month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void PrintPublishDate()
        {
            Console.WriteLine($"Publish Date: {this.day}-{this.month}-{this.year}");
        }
    }
    struct CourseInfo
    {
        private string name;
        private int serialNumber;
        private string creatorName;
        private int price;
        private byte duration;
        private byte rating;


        public CourseInfo(string name, int serialNumber, string creatorName, int price, byte duration, byte rating)
        {
            this.name = name;
            this.serialNumber = serialNumber;
            this.creatorName = creatorName;
            this.price = price;
            this.duration = duration;
            this.price = price;
            this.rating = rating;

        }


        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Information: \nSerial Number: {this.serialNumber}" +
                $"\nName: {this.name}\n"+
                $"Duration: {this.duration} hours\nPrice: ${this.price}\n" +
                $"Rating: {this.rating} star\nCreated By: {this.creatorName}");
        }
    }

    // Course Class
    internal class Courses
    {

        private PublishDate publishDate;
        private CourseInfo course;

 

        public CourseInfo Course
        {
            set { this.course = value; }
            get { return this.course; }
        }

        public PublishDate Date
        {
            set { this.publishDate = value; }
            get { return this.publishDate; }
        }



        public Courses(CourseInfo course, PublishDate publishDate)
        {
            this.Date = publishDate;
            this.Course = course;
        }


        public void ShowCourseInfo()
        {
            this.Course.PrintCourseInfo();
            this.Date.PrintPublishDate();
   
        }



        
    }
}
