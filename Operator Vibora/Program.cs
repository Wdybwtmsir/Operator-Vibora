using System;

Console.Write("Введите день рождения (): ");
int d = int.Parse(Console.ReadLine());

Console.Write("Введите месяц рождения (): ");
int n = int.Parse(Console.ReadLine());

string zodiac = "";

if (n == 3 && d >= 22 || n == 4 && d <= 21)
    zodiac = "Овен";
else if (n == 4 && d >= 22 || n == 5 && d <= 21)
    zodiac = "Телец";
else if (n == 5 && d >= 22 || n == 6 && d <= 21)
    zodiac = "Близнецы";
else if (n == 6 && d >= 22 || n == 7 && d <= 21)
    zodiac = "Рак";
else if (n == 7 && d >= 22 || n == 8 && d <= 21)
    zodiac = "Лев";
else if (n == 8 && d >= 22 || n == 9 && d <= 21)
    zodiac = "Дева";
else if (n == 9 && d >= 22 || n == 10 && d <= 21)
    zodiac = "Весы";
else if (n == 10 && d >= 22 || n == 11 && d <= 21)
    zodiac = "Скорпион";
else if (n == 11 && d >= 22 || n == 12 && d <= 21)
    zodiac = "Стрелец";
else if (n == 12 && d >= 22 || n == 1 && d <= 21)
    zodiac = "Козерог";
else if (n == 1 && d >= 22 || n == 2 && d <= 21)
    zodiac = "Водолей";
else if (n == 2 && d >= 22 || n == 3 && d <= 21)
    zodiac = "Рыбы";
Console.WriteLine($"ну наконец то Андрей Валентинович я это сделал ваш знак зодиака: {zodiac}");