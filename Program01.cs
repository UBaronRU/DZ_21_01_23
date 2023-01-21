//Найти кубы чисел от 1 до N
int Num1 = 0;
int Num2 = 0;
Console.Write("Введите число: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Num1; i++)
{
    Num2=i*i*i;
    Console.WriteLine("Куб числа "+ i +" -> "+Num2);
}