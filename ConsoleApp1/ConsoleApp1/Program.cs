using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SortNamefromFile(@"c:\names.txt");
        }

        public void SortNamefromFile(string urlFile)
        {
            // Read File from the Url
            string[] nameList = TxtReader.ReadFile(urlFile);
            // Declare array for sorting
            List<string> familyNameList = new List<string>();
            List<string> sortedNameList = new List<string>();
            // Sort nameList
            nameList = nameList.OrderBy(x => x).ToArray();
            // Get Family Name for each name
            foreach (string name in nameList)
            {
                familyNameList.Add(GetFamilyName(name));
            }
            // Sort Family Name
            familyNameList.Sort();
            // Sort Name based on sorted Family Name
            foreach (string familyName in familyNameList)
            {
                foreach (string name in nameList)
                {
                    if (GetFamilyName(name) == familyName)
                    {
                        if (!sortedNameList.Contains(name))
                        {
                            sortedNameList.Add(name);
                        }
                    }
                }
            }
            // Write each name into console
            foreach (string sortedName in sortedNameList)
            {
                Console.WriteLine(sortedName);
            }
            TxtReader.WriteFile(sortedNameList);
        }

        public string GetFamilyName(string fullName)
        {
            string[] splitName = fullName.Split(' ');
            return splitName[splitName.Count() - 1];
        }
    }
}
