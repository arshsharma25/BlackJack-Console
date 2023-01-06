using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class PG2Sorting
    {
        // loads data from csv into list
        public static List<String> FileReading()
        {
            string filepath = "inputFile.csv";
            StreamReader reader = null;
            if (File.Exists(filepath))
            {
                reader = new StreamReader(File.OpenRead(filepath));
                List<String> list = new List<String>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach(var value in values)
                    {
                        list.Add(value);
                    }
                }
                reader.Close();
                return list;
            }
            else
            {
                Console.WriteLine("No file exists");
            }
            reader.Close();
            return null;
        }

        // bubble sorting
        public static int BubbleSort(List<String> cloneList)
        {
            int num = cloneList.Count;
            int count = 0;
            Boolean swapped = true;
            while(swapped)
            {
                swapped = false;
                for (int i = 1; i < num; i++)
                {
                    if (cloneList[i - 1].CompareTo(cloneList[i]) > 0)
                    {
                        Swap(cloneList, i - 1, i);   // 5 4 3 2 1  4 3 2 1 5
                        swapped = true;
                    }
                    count++;
                }
                num--;
                count++;
            }
            return count;
        }

        private static void Swap(List<String> cloneList, int v, int i)
        {
            string temp = cloneList[v];
            cloneList[v] = cloneList[i];
            cloneList[i] = temp;
        }

        public static List<String> MergeSort(List<String> list)
        {
            if(list.Count <= 1)
            {
                return list;
            }

            var left = new List<String>();
            var right = new List<String>();

            for(int i = 0; i < list.Count; i++)
            {
                if(i < (list.Count / 2))
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);


            return Merge(left, right);
        }

        private static List<string> Merge(List<string> left, List<string> right)
        {
            var result = new List<String>();

            while (left.Count != 0 && right.Count != 0)
            {
                if(String.Compare(left.First(), right.First()) < 0){
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            while (left.Count != 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }

            while(right.Count != 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }

            return result;
        }

        public static int BinarySearch(List<String> A, String searchterm, int low, int high, ref int recursiveCall)
        {
            if (high < low)
            {
                return -1;
            }

            int mid = (low + high) / 2;

            if (String.Compare(searchterm, A[mid]) < 0)
            {
                recursiveCall++;
                return BinarySearch(A, searchterm, low, mid - 1, ref recursiveCall);
            }
            else if (String.Compare(searchterm, A[mid]) > 0)
            {
                recursiveCall++;
                return BinarySearch(A, searchterm, mid + 1, high, ref recursiveCall);
            }
            else
            {
                return mid;
            }
        }

        public static void Serialize(object obj, String filePath)
        {
            var serializer = new JsonSerializer();
            using var sw = new StreamWriter(filePath, true);
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, obj);
        }
    }

}
