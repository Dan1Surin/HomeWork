// показать все четные числа от 1 до введенного числа
Console.Write(" Your number = ");
int yourNumber = Convert.ToInt32(Console.ReadLine());

while (yourNumber > 1)
{
    if (yourNumber % 2 == 0)
    {
        Console.WriteLine(yourNumber);
    }
yourNumber=yourNumber-1;
}