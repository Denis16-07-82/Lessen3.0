// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double[] Prompt(string messeg)
{
    System.Console.WriteLine(messeg);
    double[] Coord = new double[3];
    for (int i = 0; i < 3; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-ю координату точки : ");
        string coord = Console.ReadLine() ?? "0";
        Coord[i] = double.Parse(coord);
    }
    return Coord;
}
double distancePoints(double[] arrayA, double[] arrayB)
{
    double count = 0;
    for (int i = 0; i < 3; i++)
    {
        count += Math.Pow((arrayA[i] - arrayB[i]), 2);
    }
    return Math.Sqrt(count);
}
double[] arrayA1 = Prompt("Введите три координаты точки A1.");
double[] arrayA2 = Prompt("Введите три координаты точки A2.");
System.Console.WriteLine($"Растояние между точками A1 и A2 равно {distancePoints(arrayA1, arrayA2):f4}");