//## Primer_08
//Определить, присутствует ли в заданном массиве, некоторое число
int [] array = new int[new Random().Next(1,10)];
int Len = 0;
int Num1;
int Nachel = 0;
Len = array.Length;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().Next(1,90);
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
Console.Write("Какое число ищем ?: ");
Num1 = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < Len; i++)
{
        if (array[i] == Num1)
        {
        Console.WriteLine("Элемент массива №" + i + " совпал с введеным значением -> "+array[i]);
        Nachel = 1;
        }
}
if (Nachel == 0)
{
    Console.WriteLine("Значение в массиве не найдено");
}