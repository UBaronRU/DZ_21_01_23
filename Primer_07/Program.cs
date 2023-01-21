//## Primer_07
//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
//
int [] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1,10);
    if (array[i] < 6) 
    {array[i] = 0;}
    else
    {array[i] = 1;}
    Console.WriteLine("Элемент массива №" + i + " -> "+array[i]);
}