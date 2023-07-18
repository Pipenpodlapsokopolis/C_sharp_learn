// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

                            // int [,] MaxToMin(int[,] arr){
                            //     for (int m = 0; m < arr.GetLength(1); m++)
                            //     {
                            //         int[] result = new int[arr.GetLength(0)];
                            //         int max1 =arr[m,0];
                                
                            //     for (int i = 0; i < result.GetLength(0); i++)
                            //     {
                            //         for (int j = 0; j < arr.GetLength(0); j++)
                            //         {
                            //             if (arr[m,j]>max1) max1 = arr[m,j];
                            //         }
                            //         result[i] = max1;
                            //         for (int f = 0; f < arr.GetLength(0); f++)
                            //         {
                            //             if (arr[m,f]== max1) {
                            //                 arr[m,f] = -1;
                            //                 max1 = -1;
                            //             }
                            //         }
                            //         max1 =0;
                            //     }
                            //     for (int i = 0; i < arr.GetLength(0); i++)
                            //     {
                            //     arr[m,i] = result [i];  
                            //     Console.Write($"|{result[i]}|  ");
                            //     }
                            //     Console.WriteLine(" ");
                            //     }
                            //     return arr;
                            // }

                            // int[,] Getarray(int[,]result){
                            //     for (int i = 0; i < result.GetLength(0); i++)
                            //     {
                            //         for (int j = 0; j < result.GetLength(1); j++)
                            //         {   
                            //             result[i, j] = new Random().Next(0, 10);
                            //             Console.Write($"|{result[i, j]}|  ");
                            //         }
                            //         Console.WriteLine();
                            //     }
                            //     return result;
                            // }
                            // Console.Write("Vvedite kolichestvo strok massiva: ");
                            // int row = int.Parse(Console.ReadLine()!);
                            // Console.Write("Vvedite kolichestvo stolbcov massiva: ");
                            // int column = int.Parse(Console.ReadLine()!);
                            // int[,] array = new int [row, column];
                            // Getarray(array);
                            // Console.WriteLine(" ");
                            // MaxToMin(array);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

                        // int[,,] GetArray(int[,,] array)
                        // {
                        //     int[] repitor = new int [array.Length];
                        //     int i = 0;
                        //     for (int x = 0; x < array.GetLength(0); x++)
                        //     {
                        //     for (int y = 0; y < array.GetLength(1); y++)
                        //     {
                        //         for (int z = 0; z < array.GetLength(2); z++)
                        //         {
                        //             array [x,y,z] = new Random().Next(9, 100);
                        //             repitor[i] = array [x,y,z];
                        //             for (int j = 0; j < i; j++)
                        //             {
                        //                 if (array [x,y,z] == repitor[j]) array [x,y,z]=new Random().Next(9, 100);
                        //             }
                        //             Console.Write($"{array [x,y,z]}({x},{y},{z}) ");
                        //             i++;
                        //         }
                        //         Console.WriteLine(" ");
                        //     }   
                        //     }
                        //     return array;
                        // }
                        // int[,,]array = new int [2,2,2];
                        // GetArray(array);

