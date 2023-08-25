// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To my school");
Console.WriteLine("Add new student");

School school = new School();

while (true)
{
    Console.WriteLine("Enter student name");
    var studentName = Console.ReadLine();

    var student = new Student(1, studentName);

    school.StudentAdmission(student);

    Console.WriteLine("Do you want to add more?  Y/N");
    var input = Console.ReadLine();
    if (input == "N")
    {
        break;
    }
}

Console.WriteLine("All students:");
var students = school.GetAllStudents();

foreach (var student in students) 
{
    Console.WriteLine(student.StudentName);
}

