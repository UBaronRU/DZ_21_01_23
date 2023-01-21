// ## Primer_06
// Показать кубы чисел, заканчивающихся на четную цифру
// 
int Num1 = 0;
int Num2 = 0;
int Num3 = 0;
Console.Write("Сколько чисел нужно гинерировать?: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i < Num1; i++)
{
    Num2=new Random().Next(0,21);
    Num3=Num2*Num2*Num2;
    if (Num3%2 == 0)
    {
    Console.WriteLine("Куб числа "+ Num2 +" -> "+Num3);
    }
    else
    {
   Console.WriteLine("Число "+ Num2 +" нечетное ");
    }
}