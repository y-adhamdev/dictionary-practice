Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"}
};

Console.Write("ID kiriting: ");
int id = Convert.ToInt32(Console.ReadLine());

if (students.TryGetValue(id, out string? name))
{
    Console.Write("Ismingizni kiriting: ");
    string? newName = Console.ReadLine();
    students[id] = newName!; 
}