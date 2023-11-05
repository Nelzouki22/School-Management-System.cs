using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        School school = new School("Sample School");

        // Adding students
        Student student1 = new Student("John", "Doe", "2023001");
        Student student2 = new Student("Jane", "Smith", "2023002");
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Adding teachers
        Teacher teacher1 = new Teacher("Mr. Johnson", "Mathematics");
        Teacher teacher2 = new Teacher("Ms. Davis", "Science");
        school.AddTeacher(teacher1);
        school.AddTeacher(teacher2);

        // Adding courses
        Course mathCourse = new Course("Math 101", teacher1);
        Course scienceCourse = new Course("Science 101", teacher2);
        school.AddCourse(mathCourse);
        school.AddCourse(scienceCourse);

        // Enrolling students in courses
        mathCourse.EnrollStudent(student1);
        scienceCourse.EnrollStudent(student2);

        // Display student and teacher information
        Console.WriteLine("Students:");
        foreach (Student student in school.Students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nTeachers:");
        foreach (Teacher teacher in school.Teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}

class School
{
    public string Name { get; }
    public List<Student> Students { get; } = new List<Student>();
    public List<Teacher> Teachers { get; } = new List<Teacher>();
    public List<Course> Courses { get; } = new List<Course>();

    public School(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

class Student : Person
{
    public string StudentId { get; set; }

    public Student(string firstName, string lastName, string studentId) : base(firstName, lastName)
    {
        StudentId = studentId;
    }

    public override string ToString()
    {
        return $"Student: {base.ToString()}, ID: {StudentId}";
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string fullName, string subject) : base(fullName, "")
    {
        Subject = subject;
    }

    public override string ToString()
    {
        return $"Teacher: {FirstName} {Subject}";
    }
}

class Course
{
    public string Name { get; }
    public Teacher Teacher { get; }
    public List<Student> Students { get; } = new List<Student>();

    public Course(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
    }

    public void EnrollStudent(Student student)
    {
        Students.Add(student);
    }
}
