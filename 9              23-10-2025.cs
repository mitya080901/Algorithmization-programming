//1.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6:");

//        int[] array = new int[20];

//        Console.WriteLine("Введите 20 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int evenCount = 0;
//        int oddCount = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                evenCount++;
//            }
//            else
//            {
//                oddCount++;
//            }
//        }

//        Console.WriteLine($"Количество четных элементов: {evenCount}");
//        Console.WriteLine($"Количество нечетных элементов: {oddCount}");

//        if (evenCount > oddCount)
//        {
//            Console.WriteLine("Четных элементов больше.");
//        }
//        else if (oddCount > evenCount)
//        {
//            Console.WriteLine("Нечетных элементов больше.");
//        }
//        else
//        {
//            Console.WriteLine("Количество четных и нечетных элементов равно.");
//        }

//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//        int testEvenCount = 0;
//        int testOddCount = 0;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");

//        foreach (int num in testArray)
//        {
//            if (num % 2 == 0) testEvenCount++;
//            else testOddCount++;
//        }

//        Console.WriteLine($"Четных: {testEvenCount}, Нечетных: {testOddCount}");

//        if (testEvenCount > testOddCount)
//        {
//            Console.WriteLine("Четных элементов больше в тестовом массиве.");
//        }
//        else if (testOddCount > testEvenCount)
//        {
//            Console.WriteLine("Нечетных элементов больше в тестовом массиве.");
//        }
//        else
//        {
//            Console.WriteLine("Количество равно в тестовом массиве.");
//        }
//    }
//}



//1.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7:");

//        double[] array = new double[15];

//        Console.WriteLine("Введите 15 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double first = array[0];

//        int count = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > first)
//            {
//                count++;
//            }
//        }

//        Console.WriteLine($"\nПервый элемент: {first}");
//        Console.WriteLine($"Количество элементов больше первого: {count}");
//        double[] testArray = { 5.5, 1.1, 6.6, 2.2, 7.7, 3.3, 8.8, 4.4, 9.9, 0.0, 10.0, -1.0, 11.1, 12.2, 4.5 };
//        double testFirst = testArray[0];
//        int testCount = 0;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");

//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] > testFirst) testCount++;
//        }

//        Console.WriteLine($"Первый: {testFirst}, Элементов больше: {testCount}");
//    }
//}



//1.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8:");

//        double[] array = new double[16];
//        Console.WriteLine("Введите 16 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        int maxIndex = 0;
//        int minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//            {
//                maxIndex = i;
//            }
//            if (array[i] < array[minIndex])
//            {
//                minIndex = i;
//            }
//        }

//        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
//        Console.WriteLine($"Минимальный элемент: {array[minIndex]} (индекс {minIndex})");
//        double[] testArray = { 3.3, 7.7, 1.1, 9.9, 2.2, 8.8, 4.4, 6.6, 5.5, 10.0, 0.0, 11.1, -1.0, 12.2, 13.3, -2.2 };
//        int testMaxIndex = 0;
//        int testMinIndex = 0;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");

//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] > testArray[testMaxIndex]) testMaxIndex = i;
//            if (testArray[i] < testArray[testMinIndex]) testMinIndex = i;
//        }

//        Console.WriteLine($"Max: {testArray[testMaxIndex]} (индекс {testMaxIndex}), Min: {testArray[testMinIndex]} (индекс {testMinIndex})");
//    }
//}



//1.9
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9:");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double average = array.Average();

//        double[] newArray = new double[15];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = array[i] - average;
//        }

//        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Среднее арифметическое: {average:F2}");
//        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray.Select(x => x.ToString("F2"))) + "]");

//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//        double testAverage = testArray.Average();
//        double[] testNewArray = new double[15];

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = testArray[i] - testAverage;
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Исходный: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Среднее: {testAverage:F2}");
//        Console.WriteLine("Результат: [" + string.Join(", ", testNewArray.Select(x => x.ToString("F2"))) + "]");
//    }
//}




//1.10
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10:");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 целых чисел (положительных и отрицательных):");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        var negativeAbs = array.Where(x => x < 0).Select(x => Math.Abs(x)).ToArray();

//        if (negativeAbs.Length == 0)
//        {
//            Console.WriteLine("Нет отрицательных элементов.");
//            return;
//        }

//        double avgNegAbs = negativeAbs.Average();

//        int sum = 0;
//        Console.WriteLine("\nЭлементы, |значение| которых больше среднего модулей отрицательных:");

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (Math.Abs(array[i]) > avgNegAbs)
//            {
//                Console.WriteLine($"array[{i}] = {array[i]}, |{array[i]}| = {Math.Abs(array[i])}");
//                sum += array[i];
//            }
//        }

//        Console.WriteLine($"\nСреднее модулей отрицательных: {avgNegAbs:F2}");
//        Console.WriteLine($"Сумма таких элементов: {sum}");

//        int[] testArray = { -10, 2, -5, 8, 1, -12, 3, 15, -2, 7, 4, -8, 9, -3, 6, -1, 11 };
//        var testNegativeAbs = testArray.Where(x => x < 0).Select(x => Math.Abs(x)).ToArray();
//        double testAvgNegAbs = testNegativeAbs.Average();
//        int testSum = testArray.Where(x => Math.Abs(x) > testAvgNegAbs).Sum();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Среднее модулей отрицательных: {testAvgNegAbs:F2}");
//        Console.WriteLine($"Сумма элементов |x| > среднего: {testSum}");
//    }
//}

//1.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: ");

//        int[] array = new int[14];

//        Console.WriteLine("Введите 14 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int count = 0;
//        int sum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0 && array[i] % 2 == 0)
//            {
//                count++;
//                sum += array[i];
//            }
//        }

//        Console.WriteLine($"Количество четных положительных элементов: {count}");
//        Console.WriteLine($"Сумма четных положительных элементов: {sum}");

//        int[] testArray = { 1, 2, -3, 4, 5, -6, 7, 8, -9, 10, 11, -12, 13, 14 };
//        int testCount = 0;
//        int testSum = 0;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");

//        foreach (int num in testArray)
//        {
//            if (num > 0 && num % 2 == 0)
//            {
//                testCount++;
//                testSum += num;
//            }
//        }

//        Console.WriteLine($"Количество в тесте: {testCount}, Сумма в тесте: {testSum}");
//    }
//}

//1.12
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: ");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        Array.Sort(array);
//        Array.Reverse(array);

//        double max = array[0];
//        double min = array[array.Length - 1];
//        double sum = max + min;

//        Console.WriteLine("\nОтсортированный массив (убывание): [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Сумма max и min: {sum}");

//        double[] testArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.0, 11.1, 12.2 };
//        Array.Sort(testArray);
//        Array.Reverse(testArray);
//        double testMax = testArray[0];
//        double testMin = testArray[testArray.Length - 1];
//        double testSum = testMax + testMin;

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Отсортированный: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Сумма max + min: {testSum}");
//    }
//}

//1.13
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13:");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int max = array[0];
//        int min = array[0];

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max) max = array[i];
//            if (array[i] < min) min = array[i];
//        }

//        int sum = max + min;
//        int diff = max - min;

//        Console.WriteLine($"\nMax: {max}, Min: {min}");
//        Console.WriteLine($"Сумма: {sum}, Разность: {diff}");

//        int[] testArray = { 15, 1, 14, 2, 13, 3, 12, 4, 11, 5, 10, 6, 9, 7, 8 };
//        int testMax = testArray[0];
//        int testMin = testArray[0];

//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] > testMax) testMax = testArray[i];
//            if (testArray[i] < testMin) testMin = testArray[i];
//        }

//        int testSum = testMax + testMin;
//        int testDiff = testMax - testMin;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Сумма: {testSum}, Разность: {testDiff}");
//    }
//}





//1.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14:");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int oddSum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 != 0)
//            {
//                oddSum += array[i];
//            }
//        }

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 3 == 0)
//            {
//                array[i] = oddSum;
//            }
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");

//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
//        int testOddSum = 0;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] % 2 != 0)
//            {
//                testOddSum += testArray[i];
//            }
//        }

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] % 3 == 0)
//            {
//                testArray[i] = testOddSum;
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//    }
//}
//2.15
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: ");
//        double[] array = new double[14];
//        Console.WriteLine("Введите 14 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        Array.Sort(array, 0, 7);
//        Array.Sort(array, 7, 7);
//        Array.Reverse(array, 7, 7);
//        Console.WriteLine("\nИзмененный массив: [" + string.Join(", ", array) + "]");
//        double[] testArray = { 14.0, 13.0, 12.0, 11.0, 10.0, 9.0, 8.0, 7.0, 6.0, 5.0, 4.0, 3.0, 2.0, 1.0 };
//        Array.Sort(testArray, 0, 7);
//        Array.Sort(testArray, 7, 7);
//        Array.Reverse(testArray, 7, 7);
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//    }
//}
//2.16
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: ");
//        double[] array = new double[12];
//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        int minIndex = 0;
//        int maxIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < array[minIndex]) minIndex = i;
//            if (array[i] > array[maxIndex]) maxIndex = i;
//        }
//        int start = Math.Min(minIndex, maxIndex);
//        int end = Math.Max(minIndex, maxIndex);
//        int count = end - start - 1;
//        Console.WriteLine($"\nКоличество элементов между min и max: {count}");
//        double[] testArray = { 1.0, 10.0, 2.0, 9.0, 3.0, 8.0, 4.0, 7.0, 5.0, 6.0, 0.0, 11.0 };
//        int testMinIndex = 0;
//        int testMaxIndex = 0;
//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] < testArray[testMinIndex]) testMinIndex = i;
//            if (testArray[i] > testArray[testMaxIndex]) testMaxIndex = i;
//        }
//        int testStart = Math.Min(testMinIndex, testMaxIndex);
//        int testEnd = Math.Max(testMinIndex, testMaxIndex);
//        int testCount = testEnd - testStart - 1;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}");
//    }
//}
//2.17
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: ");
//        int[] array = new int[15];
//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int negCount = 0;
//        long posProduct = 1;
//        int zeroCount = 0;
//        bool hasPositive = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                negCount++;
//            }
//            else if (array[i] > 0)
//            {
//                posProduct *= array[i];
//                hasPositive = true;
//            }
//            else
//            {
//                zeroCount++;
//            }
//        }
//        if (!hasPositive) posProduct = 0;
//        Console.WriteLine($"\nКоличество отрицательных: {negCount}");
//        Console.WriteLine($"Произведение положительных: {posProduct}");
//        Console.WriteLine($"Количество нулевых: {zeroCount}");
//        int[] testArray = { -1, 2, 0, -3, 4, 0, -5, 6, 7, -8, 9, 10, -11, 12, 0 };
//        int testNegCount = 0;
//        long testPosProduct = 1;
//        bool testHasPositive = false;
//        int testZeroCount = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] < 0) testNegCount++;
//            else if (testArray[i] > 0)
//            {
//                testPosProduct *= testArray[i];
//                testHasPositive = true;
//            }
//            else testZeroCount++;
//        }
//        if (!testHasPositive) testPosProduct = 0;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Отрицательных: {testNegCount}, Произведение положительных: {testPosProduct}, Нулевых: {testZeroCount}");
//    }
//}
//2.18
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: ");
//        double[] array = new double[12];
//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        double min = array[0];
//        double max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < min) min = array[i];
//            if (array[i] > max) max = array[i];
//        }
//        Console.WriteLine($"\nИнтервал: [{min}, {max}]");
//        double[] testArray = { 1.5, 3.2, 0.8, 4.7, 2.1, 5.6, 6.3, -1.0, 7.4, 8.9, 9.0, 10.5 };
//        double testMin = testArray[0];
//        double testMax = testArray[0];
//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] < testMin) testMin = testArray[i];
//            if (testArray[i] > testMax) testMax = testArray[i];
//        }
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Интервал: [{testMin}, {testMax}]");
//    }
//}
//2.19
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: ");
//        int[] array = new int[19];
//        Console.WriteLine("Введите 19 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int sum = 0;
//        bool foundNegative = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                foundNegative = true;
//                break;
//            }
//            sum += array[i];
//        }
//        if (foundNegative)
//        {
//            Console.WriteLine($"\nСумма до первого отрицательного: {sum}");
//        }
//        else
//        {
//            Console.WriteLine("\nОтрицательных элементов нет.");
//        }
//        int[] testArray = { 1, 2, 3, 4, 5, -6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
//        int testSum = 0;
//        bool testFoundNegative = false;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] < 0)
//            {
//                testFoundNegative = true;
//                break;
//            }
//            testSum += testArray[i];
//        }
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        if (testFoundNegative)
//        {
//            Console.WriteLine($"Сумма: {testSum}");
//        }
//        else
//        {
//            Console.WriteLine("Отрицательных нет.");
//        }
//    }
//}
//2.20
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: ");
//        int[] array = new int[16];
//        Console.WriteLine("Введите 16 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int replaceCount = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 3 == 0 && array[i] != 0)
//            {
//                array[i] = 0;
//                replaceCount++;
//            }
//        }
//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Количество замен: {replaceCount}");
//        int[] testArray = { 1, 3, 5, 6, 7, 9, 11, 12, 13, 15, 17, 18, 19, 21, 23, 24 };
//        int testReplaceCount = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] % 3 == 0 && testArray[i] != 0)
//            {
//                testArray[i] = 0;
//                testReplaceCount++;
//            }
//        }
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Замен: {testReplaceCount}");
//    }
//}
//2.21
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 21: ");
//        double[] array = new double[12];
//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        int minIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < array[minIndex]) minIndex = i;
//        }
//        array[minIndex] *= 3;
//        double temp = array[minIndex];
//        array[minIndex] = array[11];
//        array[11] = temp;
//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");
//        double[] testArray = { 12.0, 11.0, 10.0, 9.0, 8.0, 7.0, 6.0, 5.0, 4.0, 3.0, 2.0, 1.0 };
//        int testMinIndex = 0;
//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] < testArray[testMinIndex]) testMinIndex = i;
//        }
//        testArray[testMinIndex] *= 3;
//        double testTemp = testArray[testMinIndex];
//        testArray[testMinIndex] = testArray[11];
//        testArray[11] = testTemp;
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//    }
//}
//2.22
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 22: ");
//        double[] array = new double[15];
//        Console.WriteLine("Введите 15 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        Array.Reverse(array);
//        Console.WriteLine("\nОбратный массив: [" + string.Join(", ", array) + "]");
//        double[] testArray = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 13.0, 14.0, 15.0 };
//        Array.Reverse(testArray);
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//    }
//}
//2.23
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 23: ");
//        int[] array = new int[14];
//        Console.WriteLine("Введите 14 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int evenIndexSum = 0;
//        long oddValueProduct = 1;
//        bool hasOddValue = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                evenIndexSum += array[i];
//            }
//            if (array[i] % 2 != 0)
//            {
//                oddValueProduct *= array[i];
//                hasOddValue = true;
//            }
//        }
//        if (!hasOddValue) oddValueProduct = 0;
//        Console.WriteLine($"\nСумма элементов с четными индексами: {evenIndexSum}");
//        Console.WriteLine($"Произведение нечетных по значению: {oddValueProduct}");
//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
//        int testEvenIndexSum = 0;
//        long testOddValueProduct = 1;
//        bool testHasOddValue = false;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (i % 2 == 0) testEvenIndexSum += testArray[i];
//            if (testArray[i] % 2 != 0)
//            {
//                testOddValueProduct *= testArray[i];
//                testHasOddValue = true;
//            }
//        }
//        if (!testHasOddValue) testOddValueProduct = 0;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Сумма чет инд: {testEvenIndexSum}, Произв нечет знач: {testOddValueProduct}");
//    }
//}
//2.24
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 24: ");
//        double[] array = new double[12];
//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        double last = array[11];
//        int count = 0;
//        double sum = 0;
//        for (int i = 0; i < 11; i++)
//        {
//            if (array[i] < last)
//            {
//                count++;
//                sum += array[i];
//            }
//        }
//        Console.WriteLine($"\nКоличество меньше последнего: {count}");
//        Console.WriteLine($"Сумма меньше последнего: {sum}");
//        double[] testArray = { 12.0, 11.0, 10.0, 9.0, 8.0, 7.0, 6.0, 5.0, 4.0, 3.0, 2.0, 1.0 };
//        double testLast = testArray[11];
//        int testCount = 0;
//        double testSum = 0;
//        for (int i = 0; i < 11; i++)
//        {
//            if (testArray[i] < testLast)
//            {
//                testCount++;
//                testSum += testArray[i];
//            }
//        }
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}, Сумма: {testSum}");
//    }
//}
//2.25
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 25: ");
//        int[] array = new int[15];
//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int posSum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                posSum += array[i];
//            }
//        }
//        int[] newArray = new int[15];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = array[i] - posSum;
//        }
//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");
//        int[] testArray = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8 };
//        int testPosSum = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] > 0) testPosSum += testArray[i];
//        }
//        int[] testNewArray = new int[15];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = testArray[i] - testPosSum;
//        }
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testNewArray) + "]");
//    }
//}
//2.26
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 26: ");
//        double[] array = new double[15];
//        Console.WriteLine("Введите 15 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        double posProduct = 1;
//        bool hasPos = false;
//        double negAbsProduct = 1;
//        bool hasNeg = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                posProduct *= array[i];
//                hasPos = true;
//            }
//            else if (array[i] < 0)
//            {
//                negAbsProduct *= Math.Abs(array[i]);
//                hasNeg = true;
//            }
//        }
//        if (!hasPos) posProduct = 0;
//        if (!hasNeg) negAbsProduct = 0;
//        double difference = posProduct - negAbsProduct;
//        Console.WriteLine($"\nРазность: {difference}");
//        double[] testArray = { 1.0, -2.0, 3.0, -4.0, 5.0, -6.0, 7.0, -8.0, 9.0, -10.0, 11.0, -12.0, 13.0, -14.0, 15.0 };
//        double testPosProduct = 1;
//        bool testHasPos = false;
//        double testNegAbsProduct = 1;
//        bool testHasNeg = false;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] > 0)
//            {
//                testPosProduct *= testArray[i];
//                testHasPos = true;
//            }
//            else if (testArray[i] < 0)
//            {
//                testNegAbsProduct *= Math.Abs(testArray[i]);
//                testHasNeg = true;
//            }
//        }
//        if (!testHasPos) testPosProduct = 0;
//        if (!testHasNeg) testNegAbsProduct = 0;
//        double testDifference = testPosProduct - testNegAbsProduct;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Разность: {testDifference}");
//    }
//}
//2.27
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 27: ");
//        int[] array = new int[19];
//        Console.WriteLine("Введите 19 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max) max = array[i];
//        }
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                array[i] = max;
//            }
//        }
//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");
//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
//        int testMax = testArray[0];
//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] > testMax) testMax = testArray[i];
//        }
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] % 2 == 0)
//            {
//                testArray[i] = testMax;
//            }
//        }
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Результат: [" + string.Join(", ", testArray) + "]");
//    }
//}
//2.28
//using System;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 28: ");
//        int[] array = new int[17];
//        Console.WriteLine("Введите 17 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        var positives = array.Where(x => x > 0).ToArray();
//        if (positives.Length == 0)
//        {
//            Console.WriteLine("Нет положительных элементов.");
//            return;
//        }
//        double posAvg = positives.Average();
//        int count = 0;
//        int sum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (Math.Abs(array[i]) > posAvg)
//            {
//                count++;
//                sum += array[i];
//            }
//        }
//        Console.WriteLine($"\nСреднее положительных: {posAvg:F2}");
//        Console.WriteLine($"Количество: {count}, Сумма: {sum}");
//        int[] testArray = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11, -12, 13, -14, 15, -16, 17 };
//        var testPositives = testArray.Where(x => x > 0).ToArray();
//        double testPosAvg = testPositives.Average();
//        int testCount = 0;
//        int testSum = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (Math.Abs(testArray[i]) > testPosAvg)
//            {
//                testCount++;
//                testSum += testArray[i];
//            }
//        }
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}, Сумма: {testSum}");
//    }
//}
//2.29
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 29: ");
//        double[] array = new double[18];
//        Console.WriteLine("Введите 18 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }
//        double posProduct = 1;
//        bool hasPos = false;
//        double negAbsSum = 0;
//        bool hasNeg = false;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                posProduct *= array[i];
//                hasPos = true;
//            }
//            else if (array[i] < 0)
//            {
//                negAbsSum += Math.Abs(array[i]);
//                hasNeg = true;
//            }
//        }
//        if (!hasPos || !hasNeg || negAbsSum == 0)
//        {
//            Console.WriteLine("Невозможно вычислить (нет положительных или отрицательных, или сумма модулей отрицательных = 0).");
//            return;
//        }
//        double quotient = posProduct / negAbsSum;
//        Console.WriteLine($"\nЧастное: {quotient}");
//        double[] testArray = { 1.0, -1.0, 2.0, -2.0, 3.0, -3.0, 4.0, -4.0, 5.0, -5.0, 6.0, -6.0, 7.0, -7.0, 8.0, -8.0, 9.0, -9.0 };
//        double testPosProduct = 1;
//        bool testHasPos = false;
//        double testNegAbsSum = 0;
//        bool testHasNeg = false;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] > 0)
//            {
//                testPosProduct *= testArray[i];
//                testHasPos = true;
//            }
//            else if (testArray[i] < 0)
//            {
//                testNegAbsSum += Math.Abs(testArray[i]);
//                testHasNeg = true;
//            }
//        }
//        double testQuotient = testPosProduct / testNegAbsSum;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Частное: {testQuotient}");
//    }
//}
//3.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.1: ");

