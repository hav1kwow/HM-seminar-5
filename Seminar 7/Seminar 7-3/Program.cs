// Задача 51: Задайте двумерный массив. Найдите сумму
//  элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] array = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Console.WriteLine();

int SumElements(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                result = result + array[i, j];
            }
        }      
    }
    return result;
}
int summa = SumElements(array);
Console.WriteLine("Cумма элементов, находящихся на главной диагонали равна: " + summa);



