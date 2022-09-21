using static System.Console;

Clear();
WriteLine("Введите число:  ");
int num = Convert.ToInt32(ReadLine());
int num1 = Convert.ToInt32(ReadLine());
if(num > num1)
{
    WriteLine($"{num} больше {num1}");
}
else
{
    WriteLine($"{num1} больше {num}");
}