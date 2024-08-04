using OOP5;

class Program
{
    public static void Main(string[] args)
    {
        //Öğrenci Türetimi

        Student student = new Student();
        student.PersonName = "Patika";
        student.PersonSurname = "Dev";
        student.StudentNumber = "42352";
        student.DisplayInfo();

        Console.WriteLine("**********************");
        //Öğretmen Türetimi

        Teacher teacher = new Teacher();
        teacher.PersonName = "Patika";
        teacher.PersonSurname = "Plus";
        teacher.Salary = 150000;
        teacher.DisplayInfo();

    }
}