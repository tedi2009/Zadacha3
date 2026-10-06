using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha3
{
    internal class Student
    {
        private string names;
        private int facultyNumber;
        private string specialty;
        private int course;

        public Student()
        {
            names = "Иван Иванов Иванов";
            facultyNumber = 1;
            specialty = "Информатика";
            course = 1;
        }

        public Student(string names, int facultyNumber)
        {
            SetNames(names);
            SetFacultyNumber(facultyNumber);

            specialty = "Информатика";
            course = 1;
        }

        public Student(string names, int facultyNumber, string specialty, int course)
        {
            SetNames(names);
            SetFacultyNumber(facultyNumber);
            SetSpecialty(specialty);
            SetCourse(course);
        }

        private void SetNames(string names)
        {
            if (names.Length >= 3)
                this.names = names;
            else
                this.names = "Иван Иванов Иванов";
        }

        private void SetFacultyNumber(int facultyNumber)
        {
            if (facultyNumber > 0)
                this.facultyNumber = facultyNumber;
            else
                this.facultyNumber = 1;
        }

        private void SetSpecialty(string specialty)
        {
            if (specialty.Length >= 3)
                this.specialty = specialty;
            else
                this.specialty = "Информатика";
        }

        private void SetCourse(int course)
        {
            if (course >= 3)
                this.course = course;
            else
                this.course = 1;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имена: " + names);
            Console.WriteLine("Факултетен номер: " + facultyNumber);
            Console.WriteLine("Специалност: " + specialty);
            Console.WriteLine("Курс: " + course);
        }
    }
}
