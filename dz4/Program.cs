/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] a = new int[2, 2, 2];

int[] nums = new int[90];
for (int i = 0; i < 90; i++)
     nums[i] = i + 10;

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int l = 0; l < a.GetLength(2); l++)
        {
            int temp = new Random().Next(90);
            while (nums[temp] == 0)
                temp = new Random().Next(90);
            a[i, j, l] = nums[temp];
            nums[temp] = 0;
        }
    }
}

for (int i = 0; i < a.GetLength(0); i++)
     for (int j = 0; j < a.GetLength(1); j++)
     {
        for (int l = 0; l < a.GetLength(2); l++)
             Console.Write($"{a[i, j, l]} ({i},{j},{l}) ");
        Console.WriteLine();
     }
