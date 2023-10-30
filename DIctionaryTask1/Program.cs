using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();
    static void Main()
    {
        static void Main(string[] args)
        {
      
           Add("Stan", 96);
           Add("Tori", 98);
            Add("Eli", 87);
           Add("Steve", 68);

            double stansAverage = Average("Stan");
            if (stansAverage <= 0)
            {
                Console.WriteLine($"Stan's Average: {stansAverage}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        Remove("Steve");
static void Add(string name, int a)
        {
            if (grades.ContainsKey(name))
            {
                grades[name].Add(a);
            }
            else
            {
                grades[name] = new List<int>(a);
            }
        }

        static void Remove(string name)
        {
            if (grades.ContainsKey(name))
            {
                grades.Remove(name);
            }
            else
            {
                Console.WriteLine("There is no such name in the school's database!?");
            }
        }

            static double Average(string name)
            {
                if (grades.ContainsKey(name))
                {
                    List<int> gradesForThisStudent = grades[name];
                    if (gradesForThisStudent.Count > 0)
                    {
                        double average = gradesForThisStudent.Average();
                        return average;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
    }
}



