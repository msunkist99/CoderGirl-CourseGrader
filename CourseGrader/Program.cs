using System;

namespace CourseGrader
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            // create a loop that builds the grade array from user input
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter test grade #" + (i + 1) + " - ");
               grades[i] = Convert.ToInt32 (Console.ReadLine());
            }

            // send the grade array to a method that will
            // sum the grades in the array
            // find the average for the grades in the array
            double gradeAverage = FindAverage(grades);
            // send the grade array to a method to find the lowest grade

            // send the grade average and the lowest grade to a method
            int lowestGrade = FindLowestGrade(grades);

            // to determine pass/fail
            string passFail = GradeTestScores(grades);

            Console.WriteLine($"Average grade is {gradeAverage}.  Lowest grade is {lowestGrade}.");
            Console.WriteLine(passFail);
            Console.ReadLine();
        }

        private static double FindAverage(int[] grades)
        {
            int gradeTotal = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                gradeTotal += grades[i];
            }

            double gradeAverage = gradeTotal / grades.Length;

            return gradeAverage;
        }

        private static int FindLowestGrade(int[] grades)
        {
            int lowestGrade = grades[0];

            for (int i = 0; i < grades.Length; i++)
            {
                if (lowestGrade > grades[i])
                {
                    lowestGrade = grades[i];
                }
            }

            return lowestGrade;
        }

        public static string GradeTestScores(int[] grades)
        {
            string passFail;
            int lowestGrade = 0;
            int totalGrades = 0;
            int averageGrade = 0;

            if (grades.Length == 0)
            {
                return "fail";
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (i == 0) 
                {
                    lowestGrade = grades[i];
                }

                if (grades[i] < lowestGrade)
                {
                    lowestGrade = grades[i];
                }
                totalGrades += grades[i];
            }

            averageGrade = totalGrades / grades.Length;

            if ((averageGrade > 69) && (lowestGrade > 49))
            {
                passFail = "pass";
            }
            else 
            {
                passFail = "fail";
            }

            return passFail;
        }
    }
}

