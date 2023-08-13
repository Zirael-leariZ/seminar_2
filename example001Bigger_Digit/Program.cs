int num = new Random().Next(100, 1000);

int num1 = num / 100;
int num2 = num / 10 - num1*10;
int num3 = num % 10;

Console.WriteLine($"{num} and {num1} and {num3}");
