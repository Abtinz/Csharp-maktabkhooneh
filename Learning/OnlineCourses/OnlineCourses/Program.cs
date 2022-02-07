﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses
{
    internal class Program
    {
        //user
        public static string fullName;
        public static string email;
        public static int phoneNumber;

        //course
        public static string courseName;
        public static string courseId;
        public static string courseTeacher;
        public static string courseOrganizer;
        public static string courseDescription;
        public static Boolean courseIsSaved;

        //email
        public static string serverEmail;
        public static string emailContext;

        //feedback
        public static string feedBack;

        static void Main(string[] args)
        {
            signUp();
            courseIsSaved = false;
            while (true)
            {
                Console.WriteLine("Full name :" + fullName);
                Console.WriteLine("1) New Course"
                    + "\n2) Course View" + "\n3) Print Course (email)" + "\n4) feed back" + "\nElse : Exit");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    NewCourse();
                }
                else if (choice== "2")
                {

                }
                else if (choice == "3")
                {

                }
                else
                {

                }
               
            }
            
        }

        static void signUp()
        {
            Console.Write("Please enter your name: ");
            fullName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            fullName += Console.ReadLine();
            Console.Write("Please enter your email: ");
            email = Console.ReadLine();
            while (true)
            {
                Console.Write("Please enter your phone Number: ");
                string enterdPhoneNumber = Console.ReadLine();
                //numeric check
                bool isNumeric = int.TryParse(enterdPhoneNumber, out phoneNumber);
                if (isNumeric)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error phone number is numeric!");
                }
                 
            }
             
        }


        static void NewCourse()
        {
            Console.Write("Course Name: ");
            courseName = Console.ReadLine();
            Console.Write("Course ID: ");
            courseId = Console.ReadLine();
            Console.Write("Course Teacher: ");
            courseTeacher = Console.ReadLine();
            Console.Write("Course Organizer: ");
            courseOrganizer = Console.ReadLine();
            Console.Write("Course Description: ");
            courseDescription = Console.ReadLine();
            courseIsSaved = true;
        }
    }
}

