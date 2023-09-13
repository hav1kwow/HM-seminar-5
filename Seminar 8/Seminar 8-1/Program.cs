// /Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int[,] array = new int[4, 4];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }

}

void EdditMassiv(int[,] array)
{
    int temp = 0; 
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
       temp = array[0, i];
        array [0, i] = array[array.GetLength(0)- 1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }

}
FillArray(array);

EdditMassiv(array);
Console.WriteLine("");
PrintArray( array);