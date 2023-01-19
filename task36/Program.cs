/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int getSumOfNegativePosition(int[] array)
{
    int sum = 0;      
    for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            sum = sum + array[i];      
        }
        return sum;
}
int[] Array = getGenerateArray(5,0,20);
printArr(Array);
int sum = getSumOfNegativePosition(Array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях, в массиве, равна {sum}");
