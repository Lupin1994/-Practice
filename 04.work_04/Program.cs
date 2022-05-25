// // В указанном массиве вещественных чисел найдите разницу между макс и мин элементом

// Console.Write("Ведите количество элементов массива:");
// int arraySize = int.Parse(Console.ReadLine());
// int[] array = new int[arraySize];
// Random random = new Random();

// int max = int.MinValue;
// int min = int.MaxValue;

// for (int i = 0; i< arraySize;i++)
// {
//     array[i] = random.Next(-100,100);
// }
// for (int j = 0; j< arraySize;j++)
// {
//     if(array[j] > max) max = array[j];
//     if(array[j] < min) min = array[j];
// }
// Console.WriteLine($"Самое большое число в массиве равно{max}.\n Самое маленькое число в массиве равно{min}. \n Разница между мин и макс равно{max-min}");


// В массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().NextDouble()*10;
  Console.WriteLine($"{arr[i]} ");  
}
double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
  if(arr[i] < min) min = arr[i];
  if(arr[i] > max) max = arr[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница = {max-min}");

// // В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// Console.Clear();
// float [] arr = {3.5f, 4.2f,355,4,5555};
// float max = arr[1];
// float min = arr[0];
// for(int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if(arr[i]< min)
//     {
//         min = arr[i];
//     }
// }
// Console.WriteLine(max-min);

// // Найдите разницу между максимальным и минимальным элементом

// Console.Write("Введите размер массива: ");

// int Number = int.Parse(Console.ReadLine() ?? "0");
// double[] arr = new double[Number];

// for (int i = 0; i < Number; i++)
// {
//     arr[i] = new Random().NextDouble() * 10;
//     arr[i] = Math.Round(arr[i],2); //округление числа до второго знака
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine("");

// int min = 0;
// int max = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < arr[min]) min = i;
//     else if (arr[i] > arr[max]) max = i;

// }

// Console.WriteLine($"Разница между {arr[max]} и {arr[min]} = {arr[max] - arr[min]}");