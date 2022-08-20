// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
 
       
int[] array = new int[10];
int currentValue = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
       currentValue = currentValue + 1; 
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + currentValue);