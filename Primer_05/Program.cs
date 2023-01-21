// Primer_05
// Написать программу вычисления произведения чисел от 1 до N
int Num1 = 0;
int Num2 = 1;
Console.Write("Введите число: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Num1; i++)
{
    Num2=Num2*i;
}
Console.WriteLine("Произведение чисел от 1 до "+ Num1 +" -> "+Num2);
