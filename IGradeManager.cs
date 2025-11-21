using System;

{
    public interface IGradeManager
    {
        void processGrades(string studentName, double[] grades);
        double calculateFinalGrade(double bonus, double average);
    }
}

