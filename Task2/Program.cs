// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] CreateArray (int n, int m)
{
    return new int [n, m];
}

void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

void ArrayMinRow (int [,] array)
{
  int RowIndex = 0;
  int MinSum = 0;
  int TempSum = 0;
  int TempSum2 = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    TempSum2 = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        TempSum2 = TempSum2 + array[i, j];
    }
        if (TempSum2 < TempSum)
        {
            MinSum = TempSum2;
            RowIndex = i;
        } 
        else
        {
            MinSum = TempSum;
        }
       TempSum = TempSum2;
  }  Console.WriteLine($"{RowIndex+1} строка является строкой с минимальной суммой: {MinSum}"); // пользовательский вид с 1
     
} 


Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArray(row,column);
FillArray(arr);
PrintArray(arr);
ArrayMinRow(arr);



