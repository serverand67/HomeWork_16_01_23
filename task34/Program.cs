/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] getGenerateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArr( int[] array )
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i  < array.Length -1)
        {
           Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int getCountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] array = getGenerateArray(10,100,999);
printArr(array);
int count = getCountPositive(array);
Console.WriteLine($"Сумма положительных чисел в массиве {array} равна {count}");

