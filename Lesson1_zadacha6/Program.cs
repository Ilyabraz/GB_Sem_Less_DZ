// Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num % 2 == 1)
{
    Console.WriteLine("Число " + Num + " -> нет");
}
else
{
    Console.WriteLine("Число " + Num + " -> да");
}