//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Drawing;
//using System.Globalization;
//using System.IO;
//using System.IO.Compression;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Security.Cryptography;
//using System.Text;
//using System.Text.Json;
//using System.Text.RegularExpressions;
//using System.Xml;

//namespace CSharpTasks
//{
//    //1
//    public class Counter
//    {
//        public static int count = 0;
//        public static void Increment()
//        {
//            count++;
//        }
//    }

//    //2
//    public class Calculator
//    {
//        public static int Add(int a, int b) => a + b;
//        public static int Subtract(int a, int b) => a - b;
//        public static int Multiply(int a, int b) => a * b;
//        public static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
//    }

//    //3
//    public class StaticConstructorExample
//    {
//        public static string Data;
//        static StaticConstructorExample()
//        {
//            Data = "Initialized in static constructor";
//        }
//    }

//    //4
//    public class Logger
//    {
//        public static void LogToFile(string message, string filePath)
//        {
//            File.AppendAllText(filePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
//        }
//    }

//    //5
//    public class ApplicationConfig
//    {
//        private static string _applicationName = "MyApp";
//        private static int _maxConnections = 100;
//        public static string ApplicationName
//        {
//            get { return _applicationName; }
//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                    _applicationName = value;
//            }
//        }
//        public static int MaxConnections
//        {
//            get { return _maxConnections; }
//            set
//            {
//                if (value > 0)
//                    _maxConnections = value;
//            }
//        }
//        public static void DisplayConfig()
//        {
//            Console.WriteLine($"Application: {ApplicationName}");
//            Console.WriteLine($"Max Connections: {MaxConnections}");
//        }
//    }

//    //6
//    public class ObjectCounter
//    {
//        private static int _count = 0;
//        public ObjectCounter()
//        {
//            _count++;
//        }
//        public static int GetCount() => _count;
//    }

//    //7
//    public class ConfigManager
//    {
//        private const string ConfigFile = "config.txt";
//        public static string ReadConfig(string key)
//        {
//            if (File.Exists(ConfigFile))
//            {
//                var lines = File.ReadAllLines(ConfigFile);
//                foreach (var line in lines)
//                {
//                    var parts = line.Split('=');
//                    if (parts.Length == 2 && parts[0] == key)
//                        return parts[1];
//                }
//            }
//            return null;
//        }
//        public static void WriteConfig(string key, string value)
//        {
//            var config = File.Exists(ConfigFile) ? File.ReadAllText(ConfigFile) : string.Empty;
//            config += $"{key}={value}{Environment.NewLine}";
//            File.WriteAllText(ConfigFile, config);
//        }
//    }

//    //8
//    public class MathHelper
//    {
//        public static double SquareRoot(double x) => Math.Sqrt(x);
//        public static double Power(double x, double y) => Math.Pow(x, y);
//        public static double Absolute(double x) => Math.Abs(x);
//    }

//    //9
//    public class AppVersion
//    {
//        public static readonly string Version = "1.0.0";
//        public static readonly DateTime ReleaseDate = new DateTime(2025, 11, 3);
//        public static readonly string BuildNumber = "20251103.1";
//        private static readonly string _companyName = "TechCorp";
//        public static string CompanyName => _companyName;
//        public static string GetFullVersionInfo()
//        {
//            return $"{_companyName} - Version {Version} (Build {BuildNumber}) - Released: {ReleaseDate:yyyy-MM-dd}";
//        }
//    }

//    //10
//    public class ValidationHelper
//    {
//        public static bool IsEmailValid(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//        public static bool IsPositive(int number) => number > 0;
//    }

//    //11
//    public class DateTimeHelper
//    {
//        public static DateTime AddDays(DateTime date, int days) => date.AddDays(days);
//        public static bool IsWeekend(DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
//    }

//    //12
//    public class StringHelper
//    {
//        public static string Reverse(string s) => new string(s.ToCharArray().Reverse().ToArray());
//        public static string ToUpper(string s) => s.ToUpper();
//    }

//    //13
//    public class MultiStaticFields
//    {
//        public static int IntField = 42;
//        public static string StringField = "Hello";
//        public static double DoubleField = 3.14;
//        public static int GetInt() => IntField;
//        public static string GetString() => StringField;
//        public static double GetDouble() => DoubleField;
//    }

