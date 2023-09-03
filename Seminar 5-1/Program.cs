// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да





int[] array = new int[12];

int[] FillArray(int[] array)
{     
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        
    }
    Console.WriteLine(String.Join(" ", array));
    return array;

}

void Convert (int[] array){
    for (int i = 0; i < array.Length; i++){      
       array[i] = array[i]*-1;    
   
}
 Console.WriteLine(String.Join(" ", array));
    }
int[] newArray = FillArray(array);
Convert(newArray);

