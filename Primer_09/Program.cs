//## Primer_09
//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
//
int [] array = new int[new Random().Next(1,100)];
int Len = 0;
int Kol_c = 0;
int Kol_n = 0;
Len = array.Length;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().Next(100,999);
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
for (int i = 0; i < Len; i++)
{
        if (array[i]%2 == 0)
        {
        Kol_c = Kol_c +1;
        Console.WriteLine("Элемент массива №" + i + " четный  -> "+array[i]+"Кол-во четных уже "+Kol_c);
        }
        else
        {
        Kol_n = Kol_n +1;
        Console.WriteLine("Элемент массива №" + i + " нечетный  -> "+array[i]+". Кол-во четных уже "+Kol_n);
        }
}
Console.WriteLine("Итого четных значений -> "+Kol_c+". А нечетных "+Kol_n);