//        int[] array1 = new int[10];
//        int[] array2 = new int[10];

//        Console.WriteLine("Введите 10 целых чисел для первого массива:");
//        for (int i = 0; i < array1.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите 10 целых чисел для второго массива:");
//        for (int i = 0; i < array2.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[10];
//        int oddIndexCount = 0;
//        int evenIndexCount = 0;

//        for (int i = 0; i < newArray.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                newArray[i] = array1[2 * oddIndexCount + 1];
//                oddIndexCount++;
//            }
//            else
//            {
//                newArray[i] = array2[2 * evenIndexCount];
//                evenIndexCount++;
//            }
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        int[] testArray2 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
//        int[] testNewArray = new int[10];
//        int testOddIndexCount = 0;
//        int testEvenIndexCount = 0;

//        for (int i = 0; i < testNewArray.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                testNewArray[i] = testArray1[2 * testOddIndexCount + 1];
//                testOddIndexCount++;
//            }
//            else
//            {
//                testNewArray[i] = testArray2[2 * testEvenIndexCount];
//                testEvenIndexCount++;
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Первый: [" + string.Join(", ", testArray1) + "]");
//        Console.WriteLine("Второй: [" + string.Join(", ", testArray2) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//3.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.2: ");

//        int[] array = new int[8];

//        Console.WriteLine("Введите 8 двузначных целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[8];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = array[i] % 10;
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 10, 21, 32, 43, 54, 65, 76, 87 };
//        int[] testNewArray = new int[8];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = testArray[i] % 10;
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Исходный: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//3.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.3: ");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 двузначных целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            sum += array[i] / 10 + array[i] % 10;
//        }

//        Console.WriteLine($"\nСумма цифр: {sum}");

//        int[] testArray = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
//        int testSum = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testSum += testArray[i] / 10 + testArray[i] % 10;
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Сумма: {testSum}");
//    }
//}

//3.4
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.4: ");

//        double[] array1 = new double[9];
//        double[] array2 = new double[7];

//        Console.WriteLine("Введите 9 вещественных чисел для первого массива:");
//        for (int i = 0; i < array1.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите 7 вещественных чисел для второго массива:");
//        for (int i = 0; i < array2.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = double.Parse(Console.ReadLine());
//        }

//        double[] newArray = array1.Concat(array2).OrderBy(x => x).ToArray();

//        Console.WriteLine("\nТретий массив: [" + string.Join(", ", newArray) + "]");

//        double[] testArray1 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
//        double[] testArray2 = { 16, 15, 14, 13, 12, 11, 10 };
//        double[] testNewArray = testArray1.Concat(testArray2).OrderBy(x => x).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Третий: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//3.5
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.5: ");

//        int[] x = new int[10];
//        int[] y = new int[10];

//        Console.WriteLine("Введите 10 целых чисел для массива X:");
//        for (int i = 0; i < x.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            x[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите 10 целых чисел для массива Y:");
//        for (int i = 0; i < y.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            y[i] = int.Parse(Console.ReadLine());
//        }

//        int[] s = x.Intersect(y).ToArray();

//        Console.WriteLine("\nМассив S: [" + string.Join(", ", s) + "]");

//        int[] testX = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int[] testY = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
//        int[] testS = testX.Intersect(testY).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("S: [" + string.Join(", ", testS) + "]");
//    }
//}

//3.6
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.6: ");

//        double[] y = new double[12];

//        for (int i = 0; i < y.Length; i++)
//        {
//            int index = i + 1;
//            y[i] = 12 - 2 * index + 19.3 * Math.Cos(index);
//        }

//        Console.WriteLine("\nМассив Y: [" + string.Join(", ", y.Select(x => x.ToString("F2"))) + "]");

//        double avg = y.Average();

//        double[] newArray = y.Where(x => x < avg).Concat(y.Where(x => x >= avg)).ToArray();

//        Console.WriteLine($"Среднее: {avg:F2}");
//        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray.Select(x => x.ToString("F2"))) + "]");

//        double[] testY = new double[12];
//        for (int i = 0; i < testY.Length; i++)
//        {
//            int index = i + 1;
//            testY[i] = 12 - 2 * index + 19.3 * Math.Cos(index);
//        }
//        double testAvg = testY.Average();
//        double[] testNewArray = testY.Where(x => x < testAvg).Concat(testY.Where(x => x >= testAvg)).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray.Select(x => x.ToString("F2"))) + "]");
//    }
//}

//3.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.7: ");

//        double[] z = new double[16];

//        Console.WriteLine("Введите 16 вещественных чисел:");
//        for (int i = 0; i < z.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            z[i] = double.Parse(Console.ReadLine());
//        }

//        double evenSum = 0;
//        double tripleSum = 0;

//        for (int i = 0; i < z.Length; i++)
//        {
//            if (i % 2 == 0) evenSum += z[i];
//            if (i % 3 == 0) tripleSum += z[i];
//        }

//        double diff = evenSum - tripleSum;

//        Console.WriteLine($"\nРазность: {diff}");

//        double[] testZ = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
//        double testEvenSum = 0;
//        double testTripleSum = 0;

//        for (int i = 0; i < testZ.Length; i++)
//        {
//            if (i % 2 == 0) testEvenSum += testZ[i];
//            if (i % 3 == 0) testTripleSum += testZ[i];
//        }

//        double testDiff = testEvenSum - testTripleSum;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testZ) + "]");
//        Console.WriteLine($"Разность: {testDiff}");
//    }
//}

//3.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.8: ");

//        int[] r = new int[9];

//        Console.WriteLine("Введите 9 целых чисел:");
//        for (int i = 0; i < r.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            r[i] = int.Parse(Console.ReadLine());
//        }

//        int maxOddPos = int.MinValue;
//        int index = -1;

//        for (int i = 0; i < r.Length; i++)
//        {
//            if (r[i] > 0 && r[i] % 2 != 0 && r[i] > maxOddPos)
//            {
//                maxOddPos = r[i];
//                index = i;
//            }
//        }

//        if (index != -1)
//        {
//            Console.WriteLine($"\nИндекс: {index}");
//        }
//        else
//        {
//            Console.WriteLine("\nНет таких элементов.");
//        }

//        int[] testR = { 2, -3, 5, 4, 7, -1, 9, 6, 11 };
//        int testMaxOddPos = int.MinValue;
//        int testIndex = -1;

//        for (int i = 0; i < testR.Length; i++)
//        {
//            if (testR[i] > 0 && testR[i] % 2 != 0 && testR[i] > testMaxOddPos)
//            {
//                testMaxOddPos = testR[i];
//                testIndex = i;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testR) + "]");
//        Console.WriteLine($"Индекс: {testIndex}");
//    }
//}

//3.9
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3.9: ");

//        int[] x = new int[15];

//        Console.WriteLine("Введите 15 целых чисел для массива X:");
//        for (int i = 0; i < x.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            x[i] = int.Parse(Console.ReadLine());
//        }

//        double[] y = new double[15];
//        for (int i = 0; i < y.Length; i++)
//        {
//            int index = i + 1;
//            y[i] = Math.Cos(x[i]) + 2.97 * Math.Log10(2 * index * index);
//        }

//        double[] third = x.Select(n => (double)n).Concat(y).OrderByDescending(n => n).ToArray();

//        Console.WriteLine("\nМассив Y: [" + string.Join(", ", y.Select(n => n.ToString("F2"))) + "]");
//        Console.WriteLine("Третий массив: [" + string.Join(", ", third.Select(n => n.ToString("F2"))) + "]");

