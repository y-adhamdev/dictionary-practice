Dictionary<int, string> Students = new Dictionary<int, string>
{
    {101, "Ali"},
    {102, "Vali"},
    {103, "Hasan"},
    {104, "Husan"}
};
Console.WriteLine(Students.ContainsKey(101));
Console.WriteLine(Students.ContainsKey(105));
