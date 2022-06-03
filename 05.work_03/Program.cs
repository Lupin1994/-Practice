// Написать программу преобразования десятичного числа в двоичн
// .....................Не работает...........................
// Console.WriteLine("Number : ");
// int Num = int.Parse(Console.ReadLine() ?? "0");
// int tmpnumber = Num;
// int tmp = 0;
// int count = 0;
// void FillArray(int[] array)
// {
//     int tmp = 0;
//     int index = 0;
//     int length = array.Length;
//     while(index<length)
//     {
//         tmp = Num%2;
//         Num= Num/2;
//         array[index]=tmp;
//         index++;
//     }
// }
// void PrintArray(int[] col )
// {
//     int count = col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }
// while(tmpnumber>0)
// {
//     tmp = tmpnumber%2;
//     tmpnumber=tmpnumber/2;
//     count++;
// }
// int[] array = new int[count];
// FillArray(array);
// PrintArray(array.Reverse().ToArray());

// ..............My result................................
// Console.WriteLine("Write number: ");
// int Num = int.Parse(Console.ReadLine() ?? "0");
// int j = 0;
// int[] arr = new int[16];
// int res = 0;
// for (int i = 0; Num > 0; i++)
// {
//     res = Num % 2;
//     Num = Num / 2;
//     arr[i] = res;
//     Console.Write($"{arr[i]} ,");
//     j = i;
//     //Console.WriteLine();   
// }
// int count = 1;
// foreach(int k in arr)
// { 
//     Console.WriteLine($"{count} element array - {k}");
//     count++;
// }
// .............Через строку.......................
// Console.Write("Write number : ");
// int num = int.Parse(Console.ReadLine()??"0");
// string result = "";
// string RevResult = "";
// while (num>0)
// {
//     result =result+(num%2).ToString();
//     num = num/2;
// }
// int length=result.Length;
// for(int i = length -1; i>=0;i--)
// {
//     RevResult += result[i];

// }
// Console.WriteLine($"{RevResult}");
//.................Рабочий вариант.....................
Console.Write("Write number : ");
int Number = int.Parse(Console.ReadLine()??"0");
int Bit = Number%2;
int NewNumber = Bit;
Number = Number/2;
int i = 10;
while (Number>0)
{
    Bit = Number%2;
    Number = Number/2;
    NewNumber= NewNumber+Bit*i;
    i = i*10;
}
Console.WriteLine(NewNumber);

