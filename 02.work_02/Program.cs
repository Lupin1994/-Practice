Console.WriteLine("Write X:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Write Y:");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("First quarter");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("Second quarter");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Third quarter");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Fourth quarter");
}

// if (X > 0)
// {
//     if (Y > 0)
//     {
//         Console.WriteLine("First quarter");
//     }
//     else
//     {
//         Console.WriteLine("Fourth quarter");
//     }
// }
// else
// {
//     if (Y > 0)
//     {
//         Console.WriteLine("Second quarter");
//     }
//     else
//     {
//         Console.WriteLine("Third quarter");
//     }
// }