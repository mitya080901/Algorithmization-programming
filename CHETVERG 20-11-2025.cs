//1
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GenericClassConstraint
{
    public class ReferenceContainer<T> where T : class
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            items.Add(item);
        }

        public bool Remove(T item) => items.Remove(item);

        public T Find(Predicate<T> match) => items.Find(match);

        public IEnumerable<T> GetAll() => items.AsReadOnly();

        public void Clear() => items.Clear();

        public int Count => items.Count;

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value ?? throw new ArgumentNullException();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name}, {Age} лет";
    }

    class Program
    {
        static void Main()
        {
            var container = new ReferenceContainer<Person>();
            container.Add(new Person { Name = "Иван", Age = 25 });
            container.Add(new Person { Name = "Мария", Age = 30 });

            Console.WriteLine("Все элементы:");
            foreach (var p in container.GetAll())
                Console.WriteLine(p);

            var found = container.Find(x => x.Age > 28);
            Console.WriteLine($"Найден: {found}");
        }
    }
}
//2
using System;
using System.Collections.Generic;

namespace GenericStructConstraint
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"({X},{Y})";
    }

    public class ValueTypeProcessor<T> where T : struct
    {
        private List<T> values = new List<T>();

        public void Add(T value) => values.Add(value);

        public T Sum<TSum>(Func<T, T, TSum> adder, T zero) where TSum : struct
        {
            dynamic result = zero;
            foreach (var v in values)
                result += (dynamic)v;
            return (TSum)result;
        }

        public bool Contains(T value) => values.Contains(value);

        public int Count => values.Count;

        public T[] ToArray() => values.ToArray();
    }

    class Program
    {
        static void Main()
        {
            var processor = new ValueTypeProcessor<Point>();
            processor.Add(new Point { X = 1, Y = 2 });
            processor.Add(new Point { X = 3, Y = 4 });
            processor.Add(new Point { X = 5, Y = 6 });

            Console.WriteLine("Все точки:");
            foreach (var p in processor.ToArray())
                Console.WriteLine(p);
        }
    }
}
//3
using System;
using System.Collections.Generic;

namespace GenericNewConstraint
{
    public class Factory
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        public static List<T> CreateList<T>(int count) where T : new()
        {
            var list = new List<T>(count);
            for (int i = 0; i < count; i++)
                list.Add(new T());
            return list;
        }

        public static T[] CreateArray<T>(int size) where T : new()
        {
            var array = new T[size];
            for (int i = 0; i < size; i++)
                array[i] = new T();
            return array;
        }
    }

    public class Car
    {
        public string Model { get; set; } = "Неизвестно";
        public int Year { get; set; } = 2023;
        public override string ToString() => $"{Model} ({Year})";
    }

    class Program
    {
        static void Main()
        {
            var car1 = Factory.CreateInstance<Car>();
            var cars = Factory.CreateList<Car>(5);
            var carArray = Factory.CreateArray<Car>(3);

            Console.WriteLine(car1);
            Console.WriteLine($"Создано машин в списке: {cars.Count}");
            Console.WriteLine($"Длина массива: {carArray.Length}");
        }
    }
}
//4
using System;
using System.Collections.Generic;

namespace GenericComparableConstraint
{
    public class Sorter<T> where T : IComparable<T>
    {
        public void BubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 1 - i; j++)
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }

        public T Max(T a, T b) => a.CompareTo(b) > 0 ? a : b;
        public T Min(T a, T b) => a.CompareTo(b) < 0 ? a : b;

        public bool IsSorted(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i].CompareTo(array[i + 1]) > 0)
                    return false;
            return true;
        }

        public int BinarySearch(T[] array, T value)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = array[mid].CompareTo(value);
                if (cmp == 0) return mid;
                if (cmp < 0) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            var sorter = new Sorter<int>();
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            sorter.BubbleSort(arr);
            Console.WriteLine("Отсортировано: " + string.Join(" ", arr));
            Console.WriteLine("Максимум: " + sorter.Max(10, 20));
        }
    }
}
//4
using System;
using System.Collections.Generic;

namespace GenericComparableConstraint
{
    public class Sorter<T> where T : IComparable<T>
    {
        public void BubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 1 - i; j++)
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }

        public T Max(T a, T b) => a.CompareTo(b) > 0 ? a : b;
        public T Min(T a, T b) => a.CompareTo(b) < 0 ? a : b;

        public bool IsSorted(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i].CompareTo(array[i + 1]) > 0)
                    return false;
            return true;
        }

        public int BinarySearch(T[] array, T value)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = array[mid].CompareTo(value);
                if (cmp == 0) return mid;
                if (cmp < 0) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            var sorter = new Sorter<int>();
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            sorter.BubbleSort(arr);
            Console.WriteLine("Отсортировано: " + string.Join(" ", arr));
            Console.WriteLine("Максимум: " + sorter.Max(10, 20));
        }
    }
}
//6
using System;

namespace GenericBaseConstraint
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void Speak() => Console.WriteLine("Звук животного");
    }

    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Гав-гав!");
    }

    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Мяу!");
    }

    public class AnimalTrainer<T> where T : Animal
    {
        public void Train(T animal)
        {
            Console.WriteLine($"Тренирую {animal.Name}");
            animal.Speak();
        }

        public void Rename(T animal, string newName)
        {
            animal.Name = newName;
        }
    }

    class Program
    {
        static void Main()
        {
            var dogTrainer = new AnimalTrainer<Dog>();
            var catTrainer = new AnimalTrainer<Cat>();
            var generalTrainer = new AnimalTrainer<Animal>();

            var dog = new Dog { Name = "Рекс" };
            var cat = new Cat { Name = "Мурка" };

            dogTrainer.Train(dog);
            catTrainer.Train(cat);
            generalTrainer.Train(dog);
        }
    }
}
//7
using System;
using System.Collections.Generic;

namespace MultipleConstraintsDemo
{
    public class ResourceManager<T> where T : class, IDisposable
    {
        private List<T> resources = new List<T>();

        public T AddResource(T resource)
        {
            resources.Add(resource);
            return resource;
        }

        public void UseResource(Action<T> action, T resource)
        {
            if (resource == null) throw new ArgumentNullException();
            try
            {
                action(resource);
            }
            finally
            {
                resource.Dispose();
            }
        }

        public void DisposeAll()
        {
            foreach (var res in resources)
                res?.Dispose();
            resources.Clear();
        }
    }

    class Program
    {
        static void Main()
        {
            var manager = new ResourceManager<System.IO.StreamWriter>();

            manager.UseResource(writer =>
            {
                writer.WriteLine("Тестовая запись");
            }, new System.IO.StreamWriter("test.txt", false));
        }
    }
}
//10
using System;
using System.Collections.Generic;

namespace ComparableMethodDemo
{
    public static class CompareUtility
    {
        public static bool AreEqual<T>(T a, T b) where T : IComparable<T>
            => a.CompareTo(b) == 0;

        public static T Max<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0) throw new ArgumentException();
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(max) > 0)
                    max = values[i];
            return max;
        }

        public static void Sort<T>(List<T> list) where T : IComparable<T>
        {
            list.Sort();
        }

        public static int FindIndex<T>(T[] array, T value) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].CompareTo(value) == 0)
                    return i;
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(CompareUtility.AreEqual(10, 10));
            Console.WriteLine(CompareUtility.Max(5, 12, 3, 42, 7));
        }
    }
}
//11
using System;
using System.Collections.Generic;

namespace SpecificTypeConstraint
{
    public class StringProcessor<T> where T : string
    {
        private List<T> strings = new List<T>();

        public void Add(T value)
        {
            strings.Add(value ?? "");
        }

        public int TotalLength()
        {
            int length = 0;
            foreach (var s in strings)
                length += s.Length;
            return length;
        }

        public string ConcatAll(string separator = "")
        {
            return string.Join(separator, strings);
        }

        public IEnumerable<T> FindContaining(string substring)
        {
            foreach (var s in strings)
                if (s.Contains(substring))
                    yield return s;
        }
    }

    class Program
    {
        static void Main()
        {
            var processor = new StringProcessor<string>();
            processor.Add("Привет");
            processor.Add("мир");
            processor.Add("C#");

            Console.WriteLine(processor.ConcatAll(" "));
        }
    }
}
//11
using System;
using System.Collections.Generic;

namespace SpecificTypeConstraint
{
    public class StringProcessor<T> where T : string
    {
        private List<T> strings = new List<T>();

        public void Add(T value)
        {
            strings.Add(value ?? "");
        }

        public int TotalLength()
        {
            int length = 0;
            foreach (var s in strings)
                length += s.Length;
            return length;
        }

        public string ConcatAll(string separator = "")
        {
            return string.Join(separator, strings);
        }

        public IEnumerable<T> FindContaining(string substring)
        {
            foreach (var s in strings)
                if (s.Contains(substring))
                    yield return s;
        }
    }

    class Program
    {
        static void Main()
        {
            var processor = new StringProcessor<string>();
            processor.Add("Привет");
            processor.Add("мир");
            processor.Add("C#");

            Console.WriteLine(processor.ConcatAll(" "));
        }
    }
}
//12
using System;

namespace CloneConstraintDemo
{
    public static class Cloner
    {
        public static T DeepClone<T>(T original) where T : class, ICloneable
        {
            if (original == null) return null;
            return (T)original.Clone();
        }

        public static T[] CloneArray<T>(T[] array) where T : class, ICloneable
        {
            if (array == null) return null;
            var result = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                result[i] = (T)array[i].Clone();
            return result;
        }
    }

    [Serializable]
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main()
        {
            var p1 = new Person { Name = "Анна", Age = 28 };
            var p2 = Cloner.DeepClone(p1);
            Console.WriteLine(p2.Name);
        }
    }
}
//13
using System.Collections.Generic;
using System.Collections;

namespace CollectionConstraintDemo
{
    public class CollectionAnalyzer<T> where T : ICollection
    {
        public int GetCount(T collection) => collection.Count;

        public void AddRange(T collection, IEnumerable items)
        {
            foreach (var item in items)
                collection.Add(item);
        }

        public void ClearAll(T collection)
        {
            collection.Clear();
        }

        public bool IsReadOnly(T collection) => collection.IsReadOnly;

        public object[] ToArray(T collection)
        {
            var array = new object[collection.Count];
            collection.CopyTo(array, 0);
            return array;
        }
    }

    class Program
    {
        static void Main()
        {
            var list = new List<int> { 1, 2, 3 };
            var analyzer = new CollectionAnalyzer<List<int>>();
            Console.WriteLine("Кол-во: " + analyzer.GetCount(list));
        }
    }
}
//14
using System;
using System.Collections.Generic;

