namespace _03E.JSONparse
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

    public class JSONparse
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { '{', '}' }
                , StringSplitOptions.RemoveEmptyEntries);

            string[] currentStudentDetails = null;
            var studentDict = new Dictionary<string, Student>();

            for (int i = 1; i < inputLine.Length; i += 2)
            {
                currentStudentDetails = inputLine[i]
                    .Split(new char[] { '"', '[', ']', ':', ',', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                var studentName = currentStudentDetails[1];
                var studentAge = int.Parse(currentStudentDetails[3]);
                var studentGrades = currentStudentDetails.Skip(5).Select(int.Parse).ToList();

                var currentStudent = new Student { Name = studentName, Age = studentAge, Grades = studentGrades };

                studentDict.Add(studentName, currentStudent);
            }

            PrintResult(studentDict);
        }

        private static void PrintResult(Dictionary<string, Student> studentDict)
        {
            foreach (var student in studentDict.Values)
            {
                if (student.Grades.Count != 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }
        }
    }
}