//    //14
//    public class FileHelper
//    {
//        public static bool Exists(string path) => File.Exists(path);
//        public static string ReadAllText(string path) => File.ReadAllText(path);
//        public static void WriteAllText(string path, string content) => File.WriteAllText(path, content);
//    }

//    //15
//    public class Constants
//    {
//        public const int MaxValue = 100;
//        public const string AppName = "CSharpApp";
//        public const double Pi = 3.14159;
//    }

//    //16
//    public class HashHelper
//    {
//        public static string ComputeMD5(string input)
//        {
//            using (MD5 md5 = MD5.Create())
//            {
//                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
//                return BitConverter.ToString(hash).Replace("-", "").ToLower();
//            }
//        }
//        public static string ComputeSHA256(string input)
//        {
//            using (SHA256 sha256 = SHA256.Create())
//            {
//                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
//                return BitConverter.ToString(hash).Replace("-", "").ToLower();
//            }
//        }
//    }

//    //17
//    public class StaticEventsExample
//    {
//        public static event Action<string> OnMessage;
//        public static void RaiseEvent(string message)
//        {
//            OnMessage?.Invoke(message);
//        }
//        public static void Subscribe(Action<string> handler)
//        {
//            OnMessage += handler;
//        }
//        public static void Unsubscribe(Action<string> handler)
//        {
//            OnMessage -= handler;
//        }
//    }

//    //18
//    public class ConversionHelper
//    {
//        public static int ToInt(string s) => int.Parse(s);
//        public static double ToDouble(string s) => double.Parse(s);
//        public static string ToString(object o) => o.ToString();
//    }

//    //19
//    public class Timer
//    {
//        public static long MeasureExecutionTime(Action action)
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            action();
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }
//    }

//    //20
//    public class RandomGenerator
//    {
//        private static Random _random = new Random();
//        public static int NextInt(int min, int max) => _random.Next(min, max);
//        public static double NextDouble() => _random.NextDouble();
//    }




//    //21
//    public static class Utils
//    {
//        public static bool IsNullOrEmpty(string s) => string.IsNullOrEmpty(s);
//        public static int Clamp(int value, int min, int max) => Math.Max(min, Math.Min(max, value));
//        public static string GenerateGuid() => Guid.NewGuid().ToString();
//    }

//    //22
//    public static class Extensions
//    {
//        public static string Reverse(this string s) => new string(s.ToCharArray().Reverse().ToArray());
//        public static bool ContainsIgnoreCase(this string s, string value) => s.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
//        public static string TrimAll(this string s) => s.Trim();
//    }

//    //23
//    public static class DatabaseHelper
//    {
//        public static string GetConnectionString(string server, string db) => $"Server={server};Database={db};Trusted_Connection=True;";
//        public static void ExecuteQuery(string connectionString, string query) { Console.WriteLine($"Executing: {query} on {connectionString}"); }
//    }

//    //24
//    public static class CryptographyHelper
//    {
//        public static string Encrypt(string text, string key)
//        {
//            using (Aes aes = Aes.Create())
//            {
//                aes.Key = Encoding.UTF8.GetBytes(key);
//                aes.IV = new byte[16];
//                ICryptoTransform encryptor = aes.CreateEncryptor();
//                using (MemoryStream ms = new MemoryStream())
//                {
//                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
//                    {
//                        using (StreamWriter sw = new StreamWriter(cs))
//                        {
//                            sw.Write(text);
//                        }
//                    }
//                    return Convert.ToBase64String(ms.ToArray());
//                }
//            }
//        }
//        public static string Decrypt(string cipherText, string key)
//        {
//            using (Aes aes = Aes.Create())
//            {
//                aes.Key = Encoding.UTF8.GetBytes(key);
//                aes.IV = new byte[16];
//                ICryptoTransform decryptor = aes.CreateDecryptor();
//                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
//                {
//                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
//                    {
//                        using (StreamReader sr = new StreamReader(cs))
//                        {
//                            return sr.ReadToEnd();
//                        }
//                    }
//                }
//            }
//        }
//    }

