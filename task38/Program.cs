/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
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
           Console.Write(" ");
        }
    }
    Console.WriteLine("]");
}
int getMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
          if (array[i] < min)
                {
                    min = array[i];
                } 
            }
            return min;
}
int getMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
        {
          if (array[i] > max)
                {
                    max = array[i];
                } 
            }
            return max;
}
int getMaxMinDiference(int max, int min)
{
    int dif = max - min;
    return dif;
}
int[] Array = getGenerateArray(5,0,20);
printArr(Array);
int min = getMin(Array);
Console.WriteLine($"Минимальное число массива {min}");
int max = getMax(Array);
Console.WriteLine($"Максимальное число массива {max}");
int diference = getMaxMinDiference(max,min);
Console.WriteLine($"Разница между максимальным и минимальным числами в массиве равна {diference}");