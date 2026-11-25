Dictionary<string, string> users = new()
{
    { "ali123", "password1" },
    { "vali456", "password2" },
    { "hasan789", "password3" }
};

Console.Write("Loginingizni kiriting: ");
string? login =  Console.ReadLine();
Console.Write("Passwordni kiriting: ");
string? UserPasswor =  Console.ReadLine();



if(users.TryGetValue(login!, out string? password))
{
    if(password == UserPasswor)
    {
        System.Console.WriteLine("Login successful");
    }
    else
    {
        System.Console.WriteLine("Incorrect password.");
    }
}
else
{
    System.Console.WriteLine("User not found");
}
