// Задача 52. Задайте двумерный массив из 
//целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца:
// 4,6; 5,6; 3,6; 3.



int[,] array = GetArray();
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray1(ArithmeticMean(array));



int[,] GetArray()
{
    int[,] result = new int[4, 3];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0,10);
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

double[] ArithmeticMean(int[,] newArray)
{
    double[] result = new double[newArray.GetLength(0)];

    for (int k = 0; k < newArray.GetLength(1); k++)
    {
    for(int i = 0; i< newArray.GetLength(0); i++)
    
    
               
        {
               
                
                
                     result[k] =result[k] + Convert.ToDouble(newArray[i,k]);
                
               
               }
               result[k] = result[k]/(newArray.GetLength(0)); 
               
    }
    
    return result;
}

void PrintArray1(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
                    Console.Write($" {Math.Round(inArray[i], 2)} ");
    }
    Console.WriteLine();
}
