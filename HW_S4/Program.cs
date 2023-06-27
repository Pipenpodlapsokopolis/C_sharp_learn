// ---------------------------------------ВСЕ РЕШАТЬ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------

    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
    // число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16



                // int Function(int A, int B){
                //     int c = 1;
                //     for (int i = 1; i <= B; i++)
                //     {
                //         c = c * A;
                //     }
                //     return c;
                // }
                // Console.Write("Bведите число A: ");
                // int a = int.Parse(Console.ReadLine()!);
                // Console.Write("Bведите число B: ");
                // int b = int.Parse(Console.ReadLine()!);

                // Console.WriteLine($"Cislo {a} v stepeni {b} ravno {Function(a, b)}");

    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12

                    // int Function(int A){
                    //     int B = 0;
                    //     while (A!=0){
                    //         B = B + (A % 10);
                    //         A = A / 10;
                    //     }
                    //     return B;
                    // }

                    // Console.Write("Bведите число A: ");
                    // int a = int.Parse(Console.ReadLine()!);
                    // Console.WriteLine($"Cуммa цифр в числе {a} ravna {Function(a)}");


    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
    // и выводит их на экран. (можно указать любой промежуток)
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]

     
                    // int[] FunctionArray(int A){
                    //     int[] result = new int[A];
                    //     for (int i = 0; i < A; i++)
                    //     {
                    //         result[i] = new Random().Next(0, 666);            
                    //     }
                    //     return result;
                    // }
                    
                    // int[] array = FunctionArray(8);
                    // Console.WriteLine($"[{String.Join(", ",array)}]");