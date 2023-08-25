// See https://aka.ms/new-console-template for more information
public class Student
{
    //Fields
    private string _studentName;

    //contructor

    public Student(int id, string name)
    {
        _studentName = name;
    }

    //properties

    public int StudentId { get; set; }

    public string StudentName
    {
        get
        {
            return _studentName;
        }
        set
        {
            _studentName = value;
        }
    }

    //public methods
    public string GetStudentResult(int id)
    {
        //exam
        return string.Empty;
    }

    //private methods
    private DateTime GetStudentAge(DateTime dateOfBirth)
    {
        return DateTime.Now;
    }
}