namespace EquatableSearchDemo
{
    public static class SearchUtility
    {
        public static int IndexOf<T>(IReadOnlyList<T> list, T item) where T : IEquatable<T>
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].Equals(item))
                    return i;
            return -1;
        }

        public static bool Contains<T>(IEnumerable<T> source, T item) where T : IEquatable<T>
        {
            foreach (var x in source)
                if (x.Equals(item))
                    return true;
            return false;
        }

        public static IEnumerable<T> Distinct<T>(IEnumerable<T> source) where T : IEquatable<T>
        {
            var set = new HashSet<T>();
            foreach (var item in source)
                if (set.Add(item))
                    yield return item;
        }
    }

    class Program
    {
        static void Main()
        {
            var list = new List<string> { "a", "b", "c" };
            Console.WriteLine(SearchUtility.Contains(list, "b"));
        }
    }
}
//15
using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializerDemo
{
    public class Serializer<T> where T : class, new()
    {
        public void SerializeToXml(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public T DeserializeFromXml(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(filePath))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public string ToXmlString(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public T CreateDefault() => new T();
    }

    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var serializer = new Serializer<Book>();
            var book = new Book { Title = "Война и мир", Author = "Толстой", Year = 1869 };
            serializer.SerializeToXml(book, "book.xml");
        }
    }
}
//16
using System;
using System.Collections.Generic;

namespace ValidationDemo
{
    public interface IValidatable
    {
        bool IsValid();
        IEnumerable<string> GetErrors();
    }

    public static class Validator
    {
        public static bool Validate<T>(T obj) where T : IValidatable
        {
            return obj.IsValid();
        }

        public static IEnumerable<string> GetValidationErrors<T>(T obj) where T : IValidatable
        {
            return obj.GetErrors();
        }

        public static void ValidateAndThrow<T>(T obj) where T : IValidatable
        {
            if (!obj.IsValid())
            {
                var errors = string.Join("; ", obj.GetErrors());
                throw new ValidationException($"Валидация не пройдена: {errors}");
            }
        }

        public static bool TryValidate<T>(T obj, out IEnumerable<string> errors) where T : IValidatable
        {
            if (obj.IsValid())
            {
                errors = Array.Empty<string>();
                return true;
            }
            errors = obj.GetErrors();
            return false;
        }
    }

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public class Order : IValidatable
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string CustomerEmail { get; set; }

        public bool IsValid()
        {
            return GetErrors().Any() == false;
        }

        public IEnumerable<string> GetErrors()
        {
            if (Amount <= 0) yield return "Сумма должна быть положительной";
            if (string.IsNullOrWhiteSpace(CustomerEmail) || !CustomerEmail.Contains("@"))
                yield return "Неверный email";
        }
    }

    class Program
    {
        static void Main()
        {
            var order = new Order { Amount = 100, CustomerEmail = "test@example.com" };
            Console.WriteLine($"Валидно: {Validator.Validate(order)}");

            var badOrder = new Order { Amount = -50, CustomerEmail = "invalid" };
            Validator.ValidateAndThrow(badOrder);
        }
    }
}
//17
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ParserDemo
{
    public class Parser<T> where T : IConvertible
    {
        public T Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Строка не может быть пустой");

            try
            {
                return (T)Convert.ChangeType(input, typeof(T), CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new FormatException($"Не удалось преобразовать '{input}' в {typeof(T)}", ex);
            }
        }

        public bool TryParse(string input, out T result)
        {
            result = default;
            if (string.IsNullOrWhiteSpace(input)) return false;

            try
            {
                result = (T)Convert.ChangeType(input, typeof(T), CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> ParseMany(IEnumerable<string> inputs)
        {
            foreach (var s in inputs)
            {
                yield return Parse(s);
            }
        }

        public T ParseOrDefault(string input, T defaultValue = default)
        {
            return TryParse(input, out var result) ? result : defaultValue;
        }
    }

    class Program
    {
        static void Main()
        {
            var intParser = new Parser<int>();
            var doubleParser = new Parser<double>();
            var boolParser = new Parser<bool>();
            var dateParser = new Parser<DateTime>();

            Console.WriteLine(intParser.Parse("12345"));
            Console.WriteLine(doubleParser.Parse("3.14159"));
            Console.WriteLine(boolParser.Parse("true"));
            Console.WriteLine(dateParser.Parse("2025-11-20"));
        }
    }
}
//18
using System;

namespace FactoryInterfaceDemo
{
    public interface IFactory<T> where T : class, new()
    {
        T Create();
        T Create(Action<T> initializer);
        T[] CreateMany(int count);
        T CreateWithParams(params object[] args);
    }

    public class Factory<T> : IFactory<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }

        public T Create(Action<T> initializer)
        {
            var obj = new T();
            initializer?.Invoke(obj);
            return obj;
        }

        public T[] CreateMany(int count)
        {
            var array = new T[count];
            for (int i = 0; i < count; i++)
                array[i] = new T();
            return array;
        }

        public T CreateWithParams(params object[] args)
        {
            return Activator.CreateInstance(typeof(T), args) as T ?? new T();
        }
    }

    public class Config
    {
        public string ConnectionString { get; set; }
        public int Timeout { get; set; }
        public bool EnableLogging { get; set; }
    }

    class Program
    {
        static void Main()
        {
            IFactory<Config> factory = new Factory<Config>();

            var config1 = factory.Create();
            var config2 = factory.Create(c =>
            {
                c.ConnectionString = "Server=...";
                c.Timeout = 30;
                c.EnableLogging = true;
            });

            Console.WriteLine(config2.ConnectionString);
        }
    }
}
//19
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CacheDemo
{
    public class Cache<T> where T : class
    {
        private readonly ConcurrentDictionary<string, CacheItem> _cache = new();

        private class CacheItem
        {
            public T Value { get; set; }
            public DateTime ExpiresAt { get; set; }
            public bool IsExpired => DateTime.UtcNow > ExpiresAt;
        }

        public void Set(string key, T value, TimeSpan? expiry = null)
        {
            var item = new CacheItem
            {
                Value = value,
                ExpiresAt = expiry.HasValue ? DateTime.UtcNow.Add(expiry.Value) : DateTime.MaxValue
            };
            _cache[key] = item;
        }

        public bool TryGet(string key, out T value)
        {
            value = null;
            if (_cache.TryGetValue(key, out var item))
            {
                if (!item.IsExpired)
                {
                    value = item.Value;
                    return true;
                }
                _cache.TryRemove(key, out _);
            }
            return false;
        }

        public T GetOrAdd(string key, Func<T> factory, TimeSpan? expiry = null)
        {
            if (TryGet(key, out var value))
                return value;

            value = factory();
            Set(key, value, expiry);
            return value;
        }

        public void Remove(string key) => _cache.TryRemove(key, out _);

        public void Clear() => _cache.Clear();

        public int Count => _cache.Count;
    }

    class Program
    {
        static void Main()
        {
            var cache = new Cache<string>();
            cache.Set("name", "Василий", TimeSpan.FromSeconds(10));
            Console.WriteLine(cache.GetOrAdd("name", () => "Default"));
        }
    }
}
//20
using System;
using System.Collections.Generic;

namespace SortDemo
{
    public static class SortExtensions
    {
        public static void BubbleSort<T>(this IList<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count - 1; i++)
                for (int j = 0; j < list.Count - 1 - i; j++)
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
        }

        public static IList<T> MergeSort<T>(this IList<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1) return list;

            int mid = list.Count / 2;
            var left = MergeSort(list.Take(mid).ToList());
            var right = MergeSort(list.Skip(mid).ToList());

            return Merge(left, right);
        }

        private static List<T> Merge<T>(IList<T> left, IList<T> right) where T : IComparable<T>
        {
            var result = new List<T>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);

            return result;
        }

        public static T[] QuickSort<T>(T[] array) where T : IComparable<T>
        {
            var list = new List<T>(array);
            QuickSortHelper(list, 0, list.Count - 1);
            return list.ToArray();
        }

        private static void QuickSortHelper<T>(IList<T> list, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int pi = Partition(list, low, high);
                QuickSortHelper(list, low, pi - 1);
                QuickSortHelper(list, pi + 1, high);
            }
        }

        private static int Partition<T>(IList<T> list, int low, int high) where T : IComparable<T>
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            var temp1 = list[i + 1];
            list[i + 1] = list[high];
            list[high] = temp1;

            return i + 1;
        }
    }

    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 64, 34, 25, 12, 22, 11, 90 };
            numbers.BubbleSort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//21
using System;
using System.Collections.Generic;

namespace ObserverDemo
{
    public class Observer<T> where T : class
    {
        private readonly List<Action<T>> _subscribers = new();

        public void Subscribe(Action<T> callback)
        {
            if (!_subscribers.Contains(callback))
                _subscribers.Add(callback);
        }

        public void Unsubscribe(Action<T> callback)
        {
            _subscribers.Remove(callback);
        }

        public void Notify(T data)
        {
            foreach (var subscriber in _subscribers)
            {
                try
                {
                    subscriber.Invoke(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка в обработчике: {ex.Message}");
                }
            }
        }

        public void Clear() => _subscribers.Clear();
    }

    public class PriceChangedEvent
    {
        public string Product { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var priceObserver = new Observer<PriceChangedEvent>();

            priceObserver.Subscribe(e => Console.WriteLine($"Уведомление: {e.Product} теперь {e.NewPrice}"));
            priceObserver.Subscribe(e => Console.WriteLine($"Лог: Изменение цены {e.Product}"));

            priceObserver.Notify(new PriceChangedEvent
            {
                Product = "Ноутбук",
                OldPrice = 50000,
                NewPrice = 45000
            });
        }
    }
}
//22
using System;
using System.Collections.Generic;

namespace TreeTraversalDemo
{
    public interface ITreeNode<T>
    {
        T Value { get; }
        IEnumerable<ITreeNode<T>> Children { get; }
    }

    public class TreeNode<T> : ITreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; } = new();
        IEnumerable<ITreeNode<T>> ITreeNode<T>.Children => Children;
    }

    public static class TreeTraverser
    {
        public static IEnumerable<T> PreOrder<T>(ITreeNode<T> root) where T : ITreeNode<T>
        {
            var stack = new Stack<ITreeNode<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                yield return node.Value;

                foreach (var child in node.Children.Reverse())
                    stack.Push(child);
            }
        }

        public static IEnumerable<T> PostOrder<T>(ITreeNode<T> root) where T : ITreeNode<T>
        {
            var stack = new Stack<ITreeNode<T>>();
            var visited = new HashSet<ITreeNode<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Peek();
                if (node.Children.Count == 0 || visited.Contains(node))
                {
                    yield return node.Value;
                    stack.Pop();
                    visited.Add(node);
                }
                else
                {
                    foreach (var child in node.Children.Reverse())
                        stack.Push(child);
                }
            }
        }

        public static IEnumerable<T> LevelOrder<T>(ITreeNode<T> root) where T : ITreeNode<T>
        {
            var queue = new Queue<ITreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                yield return node.Value;

                foreach (var child in node.Children)
                    queue.Enqueue(child);
            }
        }
    }
}
//23
using System;
using System.Collections.Generic;

namespace GraphDemo
{
    public class Graph<T> where T : class, IEquatable<T>
    {
        public List<T> Vertices { get; } = new();
        private readonly Dictionary<T, List<T>> _adj = new();

        public void AddVertex(T vertex)
        {
            if (!Vertices.Contains(vertex))
            {
                Vertices.Add(vertex);
                _adj[vertex] = new List<T>();
            }
        }

        public void AddEdge(T from, T to)
        {
            AddVertex(from);
            AddVertex(to);
            _adj[from].Add(to);
            _adj[to].Add(from);
        }

