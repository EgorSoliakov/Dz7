//Задача 50. Напишите программу, которая на 
//вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет


Console.Write("Введите позицию элемента по горизонтали: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию элемента по вертикали: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray();
PrintArray(array);
if(ElementSearch(array, rows, columns) == true) 
{
Console.Write($"[{rows},{columns}] -> ");
ElementPrint(array, rows, columns);
}
else Console.WriteLine($"[{rows},{columns}]-> такого числа в массиве нет");


int[,] GetArray()
{
    int[,] result = new int[5, 5];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0,100);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool ElementSearch(int[,] arr, int m, int n)
{
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (m == i && n == j)  return true;           
        }
    }
     return false;
}

void ElementPrint(int[,] arr, int m, int n)
{
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (m == i && n == j)   Console.Write($"{arr[i,j]}");
        }
    }
}