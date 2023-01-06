using System;
using System.Collections.Generic;
using System.Linq;
using LectureCode;
using PG2Input;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            //Lectures.Run();
#endif
            List<string> mainList = new List<string>();
            mainList = PG2Sorting.FileReading();
            while (true)
            {
                int choice;
                string[] arr = { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit" };
                Input.ReadChoice("Please enter your choice: ", arr, out choice);

                switch (choice)
                {
                    case 1:
                        // create a cloned list for sorting
                        List<string> clonedList = new List<String>(mainList);
                        int count = PG2Sorting.BubbleSort(clonedList);
                        Console.WriteLine("# of items: " + clonedList.Count + ". Bubble Sort loops: " + count);
                        Console.WriteLine("Bubble Sort");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        for (int i = 0; i < mainList.Count; i++)
                        {
                            Console.WriteLine("{0, -50} {1, -10}", mainList[i], clonedList[i]);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        List<String> mergerSortList = PG2Sorting.MergeSort(mainList);
                        foreach(String s in mergerSortList)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        List<string> binaryClonedList = new List<String>(mainList);
                        binaryClonedList = PG2Sorting.MergeSort(binaryClonedList);
                        foreach(String s in binaryClonedList)
                        {
                            int recursiveCall = 0;
                            int foundPosition;
                            foundPosition = PG2Sorting.BinarySearch(binaryClonedList, s, 0, binaryClonedList.Count, ref recursiveCall);
                            Console.WriteLine("{0,-45} {1,-25} {2,-25} {3,-25}", s, "Index:" + binaryClonedList.IndexOf(s), "Found Index:" + foundPosition, "Recursive Calls:" + recursiveCall);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        string filePath = "";
                        Input.ReadString("Please enter the name of the file for saving: ", ref filePath);
                        //Console.WriteLine(Path.GetExtension(filePath));
                        var result = "";
                        if (Path.HasExtension(filePath))
                        {
                            if (!Path.GetExtension(filePath).Equals(".json"))
                            {
                                result = Path.ChangeExtension(filePath, ".json");
                            }
                        }
                        else
                        {
                            result = Path.ChangeExtension(filePath, ".json");
                        }
                        
                        List<string> saveClonedList = new List<String>(mainList);
                        saveClonedList = PG2Sorting.MergeSort(saveClonedList);
                        foreach(String phrase in saveClonedList)
                        {
                            PG2Sorting.Serialize(phrase, result);
                        }
                        Console.WriteLine("File Saved at " + result);
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;


                }

            }
        }
    }
}
