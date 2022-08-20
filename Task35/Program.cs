//Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


int [] array = new int[123];
Random rand = new Random();
int i = 0;
for (i = 0; i < array.Length; i++)
{  
    array[i] = rand.Next(-10, 200);
}
Console.WriteLine('[' + string.Join(",", array) + ']');
int count = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        count = count + 1;
    }
}
Console.WriteLine("Количество элементов массива, значения которых лежат в диапазоне [10,99] = " + count);