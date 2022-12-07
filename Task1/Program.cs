Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int numberA = n / 10;
int result = numberA % 10;
Console.WriteLine($"Вторая цифра числа " + n + "  - " + result);
