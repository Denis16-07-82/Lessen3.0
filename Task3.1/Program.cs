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
int fanckLen(int value)//Функция для получения длины числа в символах
{
    int count = 0;
    while (value > 0)
    {
        value = (value - value % 10) / 10;
        count++;
    }
    return count;
}
int[] fanckArray(int valueA, int len)//Функция для получения из числа массива реверсивного заданному числу
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = valueA % 10;
        valueA = (valueA - valueA % 10) / 10;
    }
    return array;
}
void comparingArrays(int[] array, int value)//Функция сравнения двух массивов:заданного и реверсивного ему                                 
{
    int i = 0;
    while (i < (array.Length) / 2)
    {
        if (array[i] == array[array.Length - i - 1])
        {
            i++;
        }
        else
        {
            break;
        }
    }
    if (i < (array.Length) / 2 - 1)
    {
        System.Console.WriteLine($"Число {value} не является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {value}  является палиндромом");
    }
}
int value = Math.Abs(Prompt("Введите число : "));
//  int lenValue = fanckLen(value);длина числа в символах
//  int[] lenArray = fanckArray(value,lenValue);возвращает массив из цифр числа наоборот
comparingArrays(fanckArray(value, fanckLen(value)), value);