// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите номер дня недели: ");
int weekend = int.Parse(Console.ReadLine());
if (weekend >= 8)
{
  Console.WriteLine("Ты что-то путаешь, столько дней в неделе нет.");
  return;
}
if (weekend > 5)
{
  Console.WriteLine($"День недели под номером {weekend} - выходной. Отдыхай.");
}

else{
  Console.WriteLine($"День недели под номером {weekend} - рабочий. Так что иди работай!");
}