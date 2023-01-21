//Найти сумму чисел от 1 до А
int Num1 = 0;
int Num2 = 0;
Console.Write("Введите число: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Num1; i++)
{
    Num2=Num2+i;
}
Console.WriteLine("Сумма чисел от 1 до "+ Num1 +" -> "+Num2);
// Вариант 2

Num2 = (( 1+ Num1)*Num1)/2;
Console.WriteLine("Сумма чисел от 1 до "+ Num1 +" -> "+Num2);