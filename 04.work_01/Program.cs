int[] array = { 2, 3, 8, 9, 4, 1, 6, 5 };
void change(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = 0 - array[i];
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j], }");
    }
}
change(array);
PrintArray(array);

// void change1(int[] array)
// {
//     int count = array.Length;
//     for(int x = 0; x < count; x++)
//     {
//         for(int z = count-1; z > x; z++)
//         {
//             int tmp = array[x];
//             array[x] = array[z];
//             array[z] = tmp;
//         }    
//     }
// }
// change1(array);
// PrintArray(array);

// void change1(int[] array)
// {
//     int count = array.Length;
//     for (int z = 0; z < (count / 2); z++)
//     {
//         int tmp = array[z];
//         array[z] = array[((count - 1) - z)];
//         array[((count - 1) - z)] = tmp;
//     }
// }
// change1(array);
// PrintArray(array);