//        int[] testX = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//        double[] testY = new double[15];
//        for (int i = 0; i < testY.Length; i++)
//        {
//            int index = i + 1;
//            testY[i] = Math.Cos(testX[i]) + 2.97 * Math.Log10(2 * index * index);
//        }
//        double[] testThird = testX.Select(n => (double)n).Concat(testY).OrderByDescending(n => n).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Третий: [" + string.Join(", ", testThird.Select(n => n.ToString("F2"))) + "]");
//    }
//}
//4.10
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4.10: ");
//        int[,] x = new int[10, 10];
//        Console.WriteLine("Введите элементы матрицы X 10×10:");
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                x[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        int[,] y = new int[10, 10];
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (i == j)
//                {
//                    y[i, j] = (int)Math.Pow(x[i, j], -7.5);
//                }
//                else if (x[i, j] > 0)
//                {
//                    y[i, j] = (int)(x[i, j] * Math.Cos(x[i, j]));
//                }
//                else
//                {
//                    y[i, j] = 0;
//                }
//            }
//        }
//        Console.WriteLine("\nМатрица Y:");
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"{y[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//        int[,] testX = {
//{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
//{2, 1, 2, 3, 4, 5, 6, 7, 8, 9},
//{3, 2, 1, 2, 3, 4, 5, 6, 7, 8},
//{4, 3, 2, 1, 2, 3, 4, 5, 6, 7},
//{5, 4, 3, 2, 1, 2, 3, 4, 5, 6},
//{6, 5, 4, 3, 2, 1, 2, 3, 4, 5},
//{7, 6, 5, 4, 3, 2, 1, 2, 3, 4},
//{8, 7, 6, 5, 4, 3, 2, 1, 2, 3},
//{9, 8, 7, 6, 5, 4, 3, 2, 1, 2},
//{10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
//};
//        int[,] testY = new int[10, 10];
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (i == j)
//                {
//                    testY[i, j] = (int)Math.Pow(testX[i, j], -7.5);
//                }
//                else if (testX[i, j] > 0)
//                {
//                    testY[i, j] = (int)(testX[i, j] * Math.Cos(testX[i, j]));
//                }
//                else
//                {
//                    testY[i, j] = 0;
//                }
//            }
//        }
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Матрица Y:");
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"{testY[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//4.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: ");

//        int[] array = new int[9];

//        Console.WriteLine("Введите 9 двузначных целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[9];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = (array[i] / 10) + (array[i] % 10);
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 10, 21, 32, 43, 54, 65, 76, 87, 98 };
//        int[] testNewArray = new int[9];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = (testArray[i] / 10) + (testArray[i] % 10);
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//4.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: ");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int swapCount = 0;
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - 1 - i; j++)
//            {
//                if (array[j] < array[j + 1])
//                {
//                    double temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                    swapCount++;
//                }
//            }
//        }

//        Console.WriteLine("\nОтсортированный массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Количество перестановок: {swapCount}");

//        double[] testArray = { 1.2, 3.4, 5.6, 7.8, 9.0, 10.1, 11.2, 12.3, 13.4, 14.5, 15.6, 16.7 };
//        int testSwapCount = 0;
//        for (int i = 0; i < testArray.Length - 1; i++)
//        {
//            for (int j = 0; j < testArray.Length - 1 - i; j++)
//            {
//                if (testArray[j] < testArray[j + 1])
//                {
//                    double temp = testArray[j];
//                    testArray[j] = testArray[j + 1];
//                    testArray[j + 1] = temp;
//                    testSwapCount++;
//                }
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Отсортированный: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Перестановок: {testSwapCount}");
//    }
//}

//4.13
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: ");

//        int[] array = new int[11];

//        Console.WriteLine("Введите 11 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sumOddNeg = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0 && array[i] % 2 != 0)
//            {
//                sumOddNeg += array[i];
//            }
//        }

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 3 == 0)
//            {
//                array[i] = sumOddNeg;
//            }
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");

//        int[] testArray = { 1, -1, 3, -3, 5, -5, 7, -7, 9, -9, 11 };
//        int testSumOddNeg = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] < 0 && testArray[i] % 2 != 0)
//            {
//                testSumOddNeg += testArray[i];
//            }
//        }
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] % 3 == 0)
//            {
//                testArray[i] = testSumOddNeg;
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testArray) + "]");
//    }
//}

//4.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: ");

//        double[] array = new double[14];

//        Console.WriteLine("Введите 14 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int swapCount = 0;
//        for (int i = 0; i < 7; i++)
//        {
//            double temp = array[i];
//            array[i] = array[i + 7];
//            array[i + 7] = temp;
//            swapCount++;
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Количество перестановок: {swapCount}");

//        double[] testArray = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 13.0, 14.0 };
//        int testSwapCount = 0;
//        for (int i = 0; i < 7; i++)
//        {
//            double temp = testArray[i];
//            testArray[i] = testArray[i + 7];
//            testArray[i + 7] = temp;
//            testSwapCount++;
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Перестановок: {testSwapCount}");
//    }
//}

//4.15
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        Console.Write("Введите число S: ");
//        double s = double.Parse(Console.ReadLine());

//        double maxDist = 0;
//        int index = -1;
//        double value = 0;

//        for (int i = 0; i < size; i++)
//        {
//            double dist = Math.Abs(array[i] - s);
//            if (dist > maxDist)
//            {
//                maxDist = dist;
//                index = i;
//                value = array[i];
//            }
//        }

//        Console.WriteLine($"\nЗначение: {value}, Индекс: {index}");

//        double[] testArray = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
//        double testS = 5.5;
//        double testMaxDist = 0;
//        int testIndex = -1;
//        double testValue = 0;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            double dist = Math.Abs(testArray[i] - testS);
//            if (dist > testMaxDist)
//            {
//                testMaxDist = dist;
//                testIndex = i;
//                testValue = testArray[i];
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"S: {testS}, Значение: {testValue}, Индекс: {testIndex}");
//    }
//}

//4.16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: ");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;
//        int count = 0;
//        bool foundNegative = false;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                foundNegative = true;
//                break;
//            }
//            sum += array[i];
//            count++;
//        }

//        if (foundNegative)
//        {
//            Console.WriteLine($"\nСумма: {sum}, Количество: {count}");
//        }
//        else
//        {
//            Console.WriteLine("\nНет отрицательных элементов.");
//        }

//        int[] testArray = { 1, 2, 3, 4, -5, 6, 7, 8, 9, 10 };
//        int testSum = 0;
//        int testCount = 0;
//        bool testFoundNegative = false;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] < 0)
//            {
//                testFoundNegative = true;
//                break;
//            }
//            testSum += testArray[i];
//            testCount++;
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Сумма: {testSum}, Количество: {testCount}");
//    }
//}

//4.17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int count = 0;
//        for (int i = 1; i < size - 1; i++)
//        {
//            if (array[i] < array[i - 1] && array[i] < array[i + 1])
//            {
//                count++;
//            }
//        }

//        Console.WriteLine($"\nКоличество локальных минимумов: {count}");

//        double[] testArray = { 1, 3, 2, 4, 1, 5, 3, 2, 6, 7, 4, 8 };
//        int testCount = 0;
//        for (int i = 1; i < testArray.Length - 1; i++)
//        {
//            if (testArray[i] < testArray[i - 1] && testArray[i] < testArray[i + 1])
//            {
//                testCount++;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}");
//    }
//}

//4.18
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int count = 0;
//        for (int i = 1; i < size - 1; i++)
//        {
//            if (array[i] > array[i - 1] && array[i] > array[i + 1])
//            {
//                count++;
//            }
//        }

//        Console.WriteLine($"\nКоличество локальных максимумов: {count}");

//        double[] testArray = { 1, 3, 2, 4, 1, 5, 3, 2, 6, 7, 4, 8 };
//        int testCount = 0;
//        for (int i = 1; i < testArray.Length - 1; i++)
//        {
//            if (testArray[i] > testArray[i - 1] && testArray[i] > testArray[i + 1])
//            {
//                testCount++;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}");
//    }
//}

//4.19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: ");

//        int[] z = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < z.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            z[i] = int.Parse(Console.ReadLine());
//        }

//        int firstNegIndex = -1;
//        int zeroIndex = -1;

//        for (int i = 0; i < z.Length; i++)
//        {
//            if (z[i] < 0 && firstNegIndex == -1)
//            {
//                firstNegIndex = i;
//            }
//            if (z[i] == 0 && firstNegIndex != -1)
//            {
//                zeroIndex = i;
//                break;
//            }
//        }

//        if (firstNegIndex != -1 && zeroIndex != -1)
//        {
//            int sum = 0;
//            Console.Write("\nПоследовательность: ");
//            for (int i = firstNegIndex + 1; i < zeroIndex; i++)
//            {
//                Console.Write(z[i] + " ");
//                sum += z[i];
//            }
//            Console.WriteLine($"\nСумма: {sum}");
//        }
//        else
//        {
//            Console.WriteLine("\nНе найдена полная последовательность.");
//        }

//        int[] testZ = { 1, 2, -3, 4, 5, 6, 0, 7, 8, 9, 10, 11, 12, 13, 14 };
//        int testFirstNegIndex = -1;
//        int testZeroIndex = -1;

//        for (int i = 0; i < testZ.Length; i++)
//        {
//            if (testZ[i] < 0 && testFirstNegIndex == -1)
//            {
//                testFirstNegIndex = i;
//            }
//            if (testZ[i] == 0 && testFirstNegIndex != -1)
//            {
//                testZeroIndex = i;
//                break;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testZ) + "]");
//        if (testFirstNegIndex != -1 && testZeroIndex != -1)
//        {
//            int testSum = 0;
//            Console.Write("Последовательность: ");
//            for (int i = testFirstNegIndex + 1; i < testZeroIndex; i++)
//            {
//                Console.Write(testZ[i] + " ");
//                testSum += testZ[i];
//            }
//            Console.WriteLine($"\nСумма: {testSum}");
//        }
//    }
//}

//4.20
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        List<string> sequences = new List<string>();
//        for (int i = 0; i < size - 1; i++)
//        {
//            if (array[i + 1] < array[i])
//            {
//                int start = i;
//                while (i < size - 1 && array[i + 1] < array[i])
//                {
//                    i++;
//                }
//                sequences.Add($"{start}-{i}");
//            }
//        }

//        Console.WriteLine("\nИндексы монотонно убывающих последовательностей: " + string.Join(", ", sequences));

//        double[] testArray = { 5, 4, 3, 6, 5, 4, 7, 8, 9, 2, 1, 0, 10 };
//        List<string> testSequences = new List<string>();
//        for (int i = 0; i < testArray.Length - 1; i++)
//        {
//            if (testArray[i + 1] < testArray[i])
//            {
//                int start = i;
//                while (i < testArray.Length - 1 && testArray[i + 1] < testArray[i])
//                {
//                    i++;
//                }
//                testSequences.Add($"{start}-{i}");
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Индексы: " + string.Join(", ", testSequences));
//    }
//}
//5.21
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.21: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Dictionary<int, int> counts = new Dictionary<int, int>();
//        for (int i = 0; i < size; i++)
//        {
//            if (counts.ContainsKey(array[i]))
//            {
//                counts[array[i]]++;
//            }
//            else
//            {
//                counts[array[i]] = 1;
//            }
//        }

//        List<int> newList = new List<int>();
//        for (int i = 0; i < size; i++)
//        {
//            if (counts[array[i]] <= 2)
//            {
//                newList.Add(array[i]);
//            }
//        }

//        int[] newArray = newList.ToArray();

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 5 };
//        Dictionary<int, int> testCounts = new Dictionary<int, int>();
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testCounts.ContainsKey(testArray[i]))
//            {
//                testCounts[testArray[i]]++;
//            }
//            else
//            {
//                testCounts[testArray[i]] = 1;
//            }
//        }
//        List<int> testNewList = new List<int>();
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testCounts[testArray[i]] <= 2)
//            {
//                testNewList.Add(testArray[i]);
//            }
//        }
//        int[] testNewArray = testNewList.ToArray();

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//5.22
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.22: ");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> negatives = new List<int>();
//        List<int> positives = new List<int>();
//        int negCount = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                negatives.Add(array[i]);
//                negCount++;
//            }
//            else if (array[i] > 0)
//            {
//                positives.Add(array[i]);
//            }
//        }

//        List<int> newList = new List<int>();
//        newList.AddRange(negatives);
//        newList.Add(negCount);
//        newList.AddRange(positives);

//        int[] newArray = newList.ToArray();

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5 };
//        List<int> testNegatives = new List<int>();
//        List<int> testPositives = new List<int>();
//        int testNegCount = 0;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (testArray[i] < 0)
//            {
//                testNegatives.Add(testArray[i]);
//                testNegCount++;
//            }
//            else if (testArray[i] > 0)
//            {
//                testPositives.Add(testArray[i]);
//            }
//        }

//        List<int> testNewList = new List<int>();
//        testNewList.AddRange(testNegatives);
//        testNewList.Add(testNegCount);
//        testNewList.AddRange(testPositives);

//        int[] testNewArray = testNewList.ToArray();

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//5.23
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.23: ");

//        double[] x = new double[10];

//        Console.WriteLine("Введите 10 целых чисел для массива X:");
//        for (int i = 0; i < x.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            x[i] = int.Parse(Console.ReadLine());
//        }

//        double[] y = new double[10];
//        for (int i = 0; i < x.Length; i++)
//        {
//            y[i] = Math.Pow(x[i], 7) + 0.3;
//        }

//        double p = 0;
//        for (int j = 0; j < 5; j++)
//        {
//            p += x[j] * y[2 * j + 1];
//        }

//        Console.WriteLine("\nМассив Y: [" + string.Join(", ", y.Select(v => v.ToString("F2"))) + "]");
//        Console.WriteLine($"P: {p:F2}");

//        double[] testX = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        double[] testY = new double[10];
//        for (int i = 0; i < testX.Length; i++)
//        {
//            testY[i] = Math.Pow(testX[i], 7) + 0.3;
//        }
//        double testP = 0;
//        for (int j = 0; j < 5; j++)
//        {
//            testP += testX[j] * testY[2 * j + 1];
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("P: " + testP.ToString("F2"));
//    }
//}

//5.24
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.24: ");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел (шесть двузначных):");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[10];
//        for (int i = 0; i < array.Length; i++)
//        {
//            int digit1 = array[i] / 10;
//            int digit2 = array[i] % 10;
//            newArray[i] = digit1 - digit2;
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 10, 21, 32, 43, 54, 65, 76, 87, 98, 99 };
//        int[] testNewArray = new int[10];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            int digit1 = testArray[i] / 10;
//            int digit2 = testArray[i] % 10;
//            testNewArray[i] = digit1 - digit2;
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//5.25
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.25: ");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        var negatives = array.Where(n => n < 0).OrderByDescending(n => n).ToArray();
//        var positives = array.Where(n => n >= 0).OrderByDescending(n => n).ToArray();

//        int[] newArray = negatives.Concat(positives).ToArray();

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8 };
//        var testNegatives = testArray.Where(n => n < 0).OrderByDescending(n => n).ToArray();
//        var testPositives = testArray.Where(n => n >= 0).OrderByDescending(n => n).ToArray();
//        int[] testNewArray = testNegatives.Concat(testPositives).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//5.26
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.26: ");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        var negatives = array.Where(n => n < 0).ToArray();
//        var positives = array.Where(n => n >= 0).OrderByDescending(n => n).ToArray();

