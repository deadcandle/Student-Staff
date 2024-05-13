using Student_Staff;

class Program
{
    public static void Main(string[] args)
    {
        Student stud1 = new Student("Misha", "Edisonweg 4a", "Software", 2024, 420.69);
        Student stud2 = new Student("Diego", "Jan Ligthartstraat 250", "Software", 2024, 9.99);
        Staff staff1 = new Staff("John", "Straatnaam 123", "Zadkine", 40);
        Staff staff2 = new Staff("Jane", "Straatnaam 23", "Zadkine", 30);

        Console.WriteLine(staff1);
        Console.WriteLine(staff2);
        Console.WriteLine(staff1);
        Console.WriteLine(staff2);
    }
}