        public IEnumerable<T> GetNeighbors(T vertex)
        {
            return _adj.TryGetValue(vertex, out var list) ? list : Array.Empty<T>();
        }

        public bool HasPath(T start, T end)
        {
            var visited = new HashSet<T>();
            var queue = new Queue<T>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Equals(end)) return true;

                foreach (var neighbor in GetNeighbors(current))
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            var graph = new Graph<string>();
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            Console.WriteLine(graph.HasPath("A", "C"));
        }
    }
}
//24
using System;
using System.Collections.Generic;

namespace TypeMappingDemo
{
    public static class Mapper
    {
        private static readonly Dictionary<Type, Dictionary<Type, Func<object, object>>> _mappers = new();

        public static void Register<TSource, TDest>(Func<TSource, TDest> mapper)
        {
            if (!_mappers.ContainsKey(typeof(TSource)))
                _mappers[typeof(TSource)] = new Dictionary<Type, Func<object, object>>();

            _mappers[typeof(TSource)][typeof(TDest)] = obj => mapper((TSource)obj);
        }

        public static TDest Map<TSource, TDest>(TSource source)
        {
            if (_mappers.TryGetValue(typeof(TSource), out var destMap) &&
                destMap.TryGetValue(typeof(TDest), out var mapper))
            {
                return (TDest)mapper(source);
            }

            throw new InvalidOperationException($"Нет маппинга от {typeof(TSource)} к {typeof(TDest)}");
        }
    }

    public class UserDto { public string FullName { get; set; } }
    public class User { public string FirstName { get; set; } public string LastName { get; set; } }

    class Program
    {
        static void Main()
        {
            Mapper.Register<User, UserDto>(u => new UserDto { FullName = u.FirstName + " " + u.LastName });
            var user = new User { FirstName = "Иван", LastName = "Иванов" };
            var dto = Mapper.Map<User, UserDto>(user);
            Console.WriteLine(dto.FullName);
        }
    }
}
//25
using System;
using System.Collections.Generic;

namespace EventArgsDemo
{
    public class EventManager<T> where T : EventArgs
    {
        public event EventHandler<T> EventOccurred;

        protected virtual void OnEvent(T args)
        {
            EventOccurred?.Invoke(this, args);
        }

        public void RaiseEvent(T args)
        {
            OnEvent(args);
        }

        public void Subscribe(EventHandler<T> handler)
        {
            EventOccurred += handler;
        }

        public void Unsubscribe(EventHandler<T> handler)
        {
            EventOccurred -= handler;
        }
    }

    public class ValueChangedEventArgs : EventArgs
    {
        public int OldValue { get; set; }
        public int NewValue { get; set; }
    }

    public class Counter : EventManager<ValueChangedEventArgs>
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    var old = _value;
                    _value = value;
                    RaiseEvent(new ValueChangedEventArgs { OldValue = old, NewValue = value });
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var counter = new Counter();
            counter.Subscribe((s, e) => Console.WriteLine($"Значение изменилось: {e.OldValue} → {e.NewValue}"));
            counter.Value = 10;
            counter.Value = 20;
        }
    }
}
//26
using System;
using System.Collections.Generic;

namespace StructSumDemo
{
    public static class MathOperations
    {
        public static T Sum<T>(IEnumerable<T> values) where T : struct, IComparable<T>
        {
            dynamic result = default(T);
            foreach (var value in values)
                result += (dynamic)value;
            return result;
        }

        public static T Max<T>(params T[] values) where T : struct, IComparable<T>
        {
            if (values.Length == 0) throw new ArgumentException();
            T max = values[0];
            foreach (var v in values)
                if (v.CompareTo(max) > 0) max = v;
            return max;
        }

        public static (T Sum, T Min, T Max) Aggregate<T>(IEnumerable<T> values) where T : struct, IComparable<T>
        {
            dynamic sum = default(T);
            T min = default, max = default;
            bool first = true;

            foreach (var v in values)
            {
                dynamic dv = v;
                sum += dv;
                if (first || v.CompareTo(min) < 0) min = v;
                if (first || v.CompareTo(max) > 0) max = v;
                first = false;
            }

            return (sum, min, max);
        }
    }

    class Program
    {
        static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(MathOperations.Sum(numbers));
            Console.WriteLine(MathOperations.Max(10, 50, 30));
        }
    }
}
//27
using System;
using System.Collections.Generic;

namespace ComparerDemo
{
    public class SmartComparer<T> : IComparer<T> where T : IComparable<T>
    {
        private readonly Func<T, T, int> _customCompare;

        public SmartComparer(Func<T, T, int> customCompare = null)
        {
            _customCompare = customCompare;
        }

        public int Compare(T x, T y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return _customCompare?.Invoke(x, y) ?? x.CompareTo(y);
        }

        public static SmartComparer<T> Default { get; } = new SmartComparer<T>();
        public static SmartComparer<T> Reverse { get; } = new SmartComparer<T>((a, b) => b.CompareTo(a));
    }

    class Program
    {
        static void Main()
        {
            var list = new List<string> { "яблоко", "банан", "вишня" };
            list.Sort(SmartComparer<string>.Default);
            Console.WriteLine(string.Join(", ", list));

            list.Sort(SmartComparer<string>.Reverse);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
//28
using System;

namespace MultipleConstraintsInterface
{
    public interface IRepository<T>
        where T : class, IEquatable<T>, new()
    {
        void Add(T entity);
        bool Remove(T entity);
        T FindById(int id);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }

    public class InMemoryRepository<T> : IRepository<T>
        where T : class, IEquatable<T>, new()
    {
        private readonly List<T> _items = new();
        private int _nextId = 1;

        public void Add(T entity)
        {
            var prop = entity.GetType().GetProperty("Id");
            if (prop != null && prop.CanWrite)
                prop.SetValue(entity, _nextId++);
            _items.Add(entity);
        }

        public bool Remove(T entity) => _items.Remove(entity);

        public T FindById(int id)
        {
            return _items.Find(e =>
            {
                var prop = e.GetType().GetProperty("Id");
                return prop != null && (int)prop.GetValue(e) == id;
            });
        }

        public IEnumerable<T> GetAll() => _items;

        public void SaveChanges() { }
    }
}
//29
using System;

namespace TypeConversionDemo
{
    public static class Converter
    {
        public static TDest Convert<TSource, TDest>(TSource source)
            where TSource : IConvertible
            where TDest : IConvertible
        {
            try
            {
                return (TDest)System.Convert.ChangeType(source, typeof(TDest));
            }
            catch
            {
                return default;
            }
        }

        public static bool TryConvert<TSource, TDest>(TSource source, out TDest result)
            where TSource : IConvertible
            where TDest : IConvertible
        {
            result = default;
            try
            {
                result = (TDest)System.Convert.ChangeType(source, typeof(TDest));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static T To<T>(string input) where T : IConvertible
        {
            return (T)System.Convert.ChangeType(input, typeof(T));
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Converter.Convert<string, int>("123"));
            Console.WriteLine(Converter.To<DateTime>("2025-11-20"));
        }
    }
}
//30
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseDemo
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }

    public class DbContext<T> where T : EntityBase, new()
    {
        private readonly List<T> _entities = new();
        private int _nextId = 1;

        public void Add(T entity)
        {
            entity.Id = _nextId++;
            entity.CreatedAt = DateTime.UtcNow;
            _entities.Add(entity);
            Console.WriteLine($"Добавлено: {entity}");
        }

        public void Update(T entity)
        {
            var existing = _entities.FirstOrDefault(e => e.Id == entity.Id);
            if (existing != null)
            {
                var index = _entities.IndexOf(existing);
                entity.UpdatedAt = DateTime.UtcNow;
                _entities[index] = entity;
                Console.WriteLine($"Обновлено: {entity}");
            }
        }

        public bool Delete(int id)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            if (entity != null)
            {
                _entities.Remove(entity);
                Console.WriteLine($"Удалено ID: {id}");
                return true;
            }
            return false;
        }

        public T GetById(int id) => _entities.FirstOrDefault(e => e.Id == id);

        public IQueryable<T> Query() => _entities.AsQueryable();

        public void SaveChanges() => Console.WriteLine("Изменения сохранены в БД");
    }

    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString() => $"Customer #{Id}: {Name}";
    }

    class Program
    {
        static void Main()
        {
            var db = new DbContext<Customer>();
            db.Add(new Customer { Name = "Пётр", Email = "petr@example.com" });
            db.SaveChanges();
        }
    }
}

//32
using System;
using System.Collections.Generic;

namespace ObjectCreatorDemo
{
    public static class ObjectFactory
    {
        public static T Create<T>() where T : class, new()
        {
            return new T();
        }

        public static T CreateWithInit<T>(Action<T> initializer) where T : class, new()
        {
            var obj = new T();
            initializer?.Invoke(obj);
            return obj;
        }

        public static IEnumerable<T> CreateMany<T>(int count, Action<T, int> initializer = null) where T : class, new()
        {
            for (int i = 0; i < count; i++)
            {
                var obj = new T();
                initializer?.Invoke(obj, i);
                yield return obj;
            }
        }

        public static T CreateDefault<T>(T defaultValue = null) where T : class, new()
        {
            return defaultValue ?? new T();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"{Name} - {Price} руб.";
    }

    class Program
    {
        static void Main()
        {
            var product = ObjectFactory.CreateWithInit<Product>(p =>
            {
                p.Name = "Телефон";
                p.Price = 50000;
            });
            Console.WriteLine(product);
        }
    }
}

//34
using System;
using System.Runtime.Serialization;
using System.IO;

namespace SerializableDemo
{
    public static class Serializer
    {
        public static void Serialize<T>(T obj, string filePath) where T : class, ISerializable
        {
            var formatter = new DataContractSerializer(typeof(T));
            using var stream = new FileStream(filePath, FileMode.Create);
            formatter.WriteObject(stream, obj);
        }

        public static T Deserialize<T>(string filePath) where T : class, ISerializable
        {
            var formatter = new DataContractSerializer(typeof(T));
            using var stream = new FileStream(filePath, FileMode.Open);
            return (T)formatter.ReadObject(stream);
        }

        public static byte[] ToBytes<T>(T obj) where T : class, ISerializable
        {
            var formatter = new DataContractSerializer(typeof(T));
            using var ms = new MemoryStream();
            formatter.WriteObject(ms, obj);
            return ms.ToArray();
        }
    }

    [DataContract]
    public class Settings : ISerializable
    {
        [DataMember] public string Theme { get; set; }
        [DataMember] public bool AutoSave { get; set; }

        public Settings() { }

        protected Settings(SerializationInfo info, StreamingContext context)
        {
            Theme = info.GetString("Theme");
            AutoSave = info.GetBoolean("AutoSave");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Theme", Theme);
            info.AddValue("AutoSave", AutoSave);
        }
    }
}
//35
using System;
using System.Collections.Generic;

namespace PipelineDemo
{
    public class Pipeline<T> where T : class
    {
        private readonly List<Func<T, T>> _steps = new();

        public Pipeline<T> AddStep(Func<T, T> step)
        {
            _steps.Add(step);
            return this;
        }

        public Pipeline<T> AddStep(Action<T> action)
        {
            _steps.Add(input => { action(input); return input; });
            return this;
        }