//        int[] newArray = negatives.Concat(positives).ToArray();

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8 };
//        var testNegatives = testArray.Where(n => n < 0).ToArray();
//        var testPositives = testArray.Where(n => n >= 0).OrderByDescending(n => n).ToArray();
//        int[] testNewArray = testNegatives.Concat(testPositives).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//5.27
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.27: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int count = 0;
//        for (int i = 0; i < size - 1; i++)
//        {
//            if (array[i + 1] > array[i])
//            {
//                int start = i;
//                while (i < size - 1 && array[i + 1] > array[i])
//                {
//                    i++;
//                }
//                count++;
//            }
//        }
//        if (size > 0) count++; // for single elements or last sequence

//        Console.WriteLine($"\nКоличество монотонно возрастающих частей: {count}");

//        int[] testArray = { 1, 3, 5, 2, 4, 6, 8, 7, 9, 10 };
//        int testCount = 0;
//        for (int i = 0; i < testArray.Length - 1; i++)
//        {
//            if (testArray[i + 1] > testArray[i])
//            {
//                int start = i;
//                while (i < testArray.Length - 1 && testArray[i + 1] > testArray[i])
//                {
//                    i++;
//                }
//                testCount++;
//            }
//        }
//        if (testArray.Length > 0) testCount++;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Количество: {testCount}");
//    }
//}
//5.28
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.28: ");
//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        int evenSum = 0;
//        int oddSum = 0;
//        for (int i = 0; i < size; i++)
//        {
//            if (i % 2 == 0)
//            {
//                evenSum += array[i];
//            }
//            else
//            {
//                oddSum += array[i];
//            }
//        }
//        if (oddSum == 0)
//        {
//            Console.WriteLine("\nСумма нечетных индексов = 0, деление невозможно.");
//        }
//        else
//        {
//            int remainder = evenSum % oddSum;
//            Console.WriteLine($"\nОстаток: {remainder}");
//        }
//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int testEvenSum = 0;
//        int testOddSum = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            if (i % 2 == 0) testEvenSum += testArray[i];
//            else testOddSum += testArray[i];
//        }
//        int testRemainder = testEvenSum % testOddSum;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Остаток: {testRemainder}");
//    }
//}
//5.29
//using System;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.29: ");
//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }
//        double avg = array.Average();
//        int count = array.Count(x => x > avg);
//        double percentage = (double)count / size * 100;
//        Console.WriteLine($"\nСреднее: {avg:F2}");
//        Console.WriteLine($"Процент: {percentage:F2}%");
//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        double testAvg = testArray.Average();
//        int testCount = testArray.Count(x => x > testAvg);
//        double testPercentage = (double)testCount / testArray.Length * 100;
//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine($"Процент: {testPercentage:F2}%");
//    }
//}
//5.30
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5.30: ");
//        Console.Write("Введите размер первого массива: ");
//        int size1 = int.Parse(Console.ReadLine());
//        double[] array1 = new double[size1];
//        Console.WriteLine("Введите элементы первого массива:");
//        for (int i = 0; i < size1; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = double.Parse(Console.ReadLine());
//        }
//        Console.Write("Введите размер второго массива: ");
//        int size2 = int.Parse(Console.ReadLine());
//        double[] array2 = new double[size2];
//        Console.WriteLine("Введите элементы второго массива:");
//        for (int i = 0; i < size2; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = double.Parse(Console.ReadLine());
//        }
//        double max1 = array1[0];
//        int maxIndex1 = 0;
//        for (int i = 1; i < size1; i++)
//        {
//            if (array1[i] > max1)
//            {
//                max1 = array1[i];
//                maxIndex1 = i;
//            }
//        }
//        double max2 = array2[0];
//        int maxIndex2 = 0;
//        for (int i = 1; i < size2; i++)
//        {
//            if (array2[i] > max2)
//            {
//                max2 = array2[i];
//                maxIndex2 = i;
//            }
//        }
//        array1[maxIndex1] = max2;
//        array2[maxIndex2] = max1;
//        Console.WriteLine("\nПервый массив после обмена: [" + string.Join(", ", array1) + "]");
//        Console.WriteLine("Второй массив после обмена: [" + string.Join(", ", array2) + "]");
//        double[] testArray1 = { 1.0, 3.0, 2.0, 5.0, 4.0 };
//        double[] testArray2 = { 6.0, 8.0, 7.0, 10.0, 9.0 };
//        double testMax1 = testArray1[0];
//        int testMaxIndex1 = 0;
//        for (int i = 1; i < testArray1.Length; i++)
//        {
//            if (testArray1[i] > testMax1)
//            {
//                testMax1 = testArray1[i];
//                testMaxIndex1 = i;
//            }
//        }
//        double testMax2 = testArray2[0];
//        int testMaxIndex2 = 0;
//        for (int i = 1; i < testArray2.Length; i++)
//        {
//            if (testArray2[i] > testMax2)
//            {
//                testMax2 = testArray2[i];
//                testMaxIndex2 = i;
//            }
//        }
//        testArray1[testMaxIndex1] = testMax2;
//        testArray2[testMaxIndex2] = testMax1;
//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Первый: [" + string.Join(", ", testArray1) + "]");
//        Console.WriteLine("Второй: [" + string.Join(", ", testArray2) + "]");
//    }
//}
//6.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.3: ");

//        Console.Write("Введите целое число в двоичной системе: ");
//        string binary = Console.ReadLine();

//        while (binary.Length % 4 != 0)
//        {
//            binary = "0" + binary;
//        }

//        string hex = "";
//        for (int i = 0; i < binary.Length; i += 4)
//        {
//            string group = binary.Substring(i, 4);
//            int val = Convert.ToInt32(group, 2);
//            hex += val.ToString("X");
//        }

//        Console.WriteLine($"\nШестнадцатеричное: {hex}");

//        string testBinary = "1010101010101010";
//        string testHex = "";
//        string padded = testBinary;
//        while (padded.Length % 4 != 0)
//        {
//            padded = "0" + padded;
//        }
//        for (int i = 0; i < padded.Length; i += 4)
//        {
//            string group = padded.Substring(i, 4);
//            int val = Convert.ToInt32(group, 2);
//            testHex += val.ToString("X");
//        }

//        Console.WriteLine("\nТестовый бинарный: " + testBinary);
//        Console.WriteLine("Шестнадцатеричное: " + testHex);
//    }
//}

//6.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.4: ");

//        Console.Write("Введите дробное число в двоичной системе: ");
//        string binary = Console.ReadLine();

//        string[] parts = binary.Split('.');
//        string intPart = parts[0];
//        string fracPart = parts.Length > 1 ? parts[1] : "";

//        double decimalVal = 0;

//        for (int i = 0; i < intPart.Length; i++)
//        {
//            if (intPart[intPart.Length - 1 - i] == '1')
//            {
//                decimalVal += Math.Pow(2, i);
//            }
//        }

//        for (int i = 0; i < fracPart.Length; i++)
//        {
//            if (fracPart[i] == '1')
//            {
//                decimalVal += Math.Pow(2, -(i + 1));
//            }
//        }

//        Console.WriteLine($"\nДесятичное: {decimalVal}");

//        string testBinary = "101.101";
//        string[] testParts = testBinary.Split('.');
//        string testIntPart = testParts[0];
//        string testFracPart = testParts.Length > 1 ? testParts[1] : "";
//        double testDecimalVal = 0;

//        for (int i = 0; i < testIntPart.Length; i++)
//        {
//            if (testIntPart[testIntPart.Length - 1 - i] == '1')
//            {
//                testDecimalVal += Math.Pow(2, i);
//            }
//        }

//        for (int i = 0; i < testFracPart.Length; i++)
//        {
//            if (testFracPart[i] == '1')
//            {
//                testDecimalVal += Math.Pow(2, -(i + 1));
//            }
//        }

//        Console.WriteLine("\nТестовый бинарный: " + testBinary);
//        Console.WriteLine("Десятичное: " + testDecimalVal);
//    }
//}

//6.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.5: ");

//        Console.Write("Введите дробное число в двоичной системе: ");
//        string binary = Console.ReadLine();

//        string[] parts = binary.Split('.');
//        string intPart = parts[0];
//        string fracPart = parts.Length > 1 ? parts[1] : "";

//        double decimalVal = 0;

//        for (int i = 0; i < intPart.Length; i++)
//        {
//            if (intPart[intPart.Length - 1 - i] == '1')
//            {
//                decimalVal += Math.Pow(2, i);
//            }
//        }

//        for (int i = 0; i < fracPart.Length; i++)
//        {
//            if (fracPart[i] == '1')
//            {
//                decimalVal += Math.Pow(2, -(i + 1));
//            }
//        }

//        string octal = Convert.ToString((long)decimalVal, 8);
//        if (fracPart.Length > 0)
//        {
//            octal += ".";
//            double frac = decimalVal - (long)decimalVal;
//            for (int i = 0; i < 10 && frac > 0; i++) // precision
//            {
//                frac *= 8;
//                octal += ((int)frac).ToString();
//                frac -= (int)frac;
//            }
//        }

//        Console.WriteLine($"\nВосьмеричное: {octal}");

//        string testBinary = "101.101";
//        similar conversion as above
//         assume same logic for test
//        Console.WriteLine("\nТестовый пример: реализовать аналогично.");
//    }
//}

//6.6
//empty, skip or assume similar

//6.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.7: ");

//        Console.Write("Введите дробное число в двоичной системе: ");
//        string binary = Console.ReadLine();

//        string[] parts = binary.Split('.');
//        string intPart = parts[0];
//        string fracPart = parts.Length > 1 ? parts[1] : "";

//        double decimalVal = 0;

//        for (int i = 0; i < intPart.Length; i++)
//        {
//            if (intPart[intPart.Length - 1 - i] == '1')
//            {
//                decimalVal += Math.Pow(2, i);
//            }
//        }

//        for (int i = 0; i < fracPart.Length; i++)
//        {
//            if (fracPart[i] == '1')
//            {
//                decimalVal += Math.Pow(2, -(i + 1));
//            }
//        }

//        string hex = Convert.ToString((long)decimalVal, 16).ToUpper();
//        if (fracPart.Length > 0)
//        {
//            hex += ".";
//            double frac = decimalVal - (long)decimalVal;
//            for (int i = 0; i < 10 && frac > 0; i++)
//            {
//                frac *= 16;
//                hex += ((int)frac).ToString("X");
//                frac -= (int)frac;
//            }
//        }

//        Console.WriteLine($"\nШестнадцатеричное: {hex}");


//    }
//}

//6.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.8: ");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 двузначных целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[15];
//        for (int i = 0; i < array.Length; i++)
//        {
//            int tens = array[i] / 10;
//            int ones = array[i] % 10;
//            newArray[i] = ones * 10 + tens;
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 25, 71, 84, 12, 34, 56, 78, 90, 13, 24, 35, 46, 57, 68, 79 };
//        int[] testNewArray = new int[15];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            int tens = testArray[i] / 10;
//            int ones = testArray[i] % 10;
//            testNewArray[i] = ones * 10 + tens;
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//6.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.9: ");

//        string[] array = new string[9];

//        Console.WriteLine("Введите 9 двузначных восьмеричных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        int[] newArray = new int[9];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = Convert.ToInt32(array[i], 8);
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        string[] testArray = { "10", "11", "12", "13", "14", "15", "16", "17", "20" };
//        int[] testNewArray = new int[9];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = Convert.ToInt32(testArray[i], 8);
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//6.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.10: ");

//        int[] array = new int[7];

//        Console.WriteLine("Введите 7 двузначных целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[7];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = array[i] / 10;
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 10, 21, 32, 43, 54, 65, 76 };
//        int[] testNewArray = new int[7];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = testArray[i] / 10;
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//6.11
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.11: ");

//        double[] array1 = new double[7];
//        double[] array2 = new double[9];

//        Console.WriteLine("Введите 7 вещественных чисел для первого массива:");
//        for (int i = 0; i < array1.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите 9 вещественных чисел для второго массива:");
//        for (int i = 0; i < array2.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = double.Parse(Console.ReadLine());
//        }

//        double[] third = array1.Concat(array2).OrderByDescending(x => x).ToArray();

//        Console.WriteLine("\nТретий массив: [" + string.Join(", ", third) + "]");

//        double[] testArray1 = { 7, 6, 5, 4, 3, 2, 1 };
//        double[] testArray2 = { 16, 15, 14, 13, 12, 11, 10, 9, 8 };
//        double[] testThird = testArray1.Concat(testArray2).OrderByDescending(x => x).ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Третий: [" + string.Join(", ", testThird) + "]");
//    }
//}

//6.12
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.12: ");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        var groups = array.GroupBy(x => x);
//        List<int> newList = new List<int>();
//        foreach (var group in groups)
//        {
//            if (group.Count() <= 2)
//            {
//                newList.AddRange(group);
//            }
//        }

//        int[] newArray = newList.ToArray();

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 0, 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 5 };
//        var testGroups = testArray.GroupBy(x => x);
//        List<int> testNewList = new List<int>();
//        foreach (var group in testGroups)
//        {
//            if (group.Count() <= 2)
//            {
//                testNewList.AddRange(group);
//            }
//        }

//        int[] testNewArray = testNewList.ToArray();

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}

//6.13
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.13: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> positions = new List<int>();
//        Dictionary<int, int> counts = new Dictionary<int, int>();
//        for (int i = 0; i < size; i++)
//        {
//            if (counts.ContainsKey(array[i]))
//            {
//                counts[array[i]]++;
//            }
//            else
//            {
//                counts[array[i]] = 1;
//            }
//        }

//        int dup = -1;
//        foreach (var kvp in counts)
//        {
//            if (kvp.Value == 2)
//            {
//                dup = kvp.Key;
//                break;
//            }
//        }

//        if (dup != -1)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                if (array[i] == dup)
//                {
//                    positions.Add(i);
//                }
//            }
//            Console.WriteLine("\nПозиции: " + string.Join(", ", positions));
//        }
//        else
//        {
//            Console.WriteLine("\nНет двух одинаковых элементов.");
//        }

//        int[] testArray = { 1, 2, 3, 4, 5, 3, 6, 7, 8, 9 };
//        similar logic for test
//    }
//}

//6.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.14: ");

//        Console.Write("Введите двоичное число: ");
//        string binary = Console.ReadLine();

//        string shifted = binary.Substring(2) + binary.Substring(0, 2);

//        long original = Convert.ToInt64(binary, 2);
//        long newVal = Convert.ToInt64(shifted, 2);

//        long diff = original - newVal;

//        Console.WriteLine("\nСдвинутое: " + shifted);
//        Console.WriteLine("Разность: " + diff);

