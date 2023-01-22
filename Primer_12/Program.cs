//## Primer_12
//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//

int [] array = new int[new Random().Next(2,10)];
int Len = 0;
int Kol_c = 0;
Len = array.Length;
int ne_chet = 0;
for (int i = 0; i < Len; i++)
{
    array[i] = new Random().Next(1,10);
    Console.WriteLine("Элемент массива №" + i + " из "+ Len +" -> "+array[i]);
}
Kol_c = Len /2;
Console.WriteLine( Len +" "+ Kol_c);

if (Kol_c*2 != Len) 
{
    Kol_c=Kol_c+1;
    ne_chet = 1;
}
else
{
    
}
Console.WriteLine(Kol_c);
int [] array_itog = new int[Kol_c];
for (int i = 0; i < Kol_c; i++)
{
    array_itog[i] = array[i] * array[Len-i-1];
}
// Убрать это условие если при нечетном количестве элементов в таблице среднее значение должно быть умножено само на себя.
if (ne_chet == 1)
{
    array_itog[Kol_c] = array_itog[Kol_c] / array[Kol_c];
}
for (int i = 0; i < Kol_c; i++)
{
     Console.WriteLine("Элемент массива №" + i + " из "+ Kol_c +" -> "+array_itog[i]);
}
 