        public T Execute(T input)
        {
            var result = input;
            foreach (var step in _steps)
            {
                result = step(result);
            }
            return result;
        }

        public Func<T, T> Build()
        {
            return input =>
            {
                var result = input;
                foreach (var step in _steps)
                    result = step(result);
                return result;
            };
        }
    }

    public class Order
    {
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal Total => Amount - Discount;
        public bool IsValid { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var pipeline = new Pipeline<Order>()
                .AddStep(o => { o.IsValid = o.Amount > 0; return o; })
                .AddStep(o => { if (o.Amount > 1000) o.Discount = o.Amount * 0.1m; return o; });

            var order = new Order { Amount = 1500 };
            var processed = pipeline.Execute(order);
            Console.WriteLine($"Итого: {processed.Total}");
        }
    }
}
//36
using System;
using System.Collections.Generic;

namespace FilterableDemo
{
    public interface IFilterable
    {
        bool Matches(object criteria);
    }

    public static class FilterExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, object criteria) where T : IFilterable
        {
            foreach (var item in source)
                if (item.Matches(criteria))
                    yield return item;
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> source, object criteria) where T : IFilterable
        {
            foreach (var item in source)
                if (item.Matches(criteria))
                    return item;
            return default;
        }

        public static int Count<T>(this IEnumerable<T> source, object criteria) where T : IFilterable
        {
            int count = 0;
            foreach (var item in source)
                if (item.Matches(criteria))
                    count++;
            return count;
        }
    }

    public class Person : IFilterable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public bool Matches(object criteria)
        {
            if (criteria is Person p)
            {
                if (!string.IsNullOrEmpty(p.Name) && Name != p.Name) return false;
                if (p.Age > 0 && Age != p.Age) return false;
                if (!string.IsNullOrEmpty(p.City) && City != p.City) return false;
            }
            return true;
        }
    }
}
//37
using System;
using System.Collections.Generic;

namespace TypeConverterDemo
{
    public class TypeConverter<T>
    {
        private readonly Dictionary<Type, Func<object, T>> _converters = new();

        public void Register<TSource>(Func<TSource, T> converter)
        {
            _converters[typeof(TSource)] = obj => converter((TSource)obj);
        }

        public T ConvertFrom(object source)
        {
            if (source == null) return default;
            var sourceType = source.GetType();

            if (_converters.TryGetValue(sourceType, out var converter))
                return converter(source);

            if (source is IConvertible)
                return (T)System.Convert.ChangeType(source, typeof(T));

            throw new InvalidOperationException($"Нет конвертера из {sourceType} в {typeof(T)}");
        }

        public bool TryConvert(object source, out T result)
        {
            try
            {
                result = ConvertFrom(source);
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var converter = new TypeConverter<string>();
            converter.Register<int>(i => i.ToString("N0"));
            Console.WriteLine(converter.ConvertFrom(1234567));
        }
    }
}
//38
using System;

namespace MapperInterfaceDemo
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
        void Map(TSource source, TDestination destination);
    }

    public class AutoMapper<TSource, TDestination> : IMapper<TSource, TDestination>
        where TSource : class
        where TDestination : class, new()
    {
        public TDestination Map(TSource source)
        {
            if (source == null) return null;
            var dest = new TDestination();
            Map(source, dest);
            return dest;
        }

        public void Map(TSource source, TDestination destination)
        {
            if (source == null || destination == null) return;

            var sourceProps = typeof(TSource).GetProperties();
            var destProps = typeof(TDestination).GetProperties();

            foreach (var destProp in destProps)
            {
                if (!destProp.CanWrite) continue;
                var sourceProp = Array.Find(sourceProps, p => p.Name == destProp.Name && p.PropertyType == destProp.PropertyType);
                if (sourceProp != null)
                    destProp.SetValue(destination, sourceProp.GetValue(source));
            }
        }
    }

    public class UserDto { public string FullName { get; set; } }
    public class User { public string FullName { get; set; } }
}
//39
using System;

namespace LoggerDemo
{
    public class Logger<T> where T : class
    {
        private readonly string _category;

        public Logger()
        {
            _category = typeof(T).Name;
        }

        public void Info(string message)
        {
            Console.WriteLine($"[INFO] [{_category}] {DateTime.Now:HH:mm:ss} - {message}");
        }

        public void Error(string message, Exception ex = null)
        {
            Console.WriteLine($"[ERROR] [{_category}] {DateTime.Now:HH:mm:ss} - {message}");
            if (ex != null) Console.WriteLine(ex);
        }

        public void Warn(string message)
        {
            Console.WriteLine($"[WARN] [{_category}] {DateTime.Now:HH:mm:ss} - {message}");
        }

        public void Debug(string message)
        {

            Console.WriteLine($"[DEBUG] [{_category}] {DateTime.Now:HH:mm:ss} - {message}");

        }
    }

    class OrderService
    {
        private static readonly Logger<OrderService> _log = new();

        public void Process() => _log.Info("Обработка заказа начата");
    }
}
//40
using System;

namespace OptionalDemo
{
    public static class Optional
    {
        public static Optional<T> Of<T>(T value) => new(value);

        public static Optional<T> Empty<T>() => new(Optional<T>.EmptyValue);
    }

    public readonly struct Optional<T>
    {
        internal static readonly T EmptyValue = default;
        private readonly T _value;
        public bool HasValue { get; }

        public Optional(T value)
        {
            _value = value;
            HasValue = value != null && !value.Equals(EmptyValue);
        }

        public T Value => HasValue ? _value : throw new InvalidOperationException("Нет значения");

        public T GetValueOrDefault(T defaultValue = default) => HasValue ? _value : defaultValue;

        public Optional<TResult> Map<TResult>(Func<T, TResult> mapper)
        {
            return HasValue ? Optional.Of(mapper(_value)) : Optional.Empty<TResult>();
        }

        public T GetOrElse(Func<T> supplier) => HasValue ? _value : supplier();
    }

    class Program
    {
        static void Main()
        {
            Optional<string> opt = Optional.Of("Привет");
            Console.WriteLine(opt.Map(s => s.Length).GetValueOrDefault(-1));
        }
    }
}
//41
using System;

namespace CommandPatternDemo
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class Command<T> : ICommand where T : class
    {
        private readonly Action<T> _execute;
        private readonly Action<T> _undo;
        private readonly T _receiver;

        public Command(T receiver, Action<T> execute, Action<T> undo = null)
        {
            _receiver = receiver;
            _execute = execute;
            _undo = undo ?? (_ => { });
        }

        public void Execute()
        {
            _execute(_receiver);
        }

        public void Undo()
        {
            _undo(_receiver);
        }
    }

    public class Light
    {
        public bool IsOn { get; private set; }
        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }

    class Program
    {
        static void Main()
        {
            var light = new Light();
            var turnOn = new Command<Light>(light, l => l.TurnOn(), l => l.TurnOff());
            turnOn.Execute();
            turnOn.Undo();
        }
    }
}
//42
using System.Threading.Tasks;

namespace AsyncOperationsDemo
{
    public static class AsyncHelper
    {
        public static async Task<T> WithTimeout<T>(Task<T> task, TimeSpan timeout)
        {
            var delay = Task.Delay(timeout);
            var completed = await Task.WhenAny(task, delay);
            if (completed == delay)
                throw new TimeoutException();
            return await task;
        }

        public static async Task<TResult> Select<T, TResult>(this Task<T> task, Func<T, TResult> selector)
        {
            var result = await task;
            return selector(result);
        }

        public static async Task WhenAll<T>(params Task<T>[] tasks)
        {
            await Task.WhenAll(tasks);
        }
    }
}
//43
using System;

namespace ResultDemo
{
    public class Result<T> where T : class
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string Error { get; }

        private Result(bool success, T value, string error)
        {
            IsSuccess = success;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new(true, value, null);
        public static Result<T> Failure(string error) => new(false, null, error);

        public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure)
        {
            return IsSuccess ? onSuccess(Value) : onFailure(Error);
        }
    }

    class Program
    {
        static void Main()
        {
            var result = Result<string>.Success("Успех");
            result.Match(
                s => Console.WriteLine(s),
                err => Console.WriteLine(err));
        }
    }
}
//44
using System;

namespace ProviderDemo
{
    public interface IProvider<T> where T : class, new()
    {
        T Get();
        void Release(T instance);
    }

    public class ObjectPool<T> : IProvider<T> where T : class, new()
    {
        private readonly Queue<T> _pool = new();

        public T Get()
        {
            return _pool.Count > 0 ? _pool.Dequeue() : new T();
        }

        public void Release(T instance)
        {
            _pool.Enqueue(instance);
        }
    }
}
//45
using System;

namespace ConfigDemo
{
    public class Configuration<T> where T : class, new()
    {
        private T _settings = new();

        public T Settings
        {
            get => _settings;
            set => _settings = value ?? throw new ArgumentNullException();
        }

        public TResult GetValue<TResult>(Func<T, TResult> selector)
        {
            return selector(_settings);
        }

        public void Update(Action<T> updater)
        {
            updater(_settings);
        }
    }

    public class AppConfig
    {
        public string ConnectionString { get; set; }
        public int Timeout { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var config = new Configuration<AppConfig>();
            config.Update(c => c.ConnectionString = "Server=...");
        }
    }
}
//46
using System;
using System.Collections.Generic;

namespace MinDemo
{
    public static class Comparer
    {
        public static T FindMin<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            using var enumerator = source.GetEnumerator();
            if (!enumerator.MoveNext())
                throw new InvalidOperationException("Пустая последовательность");

            T min = enumerator.Current;
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(min) < 0)
                    min = enumerator.Current;
            }
            return min;
        }

        public static (T Min, T Max) FindMinMax<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            using var e = source.GetEnumerator();
            if (!e.MoveNext()) throw new InvalidOperationException();

            T min = e.Current, max = e.Current;
            while (e.MoveNext())
            {
                var current = e.Current;
                if (current.CompareTo(min) < 0) min = current;
                if (current.CompareTo(max) > 0) max = current;
            }
            return (min, max);
        }
    }
}
//47
using System;
using System.Collections.Concurrent;

namespace ReferenceQueueDemo
{
    public class ObjectQueue<T> where T : class
    {
        private readonly ConcurrentQueue<T> _queue = new();

        public void Enqueue(T item)
        {
            if (item == null) throw new ArgumentNullException();
            _queue.Enqueue(item);
        }

        public bool TryDequeue(out T result) => _queue.TryDequeue(out result);

        public bool TryPeek(out T result) => _queue.TryPeek(out result);

        public int Count => _queue.Count;

        public void Clear() => _queue.Clear();
    }
}
//48
using System;
using System.Collections.Generic;

