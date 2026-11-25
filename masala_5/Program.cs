Dictionary<int, string> students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Husan"},
    {104, "Hasan"}
};

System.Console.Write("Student ID kiriting: ");
int id = Convert.ToInt32(Console.ReadLine());

if (students.ContainsKey(id))
{
    students.Remove(id);
    System.Console.WriteLine("Talaba o'chirildi.");
}
else
{
    System.Console.WriteLine("Student does not exists.");
}

