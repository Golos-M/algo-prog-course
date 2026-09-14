
Console.WriteLine("Hello, World!");
﻿Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomLength * roomWidth;
double roomPerimeter = (roomWidth + roomLength) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int Price = 65000;
int Count = 12;
double Rate = 0.08;

double total = Price * (1 + Rate);
double Payment = total / Count;

Console.WriteLine($"Цена ноутбука:{Price} руб.");
Console.WriteLine($"Итого с процентами: {total} руб.");
Console.WriteLine($"Платёж в месяц: {Payment} руб.");

Console.WriteLine("");
int a = 25;
int b = 4;
int c = a / b;
double f = (double)a/b;
Console.WriteLine($"int{c}");
Console.WriteLine($"double{f}");

Console.WriteLine();
Console.WriteLine("Сторки");

string fN = "Анна";
string lN = "Смирнова";

string fNC = fN + " " + lN;
string fNI = $"{fN} {lN}";
string fNCM = string.Concat(fN, " ", lN);

Console.WriteLine(fNC);
Console.WriteLine(fNI);
Console.WriteLine(fNCM);
Console.WriteLine();

Console.WriteLine("Константы");

@@ -63,7 +64,14 @@
int scolarship = 10000;
int month = 7999;
int money = scolarship - month;
const semester = 4;
int total = money * semester;
Console.WriteLine(total);
 GCNotificationStatus
const int semester = 4;
int total1 = money * semester;
Console.WriteLine(total1);

Console.WriteLine();

int totalMinutes = 500;
int minutesPerLesson = 45;
int Lessons = totalMinutes / minutesPerLesson;
int endLesson = totalMinutes % minutesPerLesson;
Console.WriteLine($"{totalMinutes} минут = {Lessons} полных занятий + {endLesson} минут.");
Console.WriteLine();