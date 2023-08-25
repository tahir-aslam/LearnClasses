// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To my school");
Console.WriteLine("1-Add new student /r/n 2-fee system /r/n 3-Exam system 4-Student report 5-Student List");

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


//Make id unique


