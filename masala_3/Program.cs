Dictionary<int, string> students = new Dictionary<int, string>{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Husan"},
    {104, "Hasan"}
};

System.Console.WriteLine(students.Remove(103));
Console.WriteLine(students.Remove(999));
System.Console.WriteLine(students.Count);