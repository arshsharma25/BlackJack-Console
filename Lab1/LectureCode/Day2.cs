using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureCode
{
    internal static class Day2
    {
        //public static void Run()
        //{
        //    string names = "joker,,,riddler,catwoman,,twoface,bane|gordon||barbara";
        //    console.writeline("---------dc characters---------");
        //    //string[] villains = names.split(',');
        //    //for (int i = 0; i < villains.length; i++)
        //    //{
        //    //    console.writeline(villains[i]);
        //    //}
        //    char[] delimiters = new char[] { ',', '|' };
        //    string[] characters = names.split(delimiters, stringsplitoptions.removeemptyentries);
        //    for (int i = 0; i < characters.length; i++)
        //    {
        //        console.writeline(characters[i]);
        //    }

        //    arraychallenge();

        //    listchallenge();


        //}


        //private static void listchallenge()
        //{
        //    List<double> grades = new List<double>(10);
        //    random rando = new random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        grades.add(rando.nextdouble() * 100);
        //    }

        //    printgrades(grades);
        //    int numberofgradesremoved = dropfailing(grades);
        //    console.writeline($"{numberofgradesremoved} dropped.");
        //    printgrades(grades);

        //    List<double> curvedGrades = CurveGrades(grades);
        //    PrintGrades(curvedGrades);
        //}

        //private static List<double> CurveGrades(List<double>)
        //{
        //    List<double> curved = CurveGrades().ToList();
        //    for (int i = 0; i < curved.Count; i++)
        //    {
        //        curved[i] += 5;
        //        if (curved[i] > 100) curved[i] = 100;
        //    }
        //    return curved;
        //}

        //private static int DropFailing(List<double> grades)
        //{
        //    console.writeline("----------drop failing grades----------");
        //    int numberremoved = 0;
        //    for (int i = 0; i < grades.count; i++)
        //    {
        //        if (grades[i] < 59.5)
        //        {
        //            grades.removeat(i);
        //            numberremoved++;
        //            i--;
        //        }
        //    }

        //    return numberremoved;
        //}



        //private static void PrintGrades(List<double> grades)
        //{
        //    Console.writeline("--------grades--------------");
        //    for (int i = 0; i < grades.count; i++)
        //    {
        //        console.foregroundcolor = (grades[i] > 89) ? consolecolor.green :
        //                                    (grades[i] > 79) ? consolecolor.cyan :
        //                                    (grades[i] > 69) ? consolecolor.yellow :
        //                                    (grades[i] > 59) ? consolecolor.magenta :
        //                                    consolecolor.red;
        //        console.writeline($"{ grades[i],7:n2}");
        //    }
        //    console.resetcolor();
        //}



        //private static void arraychallenge()
        //{

        //    random rando = new random();
        //    int[] numbers = new int[10];

        //    for (int i = 0; i < numbers.length; i++)
        //    {
        //        numbers[i] = rando.next();
        //    }

        //    console.writeline("------------array challenge---------------");

        //    for (int i = 0; i < numbers.length; i++)
        //    {
        //        console.writeline(numbers[i]);
        //    }

        //}





    }
}
