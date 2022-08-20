// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int [] array = new int[10];
Random rand = new Random(); 
int i = 0;
   for (i = 0; i < array.Length; i++)
   {  
        array[i] = rand.Next(1, 11);
   }
Console.WriteLine('[' + string.Join(",", array) + ']');

int sumOdd = 0;
for (i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
       sumOdd = sumOdd + array[i];
    }
}    
Console.WriteLine("Сумма чисел на нечётных позициях в массиве: " +  sumOdd);