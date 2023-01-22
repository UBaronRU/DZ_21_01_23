//## Primer_10
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] array = new int[123];
int Len = 0;
int Kol_c = 0;

Len = array.Length;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().Next(1,1000);
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
for (int i = 0; i < Len; i++)
{
        if (array[i] >= 10 && array[i] <= 99)
        {
        Kol_c = Kol_c +1;
        Console.WriteLine("Элемент массива №" + i + " найден  -> "+array[i]+" Кол-во  уже "+Kol_c);
        }
}
Console.WriteLine("Итого найдено количество элементов из отрезка [10,99]  -> "+Kol_c);