//        string testBinary = "101010";
//        string testShifted = testBinary.Substring(2) + testBinary.Substring(0, 2);
//        long testOriginal = Convert.ToInt64(testBinary, 2);
//        long testNewVal = Convert.ToInt64(testShifted, 2);
//        long testDiff = testOriginal - testNewVal;

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Разность: " + testDiff);
//    }
//}

//6.15
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.15: ");

//        Console.Write("Введите количество элементов: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] binaries = new string[size];

//        Console.WriteLine("Введите двоичные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            binaries[i] = Console.ReadLine();
//        }

//        var sorted = binaries.OrderByDescending(b => Convert.ToInt64(b, 2)).ToArray();

//        long sum = 0;
//        for (int i = 0; i < size; i++)
//        {
//            sum += Convert.ToInt64(sorted[i], 2);
//        }

//        Console.WriteLine("\nОтсортированный: [" + string.Join(", ", sorted) + "]");
//        Console.WriteLine("Сумма: " + sum);


//    }
//}

//6.16
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6.16: ");

//        Console.Write("Введите количество элементов: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] binaries = new string[size];

//        Console.WriteLine("Введите двоичные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            binaries[i] = Console.ReadLine();
//        }

//        var sorted = binaries.OrderBy(b => Convert.ToInt64(b, 2)).ToArray();

//        double sum = 0;
//        for (int i = 0; i < size; i++)
//        {
//            sum += Convert.ToInt64(sorted[i], 2);
//        }
//        double avg = sum / size;

//        Console.WriteLine("\nОтсортированный: [" + string.Join(", ", sorted) + "]");
//        Console.WriteLine("Среднее: " + avg);


//    }
//}
//7.17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.17: ");

//        Console.Write("Введите бинарное число: ");
//        string binary = Console.ReadLine();

//        string shifted = binary[binary.Length - 1] + binary.Substring(0, binary.Length - 1);

//        long original = Convert.ToInt64(binary, 2);
//        long newVal = Convert.ToInt64(shifted, 2);

//        long sum = original + newVal;

//        Console.WriteLine("\nСдвинутое: " + shifted);
//        Console.WriteLine("Сумма: " + sum);

//        string testBinary = "10101";
//        string testShifted = testBinary[testBinary.Length - 1] + testBinary.Substring(0, testBinary.Length - 1);
//        long testOriginal = Convert.ToInt64(testBinary, 2);
//        long testNewVal = Convert.ToInt64(testShifted, 2);
//        long testSum = testOriginal + testNewVal;

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Сумма: " + testSum);
//    }
//}

//7.18
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.18: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int incSum = 0;
//        int decSum = 0;

//        for (int i = 1; i < size; i++)
//        {
//            if (array[i] > array[i - 1])
//            {
//                incSum += array[i - 1] + array[i];
//                int j = i + 1;
//                while (j < size && array[j] > array[j - 1])
//                {
//                    incSum += array[j];
//                    j++;
//                }
//                i = j - 1;
//            }
//            else if (array[i] < array[i - 1])
//            {
//                decSum += array[i - 1] + array[i];
//                int j = i + 1;
//                while (j < size && array[j] < array[j - 1])
//                {
//                    decSum += array[j];
//                    j++;
//                }
//                i = j - 1;
//            }
//        }

//        int diff = incSum - decSum;

//        Console.WriteLine("\nРазность: " + diff);

//        int[] testArray = { 1, 3, 5, 4, 2, 6, 8, 7, 9 };
//        int testIncSum = 0;
//        int testDecSum = 0;

//        for (int i = 1; i < testArray.Length; i++)
//        {
//            if (testArray[i] > testArray[i - 1])
//            {
//                testIncSum += testArray[i - 1] + testArray[i];
//                int j = i + 1;
//                while (j < testArray.Length && testArray[j] > testArray[j - 1])
//                {
//                    testIncSum += testArray[j];
//                    j++;
//                }
//                i = j - 1;
//            }
//            else if (testArray[i] < testArray[i - 1])
//            {
//                testDecSum += testArray[i - 1] + testArray[i];
//                int j = i + 1;
//                while (j < testArray.Length && testArray[j] < testArray[j - 1])
//                {
//                    testDecSum += testArray[j];
//                    j++;
//                }
//                i = j - 1;
//            }
//        }

//        int testDiff = testIncSum - testDecSum;

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Разность: " + testDiff);
//    }
//}

//7.19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.19: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        if (size < 2)
//        {
//            Console.WriteLine("\nНе образуют.");
//            return;
//        }

//        int diff = array[1] - array[0];
//        bool isAP = true;

//        for (int i = 2; i < size; i++)
//        {
//            if (array[i] - array[i - 1] != diff)
//            {
//                isAP = false;
//                break;
//            }
//        }

//        if (isAP)
//        {
//            Console.WriteLine("\nРазность: " + diff);
//        }
//        else
//        {
//            Console.WriteLine("\nНе образуют.");
//        }

//        int[] testArray = { 2, 4, 6, 8, 10 };
//        int testDiff = testArray[1] - testArray[0];
//        bool testIsAP = true;
//        for (int i = 2; i < testArray.Length; i++)
//        {
//            if (testArray[i] - testArray[i - 1] != testDiff)
//            {
//                testIsAP = false;
//                break;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        if (testIsAP)
//        {
//            Console.WriteLine("Разность: " + testDiff);
//        }
//        else
//        {
//            Console.WriteLine("Не образуют.");
//        }
//    }
//}

//7.20
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.20: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        if (size < 2 || array[0] == 0)
//        {
//            Console.WriteLine("\nНе образуют.");
//            return;
//        }

//        double ratio = array[1] / array[0];
//        bool isGP = true;

//        for (int i = 2; i < size; i++)
//        {
//            if (array[i - 1] == 0 || array[i] / array[i - 1] != ratio)
//            {
//                isGP = false;
//                break;
//            }
//        }

//        if (isGP)
//        {
//            Console.WriteLine("\nЗнаменатель: " + ratio);
//        }
//        else
//        {
//            Console.WriteLine("\nНе образуют.");
//        }

//        double[] testArray = { 2, 4, 8, 16, 32 };
//        double testRatio = testArray[1] / testArray[0];
//        bool testIsGP = true;
//        for (int i = 2; i < testArray.Length; i++)
//        {
//            if (testArray[i - 1] == 0 || testArray[i] / testArray[i - 1] != testRatio)
//            {
//                testIsGP = false;
//                break;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        if (testIsGP)
//        {
//            Console.WriteLine("Знаменатель: " + testRatio);
//        }
//        else
//        {
//            Console.WriteLine("Не образуют.");
//        }
//    }
//}

//7.21
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.21: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        int[] array = new int[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> indices = new List<int>();

//        for (int i = 0; i < size; i++)
//        {
//            bool greater = true;
//            for (int j = i + 1; j < size; j++)
//            {
//                if (array[i] <= array[j])
//                {
//                    greater = false;
//                    break;
//                }
//            }
//            if (greater)
//            {
//                indices.Add(i);
//            }
//        }

//        Console.WriteLine("\nИндексы: " + string.Join(", ", indices));
//        Console.WriteLine("Количество: " + indices.Count);

//        int[] testArray = { 5, 4, 6, 3, 7, 2, 8, 1, 9, 0 };
//        List<int> testIndices = new List<int>();

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            bool greater = true;
//            for (int j = i + 1; j < testArray.Length; j++)
//            {
//                if (testArray[i] <= testArray[j])
//                {
//                    greater = false;
//                    break;
//                }
//            }
//            if (greater)
//            {
//                testIndices.Add(i);
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        Console.WriteLine("Индексы: " + string.Join(", ", testIndices));
//        Console.WriteLine("Количество: " + testIndices.Count);
//    }
//}

//7.22
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.22: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int lastIndex = -1;

//        for (int i = 1; i < size - 1; i++)
//        {
//            if (array[i - 1] < array[i] && array[i] > array[i + 1])
//            {
//                lastIndex = i;
//            }
//        }

//        if (lastIndex != -1)
//        {
//            Console.WriteLine("\nНомер: " + lastIndex);
//        }
//        else
//        {
//            Console.WriteLine("\nТаких нет.");
//        }

//        double[] testArray = { 1, 3, 2, 4, 5, 6, 7, 9, 8, 10 };
//        int testLastIndex = -1;

//        for (int i = 1; i < testArray.Length - 1; i++)
//        {
//            if (testArray[i - 1] < testArray[i] && testArray[i] > testArray[i + 1])
//            {
//                testLastIndex = i;
//            }
//        }

//        Console.WriteLine("\nТестовый массив: [" + string.Join(", ", testArray) + "]");
//        if (testLastIndex != -1)
//        {
//            Console.WriteLine("Номер: " + testLastIndex);
//        }
//        else
//        {
//            Console.WriteLine("Таких нет.");
//        }
//    }
//}

//7.23
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.23: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        long[] array = new long[size];

//        Console.WriteLine("Введите бинарные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            string bin = Console.ReadLine();
//            array[i] = Convert.ToInt64(bin, 2);
//        }

//        long min = array.Min();
//        long max = array.Max();
//        int minIndex = Array.IndexOf(array, min);
//        int maxIndex = Array.IndexOf(array, max);
//        int start = Math.Min(minIndex, maxIndex) + 1;
//        int end = Math.Max(minIndex, maxIndex) - 1;
//        int count = end - start + 1;

//        if (count > 0)
//        {
//            Console.WriteLine("\nКоличество: " + count);
//        }
//        else
//        {
//            Console.WriteLine("\nТаких чисел нет.");
//        }

//        string[] testBins = { "1", "10", "11", "100", "101" };
//        long[] testArray = new long[5];
//        for (int i = 0; i < testBins.Length; i++)
//        {
//            testArray[i] = Convert.ToInt64(testBins[i], 2);
//        }
//        long testMin = testArray.Min();
//        long testMax = testArray.Max();
//        int testMinIndex = Array.IndexOf(testArray, testMin);
//        int testMaxIndex = Array.IndexOf(testArray, testMax);
//        int testStart = Math.Min(testMinIndex, testMaxIndex) + 1;
//        int testEnd = Math.Max(testMinIndex, testMaxIndex) - 1;
//        int testCount = testEnd - testStart + 1;

//        Console.WriteLine("\nТестовый массив (десятичные): [" + string.Join(", ", testArray) + "]");
//        if (testCount > 0)
//        {
//            Console.WriteLine("Количество: " + testCount);
//        }
//        else
//        {
//            Console.WriteLine("Таких нет.");
//        }
//    }
//}

//7.24
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.24: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] array = new string[size];

//        Console.WriteLine("Введите бинарные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        string temp = array[size - 1];
//        for (int i = size - 1; i > 0; i--)
//        {
//            array[i] = array[i - 1];
//        }
//        array[0] = temp;

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");

//        string[] testArray = { "1", "10", "11", "100", "101" };
//        string testTemp = testArray[testArray.Length - 1];
//        for (int i = testArray.Length - 1; i > 0; i--)
//        {
//            testArray[i] = testArray[i - 1];
//        }
//        testArray[0] = testTemp;

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testArray) + "]");
//    }
//}

//7.25
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.25: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] array = new string[size];

//        Console.WriteLine("Введите бинарные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        long sumBefore = 0;
//        for (int i = 0; i < size; i++)
//        {
//            sumBefore += Convert.ToInt64(array[i], 2);
//        }

//        string temp = array[0];
//        for (int i = 0; i < size - 1; i++)
//        {
//            array[i] = array[i + 1];
//        }
//        array[size - 1] = temp;

//        long sumAfter = 0;
//        for (int i = 0; i < size; i++)
//        {
//            sumAfter += Convert.ToInt64(array[i], 2);
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine("Сумма до: " + sumBefore);
//        Console.WriteLine("Сумма после: " + sumAfter);

//        string[] testArray = { "1", "10", "11", "100", "101" };
//        long testSumBefore = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testSumBefore += Convert.ToInt64(testArray[i], 2);
//        }
//        string testTemp = testArray[0];
//        for (int i = 0; i < testArray.Length - 1; i++)
//        {
//            testArray[i] = testArray[i + 1];
//        }
//        testArray[testArray.Length - 1] = testTemp;
//        long testSumAfter = 0;
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testSumAfter += Convert.ToInt64(testArray[i], 2);
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Сумма до: " + testSumBefore);
//        Console.WriteLine("Сумма после: " + testSumAfter);
//    }
//}

//7.26
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.26: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] array = new string[size];

//        Console.WriteLine("Введите бинарные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        long add = Convert.ToInt64("1010", 2);

//        for (int i = 0; i < size; i++)
//        {
//            long val = Convert.ToInt64(array[i], 2);
//            val += add;
//            array[i] = Convert.ToString(val, 2);
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", array) + "]");

//        string[] testArray = { "1", "10", "11", "100", "101" };
//        long testAdd = Convert.ToInt64("1010", 2);
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            long val = Convert.ToInt64(testArray[i], 2);
//            val += testAdd;
//            testArray[i] = Convert.ToString(val, 2);
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testArray) + "]");
//    }
//}

//7.27
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.27: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        double[] array = new double[size];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        Console.Write("Введите R: ");
//        double r = double.Parse(Console.ReadLine());

//        double minDist = double.MaxValue;
//        double value = 0;
//        int index = -1;

//        for (int i = 0; i < size; i++)
//        {
//            double dist = Math.Abs(array[i] - r);
//            if (dist < minDist)
//            {
//                minDist = dist;
//                value = array[i];
//                index = i;
//            }
//        }

//        Console.WriteLine("\nЗначение: " + value + ", Индекс: " + index);

//        double[] testArray = { 1.0, 2.5, 3.0, 4.5, 5.0 };
//        double testR = 3.2;
//        double testMinDist = double.MaxValue;
//        double testValue = 0;
//        int testIndex = -1;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            double dist = Math.Abs(testArray[i] - testR);
//            if (dist < testMinDist)
//            {
//                testMinDist = dist;
//                testValue = testArray[i];
//                testIndex = i;
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Значение: " + testValue + ", Индекс: " + testIndex);
//    }
//}

//7.28
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.28: ");

//        Console.Write("Введите размер массива: ");
//        int size = int.Parse(Console.ReadLine());
//        string[] array = new string[size];

//        Console.WriteLine("Введите бинарные числа:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        Console.Write("Введите D (бинарное): ");
//        string dStr = Console.ReadLine();
//        long d = Convert.ToInt64(dStr, 2);

//        long maxDist = 0;
//        long value = 0;
//        int index = -1;

//        for (int i = 0; i < size; i++)
//        {
//            long val = Convert.ToInt64(array[i], 2);
//            long dist = Math.Abs(val - d);
//            if (dist > maxDist)
//            {
//                maxDist = dist;
//                value = val;
//                index = i;
//            }
//        }

//        Console.WriteLine("\nЗначение (десятичное): " + value + ", Индекс: " + index);

