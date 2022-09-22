// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Console.WriteLine("Впишите количество строк:");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Впишите количество столбцов:");
//int n = Convert.ToInt32(Console.ReadLine());
//double[,] twoDimArray = new double[m, n];
//Random rnd = new Random(); 
//void PrintArray(double[,] matrix)
//{ for (int i = 0; i < m; i++)
// { for (int j = 0; j < n; j++)
// { Console.Write($"{matrix[i, j]} ");}
// Console.WriteLine();}}

//void FillArray(double[,] matrix)
//{ for (int i = 0; i < m; i++)
// { for (int j = 0; j < n; j++)
// { matrix[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
//FillArray(twoDimArray);
//Console.WriteLine();
//PrintArray(twoDimArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
//Console.WriteLine("Введите количество строк:");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов:");
//int n = Convert.ToInt32(Console.ReadLine());

//int[,] array = new int[m, n];
 
//for (int i = 0; i < array.GetLength(0); i++) 
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//        array [i, j] = Convert.ToInt32(new Random().Next(0,11));  
//}
 
//for (int i = 0; i < array.GetLength(0); i++) 
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//        Console.Write(array[i,j] + "\t  ");
//        Console.WriteLine();
//}
 
// Console.WriteLine("Введите позицию элемента");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>m && b>n)
// Console.WriteLine("такого числа нет");
// else
// {
// object c = array.GetValue(a,b);
// Console.WriteLine(c);
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,11));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}


for (int j = 0; j < array.GetLength(1); j++)

{
   int summa=0;
   double SredArifm=0;
   for (int i = 0; i < array.GetLength(0); i++) 
   summa=summa+array [i, j];
   SredArifm = (double) summa/m;
Console.WriteLine(SredArifm);
}





   





 