//    //25
//    public static class HttpHelper
//    {
//        private static readonly HttpClient client = new HttpClient();
//        public static string Get(string url)
//        {
//            return client.GetStringAsync(url).Result;
//        }
//        public static void Post(string url, string data)
//        {
//            client.PostAsync(url, new StringContent(data)).Wait();
//        }
//    }

//    //26
//    public static class JsonHelper
//    {
//        public static string Serialize(object obj) => JsonSerializer.Serialize(obj);
//        public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json);
//    }

//    //27
//    public static class RegexHelper
//    {
//        public static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//        public static readonly Regex PhoneRegex = new Regex(@"^\+?\d{10,15}$");
//        public static bool IsMatch(string input, Regex regex) => regex.IsMatch(input);
//    }

//    //28
//    public static class ImageProcessor
//    {
//        public static void Resize(string inputPath, string outputPath, int width, int height)
//        {
//            using (Image image = Image.FromFile(inputPath))
//            {
//                using (Bitmap resized = new Bitmap(image, width, height))
//                {
//                    resized.Save(outputPath);
//                }
//            }
//        }
//        public static void Grayscale(string inputPath, string outputPath)
//        {
//            Console.WriteLine($"Converting {inputPath} to grayscale at {outputPath}");
//        }
//    }

//    //29
//    public static class EmailValidator
//    {
//        public static bool IsValid(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//    }

//    //30
//    public static class PasswordGenerator
//    {
//        private static readonly Random random = new Random();
//        public static string Generate(int length)
//        {
//            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
//            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
//        }
//    }

//    //31
//    public static class XmlHelper
//    {
//        public static string EscapeXml(string text)
//        {
//            if (string.IsNullOrEmpty(text))
//                return text;

//            return text
//                .Replace("&", "&amp;")
//                .Replace("<", "&lt;")
//                .Replace(">", "&gt;")
//                .Replace("\"", "&quot;")
//                .Replace("'", "&apos;");
//        }

//        public static string CreateElement(string tagName, string content)
//        {
//            return $"<{tagName}>{EscapeXml(content)}</{tagName}>";
//        }

//        public static string CreateElementWithAttributes(string tagName, string content, params (string key, string value)[] attributes)
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append($"<{tagName}");

//            foreach (var attr in attributes)
//            {
//                sb.Append($" {attr.key}=\"{EscapeXml(attr.value)}\"");
//            }

//            sb.Append($">{EscapeXml(content)}</{tagName}>");
//            return sb.ToString();
//        }

//        public static string CreateDocument(string rootElement, string content)
//        {
//            return $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<{rootElement}>\n{content}\n</{rootElement}>";
//        }

//        public static string ExtractContent(string xml, string tagName)
//        {
//            string openTag = $"<{tagName}>";
//            string closeTag = $"</{tagName}>";

//            int startIndex = xml.IndexOf(openTag);
//            int endIndex = xml.IndexOf(closeTag);

//            if (startIndex >= 0 && endIndex > startIndex)
//            {
//                startIndex += openTag.Length;
//                return xml.Substring(startIndex, endIndex - startIndex);
//            }

//            return null;
//        }
//    }

//    //32
//    public static class NetworkHelper
//    {
//        public static string GetLocalIPAddress()
//        {
//            return Dns.GetHostName();
//        }
//        public static bool IsOnline() => true;
//    }

//    //33
//    public static class SecurityHelper
//    {
//        public static string ComputeSHA256Hash(string input)
//        {
//            using (SHA256 sha256 = SHA256.Create())
//            {
//                byte[] bytes = Encoding.UTF8.GetBytes(input);
//                byte[] hash = sha256.ComputeHash(bytes);

//                StringBuilder sb = new StringBuilder();
//                foreach (byte b in hash)
//                {
//                    sb.Append(b.ToString("x2"));
//                }
//                return sb.ToString();
//            }
//        }

//        public static string ComputeMD5Hash(string input)
//        {
//            using (MD5 md5 = MD5.Create())
//            {
//                byte[] bytes = Encoding.UTF8.GetBytes(input);
//                byte[] hash = md5.ComputeHash(bytes);