//        string[] testArray = { "1", "10", "11", "100", "101" };
//        string testDStr = "11";
//        long testD = Convert.ToInt64(testDStr, 2);
//        long testMaxDist = 0;
//        long testValue = 0;
//        int testIndex = -1;

//        for (int i = 0; i < testArray.Length; i++)
//        {
//            long val = Convert.ToInt64(testArray[i], 2);
//            long dist = Math.Abs(val - testD);
//            if (dist > testMaxDist)
//            {
//                testMaxDist = dist;
//                testValue = val;
//                testIndex = i;
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Значение: " + testValue + ", Индекс: " + testIndex);
//    }
//}

//7.29
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.29: ");

//        Console.Write("Введите положительное бинарное: ");
//        string pos = Console.ReadLine();
//        Console.Write("Введите отрицательное бинарное: ");
//        string neg = Console.ReadLine();

//        long posVal = Convert.ToInt64(pos, 2);
//        long negVal = Convert.ToInt64(neg, 2); // assuming neg is given as positive binary but represents negative

//        long sum = posVal + negVal;

//        Console.WriteLine("\nСумма (десятичная): " + sum);

//        string testPos = "1010";
//        string testNeg = "101"; // assume -5 in binary as 101 for magnitude
//        long testPosVal = Convert.ToInt64(testPos, 2);
//        long testNegVal = -Convert.ToInt64(testNeg, 2);
//        long testSum = testPosVal + testNegVal;

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Сумма: " + testSum);
//    }
//}

//7.30
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7.30: ");

//        int[] array = new int[3];

//        Console.WriteLine("Введите 3 десятичных числа:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        string[] newArray = new string[3];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = Convert.ToString(array[i], 2);
//        }

//        Console.WriteLine("\nНовый массив: [" + string.Join(", ", newArray) + "]");

//        int[] testArray = { 10, 20, 30 };
//        string[] testNewArray = new string[3];
//        for (int i = 0; i < testArray.Length; i++)
//        {
//            testNewArray[i] = Convert.ToString(testArray[i], 2);
//        }

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Новый: [" + string.Join(", ", testNewArray) + "]");
//    }
//}
//8.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.1: ");

//        int[,] matrix = new int[3, 4];

//        Console.WriteLine("Введите элементы матрицы 3x4:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        SortLastRow(matrix);

//        Console.WriteLine("\nМатрица после сортировки последней строки:");
//        PrintMatrix(matrix);

//        int[,] testMatrix = {
//            {4, 3, 2, 1},
//            {8, 7, 6, 5},
//            {12, 11, 10, 9}
//        };

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("Исходная:");
//        PrintMatrix(testMatrix);

//        SortLastRow(testMatrix);

//        Console.WriteLine("После сортировки:");
//        PrintMatrix(testMatrix);
//    }

//    static void SortLastRow(int[,] matrix)
//    {
//        int cols = matrix.GetLength(1);
//        int lastRow = matrix.GetLength(0) - 1;

//        for (int i = 0; i < cols - 1; i++)
//        {
//            for (int j = 0; j < cols - 1 - i; j++)
//            {
//                if (matrix[lastRow, j] > matrix[lastRow, j + 1])
//                {
//                    int temp = matrix[lastRow, j];
//                    matrix[lastRow, j] = matrix[lastRow, j + 1];
//                    matrix[lastRow, j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.2: ");

//        int[,] matrix = new int[7, 7];

//        Console.WriteLine("Введите элементы матрицы 7x7:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        int sum = 0;

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (matrix[i, j] < 0 && Math.Abs(matrix[i, j]) % 2 != 0)
//                {
//                    sum += Math.Abs(matrix[i, j]);
//                }
//            }
//        }

//        Console.WriteLine($"\nСумма: {sum}");

//        int[,] testMatrix = new int[7, 7];
//        Random rand = new Random();
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                testMatrix[i, j] = rand.Next(-10, 11);
//            }
//        }

//        int testSum = 0;

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (testMatrix[i, j] < 0 && Math.Abs(testMatrix[i, j]) % 2 != 0)
//                {
//                    testSum += Math.Abs(testMatrix[i, j]);
//                }
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        PrintMatrix(testMatrix);
//        Console.WriteLine($"Сумма: {testSum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.3: ");

//        int[,] matrix = new int[5, 6];

//        Console.WriteLine("Введите элементы матрицы 5x6:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        Console.WriteLine("\nСредние положительных по столбцам:");
//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            int count = 0;

//            for (int i = 0; i < 5; i++)
//            {
//                if (matrix[i, j] > 0)
//                {
//                    sum += matrix[i, j];
//                    count++;
//                }
//            }

//            if (count > 0)
//            {
//                double avg = (double)sum / count;
//                Console.WriteLine($"Столбец {j}: {avg:F2}");
//            }
//            else
//            {
//                Console.WriteLine($"Столбец {j}: нет положительных");
//            }
//        }

//        int[,] testMatrix = new int[5, 6];
//        Random rand = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                testMatrix[i, j] = rand.Next(-5, 6);
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        PrintMatrix(testMatrix);

//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            int count = 0;

//            for (int i = 0; i < 5; i++)
//            {
//                if (testMatrix[i, j] > 0)
//                {
//                    sum += testMatrix[i, j];
//                    count++;
//                }
//            }

//            if (count > 0)
//            {
//                double avg = (double)sum / count;
//                Console.WriteLine($"Столбец {j}: {avg:F2}");
//            }
//            else
//            {
//                Console.WriteLine($"Столбец {j}: нет");
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.4: ");

//        double[,] matrix = new double[5, 5];

//        Console.WriteLine("Введите элементы матрицы 5x5:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = double.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        double min = matrix[0, 4];
//        for (int i = 1; i < 5; i++)
//        {
//            if (matrix[i, 4 - i] < min)
//            {
//                min = matrix[i, 4 - i];
//            }
//        }

//        Console.WriteLine("\nНаименьший на побочной диагонали: " + min);

//        double[,] testMatrix = new double[5, 5];
//        Random rand = new Random();
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                testMatrix[i, j] = rand.NextDouble() * 20 - 10;
//            }
//        }

//        double testMin = testMatrix[0, 4];
//        for (int i = 1; i < 5; i++)
//        {
//            if (testMatrix[i, 4 - i] < testMin)
//            {
//                testMin = testMatrix[i, 4 - i];
//            }
//        }

//        Console.WriteLine("\nТестовый пример:");
//        PrintMatrix(testMatrix);
//        Console.WriteLine("Наименьший: " + testMin);
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j]:F2,7}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.5: ");

//        int[,] matrix = new int[5, 4];

//        Console.WriteLine("Введите элементы матрицы 5x4:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        SortLastColumnDescending(matrix);

//        Console.WriteLine("\nМатрица после сортировки последнего столбца по убыванию:");
//        PrintMatrix(matrix);

//        int[,] testMatrix = {
//            {1, 2, 3, 4},
//            {5, 6, 7, 8},
//            {9, 10, 11, 12},
//            {13, 14, 15, 16},
//            {17, 18, 19, 20}
//        };

//        Console.WriteLine("\nТестовый пример:");
//        PrintMatrix(testMatrix);

//        SortLastColumnDescending(testMatrix);

//        PrintMatrix(testMatrix);
//    }

//    static void SortLastColumnDescending(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int lastCol = matrix.GetLength(1) - 1;

//        for (int i = 0; i < rows - 1; i++)
//        {
//            for (int j = 0; j < rows - 1 - i; j++)
//            {
//                if (matrix[j, lastCol] < matrix[j + 1, lastCol])
//                {
//                    for (int k = 0; k < matrix.GetLength(1); k++)
//                    {
//                        int temp = matrix[j, k];
//                        matrix[j, k] = matrix[j + 1, k];
//                        matrix[j + 1, k] = temp;
//                    }
//                }
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.6: ");

//        int[,] matrix = new int[4, 3];

//        Console.WriteLine("Введите элементы матрицы 4x3:");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        int maxCol0 = matrix[0, 0];
//        int maxRow0 = 0;
//        for (int i = 1; i < 4; i++)
//        {
//            if (matrix[i, 0] > maxCol0)
//            {
//                maxCol0 = matrix[i, 0];
//                maxRow0 = i;
//            }
//        }

//        int maxCol2 = matrix[0, 2];
//        int maxRow2 = 0;
//        for (int i = 1; i < 4; i++)
//        {
//            if (matrix[i, 2] > maxCol2)
//            {
//                maxCol2 = matrix[i, 2];
//                maxRow2 = i;
//            }
//        }

//        int temp = matrix[maxRow0, 0];
//        matrix[maxRow0, 0] = matrix[maxRow2, 2];
//        matrix[maxRow2, 2] = temp;

//        Console.WriteLine("\nПосле обмена:");
//        PrintMatrix(matrix);

//        int[,] testMatrix = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9},
//            {10, 11, 12}
//        };

//        similar max find and swap for test

//       Console.WriteLine("\nТестовый пример:");
//       PrintMatrix(testMatrix);
//        assume swap code

//        Print after
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.7: ");

//        int[,] matrix = new int[3, 4];

//        Console.WriteLine("Введите элементы матрицы 3x4:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        int minRow0 = matrix[0, 0];
//        int minCol0 = 0;
//        for (int j = 1; j < 4; j++)
//        {
//            if (matrix[0, j] < minRow0)
//            {
//                minRow0 = matrix[0, j];
//                minCol0 = j;
//            }
//        }

//        int minRow2 = matrix[2, 0];
//        int minCol2 = 0;
//        for (int j = 1; j < 4; j++)
//        {
//            if (matrix[2, j] < minRow2)
//            {
//                minRow2 = matrix[2, j];
//                minCol2 = j;
//            }
//        }

//        int temp = matrix[0, minCol0];
//        matrix[0, minCol0] = matrix[2, minCol2];
//        matrix[2, minCol2] = temp;

//        Console.WriteLine("\nПосле обмена:");
//        PrintMatrix(matrix);


//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.8: ");

//        Console.Write("Введите N (<=10): ");
//        int n = int.Parse(Console.ReadLine());
//        double[,] matrix = new double[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = double.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        double product = 1;

//        for (int j = 0; j < n; j++)
//        {
//            double min = matrix[0, j];
//            for (int i = 1; i < n; i++)
//            {
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                }
//            }
//            product *= min;
//        }

//        Console.WriteLine("\nПроизведение: " + product);

//        test with n = 2 or something
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j]:F2,7}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.9: ");

//        int[,] matrix = new int[5, 6];

//        Console.WriteLine("Введите элементы матрицы 5x6:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        Console.WriteLine("\nСредние столбцов:");
//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                sum += matrix[i, j];
//            }
//            double avg = (double)sum / 5;
//            Console.WriteLine($"Столбец {j}: {avg:F2}");
//        }

//        Console.WriteLine("\nМакс и мин строк:");
//        for (int i = 0; i < 5; i++)
//        {
//            int max = matrix[i, 0];
//            int min = matrix[i, 0];
//            for (int j = 1; j < 6; j++)
//            {
//                if (matrix[i, j] > max) max = matrix[i, j];
//                if (matrix[i, j] < min) min = matrix[i, j];
//            }
//            Console.WriteLine($"Строка {i}: max={max}, min={min}");
//        }


//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.10: ");

//        int[,] matrix = new int[7, 8];

//        Console.WriteLine("Введите элементы матрицы 7x8:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        Console.WriteLine("\nКоличество нечетных по столбцам:");
//        for (int j = 0; j < 8; j++)
//        {
//            int count = 0;
//            for (int i = 0; i < 7; i++)
//            {
//                if (matrix[i, j] % 2 != 0)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine($"Столбец {j}: {count}");
//        }


//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//8.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.11: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int even = 0;
//        int odd = 0;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] % 2 == 0) even++;
//                else odd++;
//            }
//        }

//        Console.WriteLine("\nЧетных: " + even);
//        Console.WriteLine("Нечетных: " + odd);


//    }
//}

//8.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.12: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int count = 0;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] == 7) count++;
//            }
//        }

//        Console.WriteLine("\nКоличество 7: " + count);


//    }
//}

//8.13
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.13: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nМакс по столбцам:");
//        for (int j = 0; j < m; j++)
//        {
//            int max = matrix[0, j];
//            for (int i = 1; i < n; i++)
//            {
//                if (matrix[i, j] > max) max = matrix[i, j];
//            }
//            Console.WriteLine($"Столбец {j}: {max}");
//        }


//    }
//}

//8.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.14: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int min = matrix[0, 0];
//        int minRow = 0;
//        int minCol = 0;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//            }
//        }

//        Console.WriteLine("\nИндекс первого min: [{minRow},{minCol}]");


//    }
//}

//8.15
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.15: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum += matrix[i, n - 1];
//        }

//        Console.WriteLine("\nСумма последнего столбца: " + sum);


//    }
//}

//8.16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.16: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        long product = 1;
//        for (int j = 0; j < n; j++)
//        {
//            product *= matrix[0, j];
//        }

//        Console.WriteLine("\nПроизведение первой строки: " + product);


//    }
//}

//8.17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.17: ");

//        int[,] matrix = new int[10, 10];

//        Console.WriteLine("Введите элементы матрицы 10x10:");
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nСуммы строк:");
//        for (int i = 0; i < 10; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 10; j++)
//            {
//                sum += matrix[i, j];
//            }
//            Console.WriteLine($"Строка {i}: {sum}");
//        }


//    }
//}

//8.18
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8.18: ");

//        int[,] matrix = new int[4, 4];

//        Console.WriteLine("Введите элементы матрицы 4x4:");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int minSum = int.MaxValue;
//        int minRow = -1;

//        for (int i = 0; i < 4; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 4; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//                minRow = i;
//            }
//        }

//        Console.WriteLine("\nСтрока с наименьшей суммой: " + minRow);


//    }
//}

//9.19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.19: ");

//        int[,] matrix = new int[7, 7];

//        Console.WriteLine("Введите элементы матрицы 7x7:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int maxSum = int.MinValue;
//        int maxRow = -1;

//        for (int i = 0; i < 7; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 7; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum > maxSum)
//            {
//                maxSum = sum;
//                maxRow = i;
//            }
//        }

//        Console.WriteLine("\nСтрока с наибольшей суммой: " + maxRow);


//    }
//}

//9.20
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.20: ");

//        int[,] matrix = new int[6, 8];

//        Console.WriteLine("Введите элементы матрицы 6x8:");
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        long product = 1;

//        for (int i = 0; i < 6; i++)
//        {
//            if (matrix[i, 0] > 0)
//            {
//                product *= matrix[i, 0];
//            }
//        }

//        Console.WriteLine("\nПроизведение положительных первого столбца: " + product);


//    }
//}

//9.21
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.21: ");

//        int[,] matrix = new int[4, 6];

