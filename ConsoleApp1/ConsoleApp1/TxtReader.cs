using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class TxtReader
    {
        public static string[] ReadFile(string fileUrl)
        {
            string[] names = File.ReadAllLines(fileUrl, Encoding.UTF8);
            return names;
        }

        public static void WriteFile(List<string> data)
        {
            string[] lines = new string[data.Count];
            int index = 0;
            string fileName = @"C:\Users\tr4v3\Documents\sorted-names-list.txt";
            // Map the names to array of string
            foreach (string item in data)
            {
                lines[index] = item;
                index++;
            }
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // Write the array of string to the new file
            System.IO.File.WriteAllLines(fileName, lines);
        }
    }
}
