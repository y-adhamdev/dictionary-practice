using System.Net;

Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Vali"},
    {102, "Ali"}
};
Console.Write("Ism kiriting: ");
string? name = Console.ReadLine();

Console.Write("ID kiriting: ");
int id = Convert.ToInt32(Console.ReadLine());

if (!students.ContainsKey(id))
{
    students.Add(id, name!);
    System.Console.WriteLine(students.Count);
}