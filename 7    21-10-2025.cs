//using System;

//class Program
//{
//    11
//    static long Factorial(int n)
//    {
//        long result = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            result *= i;
//        }
//        return result;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int number = int.Parse(Console.ReadLine());
//        long fact = Factorial(number);
//        Console.WriteLine($"Факториал числа {number} равен {fact}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}


//using System;

//class Program
//{
//    12
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = Sum(a, b);
//        Console.WriteLine($"Сумма: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    13
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = Sum(a, b);
//        Console.WriteLine($"Сумма: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    14
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = Sum(a, b);
//        Console.WriteLine($"Сумма: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    15
//    static bool IsEven(int n)
//    {
//        return n % 2 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsEven(n);
//        Console.WriteLine($"Число четное: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    16
//    static bool IsEven(int n)
//    {
//        return n % 2 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsEven(n);
//        Console.WriteLine($"Число четное: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}

//using System;

//class Program
//{
//    17
//    static void PrintRange(int a, int b)
//    {
//        for (int i = a; i <= b; i++)
//            Console.WriteLine(i);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите начало диапазона:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите конец диапазона:");
//        int b = int.Parse(Console.ReadLine());
//        PrintRange(a, b);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    18
//    static void PrintRange(int a, int b)
//    {
//        for (int i = a; i <= b; i++)
//            Console.WriteLine(i);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите начало диапазона:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите конец диапазона:");
//        int b = int.Parse(Console.ReadLine());
//        PrintRange(a, b);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    19
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = Sum(a, b);
//        Console.WriteLine($"Сумма: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    73
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//    75
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//    74
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    21
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        int result = Square(n);
//        Console.WriteLine($"Квадрат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    22
//    static bool IsPalindrome(string s)
//    {
//        string cleaned = s.ToLower().Replace(" ", "");
//        for (int i = 0; i < cleaned.Length / 2; i++)
//        {
//            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
//                return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        bool result = IsPalindrome(s);
//        Console.WriteLine($"Палиндром: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    22
//    static bool IsPalindrome(string s)
//    {
//        string cleaned = s.ToLower().Replace(" ", "");
//        for (int i = 0; i < cleaned.Length / 2; i++)
//        {
//            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
//                return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        bool result = IsPalindrome(s);
//        Console.WriteLine($"Палиндром: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    23
//    static void ChangeRef(ref int x)
//    {
//        x = x * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        ChangeRef(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    24
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        int result = Square(n);
//        Console.WriteLine($"Квадрат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    25
//    static void ChangeRef(ref int x)
//    {
//        x = x * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        ChangeRef(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    26
//    static bool IsPalindrome(string s)
//    {
//        string cleaned = s.ToLower().Replace(" ", "");
//        for (int i = 0; i < cleaned.Length / 2; i++)
//        {
//            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
//                return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        bool result = IsPalindrome(s);
//        Console.WriteLine($"Палиндром: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    27
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    28
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }

//    static void Main(string[] args)
//    {
//        PrintHelloWorld();

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    29
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        int result = Square(n);
//        Console.WriteLine($"Квадрат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    30
//    static void ChangeRef(ref int x)
//    {
//        x = x * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        ChangeRef(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    31
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    32
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    33
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        int result = Square(n);
//        Console.WriteLine($"Квадрат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    34
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        int result = Square(n);
//        Console.WriteLine($"Квадрат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    35
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    36
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }

//    static void Main(string[] args)
//    {
//        PrintHelloWorld();

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    37
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }

//    static void Main(string[] args)
//    {
//        PrintHelloWorld();

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    38
//    static void ChangeRef(ref int x)
//    {
//        x = x * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        ChangeRef(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    39
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }

//    static void Main(string[] args)
//    {
//        PrintHelloWorld();

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    40
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    41
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    42
//    static bool IsPalindrome(string s)
//    {
//        string cleaned = s.ToLower().Replace(" ", "");
//        for (int i = 0; i < cleaned.Length / 2; i++)
//        {
//            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
//                return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        bool result = IsPalindrome(s);
//        Console.WriteLine($"Палиндром: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    43
//    static void ProcedureExample()
//    {
//        Console.WriteLine("Это процедура, она не возвращает значение.");
//    }