namespace DistinctEquatableDemo
{
    public static class EquatableExtensions
    {
        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source) where T : IEquatable<T>
        {
            var set = new HashSet<T>();
            foreach (var item in source)
            {
                if (set.Add(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> first, IEnumerable<T> second) where T : IEquatable<T>
        {
            var set = new HashSet<T>(second);
            foreach (var item in first)
                if (set.Add(item))
                    yield return item;
        }
    }
}
//49
using System;
using System.Collections.Generic;

namespace ReferenceStackDemo
{
    public class ObjectStack<T> where T : class
    {
        private readonly Stack<T> _stack = new();

        public void Push(T item)
        {
            if (item == null) throw new ArgumentNullException();
            _stack.Push(item);
        }

        public T Pop()
        {
            if (_stack.Count == 0) throw new InvalidOperationException("Стек пуст");
            return _stack.Pop();
        }

        public bool TryPop(out T result) => _stack.TryPop(out result);

        public T Peek() => _stack.Peek();

        public int Count => _stack.Count;
    }
}
//50
using System;
using System.Collections.Generic;

namespace AggregationDemo
{
    public static class Aggregator
    {
        public static TResult Aggregate<T, TResult>(IEnumerable<T> source, TResult initialValue, Func<TResult, T, TResult> accumulator)
            where T : class
            where TResult : class, new()
        {
            var result = new TResult();
            foreach (var item in source)
            {
                result = accumulator(result, item) ?? result;
            }
            return result ?? initialValue;
        }

        public static TAccumulate Fold<T, TAccumulate>(IEnumerable<T> source, TAccumulate seed, Func<TAccumulate, T, TAccumulate> folder)
            where T : struct
            where TAccumulate : struct, IComparable<TAccumulate>
        {
            var result = seed;
            foreach (var item in source)
                result = folder(result, item);
            return result;
        }
    }
}
//50
using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregationDemo
{
    public static class DataAggregator
    {
        public static Dictionary<TKey, TResult> Aggregate<TSource, TKey, TResult>(
            IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<IEnumerable<TSource>, TResult> aggregator)
            where TKey : notnull
        {
            var result = new Dictionary<TKey, TResult>();
            var groups = source.GroupBy(keySelector);
            foreach (var group in groups)
                result[group.Key] = aggregator(group);
            return result;
        }

        public static TAccumulate Fold<TSource, TAccumulate>(
            IEnumerable<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> folder)
            where TSource : class
            where TAccumulate : struct
        {
            var result = seed;
            foreach (var item in source)
                result = folder(result, item);
            return result;
        }

        public static (int Count, decimal Sum, decimal Avg) Stats<T>(
            IEnumerable<T> source,
            Func<T, decimal> selector)
            where T : class
        {
            var list = source.ToList();
            int count = list.Count;
            decimal sum = list.Sum(selector);
            decimal avg = count > 0 ? sum / count : 0;
            return (count, sum, avg);
        }
    }

    class Program
    {
        static void Main()
        {
            var numbers = new List<decimal> { 10.5m, 20.3m, 15.7m, 30.1m };
            var stats = DataAggregator.Stats(numbers, x => x);
            Console.WriteLine($"Count: {stats.Count}, Sum: {stats.Sum}, Avg: {stats.Avg}");
        }
    }
}
//51
using System;
using System.Collections.Generic;

namespace ListBasicDemo
{
    class Program
    {
        static void Main()
        {
            var names = new List<string>();
            names.Add("Алексей");
            names.Add("Марина");
            names.AddRange(new[] { "Дмитрий", "Ольга", "Сергей" });
            names.Insert(1, "Виктор");
            names.InsertRange(3, new[] { "Анна", "Павел" });

            Console.WriteLine("Все имена:");
            for (int i = 0; i < names.Count; i++)
                Console.WriteLine($"{i + 1}. {names[i]}");

            names[2] = "Игорь";
            names.Remove("Ольга");
            names.RemoveAt(0);
            names.RemoveRange(3, 2);

            Console.WriteLine($"\nПосле операций осталось: {names.Count}");
            names.ForEach(n => Console.WriteLine(n));

            var copy = new List<string>(names);
            names.Clear();
            Console.WriteLine($"\nОригинал очищен. Копия ({copy.Count}):");
            copy.ForEach(Console.WriteLine);

            copy.TrimExcess();
            Console.WriteLine($"Capacity после TrimExcess: {copy.Capacity}");
        }
    }
}
//52
using System;
using System.Collections.Generic;

namespace FindOperationsDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public override string ToString() => $"{Name} [{Category}] - {Price:C}";
    }

    class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук X1", Price = 85000, Category = "Компьютеры" },
                new Product { Id = 2, Name = "Мышь", Price = 1500, Category = "Периферия" },
                new Product { Id = 3, Name = "Монитор 27", Price = 25000, Category = "Периферия" },
                new Product { Id = 4, Name = "Клавиатура", Price = 4500, Category = "Периферия" },
                new Product { Id = 5, Name = "Планшет", Price = 32000, Category = "Компьютеры" }
            };

            var expensive = products.Find(p => p.Price > 50000);
            Console.WriteLine($"Первый дорогой: {expensive}");

            var lastPeripheral = products.FindLast(p => p.Category == "Периферия");
            Console.WriteLine($"Последняя периферия: {lastPeripheral}");

            var computers = products.FindAll(p => p.Category == "Компьютеры");
            Console.WriteLine("\nВсе компьютеры:");
            computers.ForEach(Console.WriteLine);

            var index = products.FindIndex(p => p.Name.Contains("27"));
            Console.WriteLine($"\nИндекс монитора: {index}");

            var cheapPeripherals = products.FindAll(p => p.Category == "Периферия" && p.Price < 10000);
            Console.WriteLine("\nДешевая периферия:");
            cheapPeripherals.ForEach(Console.WriteLine);
        }
    }
}
//53
using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyDemo
{
    class Program
    {
        static void Main()
        {
            string text = "the cat and the dog saw the mouse and the cat ran";
            var words = text.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var word in words)
                frequency[word] = frequency.GetValueOrDefault(word) + 1;

            Console.WriteLine("Частота слов:");
            foreach (var kvp in frequency.OrderByDescending(x => x.Value))
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            var mostCommon = frequency.MaxBy(kvp => kvp.Value);
            Console.WriteLine($"\nСамое частое: {mostCommon.Key} ({mostCommon.Value})");

            var singles = frequency.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();
            singles.ForEach(w => frequency.Remove(w));

            Console.WriteLine($"\nПосле удаления редких осталось: {frequency.Count}");
        }
    }
}
//54
using System;
using System.Collections.Generic;

namespace CustomListDemo
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public override string ToString() => $"{Title} - {Author} ({Year}) - {Price:C}";
    }

    class Program
    {
        static void Main()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Война и мир", Author = "Толстой", Price = 890, Year = 1869 },
                new Book { Id = 2, Title = "Преступление и наказание", Author = "Достоевский", Price = 720, Year = 1866 },
                new Book { Id = 3, Title = "Мастер и Маргарита", Author = "Булгаков", Price = 950, Year = 1967 }
            };

            books.Add(new Book { Id = 4, Title = "1984", Author = "Оруэлл", Price = 680, Year = 1949 });

            Console.WriteLine("Все книги:");
            books.ForEach(Console.WriteLine);

            var classics = books.FindAll(b => b.Year < 1900);
            Console.WriteLine("\nКлассика XIX века:");
            classics.ForEach(Console.WriteLine);

            var book = books.Find(b => b.Author == "Булгаков");
            if (book != null) book.Price = 1200;

            books.RemoveAll(b => b.Price < 700);

            Console.WriteLine($"\nПосле фильтрации осталось: {books.Count} книг");
            books.ForEach(Console.WriteLine);
        }
    }
}
//55
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingDemo
{
    public class Sale
    {
        public int SaleId { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var sales = new List<Sale>
            {
                new Sale { SaleId = 1, Product = "Телефон", Amount = 45000, Date = new DateTime(2025, 11, 1) },
                new Sale { SaleId = 2, Product = "Ноутбук", Amount = 85000, Date = new DateTime(2025, 11, 2) },
                new Sale { SaleId = 3, Product = "Телефон", Amount = 48000, Date = new DateTime(2025, 11, 5) },
                new Sale { SaleId = 4, Product = "Планшет", Amount = 32000, Date = new DateTime(2025, 11, 8) },
                new Sale { SaleId = 5, Product = "Телефон", Amount = 46000, Date = new DateTime(2025, 11, 15) }
            };

            var productSales = new Dictionary<string, List<Sale>>();

            foreach (var sale in sales)
            {
                if (!productSales.ContainsKey(sale.Product))
                    productSales[sale.Product] = new List<Sale>();
                productSales[sale.Product].Add(sale);
            }

            Console.WriteLine("Продажи по товарам:");
            foreach (var kvp in productSales)
            {
                Console.WriteLine($"\nТовар: {kvp.Key} ({kvp.Value.Count} продаж)");
                decimal total = kvp.Value.Sum(s => s.Amount);
                foreach (var s in kvp.Value)
                    Console.WriteLine($"  #{s.SaleId} - {s.Amount:C} - {s.Date:dd.MM}");
                Console.WriteLine($"  Итого: {total:C}");
            }

            var topProduct = productSales.MaxBy(g => g.Value.Sum(s => s.Amount));
            Console.WriteLine($"\nЛидер продаж: {topProduct.Key} - {topProduct.Value.Sum(s => s.Amount):C}");
        }
    }
}
//56
using System;
using System.Collections.Generic;

namespace SortingDemo
{
    class Program
    {
        static void Main()
        {
            var data = new List<int> { 170, 45, 75, 90, 2, 802, 24, 66, 24 };

            Console.WriteLine("Оригинал: " + string.Join(" ", data));

            data.Sort();
            Console.WriteLine("Sort(): " + string.Join(" ", data));

            data.Reverse();
            Console.WriteLine("Reverse(): " + string.Join(" ", data));

            data.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine("По убыванию: " + string.Join(" ", data));

            data.Sort();
            int pos = data.BinarySearch(75);
            Console.WriteLine($"BinarySearch(75) = индекс {pos}");

            int missing = data.BinarySearch(100);
            Console.WriteLine($"BinarySearch(100) = {missing} (~вставки: {~missing})");
        }
    }
}
//57
using System;
using System.Collections.Generic;

namespace PricesDemo
{
    class Program
    {
        static void Main()
        {
            var prices = new Dictionary<string, decimal>
            {
                ["Молоко"] = 89.90m,
                ["Хлеб"] = 45.00m,
                ["Яйца (10шт)"] = 110.50m,
                ["Масло"] = 220.00m,
                ["Сыр"] = 650.00m
            };

            prices["Молоко"] = 79.90m;
            prices.TryAdd("Колбаса", 480.00m);

            Console.WriteLine("Цены в магазине:");
            foreach (var p in prices)
                Console.WriteLine($"{p.Key,-15} {p.Value,8:C}");

            var cart = new[] { "Молоко", "Хлеб", "Яйца (10шт)", "Сыр" };
            decimal total = 0;
            foreach (var item in cart)
                if (prices.TryGetValue(item, out decimal price))
                    total += price;

            Console.WriteLine($"\nИтого к оплате: {total:C}");
        }
    }
}
//58
using System;
using System.Collections.Generic;

