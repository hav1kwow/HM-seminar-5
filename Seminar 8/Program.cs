int[,] array = new int[4, 4];

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


void ChangeArray(int[,] array)
{
   int temp = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array [0, i] = array[array.GetLength(0), i];
        array[array.GetLength(0), i] = temp;
    } 
   
}   


FillArray(array);
ChangeArray(array);

