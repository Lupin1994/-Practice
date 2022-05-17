// //Задать массив из 8 элементов и вывести их на экран
// Console.WriteLine("Введите 8 элементов:");
// int [] array = new int[8];
// for(int i=1;i<=8;i++)
// {
//     Console.Write($"Введите элемент номер {i}; \n");
//     array[i-1] = int.Parse(Console.ReadLine()??"");

// }
// Console.WriteLine();
// PrintArray(array);
// //.....................Функция вывода массива на экран.....................
// void PrintArray(int[]array)
// {
//     for(int i = 0;i< array.Length;i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
// }

//......................2 Вариант упрощенный................................

// int[] array = { 1, 23, 534, 7, 878, 45, 3, 9 };
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} , ");
// }

//...........................3 Вариант с foreach...........................
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива:");
int arrSize = int.Parse(Console.ReadLine()??"0");
int[] array= new int[arrSize];
for(int i=0; i<arrSize;i++)
{
    array[i]= new Random().Next(0,100);

}    
int count = 1;
foreach (int k in array) //  для переборки массива foreach может только считывать данные,но присваивать не умеет
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}