Console.WriteLine("Write your number:");
int number = int.Parse(Console.ReadLine());
int Palindrom = number;
int rev = 0;
int i = 0;
int dig = 0;
while (i < 5)
{
    dig = number % 10;
    rev = rev * 10 + dig;
    i++;
    number = number / 10;
}
Console.WriteLine(rev);
if (rev == Palindrom)
{
    Console.WriteLine("Your number is Palindrom:");
}
else
{
    Console.WriteLine("Your number is not Palindrom:");
}


// //          Через сравнение чисел
// Console.WriteLine("Write your number:");
// int number = int.Parse(Console.ReadLine());
// if (number/10000 == number%10 && number/1000%10 == number/10%10) //сравнение 1 числа с 5 && 2 с 4 ,  и третье не сравнивается. Если они равны,то
// {
//     Console.WriteLine("Your number is Palindrom:");
// }
// else
// {
//     Console.WriteLine("Your number is not Palindrom:");
// }
// 
//               Не через цикл
// Console.WriteLine("Write your number:");
// int number = int.Parse(Console.ReadLine());
// int digit5 = number % 10;
// int digit4 = number / 10 % 10;
// int digit3 = number / 100 % 10;
// int digit2 = number / 1000 % 10;
// int digit1 = number / 10000 % 10;
// int newnumber = digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
// Console.WriteLine(newnumber);
// if(number == newnumber)
// {
//     Console.WriteLine("Your number is Palindrom:");
// }
// else
// {
//     Console.WriteLine("Your number is not Palindrom:");
// }

