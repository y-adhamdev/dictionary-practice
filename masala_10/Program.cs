Dictionary<string, string> users = new()
{
    { "ali123", "password1" },
    { "vali456", "password2" },
    { "hasan789", "password3" }
};

Console.Write("Loginingizni kiriting: ");
string? login =  Console.ReadLine();

if(users.TryGetValue(login!, out string? password))
{
    if(users[login!] == password)
    {
        System.Console.WriteLine("Login successful");
    }
}
else
{
    System.Console.WriteLine("User not found");
}
