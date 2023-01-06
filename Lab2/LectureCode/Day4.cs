using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureCode
{
    internal static class Day4
    {
        //public static void Run()
        //{
        //    string fPath = @"C:\Users\zappt\Desktop\Full Sail Stuff\PG2\PG2 Labs\Lab2\LectureCode\numbers.txt";
        //    WriteData(fPath);
        //    ReadData(fPath);
        //    WriteJson(fPath);

        //}


        //static List<int> ReadJson(string filePath)
        //{
        //    List<int> nums = null;

        //    if (File.Exists(filePath))
        //    {
        //        try
        //        {
        //            string fileText = File.ReadAllText(filePath);
        //            nums = JsonConvert.DeserializieObject
        //        }
        //        catch(Exception)
        //        {
        //            Console.WriteLine("Error reading file");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("The file does not exist");
        //    }
        //    return nums;
        //}

        //static void WriteJson(string filePath)
        //{
        //    List<int> nums = new List<int>() { 5, 19, 93, 42 };

        //    filePath = Path.ChangeExtension(filePath, ".json");
        //    using (StreamWriter sw = new StreamWriter(filePath))
        //    {
        //        using (JsonTextWriter jtw = new JsonTextWriter(sw))
        //        {
        //            jt.Formatting = Formatting.Indented;
        //        }
        //    }


        //}


        //static void ReadData(string filePath)
        //{
        //    using (StreamReader sr = new StreamReader(filePath))
        //    {
        //        string line;

        //        char delimiter = ':';
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] data = line.Split(delimiter);
        //            List<string> nums = data.ToList();
        //            for (int i = 0; i < nums.Count; i++)
        //            {
        //                Console.Write(nums[i]);
        //            }
        //        }
        //    }
        //}


        //static void WriteData(string filePath)
        //{
        //    List<int> nums = new List<int>() { 5, 12, 42, 13};


        //    char delimiter = ':';
        //    bool isFirst = true;
        //    using (StreamWriter sw = new StreamWriter(filePath))
        //    {
        //        for (int i = 0; i < nums.Count; i++)
        //        {
        //            if(!isFirst)
        //                sw.Write(delimiter);
        //            sw.Write(nums[i]);
        //            isFirst = false;

        //        }
        //    }
        //}
    }
}
