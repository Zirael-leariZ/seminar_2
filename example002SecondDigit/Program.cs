// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(int.MinValue, int.MaxValue);
string num_str = num.ToString();

if (num_str.Length >= 3)
{
    char num3_char = num_str[2];
    int num3 = int.Parse(num3_char.ToString());  
    Console.WriteLine($"{num} and {num3}");
}
else 
{
    Console.WriteLine($"{num} hasn't the third digit");
}


