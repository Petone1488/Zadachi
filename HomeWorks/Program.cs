﻿// Задача 1. Напишите программы вычисляющую среднее арифметическое 2х чисел.
// 1 вариант решения:

// string simbol;

// int a, b;

// Console.WriteLine("Введите первое число");

// simbol = Console.ReadLine();

// a = Convert.ToInt32(simbol);

// Console.WriteLine("Введите второе число");

// simbol = Console.ReadLine();

// b = Convert.ToInt32(simbol);

// int result = (a + b) / 2;

// Console.WriteLine("Среднее арифметическое двух чисел = " + result);

//  2 вариант решения: 

// int a, b;
// a = 5;
// b = 5;
// int result = (a + b) / 2;
// Console.WriteLine(result);

// 3 вариант решения.

// double firstValue, SecondValue;

// Console.WriteLine("Введите первое число");

// firstValue = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");

// SecondValue = double.Parse(Console.ReadLine());

// double result = (firstValue + SecondValue) / 2;

// Console.WriteLine("Среднее арифметическое двух чисел = " + result);


// Задача 2. Введите 3 числа и выведите на экран значение суммы и произведения этих чисел.

// 1 вариант решения:

// int a = 2, b = 3, c = 4;
// int summ = a + b + c;
// int multi = a * b * c;
// Console.WriteLine("Сумма чисел = " + summ);
// Console.WriteLine("Произведение чисел = " + multi);

// 2 вариант решения:
// string str;
// int a, b, c;
// Console.WriteLine("Введите первое число:_");
// str = Console.ReadLine();
// a = Convert.ToInt32(str);
// Console.WriteLine("Введите второе число:_");
// str = Console.ReadLine();
// b = Convert.ToInt32(str);
// Console.WriteLine("Введите третье число:_");
// str = Console.ReadLine();
// c = Convert.ToInt32(str);
// int summ = a+b+c;
// int multi = a*b*c;
// Console.WriteLine("Сумма чисел = " + summ);
// Console.WriteLine("Произведение чисел = " + multi);

// 3 вариант решения:

// double firstValue, SecondValue, thirdValue;

// Console.WriteLine("Введите первое число:");

// firstValue = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число:");

// SecondValue = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число:");

// thirdValue = double.Parse(Console.ReadLine());

// double summResult = firstValue+SecondValue+thirdValue;
// double multiResult = firstValue*SecondValue*thirdValue;

// Console.WriteLine("Сумма чисел = " + summResult);
// Console.WriteLine("Произведение чисел = " + multiResult);

// Задача 3. Напишите простой конвертер валют.

// double UsdToRub = 75.46;
// double UsdToBad = 35.59;

// System.Console.WriteLine("ВВведите сумму в USD:");

// double USD;
// USD = double.Parse(Console.ReadLine());

// System.Console.WriteLine("Сумма в рублях = " + UsdToRub * USD);
// System.Console.WriteLine("Сумма в бадах = " + UsdToBad * USD);


