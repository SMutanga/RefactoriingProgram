using System;

namespace RefactoringHomework
{
    public class GradeManager : IGradeManager
    {


        private double passingGrade = 50.0;

        public double PassingGrade
        {
            get { return passingGrade; }
            set { passingGrade = value; }
        }



        public void LogGradeProcessingMessage()
        {
            Console.WriteLine("Working on grades...");
        }


        public void processGrades(string studentName, double[] grades)
        {
            Console.WriteLine("Processing grades for " + studentName);

            global::System.Double total = CalculateTotal(grades);
            CalculateAverage (grades, total);
        }



        private void CalculateAverage(global::System.Double[] grades, System.Double total)
        {
            double average = total / grades.Length;
            Console.WriteLine("Average: " + average);

            if (average >= passingGrade)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }



        private static global::System.Double CalculateTotal(global::System.Double[] grades)
        {
            double total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            return total;
        }

        public double calculateFinalGrade(double bonus, double average)
        {
            return average + bonus;
        }
    }
}