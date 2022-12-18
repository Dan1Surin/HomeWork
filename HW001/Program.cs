// наибольшее из двух чисел
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"max = {a}"); 
}
else
{
    Console.Write($"max = {b}"); 
}