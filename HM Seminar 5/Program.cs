// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
//  программу, которая покажет количество чётных чисел в массиве.



int[] numbers = new int[10];
int count = 0;
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine($"{count} из них чётные");