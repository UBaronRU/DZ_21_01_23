//## Primer_13
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] array = new double[new Random().Next(2,10)];
int Len = 0;
double Kol_max = 0;
double Kol_min = 0;
double Delta = 0;
Len = array.Length;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().NextDouble()*125;
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
Kol_max = array[0];
Kol_min = array[0];
for (int i = 0; i < Len; i++)
{
 if (array[i] > Kol_max)
 {
    Kol_max = array[i];
 }     
 if (array[i] < Kol_min)
 {
    Kol_min = array[i];
 }     
}
Delta = Kol_max - Kol_min;
Console.WriteLine("Разница между максимальным значением " + Kol_max + " и минимальным  "+ Kol_min +" -> "+Delta);