// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int num3 = 0;
string num = Console.ReadLine();

if (num.Length >= 3) // here we have strings, not a value that's why it works
{
    int num_num = Convert.ToInt32(num);
    if (num_num > 100000)
    {
        Console.Write ("choose the shorter number");
    }
    if (num_num > 10000)
    {
        num3 = num_num / 100 % 10 ;
        Console.Write($"The third digit is {num3}");
    }
    else if (num_num > 1000)
    {
        num3 = num_num / 10 % 10;
        Console.Write($"The third digit is {num3}");
    }
    else if (num_num > 100)
    {
        num3 = num_num % 10;
        Console.Write($"The third digit is {num3}");
    }

    }

else 
{
    Console.WriteLine($"{num} hasn't the third digit");
}