namespace DictionaryCustomValueDemo
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public override string ToString() => $"Заказ #{OrderId} от {Date:dd.MM} на {Total:C} [{Status}]";
    }

    class Program
    {
        static void Main()
        {
            var customerOrders = new Dictionary<string, List<Order>>
            {
                ["ivanov"] = new List<Order>
                {
                    new Order { OrderId = 1001, Date = new DateTime(2025, 11, 1), Total = 12500, Status = "Доставлен" },
                    new Order { OrderId = 1005, Date = new DateTime(2025, 11, 15), Total = 8900, Status = "В пути" }
                },
                ["petrova"] = new List<Order>
                {
                    new Order { OrderId = 1002, Date = new DateTime(2025, 11, 3), Total = 24500, Status = "Доставлен" }
                }
            };

            customerOrders["sidorov"] = new List<Order>
            {
                new Order { OrderId = 1008, Date = DateTime.Today, Total = 15900, Status = "Новый" }
            };

            customerOrders["ivanov"].Add(new Order { OrderId = 1012, Date = DateTime.Today, Total = 5600, Status = "Новый" });

            Console.WriteLine("Заказы клиентов:");
            foreach (var kvp in customerOrders)
            {
                Console.WriteLine($"\nКлиент: {kvp.Key}");
                foreach (var order in kvp.Value)
                    Console.WriteLine($"  {order}");
                Console.WriteLine($"  Всего заказов: {kvp.Value.Count}, на сумму: {kvp.Value.Sum(o => o.Total):C}");
            }
        }
    }
}
//59
using System;
using System.Collections.Generic;

namespace TupleDemo
{
    class Program
    {
        static void Main()
        {
            var countries = new List<(int Id, string Name, string Capital, int Population)>
            {
                (1, "Россия", "Москва", 146_000_000),
                (2, "Германия", "Берлин", 83_000_000),
                (3, "Франция", "Париж", 67_000_000),
                (4, "Япония", "Токио", 125_000_000),
                (5, "Бразилия", "Бразилиа", 215_000_000)
            };

            countries.Add((6, "Канада", "Оттава", 38_000_000));

            Console.WriteLine("Страны по населению:");
            foreach (var c in countries.OrderByDescending(x => x.Population))
                Console.WriteLine($"{c.Id}. {c.Name} - {c.Capital} - {c.Population:N0} чел.");

            var largest = countries.MaxBy(c => c.Population);
            Console.WriteLine($"\nСамая большая по населению: {largest.Name} ({largest.Population:N0})");
        }
    }
}
//60
using System;
using System.Collections.Generic;

namespace SortedDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            var scores = new SortedDictionary<string, int>();

            scores["Мария"] = 95;
            scores["Алексей"] = 88;
            scores["Дмитрий"] = 92;
            scores["Ольга"] = 99;
            scores["Сергей"] = 85;

            scores["Анна"] = 97;

            Console.WriteLine("Результаты экзамена (по алфавиту):");
            foreach (var kvp in scores)
                Console.WriteLine($"{kvp.Key} - {kvp.Value} баллов");

            Console.WriteLine($"\nЛучший результат: {scores.MaxBy(kvp => kvp.Value).Key} - {scores.Values.Max()}");
            Console.WriteLine($"Худший результат: {scores.MinBy(kvp => kvp.Value).Key} - {scores.Values.Min()}");

            Console.WriteLine("\nТоп-3:");
            foreach (var kvp in scores.Reverse().Take(3))
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}
//61
using System;
using System.Collections.Generic;

namespace DictionaryHashSetDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 61: Dictionary<int, HashSet<T>> ===\n");

            var categoryProducts = new Dictionary<int, HashSet<string>>
            {
                [1] = new HashSet<string> { "Ноутбук", "Планшет", "Монитор" },
                [2] = new HashSet<string> { "Телефон", "Наушники", "Чехол" },
                [3] = new HashSet<string> { "Клавиатура", "Мышь", "Коврик" }
            };

            categoryProducts[1].Add("Веб-камера");
            categoryProducts[2].Add("Наушники");
            categoryProducts[2].Add("Зарядка");

            categoryProducts[4] = new HashSet<string> { "Принтер", "Сканер", "Картридж" };

            Console.WriteLine("Товары по категориям (уникальные):");
            foreach (var kvp in categoryProducts)
            {
                Console.WriteLine($"\nКатегория {kvp.Key}:");
                foreach (var product in kvp.Value)
                    Console.WriteLine($"  • {product}");
                Console.WriteLine($"  Всего уникальных: {kvp.Value.Count}");
            }

            if (categoryProducts[2].Contains("Наушники"))
                Console.WriteLine("\nНаушники уже есть в категории 2");

            var allProducts = new HashSet<string>();
            foreach (var set in categoryProducts.Values)
                allProducts.UnionWith(set);

            Console.WriteLine($"\nОбщее количество уникальных товаров: {allProducts.Count}");
        }
    }
}
//62
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListLinqDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 62: List<T> + LINQ ===\n");

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Алексей", Salary = 95000, Position = "Senior Developer", DepartmentId = 10 },
                new Employee { Id = 2, Name = "Марина", Salary = 72000, Position = "Designer", DepartmentId = 20 },
                new Employee { Id = 3, Name = "Дмитрий", Salary = 110000, Position = "Team Lead", DepartmentId = 10 },
                new Employee { Id = 4, Name = "Ольга", Salary = 68000, Position = "QA Engineer", DepartmentId = 30 },
                new Employee { Id = 5, Name = "Сергей", Salary = 85000, Position = "Developer", DepartmentId = 10 }
            };

            var highSalary = employees.Where(e => e.Salary > 80000).OrderByDescending(e => e.Salary);
            Console.WriteLine("Сотрудники с зарплатой > 80к:");
            foreach (var e in highSalary)
                Console.WriteLine($"  {e.Name} — {e.Salary:C} ({e.Position})");

            var avgSalary = employees.Average(e => e.Salary);
            var maxSalary = employees.Max(e => e.Salary);
            var devCount = employees.Count(e => e.Position.Contains("Developer") || e.Position.Contains("Lead"));

            Console.WriteLine($"\nСредняя зарплата: {avgSalary:C}");
            Console.WriteLine($"Максимальная: {maxSalary:C}");
            Console.WriteLine($"Разработчиков: {devCount}");

            var names = employees.Select(e => e.Name.ToUpper()).ToList();
            Console.WriteLine("\nИмена заглавными:");
            names.ForEach(n => Console.WriteLine($"  {n}"));

            var grouped = employees.GroupBy(e => e.DepartmentId);
            Console.WriteLine("\nПо отделам:");
            foreach (var g in grouped)
                Console.WriteLine($"  Отдел {g.Key}: {g.Count()} чел., средняя з/п {g.Average(x => x.Salary):C}");
        }
    }
}
//63
using System;
using System.Collections.Generic;

namespace DynamicDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 63: Dictionary<string, object> ===\n");

            var config = new Dictionary<string, object>
            {
                ["Server"] = "prod-db-01",
                ["Port"] = 5432,
                ["Timeout"] = TimeSpan.FromSeconds(30),
                ["EnableCache"] = true,
                ["MaxConnections"] = 100,
                ["Tags"] = new List<string> { "production", "high-load", "monitoring" },
                ["Metadata"] = new Dictionary<string, string>
                {
                    ["Version"] = "2.4.1",
                    ["Owner"] = "DevOps Team"
                }
            };

            config["LastUpdated"] = DateTime.Now;

            Console.WriteLine("Конфигурация приложения:");
            foreach (var kvp in config)
            {
                if (kvp.Value is IEnumerable<object> enumerable && !(kvp.Value is string))
                {
                    Console.Write($"  {kvp.Key}: ");
                    Console.WriteLine(string.Join(", ", enumerable));
                }
                else
                {
                    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
                }
            }

            if (config["EnableCache"] is bool cache && cache)
                Console.WriteLine("\nКэширование включено");

            if (config["Tags"] is List<string> tags)
            {
                tags.Add("updated-2025");
                Console.WriteLine("Теги обновлены");
            }
        }
    }
}
//64
using System;
using System.Collections.Generic;

namespace QueueStackDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 64: Queue<T> и Stack<T> ===\n");

            var printQueue = new Queue<string>();
            printQueue.Enqueue("Документ1.pdf");
            printQueue.Enqueue("Отчет_2025.docx");
            printQueue.Enqueue("Фото.jpg");
            printQueue.Enqueue("Презентация.pptx");

            Console.WriteLine($"В очереди на печать: {printQueue.Count} документов");
            while (printQueue.Count > 0)
            {
                var doc = printQueue.Dequeue();
                Console.WriteLine($"Печатается: {doc}");
            }

            var browserHistory = new Stack<string>();
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            browserHistory.Push("youtube.com");

            Console.WriteLine($"\nИстория браузера ({browserHistory.Count} вкладок):");
            Console.WriteLine($"Текущая: {browserHistory.Peek()}");

            Console.WriteLine("\nНажата кнопка 'Назад':");
            while (browserHistory.Count > 0)
            {
                var page = browserHistory.Pop();
                Console.WriteLine($"  ← {page}");
            }

            var undoStack = new Stack<Action>();
            int x = 0;
            undoStack.Push(() => x = 0);
            x = 10;
            undoStack.Push(() => x = 10);
            x = 25;

            Console.WriteLine($"\nТекущее значение: {x}");
            if (undoStack.Count > 0)
            {
                undoStack.Pop().Invoke();
                Console.WriteLine($"После Undo: {x}");
            }
        }
    }
}
//65
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListTransformDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 65: List<T> с фильтрацией и преобразованием ===\n");

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук Pro", Price = 129000, Category = "Электроника", InStock = true },
                new Product { Id = 2, Name = "Кофе в зернах", Price = 890, Category = "Продукты", InStock = true },
                new Product { Id = 3, Name = "Наушники", Price = 15900, Category = "Электроника", InStock = false },
                new Product { Id = 4, Name = "Книга C#", Price = 2490, Category = "Книги", InStock = true },
                new Product { Id = 5, Name = "Монитор 27\"", Price = 35900, Category = "Электроника", InStock = true }
            };

            var availableElectronics = products
                .Where(p => p.Category == "Электроника" && p.InStock)
                .OrderBy(p => p.Price);

            Console.WriteLine("Доступная электроника (по возрастанию цены):");
            foreach (var p in availableElectronics)
                Console.WriteLine($"  {p.Name} — {p.Price:C}");

            var productNames = products
                .Where(p => p.InStock)
                .Select(p => p.Name.ToUpper());

            Console.WriteLine("\nНазвания товаров в наличии (верхний регистр):");
            productNames.ToList().ForEach(n => Console.WriteLine($"  → {n}"));

            var discounted = products
                .Where(p => p.InStock)
                .Select(p => new
                {
                    p.Name,
                    OriginalPrice = p.Price,
                    DiscountedPrice = p.Price * 0.9m,
                    Savings = p.Price * 0.1m
                });

            Console.WriteLine("\nТовары со скидкой 10%:");
            foreach (var item in discounted)
                Console.WriteLine($"  {item.Name}: {item.OriginalPrice:C} → {item.DiscountedPrice:C} (экономия {item.Savings:C})");

            var totalValue = products
                .Where(p => p.InStock)
                .Sum(p => p.Price);

            Console.WriteLine($"\nОбщая стоимость товаров в наличии: {totalValue:C}");
        }
    }
}
//66
using System;
using System.Collections.Generic;

namespace SafeDictionaryDemo
{
    public class SafeDictionary<TKey, TValue> where TKey : notnull
    {
        private readonly Dictionary<TKey, TValue> _dict = new();

