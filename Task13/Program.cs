// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
string numText = Convert.ToString(num);

if (numText.Length > 2)
{
Console.WriteLine($"Третья цифра числа {num} - {numText[2]}");
}
else {
  Console.WriteLine($"Третьего числа не обнаружено");
}