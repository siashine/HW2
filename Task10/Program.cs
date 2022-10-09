// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// нематематическое решение
// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());
// string numText = Convert.ToString (num);
// if (numText.Length < 3 | numText.Length > 3)
// {
//   Console.WriteLine($"Число {num} не соответствует заданному");
// }
// else
// {
//   Console.WriteLine($"Вторая цифра вашего числа {num} - {numText[1]}");
// }

// математическое решение

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int secondNumber = 0;
if (num < 100)
{
  Console.WriteLine($"Число {num} не соответствует заданному");
  return;
}
else
if (num > 1000)
{
  Console.WriteLine($"Число {num} не соответствует заданному");
}
else{
  Console.WriteLine($"Вторая цифра вашего числа {num} - {num / 10 % 10}");
}