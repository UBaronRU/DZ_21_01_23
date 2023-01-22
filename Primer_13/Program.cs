//## Primer_13
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] array = {-1.2,1.76,-8.0,9.5,12.14,-13.6,2.1,-5.1,12.5,-9.4};
int Len = 0;
double Kol_max = 0;
double Kol_min = 0;
double Delta = 0;
Len = array.Length;
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