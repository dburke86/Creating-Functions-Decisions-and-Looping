using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            SetInstructorName("Daniel Burke");
            SetCourseTitle("MSCA PCAD1");
            AddClass("MSCA PCAD1", true, true, true);
            DisplayReminders("Friday");
        }

        static void SetInstructorName(string newName)
        {
            string instructorName = newName;
            Console.Out.WriteLine("Instructor name is " + instructorName + ". ");
        }
        static void SetCourseTitle(string newTitle)
        {
            bool result = ValidateCourseTitleLength(newTitle);
            if (result)
            {
                string courseTitle = newTitle;
                Console.Out.WriteLine("Course Title is " + courseTitle + ". ");
            }
            else
            {
                Console.Out.WriteLine("Class name exceeds 50 characters, please shorten.");
            }
        }
        static bool ValidateCourseTitleLength(string Title)
        {
            if(Title.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void AddClass(string title, bool isInProgram, bool isRequired, bool isElective)
        {
            if(isInProgram)
            {
                if(isRequired)
                {
                    Console.Out.WriteLine(title + " is in the program and it is a required course.");
                }
                else if(isElective)
                {
                    Console.Out.WriteLine(title + " is in the program and is an elective course.");
                }
                else
                {
                    Console.Out.WriteLine(title + " is in the program but is an extra credit course.");
                }

            }
            else
            {
                Console.Out.WriteLine(title + " is not in the program.");
            }
        }
        static void DisplayReminders(string day)
        {
            switch(day)
            {
                case "Wednesday":
                    Console.Out.WriteLine("Discussion post is due today!");
                    break;
                case "Friday":
                    Console.Out.WriteLine("Quiz is due today.");
                    break;
                case "Sunday":
                    Console.Out.WriteLine("Assignment is due today!");
                    break;
            }
        }
        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            

        }
    }
}
