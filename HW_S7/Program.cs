// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


                // double[,] GetArray (int rows, int columns)
                // {
                //     double[,] result = new double[rows, columns];
                //     for (int i = 0; i < result.GetLength(0); i++)
                //     {
                //         for (int j = 0; j < result.GetLength(1); j++)
                //         {   
                //             double x = new Random().Next(-10, 10);
                //             result[i, j] = new Random().NextDouble() + x;
                //             Console.Write($"|{result[i, j]:f1}| ");
                //         }
                //         Console.WriteLine();
                //     }
                //     return result;
                // }
                // Console.Write("Vvedite kolichestvo strok massiva: ");
                // int row = int.Parse(Console.ReadLine()!);
                // Console.Write("Vvedite kolichestvo stolbcov massiva: ");
                // int column = int.Parse(Console.ReadLine()!);
                // double[,] array = GetArray(row, column);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует


                // int[,] Getarray(int[,]result){
                //     for (int i = 0; i < result.GetLength(0); i++)
                //     {
                //         for (int j = 0; j < result.GetLength(1); j++)
                //         {   
                //             result[i, j] = new Random().Next(-10, 10);
                //             Console.Write($"|{result[i, j]}| ");
                //         }
                //         Console.WriteLine();
                //     }
                //     return result;
                // }

                // string Find (int row, int column, int[,] array)
                // {   
                //     string result = String.Empty;
                //     if (row > array.GetLength(0) | row < 0)
                //     result = ("такого элемента не существует");
                //     else if (column > array.GetLength(1) | column < 0)
                //     result = ("такого элемента не существует");
                //     else {
                //         result = ($"iskomoe chislo: {array[row-1, column-1]}");
                //     }
                //     return result;
                // }

                // int[,] array = new int [10, 10];
                // Getarray(array);
                // Console.WriteLine("Vvedite nuzhnuyu stroku massiva: ");
                // int row = int.Parse(Console.ReadLine()!);
                // Console.WriteLine("Vvedite nuzhniy stolbec massiva: ");
                // int column = int.Parse(Console.ReadLine()!);
                // string x = Find(row, column, array);
                // Console.WriteLine($"{x}");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)

                int[,] Getarray(int[,]result){
                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {   
                            result[i, j] = new Random().Next(0, 10);
                            Console.Write($"|{result[i, j]}|  ");
                        }
                        Console.WriteLine();
                    }
                    return result;
                }

                double[] SrAr(int[,] array)
                {
                    double[] result =new double[array.GetLength(1)];
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        double x = 0;
                        for (int j = 0; j < array.GetLength(0); j++)
                        {
                            x = x + array[j, i];
                        }
                        result[i] = x / array.GetLength(0);
                    }
                    return result;
                }

                int[,] array = new int [2, 5]; /////razmer massiva
                Getarray(array);
                double[] otvet = SrAr(array);
                Console.WriteLine($"[{String.Join("; ", otvet)}]");