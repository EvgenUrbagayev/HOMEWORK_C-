using static System.Console;

Clear();
WriteLine("Введите число:  ");
int num = Convert.ToInt32(ReadLine());

if(num % 2 == 0)
{
    WriteLine($"{num} является четным числом");
}
else
{
    WriteLine($"{num} является нечетным числом");
}