//        Console.WriteLine("Введите элементы матрицы 4x6:");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nСуммы столбцов:");
//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                sum += matrix[i, j];
//            }
//            Console.WriteLine($"Столбец {j}: {sum}");
//        }


//    }
//}

//9.22
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.22: ");

//        int[,] matrix = new int[5, 10];

//        Console.WriteLine("Введите элементы матрицы 5x10:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int minSum = int.MaxValue;

//        for (int i = 0; i < 5; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 10; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//            }
//        }

//        Console.WriteLine("\nМинимальная сумма строки: " + minSum);


//    }
//}

//9.23
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.23: ");

//        int[,] matrix = new int[4, 5];

//        Console.WriteLine("Введите элементы матрицы 4x5:");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sum = 0;
//        int count = 0;

//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                sum += matrix[i, j];
//                count++;
//            }
//        }

//        double avg = (double)sum / count;

//        int greaterCount = 0;

//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (matrix[i, j] > avg) greaterCount++;
//            }
//        }

//        Console.WriteLine("\nКоличество превосходящих среднее: " + greaterCount);


//    }
//}

//9.24
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.24: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите M: ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sum = 0;

//        if (n >= 2)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                sum += matrix[1, j];
//            }
//        }

//        Console.WriteLine("\nСумма второй строки: " + sum);


//    }
//}

//9.25
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.25: ");

//        int[,] matrix = new int[5, 5];

//        Console.WriteLine("Введите элементы матрицы 5x5:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int count = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            if (matrix[i, 1] < 0) count++;
//        }

//        Console.WriteLine("\nКоличество отрицательных во втором столбце: " + count);


//    }
//}

//9.26
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.26: ");

//        int[,] matrix = new int[3, 7];

//        Console.WriteLine("Введите элементы матрицы 3x7:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nКоличество элементов по столбцам:");
//        for (int j = 0; j < 7; j++)
//        {
//            Console.WriteLine($"Столбец {j}: 3"); // since 3 rows
//        }


//    }
//}

//9.27
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.27: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sum = 0;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] % 2 != 0) sum += matrix[i, j];
//            }
//        }

//        Console.WriteLine("\nСумма нечетных: " + sum);


//    }
//}

//9.28
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.28: ");

//        int[,] matrix = new int[5, 5];

//        Console.WriteLine("Введите элементы матрицы 5x5:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        for (int j = 0; j < 5; j++)
//        {
//            int temp = matrix[3, j];
//            matrix[3, j] = matrix[4, j];
//            matrix[4, j] = temp;
//        }

//        Console.WriteLine("\nПосле перестановки 4 и 5 строки:");
//        PrintMatrix(matrix);


//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//9.29
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.29: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int minSum = int.MaxValue;
//        int minCol = -1;

//        for (int j = 0; j < m; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//                minCol = j;
//            }
//        }

//        Console.WriteLine("\nСтолбец с наименьшей суммой: " + minCol);

//    }
//}

//9.30
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9.30: ");

//        Console.Write("Введите строки (n): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите столбцы (m): ");
//        int m = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int count = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (matrix[i, 1] >= 0) count++;
//        }

//        Console.WriteLine("\nКоличество неотрицательных во втором столбце: " + count);

//    }
//}
//10.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.3: ");

//        int[,] A = {
//            {01, 02, 03, 04},
//            {12, 13, 14, 05},
//            {11, 16, 15, 06},
//            {10, 09, 08, 07}
//        };

//        Console.WriteLine("Матрица A:");
//        PrintMatrix(A);

//        Console.WriteLine("\nПосле вывода - массив должен иметь вид:");
//        Console.WriteLine("01 02 03 04");
//        Console.WriteLine("12 13 14 05");
//        Console.WriteLine("11 16 15 06");
//        Console.WriteLine("10 09 08 07");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:D2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.4
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.4: ");

//        Console.Write("Введите n (строки): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m (столбцы): ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(A);

//        var rowsToRemove = new System.Collections.Generic.List<int>();
//        for (int i = 0; i < n; i++)
//        {
//            bool hasPositive = false;
//            for (int j = 0; j < m; j++)
//            {
//                if (A[i, j] > 0)
//                {
//                    hasPositive = true;
//                    break;
//                }
//            }
//            if (!hasPositive)
//            {
//                rowsToRemove.Add(i);
//            }
//        }

//        int newRowCount = n - rowsToRemove.Count;
//        int[,] result = new int[newRowCount, m];
//        int newRow = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (!rowsToRemove.Contains(i))
//            {
//                for (int j = 0; j < m; j++)
//                {
//                    result[newRow, j] = A[i, j];
//                }
//                newRow++;
//            }
//        }

//        Console.WriteLine("\nМатрица после удаления строк без положительных:");
//        PrintMatrix(result);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.5: ");

//        int[,] matrix = new int[3, 3];
//        int value = 7;

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                matrix[i, j] = value;
//                value--;
//                if (value < 1) value = 9;
//            }
//        }

//        Console.WriteLine("Матрица 3x3 по спирали начиная с 7 8 9:");
//        PrintMatrix(matrix);

//        int[,] test = {
//            {7, 8, 9},
//            {6, 1, 2},
//            {5, 4, 3}
//        };
//        Console.WriteLine("\nОжидаемый результат:");
//        PrintMatrix(test);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],3}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.6: ");

//        Random rand = new Random();
//        int[,] A = new int[4, 4];

//        Console.WriteLine("Матрица A (случайные числа):");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                A[i, j] = rand.Next(-10, 11);
//                Console.Write($"{A[i, j],4}");
//            }
//            Console.WriteLine();
//        }

//        int[,] B = new int[4, 4];
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                if (i == j)
//                {
//                    B[i, j] = 0;
//                }
//                else
//                {
//                    B[i, j] = A[i, j];
//                }
//            }
//        }

//        Console.WriteLine("\nМатрица B (главная диагональ = 0):");
//        PrintMatrix(B);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.7: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        int value = 1;
//        int top = 0, bottom = n - 1, left = 0, right = n - 1;

//        while (value <= n * n)
//        {
//            for (int j = left; j <= right; j++)
//                matrix[top, j] = value++;
//            top++;

//            for (int i = top; i <= bottom; i++)
//                matrix[i, right] = value++;
//            right--;

//            if (top <= bottom)
//            {
//                for (int j = right; j >= left; j--)
//                    matrix[bottom, j] = value++;
//                bottom--;
//            }

//            if (left <= right)
//            {
//                for (int i = bottom; i >= top; i--)
//                    matrix[i, left] = value++;
//                left++;
//            }
//        }

//        Console.WriteLine($"\nКвадратная матрица {n}x{n} по спирали:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int n = matrix.GetLength(0);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.8: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        int value = 1;
//        int top = 0, bottom = n - 1, left = 0, right = n - 1;
//        int direction = 0;

//        while (value <= n * n)
//        {
//            if (direction == 0)
//            {
//                for (int j = left; j <= right; j++)
//                    matrix[top, j] = value++;
//                top++;
//            }
//            else if (direction == 1)
//            {
//                for (int i = top; i <= bottom; i++)
//                    matrix[i, right] = value++;
//                right--;
//            }
//            else if (direction == 2)
//            {
//                for (int j = right; j >= left; j--)
//                    matrix[bottom, j] = value++;
//                bottom--;
//            }
//            else if (direction == 3)
//            {
//                for (int i = bottom; i >= top; i--)
//                    matrix[i, left] = value++;
//                left++;
//            }
//            direction = (direction + 1) % 4;
//        }

//        Console.WriteLine($"\nКвадратная матрица {n}x{n} по спирали (по часовой):");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int n = matrix.GetLength(0);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.9
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.9: ");

//        Console.Write("Введите n (строки): ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m (столбцы): ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы A:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] result = new int[n * m];
//        int k = 0;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                result[k++] = A[i, j];
//            }
//        }

//        Array.Sort(result);

//        Console.WriteLine("\nОдномерный массив из элементов A по возрастанию:");
//        Console.WriteLine("[" + string.Join(", ", result) + "]");
//    }
//}

//10.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.10: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы A(N,M):");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int B = int.MinValue;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (A[i, j] > B)
//                {
//                    B = A[i, j];
//                }
//            }
//        }

//        int count = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (A[i, j] == B)
//                {
//                    count++;
//                }
//            }
//        }

//        Console.WriteLine($"\nНаибольшее число B = {B}, встречается {count} раз(а).");
//    }
//}

//10.11
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.11: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы A(N,M):");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] rowAverages = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < m; j++)
//            {
//                sum += A[i, j];
//            }
//            rowAverages[i] = sum / m;
//        }

//        int[] result = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            result[i] = rowAverages[i];
//        }

//        Console.WriteLine("\nМассив средних арифметических строк:");
//        Console.WriteLine("[" + string.Join(", ", result) + "]");
//    }
//}

//10.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.12: ");

//        int[,] A = new int[5, 10];

//        Console.WriteLine("Введите элементы матрицы 5x10:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        double[,] result = new double[5, 10];

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                result[i, j] = (double)A[i, j] / 100;
//            }
//        }

//        Console.WriteLine("\nНовая матрица (каждый элемент / 100):");
//        PrintMatrix(result);
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:F2,8}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//10.13
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.13: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        List<int> minimalRows = new List<int>();
//        int globalMin = int.MaxValue;

//        for (int i = 0; i < n; i++)
//        {
//            int rowMin = A[i, 0];
//            for (int j = 1; j < m; j++)
//            {
//                if (A[i, j] < rowMin)
//                    rowMin = A[i, j];
//            }
//            if (rowMin < globalMin)
//            {
//                globalMin = rowMin;
//                minimalRows.Clear();
//                minimalRows.Add(i);
//            }
//            else if (rowMin == globalMin)
//            {
//                minimalRows.Add(i);
//            }
//        }

//        Console.WriteLine("\nСтроки с минимальным элементом:");
//        foreach (int row in minimalRows)
//        {
//            Console.WriteLine($"Строка {row}: минимальный элемент = {globalMin}");
//        }
//    }
//}

//10.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.14: ");

//        double[,] B = new double[5, 5];

//        Console.WriteLine("Введите элементы матрицы B[1..5,1..5]:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"B[{i + 1},{j + 1}]: ");
//                B[i, j] = double.Parse(Console.ReadLine());
//            }
//        }

//        double product = 1.0;
//        for (int i = 0; i < 5; i++)
//        {
//            product *= B[i, i];
//        }

//        Console.WriteLine($"\nПроизведение элементов главной диагонали: {product:F2}");
//    }
//}

//10.15
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.15: ");

//        double[,] B = new double[5, 5];

//        Console.WriteLine("Введите элементы матрицы B[1..5,1..5]:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"B[{i + 1},{j + 1}]: ");
//                B[i, j] = double.Parse(Console.ReadLine());
//            }
//        }

//        double sum = 0.0;
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (i + j < 5 - 1)
//                {
//                    sum += B[i, j];
//                }
//            }
//        }

//        Console.WriteLine($"\nСумма элементов выше левой диагонали: {sum:F2}");
//    }
//}

//10.16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10.16: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[5, n];

//        Console.WriteLine("Введите элементы матрицы 5xn:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (matrix[i, j] < 0)
//                {
//                    matrix[i, j] = 0;
//                }
//            }
//        }

//        Console.WriteLine("\nМатрица после замены отрицательных на 0:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//11.17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.17: ");

//        int[,] matrix = new int[5, 5];

//        Console.WriteLine("Введите элементы матрицы 5x5:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int max = matrix[0, 0];
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (matrix[i, j] > max)
//                    max = matrix[i, j];
//            }
//        }

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] /= max;
//            }
//        }

//        Console.WriteLine("\nНовая матрица (каждый элемент / max):");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//11.18
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.18: ");

//        Console.Write("Введите M (строки): ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[m, 8];

//        Console.WriteLine("Введите элементы матрицы Mx8:");
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] nonZeroCounts = new int[m];

//        for (int i = 0; i < m; i++)
//        {
//            nonZeroCounts[i] = 8 - matrix.GetLength(1) + matrix.Row(i).Count(x => x != 0);
//            for (int j = 0; j < 8; j++)
//            {
//                if (matrix[i, j] != 0)
//                    nonZeroCounts[i]++;
//            }
//        }

//        Array.Sort(nonZeroCounts);
//        Array.Reverse(nonZeroCounts);

//        Console.WriteLine("\nСтроки отсортированы по убыванию количества ненулевых элементов:");
//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine($"Строка с {nonZeroCounts[i]} ненулевыми");
//        }
//    }
//}

//11.19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.19: ");

//        int[,] matrix = new int[8, 5];

//        Console.WriteLine("Введите элементы матрицы 8x5:");
//        for (int i = 0; i < 8; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sumAbove3 = 0;
//        int sumIn3 = 0;

//        for (int i = 0; i < 8; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (i < 3)
//                    sumAbove3 += matrix[i, j];
//                else if (i == 3)
//                    sumIn3 += matrix[i, j];
//            }
//        }

//        Console.WriteLine($"\nСумма всех элементов второго столбца до 3-й строки: {sumAbove3}");
//        Console.WriteLine($"Сумма всех элементов 3-й строки: {sumIn3}");
//    }
//}

//11.20
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.20: ");

//        Console.Write("Введите M: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[m, 10];

//        Console.WriteLine("Введите элементы матрицы Mx10:");
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] rowProducts = new int[m];

//        for (int i = 0; i < m; i++)
//        {
//            long product = 1;
//            for (int j = 0; j < 10; j++)
//            {
//                if (matrix[i, j] > 0)
//                    product *= matrix[i, j];
//            }
//            rowProducts[i] = (int)product;
//        }

//        int maxProduct = rowProducts.Max();
//        int rowIndex = Array.IndexOf(rowProducts, maxProduct);

//        Console.WriteLine($"\nСтрока с наибольшим произведением положительных: {rowIndex}");
//        Console.WriteLine($"Произведение: {maxProduct}");
//    }
//}

//11.21
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.21: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        double[,] matrix = new double[n, n];

//        Console.WriteLine("Введите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = double.Parse(Console.ReadLine());
//            }
//        }

//        double[] rowAverages = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            double sum = 0;
//            for (int j = 0; j < n; j++)
//            {
//                sum += matrix[i, j];
//            }
//            rowAverages[i] = sum / n;
//        }

//        int count = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (rowAverages[i] > 1.0 && rowAverages[i] < 10.0)
//                count++;
//        }

//        Console.WriteLine($"\nКоличество строк со средним в (1,10): {count}");
//    }
//}

//11.22
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.22: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < n; i++)
//        {
//            int max = matrix[i, 0];
//            int maxCol = 0;
//            for (int j = 1; j < n; j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                    maxCol = j;
//                }
//            }

//            int temp = matrix[i, maxCol];
//            matrix[i, maxCol] = matrix[i, i];
//            matrix[i, i] = temp;
//        }

