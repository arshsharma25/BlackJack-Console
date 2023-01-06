using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureCode
{
    //internal static class Day3
    //{
    //    public static void Run()
    //    {
    //        Dictionary<string, double> pg2 = new Dictionary<string, double>();
    //        Random rando = new Random();
            

    //        pg2.Add("Steve", rando.NextDouble() * 100.0);
    //        pg2.Add("Bob", rando.NextDouble() * 100.0);
    //        pg2.Add("Alice", rando.NextDouble() * 100.0);

    //        pg2["Diana"] = rando.NextDouble() * 100.0;
    //        pg2["Barry"] = rando.NextDouble() * 100.0;

    //        PrintGrades(pg2);

    //        DropStudent(pg2);

    //        CurveStudent(pg2);
    //    }


    //    private static void CurveStudent(Dictionary<string, double> grades)
    //    {
    //        Console.Write("Name of student to curve: ");
    //        string student = Console.ReadLine();
    //        if (grades.TryGetValue(student, out double grade))
    //        {
    //            grades[student] = grade + 5;
    //            if (grades[student] > 100) grades[student] = 100;

    //        }
    //        else
    //            Console.Write($"{student} is not in the course");

    //    }





    //    private static void CheckPrice(Dictionary<string, float> menu)
    //    {
    //        Console.Write("Item to check: ");
    //        string menuItem = Console.ReadLine();

    //        if (menu.ContainsKey(menuItem))
    //        {
    //            Console.WriteLine($"{menuItem} was found.");
                
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{ menuItem} was not found.");
    //        }

    //    }

        
        
    //    private static void DropStudent(Dictionary<string, double> grades)
    //    {
    //        Console.Write("Name of the student to drop: ");
    //        string student = Console.ReadLine();

    //        bool wasDropped = grades.Remove(student);
    //        if (wasDropped)
    //            Console.WriteLine($"{student} was dropped from course");
    //        else
    //            Console.WriteLine($"{student} was not in the course");


    //    }
        
        
        
    //    private static void PrintGrades(Dictionary<string, double> grades)
    //    {
    //        Console.Write("------------Grades---------------");
    //        foreach (var grade in grades)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Yellow;
    //            Console.Write(grade.Key);

    //            Console.CursorLeft = 15;
    //            Console.ForegroundColor = ConsoleColor.DarkGreen;
    //            Console.WriteLine($"{grade.Value:N2}");

    //        }
    //        Console.ResetColor();
    //    }

    //}
}
