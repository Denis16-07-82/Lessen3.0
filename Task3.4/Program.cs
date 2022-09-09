// Задача 1

// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Не использовать строки!

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int Prompt(string messeg)//Функция ввода числа
{
    System.Console.WriteLine(messeg);
    string valueA = System.Console.ReadLine() ?? "0";
    int valueB = int.Parse(valueA);
    return valueB;
}
int Inversion(int value)
{
    value = Math.Abs(value);
    int valueA = 0;
    while (value > 0)
    {
        valueA = (valueA * 10 + value % 10);
        value = value / 10;
    }
    return valueA;
}
int value1 = Prompt("Введите число : ");
int value2 = Inversion(value1);
if (Math.Abs(value1) == value2)
{
    System.Console.WriteLine($"Число {value1} является полиандромом");
}
else
{
    System.Console.WriteLine($"Число {value2} не является полиандромом");
}