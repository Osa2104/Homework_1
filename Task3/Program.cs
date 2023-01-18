// Принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
   Console.Write($"{num} -> четное");
}
else
{
   Console.Write($"{num} -> нечетное");
}