        public TValue Get(TKey key)
        {
            if (!_dict.ContainsKey(key))
                throw new KeyNotFoundException($"Ключ '{key}' не найден");
            return _dict[key];
        }

        public TValue GetOrDefault(TKey key, TValue defaultValue = default!)
        {
            return _dict.TryGetValue(key, out var value) ? value : defaultValue;
        }

        public void Set(TKey key, TValue value)
        {
            _dict[key] = value;
        }

        public bool TryGet(TKey key, out TValue value)
        {
            return _dict.TryGetValue(key, out value!);
        }

        public bool ContainsKey(TKey key) => _dict.ContainsKey(key);

        public void Remove(TKey key)
        {
            if (!_dict.ContainsKey(key))
                throw new KeyNotFoundException($"Ключ '{key}' не найден");
            _dict.Remove(key);
        }

        public int Count => _dict.Count;
    }

    class Program
    {
        static void Main()
        {
            var safe = new SafeDictionary<string, int>();
            safe.Set("apple", 5);
            safe.Set("banana", 3);

            Console.WriteLine(safe.Get("apple"));
            Console.WriteLine(safe.GetOrDefault("orange", 0));
        }
    }
}
//67
using System;
using System.Collections.Generic;

namespace SortedListDemo
{
    class Program
    {
        static void Main()
        {
            var scores = new SortedList<string, int>();
            scores.Add("Ольга", 95);
            scores.Add("Алексей", 88);
            scores.Add("Мария", 99);
            scores.Add("Дмитрий", 92);

            scores["Сергей"] = 85;
            scores["Анна"] = 97;

            Console.WriteLine("Результаты по алфавиту:");
            foreach (KeyValuePair<string, int> kvp in scores)
                Console.WriteLine($"{kvp.Key} — {kvp.Value}");

            Console.WriteLine($"\nЛучший: {scores.Values.Max()}");
            Console.WriteLine($"Худший: {scores.Values.Min()}");

            if (scores.TryGetValue("Мария", out int mariaScore))
                Console.WriteLine($"Мария: {mariaScore}");

            scores.Remove("Алексей");
            Console.WriteLine($"\nПосле удаления осталось: {scores.Count}");
        }
    }
}
//68
using System;
using System.Collections.Generic;

namespace EventListDemo
{
    public class EventManager
    {
        private readonly List<string> _events = new();

        public void AddEvent(string eventName)
        {
            _events.Add($"[{DateTime.Now:HH:mm:ss}] {eventName}");
            Console.WriteLine($"Событие: {eventName}");
        }

        public void Subscribe(Action<string> handler)
        {
            foreach (var e in _events)
                handler(e);
        }

        public IReadOnlyList<string> GetHistory() => _events.AsReadOnly();

        public void Clear() => _events.Clear();

        public int Count => _events.Count;
    }

    class Program
    {
        static void Main()
        {
            var manager = new EventManager();
            manager.AddEvent("Система запущена");
            manager.AddEvent("Пользователь вошел");
            manager.AddEvent("Файл сохранен");

            manager.Subscribe(e => Console.WriteLine($"Уведомление: {e}"));
        }
    }
}
//69
using System;
using System.Collections.Generic;

namespace MultiLevelStorageDemo
{
    class Program
    {
        static void Main()
        {
            var storage = new Dictionary<string, List<string>>();
            storage["fruits"] = new List<string> { "apple", "banana", "orange" };
            storage["vegetables"] = new List<string> { "carrot", "potato" };
            storage["dairy"] = new List<string> { "milk", "cheese", "yogurt" };

            storage["fruits"].Add("grape");

            if (!storage.ContainsKey("meat"))
                storage["meat"] = new List<string>();

            storage["meat"].AddRange(new[] { "beef", "chicken", "pork" });

            Console.WriteLine("Хранилище продуктов:");
            foreach (var category in storage)
            {
                Console.WriteLine($"\n{category.Key}:");
                foreach (var item in category.Value)
                    Console.WriteLine($"  - {item}");
            }
        }
    }
}
//70
using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main()
        {
            var list = new LinkedList<string>();
            var node1 = list.AddFirst("Первый");
            var node2 = list.AddAfter(node1, "Второй");
            list.AddLast("Последний");
            list.AddBefore(node2, "Перед вторым");

            Console.WriteLine("Связный список:");
            for (var node = list.First; node != null; node = node.Next)
                Console.WriteLine(node.Value);

            list.Remove(node1);
            list.Remove("Последний");

            Console.WriteLine("\nПосле удалений:");
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
//71
using System;
using System.Collections.Generic;

namespace SearchMethodsDemo
{
    class Program
    {
        static void Main()
        {
            var names = new List<string> { "Анна", "Борис", "Анна", "Виктор", "Анна", "Дмитрий" };

            Console.WriteLine($"Contains(\"Анна\"): {names.Contains("Анна")}");
            Console.WriteLine($"IndexOf(\"Виктор\"): {names.IndexOf("Виктор")}");
            Console.WriteLine($"LastIndexOf(\"Анна\"): {names.LastIndexOf("Анна")}");

            int firstAnna = names.IndexOf("Анна");
            int nextAnna = names.IndexOf("Анна", firstAnna + 1);
            Console.WriteLine($"Вторая Анна на позиции: {nextAnna}");
        }
    }
}
//72
using System;
using System.Collections.Generic;

namespace IntStringMappingDemo
{
    class Program
    {
        static void Main()
        {
            var statusMap = new Dictionary<int, string>
            {
                [1] = "Новый",
                [2] = "В обработке",
                [3] = "Выполнен",
                [4] = "Отменен",
                [5] = "На паузе"
            };

            int code = 3;
            if (statusMap.TryGetValue(code, out string description))
                Console.WriteLine($"Статус {code}: {description}");

            foreach (var kvp in statusMap)
                Console.WriteLine($"Код {kvp.Key} → {kvp.Value}");
        }
    }
}
//73
using System;
using System.Collections.Generic;

namespace ListAddRemoveDemo
{
    class Program
    {
        static void Main()
        {
            var tasks = new List<string>();
            tasks.Add("Задача 1");
            tasks.AddRange(new[] { "Задача 2", "Задача 3" });
            tasks.Insert(1, "Срочная задача");

            tasks.Remove("Задача 2");
            tasks.RemoveAt(0);

            Console.WriteLine("Оставшиеся задачи:");
            for (int i = 0; i < tasks.Count; i++)
                Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}
//74
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencyCounterDemo
{
    class Program
    {
        static void Main()
        {
            var words = "apple banana apple orange banana apple".Split();
            var counter = new Dictionary<string, int>();

            foreach (var word in words)
                counter[word] = counter.GetValueOrDefault(word) + 1;

            foreach (var kvp in counter.OrderByDescending(x => x.Value))
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
//75
using System;
using System.Collections.Generic;

namespace KeyValuePairListDemo
{
    class Program
    {
        static void Main()
        {
            var settings = new List<KeyValuePair<string, string>>
            {
                new("theme", "dark"),
                new("language", "ru"),
                new("notifications", "true")
            };

            settings.Add(new KeyValuePair<string, string>("version", "2.1"));

            foreach (var pair in settings)
                Console.WriteLine($"{pair.Key} = {pair.Value}");

            var lang = settings.Find(p => p.Key == "language");
            Console.WriteLine($"Язык: {lang.Value}");
        }
    }
}
//76
using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryIterationDemo
{
    class Program
    {
        static void Main()
        {
            var users = new Dictionary<int, string>
            {
                [1] = "Админ",
                [2] = "Пользователь",
                [3] = "Гость",
                [4] = "Модератор"
            };

            Console.WriteLine("Все пользователи:");
            foreach (var kvp in users)
                Console.WriteLine($"ID: {kvp.Key} → {kvp.Value}");

            var active = users.Where(kvp => kvp.Key < 4);
            Console.WriteLine("\nАктивные:");
            foreach (var kvp in active)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
//77
using System;
using System.Collections.Generic;

namespace CacheListDemo
{
    public class Cache<T>
    {
        private readonly List<T> _items = new();
        private readonly int _capacity;

        public Cache(int capacity) => _capacity = capacity;

        public void Add(T item)
        {
            if (_items.Count >= _capacity)
                _items.RemoveAt(0);
            _items.Add(item);
        }

        public IReadOnlyList<T> Items => _items.AsReadOnly();
    }

    class Program
    {
        static void Main()
        {
            var cache = new Cache<string>(3);
            cache.Add("страница1");
            cache.Add("страница2");
            cache.Add("страница3");
            cache.Add("страница4");

            foreach (var page in cache.Items)
                Console.WriteLine(page);
        }
    }
}
//78
using System;
using System.Collections.Generic;

namespace PolymorphicDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            var objects = new Dictionary<int, object>
            {
                [1] = "Текстовая запись",
                [2] = 42,
                [3] = true,
                [4] = DateTime.Now,
                [5] = new List<int> { 1, 2, 3 }
            };

            foreach (var kvp in objects)
                Console.WriteLine($"[{kvp.Key}] {kvp.Value} ({kvp.Value.GetType().Name})");
        }
    }
}
//79
using System;
using System.Collections.Generic;

namespace RemoveOperationsDemo
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>();
            for (int i = 1; i <= 20; i++) numbers.Add(i);

            numbers.RemoveAll(x => x % 3 == 0);
            numbers.RemoveRange(0, 2);

            Console.WriteLine("После удаления:");
            foreach (var n in numbers)
                Console.Write($"{n} ");
        }
    }
}
//80
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiDimensionalDemo
{
    class Program
    {
        static void Main()
        {
            var sales = new Dictionary<string, Dictionary<string, int>>
            {
                ["Москва"] = new Dictionary<string, int>
                {
                    ["Январь"] = 150,
                    ["Февраль"] = 180,
                    ["Март"] = 200
                },
                ["СПб"] = new Dictionary<string, int>
                {
                    ["Январь"] = 120,
                    ["Февраль"] = 140,
                    ["Март"] = 160
                }
            };

            foreach (var city in sales)
            {
                Console.WriteLine($"\n{city.Key}:");
                int total = city.Value.Values.Sum();
                foreach (var month in city.Value)
                    Console.WriteLine($"  {month.Key}: {month.Value}");
                Console.WriteLine($"  Итого: {total}");
            }
        }
    }
}
//81
using System;
using System.Collections.Generic;

namespace CustomSortDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public override string ToString() => $"{Name} (з/п: {Salary}, опыт: {Experience})";
    }

    class SalaryThenExperienceComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x == null || y == null) return 0;
            int salaryCompare = x.Salary.CompareTo(y.Salary);
            return salaryCompare != 0 ? salaryCompare : x.Experience.CompareTo(y.Experience);
        }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Алексей", Salary = 80000, Experience = 5 },
                new Employee { Name = "Марина", Salary = 120000, Experience = 3 },
                new Employee { Name = "Дмитрий", Salary = 80000, Experience = 8 },
                new Employee { Name = "Ольга", Salary = 95000, Experience = 6 }
            };

            employees.Sort(new SalaryThenExperienceComparer());

            Console.WriteLine("Сотрудники по зарплате, затем по опыту:");
            employees.ForEach(e => Console.WriteLine(e));
        }
    }
}
//82
using System;
using System.Collections.Generic;
using System.Linq;

