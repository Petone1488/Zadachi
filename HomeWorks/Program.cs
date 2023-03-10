// Напишите программы вычисляющую среднее арифметическое 2х чисел.
// =========== 1 вариант решения ==========
string simbol;

int a, b;

Console.WriteLine("Введите первое число");

simbol = Console.ReadLine();

a = Convert.ToInt32(simbol);

Console.WriteLine("Введите второе число");

simbol = Console.ReadLine();

b = Convert.ToInt32(simbol);

int result = (a + b) / 2;

Console.WriteLine("Среднее арифметическое двух чисел = " + result);

// =========== 2 вариант решения ===========

// int a, b;
// a = 5;
// b = 5;
// int result = (a + b) / 2;
// Console.WriteLine(result);
