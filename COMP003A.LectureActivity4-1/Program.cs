//Author:  Brianna Ordaz
//Course:  COMP003A
//Faculty: Jonathan Cruz
//Purpose: Calculate average grades using arrays and list in C#
namespace COMP003A.LectureActivity4_1;

class Program
{
    static void Main(string[] args)
    {
        //Declare an array to store 5 grades
        int[] grades = new int[5];
        
        
        // Collect, validate, then store the grades

        for (int i = 0; i < grades.Length; i++)
        {
            int grade = -1; // Initialize with an invalid value to ensure validation starts
            while (grade < 0 || grade > 100)
            {
                Console.Write($"Enter grade for student {i + 1} (0-100): ");
                if (int.TryParse(Console.ReadLine(), out grade)) //Check if input is a valid integer
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        grades[i] = grade;
                    }
                    else
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    grade = -1; //Reset grade to an invalid value to re-enter the loop
                }
            }
        }
        
        //Calculate the average of the grades:
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];  //Add the current grade to the total sum for averaging
        }
        double average = sum / grades.Length;
        
        //Display the grades and average
        Console.WriteLine("\nGrades:");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade); // Display each grade stored in the array
        }
        Console.WriteLine($"Average Grade: {average:F2}");
        
        //Declare a list of strings to store the names of the students
        List<string> studentNames = new List<string>();
        
        //Collect student names
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            studentNames.Add(Console.ReadLine()); // Add the entered nane to the list of student names
            
        }
        
        //Display student names
        Console.WriteLine("\nStudent Names: ");
        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine($"Student {i + 1}: {studentNames[i]}"); //Display each student name with their index
        }
    }
}