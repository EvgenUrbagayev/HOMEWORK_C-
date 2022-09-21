using static System.Console;

Clear();
WriteLine("Введите число:  ");
int num = Convert.ToInt32(ReadLine());
int num1 = Convert.ToInt32(ReadLine());
int num2 = Convert.ToInt32(ReadLine());

if(num > num1)
{
    if(num > num2)
    {
        WriteLine($"Максимальное число это {num}");
    }
    else
    {
        WriteLine($"Максимальное число это {num2}");
    }
}
else
{
    if(num1 > num2)
{
    WriteLine($"Максимальное число это {num1}");
}
    else
    {
        WriteLine($"Максимальное число это {num2}");
    }
}
