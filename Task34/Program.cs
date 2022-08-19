//int [] array = new int[10];
//int i = 0;
//    while (i < array.Length)
//    {  
//         array[i] = new Random().Next(100, 1000);
//         i++;
//    }
//Console.WriteLine(array);   
 
//int currentValue = 0;
//int Value = array[i];
//    if (Value % 2 == 0)
//    {
//        currentValue = currentValue + 1;     
//    }
//Console.WriteLine("Четных чисел в массиве: " + currentValue);    
       
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
Console.WriteLine("Количество четных чисел в массиве:" + currentValue);