using System.Data;

Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Xusan"},
    {104, "Xasan"}
};

for(int i = 0; i <= 2; i++)
{
    Console.Write("ID kiriting: ");
    int id = Convert.ToInt32(Console.ReadLine());
    if(students.TryGetValue(id, out string? name))
    {
    Console.WriteLine(name);
    }
    else
    {
        System.Console.WriteLine("Student does not found.");
    }
}