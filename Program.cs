Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number / 10) % 10;
Console.Write($"Вторая цифра: {secondDigit}");