//        Console.WriteLine("\nМатрица после обмена:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int n = matrix.GetLength(0);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//11.23
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.23: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sumBelow = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (i + j > n)
//                    sumBelow += matrix[i, j];
//            }
//        }

//        Console.WriteLine($"\nСумма элементов ниже побочной диагонали: {sumBelow}");
//    }
//}

//11.24
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.24: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                sum += matrix[i, j];
//            }
//        }

//        Console.WriteLine($"\nСумма всех элементов матрицы: {sum}");
//    }
//}

//11.25
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.25: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        bool isSymmetric = true;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (matrix[i, j] != matrix[j, i])
//                {
//                    isSymmetric = false;
//                    break;
//                }
//            }
//            if (!isSymmetric) break;
//        }

//        if (isSymmetric)
//            Console.WriteLine("\nМатрица симметрична относительно главной диагонали.");
//        else
//            Console.WriteLine("\nМатрица НЕ симметрична.");
//    }
//}

//11.26
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.26: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Вводите элементы матрицы NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        bool isAntiSymmetric = true;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (matrix[i, j] != -matrix[j, i])
//                {
//                    isAntiSymmetric = false;
//                    break;
//                }
//            }
//            if (!isAntiSymmetric) break;
//        }

//        if (isAntiSymmetric)
//            Console.WriteLine("\nМатрица антисимметрична (A[i,j] = -A[j,i]).");
//        else
//            Console.WriteLine("\nМатрица НЕ антисимметрична.");
//    }
//}

//11.27
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.27: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Заполните матрицу A[n,m]:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (A[i, j] < 0)
//                    A[i, j] = 0;
//                else if (A[i, j] > 0)
//                    A[i, j] = 1;
//            }
//        }

//        Console.WriteLine("\nМатрица после замены: отрицательные to 0, положительные to 1:");
//        PrintMatrix(A);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],3}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//11.28
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.28: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите матрицу A[n,m]:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] rowSums = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                rowSums[i] += A[i, j];
//            }
//        }

//        int maxSum = rowSums.Max();
//        int rowIndex = Array.IndexOf(rowSums, maxSum);

//        Console.WriteLine($"\nСтрока с наибольшей суммой: {rowIndex + 1} (сумма = {maxSum})");
//    }
//}

//11.29
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.29: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите матрицу NxN:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        long product = 1;
//        for (int i = 0; i < n; i++)
//        {
//            product *= matrix[i, n - 1 - i];
//        }

//        Console.WriteLine($"\nПроизведение элементов побочной диагонали: {product}");
//    }
//}

//11.30
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11.30: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите M: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите матрицу A[N,M]:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int maxUnique = 0;
//        int rowWithMaxUnique = -1;

//        for (int i = 0; i < n; i++)
//        {
//            var set = new System.Collections.Generic.HashSet<int>();
//            for (int j = 0; j < m; j++)
//            {
//                set.Add(A[i, j]);
//            }
//            if (set.Count > maxUnique)
//            {
//                maxUnique = set.Count;
//                rowWithMaxUnique = i;
//            }
//        }

//        Console.WriteLine($"\nСтрока с наибольшим количеством уникальных элементов: {rowWithMaxUnique + 1}");
//        Console.WriteLine($"Количество уникальных: {maxUnique}");
//    }
//}
//12.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.1: ");

//        Console.Write("Введите n (размер массива): ");
//        int n = int.Parse(Console.ReadLine());
//        double[] a = new double[n];

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"a[{i}]: ");
//            a[i] = double.Parse(Console.ReadLine());
//        }

//        double max = a[0];
//        int maxIndex = 0;
//        for (int i = 1; i < n; i++)
//        {
//            if (a[i] > max)
//            {
//                max = a[i];
//                maxIndex = i;
//            }
//        }

//        double sum = 0;
//        for (int i = maxIndex + 1; i < n; i++)
//        {
//            sum += a[i];
//        }

//        double radius = Math.Abs(sum);
//        double center = maxIndex;

//        Console.WriteLine($"\nРадиус: {radius:F2}");
//        Console.WriteLine($"Центр: {center}");
//    }
//}

//12.2
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.2: ");

//        Console.Write("Введите количество студентов: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] scores = new double[n];

//        Console.WriteLine("Введите баллы студентов (0-100):");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Студент {i + 1}: ");
//            scores[i] = double.Parse(Console.ReadLine());
//        }

//        var top4 = scores.OrderByDescending(x => x).Take(4).ToArray();

//        Console.WriteLine("\nКоманда из 4 лучших бегунов:");
//        for (int i = 0; i < top4.Length; i++)
//        {
//            Console.WriteLine($"Место {i + 1}: {top4[i]} баллов");
//        }

//        double teamTime = top4.Sum();
//        Console.WriteLine($"Суммарное время команды: {teamTime:F2} сек");
//    }
//}

//12.3
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.3: ");

//        Console.Write("Введите размер массива L: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] L = new double[n];

//        Console.WriteLine("Введите элементы массива L:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"L[{i}]: ");
//            L[i] = double.Parse(Console.ReadLine());
//        }

//        double[] sorted = L.OrderBy(x => x).ToArray();

//        Console.WriteLine("\nОтсортированный массив по возрастанию:");
//        Console.WriteLine("[" + string.Join(", ", sorted) + "]");
//    }
//}

//12.4
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.4: ");

//        Console.Write("Введите размер квадратной матрицы: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] diagonal = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            diagonal[i] = matrix[i, i];
//        }

//        Array.Sort(diagonal);

//        Console.WriteLine("\nОдномерный массив из главной диагонали (отсортирован):");
//        Console.WriteLine("[" + string.Join(", ", diagonal) + "]");
//    }
//}

//12.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.5: ");

//        Console.Write("Введите M (строки): ");
//        int m = int.Parse(Console.ReadLine());
//        Console.Write("Введите N (столбцы): ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[m, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int firstRowSum = 0;
//        for (int j = 0; j < n; j++)
//        {
//            firstRowSum += matrix[0, j];
//        }

//        int count = 0;
//        for (int i = 1; i < m; i++)
//        {
//            int rowSum = 0;
//            for (int j = 0; j < n; j++)
//            {
//                rowSum += matrix[i, j];
//            }
//            if (rowSum == firstRowSum)
//                count++;
//        }

//        Console.WriteLine($"\nКоличество строк, равных первой: {count}");
//    }
//}

//12.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.6: ");

//        Console.Write("Введите M (строки): ");
//        int m = int.Parse(Console.ReadLine());
//        Console.Write("Введите N (столбцы): ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[m, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int count = 0;
//        for (int i = 0; i < m; i++)
//        {
//            bool similar = true;
//            for (int j = 0; j < n; j++)
//            {
//                if (matrix[i, j] != matrix[0, j])
//                {
//                    similar = false;
//                    break;
//                }
//            }
//            if (similar) count++;
//        }

//        Console.WriteLine($"\nКоличество строк, похожих на первую: {count}");
//    }
//}

//12.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.7: ");

//        int[,] matrix = new int[3, 3];

//        Console.WriteLine("Введите элементы матрицы 3x3:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int minRow = 0, minCol = 0;
//        int minSum = int.MaxValue;

//        for (int i = 0; i < 3; i++)
//        {
//            int rowSum = 0;
//            for (int j = 0; j < 3; j++)
//            {
//                rowSum += matrix[i, j];
//            }
//            if (rowSum < minSum)
//            {
//                minSum = rowSum;
//                minRow = i;
//            }
//        }

//        for (int j = 0; j < 3; j++)
//        {
//            int colSum = 0;
//            for (int i = 0; i < 3; i++)
//            {
//                colSum += matrix[i, j];
//            }
//            if (colSum < minSum)
//            {
//                minSum = colSum;
//                minRow = -1;
//                minCol = j;
//            }
//        }

//        if (minRow != -1)
//            Console.WriteLine($"\nСтрока {minRow + 1} с минимальной суммой: {minSum}");
//        else
//            Console.WriteLine($"\nСтолбец {minCol + 1} с минимальной суммой: {minSum}");
//    }
//}

//12.8
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.8: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] distances = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < n; j++)
//            {
//                sum += Math.Abs(matrix[i, j]);
//            }
//            distances[i] = sum;
//        }

//        Array.Sort(distances);

//        Console.WriteLine("\nЭлементы, расположенные в порядке возрастания расстояния от начала координат:");
//        Console.WriteLine("[" + string.Join(", ", distances) + "]");
//    }
//}

//12.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.9: ");

//        int[,] matrix = new int[5, 10];

//        Console.WriteLine("Введите элементы матрицы 5x10:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int count = 0;
//        for (int j = 0; j < 10; j++)
//        {
//            bool allZero = true;
//            for (int i = 0; i < 5; i++)
//            {
//                if (matrix[i, j] != 0)
//                {
//                    allZero = false;
//                    break;
//                }
//            }
//            if (allZero) count++;
//        }

//        Console.WriteLine($"\nКоличество нулевых столбцов: {count}");
//    }
//}

//12.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.10: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int max = int.MinValue;
//        int maxRow = -1, maxCol = -1;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }
//            }
//        }

//        Console.WriteLine($"\nНаибольший элемент: {max}");
//        Console.WriteLine($"Индекс: [{maxRow}, {maxCol}]");
//    }
//}

//12.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.11: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int maxSeries = 0;
//        int currentSeries = 1;

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 1; j < n; j++)
//            {
//                if (matrix[i, j] > matrix[i, j - 1])
//                {
//                    currentSeries++;
//                }
//                else
//                {
//                    if (currentSeries > maxSeries)
//                        maxSeries = currentSeries;
//                    currentSeries = 1;
//                }
//            }
//            if (currentSeries > maxSeries)
//                maxSeries = currentSeries;
//            currentSeries = 1;
//        }

//        Console.WriteLine($"\nМаксимальная серия упорядоченных по возрастанию элементов: {maxSeries}");
//    }
//}

//12.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.12: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        bool hasNatural = false;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (matrix[i, j] > 0)
//                {
//                    hasNatural = true;
//                    break;
//                }
//            }
//            if (hasNatural) break;
//        }

//        if (hasNatural)
//            Console.WriteLine("\nВ матрице есть хотя бы одно натуральное число.");
//        else
//            Console.WriteLine("\nВ матрице нет натуральных чисел.");
//    }
//}

//12.13
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12.13: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int maxDiagonal = int.MinValue;
//        int diagonalIndex = -1;

//        for (int k = 0; k < 2 * n - 1; k++)
//        {
//            int sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                int j = k - i;
//                if (j >= 0 && j < n)
//                {
//                    sum += matrix[i, j];
//                }
//            }
//            if (sum > maxDiagonal)
//            {
//                maxDiagonal = sum;
//                diagonalIndex = k;
//            }
//        }

//        Console.WriteLine($"\nНомер диагонали с наибольшей суммой: {diagonalIndex + 1}");
//        Console.WriteLine($"Сумма: {maxDiagonal}");
//    }
//}
//13.14
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.14: ");

//        Console.Write("Введите N: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите M: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] rowMax = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int max = A[i, 0];
//            for (int j = 1; j < m; j++)
//            {
//                if (A[i, j] > max)
//                    max = A[i, j];
//            }
//            rowMax[i] = max;
//        }

//        Console.WriteLine("\nНовый массив из максимумов строк:");
//        Console.WriteLine("[" + string.Join(", ", rowMax) + "]");
//    }
//}

//13.15
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.15: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[,] B = new int[n, n];
//        int value = 1;

//        for (int k = 0; k < n; k++)
//        {
//            for (int i = k; i < n; i++)
//            {
//                int j = k - (i - k);
//                if (j >= 0 && j < n)
//                    B[i, j] = value++;
//            }
//        }

//        for (int k = 1; k < n; k++)
//        {
//            for (int i = 0; i < n - k; i++)
//            {
//                int j = k + i;
//                if (j < n)
//                    B[i, j] = value++;
//            }
//        }

//        Console.WriteLine("\nМатрица B (ниже главной диагонали):");
//        PrintMatrix(B);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int n = matrix.GetLength(0);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"{matrix[i, j],3}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//13.16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.16: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        bool isSymmetric = true;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (A[i, j] != A[j, i])
//                {
//                    isSymmetric = false;
//                    break;
//                }
//            }
//            if (!isSymmetric) break;
//        }

//        Console.WriteLine(isSymmetric
//            ? "\nМатрица симметрична относительно главной диагонали."
//            : "\nМатрица НЕ симметрична.");
//    }
//}

//13.17
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.17: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Введите m: ");
//        int m = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, m];

//        Console.WriteLine("Введите элементы матрицы A:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int[] symbolCounts = new int[10];

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                int num = Math.Abs(A[i, j]);
//                while (num > 0)
//                {
//                    int digit = num % 10;
//                    symbolCounts[digit]++;
//                    num /= 10;
//                }
//                if (A[i, j] == 0) symbolCounts[0]++;
//            }
//        }

//        Console.WriteLine("\nВывод (каждое число равно количеству вхождений символа):");
//        for (int d = 0; d < 10; d++)
//        {
//            Console.WriteLine($"{d}: {symbolCounts[d]}");
//        }
//    }
//}

//13.18
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.18: ");

//        int n = 4, m = 6;
//        int[,] A = new int[n, m];

//        int value = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                A[i, j] = value++;
//            }
//        }

//        Console.WriteLine("Матрица A[4,6] (заполнена змейкой):");
//        PrintMatrix(A);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        for (int i = 0; i < rows; i++)
//        {
//            if (i % 2 == 0)
//            {
//                for (int j = 0; j < cols; j++)
//                    Console.Write($"{matrix[i, j],3}");
//            }
//            else
//            {
//                for (int j = cols - 1; j >= 0; j--)
//                    Console.Write($"{matrix[i, j],3}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//13.19
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.19: ");

//        int n = 4, m = 6;
//        int[,] A = new int[n, m];

//        int value = 0;
//        for (int j = 0; j < m; j++)
//        {
//            if (j % 2 == 0)
//            {
//                for (int i = 0; i < n; i++)
//                    A[i, j] = value++;
//            }
//            else
//            {
//                for (int i = n - 1; i >= 0; i--)
//                    A[i, j] = value++;
//            }
//        }

//        Console.WriteLine("Матрица A[4,6] (заполнена по столбцам змейкой):");
//        PrintMatrix(A);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],3}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//13.20
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13.20: ");

//        Console.Write("Введите n: ");
//        int n = int.Parse(Console.ReadLine());

//        int[,] A = new int[n, n];

//        Console.WriteLine("Введите элементы матрицы A:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"A[{i},{j}]: ");
//                A[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int centralRow = n / 2;
//        int centralCol = n / 2;

//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum += A[centralRow, i];
//            sum += A[i, centralCol];
//        }
//        sum -= A[centralRow, centralCol];

//        Console.WriteLine($"\nСумма центральной строки и столбца: {sum}");
//    }
//}