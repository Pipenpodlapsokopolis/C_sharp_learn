// -------------------------------------------------------------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ-------------------------------------------------------------------

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

        // int[] GetArray(int size){
        // int[] result = new int[size];
        // for(int i = 0; i < size; i++){
        // result[i] = new Random().Next(99, 1000);
        // }
        // return result;
        // }

        // Console.Write("Vvedite razmer massiva: ");
        // int size = int.Parse(Console.ReadLine()!);
        
        // int[] array = GetArray(size);
        // Console.WriteLine($"[{String.Join(", ", array)}]"); 
        // int count = 0;
        // for (int i = 0; i < size; i++)
        // {
        //     if (array[i]%2 == 0)
        //     {
        //      count++;   
        //     }
        // }
        // Console.WriteLine ($"V massive {count} chetnih chisel");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

                // int[] GetArray(int size){
                // int[] result = new int[size];
                // for(int i = 0; i < size; i++){
                // result[i] = new Random().Next(99, 1000);
                // }
                // return result;
                // }
                
                // Console.Write("Vvedite razmer massiva: ");
                // int size = int.Parse(Console.ReadLine()!);
                
                // int[] array = GetArray(size);
                // Console.WriteLine($"[{String.Join(", ", array)}]"); 
                
                // int sum = 0;
                // for (int i = 0; i < size; i++)
                // {
                //     if (i%2 != 0){
                //         sum += array[i];
                //     }
                // }

                // Console.WriteLine ($"Cуммa элементов, стоящих на нечётных ИНДЕКСАХ = {sum}");

              

// Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**


                int[] GetArray(int size){
                int[] result = new int[size];
                for(int i = 0; i < size; i++){
                result[i] = new Random().Next(9, 100);
                }
                return result;
                }
                
                Console.Write("Vvedite razmer massiva: ");
                int size = int.Parse(Console.ReadLine()!);
                
                int[] array = GetArray(size);
                Console.WriteLine($"[{String.Join(", ", array)}]"); 
                                    int max = 0;
                    int min = array[1];
                    int chenge = 0;
                    for (int i = 0; i < size; i++)
                    {
                        if (array[i]>max){
                            max = array[i];
                        }
                        if (array[i]<min){
                            min = array[i];
                        }
                    }
                chenge = max -min;
                Console.WriteLine($"Pазницa между максимальным и минимальным элементов массива: {chenge}");
