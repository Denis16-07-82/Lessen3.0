// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    string value = System.Console.ReadLine() ?? "0";
    int valueA = int.Parse(value);
    return valueA;
}
int[] fankCub(int value)
{
    int[] array1 = new int[1];
    if (value == 0)
    {
        array1[0] = 0;
    }
    int[] array = new int[Math.Abs(value)];
    if (value > 0)
    {
        double count = 1;
        for (int i = 0; i < value; i++)
        {
            array[i] = (int)Math.Pow(count, 3);
            count++;
        }
    }
    else
    {
        double count = -1;
        for (int i = 0; i < Math.Abs(value); i++)
        {
            array[i] = (int)Math.Pow(count, 3);
            count--;
        }
    }
    if (value == 0)
    {
        return array1;
    }
    else
    {
        return array;
    }


}
void concLusion(int[] array, int value)
{
    System.Console.Write($"Таблица кубов для числа {value} ->");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]},");
    }
    System.Console.WriteLine();
}
int valueB = Prompt("Введите число :");
concLusion(fankCub(valueB), valueB);