//    static int FunctionExample(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        ProcedureExample();
//        Console.WriteLine("Введите первое число:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int b = int.Parse(Console.ReadLine());
//        int result = FunctionExample(a, b);
//        Console.WriteLine($"Результат функции: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    44
//    static void PrintHelloWorld()
//    {
//        Console.WriteLine("Hello, World!");
//    }

//    static void Main(string[] args)
//    {
//        PrintHelloWorld();

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    45
//    static void ChangeRef(ref int x)
//    {
//        x = x * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        ChangeRef(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    46
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    47
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    48
//    static int[] CopyArray(int[] arr)
//    {
//        int[] copy = new int[arr.Length];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            copy[i] = arr[i];
//        }
//        return copy;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int[] copied = CopyArray(arr);
//        Console.WriteLine("Скопированный массив:");
//        foreach (int num in copied)
//        {
//            Console.WriteLine(num);
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    49
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    50
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    51
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    52
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    53
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    54
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    55
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    56
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    57
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    58
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    59
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    60
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    61
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    62
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    63
//    static int[] CopyArray(int[] arr)
//    {
//        int[] copy = new int[arr.Length];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            copy[i] = arr[i];
//        }
//        return copy;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int[] copied = CopyArray(arr);
//        Console.WriteLine("Скопированный массив:");
//        foreach (int num in copied)
//        {
//            Console.WriteLine(num);
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    64
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    65
//    static int[] CopyArray(int[] arr)
//    {
//        int[] copy = new int[arr.Length];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            copy[i] = arr[i];
//        }
//        return copy;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int[] copied = CopyArray(arr);
//        Console.WriteLine("Скопированный массив:");
//        foreach (int num in copied)
//        {
//            Console.WriteLine(num);
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    66
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    67
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    68
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    69
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    70
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    70
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    71
//    static int StringLength(string s)
//    {
//        return s.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        int result = StringLength(s);
//        Console.WriteLine($"Длина строки: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    72
//    static double Average(int[] arr)
//    {
//        double sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }
//        return sum / arr.Length;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        double result = Average(arr);
//        Console.WriteLine($"Среднее значение: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    73
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    74
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите 1 для суммы двух чисел или 2 для трех:");
//        int choice = int.Parse(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            int result = Sum(a, b);
//            Console.WriteLine($"Сумма: {result}");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Введите первое число:");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите третье число:");
//            int c = int.Parse(Console.ReadLine());
//            int result = Sum(a, b, c);
//            Console.WriteLine($"Сумма: {result}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    75
//    static int FindMin(int[] arr)
//    {
//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min) min = arr[i];
//        }
//        return min;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int result = FindMin(arr);
//        Console.WriteLine($"Минимальный элемент: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    76
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    77
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    78
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    79
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    80
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    81
//    static string ReturnNullIfEmpty(string s)
//    {
//        if (string.IsNullOrEmpty(s)) return null;
//        return s.ToUpper();
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        string result = ReturnNullIfEmpty(s);
//        Console.WriteLine(result == null ? "Строка пустая" : $"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    82
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    83
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    84
//    static string MultipleReturns(int code)
//    {
//        if (code == 0) return "Успех";
//        if (code < 0) return "Ошибка";
//        return "Неизвестно";
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите код:");
//        int code = int.Parse(Console.ReadLine());
//        string result = MultipleReturns(code);
//        Console.WriteLine($"Статус: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    85
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    86
//    static string MultipleReturns(int code)
//    {
//        if (code == 0) return "Успех";
//        if (code < 0) return "Ошибка";
//        return "Неизвестно";
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите код:");
//        int code = int.Parse(Console.ReadLine());
//        string result = MultipleReturns(code);
//        Console.WriteLine($"Статус: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    87
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    88
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    89
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    90
//    static string MultipleReturns(int code)
//    {
//        if (code == 0) return "Успех";
//        if (code < 0) return "Ошибка";
//        return "Неизвестно";
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите код:");
//        int code = int.Parse(Console.ReadLine());
//        string result = MultipleReturns(code);
//        Console.WriteLine($"Статус: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    91
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    92
//    static string ReturnNullIfEmpty(string s)
//    {
//        if (string.IsNullOrEmpty(s)) return null;
//        return s.ToUpper();
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        string result = ReturnNullIfEmpty(s);
//        Console.WriteLine(result == null ? "Строка пустая" : $"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    93
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    94
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    95
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    96
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    97
//    static bool IsDivisibleByThree(int n)
//    {
//        return n % 3 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int n = int.Parse(Console.ReadLine());
//        bool result = IsDivisibleByThree(n);
//        Console.WriteLine($"Делится на 3: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    98
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    99
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    100
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    101
//    static int DivideWithError(int a, int b)
//    {
//        if (b == 0) return -1;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        int result = DivideWithError(a, b);
//        if (result == -1)
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    102
//    static string ReturnNullIfEmpty(string s)
//    {
//        if (string.IsNullOrEmpty(s)) return null;
//        return s.ToUpper();
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        string result = ReturnNullIfEmpty(s);
//        Console.WriteLine(result == null ? "Строка пустая" : $"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    103
//    static string ReturnNullIfEmpty(string s)
//    {
//        if (string.IsNullOrEmpty(s)) return null;
//        return s.ToUpper();
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        string result = ReturnNullIfEmpty(s);
//        Console.WriteLine(result == null ? "Строка пустая" : $"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    104
//    static void EarlyReturnExample(int value)
//    {
//        if (value <= 0)
//        {
//            Console.WriteLine("Значение недопустимо");
//            return;
//        }
//        Console.WriteLine($"Значение корректно: {value}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        EarlyReturnExample(value);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    105
//    static string ReturnNullIfEmpty(string s)
//    {
//        if (string.IsNullOrEmpty(s)) return null;
//        return s.ToUpper();
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        string result = ReturnNullIfEmpty(s);
//        Console.WriteLine(result == null ? "Строка пустая" : $"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    106
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    107
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    108
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    109
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    110
//    static void ProcessArray(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return;
//        Console.WriteLine("Массив не пустой, обработка...");
//        foreach (int x in arr) Console.WriteLine(x);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        if (size > 0)
//        {
//            Console.WriteLine("Введите элементы:");
//            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
//        }
//        ProcessArray(arr);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    111
//    static void ProcessArray(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return;
//        Console.WriteLine("Массив не пустой, обработка...");
//        foreach (int x in arr) Console.WriteLine(x);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        if (size > 0)
//        {
//            Console.WriteLine("Введите элементы:");
//            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
//        }
//        ProcessArray(arr);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    112
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    113
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    114
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    115
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    116
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    117
//    static void ProcessArray(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return;
//        Console.WriteLine("Массив не пустой, обработка...");
//        foreach (int x in arr) Console.WriteLine(x);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        if (size > 0)
//        {
//            Console.WriteLine("Введите элементы:");
//            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
//        }
//        ProcessArray(arr);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    118
//    static void ProcessArray(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return;
//        Console.WriteLine("Массив не пустой, обработка...");
//        foreach (int x in arr) Console.WriteLine(x);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        if (size > 0)
//        {
//            Console.WriteLine("Введите элементы:");
//            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
//        }
//        ProcessArray(arr);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    119
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    120
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    121
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    122
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    123
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    123
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    124
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    125
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    126
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    127
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    128
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    129
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    130
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    131
//    class Person
//    {
//        public string Name { get; }
//        public Person(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//                throw new ArgumentException("Имя обязательно");
//            Name = name;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите имя:");
//        string name = Console.ReadLine();
//        try
//        {
//            Person p = new Person(name);
//            Console.WriteLine($"Создан объект: {p.Name}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    132
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    133
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    134
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    135
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    136
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    137
//    static void ProcessArray(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return;
//        Console.WriteLine("Массив не пустой, обработка...");
//        foreach (int x in arr) Console.WriteLine(x);
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        if (size > 0)
//        {
//            Console.WriteLine("Введите элементы:");
//            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
//        }
//        ProcessArray(arr);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    138
//    static double SafeDivide(double a, double b)
//    {
//        if (b == 0) return double.NaN;
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        double a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double b = double.Parse(Console.ReadLine());
//        double result = SafeDivide(a, b);
//        if (double.IsNaN(result))
//            Console.WriteLine("Ошибка: деление на ноль");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    139
//    static void ProcessString(string s)
//    {
//        if (s == null) throw new ArgumentNullException(nameof(s));
//        Console.WriteLine($"Длина строки: {s.Length}");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string s = Console.ReadLine();
//        try
//        {
//            ProcessString(s == "" ? null : s);
//        }
//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("Ошибка: строка null");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    140
//    static bool IsInRange(int value, int min, int max)
//    {
//        if (value < min || value > max) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите значение:");
//        int value = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите минимум:");
//        int min = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите максимум:");
//        int max = int.Parse(Console.ReadLine());
//        bool result = IsInRange(value, min, max);
//        Console.WriteLine($"В диапазоне: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    141
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    143
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    144
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    145
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    146
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    147
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    148
//    static bool CheckAge(int age)
//    {
//        if (age < 18) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите возраст:");
//        int age = int.Parse(Console.ReadLine());
//        bool result = CheckAge(age);
//        Console.WriteLine(result ? "Доступ разрешён" : "Возраст меньше 18");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    149
//    static bool CheckAge(int age)
//    {
//        if (age < 18) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите возраст:");
//        int age = int.Parse(Console.ReadLine());
//        bool result = CheckAge(age);
//        Console.WriteLine(result ? "Доступ разрешён" : "Возраст меньше 18");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    150
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    151
//    static bool CheckAge(int age)
//    {
//        if (age < 18) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите возраст:");
//        int age = int.Parse(Console.ReadLine());
//        bool result = CheckAge(age);
//        Console.WriteLine(result ? "Доступ разрешён" : "Возраст меньше 18");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    152
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    153
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    154
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    155
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    156
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    156
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    157
//    static void ValidateDate(string date)
//    {
//        if (!DateTime.TryParse(date, out _))
//            throw new FormatException("Невалидный формат даты");
//        Console.WriteLine("Дата валидна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите дату:");
//        string date = Console.ReadLine();
//        try
//        {
//            ValidateDate(date);
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    158
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    159
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    160
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    161
//    static bool IsEmailUnique(string email)
//    {
//        string[] existing = { "user@example.com" };
//        foreach (string e in existing)
//            if (e == email) return false;
//        return true;
//    }

