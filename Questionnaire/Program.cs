Console.WriteLine("Hello, World!");
Console.Write("Введ. Имя и фам.");
string name = Console.ReadLine();

Console.Write("Введ. группу");
string group = Console.ReadLine();

Console.Write("Введ. год рожд.");
int good = Convert.ToInt32(Console.ReadLine());

Console.Write("Введ. ср. балл");
string bal = Console.ReadLine();

bool ball = int.TryParse(bal, out int ggg);

Console.Write("Введ. любим. буква");
string buk = Console.ReadLine();
char t = '\t';
Console.WriteLine($"{t} Анкета");

Console.WriteLine($"{name}, группа {group}");
Console.WriteLine($"Год рождения: {good}");
Console.WriteLine($"Ср. балл: {bal}");
Console.WriteLine($"Балл >= 4.0: {ball}");
Console.WriteLine($"Любим. буква {buk}");