namespace CategoryGroupingDemo
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product { Name = "Ноутбук", Category = "Электроника", Price = 85000 },
                new Product { Name = "Яблоки", Category = "Продукты", Price = 89.9m },
                new Product { Name = "Телефон", Category = "Электроника", Price = 45000 },
                new Product { Name = "Молоко", Category = "Продукты", Price = 75 }
            };

            var grouped = new Dictionary<string, List<Product>>();

            foreach (var p in products)
            {
                if (!grouped.ContainsKey(p.Category))
                    grouped[p.Category] = new List<Product>();
                grouped[p.Category].Add(p);
            }

            foreach (var kvp in grouped)
            {
                Console.WriteLine($"\n{kvp.Key}:");
                foreach (var p in kvp.Value)
                    Console.WriteLine($"  {p.Name} - {p.Price:C}");
            }
        }
    }
}

//84
using System;
using System.Collections.Generic;

namespace DictionaryHashSetDemo
{
    class Program
    {
        static void Main()
        {
            var tags = new Dictionary<string, HashSet<string>>
            {
                ["пост1"] = new HashSet<string> { "csharp", "dotnet", "programming" },
                ["пост2"] = new HashSet<string> { "java", "spring", "programming" }
            };

            tags["пост1"].Add("oop");
            tags["пост1"].Add("csharp");

            tags["пост3"] = new HashSet<string> { "python", "django", "web" };

            foreach (var kvp in tags)
            {
                Console.WriteLine($"\n{kvp.Key}:");
                foreach (var tag in kvp.Value)
                    Console.WriteLine($"  #{tag}");
            }
        }
    }
}
//86
using System;
using System.Collections.Generic;

namespace TypedStorageDemo
{
    public class Storage<T>
    {
        private readonly Dictionary<string, T> _data = new();

        public void Set(string key, T value) => _data[key] = value;
        public T Get(string key) => _data[key];
        public bool TryGet(string key, out T value) => _data.TryGetValue(key, out value);
        public void Remove(string key) => _data.Remove(key);
    }

    class Program
    {
        static void Main()
        {
            var config = new Storage<string>();
            config.Set("theme", "dark");
            config.Set("lang", "ru");

            Console.WriteLine(config.Get("theme"));
        }
    }
}
//87
using System;
using System.Collections.Generic;

namespace NullableListDemo
{
    class Program
    {
        static void Main()
        {
            var scores = new List<int?> { 95, null, 88, 100, null, 72 };

            scores.Add(null);
            scores.Insert(1, 99);

            int validCount = 0;
            int sum = 0;
            foreach (var s in scores)
                if (s.HasValue)
                {
                    sum += s.Value;
                    validCount++;
                }

            double avg = validCount > 0 ? (double)sum / validCount : 0;
            Console.WriteLine($"Средний балл (без null): {avg:F1}");
        }
    }
}
//88
using System;
using System.Collections.Generic;

namespace TryGetValueDemo
{
    class Program
    {
        static void Main()
        {
            var errorCodes = new Dictionary<int, string>
            {
                [404] = "Not Found",
                [500] = "Internal Server Error",
                [200] = "OK"
            };

            int code = 404;
            if (errorCodes.TryGetValue(code, out string message))
                Console.WriteLine($"Ошибка {code}: {message}");
            else
                Console.WriteLine("Неизвестная ошибка");

            code = 403;
            errorCodes.TryGetValue(code, out message);
            Console.WriteLine(message == null ? "Код не найден" : message);
        }
    }
}
//89
using System;
using System.Collections.Generic;

namespace CapacityDemo
{
    class Program
    {
        static void Main()
        {
            var list = new List<int>(20);
            Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");

            for (int i = 0; i < 25; i++)
            {
                list.Add(i * 10);
                if (list.Capacity != list.Count * 2 && list.Count > 10)
                    Console.WriteLine($"После добавления {list.Count} элементов: Capacity = {list.Capacity}");
            }

            list.TrimExcess();
            Console.WriteLine($"После TrimExcess: Capacity = {list.Capacity}");
        }
    }
}
//90
using System;
using System.Collections.Generic;

namespace FinanceDemo
{
    class Program
    {
        static void Main()
        {
            var balances = new Dictionary<string, decimal>
            {
                ["USD"] = 125000.75m,
                ["EUR"] = 98000.50m,
                ["RUB"] = 12500000.00m
            };

            balances["USD"] += 5000.25m;
            balances["BTC"] = 0.5m * 65000m;

            decimal totalUsd = 0;
            foreach (var kvp in balances)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value:C2}");
                totalUsd += kvp.Key == "USD" ? kvp.Value : 0;
            }

            Console.WriteLine($"\nВсего в USD: {totalUsd:C2}");
        }
    }
}
//91
using System;
using System.Collections.Generic;

namespace CustomCollectionDemo
{
    public class LimitedList<T> : List<T>
    {
        private readonly int _maxSize;

        public LimitedList(int maxSize) => _maxSize = maxSize;

        public new void Add(T item)
        {
            if (Count >= _maxSize)
                RemoveAt(0);
            base.Add(item);
        }

        public new void Insert(int index, T item)
        {
            if (Count >= _maxSize)
                RemoveAt(0);
            base.Insert(index, item);
        }
    }

    class Program
    {
        static void Main()
        {
            var history = new LimitedList<string>(5);
            history.Add("page1");
            history.Add("page2");
            history.Add("page3");
            history.Add("page4");
            history.Add("page5");
            history.Add("page6");

            history.ForEach(Console.WriteLine);
        }
    }
}
//92
using System;
using System.Collections.Generic;

namespace ComplexDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            var records = new Dictionary<int, List<KeyValuePair<string, object>>>
            {
                [1] = new List<KeyValuePair<string, object>>
                {
                    new("name", "Иван"),
                    new("age", 30),
                    new("active", true)
                }
            };

            records[2] = new List<KeyValuePair<string, object>>
            {
                new("name", "Мария"),
                new("score", 95.5),
                new("tags", new[] { "gold", "vip" })
            };

            foreach (var kvp in records)
            {
                Console.WriteLine($"Запись {kvp.Key}:");
                foreach (var pair in kvp.Value)
                    Console.WriteLine($"  {pair.Key}: {pair.Value}");
            }
        }
    }
}
//92
using System;
using System.Collections.Generic;

namespace ComplexDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            var records = new Dictionary<int, List<KeyValuePair<string, object>>>
            {
                [1] = new List<KeyValuePair<string, object>>
                {
                    new("name", "Иван"),
                    new("age", 30),
                    new("active", true)
                }
            };

            records[2] = new List<KeyValuePair<string, object>>
            {
                new("name", "Мария"),
                new("score", 95.5),
                new("tags", new[] { "gold", "vip" })
            };

            foreach (var kvp in records)
            {
                Console.WriteLine($"Запись {kvp.Key}:");
                foreach (var pair in kvp.Value)
                    Console.WriteLine($"  {pair.Key}: {pair.Value}");
            }
        }
    }
}
//93
using System;
using System.Collections.Generic;

namespace RangeOperationsDemo
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            numbers.AddRange(new[] { 10, 11, 12 });
            numbers.InsertRange(5, new[] { 99, 98, 97 });

            Console.WriteLine("После операций:");
            numbers.ForEach(n => Console.Write(n + " "));
        }
    }
}
//94
using System;
using System.Collections.Generic;

namespace JsonLikeDemo
{
    class Program
    {
        static void Main()
        {
            var json = new Dictionary<string, object>
            {
                ["name"] = "Продукт",
                ["price"] = 1500.50m,
                ["inStock"] = true,
                ["tags"] = new List<string> { "new", "sale" },
                ["specs"] = new Dictionary<string, object>
                {
                    ["weight"] = 1.2,
                    ["dimensions"] = new[] { 10, 20, 30 }
                }
            };

            Console.WriteLine($"Название: {json["name"]}");
            Console.WriteLine($"В наличии: {json["inStock"]}");
        }
    }
}
//95
using System;
using System.Collections.Generic;

namespace SearchDemo
{
    class Program
    {
        static void Main()
        {
            var fruits = new List<string> { "apple", "banana", "cherry", "date", "apple" };

            Console.WriteLine($"Contains(\"banana\"): {fruits.Contains("banana")}");
            Console.WriteLine($"IndexOf(\"apple\"): {fruits.IndexOf("apple")}");
            Console.WriteLine($"LastIndexOf(\"apple\"): {fruits.LastIndexOf("apple")}");
        }
    }
}
//96
using System;
using System.Collections.Generic;

namespace DictionaryClearDemo
{
    public class SafeDict<TKey, TValue> where TKey : notnull
    {
        private readonly Dictionary<TKey, TValue> _dict = new();

        public void Add(TKey key, TValue value) => _dict.Add(key, value);
        public bool IsEmpty() => _dict.Count == 0;
        public void ClearAll() => _dict.Clear();
        public int Size() => _dict.Count;
    }

    class Program
    {
        static void Main()
        {
            var dict = new SafeDict<string, int>();
            dict.Add("a", 1);
            dict.Add("b", 2);

            Console.WriteLine($"Пустой: {dict.IsEmpty()}");
            dict.ClearAll();
            Console.WriteLine($"После очистки: {dict.IsEmpty()}");
        }
    }
}
//98
using System;
using System.Collections.Generic;

namespace FunctionDictionaryDemo
{
    class Program
    {
        static void Main()
        {
            var operations = new Dictionary<string, Func<int, int>>
            {
                ["square"] = x => x * x,
                ["double"] = x => x * 2,
                ["increment"] = x => x + 1,
                ["negate"] = x => -x
            };

            int value = 5;
            Console.WriteLine($"square: {operations["square"](value)}");
            Console.WriteLine($"double: {operations["double"](value)}");
        }
    }
}
//99
using System;
using System.Collections.Generic;

namespace ObserverListDemo
{
    public class Publisher
    {
        private readonly List<Action<string>> _subscribers = new();

        public void Subscribe(Action<string> callback) => _subscribers.Add(callback);
        public void Unsubscribe(Action<string> callback) => _subscribers.Remove(callback);

        public void Notify(string message)
        {
            foreach (var sub in _subscribers)
                sub(message);
        }
    }

    class Program
    {
        static void Main()
        {
            var pub = new Publisher();
            pub.Subscribe(msg => Console.WriteLine($"A: {msg}"));
            pub.Subscribe(msg => Console.WriteLine($"B: {msg}"));

            pub.Notify("Новое событие!");
        }
    }
}
//100
using System;
using System.Collections.Generic;

namespace EventLogDemo
{
    class Program
    {
        static void Main()
        {
            var log = new Dictionary<DateTime, string>();

            log[DateTime.Now.AddMinutes(-10)] = "Система запущена";
            log[DateTime.Now.AddMinutes(-5)] = "Пользователь вошел";
            log[DateTime.Now] = "Данные сохранены";

            Console.WriteLine("Лог событий:");
            foreach (var kvp in log)
                Console.WriteLine($"{kvp.Key:yyyy-MM-dd HH:mm:ss} | {kvp.Value}");
        }
    }
}

























