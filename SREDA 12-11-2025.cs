using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesTasksExtended
{
    //1
    public delegate int BinaryOperation(int a, int b);
    class DelegateBinaryDemo
    {
        static int Add(int x, int y) => x + y;
        static int Multiply(int x, int y) => x * y;
        static int Subtract(int x, int y) => x - y;
        static int Divide(int x, int y) => y != 0 ? x / y : 0;
        static void Main()
        {
            BinaryOperation[] operations = { Add, Multiply, Subtract, Divide };
            int a = 20, b = 5;
            foreach (var op in operations)
                Console.WriteLine($"{op.Method.Name}: {op(a, b)}");
        }
    }

    //2
    public delegate int ArithmeticOperation(int a, int b);
    class ArithmeticDemo
    {
        static int Power(int x, int y) => (int)Math.Pow(x, y);
        static int Modulo(int x, int y) => x % y;
        static void Main()
        {
            ArithmeticOperation[] ops = { Add, Subtract, Multiply, Divide, Power, Modulo };
            int a = 10, b = 3;
            foreach (var op in ops)
                Console.WriteLine($"{op.Method.Name}: {op(a, b)}");
        }
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        static int Divide(int x, int y) => y != 0 ? x / y : 0;
    }

    //3
    public delegate void MessageDelegate(string message);
    class MessageOutputDemo
    {
        static void PrintConsole(string msg) => Console.WriteLine($"[CONSOLE] {msg}");
        static void PrintFile(string msg) => File.AppendAllText("messages.log", $"[{DateTime.Now}] {msg}\n");
        static void PrintBoth(string msg)
        {
            PrintConsole(msg);
            PrintFile(msg);
        }
        static void Main()
        {
            MessageDelegate del = PrintConsole;
            del += PrintFile;
            del += PrintBoth;
            del += msg => Console.WriteLine($"[DEBUG] {msg.ToUpper()}");
            del("Application initialized successfully");
        }
    }

    //4
    public delegate bool Predicate<T>(T value);
    class PredicateDemo
    {
        static bool IsEven(int n) => n % 2 == 0;
        static bool IsPositive(double d) => d > 0;
        static bool IsPalindrome(string s) => s.SequenceEqual(s.Reverse());
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        static void Main()
        {
            Predicate<int>[] intPredicates = { IsEven, IsPrime };
            Predicate<double> positiveCheck = IsPositive;
            Predicate<string> palindromeCheck = IsPalindrome;
            Console.WriteLine($"Even(4): {intPredicates[0](4)}");
            Console.WriteLine($"Prime(7): {intPredicates[1](7)}");
            Console.WriteLine($"Positive(-1.5): {positiveCheck(-1.5)}");
            Console.WriteLine($"Palindrome('radar'): {palindromeCheck("radar")}");
        }
    }

    //5
    class ActionDelegateDemo
    {
        static void PrintMessage(string msg) => Console.WriteLine($"[INFO] {msg}");
        static void LogMessage(string msg) => Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {msg}");
        static void ProcessNumber(int num) => Console.WriteLine($"Number: {num}, Square: {num * num}, Cube: {num * num * num}, Root: {Math.Sqrt(num):F2}");
        static void PrintToFile(int value) => File.AppendAllText("numbers.log", $"{value}\n");
        static void SendAlert(string msg) => Console.WriteLine($"[ALERT] {msg}");
        static void Main()
        {
            Action<string> printAction = Console.WriteLine;
            printAction("Hello from Action delegate");
            printAction("System ready");

            Action<string, int> displayInfo = (name, age) =>
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Age Group: {(age < 18 ? "Minor" : "Adult")}");
            };
            displayInfo("Ivan", 25);
            displayInfo("Maria", 17);

            Action<string> multiAction = PrintMessage;
            multiAction += LogMessage;
            multiAction += SendAlert;
            multiAction += msg => Console.WriteLine($"[BACKUP] {msg}");
            multiAction("File operation completed");

            Action<int> processor = ProcessNumber;
            processor += PrintToFile;
            processor += n => Console.WriteLine($"[MATH] {n} in binary: {Convert.ToString(n, 2)}");
            processor(8);

            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Eve" };
            names.ForEach(name => Console.WriteLine($"  - {name.ToUpper()}"));

            Action<int> conditionalAction = (num) =>
            {
                string parity = num % 2 == 0 ? "even" : "odd";
                string sign = num > 0 ? "positive" : (num < 0 ? "negative" : "zero");
                Console.WriteLine($"{num} is {parity} and {sign}");
            };
            conditionalAction(7);
            conditionalAction(-4);
            conditionalAction(0);

            Action<string> notificationSystem = null;
            notificationSystem += msg => Console.WriteLine($"[EMAIL] Sending to user: {msg}");
            notificationSystem += msg => Console.WriteLine($"[SMS] SMS: {msg}");
            notificationSystem += msg => Console.WriteLine($"[PUSH] Push notification: {msg}");
            notificationSystem += msg => Console.WriteLine($"[WEBHOOK] POST to service: {msg}");
            notificationSystem?.Invoke("Critical system update required");
        }
    }

    //6
    class FuncDelegateDemo
    {
        static string ToUpper(string s) => s.ToUpper();
        static int Square(int n) => n * n;
        static double CircleArea(double r) => Math.PI * r * r;
        static string FormatDate(DateTime dt) => dt.ToString("yyyy-MM-dd HH:mm:ss");
        static void Main()
        {
            Func<string, string> transform = ToUpper;
            Console.WriteLine(transform("hello world"));

            Func<int, int> mathOp = Square;
            Console.WriteLine($"Square of 5: {mathOp(5)}");

            Func<double, double> areaCalc = CircleArea;
            Console.WriteLine($"Area of circle r=3: {areaCalc(3):F2}");

            Func<string, int, string> format = (s, n) => $"{s}: {n:D3}";
            Console.WriteLine(format("ID", 42));

            Func<DateTime, string> dateFmt = FormatDate;
            Console.WriteLine($"Current time: {dateFmt(DateTime.Now)}");

            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine($"10 + 5 = {add(10, 5)}");
            Console.WriteLine($"10 * 5 = {multiply(10, 5)}");
        }
    }

    //7
    class FilterDelegateDemo
    {
        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 30).ToList();
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

            Predicate<int> isEven = n => n % 2 == 0;
            Predicate<int> isPrime = n =>
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0) return false;
                return true;
            };
            Predicate<int> isMultipleOf5 = n => n % 5 == 0;

            Predicate<string> startsWithA = s => s.StartsWith("a", StringComparison.OrdinalIgnoreCase);
            Predicate<string> lengthGreaterThan5 = s => s.Length > 5;

            var evens = numbers.Where(x => isEven(x)).ToList();
            var primes = numbers.Where(x => isPrime(x)).ToList();
            var multiplesOf5 = numbers.Where(x => isMultipleOf5(x)).ToList();
            var wordsWithA = words.Where(x => startsWithA(x)).ToList();
            var longWords = words.Where(x => lengthGreaterThan5(x)).ToList();

            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
            Console.WriteLine("Prime numbers: " + string.Join(", ", primes));
            Console.WriteLine("Multiples of 5: " + string.Join(", ", multiplesOf5));
            Console.WriteLine("Words starting with A: " + string.Join(", ", wordsWithA));
            Console.WriteLine("Words longer than 5: " + string.Join(", ", longWords));

            var complexFilter = numbers.Where(n => isEven(n) && isMultipleOf5(n) && n > 10);
            Console.WriteLine("Even, multiple of 5, >10: " + string.Join(", ", complexFilter));
        }
    }

    //8
    class CallbackDemo
    {
        public delegate void Callback(string result);
        public delegate void ProgressCallback(int percent);

        static void ProcessAsync(Callback onComplete, ProgressCallback onProgress)
        {
            for (int i = 0; i <= 100; i += 20)
            {
                Thread.Sleep(200);
                onProgress(i);
            }
            onComplete("Operation completed successfully");
        }

        static void Main()
        {
            Callback completion = msg => Console.WriteLine($"[CALLBACK] {msg}");
            ProgressCallback progress = pct => Console.WriteLine($"[PROGRESS] {pct}% completed");

            Console.WriteLine("Starting async operation...");
            ProcessAsync(completion, progress);
            Console.WriteLine("Main thread continues...");
        }
    }

    //9
    class SortingDelegateDemo
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }
            public DateTime EnrollmentDate { get; set; }
            public string Major { get; set; }

            public override string ToString() => $"{Name,-15} Age: {Age,2}  GPA: {GPA:F2}  Major: {Major,-12}  Enrolled: {EnrollmentDate:yyyy-MM-dd}";
        }

        public delegate int StudentComparer(Student a, Student b);

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22, GPA = 3.8, EnrollmentDate = new DateTime(2022, 9, 1), Major = "Computer Science" },
            new Student { Name = "Bob", Age = 20, GPA = 3.5, EnrollmentDate = new DateTime(2023, 9, 1), Major = "Mathematics" },
            new Student { Name = "Charlie", Age = 23, GPA = 3.9, EnrollmentDate = new DateTime(2021, 9, 1), Major = "Physics" },
            new Student { Name = "Diana", Age = 21, GPA = 3.6, EnrollmentDate = new DateTime(2022, 9, 1), Major = "Computer Science" },
            new Student { Name = "Eve", Age = 22, GPA = 3.7, EnrollmentDate = new DateTime(2023, 1, 15), Major = "Biology" }
        };

            Console.WriteLine("Original list:");
            students.ForEach(s => Console.WriteLine(s));

            // Sort by Name
            StudentComparer byName = (a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal);
            List<Student> sortedByName = new List<Student>(students);
            sortedByName.Sort(Comparer<Student>.Create(byName));
            Console.WriteLine("\n--- Sorted by Name ---");
            sortedByName.ForEach(s => Console.WriteLine(s));

            // Sort by Age ascending
            StudentComparer byAge = (a, b) => a.Age.CompareTo(b.Age);
            List<Student> sortedByAge = new List<Student>(students);
            sortedByAge.Sort(Comparer<Student>.Create(byAge));
            Console.WriteLine("\n--- Sorted by Age (asc) ---");
            sortedByAge.ForEach(s => Console.WriteLine(s));

            // Sort by GPA descending
            StudentComparer byGPADesc = (a, b) => b.GPA.CompareTo(a.GPA);
            List<Student> sortedByGPADesc = new List<Student>(students);
            sortedByGPADesc.Sort(Comparer<Student>.Create(byGPADesc));
            Console.WriteLine("\n--- Sorted by GPA (desc) ---");
            sortedByGPADesc.ForEach(s => Console.WriteLine(s));

            // Sort by Major then GPA
            Console.WriteLine("\n--- Sorted by Major, then GPA (desc) ---");
            var sortedByMajorThenGPA = students
                .OrderBy(s => s.Major)
                .ThenByDescending(s => s.GPA)
                .ToList();
            sortedByMajorThenGPA.ForEach(s => Console.WriteLine(s));

            // Sort by enrollment date
            StudentComparer byEnrollment = (a, b) => a.EnrollmentDate.CompareTo(b.EnrollmentDate);
            List<Student> sortedByEnrollment = new List<Student>(students);
            sortedByEnrollment.Sort(Comparer<Student>.Create(byEnrollment));
            Console.WriteLine("\n--- Sorted by Enrollment Date ---");
            sortedByEnrollment.ForEach(s => Console.WriteLine(s));

            // Complex sort using Sort with delegate
            Console.WriteLine("\n--- Complex Sort: GPA desc, Age asc, Name asc ---");
            List<Student> complexSorted = new List<Student>(students);
            complexSorted.Sort((a, b) =>
            {
                int gpaCompare = b.GPA.CompareTo(a.GPA);
                if (gpaCompare != 0) return gpaCompare;
                int ageCompare = a.Age.CompareTo(b.Age);
                if (ageCompare != 0) return ageCompare;
                return string.Compare(a.Name, b.Name, StringComparison.Ordinal);
            });
            complexSorted.ForEach(s => Console.WriteLine(s));
        }
    }

    //10
    class ErrorHandlingDelegateDemo
    {
        public delegate void Operation();
        public delegate void RiskyOperation(out string result);

        static void SafeExecute(Operation op, string operationName)
        {
            try
            {
                Console.WriteLine($"Executing {operationName}...");
                op();
                Console.WriteLine($"{operationName} completed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR in {operationName}] {ex.GetType().Name}: {ex.Message}");
            }
        }

        static void SafeExecuteWithResult(RiskyOperation op, string operationName)
        {
            string result = "failed";
            try
            {
                op(out result);
                Console.WriteLine($"{operationName} result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR in {operationName}] {ex.Message}");
            }
        }

        static void Main()
        {
            Operation[] operations = {
            () => Console.WriteLine("Normal operation"),
            () => { throw new InvalidOperationException("Invalid state"); },
            () => { int x = 0; int y = 10 / x; },
            () => File.ReadAllText("nonexistent.txt"),
            () => Console.WriteLine("Another normal operation")
        };

            for (int i = 0; i < operations.Length; i++)
                SafeExecute(operations[i], $"Operation {i + 1}");

            RiskyOperation divide = (out string res) =>
            {
                int a = 10, b = 0;
                res = (b != 0) ? (a / b).ToString() : "division by zero";
                if (b == 0) throw new DivideByZeroException();
            };

            SafeExecuteWithResult(divide, "Division");
        }
    }

    //11
    public delegate string StringTransform(string input);
    class StringTransformDemo
    {
        static string Reverse(string s) => new string(s.Reverse().ToArray());
        static string TrimAndUpper(string s) => s.Trim().ToUpper();
        static string AddPrefix(string s) => $"[PREFIX] {s}";
        static string AddSuffix(string s) => $"{s} [SUFFIX]";
        static string ReplaceSpaces(string s) => s.Replace(" ", "_");
        static string ToTitleCase(string s) =>
            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());

        static void Main()
        {
            StringTransform[] transforms = {
            Reverse,
            TrimAndUpper,
            AddPrefix,
            AddSuffix,
            ReplaceSpaces,
            ToTitleCase
        };

            string[] inputs = { "  hello world  ", "csharp", " data processing ", "machine learning" };

            foreach (var input in inputs)
            {
                Console.WriteLine($"Input: \"{input}\"");
                foreach (var t in transforms)
                    Console.WriteLine($"  {t.Method.Name}: \"{t(input)}\"");
                Console.WriteLine();
            }
        }
    }

    //12
    public delegate bool SearchPredicate<T>(T item);
    class SearchDemo
    {
        static T Find<T>(List<T> list, SearchPredicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
                if (predicate(list[i])) return list[i];
            return default;
        }

        static IEnumerable<T> FindAll<T>(List<T> list, SearchPredicate<T> predicate)
        {
            var results = new List<T>();
            foreach (var item in list)
                if (predicate(item)) results.Add(item);
            return results;
        }

        static int FindIndex<T>(List<T> list, SearchPredicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
                if (predicate(list[i])) return i;
            return -1;
        }

        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 20).ToList();
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig" };

            // Find first even number
            int firstEven = Find(numbers, x => x % 2 == 0);
            Console.WriteLine($"First even: {firstEven}");

            // Find first number > 15
            int firstGreater15 = Find(numbers, x => x > 15);
            Console.WriteLine($"First > 15: {firstGreater15}");

            // Find all words with length > 5
            var longWords = FindAll(words, w => w.Length > 5);
            Console.WriteLine("Words longer than 5: " + string.Join(", ", longWords));

            // Find index of first word starting with 'c'
            int indexC = FindIndex(words, w => w.StartsWith("c"));
            Console.WriteLine($"First word with 'c' at index: {indexC} ({(indexC >= 0 ? words[indexC] : "none")})");

            // Find first palindrome
            string firstPalindrome = Find(words, w => w.SequenceEqual(w.Reverse()));
            Console.WriteLine($"First palindrome: {firstPalindrome ?? "none"}");
        }
    }

    //13
    public delegate bool Validator<T>(T value);
    class ValidationDemo
    {
        static bool IsValidEmail(string email) =>
            email.Contains("@") && email.Contains(".") && email.Length > 5 && email.IndexOf("@") > 0;

        static bool IsPositive(int n) => n > 0;
        static bool IsInRange(int n, int min, int max) => n >= min && n <= max;
        static bool IsValidPassword(string pwd) =>
            pwd.Length >= 8 && pwd.Any(char.IsUpper) && pwd.Any(char.IsLower) && pwd.Any(char.IsDigit);

        static bool ValidateAll<T>(T value, params Validator<T>[] validators)
        {
            foreach (var v in validators)
                if (!v(value)) return false;
            return true;
        }

        static void Main()
        {
            Validator<string> emailCheck = IsValidEmail;
            Validator<string> passwordCheck = IsValidPassword;
            Validator<int> positiveCheck = IsPositive;

            Console.WriteLine($"Email 'test@example.com': {emailCheck("test@example.com")}");
            Console.WriteLine($"Email 'invalid': {emailCheck("invalid")}");
            Console.WriteLine($"Password 'Pass123word': {passwordCheck("Pass123word")}");
            Console.WriteLine($"Password 'weak': {passwordCheck("weak")}");

            int number = 42;
            Validator<int> rangeCheck = n => IsInRange(n, 1, 100);
            bool valid = ValidateAll(number, positiveCheck, rangeCheck);
            Console.WriteLine($"Number {number} is valid: {valid}");

            string userInput = "User123!";
            bool userValid = ValidateAll(userInput,
                s => s.Length >= 3,
                s => s.Length <= 20,
                s => s.Any(char.IsLetter),
                s => s.Any(char.IsDigit));
            Console.WriteLine($"Username '{userInput}' valid: {userValid}");
        }
    }

    //14
    public delegate string Formatter<T>(T obj);
    class FormatterDemo
    {
        static string FormatDate(DateTime dt) => dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
        static string FormatNumber(double n) => n.ToString("N2");
        static string FormatCurrency(decimal amount) => amount.ToString("C");
        static string FormatBoolean(bool b) => b ? "[YES]" : "[NO]";

        static void Main()
        {
            Formatter<DateTime> dateFmt = FormatDate;
            Formatter<double> numFmt = FormatNumber;
            Formatter<decimal> currencyFmt = FormatCurrency;
            Formatter<bool> boolFmt = FormatBoolean;

            Console.WriteLine($"Date: {dateFmt(DateTime.Now)}");
            Console.WriteLine($"Number: {numFmt(1234.5678)}");
            Console.WriteLine($"Currency: {currencyFmt(999.99m)}");
            Console.WriteLine($"Active: {boolFmt(true)}");

            Formatter<object> universal = obj =>
            {
                if (obj is DateTime dt) return dateFmt(dt);
                if (obj is double d) return numFmt(d);
                if (obj is decimal dec) return currencyFmt(dec);
                if (obj is bool b) return boolFmt(b);
                return obj?.ToString() ?? "null";
            };

            object[] values = { DateTime.Now, 3.14159, 100.50m, false, "text" };
            foreach (var v in values)
                Console.WriteLine($"Universal: {universal(v)}");
        }
    }

    //15
    class ComparisonDemo
    {
        static int CompareLength(string a, string b) => a.Length.CompareTo(b.Length);
        static int CompareAlphabetical(string a, string b) => string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
        static int CompareByVowelCount(string a, string b)
        {
            int countVowels(string s) => s.Count(c => "aeiouAEIOU".Contains(c));
            return countVowels(a).CompareTo(countVowels(b));
        }

        static void Main()
        {
            Comparison<string> cmpLength = CompareLength;
            Comparison<string> cmpAlpha = CompareAlphabetical;
            Comparison<string> cmpVowels = CompareByVowelCount;

            string[] words = { "hello", "world", "a", "programming", "ai" };

            Console.WriteLine($"Length: hello vs world: {cmpLength("hello", "world")}");
            Console.WriteLine($"Alphabetical: Apple vs banana: {cmpAlpha("Apple", "banana")}");
            Console.WriteLine($"Vowels: education vs strength: {cmpVowels("education", "strength")}");

            Array.Sort(words, cmpLength);
            Console.WriteLine("Sorted by length: " + string.Join(", ", words));

            Array.Sort(words, cmpVowels);
            Console.WriteLine("Sorted by vowel count: " + string.Join(", ", words));
        }
    }

    //16
    public delegate T Converter<TInput, TOutput>(TInput input);
    class ConverterDemo
    {
        static double CelsiusToFahrenheit(double c) => c * 9.0 / 5.0 + 32;
        static double FahrenheitToCelsius(double f) => (f - 32) * 5.0 / 9.0;
        static string IntToBinary(int n) => Convert.ToString(n, 2);
        static int BinaryToInt(string bin) => Convert.ToInt32(bin, 2);

        static void Main()
        {
            Converter<double, double> tempCtoF = CelsiusToFahrenheit;
            Converter<double, double> tempFtoC = FahrenheitToCelsius;
            Converter<int, string> intToBin = IntToBinary;
            Converter<string, int> binToInt = BinaryToInt;

            Console.WriteLine($"25°C = {tempCtoF(25):F1}°F");
            Console.WriteLine($"77°F = {tempFtoC(77):F1}°C");
            Console.WriteLine($"10 in binary: {intToBin(10)}");
            Console.WriteLine($"1010 in decimal: {binToInt("1010")}");

            Converter<string, string> reverse = s => new string(s.Reverse().ToArray());
            Console.WriteLine($"Reverse 'hello': {reverse("hello")}");
        }
    }

    //17
    public delegate void Processor<T>(T item);
    class CollectionProcessorDemo
    {
        static void ProcessList<T>(List<T> list, Processor<T> processor)
        {
            Console.WriteLine($"Processing {list.Count} items:");
            foreach (var item in list)
                processor(item);
        }

        static void ProcessWithIndex<T>(List<T> list, Action<T, int> processor)
        {
            for (int i = 0; i < list.Count; i++)
                processor(list[i], i);
        }

        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            ProcessList(numbers, n => Console.WriteLine($"  Square: {n * n}, Cube: {n * n * n}"));

            ProcessList(names, name =>
            {
                Console.WriteLine($"  Name: {name}");
                Console.WriteLine($"    Length: {name.Length}");
                Console.WriteLine($"    Upper: {name.ToUpper()}");
            });

            ProcessWithIndex(numbers, (n, i) =>
                Console.WriteLine($"  [{i}] {n} -> binary: {Convert.ToString(n, 2)}"));
        }
    }

    //18
    public delegate double MathFunction(double x);
    class MathFunctionDemo
    {
        static double Sin(double x) => Math.Sin(x);
        static double Cos(double x) => Math.Cos(x);
        static double Sqrt(double x) => Math.Sqrt(x);
        static double Log(double x) => Math.Log(x);
        static double Exp(double x) => Math.Exp(x);

        static void Main()
        {
            MathFunction[] funcs = { Sin, Cos, Sqrt, Log, Exp };
            string[] names = { "sin", "cos", "sqrt", "log", "exp" };

            double[] inputs = { 0, Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 1, 2, Math.E };

            Console.WriteLine("Mathematical Functions Evaluation:");
            Console.WriteLine($"{"Input",-8} | {"sin",-8} | {"cos",-8} | {"sqrt",-8} | {"log",-8} | {"exp",-8}");
            Console.WriteLine(new string('-', 60));

            foreach (var x in inputs)
            {
                if (x <= 0 && (names.Contains("sqrt") || names.Contains("log"))) continue;
                Console.WriteLine($"{x,-8:F3} | {Sin(x),-8:F3} | {Cos(x),-8:F3} | {Sqrt(x),-8:F3} | {Log(x),-8:F3} | {Exp(x),-8:F3}");
            }
        }
    }

    //19
    public class TreeNode
    {
        public int Value;
        public TreeNode Left, Right;
        public TreeNode(int val) => Value = val;
        public override string ToString() => Value.ToString();
    }

    public delegate void TreeVisitor(TreeNode node);
    class TreeTraversalDemo
    {
        static void InOrder(TreeNode node, TreeVisitor visit)
        {
            if (node == null) return;
            InOrder(node.Left, visit);
            visit(node);
            InOrder(node.Right, visit);
        }

        static void PreOrder(TreeNode node, TreeVisitor visit)
        {
            if (node == null) return;
            visit(node);
            PreOrder(node.Left, visit);
            PreOrder(node.Right, visit);
        }

        static void PostOrder(TreeNode node, TreeVisitor visit)
        {
            if (node == null) return;
            PostOrder(node.Left, visit);
            PostOrder(node.Right, visit);
            visit(node);
        }

        static void LevelOrder(TreeNode root, TreeVisitor visit)
        {
            if (root == null) return;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                visit(node);
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }
        }

        static void Main()
        {
            TreeNode root = new TreeNode(1)
            {
                Left = new TreeNode(2) { Left = new TreeNode(4), Right = new TreeNode(5) },
                Right = new TreeNode(3) { Left = new TreeNode(6), Right = new TreeNode(7) }
            };

            Console.WriteLine("In-order:"); InOrder(root, n => Console.Write(n + " "));
            Console.WriteLine("\nPre-order:"); PreOrder(root, n => Console.Write(n + " "));
            Console.WriteLine("\nPost-order:"); PostOrder(root, n => Console.Write(n + " "));
            Console.WriteLine("\nLevel-order:"); LevelOrder(root, n => Console.Write(n + " "));
            Console.WriteLine();
        }
    }

    //20
    public delegate T Factory<T>(params object[] args);
    class FactoryDemo
    {
        static Random rnd = new Random();

        static int CreateId() => rnd.Next(1000, 9999);
        static DateTime CreateTimestamp() => DateTime.Now;
        static string CreateGuid() => Guid.NewGuid().ToString();

        static User CreateUser(string name, int age)
        {
            return new User { Id = CreateId(), Name = name, Age = age, Created = CreateTimestamp() };
        }

        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public DateTime Created { get; set; }
            public override string ToString() => $"User[Id={Id}, Name={Name}, Age={Age}, Created={Created:yyyy-MM-dd HH:mm:ss}]";
        }

        static void Main()
        {
            Factory<int> idFactory = _ => CreateId();
            Factory<DateTime> timeFactory = _ => CreateTimestamp();
            Factory<string> guidFactory = _ => CreateGuid();
            Factory<User> userFactory = (args) => CreateUser((string)args[0], (int)args[1]);

            Console.WriteLine($"ID: {idFactory()}");
            Console.WriteLine($"Timestamp: {timeFactory()}");
            Console.WriteLine($"GUID: {guidFactory()}");
            Console.WriteLine($"User: {userFactory("Alice", 25)}");
        }
    }

    //21
    class CacheDemo
    {
        static Dictionary<string, (string result, DateTime timestamp)> cache = new Dictionary<string, (string, DateTime)>();
        static TimeSpan cacheDuration = TimeSpan.FromMinutes(5);

        static Func<string, string> CachedOperation(string key, Func<string, string> operation)
        {
            return k =>
            {
                if (cache.TryGetValue(k, out var cached) && DateTime.Now - cached.timestamp < cacheDuration)
                {
                    Console.WriteLine($"[CACHE HIT] {k}");
                    return cached.result;
                }
                else
                {
                    Console.WriteLine($"[CACHE MISS] Computing {k}");
                    var result = operation(k);
                    cache[k] = (result, DateTime.Now);
                    return result;
                }
            };
        }

        static void Main()
        {
            Func<string, string> expensive = s =>
            {
                Thread.Sleep(100);
                return s.ToUpper() + "!";
            };

            var cachedUpper = CachedOperation("upper", expensive);
            var cachedReverse = CachedOperation("reverse", s => new string(s.Reverse().ToArray()));

            Console.WriteLine(cachedUpper("hello"));
            Console.WriteLine(cachedUpper("hello"));
            Console.WriteLine(cachedReverse("world"));
            Console.WriteLine(cachedReverse("world"));

            Console.WriteLine($"Cache size: {cache.Count}");
        }
    }

    //22
    public delegate void Logger(string message, string level = "INFO");
    class LoggingDemo
    {
        static void LogConsole(string msg, string level) => Console.WriteLine($"[{level}] {DateTime.Now:HH:mm:ss} {msg}");
        static void LogFile(string msg, string level) =>
            File.AppendAllText("app.log", $"[{level}] {DateTime.Now:yyyy-MM-dd HH:mm:ss} {msg}\n");
        static void LogDatabase(string msg, string level) =>
            Console.WriteLine($"[DB] INSERT INTO logs (level, message, timestamp) VALUES ('{level}', '{msg}', NOW())");

        static void Main()
        {
            Logger logger = LogConsole;
            logger += LogFile;
            logger += LogDatabase;
            logger += (msg, level) => Console.WriteLine($"[AUDIT] {level}: {msg}");

            logger("Application started", "INFO");
            logger("User login successful", "INFO");
            logger("Database connection failed", "ERROR");
            logger("Security breach detected", "CRITICAL");
        }
    }

    //23
    class TimerDemo
    {
        static void Schedule(Action action, int delayMs, bool repeat = false, int interval = 0)
        {
            if (!repeat)
            {
                Thread.Sleep(delayMs);
                action();
            }
            else
            {
                var timer = new System.Threading.Timer(_ =>
                {
                    action();
                }, null, delayMs, interval);
            }
        }

        static void ScheduleRecurring(Action action, int intervalMs)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(intervalMs, token);
                }
            }, token);
        }

        static void Main()
        {
            Console.WriteLine("Scheduling one-time task in 2 seconds...");
            Schedule(() => Console.WriteLine($"[TIMER] One-time task executed at {DateTime.Now:HH:mm:ss}"), 2000);

            Console.WriteLine("Scheduling recurring task every 3 seconds...");
            ScheduleRecurring(() => Console.WriteLine($"[RECURRING] {DateTime.Now:HH:mm:ss}"), 3000);

            Console.WriteLine("Main thread running... Press Enter to exit.");
            Console.ReadLine();
        }
    }

    //24
    class InputProcessorDemo
    {
        public delegate void InputHandler(string input);
        public delegate bool InputValidator(string input);

        static void ProcessInput(InputHandler handler, InputValidator validator = null)
        {
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            if (validator != null && !validator(input))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            handler(input);
        }

        static void Main()
        {
            InputHandler echo = s => Console.WriteLine($"Echo: {s}");
            InputHandler reverse = s => Console.WriteLine($"Reverse: {new string(s.Reverse().ToArray())}");
            InputHandler count = s => Console.WriteLine($"Length: {s.Length}, Words: {s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}");

            InputValidator notEmpty = s => !string.IsNullOrWhiteSpace(s);
            InputValidator numeric = s => int.TryParse(s, out _);

            ProcessInput(echo);
            ProcessInput(reverse, notEmpty);
            ProcessInput(s => Console.WriteLine($"Upper: {s.ToUpper()}"), notEmpty);
            ProcessInput(count, s => s.Length > 0);
            ProcessInput(s => Console.WriteLine($"Number squared: {int.Parse(s) * int.Parse(s)}"), numeric);
        }
    }

    //25
    class ObserverDemo
    {
        public delegate void Observer(string state);
        public delegate void PropertyChanged(string propertyName, object oldValue, object newValue);

        class Subject
        {
            private List<Observer> observers = new List<Observer>();
            private List<PropertyChanged> propertyObservers = new List<PropertyChanged>();
            private string state;

            public string State
            {
                get => state;
                set
                {
                    var old = state;
                    state = value;
                    Notify(state);
                    NotifyPropertyChanged(nameof(State), old, value);
                }
            }

            public void Subscribe(Observer o) => observers.Add(o);
            public void Unsubscribe(Observer o) => observers.Remove(o);
            public void SubscribeProperty(PropertyChanged o) => propertyObservers.Add(o);
            public void UnsubscribeProperty(PropertyChanged o) => propertyObservers.Remove(o);

            public void Notify(string state)
            {
                foreach (var o in observers) o(state);
            }

            public void NotifyPropertyChanged(string property, object oldVal, object newVal)
            {
                foreach (var o in propertyObservers) o(property, oldVal, newVal);
            }
        }

        static void Main()
        {
            Subject subject = new Subject();

            subject.Subscribe(s => Console.WriteLine($"Observer 1: State is now '{s}'"));
            subject.Subscribe(s => Console.WriteLine($"Observer 2: Received update: {s}"));
            subject.Subscribe(s => Console.WriteLine($"Observer 3: {s.Length} characters"));

            subject.SubscribeProperty((prop, oldV, newV) =>
                Console.WriteLine($"Property '{prop}' changed from '{oldV}' to '{newV}'"));

            subject.State = "initial";
            subject.State = "running";
            subject.State = "completed";
        }
    }

    //26
    class MulticastAddDemo
    {
        delegate void Operation();
        static void Op1() => Console.WriteLine("Operation 1 executed");
        static void Op2() => Console.WriteLine("Operation 2 executed");
        static void Op3() => Console.WriteLine("Operation 3 executed");
        static void Main()
        {
            Operation del = null;
            del += Op1;
            del += Op2;
            del += Op3;
            del += () => Console.WriteLine("Anonymous operation");
            Console.WriteLine($"Invocation list count: {del.GetInvocationList().Length}");
            del();
        }
    }

    //27
    class ChainDemo
    {
        delegate void Step();
        static void Step1() => Console.WriteLine("Step 1: Initialize");
        static void Step2() => Console.WriteLine("Step 2: Process data");
        static void Step3() => Console.WriteLine("Step 3: Validate");
        static void Step4() => Console.WriteLine("Step 4: Save");
        static void Step5() => Console.WriteLine("Step 5: Notify");
        static void Main()
        {
            Step chain = Step1;
            chain += Step2;
            chain += Step3;
            chain += Step4;
            chain += Step5;
            chain += () => Console.WriteLine("Step 6: Cleanup");
            chain();
        }
    }

    //28
    class MulticastDemo
    {
        delegate void Handler(string msg);
        static void Handle1(string m) => Console.WriteLine($"Handler 1: {m}");
        static void Handle2(string m) => Console.WriteLine($"Handler 2: {m.ToUpper()}");
        static void Handle3(string m) => Console.WriteLine($"Handler 3: [{m.Length}] {m}");
        static void Main()
        {
            Handler multicast = Handle1;
            multicast += Handle2;
            multicast += Handle3;
            multicast += m => Console.WriteLine($"Handler 4: {new string(m.Reverse().ToArray())}");
            multicast("multicast delegate demo");
            Console.WriteLine($"Total handlers: {multicast.GetInvocationList().Length}");
        }
    }

    //29
    class SubscriptionDemo
    {
        public delegate void Event();
        class Publisher
        {
            public event Event OnEvent;
            public void Trigger() => OnEvent?.Invoke();
            public void TriggerWithDelay(int ms)
            {
                Thread.Sleep(ms);
                Trigger();
            }
        }

        static void Handler1() => Console.WriteLine("Handler 1 subscribed");
        static void Handler2() => Console.WriteLine("Handler 2 subscribed");

        static void Main()
        {
            Publisher pub = new Publisher();
            pub.OnEvent += Handler1;
            pub.OnEvent += Handler2;
            pub.OnEvent += () => Console.WriteLine("Anonymous handler");
            pub.OnEvent += () => Console.WriteLine($"Timestamp: {DateTime.Now:HH:mm:ss}");

            Console.WriteLine("Triggering event...");
            pub.Trigger();

            Console.WriteLine("Triggering with 1 second delay...");
            pub.TriggerWithDelay(1000);
        }
    }

    //30
    class LogAndEmailDemo
    {
        delegate void Notifier(string msg);
        static void Log(string m) => Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} {m}");
        static void Email(string m) => Console.WriteLine($"[EMAIL] Sending to admin: {m}");
        static void Database(string m) => Console.WriteLine($"[DB] INSERT log: {m}");
        static void Slack(string m) => Console.WriteLine($"[SLACK] #{m}");
        static void Main()
        {
            Notifier notify = Log;
            notify += Email;
            notify += Database;
            notify += Slack;
            notify += m => Console.WriteLine($"[AUDIT] {m}");

            notify("User login failed");
            notify("System backup completed");
            notify("Security alert: unauthorized access");
        }
    }

    //31
    class UnsubscribeDelegateDemo
    {
        public delegate void EventNotification(string message);
        static void Main()
        {
            EventNotification notification = null;

            void LogEvent(string msg) => Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss}: {msg}");
            void SendEmail(string msg) => Console.WriteLine($"[EMAIL] Sending: {msg}");
            void SaveToFile(string msg) => Console.WriteLine($"[FILE] Saving: {msg}");
            void NotifyUser(string msg) => Console.WriteLine($"[ALERT] {msg}");
            void SendSMS(string msg) => Console.WriteLine($"[SMS] SMS: {msg}");

            Console.WriteLine("=== Subscribing ===");
            notification += LogEvent;
            notification += SendEmail;
            notification += SaveToFile;
            notification += NotifyUser;
            notification += SendSMS;

            Console.WriteLine($"Subscribers: {notification.GetInvocationList().Length}");
            notification("System started");

            Console.WriteLine("\n=== Unsubscribing Email ===");
            notification -= SendEmail;
            Console.WriteLine($"Subscribers: {notification.GetInvocationList().Length}");
            notification("Email unsubscribed");

            Console.WriteLine("\n=== Unsubscribing File ===");
            notification -= SaveToFile;
            notification("File save disabled");

            Console.WriteLine("\n=== Practical Example ===");
            var logger = new EventLogger();
            var emailService = new EmailService();
            var alertSystem = new AlertSystem();
            var smsService = new SMSService();

            EventNotification systemNotification = null;
            systemNotification += logger.Log;
            systemNotification += emailService.SendEmail;
            systemNotification += alertSystem.Alert;
            systemNotification += smsService.SendSMS;

            systemNotification("Critical system error");

            Console.WriteLine("\n=== Unsubscribing SMS ===");
            systemNotification -= smsService.SendSMS;
            systemNotification("SMS notifications disabled");

            Console.WriteLine("\n=== Safe invocation ===");
            if (systemNotification != null)
                systemNotification("Final message");
            else
                Console.WriteLine("No subscribers");

            Console.WriteLine("\n=== Clearing all ===");
            systemNotification -= logger.Log;
            systemNotification -= emailService.SendEmail;
            systemNotification -= alertSystem.Alert;
            Console.WriteLine($"Remaining: {systemNotification?.GetInvocationList().Length ?? 0}");
        }
    }

    class EventLogger { public void Log(string m) => Console.WriteLine($"[LOG] {m}"); }
    class EmailService { public void SendEmail(string m) => Console.WriteLine($"[EMAIL] {m}"); }
    class AlertSystem { public void Alert(string m) => Console.WriteLine($"[ALERT] {m}"); }
    class SMSService { public void SendSMS(string m) => Console.WriteLine($"[SMS] {m}"); }

    //32
    class NotificationSystemDemo
    {
        public delegate void Notification(string msg, string channel = "default");
        class Notifier
        {
            private Notification handlers;
            public void Subscribe(Notification handler) => handlers += handler;
            public void Unsubscribe(Notification handler) => handlers -= handler;
            public void Send(string msg, string channel = "default") => handlers?.Invoke(msg, channel);
        }

        static void Main()
        {
            Notifier notifier = new Notifier();

            notifier.Subscribe((m, c) => Console.WriteLine($"[UI] {c}: {m}"));
            notifier.Subscribe((m, c) => Console.WriteLine($"[DB] Saving to {c}: {m}"));
            notifier.Subscribe((m, c) => Console.WriteLine($"[EMAIL] Channel {c}: {m}"));
            notifier.Subscribe((m, c) => Console.WriteLine($"[LOG] {c.ToUpper()}: {m}"));

            notifier.Send("Update available", "system");
            notifier.Send("User logged in", "security");
            notifier.Send("Backup completed", "maintenance");
        }
    }

    //33
    class EventChainDemo
    {
        public delegate void EventHandler(Event evt);
        public class Event
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Timestamp { get; set; }
            public EventPriority Priority { get; set; }
            public List<string> Log { get; set; }
            public Dictionary<string, object> Metadata { get; set; }

            public Event(string name, string description, EventPriority priority)
            {
                Name = name; Description = description; Priority = priority;
                Timestamp = DateTime.Now; Log = new List<string>(); Metadata = new Dictionary<string, object>();
            }

            public override string ToString() => $"[{Priority}] {Name}: {Description}";
        }

        public enum EventPriority { Low, Medium, High, Critical }

        static void Main()
        {
            EventHandler chain = null;

            chain += (evt) =>
            {
                evt.Log.Add($"[1. LOGGER] Event: {evt.Name}, Priority: {evt.Priority}");
                Console.WriteLine($"Logging: {evt.Name}");
                evt.Metadata["logged"] = true;
            };

            chain += (evt) =>
            {
                evt.Log.Add($"[2. PRIORITY] Level: {evt.Priority}");
                Console.WriteLine($"Priority check: {evt.Priority}");
                if (evt.Priority >= EventPriority.High)
                    evt.Metadata["escalated"] = true;
            };

            chain += (evt) =>
            {
                evt.Log.Add($"[3. NOTIFIER] Sending alert");
                Console.WriteLine($"Notification sent for {evt.Priority} event");
                evt.Metadata["notified"] = DateTime.Now;
            };

            chain += (evt) =>
            {
                evt.Log.Add($"[4. STORAGE] Saving to database");
                Console.WriteLine($"Event saved");
                evt.Metadata["saved"] = true;
            };

            chain += (evt) =>
            {
                evt.Log.Add($"[5. ANALYTICS] Processing metrics");
                Console.WriteLine($"Analytics processed");
                evt.Metadata["analyzed"] = true;
            };

            var highEvent = new Event("UserLogin", "User authenticated successfully", EventPriority.High);
            chain(highEvent);

            Console.WriteLine("\n--- Event Log ---");
            foreach (var log in highEvent.Log) Console.WriteLine(log);
            Console.WriteLine($"Metadata: {string.Join(", ", highEvent.Metadata.Select(kv => $"{kv.Key}={kv.Value}"))}");

            var criticalEvent = new Event("SecurityBreach", "Multiple failed login attempts", EventPriority.Critical);
            chain(criticalEvent);

            EventHandler conditionalChain = (evt) =>
            {
                if (evt.Priority >= EventPriority.High)
                {
                    Console.WriteLine($"ALERT: {evt.Priority} priority!");
                    evt.Log.Add($"[ALERT] {evt.Priority} event");
                    evt.Metadata["alert"] = true;
                }
            };

            conditionalChain += (evt) =>
            {
                Console.WriteLine($"LOG: {evt.Description}");
                evt.Log.Add($"[LOG] {evt.Description}");
            };

            conditionalChain += (evt) =>
            {
                if (evt.Priority == EventPriority.Critical)
                {
                    Console.WriteLine("ADMIN NOTIFY: Immediate attention required");
                    evt.Log.Add("[ADMIN] Escalated to admin");
                    evt.Metadata["admin_notified"] = true;
                }
            };

            var systemError = new Event("SystemError", "Core service unavailable", EventPriority.Critical);
            conditionalChain(systemError);

            Console.WriteLine("\n--- Final Log ---");
            foreach (var log in systemError.Log) Console.WriteLine(log);
        }
    }

    //34
    class SequentialOperationsDemo
    {
        delegate void Operation();
        static void Main()
        {
            Operation seq = () => Console.WriteLine("1. Initialize system");
            seq += () => Console.WriteLine("2. Load configuration");
            seq += () => Console.WriteLine("3. Connect to database");
            seq += () => Console.WriteLine("4. Start services");
            seq += () => Console.WriteLine("5. Initialize cache");
            seq += () => Console.WriteLine("6. Start API server");
            seq += () => Console.WriteLine("7. System ready");
            seq();
        }
    }

    //35
    class MultiClassDelegateDemo
    {
        delegate void Worker();
        class WorkerA { public void DoWork() => Console.WriteLine("Worker A: Processing data"); }
        class WorkerB { public void DoWork() => Console.WriteLine("Worker B: Validating input"); }
        class WorkerC { public void DoWork() => Console.WriteLine("Worker C: Saving to storage"); }
        static void Main()
        {
            WorkerA a = new WorkerA();
            WorkerB b = new WorkerB();
            WorkerC c = new WorkerC();

            Worker del = a.DoWork;
            del += b.DoWork;
            del += c.DoWork;
            del += () => Console.WriteLine("Final cleanup");
            del();
        }
    }

    //36
    class MultiActionDemo
    {
        delegate void Action(string data);
        static void Log(string d) => Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} {d}");
        static void Save(string d) => Console.WriteLine($"[SAVE] Persisting: {d}");
        static void Display(string d) => Console.WriteLine($"[DISPLAY] Output: {d}");
        static void Audit(string d) => Console.WriteLine($"[AUDIT] Recording: {d}");
        static void Notify(string d) => Console.WriteLine($"[NOTIFY] Alert: {d}");
        static void Main()
        {
            Action del = Log;
            del += Save;
            del += Display;
            del += Audit;
            del += Notify;
            del("Critical operation completed");
        }
    }

    //37
    class EventSubscriptionSystem
    {
        public delegate void UpdateEvent(string update);
        class Publisher
        {
            public event UpdateEvent OnUpdate;
            private int counter = 0;
            public void Publish(string msg)
            {
                OnUpdate?.Invoke($"[{++counter}] {msg}");
            }
        }

        static void Main()
        {
            Publisher pub = new Publisher();

            pub.OnUpdate += msg => Console.WriteLine($"UI: {msg}");
            pub.OnUpdate += msg => Console.WriteLine($"Logger: {msg}");
            pub.OnUpdate += msg => Console.WriteLine($"Analytics: {msg}");
            pub.OnUpdate += msg => Console.WriteLine($"Backup: {msg}");
            pub.OnUpdate += msg => Console.WriteLine($"Monitor: {msg}");

            pub.Publish("Data updated");
            pub.Publish("Configuration changed");
            pub.Publish("User action performed");
        }
    }

    //38
    class ExceptionChainDemo
    {
        delegate void RiskyOperation();
        static void SafeChain(RiskyOperation chain)
        {
            var handlers = chain.GetInvocationList();
            Console.WriteLine($"Executing {handlers.Length} operations...");

            foreach (RiskyOperation op in handlers)
            {
                try
                {
                    Console.Write($"  {op.Method.Name}... ");
                    op();
                    Console.WriteLine("OK");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"FAILED ({ex.GetType().Name})");
                    Console.WriteLine($"    {ex.Message}");
                }
            }
        }

        static void Main()
        {
            RiskyOperation chain = () => Console.WriteLine("Database connect");
            chain += () => { throw new InvalidOperationException("Service unavailable"); };
            chain += () => Console.WriteLine("Load config");
            chain += () => { int x = 0; int y = 10 / x; };
            chain += () => Console.WriteLine("Start API");
            chain += () => File.ReadAllText("missing.txt");

            SafeChain(chain);
        }
    }

    //39
    class ResultCheckDemo
    {
        delegate bool Validator(string input);
        static void Main()
        {
            Validator chain = s =>
            {
                bool valid = s.Length >= 3;
                Console.WriteLine($"Length check (>=3): {valid}");
                return valid;
            };
            chain += s =>
            {
                bool valid = s.Length <= 20;
                Console.WriteLine($"Length check (<=20): {valid}");
                return valid;
            };
            chain += s =>
            {
                bool valid = s.Any(char.IsLetter);
                Console.WriteLine($"Contains letter: {valid}");
                return valid;
            };
            chain += s =>
            {
                bool valid = s.Any(char.IsDigit);
                Console.WriteLine($"Contains digit: {valid}");
                return valid;
            };

            string[] inputs = { "ab1", "validUser123", "a", "toolongusername123456", "12345" };

            foreach (var input in inputs)
            {
                Console.WriteLine($"\n--- Validating '{input}' ---");
                bool valid = true;
                foreach (Validator v in chain.GetInvocationList())
                {
                    if (!v(input))
                    {
                        valid = false;
                        break;
                    }
                }
                Console.WriteLine($"Overall valid: {valid}");
            }
        }
    }

    //40
    class SyncDemo
    {
        delegate void Task();
        static void SyncTasks(params Task[] tasks)
        {
            Console.WriteLine($"Synchronizing {tasks.Length} tasks...");
            foreach (var t in tasks)
            {
                Console.Write($"  Executing {t.Method.Name}... ");
                t();
                Console.WriteLine("Done");
            }
        }

        static void Main()
        {
            Task t1 = () => { Thread.Sleep(100); Console.Write("Task 1"); };
            Task t2 = () => { Thread.Sleep(50); Console.Write("Task 2"); };
            Task t3 = () => { Thread.Sleep(75); Console.Write("Task 3"); };

            SyncTasks(t1, t2, t3);
        }
    }

    //41
    class AsyncSequentialDemo
    {
        delegate Task AsyncOperation();
        static async Task RunSequential(params AsyncOperation[] ops)
        {
            Console.WriteLine($"Running {ops.Length} async operations sequentially...");
            for (int i = 0; i < ops.Length; i++)
            {
                Console.Write($"  Operation {i + 1}... ");
                await ops[i]();
                Console.WriteLine("Completed");
            }
        }

        static Task Op1() { Console.Write("API call"); return Task.Delay(200); }
        static Task Op2() { Console.Write("DB query"); return Task.Delay(150); }
        static Task Op3() { Console.Write("File IO"); return Task.Delay(100); }

        static async Task Main()
        {
            await RunSequential(Op1, Op2, Op3);
            Console.WriteLine("All operations completed");
        }
    }

    //42
    class ConditionalDelegateDemo
    {
        delegate void ConditionalAction(int value);
        static void Main()
        {
            ConditionalAction ca = v =>
            {
                if (v > 0) Console.WriteLine($"{v} is positive");
            };
            ca += v =>
            {
                if (v % 2 == 0) Console.WriteLine($"{v} is even");
            };
            ca += v =>
            {
                if (v % 3 == 0) Console.WriteLine($"{v} is divisible by 3");
            };
            ca += v =>
            {
                if (v > 100) Console.WriteLine($"{v} is greater than 100");
            };

            int[] numbers = { 6, 15, 150, -5, 101 };
            foreach (var n in numbers)
            {
                Console.WriteLine($"\n--- Checking {n} ---");
                ca(n);
            }
        }
    }

    //43
    class ReduceDemo
    {
        delegate T Accumulator<T>(T acc, T item);
        static T Reduce<T>(IEnumerable<T> source, Accumulator<T> acc, T seed)
        {
            T result = seed;
            int index = 0;
            foreach (var item in source)
            {
                Console.WriteLine($"Step {index++}: {result} + {item} => {acc(result, item)}");
                result = acc(result, item);
            }
            return result;
        }

        static void Main()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            int sum = Reduce(numbers, (a, b) => a + b, 0);
            Console.WriteLine($"Sum: {sum}");

            string concat = Reduce(new[] { "a", "b", "c" }, (a, b) => a + b, "");
            Console.WriteLine($"Concat: {concat}");

            int product = Reduce(numbers, (a, b) => a * b, 1);
            Console.WriteLine($"Product: {product}");
        }
    }

    //44
    class LoggingReduceDemo
    {
        static void Main()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var words = new[] { "hello", "world", "csharp" };

            int sum = numbers.Aggregate(0, (acc, x) =>
            {
                int result = acc + x;
                Console.WriteLine($"{acc} + {x} = {result}");
                return result;
            });
            Console.WriteLine($"Total sum: {sum}");

            string sentence = words.Aggregate("", (acc, w) =>
            {
                string result = acc + (string.IsNullOrEmpty(acc) ? "" : " ") + w;
                Console.WriteLine($"\"{acc}\" + \"{w}\" => \"{result}\"");
                return result;
            });
            Console.WriteLine($"Sentence: {sentence}");
        }
    }

    //45
    class PluginSystemDemo
    {
        public delegate void Plugin(string context);
        class PluginManager
        {
            private List<Plugin> plugins = new List<Plugin>();
            private Dictionary<string, Plugin> namedPlugins = new Dictionary<string, Plugin>();

            public void Register(Plugin p, string name = null)
            {
                plugins.Add(p);
                if (!string.IsNullOrEmpty(name))
                    namedPlugins[name] = p;
            }

            public void Execute(string context = "default")
            {
                Console.WriteLine($"Executing {plugins.Count} plugins for context: {context}");
                foreach (var p in plugins) p(context);
            }

            public void ExecuteNamed(string name, string context)
            {
                if (namedPlugins.TryGetValue(name, out var plugin))
                    plugin(context);
                else
                    Console.WriteLine($"Plugin '{name}' not found");
            }
        }

        static void Main()
        {
            PluginManager pm = new PluginManager();

            pm.Register(context => Console.WriteLine($"Analytics Plugin: {context}"), "analytics");
            pm.Register(context => Console.WriteLine($"Security Plugin: {context}"), "security");
            pm.Register(context => Console.WriteLine($"UI Plugin: {context}"));
            pm.Register(context => Console.WriteLine($"Backup Plugin: {context}"));

            pm.Execute("user-login");
            pm.ExecuteNamed("analytics", "page-view");
            pm.ExecuteNamed("unknown", "test");
        }
    }

    //46
    class MultiValidationDemo
    {
        delegate bool Rule(string input);
        static bool Validate(string input, params Rule[] rules)
        {
            Console.WriteLine($"Validating '{input}' with {rules.Length} rules:");
            bool allValid = true;
            for (int i = 0; i < rules.Length; i++)
            {
                bool valid = rules[i](input);
                Console.WriteLine($"  Rule {i + 1}: {valid}");
                if (!valid) allValid = false;
            }
            return allValid;
        }

        static void Main()
        {
            bool valid = Validate("User123!",
                s => { Console.Write("Length 6-20"); return s.Length >= 6 && s.Length <= 20; },
                s => { Console.Write(", has letter"); return s.Any(char.IsLetter); },
                s => { Console.Write(", has digit"); return s.Any(char.IsDigit); },
                s => { Console.Write(", has symbol"); return s.Any(c => !char.IsLetterOrDigit(c)); }
            );
            Console.WriteLine($"Overall: {valid}");

            Validate("weak",
                s => s.Length >= 8,
                s => s.Any(char.IsUpper),
                s => s.Any(char.IsLower),
                s => s.Any(char.IsDigit));
        }
    }

    //47
    class MultiChannelNotification
    {
        delegate void Channel(string msg, string channel);
        static void Main()
        {
            Channel notify = (m, c) => Console.WriteLine($"[SMS] {c}: {m}");
            notify += (m, c) => Console.WriteLine($"[EMAIL] {c}: {m}");
            notify += (m, c) => Console.WriteLine($"[PUSH] {c}: {m}");
            notify += (m, c) => Console.WriteLine($"[WEBHOOK] POST to {c}: {m}");
            notify += (m, c) => Console.WriteLine($"[SLACK] #{c}: {m}");

            notify("System maintenance", "operations");
            notify("Security alert", "security");
            notify("New user registered", "marketing");
        }
    }

    //48
    class PerformanceMonitorDemo
    {
        delegate void Operation();
        static void Measure(Operation op, string name)
        {
            var sw = Stopwatch.StartNew();
            Console.Write($"Measuring {name}... ");
            op();
            sw.Stop();
            Console.WriteLine($"Completed in {sw.ElapsedMilliseconds}ms");
        }

        static void MeasureMultiple(params (Operation op, string name)[] operations)
        {
            foreach (var (op, name) in operations)
                Measure(op, name);
        }

        static void Main()
        {
            Measure(() => Thread.Sleep(100), "Sleep 100ms");
            Measure(() => Enumerable.Range(1, 1000000).Sum(), "Sum 1M numbers");
            Measure(() => File.WriteAllText("temp.txt", new string('x', 10000)), "Write 10KB file");

            MeasureMultiple(
                (() => Thread.Sleep(50), "Quick sleep"),
                (() => GC.Collect(), "Force GC"),
                (() => Task.Delay(10).Wait(), "Async delay")
            );
        }
    }

    //49
    class CachedLoggingDemo
    {
        static Dictionary<string, (string result, DateTime timestamp, int hits)> cache =
            new Dictionary<string, (string, DateTime, int)>();

        static TimeSpan cacheDuration = TimeSpan.FromSeconds(30);

        static string CachedOp(string key, Func<string, string> op)
        {
            if (cache.TryGetValue(key, out var cached) && DateTime.Now - cached.timestamp < cacheDuration)
            {
                cached.hits++;
                cache[key] = cached;
                Console.WriteLine($"[CACHE HIT] {key} (hits: {cached.hits})");
                return cached.result;
            }
            else
            {
                Console.WriteLine($"[CACHE MISS] Computing {key}");
                var result = op(key);
                cache[key] = (result, DateTime.Now, 1);
                return result;
            }
        }

        static void Main()
        {
            Func<string, string> expensive = s =>
            {
                Thread.Sleep(100);
                return $"{s.ToUpper()} processed at {DateTime.Now:HH:mm:ss}";
            };

            Console.WriteLine(CachedOp("report", expensive));
            Console.WriteLine(CachedOp("report", expensive));
            Console.WriteLine(CachedOp("report", expensive));
            Console.WriteLine(CachedOp("dashboard", expensive));
            Console.WriteLine(CachedOp("report", expensive));

            Console.WriteLine($"\nCache statistics:");
            foreach (var kvp in cache)
                Console.WriteLine($"  {kvp.Key}: {kvp.Value.hits} hits, age: {(DateTime.Now - kvp.Value.timestamp).TotalSeconds:F1}s");
        }
    }

    //50
    class TaskQueueDemo
    {
        delegate void Task();
        class Queue
        {
            private System.Collections.Queue tasks = new System.Collections.Queue();
            private System.Collections.Queue priorities = new System.Collections.Queue();
            private int processed = 0;

            public void Enqueue(Task t, int priority = 0)
            {
                tasks.Enqueue(t);
                priorities.Enqueue(priority);
                Console.WriteLine($"Task enqueued (priority: {priority})");
            }

            public void Process()
            {
                Console.WriteLine($"Processing {tasks.Count} tasks...");
                while (tasks.Count > 0)
                {
                    var task = (Task)tasks.Dequeue();
                    var priority = (int)priorities.Dequeue();
                    Console.Write($"  [{priority}] Executing... ");
                    task();
                    Console.WriteLine($"Done ({++processed})");
                }
            }
        }

        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(() => Console.Write("Low priority task"), 0);
            q.Enqueue(() => Console.Write("High priority task"), 10);
            q.Enqueue(() => Console.Write("Medium priority task"), 5);
            q.Enqueue(() => Console.Write("Another low task"), 0);
            q.Process();
        }
    }

    //51
    class AnonymousMethodDemo
    {
        delegate int Operation(int a, int b);
        delegate string Formatter(int n);
        static void Main()
        {
            Operation add = delegate (int x, int y)
            {
                Console.WriteLine($"Adding {x} + {y}");
                return x + y;
            };

            Operation multiply = delegate (int x, int y)
            {
                Console.WriteLine($"Multiplying {x} * {y}");
                return x * y;
            };

            Formatter binary = delegate (int n)
            {
                return Convert.ToString(n, 2).PadLeft(8, '0');
            };

            Console.WriteLine($"5 + 3 = {add(5, 3)}");
            Console.WriteLine($"5 * 3 = {multiply(5, 3)}");
            Console.WriteLine($"10 in binary: {binary(10)}");
        }
    }

    //52
    class AnonymousFilterDemo
    {
        delegate bool Filter(int n);
        delegate bool StringFilter(string s);

        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 20).ToList();
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig" };

            Filter isEven = delegate (int n)
            {
                Console.WriteLine($"Checking if {n} is even");
                return n % 2 == 0;
            };

            Filter isPrime = delegate (int n)
            {
                if (n < 2) return false;
                Console.WriteLine($"Checking if {n} is prime");
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0) return false;
                return true;
            };

            StringFilter startsWithVowel = delegate (string s)
            {
                char first = char.ToLower(s[0]);
                return "aeiou".Contains(first);
            };

            var evens = numbers.FindAll(isEven);
            var primes = numbers.FindAll(isPrime);
            var vowelWords = words.FindAll(startsWithVowel);

            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
            Console.WriteLine("Prime numbers: " + string.Join(", ", primes));
            Console.WriteLine("Words starting with vowel: " + string.Join(", ", vowelWords));
        }
    }

    //53
    class AnonymousSearchDemo
    {
        delegate bool Predicate<T>(T item);
        static T Find<T>(List<T> list, Predicate<T> pred)
        {
            Console.WriteLine($"Searching {list.Count} items...");
            for (int i = 0; i < list.Count; i++)
            {
                if (pred(list[i]))
                {
                    Console.WriteLine($"Found at index {i}");
                    return list[i];
                }
            }
            Console.WriteLine("Not found");
            return default;
        }

        static void Main()
        {
            var numbers = Enumerable.Range(1, 100).ToList();
            var words = new List<string> { "alpha", "beta", "gamma", "delta", "epsilon" };

            int firstMultipleOf12 = Find(numbers, delegate (int n)
            {
                bool isMultiple = n % 12 == 0;
                if (isMultiple) Console.WriteLine($"{n} is multiple of 12");
                return isMultiple;
            });

            string firstWithE = Find(words, delegate (string s)
            {
                bool hasE = s.Contains('e');
                if (hasE) Console.WriteLine($"'{s}' contains 'e'");
                return hasE;
            });

            Console.WriteLine($"First multiple of 12: {firstMultipleOf12}");
            Console.WriteLine($"First word with 'e': {firstWithE}");
        }
    }

    //54
    class ClosureDemo
    {
        static Func<int, int> CreateMultiplier(int factor)
        {
            int calls = 0;
            return delegate (int x)
            {
                calls++;
                Console.WriteLine($"Multiplier called {calls} times with factor {factor}");
                return x * factor;
            };
        }

        static Func<int, string> CreateFormatter(string prefix)
        {
            return delegate (int n)
            {
                return $"{prefix}: {n} ({Convert.ToString(n, 2)})";
            };
        }

        static void Main()
        {
            var doubleIt = CreateMultiplier(2);
            var tripleIt = CreateMultiplier(3);
            var hexFormatter = CreateFormatter("HEX");
            var binFormatter = CreateFormatter("BIN");

            Console.WriteLine(doubleIt(5));
            Console.WriteLine(doubleIt(10));
            Console.WriteLine(tripleIt(7));
            Console.WriteLine(hexFormatter(255));
            Console.WriteLine(binFormatter(10));
        }
    }

    //55
    class AnonymousEventDemo
    {
        delegate void ButtonClick(int buttonId);
        delegate void KeyPress(char key);

        static void Main()
        {
            ButtonClick click = delegate (int id)
            {
                Console.WriteLine($"Button {id} clicked at {DateTime.Now:HH:mm:ss}");
            };

            KeyPress press = delegate (char key)
            {
                Console.WriteLine($"Key '{key}' pressed (code: {(int)key})");
            };

            click(1);
            click(2);
            press('A');
            press(' ');
            press('Enter');
        }
    }

    //56
    class AnonymousTransformDemo
    {
        delegate string Transform(string s);
        delegate int StringToInt(string s);

        static void Main()
        {
            Transform upper = delegate (string s)
            {
                Console.WriteLine($"Converting '{s}' to uppercase");
                return s.ToUpper();
            };

            Transform reverse = delegate (string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            };

            StringToInt toLength = delegate (string s)
            {
                return s.Length;
            };

            StringToInt countVowels = delegate (string s)
            {
                return s.Count(c => "aeiouAEIOU".Contains(c));
            };

            string[] words = { "hello", "world", "programming" };
            foreach (var word in words)
            {
                Console.WriteLine($"Original: {word}");
                Console.WriteLine($"Upper: {upper(word)}");
                Console.WriteLine($"Reverse: {reverse(word)}");
                Console.WriteLine($"Length: {toLength(word)}");
                Console.WriteLine($"Vowels: {countVowels(word)}");
                Console.WriteLine();
            }
        }
    }

    //57
    class AnonymousValidationDemo
    {
        delegate bool Validate(string input);
        delegate (bool valid, string message) ValidateWithMessage(string input);

        static void Main()
        {
            Validate emailCheck = delegate (string s)
            {
                bool valid = s.Contains("@") && s.Contains(".") && s.Length > 5;
                if (!valid) Console.WriteLine($"Invalid email: {s}");
                return valid;
            };

            ValidateWithMessage passwordCheck = delegate (string s)
            {
                if (s.Length < 8) return (false, "Too short (min 8)");
                if (!s.Any(char.IsUpper)) return (false, "Missing uppercase");
                if (!s.Any(char.IsLower)) return (false, "Missing lowercase");
                if (!s.Any(char.IsDigit)) return (false, "Missing digit");
                return (true, "Valid password");
            };

            string[] emails = { "a@b.c", "invalid", "test@example.com", "user@domain.co.uk" };
            foreach (var email in emails)
                Console.WriteLine($"Email '{email}': {emailCheck(email)}");

            string[] passwords = { "weak", "Str0ng", "password123", "Passw0rd!" };
            foreach (var pwd in passwords)
            {
                var (valid, msg) = passwordCheck(pwd);
                Console.WriteLine($"Password '{pwd}': {valid} - {msg}");
            }
        }
    }
    //58
    class AnonymousSortDemo
    {
        delegate int Compare(string a, string b);
        delegate int IntCompare(int a, int b);

        static void Main()
        {
            List<string> words = new List<string> { "banana", "apple", "cherry", "date", "elderberry" };

            Compare byLength = delegate (string a, string b)
            {
                Console.WriteLine($"Comparing length: '{a}' ({a.Length}) vs '{b}' ({b.Length})");
                return a.Length.CompareTo(b.Length);
            };

            Compare byVowelCount = delegate (string a, string b)
            {
                int countVowels(string s) => s.Count(c => "aeiouAEIOU".Contains(c));
                int va = countVowels(a), vb = countVowels(b);
                Console.WriteLine($"Vowels: '{a}' ({va}) vs '{b}' ({vb})");
                return va.CompareTo(vb);
            };

            IntCompare byValue = delegate (int x, int y)
            {
                Console.WriteLine($"Comparing {x} and {y}");
                return x.CompareTo(y);
            };

            List<int> numbers = new List<int> { 42, 17, 89, 5, 100 };
            numbers.Sort(byValue);

            Console.WriteLine("--- Sorting words by length ---");
            words.Sort(byLength);
            words.ForEach(w => Console.WriteLine(w));

            Console.WriteLine("\n--- Sorting words by vowel count ---");
            words.Sort(byVowelCount);
            words.ForEach(w => Console.WriteLine(w));

            Console.WriteLine("\n--- Sorted numbers ---");
            numbers.ForEach(n => Console.WriteLine(n));
        }
    }

    //59
    class AnonymousFactoryDemo
    {
        delegate Func<T> Factory<T>();
        delegate object Creator();

        static void Main()
        {
            Factory<DateTime> nowFactory = delegate ()
            {
                Console.WriteLine("Creating current timestamp");
                return () => DateTime.Now;
            };

            Factory<string> guidFactory = delegate ()
            {
                return () => Guid.NewGuid().ToString();
            };

            Creator userCreator = delegate ()
            {
                Console.WriteLine("Creating user object");
                return new { Id = Guid.NewGuid(), Name = "User" + new Random().Next(1000, 9999), Created = DateTime.Now };
            };

            var nowFunc = nowFactory();
            var guidFunc = guidFactory();

            Console.WriteLine($"Time: {nowFunc()}");
            Console.WriteLine($"GUID: {guidFunc()}");
            Console.WriteLine($"User: {userCreator()}");
        }
    }

    //60
    class AnonymousCallbackDemo
    {
        delegate void Callback(string result);
        delegate void Progress(int percent);

        static void SimulateAsync(Callback onDone, Progress onProgress)
        {
            for (int i = 0; i <= 100; i += 25)
            {
                Thread.Sleep(100);
                onProgress(i);
            }
            onDone("Download completed");
        }

        static void Main()
        {
            SimulateAsync(
                delegate (string result)
                {
                    Console.WriteLine($"[CALLBACK] {result}");
                },
                delegate (int pct)
                {
                    Console.WriteLine($"[PROGRESS] {pct}%");
                }
            );
        }
    }

    //61
    class LambdaBinaryDemo
    {
        static void Main()
        {
            BinaryOperation add = (x, y) =>
            {
                Console.WriteLine($"Adding {x} + {y}");
                return x + y;
            };

            BinaryOperation multiply = (x, y) => x * y;
            BinaryOperation power = (x, y) => (int)Math.Pow(x, y);
            BinaryOperation modulo = (x, y) => y != 0 ? x % y : 0;

            int a = 8, b = 3;
            Console.WriteLine($"{a} + {b} = {add(a, b)}");
            Console.WriteLine($"{a} * {b} = {multiply(a, b)}");
            Console.WriteLine($"{a}^{b} = {power(a, b)}");
            Console.WriteLine($"{a} % {b} = {modulo(a, b)}");
        }

        delegate int BinaryOperation(int x, int y);
    }

    //62
    class LambdaPredicateDemo
    {
        static void Main()
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Predicate<int> isPrime = n =>
            {
                if (n < 2) return false;
                for (int i = 2; i * i <= n; i++)
                    if (n % i == 0) return false;
                return true;
            };

            Predicate<string> isPalindrome = s => s == new string(s.Reverse().ToArray());
            Predicate<string> hasDigit = s => s.Any(char.IsDigit);

            Console.WriteLine($"10 even: {isEven(10)}");
            Console.WriteLine($"17 prime: {isPrime(17)}");
            Console.WriteLine($"'radar' palindrome: {isPalindrome("radar")}");
            Console.WriteLine($"'abc123' has digit: {hasDigit("abc123")}");
        }
    }

    //63
    class LambdaActionDemo
    {
        static void Main()
        {
            Action<string> log = msg => Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} {msg}");
            Action<int, int> printRange = (start, end) =>
            {
                Console.WriteLine($"Range: {start} to {end}");
                for (int i = start; i <= end; i++) Console.Write($"{i} ");
                Console.WriteLine();
            };

            Action<List<string>> printList = items =>
            {
                Console.WriteLine("List items:");
                items.ForEach(item => Console.WriteLine($"  - {item}"));
            };

            log("System started");
            printRange(1, 5);
            printList(new List<string> { "apple", "banana", "cherry" });
        }
    }

    //64
    class LambdaFuncDemo
    {
        static void Main()
        {
            Func<int, int, int> max = (a, b) => a > b ? a : b;
            Func<double, string> formatCurrency = amount => amount.ToString("C2");
            Func<string, int> wordCount = s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            Func<DateTime, string> formatDate = dt => dt.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"Max(10, 20): {max(10, 20)}");
            Console.WriteLine($"$123.45: {formatCurrency(123.45)}");
            Console.WriteLine($"Words in 'hello world': {wordCount("hello world")}");
            Console.WriteLine($"Now: {formatDate(DateTime.Now)}");
        }
    }

    //65
    class LambdaFilterDemo
    {
        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 30).ToList();
            List<string> fruits = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig" };

            var evens = numbers.Where(n => n % 2 == 0).ToList();
            var multiplesOf3 = numbers.Where(n => n % 3 == 0).ToList();
            var longFruits = fruits.Where(f => f.Length > 5).ToList();
            var startsWithC = fruits.Where(f => f.StartsWith("c", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("Even: " + string.Join(", ", evens));
            Console.WriteLine("Multiples of 3: " + string.Join(", ", multiplesOf3));
            Console.WriteLine("Long fruits: " + string.Join(", ", longFruits));
            Console.WriteLine("Starts with C: " + string.Join(", ", startsWithC));

            var complex = numbers.Where(n => n > 10 && n % 2 == 0 && n % 5 != 0);
            Console.WriteLine("Complex (>10, even, not multiple of 5): " + string.Join(", ", complex));
        }
    }

    //66
    class LambdaSortDemo
    {
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public override string ToString() => $"{Name,-15} ${Price,6:F2} x{Quantity}";
        }

        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 999.99m, Quantity = 5 },
            new Product { Name = "Mouse", Price = 25.50m, Quantity = 50 },
            new Product { Name = "Keyboard", Price = 75.00m, Quantity = 30 },
            new Product { Name = "Monitor", Price = 299.99m, Quantity = 10 }
        };

            Console.WriteLine("Original:");
            products.ForEach(p => Console.WriteLine(p));

            products.Sort((a, b) => a.Price.CompareTo(b.Price));
            Console.WriteLine("\nBy Price asc:");
            products.ForEach(p => Console.WriteLine(p));

            products.Sort((a, b) => b.Quantity.CompareTo(a.Quantity));
            Console.WriteLine("\nBy Quantity desc:");
            products.ForEach(p => Console.WriteLine(p));

            var sorted = products.OrderBy(p => p.Name).ThenByDescending(p => p.Price).ToList();
            Console.WriteLine("\nBy Name then Price desc:");
            sorted.ForEach(p => Console.WriteLine(p));
        }
    }

    //67
    class LambdaTransformDemo
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<string> words = new List<string> { "hello", "world", "csharp", "lambda" };

            var squares = numbers.Select(n => n * n).ToList();
            var cubes = numbers.Select(n => n * n * n).ToList();
            var upperWords = words.Select(w => w.ToUpper()).ToList();
            var lengths = words.Select(w => $"{w}: {w.Length}").ToList();

            Console.WriteLine("Squares: " + string.Join(", ", squares));
            Console.WriteLine("Cubes: " + string.Join(", ", cubes));
            Console.WriteLine("Upper: " + string.Join(", ", upperWords));
            Console.WriteLine("With length: " + string.Join(" | ", lengths));
        }
    }

    //68
    class LambdaAggregateDemo
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] words = { "the", "quick", "brown", "fox" };

            int sum = numbers.Aggregate(0, (acc, n) => acc + n);
            int product = numbers.Aggregate(1, (acc, n) => acc * n);
            int max = numbers.Aggregate(int.MinValue, (acc, n) => acc > n ? acc : n);
            string sentence = words.Aggregate("", (acc, w) => acc + (string.IsNullOrEmpty(acc) ? "" : " ") + w);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Sentence: '{sentence}'");
        }
    }

    //69
    class LambdaGroupDemo
    {
        public class Order
        {
            public string Customer { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; }
        }

        static void Main()
        {
            List<Order> orders = new List<Order>
        {
            new Order { Customer = "Alice", Amount = 100, Category = "Electronics" },
            new Order { Customer = "Bob", Amount = 50, Category = "Books" },
            new Order { Customer = "Alice", Amount = 200, Category = "Electronics" },
            new Order { Customer = "Charlie", Amount = 75, Category = "Books" },
            new Order { Customer = "Bob", Amount = 300, Category = "Furniture" }
        };

            var byCustomer = orders.GroupBy(o => o.Customer);
            Console.WriteLine("By Customer:");
            foreach (var group in byCustomer)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (var o in group) Console.WriteLine($"  {o.Category}: ${o.Amount}");
            }

            var byCategory = orders.GroupBy(o => o.Category).Select(g => new
            {
                Category = g.Key,
                Total = g.Sum(o => o.Amount),
                Count = g.Count()
            });

            Console.WriteLine("\nBy Category Summary:");
            foreach (var g in byCategory)
                Console.WriteLine($"{g.Category}: ${g.Total} ({g.Count} orders)");
        }
    }

    //70
    class LambdaJoinDemo
    {
        public class Student { public int Id { get; set; } public string Name { get; set; } }
        public class Grade { public int StudentId { get; set; } public string Subject { get; set; } public int Score { get; set; } }

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" },
            new Student { Id = 3, Name = "Charlie" }
        };

            List<Grade> grades = new List<Grade>
        {
            new Grade { StudentId = 1, Subject = "Math", Score = 95 },
            new Grade { StudentId = 1, Subject = "English", Score = 88 },
            new Grade { StudentId = 2, Subject = "Math", Score = 72 },
            new Grade { StudentId = 3, Subject = "English", Score = 91 }
        };

            var report = students.Join(grades,
                s => s.Id,
                g => g.StudentId,
                (s, g) => new { s.Name, g.Subject, g.Score });

            Console.WriteLine("Student Grades:");
            foreach (var r in report)
                Console.WriteLine($"{r.Name} - {r.Subject}: {r.Score}");
        }
    }

    //71
    class LambdaExpressionTreeDemo
    {
        static void Main()
        {
            ParameterExpression x = Expression.Parameter(typeof(int), "x");
            ParameterExpression y = Expression.Parameter(typeof(int), "y");

            BinaryExpression add = Expression.Add(x, y);
            BinaryExpression multiply = Expression.Multiply(x, y);
            BinaryExpression power = Expression.Power(x, y);

            var addLambda = Expression.Lambda<Func<int, int, int>>(add, x, y).Compile();
            var mulLambda = Expression.Lambda<Func<int, int, int>>(multiply, x, y).Compile();

            Console.WriteLine($"5 + 3 = {addLambda(5, 3)}");
            Console.WriteLine($"5 * 3 = {mulLambda(5, 3)}");
        }
    }

    //72
    class LambdaCachingDemo
    {
        static Dictionary<string, (Func<string> func, DateTime timestamp)> cache = new();

        static Func<string> Cached(Func<string> expensive, string key)
        {
            return () =>
            {
                if (cache.TryGetValue(key, out var entry) && DateTime.Now - entry.timestamp < TimeSpan.FromSeconds(10))
                {
                    Console.WriteLine($"[CACHE HIT] {key}");
                    return entry.func();
                }
                Console.WriteLine($"[CACHE MISS] {key}");
                var result = expensive();
                cache[key] = (expensive, DateTime.Now);
                return result;
            };
        }

        static void Main()
        {
            Func<string> heavy = () => { Thread.Sleep(100); return DateTime.Now.ToString("O"); };
            var cached = Cached(heavy, "time");

            Console.WriteLine(cached());
            Console.WriteLine(cached());
            Thread.Sleep(11000);
            Console.WriteLine(cached());
        }
    }

    //73
    class LambdaPipelineDemo
    {
        static Func<string, string> Pipeline(params Func<string, string>[] steps)
        {
            return input => steps.Aggregate(input, (current, step) => step(current));
        }

        static void Main()
        {
            var process = Pipeline(
                s => s.Trim(),
                s => s.ToLower(),
                s => s.Replace(" ", "_"),
                s => $"prefix_{s}_suffix"
            );

            Console.WriteLine(process("  Hello World CSharp  "));
        }
    }

    //74
    class LambdaValidatorDemo
    {
        static bool Validate(string input, params Func<string, bool>[] rules)
        {
            return rules.All(rule => rule(input));
        }

        static void Main()
        {
            var isValidUsername = Validate("user123",
                s => s.Length >= 3,
                s => s.Length <= 20,
                s => s.Any(char.IsLetter),
                s => s.Any(char.IsDigit),
                s => !s.Contains(" ")
            );

            Console.WriteLine($"Valid username: {isValidUsername}");
        }
    }

    //75
    class LambdaFactoryDemo
    {
        static Func<T> CreateFactory<T>(T value) => () => value;
        static Func<T> CreateLazyFactory<T>(Func<T> creator) => creator;

        static void Main()
        {
            var nowFactory = CreateFactory(DateTime.Now);
            var guidFactory = CreateLazyFactory(() => Guid.NewGuid());

            Console.WriteLine(nowFactory());
            Console.WriteLine(guidFactory());
            Console.WriteLine(guidFactory());
        }
    }

    //76
    class LambdaEventDemo
    {
        static void Main()
        {
            Action<string> onMessage = null;

            onMessage += msg => Console.WriteLine($"[UI] {msg}");
            onMessage += msg => Console.WriteLine($"[LOG] {msg}");
            onMessage += msg => Console.WriteLine($"[DB] Saved: {msg}");

            onMessage?.Invoke("User logged in");
        }
    }

    //77
    class LambdaCommandDemo
    {
        interface ICommand { void Execute(); }
        class LambdaCommand : ICommand
        {
            private Action action;
            public LambdaCommand(Action a) => action = a;
            public void Execute() => action();
        }

        static void Main()
        {
            var commands = new List<ICommand>
        {
            new LambdaCommand(() => Console.WriteLine("Start service")),
            new LambdaCommand(() => Console.WriteLine("Stop service")),
            new LambdaCommand(() => Thread.Sleep(100)),
            new LambdaCommand(() => Console.WriteLine("Cleanup"))
        };

            foreach (var cmd in commands) cmd.Execute();
        }
    }

    //78
    class LambdaStateMachineDemo
    {
        static void Main()
        {
            string state = "idle";
            var transitions = new Dictionary<string, Func<string, string>>
            {
                ["start"] = s => "running",
                ["pause"] = s => s == "running" ? "paused" : s,
                ["resume"] = s => s == "paused" ? "running" : s,
                ["stop"] = s => "idle"
            };

            string[] events = { "start", "pause", "resume", "stop", "start" };
            foreach (var evt in events)
            {
                state = transitions.ContainsKey(evt) ? transitions[evt](state) : state;
                Console.WriteLine($"{evt} -> {state}");
            }
        }
    }

    //79
    class LambdaRuleEngineDemo
    {
        static bool Evaluate(string input, List<Func<string, bool>> rules)
        {
            return rules.All(r => r(input));
        }

        static void Main()
        {
            var rules = new List<Func<string, bool>>
        {
            s => s.Length >= 8,
            s => s.Any(char.IsUpper),
            s => s.Any(char.IsLower),
            s => s.Any(char.IsDigit),
            s => s.Any(c => "!@#$%^&*".Contains(c))
        };

            Console.WriteLine($"StrongPass1!: {Evaluate("StrongPass1!", rules)}");
            Console.WriteLine($"weak: {Evaluate("weak", rules)}");
        }
    }

    //80
    class LambdaQueryDemo
    {
        public class LogEntry
        {
            public DateTime Timestamp { get; set; }
            public string Level { get; set; }
            public string Message { get; set; }
        }

        static void Main()
        {
            var logs = new List<LogEntry>
        {
            new LogEntry { Timestamp = DateTime.Now.AddHours(-1), Level = "INFO", Message = "App started" },
            new LogEntry { Timestamp = DateTime.Now.AddMinutes(-30), Level = "ERROR", Message = "DB connection failed" },
            new LogEntry { Timestamp = DateTime.Now.AddMinutes(-10), Level = "WARN", Message = "High memory" },
            new LogEntry { Timestamp = DateTime.Now, Level = "INFO", Message = "Request processed" }
        };

            var errors = logs.Where(l => l.Level == "ERROR").ToList();
            var recent = logs.Where(l => l.Timestamp > DateTime.Now.AddMinutes(-15)).ToList();

            Console.WriteLine("Errors:");
            errors.ForEach(e => Console.WriteLine($"  {e.Timestamp:HH:mm} [{e.Level}] {e.Message}"));

            Console.WriteLine("Recent:");
            recent.ForEach(e => Console.WriteLine($"  {e.Timestamp:HH:mm} [{e.Level}] {e.Message}"));
        }
    }

    //81
    class LambdaConfigDemo
    {
        static void Main()
        {
            var config = new Dictionary<string, Func<object>>
            {
                ["version"] = () => "1.0.0",
                ["timeout"] = () => 30,
                ["debug"] = () => Environment.GetEnvironmentVariable("DEBUG") == "1",
                ["apiUrl"] = () => "https://api.example.com"
            };

            foreach (var kv in config)
                Console.WriteLine($"{kv.Key}: {kv.Value()}");
        }
    }

    //82
    class LambdaRetryDemo
    {
        static T Retry<T>(Func<T> operation, int attempts = 3)
        {
            Exception lastError = null;
            for (int i = 0; i < attempts; i++)
            {
                try { return operation(); }
                catch (Exception ex)
                {
                    lastError = ex;
                    Console.WriteLine($"Attempt {i + 1} failed: {ex.Message}");
                    Thread.Sleep(100 * (i + 1));
                }
            }
            throw lastError ?? new Exception("Unknown error");
        }

        static void Main()
        {
            try
            {
                var result = Retry(() =>
                {
                    if (new Random().Next(5) > 2) throw new InvalidOperationException("Random failure");
                    return "Success!";
                });
                Console.WriteLine(result);
            }
            catch (Exception ex) { Console.WriteLine($"Failed: {ex.Message}"); }
        }
    }

    //83
    class LambdaCircuitBreakerDemo
    {
        static async Task<T> CircuitBreaker<T>(Func<Task<T>> operation, int failureThreshold = 3)
        {
            int failures = 0;
            while (true)
            {
                try
                {
                    var result = await operation();
                    failures = 0;
                    return result;
                }
                catch
                {
                    failures++;
                    if (failures >= failureThreshold)
                    {
                        Console.WriteLine("Circuit OPEN - failing fast");
                        throw;
                    }
                    Console.WriteLine($"Failure {failures}, retrying...");
                    await Task.Delay(100);
                }
            }
        }

        static Task<string> Unreliable() => Task.FromResult(new Random().Next(10) > 7 ? "OK" : throw new Exception("Fail"));

        static async Task Main()
        {
            try { Console.WriteLine(await CircuitBreaker(Unreliable)); }
            catch { Console.WriteLine("Operation failed"); }
        }
    }

    //84
    class LambdaThrottlingDemo
    {
        static async Task<T> Throttle<T>(Func<Task<T>> operation, int maxPerSecond = 5)
        {
            var semaphore = new SemaphoreSlim(maxPerSecond);
            await semaphore.WaitAsync();
            try { return await operation(); }
            finally { _ = Task.Delay(1000 / maxPerSecond).ContinueWith(_ => semaphore.Release()); }
        }

        static Task<int> Work() => Task.FromResult(Environment.TickCount);

        static async Task Main()
        {
            var tasks = Enumerable.Range(0, 10).Select(_ => Throttle(Work));
            var results = await Task.WhenAll(tasks);
            Console.WriteLine(string.Join(", ", results));
        }
    }

    //85
    class LambdaObserverPatternDemo
    {
        static void Main()
        {
            var subject = new Subject<string>();
            subject.Subscribe(msg => Console.WriteLine($"Observer 1: {msg}"));
            subject.Subscribe(msg => Console.WriteLine($"Observer 2: {msg.ToUpper()}"));

            subject.Notify("update 1");
            subject.Notify("update 2");
        }
    }

    class Subject<T>
    {
        private List<Action<T>> observers = new();
        public void Subscribe(Action<T> observer) => observers.Add(observer);
        public void Notify(T value) => observers.ForEach(o => o(value));
    }

    //86
    class LambdaStrategyDemo
    {
        static decimal Calculate(Func<decimal, decimal, decimal> strategy, decimal a, decimal b)
        {
            return strategy(a, b);
        }

        static void Main()
        {
            var strategies = new Dictionary<string, Func<decimal, decimal, decimal>>
            {
                ["add"] = (a, b) => a + b,
                ["mul"] = (a, b) => a * b,
                ["max"] = (a, b) => Math.Max(a, b)
            };

            Console.WriteLine(Calculate(strategies["add"], 5, 3));
            Console.WriteLine(Calculate(strategies["mul"], 5, 3));
            Console.WriteLine(Calculate(strategies["max"], 5, 3));
        }
    }

    //87
    class LambdaDecoratorDemo
    {
        static Func<int, int> Decorate(Func<int, int> func, Action before = null, Action after = null)
        {
            return x =>
            {
                before?.Invoke();
                var result = func(x);
                after?.Invoke();
                return result;
            };
        }

        static void Main()
        {
            Func<int, int> square = x => x * x;
            var logged = Decorate(square,
                () => Console.WriteLine("Before square"),
                () => Console.WriteLine("After square"));

            Console.WriteLine(logged(5));
        }
    }

    //88
    class LambdaMemoizationDemo
    {
        static Func<T, R> Memoize<T, R>(Func<T, R> func)
        {
            var cache = new Dictionary<T, R>();
            return arg =>
            {
                if (!cache.ContainsKey(arg))
                    cache[arg] = func(arg);
                return cache[arg];
            };
        }

        static void Main()
        {
            Func<int, int> fib = null;
            fib = Memoize(n => n <= 1 ? n : fib(n - 1) + fib(n - 2));

            Console.WriteLine(fib(10));
        }
    }

    //89
    class LambdaFluentDemo
    {
        class Builder
        {
            private string result = "";
            public Builder Append(string s) { result += s; return this; }
            public Builder NewLine() { result += "\n"; return this; }
            public string Build() => result;
        }

        static void Main()
        {
            var text = new Builder()
                .Append("Line 1")
                .NewLine()
                .Append("Line 2")
                .NewLine()
                .Append("Line 3")
                .Build();

            Console.WriteLine(text);
        }
    }

    //90
    class LambdaExpressionVisitorDemo
    {
        static void Main()
        {
            Expression<Func<int, int, bool>> expr = (a, b) => a > b && a % 2 == 0;
            var visitor = new CustomVisitor();
            visitor.Visit(expr);
        }
    }

    class CustomVisitor : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            Console.WriteLine($"Binary: {node.NodeType} ({node.Left} {node.NodeType} {node.Right})");
            return base.VisitBinary(node);
        }
    }

    //91
    class LambdaDynamicDispatchDemo
    {
        static void Main()
        {
            dynamic x = 10;
            dynamic y = "hello";

            Func<dynamic, string> describe = obj => obj switch
            {
                int i => $"Integer: {i}",
                string s => $"String: {s}",
                _ => "Unknown"
            };

            Console.WriteLine(describe(x));
            Console.WriteLine(describe(y));
        }
    }

    //92
    class LambdaAsyncStreamDemo
    {
        static async IAsyncEnumerable<int> GenerateAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i * i;
            }
        }

        static async Task Main()
        {
            await foreach (var sq in GenerateAsync())
                Console.WriteLine(sq);
        }
    }

    //93
    class LambdaPatternMatchingDemo
    {
        static string Describe(object obj) => obj switch
        {
            int i when i > 0 => "Positive int",
            int i => "Non-positive int",
            string { Length: > 5 } s => $"Long string: {s}",
            string s => $"Short string: {s}",
            null => "null",
            _ => "other"
        };

        static void Main()
        {
            Console.WriteLine(Describe(5));
            Console.WriteLine(Describe("hello"));
            Console.WriteLine(Describe("hi"));
            Console.WriteLine(Describe(null));
        }
    }

    //94
    class LambdaSourceGeneratorDemo
    {
        static void Log(string message) => Console.WriteLine($"[LOG] {message}");

        static void Main()
        {
            Log("Generated logging");
        }
    }

    //95
    class LambdaRecordDemo
    {
        public record Person(string Name, int Age);
        public record Employee(string Name, int Age, string Department) : Person(Name, Age);

        static void Main()
        {
            var p1 = new Person("Alice", 30);
            var p2 = new Person("Alice", 30);
            Console.WriteLine(p1 == p2);

            var e = new Employee("Bob", 25, "IT");
            Console.WriteLine(e);
        }
    }

    //96
    class LambdaInitDemo
    {
        public class Config
        {
            public string Host { get; init; }
            public int Port { get; init; }
            public bool Debug { get; init; }
        }

        static void Main()
        {
            var cfg = new Config { Host = "localhost", Port = 8080, Debug = true };
            Console.WriteLine($"{cfg.Host}:{cfg.Port} Debug={cfg.Debug}");
        }
    }

    //97
    class LambdaLinqToSqlDemo
    {
        static void Main()
        {
            // Simulated
            var query = from x in new[] { 1, 2, 3 }
                        where x > 1
                        select x;
            foreach (var x in query) Console.WriteLine(x);
        }
    }

    //98
    class LambdaAnonymousDemo
    {
        static void Main()
        {
            var anon = new[] { 1, 2, 3 }.Select(x => new { Value = x, Square = x * x });
            foreach (var a in anon) Console.WriteLine($"{a.Value}^2 = {a.Square}");
        }
    }

    //99
    class LambdaFileDemo
    {
        static void Main()
        {
            var files = Directory.GetFiles(".");
            var txtFiles = files.Where(f => Path.GetExtension(f) == ".txt");
            foreach (var f in txtFiles) Console.WriteLine(f);
        }
    }

    //100
    class LambdaFinalDemo
    {
        static void Main()
        {
            Console.WriteLine("=== Lambda Expressions Summary ===");


            Func<int, int> square = x => x * x;
            Action<string> log = msg => Console.WriteLine(msg);
            Predicate<int> isEven = n => n % 2 == 0;


            Func<int, int> pipeline = x => square(x * 2);

            Func<Task<int>> asyncOp = async () => await Task.FromResult(42);

            string describe(int n) => n switch { > 0 => "pos", 0 => "zero", _ => "neg" };

            Console.WriteLine($"100² = {square(100)}");
            log("Lambda complete!");
            Console.WriteLine($"Even: {isEven(4)}");
            Console.WriteLine($"Pipeline: {pipeline(5)}");
            Console.WriteLine(describe(-1));
        }
    }
}