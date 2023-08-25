// See https://aka.ms/new-console-template for more information
public class School
{
    private readonly List<Student> _students;

    public School()
    {
        _students = new List<Student>();        
    }   

    public List<Student> GetAllStudents()
    {
        return _students;
    }

    public void StudentAdmission(Student student)
    {
        _students.Add(student);
    }
}