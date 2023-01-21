// Возведите число А в натуральную степень B используя цикл
// Найти сумму чисел от 1 до А
// Показать таблиц
int Num1 = 0;
int Num2 = 0;
int Num3 = 1;
Console.Write("Введите число для возведения в спепень:");
Num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение степени (натуральное число) для возведения в него числа  "+Num1+":");
Num2 = int.Parse(Console.ReadLine() ?? "0");
if (Num1 > 0)
{    
        for (int i = 1; i <= Num2; i++)
    {
    Num3=Num3*Num1;
    Console.WriteLine("Число "+ Num1 +" в степени "+ i +" -> "+ Num3);
    }
    Console.WriteLine("Итого: Число "+ Num1 +" в степени "+ Num2 +" -> "+ Num3);
}
else
{
    Console.WriteLine("Ошибка ввода значения степени");
}