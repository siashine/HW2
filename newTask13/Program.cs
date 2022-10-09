// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int thirdNum = 0;

if (num < 100)
{
Console.WriteLine($"Третьего числа не обнаружено");
return;
}

else 
if (num > 100)
{
  while(num>1000)
  {
    num = num / 10;
  }
  thirdNum = num % 10;
}
Console.WriteLine($"Третья цифра числа {num} - {thirdNum}");