// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//  Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)    2, 4 -> 16

int inputdata(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int CalculetePoiw (int A, int B)
{
    int BaseNumber = A;
    for (int i = 1; i < B; i++ )
    {
        A *= BaseNumber;
    }
    return A;
}
int A = inputdata("Введите число A");
int B = inputdata("Введите число B");
int result = CalculetePoiw(A,B);
Console.WriteLine(result);