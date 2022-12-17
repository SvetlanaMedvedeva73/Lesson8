/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива */
int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int n = 0; n < array.GetLength(0); n++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array[n, i];
        int j = i - 1;

        while (j >= 0 && array[n, j] > k)
        {
            array[n, j + 1] = array[n, j];
            array[n, j] = k;
            j--;
        }
    }
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         Console.Write($"{array[i, j]} ");
    }
     Console.WriteLine();
}
