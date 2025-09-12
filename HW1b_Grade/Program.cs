// HW1b Grade

// Your Name: Cooper Baer
// Did you seek help ? If yes, specify the helper or web link herehttps://www.w3schools.com/cs/index.php

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string studentidAsString;
            string exam1AsString;
            string exam2AsString;
            string exam3AsString;
            string participationGradeAsString;
            string homeworkGradeAsString;

            double participationGrade;
            double homeworkGrade;
            double exam1Grade;
            double exam2Grade;
            double exam3Grade;
            double finalGrade;

            const double participation_weight = 0.15;
            const double homework_weight = 0.20;
            const double exam1_weight = .15;
            const double exam2_weight = .25;
            const double exam3_weight = .25;

            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();

            Console.WriteLine("What is your student ID number?");
            studentidAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Homework?");
            homeworkGradeAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Participation?");
            participationGradeAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            exam1AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            exam2AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            exam3AsString = Console.ReadLine();

            exam1Grade = Convert.ToDouble(exam1AsString);
            exam2Grade = Convert.ToDouble(exam2AsString);
            exam3Grade = Convert.ToDouble(exam3AsString);
            homeworkGrade = Convert.ToDouble(homeworkGradeAsString);
            participationGrade = Convert.ToDouble(participationGradeAsString);

            finalGrade = (exam1Grade * exam1_weight) + 
                         (exam2Grade * exam2_weight) +
                         (exam3Grade * exam3_weight) +
                         (homeworkGrade * homework_weight) +
                         (participationGrade *  participation_weight);

            Console.WriteLine(firstname + " " + lastname + " (" + studentidAsString + "), your final grade is " + (finalGrade / 100).ToString("P2")); 



        }
    }
}
