Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Husan"},
    {104, "Hasan"}
};

if(students.TryGetValue(1030, out string? name))
{
    System.Console.WriteLine($"Result: {name}");
}else {
    System.Console.WriteLine("Student not found.");
    }