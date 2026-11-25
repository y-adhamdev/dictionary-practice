Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Husan"},
    {104, "Hasan"}
};

System.Console.Write("Student ID kiriting: ");
string? id = Console.ReadLine();

int StudentID;

int.TryParse(id, out StudentID);

if (students.TryGetValue(StudentID, out string? name))
{
    System.Console.WriteLine($"Name: {name}");
}
else
{
    System.Console.WriteLine("Student does not found");
}