//                StringBuilder sb = new StringBuilder();
//                foreach (byte b in hash)
//                {
//                    sb.Append(b.ToString("x2"));
//                }
//                return sb.ToString();
//            }
//        }

//        public static string GenerateRandomKey(int length)
//        {
//            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//            byte[] randomBytes = new byte[length];

//            using (var rng = RandomNumberGenerator.Create())
//            {
//                rng.GetBytes(randomBytes);
//            }

//            StringBuilder sb = new StringBuilder(length);
//            foreach (byte b in randomBytes)
//            {
//                sb.Append(chars[b % chars.Length]);
//            }

//            return sb.ToString();
//        }

//        public static string XorEncrypt(string input, string key)
//        {
//            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
//                return input;

//            StringBuilder result = new StringBuilder();
//            for (int i = 0; i < input.Length; i++)
//            {
//                result.Append((char)(input[i] ^ key[i % key.Length]));
//            }

//            return Convert.ToBase64String(Encoding.UTF8.GetBytes(result.ToString()));
//        }

//        public static string XorDecrypt(string encrypted, string key)
//        {
//            if (string.IsNullOrEmpty(encrypted) || string.IsNullOrEmpty(key))
//                return encrypted;

//            byte[] encryptedBytes = Convert.FromBase64String(encrypted);
//            string encryptedString = Encoding.UTF8.GetString(encryptedBytes);

//            StringBuilder result = new StringBuilder();
//            for (int i = 0; i < encryptedString.Length; i++)
//            {
//                result.Append((char)(encryptedString[i] ^ key[i % key.Length]));
//            }

//            return result.ToString();
//        }
//    }

//    //34
//    public static class PathHelper
//    {
//        public static string Combine(params string[] paths) => Path.Combine(paths);
//        public static string GetExtension(string path) => Path.GetExtension(path);
//    }

//    //35
//    public static class ColorHelper
//    {
//        public static Color FromRgb(int r, int g, int b) => Color.FromArgb(r, g, b);
//        public static string ToHex(Color color) => $"#{color.R:X2}{color.G:X2}{color.B:X2}";
//    }

//    //36
//    public static class CompressionHelper
//    {
//        public static byte[] Compress(byte[] data)
//        {
//            using (MemoryStream ms = new MemoryStream())
//            {
//                using (GZipStream gs = new GZipStream(ms, CompressionMode.Compress))
//                {
//                    gs.Write(data, 0, data.Length);
//                }
//                return ms.ToArray();
//            }
//        }
//        public static byte[] Decompress(byte[] compressed)
//        {
//            using (MemoryStream ms = new MemoryStream(compressed))
//            {
//                using (GZipStream gs = new GZipStream(ms, CompressionMode.Decompress))
//                {
//                    using (MemoryStream output = new MemoryStream())
//                    {
//                        gs.CopyTo(output);
//                        return output.ToArray();
//                    }
//                }
//            }
//        }
//    }

//    //37
//    public static class EnvironmentHelper
//    {
//        public static string GetVariable(string name) => Environment.GetEnvironmentVariable(name);
//        public static void SetVariable(string name, string value) => Environment.SetEnvironmentVariable(name, value);
//    }

//    //38
//    public static class UrlHelper
//    {
//        public static string Encode(string url) => WebUtility.UrlEncode(url);
//        public static string Decode(string url) => WebUtility.UrlDecode(url);
//    }

//    //39
//    public static class TextProcessor
//    {
//        public static string RemovePunctuation(string text) => new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
//        public static string NormalizeWhitespace(string text) => Regex.Replace(text, @"\s+", " ");
//    }

//    //40
//    public static class SystemInfo
//    {
//        public static string GetOSVersion() => Environment.OSVersion.ToString();
//        public static int GetProcessorCount() => Environment.ProcessorCount;
//    }

//    //41
//    public static class StringExtensions
//    {
//        public static bool IsPalindrome(this string s)
//        {
//            s = s.ToLower().Replace(" ", "");
//            return s == new string(s.Reverse().ToArray());
//        }
//    }

//    //42
//    public static class ArrayExtensions
//    {
//        private static readonly Random random = new Random();
//        public static T RandomElement<T>(this T[] array) => array[random.Next(array.Length)];
//    }

