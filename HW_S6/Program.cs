//___________МЕТОДЫ__________

       //K N-41
       
        int[] GetArray_41_1(int size)                                       
        {                                                                       

            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] =int.Parse(Console.ReadLine()!);                
            }
            return result;
        }

        int count(int[] array,int size)
        {
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] > 0) result = result +1;
            }
            return result;
        }


            string Coordinate(double k1, double b1, double k2, double b2)
            {
                    double x = (b2-b1)/(k1-k2);
                    
                    double y = k1*x + b1;
                    string result = ($"({x:f2}; {y:f2})");
                    return result;
            }


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

                    // Console.Write("Vvedite dlinu massiva: ");
                    // int size = int.Parse(Console.ReadLine()!);
                    // Console.WriteLine("Vvedite chisla massiva: ");
                    // int[] array = GetArray_41_1(size);
                    // int otvet = count(array, size);
                    // Console.WriteLine($"V massive {otvet} chisel bolshe 0");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями k1 * x + b1 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

                    // Console.Write("Vvedite b1: ");
                    // double b1 = double.Parse(Console.ReadLine()!);
                    // Console.Write("Vvedite k1: ");
                    // double k1 = double.Parse(Console.ReadLine()!);
                    // Console.Write("Vvedite b2: ");
                    // double b2 = double.Parse(Console.ReadLine()!);
                    // Console.Write("Vvedite k2: ");
                    // double k2 = double.Parse(Console.ReadLine()!);
                    // string otvet = Coordinate(k1, b1, k2, b2);
                    // Console.Write($"Koordinati tochki peresecheniya pryamih : {otvet}");


// Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа
//  Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
// (Следующее число складывается из двух предыдущих)

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8