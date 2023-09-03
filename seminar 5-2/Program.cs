

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] array = new int[5];
int[] array2 = new int[10];

int[] FillArray(int[] array){
        for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9,10);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;   
}
int number = Convert.ToInt32(Console.ReadLine());

void YesNo(int[] array, int number){
     for (int i = 0; i < array.Length; i++){
        if (array[i] == number){
            Console.WriteLine("Да");
            
        }
        else Console.WriteLine("Нет");
        break;
     }
}
int[] newArray = FillArray(array);
YesNo(newArray, number);
int[] newArray2 = FillArray(array2);
YesNo(newArray2, number);













// FillArray(array);


// void FillArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(-9, 10 );
//         newArray[i] = array[i]*(-1);
//     }
//     System.Console.WriteLine(String.Join(" ", array));
//     System.Console.WriteLine(String.Join(" ", newArray));
// }