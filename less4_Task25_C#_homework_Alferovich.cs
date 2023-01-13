// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Пожалуйста, введите число для возведения в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь введите степень для этого числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(num1,num2);
Console.WriteLine($"Результат возведения числа в натуральную степень: {result}.");