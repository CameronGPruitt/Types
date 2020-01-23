using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Cameron";
            int grade = 100;
            char letterGrade = 'A';
            double costOfTuition = 80.00;

            Console.WriteLine($"{firstName} Is the student, {grade} Is the grade he earned, which is an {letterGrade} and the cost of tuition is {costOfTuition}");

        }
    }
}