//    static void Register(string email)
//    {
//        if (!IsEmailUnique(email))
//            throw new InvalidOperationException("Email уже занят");
//        Console.WriteLine("Регистрация успешна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        try
//        {
//            Register(email);
//        }
//        catch (InvalidOperationException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    162
//    static bool CheckAge(int age)
//    {
//        if (age < 18) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите возраст:");
//        int age = int.Parse(Console.ReadLine());
//        bool result = CheckAge(age);
//        Console.WriteLine(result ? "Доступ разрешён" : "Возраст меньше 18");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    163
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    164
//    static bool CheckAge(int age)
//    {
//        if (age < 18) return false;
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите возраст:");
//        int age = int.Parse(Console.ReadLine());
//        bool result = CheckAge(age);
//        Console.WriteLine(result ? "Доступ разрешён" : "Возраст меньше 18");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    165
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    166
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    167
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    168
//    static void ValidateDate(string date)
//    {
//        if (!DateTime.TryParse(date, out _))
//            throw new FormatException("Невалидный формат даты");
//        Console.WriteLine("Дата валидна");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите дату:");
//        string date = Console.ReadLine();
//        try
//        {
//            ValidateDate(date);
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    169
//    static void ValidatePassword(string password)
//    {
//        if (password.Length < 8)
//            throw new ArgumentException("Пароль слишком короткий");
//        Console.WriteLine("Пароль валиден");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите пароль:");
//        string password = Console.ReadLine();
//        try
//        {
//            ValidatePassword(password);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    170
//    static int CalculateWithNegativeCheck(int amount)
//    {
//        if (amount < 0) return -1;
//        return amount * 2;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите сумму:");
//        int amount = int.Parse(Console.ReadLine());
//        int result = CalculateWithNegativeCheck(amount);
//        if (result == -1)
//            Console.WriteLine("Ошибка: сумма отрицательная");
//        else
//            Console.WriteLine($"Результат: {result}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    171
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    172
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    173
//    static void FillSquares(int[] result)
//    {
//        for (int i = 0; i < result.Length; i++)
//        {
//            result[i] = i * i;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        FillSquares(arr);
//        Console.WriteLine("Квадраты:");
//        foreach (int x in arr) Console.WriteLine(x);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    174
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    175
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    176
//    static void Increment(ref int value)
//    {
//        value++;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        Increment(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    177
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    178
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    179
//    static void FillSquares(int[] result)
//    {
//        for (int i = 0; i < result.Length; i++)
//        {
//            result[i] = i * i;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        FillSquares(arr);
//        Console.WriteLine("Квадраты:");
//        foreach (int x in arr) Console.WriteLine(x);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    180
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    181
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    182
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    183
//    static void Increment(ref int value)
//    {
//        value++;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        Increment(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    184
//    static void FillSquares(int[] result)
//    {
//        for (int i = 0; i < result.Length; i++)
//        {
//            result[i] = i * i;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        FillSquares(arr);
//        Console.WriteLine("Квадраты:");
//        foreach (int x in arr) Console.WriteLine(x);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    185
//    static void Increment(ref int value)
//    {
//        value++;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        Increment(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    186
//    static void FillSquares(int[] result)
//    {
//        for (int i = 0; i < result.Length; i++)
//        {
//            result[i] = i * i;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        FillSquares(arr);
//        Console.WriteLine("Квадраты:");
//        foreach (int x in arr) Console.WriteLine(x);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    187
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    188
//    static void FillSquares(int[] result)
//    {
//        for (int i = 0; i < result.Length; i++)
//        {
//            result[i] = i * i;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите размер массива:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        FillSquares(arr);
//        Console.WriteLine("Квадраты:");
//        foreach (int x in arr) Console.WriteLine(x);

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    189
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int y = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: x={x}, y={y}");
//        Swap(ref x, ref y);
//        Console.WriteLine($"После: x={x}, y={y}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    190
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    191
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    192
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int y = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: x={x}, y={y}");
//        Swap(ref x, ref y);
//        Console.WriteLine($"После: x={x}, y={y}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    193
//    static void Increment(ref int value)
//    {
//        value++;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: {x}");
//        Increment(ref x);
//        Console.WriteLine($"После: {x}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    194
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int y = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: x={x}, y={y}");
//        Swap(ref x, ref y);
//        Console.WriteLine($"После: x={x}, y={y}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    195
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    196
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    197
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    198
//    static bool TryParseInt(string s, out int result)
//    {
//        result = 0;
//        if (int.TryParse(s, out int value))
//        {
//            result = value;
//            return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        string s = Console.ReadLine();
//        if (TryParseInt(s, out int num))
//            Console.WriteLine($"Успешно: {num}");
//        else
//            Console.WriteLine("Не удалось распарсить");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    199
//    static void Divide(int a, int b, out int quotient, out int remainder)
//    {
//        quotient = a / b;
//        remainder = a % b;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите делимое:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        int b = int.Parse(Console.ReadLine());
//        Divide(a, b, out int q, out int r);
//        Console.WriteLine($"Частное: {q}, Остаток: {r}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    200
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите первое число:");
//        int x = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите второе число:");
//        int y = int.Parse(Console.ReadLine());
//        Console.WriteLine($"До: x={x}, y={y}");
//        Swap(ref x, ref y);
//        Console.WriteLine($"После: x={x}, y={y}");

//        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть...");
//        Console.ReadKey();
//    }
//}