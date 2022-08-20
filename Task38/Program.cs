//Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 


Console.WriteLine("Введите количество элементов массива: ");
int elementCount = Convert.ToInt32(Console.ReadLine());
double[] array = new double[elementCount];
for (int i = 0; i < array.Length; i++)
{ 
    Console.WriteLine($"Введите элемент массива под индексом {i}:  ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join("; ", array) + ']');
double max = double.MinValue;
double min = double.MaxValue;
for (int i = 0; i < array.Length; i++)
{
    if(max < array[i])  
    {
        max = array[i];
    }
    if(min > array[i])
    {
        min=array[i];
    }  
}   
double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами массива:  " + diff);   