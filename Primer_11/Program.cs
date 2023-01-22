// ## Primer_11
// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = new int[new Random().Next(1,100)];
int Len = 0;
int Kol_c = 0;
Len = array.Length;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
for (int i = 0; i < Len; i++)
{
        if (i%2 != 0)
        {
        Kol_c = Kol_c + array[i];
        Console.WriteLine("Элемент массива №" + i + " найден  -> "+array[i]+" Сумма уже  уже "+Kol_c);
        }
}
Console.WriteLine("Итого сумма чисел одномерного массива стоящих на нечетной позиции "+Kol_c);
