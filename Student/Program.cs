using System.Collections.Generic;

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
          List<Student> students = new List<Student>()
          {
            new Student() { Name = "Sally", GradeLevel = 3},
            new Student() { Name = "Bob", GradeLevel = 3},
            new Student() { Name = "Sally", GradeLevel = 2},
          };

          SchoolRoll schoolRoll = new SchoolRoll();
          schoolRoll.AddStudents(students);

          schoolRoll.Students.RemoveAt(0); // with IEnumerable this in not possible
          schoolRoll.Students.Sort(); // with IEnumerable this in not possible

          schoolRoll.Students.AddRange(students); // with IEnumerable this in not possible

          foreach (Student student in schoolRoll.Students)
          {
            System.Console.WriteLine($"{student.Name} is in grade: {student.GradeLevel}");
          }
        }
    }
}
