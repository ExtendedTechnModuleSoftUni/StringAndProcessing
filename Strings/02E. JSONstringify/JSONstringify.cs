namespace _02E.JSONstringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }

    }

    public class JSONstringify
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var studentsDict = new Dictionary<string, Student>();

            while (inputLine != "stringify")
            {
                var currentStudentDetails = inputLine
                    .Split(new char[] { ' ', ':', '-', '>', ',' }
                    , StringSplitOptions.RemoveEmptyEntries);

                var studentName = currentStudentDetails[0];
                var studentAge = int.Parse(currentStudentDetails[1]);
                var studentGrades = currentStudentDetails.Skip(2).Select(int.Parse).ToList();

                var currentStudent = new Student { Name = studentName, Age = studentAge, Grades = studentGrades };

                studentsDict.Add(studentName, currentStudent);

                inputLine = Console.ReadLine();
            }

            PrintResult(studentsDict);
        }

        private static void PrintResult(Dictionary<string, Student> studentsDict)
        {
            int dictCount = studentsDict.Count;
            int printFirstLine = dictCount;

            if (dictCount == 1)
            {
                foreach (var student in studentsDict.Values)
                {
                    Console.WriteLine($"[{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}]");
                    return;
                }         
            }
            foreach (var student in studentsDict.Values)
            {
                if (dictCount == printFirstLine)
                {
                    Console.Write($"[{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
                }
                else if (dictCount != 1)
                {
                    Console.Write($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
                }
                else
                {
                    Console.WriteLine($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}]");
                }

                dictCount--;
            }
        }
    }
}
