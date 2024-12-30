using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student(1, "Alice", 16),
            new Student(2, "Bob", 17),
            new Student(3, "Charlie", 14),
            new Student(4, "David", 19),
            new Student(5, "Anna", 15)
        };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var studentsInAgeRange = from student in students
                                     where student.Age >= 15 && student.Age <= 18
                                     select student;

            Console.WriteLine("Danh sách học sinh có tuổi từ 15 đến 18:");
            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var studentsStartingWithA = from student in students
                                        where student.Name.StartsWith("A")
                                        select student;

            Console.WriteLine("Danh sách học sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var totalAge = students.Sum(student => student.Age);

            Console.WriteLine($"Tổng tuổi của tất cả học sinh: {totalAge}");

            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(student => student.Age).FirstOrDefault();

            Console.WriteLine("Học sinh có tuổi lớn nhất:");
            Console.WriteLine($"ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedStudents = students.OrderBy(student => student.Age).ToList();

            Console.WriteLine("Danh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
    
}
