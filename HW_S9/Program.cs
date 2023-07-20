// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


                // void FromTo (int N){
                // Console.Write($"{N}  ");
                //     if (N>1) FromTo(N-1);
                // }


                // Console.Write("Vvedite chislo: ");
                // int N = int.Parse(Console.ReadLine()!);

                // FromTo(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


                    // int Sum(int M,int N, int result){
                    //     if (M<=N){
                    //         result = result + M;
                    //         return Sum(M+1, N, result);;
                    //     }
                    //     return result;
                    // }

                    // Console.Write("Vvedite menshee chislo: ");
                    // int M = int.Parse(Console.ReadLine()!);
                    // Console.Write("Vvedite bolshee chislo: ");
                    // int N = int.Parse(Console.ReadLine()!);
                    // int result = 0;
                    // result = Sum(M, N, result);
                    // Console.WriteLine($"Cуммa натуральных элементов в промежутке от {M} до {N} = {result}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29