//    //43
//    public static class IntExtensions
//    {
//        public static bool IsEven(this int n) => n % 2 == 0;
//    }

//    //44
//    public static class DateTimeExtensions
//    {
//        public static int GetAge(this DateTime birthDate)
//        {
//            var today = DateTime.Today;
//            int age = today.Year - birthDate.Year;
//            if (birthDate.Date > today.AddYears(-age)) age--;
//            return age;
//        }
//    }

//    //45
//    public static class StringExtensions2
//    {
//        public static string RemoveSpaces(this string s) => s.Replace(" ", "");
//    }

//    //46
//    public static class ListExtensions
//    {
//        private static readonly Random random = new Random();
//        public static void Shuffle<T>(this IList<T> list)
//        {
//            int n = list.Count;
//            while (n > 1)
//            {
//                n--;
//                int k = random.Next(n + 1);
//                T value = list[k];
//                list[k] = list[n];
//                list[n] = value;
//            }
//        }
//    }

//    //47
//    public static class StringExtensions3
//    {
//        public static string ToTitleCase(this string s) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
//    }

//    //48
//    public static class IntExtensions2
//    {
//        public static string ToRoman(this int n)
//        {
//            if (n <= 0) return "";
//            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
//            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < values.Length; i++)
//            {
//                while (n >= values[i])
//                {
//                    sb.Append(roman[i]);
//                    n -= values[i];
//                }
//            }
//            return sb.ToString();
//        }
//    }

//    //49
//    public static class CollectionExtensions
//    {
//        public static bool IsNotEmpty<T>(this IEnumerable<T> collection) => collection.Any();
//    }

//    //50
//    public static class StringExtensions4
//    {
//        public static int WordCount(this string s) => s.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
//    }

//    //51
//    public static class ArrayExtensions2
//    {
//        public static double Median(this double[] array)
//        {
//            Array.Sort(array);
//            int n = array.Length;
//            if (n % 2 == 0) return (array[n / 2 - 1] + array[n / 2]) / 2;
//            return array[n / 2];
//        }
//    }

//    //52
//    public static class DateTimeExtensions2
//    {
//        public static DateTime StartOfWeek(this DateTime dt)
//        {
//            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
//            return dt.AddDays(-1 * diff).Date;
//        }
//    }

//    //53
//    public static class StringExtensions5
//    {
//        public static string RemoveHtmlTags(this string s) => Regex.Replace(s, @"<[^>]*>", "");
//    }

//    //54
//    public static class IntExtensions3
//    {
//        public static bool IsPrime(this int n)
//        {
//            if (n <= 1) return false;
//            if (n <= 3) return true;
//            if (n % 2 == 0 || n % 3 == 0) return false;
//            for (int i = 5; i * i <= n; i += 6)
//            {
//                if (n % i == 0 || n % (i + 2) == 0) return false;
//            }
//            return true;
//        }
//    }

//    //55
//    public static class CollectionExtensions2
//    {
//        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
//        {
//            while (source.Any())
//            {
//                yield return source.Take(size);
//                source = source.Skip(size);
//            }
//        }
//    }

//    //56
//    public static class StringExtensions6
//    {
//        public static string ToBase64(this string s) => Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
//    }

//    //57
//    public static class ArrayExtensions3
//    {
//        public static T SecondMax<T>(this T[] array) where T : IComparable<T>
//        {
//            if (array.Length < 2) throw new InvalidOperationException();
//            Array.Sort(array);
//            return array[array.Length - 2];
//        }
//    }

//    //58
//    public static class DateTimeExtensions3
//    {
//        public static string ToReadable(this DateTime dt) => dt.ToString("dddd, MMMM dd, yyyy hh:mm tt");
//    }

//    //59
//    public static class StringExtensions7
//    {
//        public static bool IsStrongPassword(this string s)
//        {
//            return s.Length >= 8 &&
//                   Regex.IsMatch(s, @"[A-Z]") &&
//                   Regex.IsMatch(s, @"[a-z]") &&
//                   Regex.IsMatch(s, @"\d") &&
//                   Regex.IsMatch(s, @"[!@#$%^&*]");
//        }
//    }

