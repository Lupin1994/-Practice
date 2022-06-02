// Функции
void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        array[i] = random.Next(min, max);
    return array;
}
bool Contains(int[] array, int value)
{
    foreach (var element in array)
        if (element == value)
            return true;
    return false;
}
int[] FirstArray = CreateArray(5, -10, 10);
Console.WriteLine("Your array: ");
PrintArray(FirstArray);
Console.Write("Enter value to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(Contains(FirstArray,value) ? "Contains" : "Doesn't contains"); // тернарный оператор
// int max = First> second ? First : second  // тоже тернарный оператор Сначала пишется условие ? если тру, то ферст если элсе то секонд.
// if(Contains(FirstArray,value))
//     Console.WriteLine("Contains");
// else
//     Console.WriteLine("Does not contains");