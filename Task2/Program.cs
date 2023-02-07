//  Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11    82 -> 10    9012 -> 12

int inputdata(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int findsum(int number)
{
    int result = 0;
    int left;
    while(number > 0)
    {
        left = number % 10;
        number = number / 10;   
        result = result + left;
    }
    return result;
}
int number = inputdata("Введите число");
Console.WriteLine(findsum(number) );