//    //60
//    public static class LongExtensions
//    {
//        public static string ToReadableBytes(this long bytes)
//        {
//            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
//            int order = 0;
//            double num = bytes;
//            while (num >= 1024 && order < sizes.Length - 1)
//            {
//                order++;
//                num /= 1024;
//            }
//            return $"{num:0.##} {sizes[order]}";
//        }
//    }



//    //61
//    public class Car
//    {
//        public class Engine
//        {
//            public int Horsepower { get; set; }
//            public void Start() { }
//        }
//        public Engine CarEngine { get; set; }
//    }

//    //62
//    public class Library
//    {
//        public class Book
//        {
//            public string Title { get; set; }
//            public string Author { get; set; }
//        }
//        public List<Book> Books { get; set; } = new List<Book>();
//    }

//    //63
//    public class Computer
//    {
//        private class CPU
//        {
//            public int Cores { get; set; }
//        }
//        private class RAM
//        {
//            public int SizeGB { get; set; }
//        }
//        private CPU Processor { get; set; }
//        private RAM Memory { get; set; }
//    }

//    //64
//    public class University
//    {
//        protected class Student
//        {
//            public string Name { get; set; }
//            public int ID { get; set; }
//        }
//        protected List<Student> Students { get; set; } = new List<Student>();
//    }

//    //65
//    public class BankAccount
//    {
//        public class Transaction
//        {
//            public decimal Amount { get; set; }
//            public DateTime Date { get; set; }
//        }
//        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
//    }

//    //66
//    public class Game
//    {
//        public static class Rules
//        {
//            public static string GetRule(string ruleName) => "Rule";
//        }
//    }

//    //67
//    public class TreeNode
//    {
//        public class Traverser
//        {
//            public void InOrder(TreeNode node) { }
//            public void PreOrder(TreeNode node) { }
//            public void PostOrder(TreeNode node) { }
//        }
//        public TreeNode Left { get; set; }
//        public TreeNode Right { get; set; }
//    }

//    //68
//    public class Calculator
//    {
//        public class Addition
//        {
//            public double Add(double a, double b) => a + b;
//        }
//        public class Subtraction
//        {
//            public double Subtract(double a, double b) => a - b;
//        }
//    }

//    //69
//    public class Document
//    {
//        public class Page
//        {
//            public string Content { get; set; }
//        }
//        public List<Page> Pages { get; set; } = new List<Page>();
//    }

//    //70
//    public class Network
//    {
//        public class Node
//        {
//            public string ID { get; set; }
//        }
//        public class Connection
//        {
//            public Node From { get; set; }
//            public Node To { get; set; }
//        }
//    }

//    //71
//    public class House
//    {
//        public class Room
//        {
//            public class Furniture
//            {
//                public string Type { get; set; }
//            }
//            public List<Furniture> Furnitures { get; set; } = new List<Furniture>();
//        }
//        public List<Room> Rooms { get; set; } = new List<Room>();
//    }

//    //72
//    public class Phone
//    {
//        public class Contact
//        {
//            public string Name { get; set; }
//            public string Number { get; set; }
//        }
//        public class Message
//        {
//            public string Text { get; set; }
//        }
//    }

//    //73
//    public class Restaurant
//    {
//        public class Menu
//        {
//            public List<string> Items { get; set; } = new List<string>();
//        }
//        public class Order
//        {
//            public List<string> OrderedItems { get; set; } = new List<string>();
//        }
//    }

//    //74
//    public class School
//    {
//        public class Teacher
//        {
//            public string Name { get; set; }
//        }
//        public class Classroom
//        {
//            public int Number { get; set; }
//        }
//    }

//    //75
//    public class LinkedList<T>
//    {
//        public class Node
//        {
//            public T Value { get; set; }
//            public Node Next { get; set; }
//        }
//        public Node Head { get; set; }
//    }

//    //76
//    public class Email
//    {
//        public class Attachment
//        {
//            public string FileName { get; set; }
//        }
//        public class Header
//        {
//            public string Subject { get; set; }
//        }
//    }

//    //77
//    public class Team
//    {
//        public class Player
//        {
//            public string Name { get; set; }
//        }
//        public class Coach
//        {
//            public string Name { get; set; }
//        }
//    }

