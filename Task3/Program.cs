// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] kreitarray(int size = 8)
{
    int[]array = new int [size];
    Random Nums = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Nums.Next(0,20);
    } 
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
}
int [] array = kreitarray();
PrintArray(array);