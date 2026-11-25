Dictionary<int, string> students = new Dictionary<int, string>
{
    { 1, "Laptop" },
    { 2, "Mouse" },
    { 3, "Keyboard" },
    { 4, "Monitor" }
};

bool isDone = true;

while (isDone)
{
    System.Console.WriteLine("1 - Mahsulotni ID orqali qidirish.");
    System.Console.WriteLine("2 - Yangi mahsulot qo'shish.");
    System.Console.WriteLine("3 - Mahsulotni o'chirish.");
    System.Console.WriteLine("4 - Jami mahsulotlar sonini ko'rish");
    System.Console.WriteLine("5 - Chiqish");
    Console.Write("Tanlovingiz: ");
    string? i = Console.ReadLine();

    switch (i)
    {
        case "1": 
            GetProduct(students);
            break;
        case "2":
            AddProduct(students);
            break;
        case "3":
            RemoveProduct(students);
        break;
        case "4":
            System.Console.WriteLine($"Mahsulot soni: {students.Count}");
            break;
        case "5":
            isDone = false;
            break;

    }

}

static void GetProduct(Dictionary<int , string> students){
            
            Console.Write("ID kiriting: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if(students.TryGetValue(id, out string? name))
            {
                System.Console.WriteLine(name);
            }
            else
            {
                System.Console.WriteLine("Mahsulot topilmadi.");
            }
}

static void AddProduct(Dictionary<int , string> students)
{
            Console.Write("ID kiriting: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mahsulotni kiriting: ");
            string? newName = Console.ReadLine();
            students.Add(id, newName!);
}

static void RemoveProduct(Dictionary<int, string> students)
{
            Console.Write("ID kiriting: ");
            int id = Convert.ToInt32(Console.ReadLine());
            students.Remove(id);
}