//    //78
//    public class Shape
//    {
//        public class Circle
//        {
//            public double Radius { get; set; }
//        }
//        public class Rectangle
//        {
//            public double Width { get; set; }
//            public double Height { get; set; }
//        }
//    }

//    //79
//    public class Database
//    {
//        public class Table
//        {
//            public string Name { get; set; }
//            public class Column
//            {
//                public string Name { get; set; }
//                public string Type { get; set; }
//            }
//            public List<Column> Columns { get; set; } = new List<Column>();
//        }
//    }

//    //80
//    public class Store
//    {
//        public class Product
//        {
//            public string Name { get; set; }
//        }
//        public class Category
//        {
//            public string Name { get; set; }
//            public List<Product> Products { get; set; } = new List<Product>();
//        }
//    }

//    //81
//    public sealed class DatabaseConnection
//    {
//        private static DatabaseConnection _instance;
//        private DatabaseConnection() { }
//        public static DatabaseConnection Instance
//        {
//            get
//            {
//                if (_instance == null)
//                    _instance = new DatabaseConnection();
//                return _instance;
//            }
//        }
//    }

//    //82
//    public sealed class Logger
//    {
//        private static Logger _instance;
//        private static readonly object _lock = new object();
//        private Logger() { }
//        public static Logger Instance
//        {
//            get
//            {
//                lock (_lock)
//                {
//                    if (_instance == null)
//                        _instance = new Logger();
//                    return _instance;
//                }
//            }
//        }
//        public void Log(string message) { }
//    }

//    //83
//    public sealed class ConfigurationManager
//    {
//        private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());
//        private readonly Dictionary<string, string> _settings;
//        private ConfigurationManager()
//        {
//            _settings = new Dictionary<string, string>();
//            LoadDefaultSettings();
//        }
//        public static ConfigurationManager Instance => _instance.Value;
//        private void LoadDefaultSettings()
//        {
//            _settings["AppName"] = "MyApplication";
//            _settings["Version"] = "1.0.0";
//            _settings["Environment"] = "Production";
//        }
//        public void SetSetting(string key, string value)
//        {
//            _settings[key] = value;
//        }
//        public string GetSetting(string key)
//        {
//            return _settings.ContainsKey(key) ? _settings[key] : null;
//        }
//        public void DisplayAllSettings()
//        {
//            foreach (var kvp in _settings)
//            {
//                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//            }
//        }
//    }

//    //84
//    public sealed class SingletonWithDoubleCheck
//    {
//        private static SingletonWithDoubleCheck _instance;
//        private static readonly object _lock = new object();
//        private SingletonWithDoubleCheck() { }
//        public static SingletonWithDoubleCheck Instance
//        {
//            get
//            {
//                if (_instance == null)
//                {
//                    lock (_lock)
//                    {
//                        if (_instance == null)
//                            _instance = new SingletonWithDoubleCheck();
//                    }
//                }
//                return _instance;
//            }
//        }
//    }

//    //85
//    public sealed class ConfigManager
//    {
//        private static ConfigManager _instance;
//        private static readonly object _lock = new object();
//        private ConfigManager() { }
//        public static ConfigManager Instance
//        {
//            get
//            {
//                lock (_lock)
//                {
//                    if (_instance == null)
//                        _instance = new ConfigManager();
//                    return _instance;
//                }
//            }
//        }
//    }

//    //86
//    public sealed class StaticConstructorSingleton
//    {
//        private static readonly StaticConstructorSingleton _instance;
//        static StaticConstructorSingleton()
//        {
//            _instance = new StaticConstructorSingleton();
//        }
//        private StaticConstructorSingleton() { }
//        public static StaticConstructorSingleton Instance => _instance;
//    }

//    //87
//    public enum ApplicationSettings
//    {
//        Instance;
//    public string GetSetting() => "Setting";
//}

////88
//public abstract class GenericSingleton<T> where T : GenericSingleton<T>, new()
//{
//    private static T _instance;
//    private static readonly object _lock = new object();
//    public static T Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new T();
//                return _instance;
//            }
//        }
//    }
//}

