Console.WriteLine("Hello, World!");
string Name = "Иванова Иван Иванович";
﻿const string Name = "Иванова Иван Иванович";
string group = "ИПС-251";
int course = 2;
string spec = "09.02.07";

double total = (3 + 4 + 5) / 3;
int week = 9;
Console.WriteLine($"    ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine($"ФИО:            {Name}");
Console.WriteLine($"Группа:         {group}");
Console.WriteLine($"Курс:           {course}");
Console.WriteLine($"Специальность:  {spec}");

Console.WriteLine();
Console.WriteLine($"");

Console.WriteLine($"Ср. балл за 3 работы:        {total}");
Console.WriteLine($"Стипендия положена (>= 4.0): True");

Console.WriteLine($"");

Console.WriteLine($"Учебных недель осталось в семестре: {week}");