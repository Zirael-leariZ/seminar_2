// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int num = new Random().Next(1, 8);

Console.WriteLine("Provide any number from 1 to 7: ");
int day = int.Parse(Console.ReadLine());

    if (day == 1)
    {
        Console.WriteLine("Monday");
    }
    else if (day == 2)
    {
        Console.WriteLine("Tuesday");
    } 
    else if (day == 3)
    {
        Console.WriteLine("Wednesday");
    }
    else if (day == 4)
    {
        Console.WriteLine("Thursday");
    }
    else if (day == 5)
    {
        Console.WriteLine("Friday");
    }
    else if (day == 6)
    {
        Console.WriteLine("Saturday");
    }
    else if (day == 7)
    {
        Console.WriteLine("Sunday");
    }
    else 
    {
        Console.WriteLine("No such a day");
    }



if (day >=6 && day <= 7)
{
    Console.WriteLine("Is a weekend: Yes");
}
else
{
    Console.WriteLine("Is a weekend: No");
}