////89
//public sealed class ResettableSingleton
//{
//    private static ResettableSingleton _instance;
//    private ResettableSingleton() { }
//    public static ResettableSingleton Instance
//    {
//        get
//        {
//            if (_instance == null)
//                _instance = new ResettableSingleton();
//            return _instance;
//        }
//    }
//    public static void Reset()
//    {
//        _instance = null;
//    }
//}

////90
//public sealed class CacheManager
//{
//    private static CacheManager _instance;
//    private static readonly object _lock = new object();
//    private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();
//    private CacheManager() { }
//    public static CacheManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new CacheManager();
//                return _instance;
//            }
//        }
//    }
//    public void Add(string key, object value) => _cache[key] = value;
//    public object Get(string key) => _cache.ContainsKey(key) ? _cache[key] : null;
//}

////91
//public sealed class FileManager
//{
//    private static FileManager _instance;
//    private static readonly object _lock = new object();
//    private FileManager() { }
//    public static FileManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new FileManager();
//                return _instance;
//            }
//        }
//    }
//    public bool FileExists(string path) => File.Exists(path);
//}

////92
//public sealed class RandomGenerator
//{
//    private static RandomGenerator _instance;
//    private static readonly object _lock = new object();
//    private readonly Random _random = new Random();
//    private RandomGenerator() { }
//    public static RandomGenerator Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new RandomGenerator();
//                return _instance;
//            }
//        }
//    }
//    public int NextInt(int min, int max) => _random.Next(min, max);
//    public double NextDouble() => _random.NextDouble();
//}

////93
//public sealed class ApplicationState
//{
//    private static ApplicationState _instance;
//    private static readonly object _lock = new object();
//    private ApplicationState() { }
//    public static ApplicationState Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new ApplicationState();
//                return _instance;
//            }
//        }
//    }
//    public void SaveToFile(string state, string path) => File.WriteAllText(path, state);
//}

////94
//public sealed class SecurityManager
//{
//    private static SecurityManager _instance;
//    private static readonly object _lock = new object();
//    private SecurityManager() { }
//    public static SecurityManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new SecurityManager();
//                return _instance;
//            }
//        }
//    }
//    public bool Authenticate(string user, string pass) => true;
//}

////95
//public sealed class PerformanceCounter
//{
//    private static PerformanceCounter _instance;
//    private static readonly object _lock = new object();
//    private PerformanceCounter() { }
//    public static PerformanceCounter Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new PerformanceCounter();
//                return _instance;
//            }
//        }
//    }
//    public void Increment() { }
//}

////96
//public sealed class EmailService
//{
//    private static EmailService _instance;
//    private static readonly object _lock = new object();
//    private readonly Queue<string> _queue = new Queue<string>();
//    private EmailService() { }
//    public static EmailService Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new EmailService();
//                return _instance;
//            }
//        }
//    }
//    public void Enqueue(string message) => _queue.Enqueue(message);
//}

////97
//public sealed class PrintManager
//{
//    private static PrintManager _instance;
//    private static readonly object _lock = new object();
//    private readonly Queue<string> _printQueue = new Queue<string>();
//    private PrintManager() { }
//    public static PrintManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new PrintManager();
//                return _instance;
//            }
//        }
//    }
//    public void AddToQueue(string document) => _printQueue.Enqueue(document);
//}

////98
//public sealed class SessionManager
//{
//    private static SessionManager _instance;
//    private static readonly object _lock = new object();
//    private SessionManager() { }
//    public static SessionManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new SessionManager();
//                return _instance;
//            }
//        }
//    }
//    public void StartSession() { }
//}

////99
//public sealed class NotificationService
//{
//    private static NotificationService _instance;
//    private static readonly object _lock = new object();
//    private NotificationService() { }
//    public static NotificationService Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new NotificationService();
//                return _instance;
//            }
//        }
//    }
//    public void SendNotification(string message) { }
//}

////100
//public sealed class ResourcePoolManager
//{
//    private static ResourcePoolManager _instance;
//    private static readonly object _lock = new object();
//    private ResourcePoolManager() { }
//    public static ResourcePoolManager Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                    _instance = new ResourcePoolManager();
//                return _instance;
//            }
//        }
//    }
//    public object AcquireResource() => new object();
//}
//}