// 1



namespace GenericStackDemo
{
    public class Stack<T>
    {
        private readonly List<T> _items = new List<T>();
        private readonly int _capacity;

        public Stack(int capacity = 100)
        {
            _capacity = capacity;
        }

        public void Push(T item)
        {
            if (_items.Count >= _capacity)
                throw new InvalidOperationException("Stack overflow");
            _items.Add(item);
            Console.WriteLine($"Pushed: {item}");
        }

        public T Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack underflow");
            var item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            Console.WriteLine($"Popped: {item}");
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            return _items[^1];
        }

        public int Count => _items.Count;
        public bool IsEmpty => _items.Count == 0;
        public void Clear() => _items.Clear();

        public override string ToString() => $"Stack[{{ {string.Join(", ", _items)} }}]";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 1: Generic Stack<T> ===\n");

            Console.WriteLine("--- Стек целых чисел ---");
            var intStack = new Stack<int>(5);
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);
            Console.WriteLine($"Peek: {intStack.Peek()}");
            Console.WriteLine($"Count: {intStack.Count}");
            intStack.Pop();
            Console.WriteLine($"After pop: {intStack}");

            Console.WriteLine("\n--- Стек строк ---");
            var stringStack = new Stack<string>();
            stringStack.Push("First");
            stringStack.Push("Second");
            stringStack.Push("Third");
            Console.WriteLine($"Current: {stringStack}");
            while (!stringStack.IsEmpty)
                stringStack.Pop();

            Console.WriteLine("\n--- Стек объектов Person ---");
            var personStack = new Stack<Person>();
            personStack.Push(new Person { Name = "Alice", Age = 25 });
            personStack.Push(new Person { Name = "Bob", Age = 30 });
            Console.WriteLine($"Top: {personStack.Peek()}");
            personStack.Pop();
            personStack.Push(new Person { Name = "Charlie", Age = 35 });
            Console.WriteLine($"Final: {personStack}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 2



namespace GenericQueueDemo
{
    public class Queue<T>
    {
        private readonly List<T> _items = new List<T>();
        private readonly int _capacity;

        public Queue(int capacity = 100)
        {
            _capacity = capacity;
        }

        public void Enqueue(T item)
        {
            if (_items.Count >= _capacity)
                throw new InvalidOperationException("Queue overflow");
            _items.Add(item);
            Console.WriteLine($"Enqueued: {item}");
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Queue underflow");
            var item = _items[0];
            _items.RemoveAt(0);
            Console.WriteLine($"Dequeued: {item}");
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Queue is empty");
            return _items[0];
        }

        public int Count => _items.Count;
        public bool IsEmpty => _items.Count == 0;
        public void Clear() => _items.Clear();

        public override string ToString() => $"Queue[{{ {string.Join(" <- ", _items)} }}]";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 2: Generic Queue<T> ===\n");

            Console.WriteLine("--- Очередь задач ---");
            var taskQueue = new Queue<string>();
            taskQueue.Enqueue("Task 1: Clean");
            taskQueue.Enqueue("Task 2: Code");
            taskQueue.Enqueue("Task 3: Test");
            Console.WriteLine($"Front: {taskQueue.Peek()}");
            taskQueue.Dequeue();
            Console.WriteLine($"After dequeue: {taskQueue}");

            Console.WriteLine("\n--- Очередь заказов ---");
            var orderQueue = new Queue<Order>();
            orderQueue.Enqueue(new Order { Id = 101, Amount = 99.99m });
            orderQueue.Enqueue(new Order { Id = 102, Amount = 149.50m });
            orderQueue.Enqueue(new Order { Id = 103, Amount = 75.00m });
            Console.WriteLine($"Processing orders...");
            while (!orderQueue.IsEmpty)
                orderQueue.Dequeue();

            Console.WriteLine("\n--- Циклическая обработка ---");
            var messageQueue = new Queue<string>(3);
            messageQueue.Enqueue("Msg A");
            messageQueue.Enqueue("Msg B");
            messageQueue.Enqueue("Msg C");
            Console.WriteLine($"Queue: {messageQueue}");
            messageQueue.Dequeue();
            messageQueue.Enqueue("Msg D");
            Console.WriteLine($"Updated: {messageQueue}");
        }
    }

    class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public override string ToString() => $"Order #{Id}: ${Amount:F2}";
    }
}

// 3



namespace GenericSearchDemo
{
    public static class ArrayExtensions
    {
        public static int FindIndex<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }

        public static int FindIndex<T>(this T[] array, Predicate<T> match)
        {
            for (int i = 0; i < array.Length; i++)
                if (match(array[i]))
                    return i;
            return -1;
        }

        public static List<int> FindAllIndices<T>(this T[] array, T value)
        {
            var indices = new List<int>();
            for (int i = 0; i < array.Length; i++)
                if (EqualityComparer<T>.Default.Equals(array[i], value))
                    indices.Add(i);
            return indices;
        }

        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            var result = new List<T>();
            foreach (var item in array)
                if (match(item))
                    result.Add(item);
            return result.ToArray();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 3: Generic поиск в массиве ===\n");

            Console.WriteLine("--- Поиск по значению ---");
            int[] numbers = { 10, 20, 30, 20, 40 };
            int index = numbers.FindIndex(20);
            Console.WriteLine($"First 20 at index: {index}");

            var allIndices = numbers.FindAllIndices(20);
            Console.WriteLine($"All 20s at: [{string.Join(", ", allIndices)}]");

            Console.WriteLine("\n--- Поиск по предикату ---");
            string[] words = { "apple", "banana", "cherry", "date" };
            int longWordIndex = words.FindIndex(w => w.Length > 5);
            Console.WriteLine($"First word >5 chars: {words[longWordIndex]}");

            var longWords = words.FindAll(w => w.StartsWith('a') || w.StartsWith('c'));
            Console.WriteLine($"Words starting with a/c: [{string.Join(", ", longWords)}]");

            Console.WriteLine("\n--- Поиск объектов ---");
            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 25 }
            };

            int aliceIndex = people.FindIndex(p => p.Name == "Alice");
            Console.WriteLine($"Alice at index: {aliceIndex}");

            var age25 = people.FindAll(p => p.Age == 25);
            foreach (var p in age25)
                Console.WriteLine($"Age 25: {p}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 4


namespace GenericPairDemo
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair() { }
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void Swap()
        {
            (First, Second) = (Second, First);
        }

        public bool Equals(Pair<T> other)
        {
            return EqualityComparer<T>.Default.Equals(First, other.First) &&
                   EqualityComparer<T>.Default.Equals(Second, other.Second);
        }

        public override string ToString() => $"({First}, {Second})";
        public override bool Equals(object obj) => obj is Pair<T> p && Equals(p);
        public override int GetHashCode() => HashCode.Combine(First, Second);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 4: Generic Pair<T> ===\n");

            Console.WriteLine("--- Пара чисел ---");
            var intPair = new Pair<int>(10, 20);
            Console.WriteLine($"Original: {intPair}");
            intPair.Swap();
            Console.WriteLine($"After swap: {intPair}");

            Console.WriteLine("\n--- Пара строк ---");
            var stringPair = new Pair<string>("Hello", "World");
            Console.WriteLine($"Original: {stringPair}");
            stringPair.First = "Hi";
            Console.WriteLine($"Modified: {stringPair}");

            Console.WriteLine("\n--- Пара объектов ---");
            var personPair = new Pair<Person>
            {
                First = new Person { Name = "Alice", Age = 25 },
                Second = new Person { Name = "Bob", Age = 30 }
            };
            Console.WriteLine($"Pair: {personPair}");
            personPair.Swap();
            Console.WriteLine($"After swap: {personPair}");

            Console.WriteLine("\n--- Сравнение пар ---");
            var pair1 = new Pair<int>(5, 10);
            var pair2 = new Pair<int>(5, 10);
            var pair3 = new Pair<int>(10, 5);
            Console.WriteLine($"pair1 == pair2: {pair1.Equals(pair2)}");
            Console.WriteLine($"pair1 == pair3: {pair1.Equals(pair3)}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 5


namespace GenericSwapDemo
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static (T, T) SwapReturn<T>(T a, T b)
        {
            return (b, a);
        }

        class SwapHelper<T>
        {
            private T _value1;
            private T _value2;

            public SwapHelper(T value1, T value2)
            {
                _value1 = value1;
                _value2 = value2;
            }

            public void Display()
            {
                Console.WriteLine($"Value1: {_value1}, Value2: {_value2}");
            }

            public void DoSwap()
            {
                Console.WriteLine($"Before: {_value1}, {_value2}");
                (_value1, _value2) = (_value2, _value1);
                Console.WriteLine($"After: {_value1}, {_value2}");
            }
        }

        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 5: Generic метод для обмена значений ===\n");

            Console.WriteLine("--- Обмен целых чисел ---");
            int a = 10, b = 20;
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");

            Console.WriteLine("\n--- Обмен строк ---");
            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"До обмена: s1 = '{s1}', s2 = '{s2}'");
            Swap(ref s1, ref s2);
            Console.WriteLine($"После обмена: s1 = '{s1}', s2 = '{s2}'");

            Console.WriteLine("\n--- Обмен вещественных чисел ---");
            double x = 3.14, y = 2.71;
            Console.WriteLine($"До обмена: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После обмена: x = {x}, y = {y}");

            Console.WriteLine("\n--- SwapReturn (с возвращением tuple) ---");
            int n1 = 100, n2 = 200;
            (n1, n2) = SwapReturn(n1, n2);
            Console.WriteLine($"После SwapReturn: n1 = {n1}, n2 = {n2}");

            Console.WriteLine("\n--- SwapHelper класс ---");
            var helper = new SwapHelper<char>('A', 'B');
            helper.Display();
            helper.DoSwap();

            Console.WriteLine("\n--- Обмен пользовательских объектов ---");
            var person1 = new Person { Name = "Alice", Age = 25 };
            var person2 = new Person { Name = "Bob", Age = 30 };

            Console.WriteLine($"До обмена: {person1}, {person2}");
            Swap(ref person1, ref person2);
            Console.WriteLine($"После обмена: {person1}, {person2}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} ({Age})";
    }
}

// 6



namespace GenericCacheDemo
{
    public class Cache<TKey, TValue>
    {
        private readonly Dictionary<TKey, CacheEntry> _store = new Dictionary<TKey, CacheEntry>();
        private readonly TimeSpan _defaultExpiration;
        private readonly object _lock = new object();

        private class CacheEntry
        {
            public TValue Value { get; set; }
            public DateTime ExpiresAt { get; set; }
        }

        public Cache(TimeSpan? defaultExpiration = null)
        {
            _defaultExpiration = defaultExpiration ?? TimeSpan.FromMinutes(5);
        }

        public void Set(TKey key, TValue value, TimeSpan? expiration = null)
        {
            lock (_lock)
            {
                var expiresAt = DateTime.UtcNow + (expiration ?? _defaultExpiration);
                _store[key] = new CacheEntry { Value = value, ExpiresAt = expiresAt };
                Console.WriteLine($"Cached: {key} -> {value} (expires in {expiration ?? _defaultExpiration})");
            }
        }

        public bool TryGet(TKey key, out TValue value)
        {
            lock (_lock)
            {
                if (_store.TryGetValue(key, out var entry) && DateTime.UtcNow < entry.ExpiresAt)
                {
                    value = entry.Value;
                    Console.WriteLine($"Cache hit: {key} -> {value}");
                    return true;
                }

                _store.Remove(key);
                value = default;
                Console.WriteLine($"Cache miss: {key}");
                return false;
            }
        }

        public void Remove(TKey key)
        {
            lock (_lock)
            {
                if (_store.Remove(key))
                    Console.WriteLine($"Removed from cache: {key}");
            }
        }

        public void Clear()
        {
            lock (_lock)
            {
                _store.Clear();
                Console.WriteLine("Cache cleared");
            }
        }

        public int Count
        {
            get
            {
                lock (_lock)
                {
                    Cleanup();
                    return _store.Count;
                }
            }
        }

        private void Cleanup()
        {
            var now = DateTime.UtcNow;
            var expired = new List<TKey>();
            foreach (var kvp in _store)
                if (now >= kvp.Value.ExpiresAt)
                    expired.Add(kvp.Key);

            foreach (var key in expired)
                _store.Remove(key);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 6: Generic Cache<TKey, TValue> ===\n");

            var cache = new Cache<string, string>(TimeSpan.FromSeconds(3));

            Console.WriteLine("--- Кэширование строк ---");
            cache.Set("greeting", "Hello World");
            cache.Set("user", "Alice", TimeSpan.FromSeconds(10));

            if (cache.TryGet("greeting", out string greeting))
                Console.WriteLine($"Got: {greeting}");

            Console.WriteLine($"\nCache count: {cache.Count}");

            Console.WriteLine("\n--- Ожидание истечения срока ---");
            System.Threading.Thread.Sleep(4000);

            cache.TryGet("greeting", out _);
            Console.WriteLine($"Cache count after expiration: {cache.Count}");

            Console.WriteLine("\n--- Кэширование объектов ---");
            var personCache = new Cache<int, Person>();
            personCache.Set(1, new Person { Name = "Bob", Age = 30 });
            personCache.Set(2, new Person { Name = "Charlie", Age = 35 }, TimeSpan.FromSeconds(5));

            if (personCache.TryGet(1, out Person p1))
                Console.WriteLine($"Person 1: {p1}");

            Console.WriteLine("\n--- Очистка кэша ---");
            cache.Clear();
            personCache.Clear();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 7


namespace GenericLinkedListDemo
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node(T value) => Value = value;
        }

        private Node _head;
        private Node _tail;
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var node = new Node(value);
            if (_head == null)
                _head = _tail = node;
            else
            {
                node.Next = _head;
                _head = node;
            }
            Count++;
            Console.WriteLine($"Added first: {value}");
        }

        public void AddLast(T value)
        {
            var node = new Node(value);
            if (_tail == null)
                _head = _tail = node;
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
            Console.WriteLine($"Added last: {value}");
        }

        public T RemoveFirst()
        {
            if (_head == null)
                throw new InvalidOperationException("List is empty");
            var value = _head.Value;
            _head = _head.Next;
            if (_head == null)
                _tail = null;
            Count--;
            Console.WriteLine($"Removed first: {value}");
            return value;
        }

        public T RemoveLast()
        {
            if (_head == null)
                throw new InvalidOperationException("List is empty");
            if (_head == _tail)
                return RemoveFirst();

            var current = _head;
            while (current.Next != _tail)
                current = current.Next;
            var value = _tail.Value;
            current.Next = null;
            _tail = current;
            Count--;
            Console.WriteLine($"Removed last: {value}");
            return value;
        }

        public bool Contains(T value)
        {
            var current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void Print()
        {
            var current = _head;
            var sb = new System.Text.StringBuilder();
            sb.Append("List: [");
            while (current != null)
            {
                sb.Append(current.Value);
                if (current.Next != null)
                    sb.Append(" -> ");
                current = current.Next;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 7: Generic LinkedList<T> ===\n");

            var list = new LinkedList<int>();

            Console.WriteLine("--- Добавление элементов ---");
            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(5);
            list.AddLast(30);
            list.Print();

            Console.WriteLine("\n--- Удаление элементов ---");
            list.RemoveFirst();
            list.RemoveLast();
            list.Print();

            Console.WriteLine($"\nCount: {list.Count}");
            Console.WriteLine($"Contains 20: {list.Contains(20)}");
            Console.WriteLine($"Contains 99: {list.Contains(99)}");

            Console.WriteLine("\n--- Список строк ---");
            var stringList = new LinkedList<string>();
            stringList.AddFirst("First");
            stringList.AddLast("Last");
            stringList.AddFirst("Very First");
            stringList.Print();
        }
    }
}

// 8


namespace GenericSortDemo
{
    public static class SortExtensions
    {
        public static void BubbleSort<T>(this T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j].CompareTo(array[j + 1]) > 0)
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
        }

        public static void QuickSort<T>(this T[] array) where T : IComparable<T>
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            return i + 1;
        }

        public static void Print<T>(this T[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 8: Generic сортировка массива ===\n");

            Console.WriteLine("--- Bubble Sort ---");
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Before:");
            numbers.Print();
            numbers.BubbleSort();
            Console.WriteLine("After:");
            numbers.Print();

            Console.WriteLine("\n--- Quick Sort ---");
            string[] words = { "zebra", "apple", "banana", "cherry", "date" };
            Console.WriteLine("Before:");
            words.Print();
            words.QuickSort();
            Console.WriteLine("After:");
            words.Print();

            Console.WriteLine("\n--- Сортировка объектов ---");
            var people = new[]
            {
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };
            Console.WriteLine("Before:");
            foreach (var p in people) Console.WriteLine($"  {p}");

            Array.Sort(people, (x, y) => x.Age.CompareTo(y.Age));
            Console.WriteLine("After sorting by age:");
            foreach (var p in people) Console.WriteLine($"  {p}");
        }
    }

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other) => Name.CompareTo(other.Name);
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 9


using System.Linq;

namespace GenericRepositoryDemo
{
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        bool Exists(int id);
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"#{Id} {Name} ({Email})";
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"#{Id} {Name} - ${Price:F2}";
    }

    class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _data = new List<T>();
        private int _nextId = 1;

        public virtual void Add(T item)
        {
            _data.Add(item);
            dynamic d = item;
            d.Id = _nextId++;
            Console.WriteLine($"Added: {item}");
        }

        public virtual void Remove(T item)
        {
            _data.Remove(item);
            Console.WriteLine($"Removed: {item}");
        }

        public virtual T GetById(int id)
        {
            return _data.FirstOrDefault(x => ((dynamic)x).Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _data;
        }

        public virtual void Update(T item)
        {
            var index = _data.FindIndex(x => ((dynamic)x).Id == ((dynamic)item).Id);
            if (index >= 0)
            {
                _data[index] = item;
                Console.WriteLine($"Updated: {item}");
            }
        }

        public virtual bool Exists(int id)
        {
            return _data.Any(x => ((dynamic)x).Id == id);
        }
    }

    class UserRepository : Repository<User>
    {
        public List<User> FindByName(string name)
        {
            return GetAll().Where(u => u.Name.Contains(name)).ToList();
        }

        public User FindByEmail(string email)
        {
            return GetAll().FirstOrDefault(u => u.Email == email);
        }
    }

    class ProductRepository : Repository<Product>
    {
        public List<Product> FindByPrice(decimal minPrice, decimal maxPrice)
        {
            return GetAll().Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> FindExpensive(decimal threshold)
        {
            return GetAll().Where(p => p.Price > threshold).OrderByDescending(p => p.Price).ToList();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 9: Generic IRepository<T> ===\n");

            Console.WriteLine("--- UserRepository ---");
            var userRepo = new UserRepository();

            var user1 = new User { Name = "Alice", Email = "alice@example.com" };
            var user2 = new User { Name = "Bob", Email = "bob@example.com" };
            var user3 = new User { Name = "Charlie", Email = "charlie@example.com" };

            userRepo.Add(user1);
            userRepo.Add(user2);
            userRepo.Add(user3);

            Console.WriteLine("\nВсе пользователи:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");

            Console.WriteLine("\nПоиск по имени 'Alice':");
            foreach (var user in userRepo.FindByName("Alice"))
                Console.WriteLine($"  {user}");

            Console.WriteLine("\nПоиск по email 'bob@example.com':");
            var found = userRepo.FindByEmail("bob@example.com");
            Console.WriteLine($"  {found}");

            Console.WriteLine("\n--- ProductRepository ---");
            var productRepo = new ProductRepository();

            var prod1 = new Product { Name = "Ноутбук", Price = 1200.00m };
            var prod2 = new Product { Name = "Мышка", Price = 25.00m };
            var prod3 = new Product { Name = "Монитор", Price = 400.00m };
            var prod4 = new Product { Name = "Клавиатура", Price = 80.00m };

            productRepo.Add(prod1);
            productRepo.Add(prod2);
            productRepo.Add(prod3);
            productRepo.Add(prod4);

            Console.WriteLine("\nВсе продукты:");
            foreach (var prod in productRepo.GetAll())
                Console.WriteLine($"  {prod}");

            Console.WriteLine("\nПродукты стоимостью $50-$500:");
            foreach (var prod in productRepo.FindByPrice(50, 500))
                Console.WriteLine($"  {prod}");

            Console.WriteLine("\nДорогие продукты (>$100):");
            foreach (var prod in productRepo.FindExpensive(100))
                Console.WriteLine($"  {prod}");

            Console.WriteLine("\n--- Операции Update/Remove ---");
            user1.Name = "Alice Smith";
            userRepo.Update(user1);

            userRepo.Remove(user2);

            Console.WriteLine("\nПользователи после изменений:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");
        }
    }
}

// 10


namespace GenericMatrixDemo
{
    public class Matrix<T> where T : struct, IComparable<T>
    {
        private readonly T[,] _data;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Dimensions must be positive");
            Rows = rows;
            Columns = columns;
            _data = new T[rows, columns];
        }

        public T this[int row, int col]
        {
            get => _data[row, col];
            set => _data[row, col] = value;
        }

        public Matrix<T> Add(Matrix<T> other)
        {
            if (Rows != other.Rows || Columns != other.Columns)
                throw new InvalidOperationException("Matrix dimensions must match");

            var result = new Matrix<T>(Rows, Columns);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    result[i, j] = AddValues(_data[i, j], other[i, j]);
            return result;
        }

        public Matrix<T> Multiply(Matrix<T> other)
        {
            if (Columns != other.Rows)
                throw new InvalidOperationException("Invalid dimensions for multiplication");

            var result = new Matrix<T>(Rows, other.Columns);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < other.Columns; j++)
                    for (int k = 0; k < Columns; k++)
                        result[i, j] = AddValues(result[i, j], MultiplyValues(_data[i, k], other[k, j]));
            return result;
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{_data[i, j],8}");
                Console.WriteLine();
            }
        }

        private T AddValues(T a, T b)
        {
            return (dynamic)a + b;
        }

        private T MultiplyValues(T a, T b)
        {
            return (dynamic)a * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 10: Generic Matrix<T> ===\n");

            Console.WriteLine("--- Матрица целых чисел ---");
            var m1 = new Matrix<int>(2, 3);
            m1[0, 0] = 1; m1[0, 1] = 2; m1[0, 2] = 3;
            m1[1, 0] = 4; m1[1, 1] = 5; m1[1, 2] = 6;

            var m2 = new Matrix<int>(2, 3);
            m2[0, 0] = 6; m2[0, 1] = 5; m2[0, 2] = 4;
            m2[1, 0] = 3; m2[1, 1] = 2; m2[1, 2] = 1;

            Console.WriteLine("Matrix 1:");
            m1.Print();
            Console.WriteLine("Matrix 2:");
            m2.Print();

            var sum = m1.Add(m2);
            Console.WriteLine("Sum:");
            sum.Print();

            Console.WriteLine("\n--- Матрица для умножения ---");
            var a = new Matrix<int>(2, 2);
            a[0, 0] = 1; a[0, 1] = 2;
            a[1, 0] = 3; a[1, 1] = 4;

            var b = new Matrix<int>(2, 2);
            b[0, 0] = 5; b[0, 1] = 6;
            b[1, 0] = 7; b[1, 1] = 8;

            Console.WriteLine("A:");
            a.Print();
            Console.WriteLine("B:");
            b.Print();

            var product = a.Multiply(b);
            Console.WriteLine("A * B:");
            product.Print();

            Console.WriteLine("\n--- Матрица double ---");
            var d1 = new Matrix<double>(2, 2);
            d1[0, 0] = 1.5; d1[0, 1] = 2.5;
            d1[1, 0] = 3.5; d1[1, 1] = 4.5;
            d1.Print();
        }
    }
}

// 11


using System.Linq;

namespace GenericConversionDemo
{
    public static class CollectionConverter
    {
        public static List<TOut> ConvertAll<TIn, TOut>(IEnumerable<TIn> source, Func<TIn, TOut> converter)
        {
            return source.Select(converter).ToList();
        }

        public static TOut[] ConvertToArray<TIn, TOut>(IEnumerable<TIn> source, Func<TIn, TOut> converter)
        {
            return source.Select(converter).ToArray();
        }

        public static Dictionary<TKey, TOut> ConvertToDictionary<TIn, TKey, TOut>(
            IEnumerable<TIn> source,
            Func<TIn, TKey> keySelector,
            Func<TIn, TOut> valueSelector)
        {
            return source.ToDictionary(keySelector, valueSelector);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 11: Generic конвертация коллекции ===\n");

            Console.WriteLine("--- Строки в числа ---");
            var strings = new[] { "10", "20", "30", "40" };
            var numbers = CollectionConverter.ConvertAll(strings, s => int.Parse(s));
            Console.WriteLine($"Strings: [{string.Join(", ", strings)}]");
            Console.WriteLine($"Numbers: [{string.Join(", ", numbers)}]");

            Console.WriteLine("\n--- Объекты в строки ---");
            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 35 }
            };

            var names = CollectionConverter.ConvertAll(people, p => p.Name);
            Console.WriteLine($"Names: [{string.Join(", ", names)}]");

            Console.WriteLine("\n--- В словарь ---");
            var dict = CollectionConverter.ConvertToDictionary(
                people,
                p => p.Name,
                p => p.Age);

            Console.WriteLine("Dictionary:");
            foreach (var kvp in dict)
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");

            Console.WriteLine("\n--- Массив с фильтрацией ---");
            var evenNumbers = CollectionConverter.ConvertToArray(
                Enumerable.Range(1, 10),
                n => n * 2);
            Console.WriteLine($"Even numbers: [{string.Join(", ", evenNumbers)}]");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

// 12



namespace GenericHistoryDemo
{
    public class History<T>
    {
        private readonly Stack<T> _undoStack = new Stack<T>();
        private readonly Stack<T> _redoStack = new Stack<T>();
        private readonly int _maxSize;

        public History(int maxSize = 100)
        {
            _maxSize = maxSize;
        }

        public void Add(T state)
        {
            if (_undoStack.Count >= _maxSize)
                _undoStack.Pop();
            _undoStack.Push(state);
            _redoStack.Clear();
            Console.WriteLine($"State saved. Undo count: {_undoStack.Count}");
        }

        public T Undo()
        {
            if (_undoStack.Count == 0)
                throw new InvalidOperationException("No states to undo");
            var state = _undoStack.Pop();
            _redoStack.Push(state);
            Console.WriteLine($"Undone. Remaining: {_undoStack.Count}");
            return state;
        }

        public T Redo()
        {
            if (_redoStack.Count == 0)
                throw new InvalidOperationException("No states to redo");
            var state = _redoStack.Pop();
            _undoStack.Push(state);
            Console.WriteLine($"Redone. Undo count: {_undoStack.Count}");
            return state;
        }

        public bool CanUndo => _undoStack.Count > 0;
        public bool CanRedo => _redoStack.Count > 0;
        public int UndoCount => _undoStack.Count;
        public int RedoCount => _redoStack.Count;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 12: Generic History<T> ===\n");

            var editor = new History<string>(5);

            Console.WriteLine("--- Редактирование текста ---");
            editor.Add("Version 1");
            editor.Add("Version 2");
            editor.Add("Version 3");

            Console.WriteLine($"\nCan undo: {editor.CanUndo}, Can redo: {editor.CanRedo}");

            Console.WriteLine("\n--- Отмена ---");
            var v2 = editor.Undo();
            var v1 = editor.Undo();
            Console.WriteLine($"Current: {v1}");

            Console.WriteLine("\n--- Повтор ---");
            editor.Redo();
            editor.Redo();

            Console.WriteLine("\n--- История чисел ---");
            var calc = new History<int>();
            calc.Add(10);
            calc.Add(20);
            calc.Add(30);

            calc.Undo();
            calc.Undo();
            calc.Redo();
        }
    }
}

// 13


using System.Linq;

namespace GenericFilterDemo
{
    public static class FilterExtensions
    {
        public static T[] Where<T>(this T[] source, Predicate<T> predicate)
        {
            var result = new List<T>();
            foreach (var item in source)
                if (predicate(item))
                    result.Add(item);
            return result.ToArray();
        }

        public static T[] TakeWhile<T>(this T[] source, Predicate<T> predicate)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                if (!predicate(item)) break;
                result.Add(item);
            }
            return result.ToArray();
        }

        public static T[] SkipWhile<T>(this T[] source, Predicate<T> predicate)
        {
            var result = new List<T>();
            bool skipped = false;
            foreach (var item in source)
            {
                if (!skipped && !predicate(item))
                    skipped = true;
                if (skipped)
                    result.Add(item);
            }
            return result.ToArray();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 13: Generic фильтрация массива ===\n");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("--- Четные числа ---");
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine($"Evens: [{string.Join(", ", evens)}]");

            Console.WriteLine("\n--- Числа > 5 ---");
            var greaterThan5 = numbers.Where(n => n > 5);
            Console.WriteLine($"Greater than 5: [{string.Join(", ", greaterThan5)}]");

            Console.WriteLine("\n--- TakeWhile < 6 ---");
            var takeWhile = numbers.TakeWhile(n => n < 6);
            Console.WriteLine($"TakeWhile < 6: [{string.Join(", ", takeWhile)}]");

            Console.WriteLine("\n--- SkipWhile < 5 ---");
            var skipWhile = numbers.SkipWhile(n => n < 5);
            Console.WriteLine($"SkipWhile < 5: [{string.Join(", ", skipWhile)}]");

            Console.WriteLine("\n--- Фильтрация строк ---");
            string[] words = { "apple", "banana", "cherry", "date", "elderberry" };
            var longWords = words.Where(w => w.Length > 5);
            Console.WriteLine($"Words > 5 chars: [{string.Join(", ", longWords)}]");
        }
    }
}

// 14



namespace GenericGraphDemo
{
    public class Graph<T>
    {
        private readonly Dictionary<T, List<T>> _adjacencyList = new Dictionary<T, List<T>>();

        public void AddVertex(T vertex)
        {
            if (!_adjacencyList.ContainsKey(vertex))
                _adjacencyList[vertex] = new List<T>();
        }

        public void AddEdge(T from, T to, bool bidirectional = true)
        {
            AddVertex(from);
            AddVertex(to);
            _adjacencyList[from].Add(to);
            if (bidirectional)
                _adjacencyList[to].Add(from);
        }

        public List<T> GetNeighbors(T vertex)
        {
            return _adjacencyList.TryGetValue(vertex, out var neighbors) ? neighbors : new List<T>();
        }

        public void DFS(T start, Action<T> visit)
        {
            var visited = new HashSet<T>();
            DFSRecursive(start, visited, visit);
        }

        private void DFSRecursive(T vertex, HashSet<T> visited, Action<T> visit)
        {
            if (!visited.Add(vertex)) return;
            visit(vertex);
            foreach (var neighbor in GetNeighbors(vertex))
                DFSRecursive(neighbor, visited, visit);
        }

        public void BFS(T start, Action<T> visit)
        {
            var visited = new HashSet<T>();
            var queue = new Queue<T>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                visit(vertex);
                foreach (var neighbor in GetNeighbors(vertex))
                {
                    if (visited.Add(neighbor))
                        queue.Enqueue(neighbor);
                }
            }
        }

        public void Print()
        {
            foreach (var kvp in _adjacencyList)
            {
                Console.WriteLine($"{kvp.Key} -> [{string.Join(", ", kvp.Value)}]");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 14: Generic Graph<T> ===\n");

            var graph = new Graph<string>();

            Console.WriteLine("--- Создание графа ---");
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "E");

            Console.WriteLine("Graph structure:");
            graph.Print();

            Console.WriteLine("\n--- DFS обход ---");
            Console.Write("DFS from A: ");
            graph.DFS("A", v => Console.Write(v + " "));

            Console.WriteLine("\n\n--- BFS обход ---");
            Console.Write("BFS from A: ");
            graph.BFS("A", v => Console.Write(v + " "));

            Console.WriteLine("\n\n--- Граф чисел ---");
            var numGraph = new Graph<int>();
            for (int i = 1; i <= 5; i++)
                for (int j = i + 1; j <= 5; j++)
                    if (j - i <= 2)
                        numGraph.AddEdge(i, j);

            Console.Write("BFS from 1: ");
            numGraph.BFS(1, v => Console.Write(v + " "));
            Console.WriteLine();
        }
    }
}

// 15

using System.Linq;

namespace GenericMinMaxDemo
{
    public static class MinMaxExtensions
    {
        public static T Min<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("At least one value required");
            return values.Min();
        }

        public static T Max<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("At least one value required");
            return values.Max();
        }

        public static (T Min, T Max) MinMax<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("At least one value required");
            return (values.Min(), values.Max());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 15: Generic поиск min/max ===\n");

            Console.WriteLine("--- Числа ---");
            Console.WriteLine($"Min of 5,2,8,1: {MinMaxExtensions.Min(5, 2, 8, 1)}");
            Console.WriteLine($"Max of 5,2,8,1: {MinMaxExtensions.Max(5, 2, 8, 1)}");
            var (min, max) = MinMaxExtensions.MinMax(5, 2, 8, 1);
            Console.WriteLine($"MinMax: ({min}, {max})");

            Console.WriteLine("\n--- Строки ---");
            Console.WriteLine($"Min of cat,dog,apple: {MinMaxExtensions.Min("cat", "dog", "apple")}");
            Console.WriteLine($"Max of cat,dog,apple: {MinMaxExtensions.Max("cat", "dog", "apple")}");

            Console.WriteLine("\n--- Даты ---");
            var dates = new[] { new DateTime(2020, 1, 1), new DateTime(2022, 6, 15), new DateTime(2021, 3, 10) };
            Console.WriteLine($"Earliest: {MinMaxExtensions.Min(dates)}");
            Console.WriteLine($"Latest: {MinMaxExtensions.Max(dates))}");
        }
    }
}

// 16


namespace GenericContainerDemo
{
    public class Container<T> where T : class, new()
    {
        private T _value;

        public Container()
        {
            _value = new T();
        }

        public Container(T value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public T Value
        {
            get => _value;
            set => _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void Swap(Container<T> other)
        {
            var temp = _value;
            _value = other._value;
            other._value = temp;
        }

        public override string ToString() => _value.ToString();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 16: Generic Container с ограничениями ===\n");

            var c1 = new Container<Person>(new Person { Name = "Alice" });
            var c2 = new Container<Person>(new Person { Name = "Bob" });

            Console.WriteLine($"C1: {c1}");
            Console.WriteLine($"C2: {c2}");

            c1.Swap(c2);
            Console.WriteLine($"After swap - C1: {c1}, C2: {c2}");

            var c3 = new Container<string>("Hello");
            Console.WriteLine($"String container: {c3}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public override string ToString() => $"Person: {Name}";
    }
}

// 17


namespace GenericTreeDemo
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

        public TreeNode(T value)
        {
            Value = value;
        }

        public void AddChild(T childValue)
        {
            Children.Add(new TreeNode<T>(childValue));
        }

        public void TraversePreOrder(Action<T> visit)
        {
            visit(Value);
            foreach (var child in Children)
                child.TraversePreOrder(visit);
        }

        public void TraversePostOrder(Action<T> visit)
        {
            foreach (var child in Children)
                child.TraversePostOrder(visit);
            visit(Value);
        }

        public void Print(string indent = "")
        {
            Console.WriteLine($"{indent}{Value}");
            foreach (var child in Children)
                child.Print(indent + "  ");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 17: Generic обход дерева ===\n");

            var root = new TreeNode<string>("Root");
            var child1 = new TreeNode<string>("Child1");
            var child2 = new TreeNode<string>("Child2");
            var grand1 = new TreeNode<string>("Grand1");
            var grand2 = new TreeNode<string>("Grand2");

            root.AddChild(child1.Value);
            root.AddChild(child2.Value);
            child1.AddChild(grand1.Value);
            child1.AddChild(grand2.Value);

            Console.WriteLine("Tree structure:");
            root.Print();

            Console.WriteLine("\nPre-order traversal:");
            root.TraversePreOrder(v => Console.Write(v + " "));

            Console.WriteLine("\n\nPost-order traversal:");
            root.TraversePostOrder(v => Console.Write(v + " "));
            Console.WriteLine();
        }
    }
}

// 18



namespace GenericComparerDemo
{
    public interface IComparer<T>
    {
        int Compare(T x, T y);
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (x?.Length ?? 0).CompareTo(y?.Length ?? 0);
        }
    }

    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return (x?.Age ?? 0).CompareTo(y?.Age ?? 0);
        }
    }

    public static class SortHelper
    {
        public static void Sort<T>(T[] array, IComparer<T> comparer)
        {
            Array.Sort(array, comparer);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 18: Generic IComparer ===\n");

            Console.WriteLine("--- Сортировка строк по длине ---");
            string[] words = { "apple", "hi", "banana", "a" };
            Console.WriteLine($"Before: [{string.Join(", ", words)}]");
            SortHelper.Sort(words, new StringLengthComparer());
            Console.WriteLine($"After: [{string.Join(", ", words)}]");

            Console.WriteLine("\n--- Сортировка людей по возрасту ---");
            var people = new[]
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };
            Console.WriteLine("Before:");
            foreach (var p in people) Console.WriteLine($"  {p}");
            SortHelper.Sort(people, new PersonAgeComparer());
            Console.WriteLine("After:");
            foreach (var p in people) Console.WriteLine($"  {p}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}

// 19



namespace GenericEventDispatcherDemo
{
    public class EventDispatcher<T>
    {
        private readonly Dictionary<string, List<Action<T>>> _handlers = new Dictionary<string, List<Action<T>>>();

        public void Subscribe(string eventName, Action<T> handler)
        {
            if (!_handlers.ContainsKey(eventName))
                _handlers[eventName] = new List<Action<T>>();
            _handlers[eventName].Add(handler);
            Console.WriteLine($"Subscribed to {eventName}");
        }

        public void Unsubscribe(string eventName, Action<T> handler)
        {
            if (_handlers.ContainsKey(eventName))
                _handlers[eventName].Remove(handler);
        }

        public void Dispatch(string eventName, T data)
        {
            if (_handlers.ContainsKey(eventName))
            {
                Console.WriteLine($"Dispatching {eventName}");
                foreach (var handler in _handlers[eventName])
                    handler(data);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 19: Generic EventDispatcher ===\n");

            var dispatcher = new EventDispatcher<string>();

            dispatcher.Subscribe("message", msg => Console.WriteLine($"Handler 1: {msg}"));
            dispatcher.Subscribe("message", msg => Console.WriteLine($"Handler 2: {msg.ToUpper()}"));

            dispatcher.Dispatch("message", "Hello World");

            Console.WriteLine("\n--- События с числами ---");
            var numDispatcher = new EventDispatcher<int>();
            numDispatcher.Subscribe("number", n => Console.WriteLine($"Square: {n * n}"));
            numDispatcher.Dispatch("number", 5);
        }
    }
}

// 20


namespace GenericCloneDemo
{
    public interface ICloneable<T>
    {
        T Clone();
    }

    public class Person : ICloneable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Home { get; set; }

        public Person Clone()
        {
            return new Person
            {
                Name = Name,
                Age = Age,
                Home = Home?.Clone()
            };
        }

        public override string ToString() => $"{Name} ({Age}), {Home}";
    }

    public class Address : ICloneable<Address>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address Clone()
        {
            return new Address { City = City, Street = Street };
        }

        public override string ToString() => $"{Street}, {City}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 20: Generic Clone ===\n");

            var original = new Person
            {
                Name = "Alice",
                Age = 30,
                Home = new Address { City = "NY", Street = "5th Ave" }
            };

            var clone = original.Clone();

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Clone: {clone}");

            clone.Name = "Bob";
            clone.Home.City = "LA";

            Console.WriteLine($"\nAfter modification:");
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Clone: {clone}");
        }
    }
}

// 21


namespace GenericConverterDemo
{
    public class Converter<TIn, TOut>
    {
        private readonly Func<TIn, TOut> _convertFunc;

        public Converter(Func<TIn, TOut> convertFunc)
        {
            _convertFunc = convertFunc ?? throw new ArgumentNullException(nameof(convertFunc));
        }

        public TOut Convert(TIn input)
        {
            return _convertFunc(input);
        }

        public TOut[] ConvertArray(TIn[] inputs)
        {
            var result = new TOut[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
                result[i] = _convertFunc(inputs[i]);
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 21: Generic Converter<TIn, TOut> ===\n");

            var intToString = new Converter<int, string>(n => n.ToString("D3"));
            Console.WriteLine($"5 -> {intToString.Convert(5)}");

            var stringToInt = new Converter<string, int>(s => int.Parse(s));
            var numbers = stringToInt.ConvertArray(new[] { "10", "20", "30" });
            Console.WriteLine($"Converted: [{string.Join(", ", numbers)}]");

            var personToString = new Converter<Person, string>(p => $"{p.Name} is {p.Age}");
            Console.WriteLine(personToString.Convert(new Person { Name = "Alice", Age = 25 }));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

// 22


namespace GenericValidatorDemo
{
    public static class Validator
    {
        public static bool Validate<T>(T value, Func<T, bool> rule, string errorMessage)
        {
            if (!rule(value))
            {
                Console.WriteLine($"Validation failed: {errorMessage}");
                return false;
            }
            return true;
        }

        public static bool IsNotNull<T>(T value) where T : class
        {
            return value != null;
        }

        public static bool IsPositive<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T)) > 0;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 22: Generic валидация ===\n");

            string name = "Alice";
            Validator.Validate(name, Validator.IsNotNull, "Name cannot be null");
            Validator.Validate(name, n => n.Length > 0, "Name cannot be empty");

            int number = 42;
            Validator.Validate(number, Validator.IsPositive<int>, "Number must be positive");

            string nullString = null;
            Validator.Validate(nullString, Validator.IsNotNull, "String is null");
        }
    }
}

// 23


namespace GenericHandlerDemo
{
    public class Handler<TRequest, TResponse>
    {
        private readonly Func<TRequest, TResponse> _handleFunc;

        public Handler(Func<TRequest, TResponse> handleFunc)
        {
            _handleFunc = handleFunc;
        }

        public TResponse Handle(TRequest request)
        {
            return _handleFunc(request);
        }
    }

    public class Request
    {
        public string Command { get; set; }
    }

    public class Response
    {
        public string Result { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 23: Generic Handler<TRequest, TResponse> ===\n");

            var handler = new Handler<Request, Response>(req =>
                new Response { Result = $"Processed: {req.Command}" });

            var response = handler.Handle(new Request { Command = "Save" });
            Console.WriteLine(response.Result);

            var mathHandler = new Handler<int, int>(n => n * n);
            Console.WriteLine($"Square of 7: {mathHandler.Handle(7)}");
        }
    }
}

// 24


using System.Linq;

namespace GenericGroupingDemo
{
    public static class GroupExtensions
    {
        public static Dictionary<Type, List<T>> GroupByType<T>(this IEnumerable<T> source)
        {
            return source.GroupBy(x => x.GetType())
                        .ToDictionary(g => g.Key, g => g.ToList());
        }

        public static Dictionary<TKey, List<T>> GroupBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            return source.GroupBy(keySelector)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 24: Generic группировка ===\n");

            var items = new object[]
            {
                1, "hello", 3.14, "world", 42, true
            };

            var byType = items.GroupByType();
            foreach (var group in byType)
            {
                Console.WriteLine($"{group.Key}: [{string.Join(", ", group.Value)}]");
            }

            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 25 }
            };

            var byAge = people.GroupBy(p => p.Age);
            foreach (var group in byAge)
            {
                Console.WriteLine($"Age {group.Key}: {string.Join(", ", group.Value.Select(p => p.Name))}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

// 25



namespace GenericPipelineDemo
{
    public class Pipeline<T>
    {
        private readonly List<Func<T, T>> _steps = new List<Func<T, T>>();

        public Pipeline<T> AddStep(Func<T, T> step)
        {
            _steps.Add(step);
            return this;
        }

        public T Execute(T input)
        {
            var result = input;
            foreach (var step in _steps)
            {
                result = step(result);
                Console.WriteLine($"After step: {result}");
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 25: Generic Pipeline ===\n");

            var pipeline = new Pipeline<string>()
                .AddStep(s => s.Trim())
                .AddStep(s => s.ToUpper())
                .AddStep(s => "PREFIX_" + s)
                .AddStep(s => s + "_SUFFIX");

            var result = pipeline.Execute("  hello world  ");
            Console.WriteLine($"Final result: {result}");

            var numberPipeline = new Pipeline<int>()
                .AddStep(n => n + 10)
                .AddStep(n => n * 2)
                .AddStep(n => n - 5);

            Console.WriteLine($"\nNumber pipeline: {numberPipeline.Execute(5)}");
        }
    }
}

// 26



namespace CovariantProducerDemo
{
    interface IProducer<out T>
    {
        T Produce();
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { public void Bark() => Console.WriteLine("Woof"); }
    class Puppy : Dog { }

    class AnimalProducer : IProducer<Animal>
    {
        public Animal Produce() => new Animal { Name = "Generic" };
    }

    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog { Name = "Rex" };
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 26: Ковариантный IProducer<out T> ===\n");

            IProducer<Dog> dogProducer = new DogProducer();
            IProducer<Animal> animalProducer = dogProducer;

            Animal animal = animalProducer.Produce();
            Console.WriteLine($"Produced: {animal.Name}");
        }
    }
}

// 27


namespace ContravariantConsumerDemo
{
    interface IConsumer<in T>
    {
        void Consume(T item);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"Consuming animal: {animal.Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 27: Контрвариантный IConsumer<in T> ===\n");

            IConsumer<Animal> animalConsumer = new AnimalConsumer();
            IConsumer<Dog> dogConsumer = animalConsumer;

            dogConsumer.Consume(new Dog { Name = "Buddy" });
        }
    }
}

// 28



namespace CovariantIEnumerableDemo
{
    class Animal { }
    class Dog : Animal { }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 28: Ковариантность IEnumerable<out T> ===\n");

            List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
            IEnumerable<Animal> animals = dogs;

            Console.WriteLine($"Count: {animals.Count()}");
        }
    }
}

// 29


namespace ContravariantActionDemo
{
    class Animal { }
    class Dog : Animal { }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 29: Контрвариантный Action<in T> ===\n");

            Action<Animal> animalAction = a => Console.WriteLine("Animal action");
            Action<Dog> dogAction = animalAction;

            dogAction(new Dog());
        }
    }
}

// 30


namespace CovariantFuncDemo
{
    class Animal { public override string ToString() => "Animal"; }
    class Dog : Animal { public override string ToString() => "Dog"; }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 30: Ковариантный Func<out T> ===\n");

            Func<Dog> dogFunc = () => new Dog();
            Func<Animal> animalFunc = dogFunc;

            Console.WriteLine(animalFunc());
        }
    }
}

// 31



namespace VarianceHierarchyDemo
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Звук животного");
        }

        public override string ToString() => $"{GetType().Name}: {Name}";
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав! Гав!");
        }
    }

    class Puppy : Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine("Пищик! Пищик!");
        }
    }

    interface IProducer<out T>
    {
        T Produce();
    }

    interface IConsumer<in T>
    {
        void Consume(T item);
    }

    class AnimalProducer : IProducer<Animal>
    {
        public Animal Produce() => new Animal { Name = "Generic Animal" };
    }

    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog { Name = "Buddy" };
    }

    class PuppyProducer : IProducer<Puppy>
    {
        public Puppy Produce() => new Puppy { Name = "Max" };
    }

    class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"Consuming: {animal}");
            animal.MakeSound();
        }
    }

    class DogConsumer : IConsumer<Dog>
    {
        public void Consume(Dog dog)
        {
            Console.WriteLine($"Consuming Dog: {dog}");
            dog.MakeSound();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 31: Ковариантность и контрвариантность ===\n");

            Console.WriteLine("--- Иерархия классов ---");
            Animal generic = new Animal { Name = "Animal" };
            Dog dog = new Dog { Name = "Rex" };
            Puppy puppy = new Puppy { Name = "Buddy" };

            generic.MakeSound();
            dog.MakeSound();
            puppy.MakeSound();

            Console.WriteLine("\n--- Ковариантность (IProducer<out T>) ---");

            IProducer<Animal> animalProducer = new AnimalProducer();
            IProducer<Dog> dogProducer = new DogProducer();
            IProducer<Puppy> puppyProducer = new PuppyProducer();

            IProducer<Animal> producerAsAnimal1 = dogProducer;
            IProducer<Animal> producerAsAnimal2 = puppyProducer;

            Console.WriteLine("Производители:");
            Console.WriteLine($"  AnimalProducer: {animalProducer.Produce()}");
            Console.WriteLine($"  DogProducer как Animal: {producerAsAnimal1.Produce()}");
            Console.WriteLine($"  PuppyProducer как Animal: {producerAsAnimal2.Produce()}");

            Console.WriteLine("\n--- Контрвариантность (IConsumer<in T>) ---");

            IConsumer<Animal> animalConsumer = new AnimalConsumer();
            IConsumer<Dog> dogConsumer = new DogConsumer();

            IConsumer<Dog> consumerForDog = animalConsumer;
            IConsumer<Puppy> consumerForPuppy = animalConsumer;

            Console.WriteLine("\nПотребители:");
            consumerForDog.Consume(new Dog { Name = "Собака" });
            consumerForPuppy.Consume(new Puppy { Name = "Щенок" });

            Console.WriteLine("\n--- Практический пример с коллекциями ---");
            var dogs = new List<Dog> { new Dog { Name = "Rex" }, new Dog { Name = "Max" } };
            var puppies = new List<Puppy> { new Puppy { Name = "Buddy" } };

            IEnumerable<Animal> animalsFromDogs = dogs;
            IEnumerable<Animal> animalsFromPuppies = puppies;

            Console.WriteLine("\nВсе животные:");
            foreach (var animal in animalsFromDogs)
                Console.WriteLine($"  {animal}");
            foreach (var animal in animalsFromPuppies)
                Console.WriteLine($"  {animal}");
        }
    }
}
// 33



namespace CovarianceInterfaceDemo
{
    interface IReadOnlyRepository<out T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    interface IValidator<in T> where T : class
    {
        bool Validate(T item);
        void LogValidation(T item, bool isValid);
    }

    abstract class Shape
    {
        public string Name { get; set; }
        public abstract double GetArea();
        public override string ToString() => $"{GetType().Name}: {Name}";
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea() => Side * Side;
    }

    class ShapeRepository : IReadOnlyRepository<Shape>
    {
        private List<Shape> _shapes = new List<Shape>
        {
            new Circle { Name = "Circle1", Radius = 5 },
            new Square { Name = "Square1", Side = 4 }
        };

        public Shape GetById(int id) => id < _shapes.Count ? _shapes[id] : null;
        public IEnumerable<Shape> GetAll() => _shapes;
    }

    class CircleRepository : IReadOnlyRepository<Circle>
    {
        private List<Circle> _circles = new List<Circle>
        {
            new Circle { Name = "Circle1", Radius = 3 },
            new Circle { Name = "Circle2", Radius = 5 },
            new Circle { Name = "Circle3", Radius = 7 }
        };

        public Circle GetById(int id) => id < _circles.Count ? _circles[id] : null;
        public IEnumerable<Circle> GetAll() => _circles;
    }

    class ShapeValidator : IValidator<Shape>
    {
        public bool Validate(Shape item)
        {
            if (item == null) return false;
            double area = item.GetArea();
            return area > 0;
        }

        public void LogValidation(Shape item, bool isValid)
        {
            Console.WriteLine($"  [{(isValid ? "OK" : "FAIL")}] {item} - Area: {item.GetArea():F2}");
        }
    }

    class Program
    {
        static void DisplayShapes(IReadOnlyRepository<Shape> repo)
        {
            Console.WriteLine("Фигуры в репозитории:");
            foreach (var shape in repo.GetAll())
                Console.WriteLine($"  {shape} - Area: {shape.GetArea():F2}");
        }

        static void ValidateShapes(IEnumerable<Shape> shapes, IValidator<Shape> validator)
        {
            Console.WriteLine("Валидация фигур:");
            foreach (var shape in shapes)
            {
                bool isValid = validator.Validate(shape);
                validator.LogValidation(shape, isValid);
            }
        }

        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 33: Generic интерфейс с ковариантностью ===\n");

            Console.WriteLine("--- 1. ShapeRepository ---");
            IReadOnlyRepository<Shape> shapeRepo = new ShapeRepository();
            DisplayShapes(shapeRepo);

            Console.WriteLine("\n--- 2. CircleRepository как Shape (ковариантность) ---");
            IReadOnlyRepository<Circle> circleRepo = new CircleRepository();
            IReadOnlyRepository<Shape> circleAsShapeRepo = circleRepo;
            DisplayShapes(circleAsShapeRepo);

            Console.WriteLine("\n--- 3. Валидация фигур ---");
            var validator = new ShapeValidator();

            List<Shape> allShapes = new List<Shape>
            {
                new Circle { Name = "BigCircle", Radius = 10 },
                new Square { Name = "BigSquare", Side = 8 },
                new Circle { Name = "SmallCircle", Radius = 2 }
            };

            ValidateShapes(allShapes, validator);

            Console.WriteLine("\n--- 4. Использование ковариантности ---");
            IReadOnlyRepository<Shape> repo1 = shapeRepo;
            IReadOnlyRepository<Shape> repo2 = circleRepo;

            Console.WriteLine("Репо 1 (Shape):");
            foreach (var shape in repo1.GetAll())
                Console.WriteLine($"  {shape}");

            Console.WriteLine("\nРепо 2 (Circle как Shape):");
            foreach (var shape in repo2.GetAll())
                Console.WriteLine($"  {shape}");

            Console.WriteLine("\n--- 5. Проверка типов ---");
            Console.WriteLine($"circleRepo is IReadOnlyRepository<Shape>: {circleRepo is IReadOnlyRepository<Shape>}");
            Console.WriteLine($"validator is IValidator<Shape>: {validator is IValidator<Shape>}");
        }
    }
}

// 34



namespace ContravariantComparerDemo
{
    interface IComparer<in T>
    {
        int Compare(T x, T y);
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }

    class Dog : Animal { public string Breed { get; set; } }
    class Cat : Animal
    {
        public bool IsIndoor { get; set; }

        class AgeComparer : IComparer<Animal>
        {
            public int Compare(Animal x, Animal y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;
                return x.Age.CompareTo(y.Age);
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 34: Контрвариантный компаратор ===\n");

                IComparer<Animal> animalComparer = new AgeComparer();
                IComparer<Dog> dogComparer = animalComparer;
                IComparer<Cat> catComparer = animalComparer;

                var dogs = new List<Dog>
            {
                new Dog { Name = "Rex", Age = 5, Breed = "Labrador" },
                new Dog { Name = "Max", Age = 3, Breed = "Poodle" },
                new Dog { Name = "Buddy", Age = 7, Breed = "Golden" }
            };

                dogs.Sort(dogComparer);
                Console.WriteLine("Собаки по возрасту:");
                foreach (var dog in dogs)
                    Console.WriteLine($"  {dog}");

                var animals = new List<Animal>
            {
                new Cat { Name = "Whiskers", Age = 4 },
                new Dog { Name = "Fido", Age = 6 },
                new Animal { Name = "Generic", Age = 2 }
            };

                animals.Sort(animalComparer);
                Console.WriteLine("\nВсе животные по возрасту:");
                foreach (var animal in animals)
                    Console.WriteLine($"  {animal}");
            }
        }
    }

// 35


using System.Linq;

namespace CovarianceCollectionsDemo
    {
        class Animal { public string Name { get; set; } }
        class Dog : Animal { public void Bark() => Console.WriteLine("Woof!"); }
        class Cat : Animal { public void Meow() => Console.WriteLine("Meow!"); }

        class Program
        {
            static void ProcessAnimals(IEnumerable<Animal> animals)
            {
                Console.WriteLine($"Обработка {animals.Count()} животных:");
                foreach (var animal in animals)
                    Console.WriteLine($"  {animal.Name} - {animal.GetType().Name}");
            }

            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 35: Ковариантность в коллекциях ===\n");

                List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Rex" },
                new Dog { Name = "Max" }
            };

                List<Cat> cats = new List<Cat>
            {
                new Cat { Name = "Whiskers" },
                new Cat { Name = "Luna" }
            };

                IEnumerable<Animal> animalsFromDogs = dogs;
                IEnumerable<Animal> animalsFromCats = cats;

                ProcessAnimals(animalsFromDogs);
                ProcessAnimals(animalsFromCats);

                var allAnimals = dogs.Concat<Animal>(cats).ToList();
                Console.WriteLine($"\nВсего животных: {allAnimals.Count}");
                ProcessAnimals(allAnimals);
            }
        }
    }

// 36



namespace VarianceGenericClassDemo
    {
        class ProducerConsumer<out TProduce, in TConsume>
        {
            private readonly Func<TProduce> _producer;
            private readonly Action<TConsume> _consumer;

            public ProducerConsumer(Func<TProduce> producer, Action<TConsume> consumer)
            {
                _producer = producer;
                _consumer = consumer;
            }

            public TProduce Produce() => _producer();
            public void Consume(TConsume item) => _consumer(item);
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }
        class Cat : Animal { }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 36: Generic класс с вариантностью ===\n");

                var pc = new ProducerConsumer<Animal, Dog>(
                    () => new Animal { Name = "Generic" },
                    dog => Console.WriteLine($"Consuming dog: {dog.Name}")
                );

                ProducerConsumer<Dog, Animal> dogSpecific = pc;

                var dog = dogSpecific.Produce() as Dog;
                if (dog != null) dog.Name = "Buddy";

                pc.Consume(new Dog { Name = "Rex" });
            }
        }
    }

// 37


namespace CovariantFactoryDemo
    {
        interface IFactory<out T>
        {
            T Create();
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { public Dog() { Name = "Dog"; } }
        class Puppy : Dog { public Puppy() { Name = "Puppy"; } }

        class DogFactory : IFactory<Dog>
        {
            public Dog Create() => new Dog();
        }

        class PuppyFactory : IFactory<Puppy>
        {
            public Puppy Create() => new Puppy();
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 37: Ковариантный Factory ===\n");

                IFactory<Dog> dogFactory = new DogFactory();
                IFactory<Puppy> puppyFactory = new PuppyFactory();

                IFactory<Animal> animalFactory1 = dogFactory;
                IFactory<Animal> animalFactory2 = puppyFactory;

                Console.WriteLine($"Dog factory produces: {animalFactory1.Create().Name}");
                Console.WriteLine($"Puppy factory produces: {animalFactory2.Create().Name}");
            }
        }
    }

// 38


namespace ContravariantEventHandlerDemo
    {
        delegate void EventHandler<in T>(T sender, EventArgs args);

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }

        class Program
        {
            static void AnimalHandler(Animal sender, EventArgs args)
            {
                Console.WriteLine($"Animal event: {sender.Name}");
            }

            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 38: Контрвариантный EventHandler ===\n");

                EventHandler<Animal> animalHandler = AnimalHandler;
                EventHandler<Dog> dogHandler = animalHandler;

                dogHandler(new Dog { Name = "Rex" }, EventArgs.Empty);
            }
        }
    }

// 39



namespace SafeVarianceCastingDemo
    {
        interface IReader<out T>
        {
            T Read();
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { public void Bark() => Console.WriteLine("Woof!"); }

        class DogReader : IReader<Dog>
        {
            public Dog Read() => new Dog { Name = "Buddy" };
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 39: Безопасное приведение с вариантностью ===\n");

                IReader<Dog> dogReader = new DogReader();
                IReader<Animal> animalReader = dogReader;

                Animal animal = animalReader.Read();
                Console.WriteLine($"Read animal: {animal.Name}");

                if (animal is Dog dog)
                    dog.Bark();
            }
        }
    }

// 40



namespace CovariantRepositoryDemo
    {
        interface IRepository<out T>
        {
            IEnumerable<T> GetAll();
            T GetById(int id);
        }

        class Product { public int Id { get; set; } public string Name { get; set; } }
        class Book : Product { public string Author { get; set; } }

        class ProductRepository : IRepository<Product>
        {
            private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Item1" },
            new Book { Id = 2, Name = "C# Book", Author = "Author" }
        };

            public Product GetById(int id) => _products.Find(p => p.Id == id);
            public IEnumerable<Product> GetAll() => _products;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 40: Repository с ковариантностью ===\n");

                IRepository<Product> productRepo = new ProductRepository();
                IRepository<Book> bookRepo = productRepo;

                foreach (var book in bookRepo.GetAll())
                {
                    Console.WriteLine($"Book: {book.Name}");
                    if (book is Book b) Console.WriteLine($"  Author: {b.Author}");
                }
            }
        }
    }

// 41


namespace ContravariantValidatorDemo
    {
        interface IValidator<in T>
        {
            bool Validate(T obj);
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Employee : Person
        {
            public string Position { get; set; }
        }

        class PersonValidator : IValidator<Person>
        {
            public bool Validate(Person person)
            {
                return !string.IsNullOrEmpty(person?.Name) && person.Age >= 0;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 41: Контрвариантный validator ===\n");

                IValidator<Person> personValidator = new PersonValidator();
                IValidator<Employee> employeeValidator = personValidator;

                var emp = new Employee { Name = "Alice", Age = 30, Position = "Dev" };
                Console.WriteLine($"Employee valid: {employeeValidator.Validate(emp)}");
            }
        }
    }

// 42



namespace CombinedVarianceDemo
    {
        interface IProcessor<in TIn, out TOut>
        {
            TOut Process(TIn input);
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }
        class Cat : Animal { }
        class Sound { public string Noise { get; set; } }

        class AnimalToSoundProcessor : IProcessor<Animal, Sound>
        {
            public Sound Process(Animal animal)
            {
                return new Sound { Noise = animal is Dog ? "Woof" : "Meow" };
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 42: Комбинирование ковариантности и контрвариантности ===\n");

                IProcessor<Animal, Sound> baseProcessor = new AnimalToSoundProcessor();
                IProcessor<Dog, Sound> dogProcessor = baseProcessor;

                Sound sound = dogProcessor.Process(new Dog { Name = "Rex" });
                Console.WriteLine($"Dog makes: {sound.Noise}");
            }
        }
    }

// 43


namespace VarianceConstraintsDemo
    {
        interface IConverter<in TIn, out TOut> where TIn : class where TOut : new()
        {
            TOut Convert(TIn input);
        }

        class Person { public string Name { get; set; } }
        class PersonDto { public string Name { get; set; } }

        class PersonConverter : IConverter<Person, PersonDto>
        {
            public PersonDto Convert(Person input)
            {
                return new PersonDto { Name = input.Name };
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 43: Generic метод с ограничениями для вариантности ===\n");

                IConverter<Person, PersonDto> converter = new PersonConverter();
                var dto = converter.Convert(new Person { Name = "Alice" });
                Console.WriteLine($"Converted: {dto.Name}");
            }
        }
    }

// 44



namespace CovariantIteratorDemo
    {
        interface IIterator<out T>
        {
            bool HasNext();
            T Next();
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }

        class DogIterator : IIterator<Dog>
        {
            private readonly Dog[] _dogs = { new Dog { Name = "Rex" }, new Dog { Name = "Max" } };
            private int _index = 0;

            public bool HasNext() => _index < _dogs.Length;
            public Dog Next() => _dogs[_index++];
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 44: Ковариантный интерфейс для итераторов ===\n");

                IIterator<Dog> dogIterator = new DogIterator();
                IIterator<Animal> animalIterator = dogIterator;

                while (animalIterator.HasNext())
                {
                    var animal = animalIterator.Next();
                    Console.WriteLine($"Animal: {animal.Name}");
                }
            }
        }
    }

// 45


namespace ContravariantErrorHandlerDemo
    {
        interface IErrorHandler<in T>
        {
            void Handle(T error);
        }

        class Exception { public string Message { get; set; } }
        class FileNotFoundException : Exception { }

        class GeneralErrorHandler : IErrorHandler<Exception>
        {
            public void Handle(Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 45: Контрвариантный обработчик ошибок ===\n");

                IErrorHandler<Exception> generalHandler = new GeneralErrorHandler();
                IErrorHandler<FileNotFoundException> specificHandler = generalHandler;

                specificHandler.Handle(new FileNotFoundException { Message = "File not found!" });
            }
        }
    }

// 46


namespace VarianceEventHandlerDemo
    {
        public class EventArgs<T> : EventArgs
        {
            public T Data { get; set; }
        }

        public delegate void EventHandler<in T>(object sender, EventArgs<T> args);

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }

        class Program
        {
            static void AnimalHandler(object sender, EventArgs<Animal> args)
            {
                Console.WriteLine($"Animal event: {args.Data.Name}");
            }

            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 46: Вариантность в EventHandler ===\n");

                EventHandler<Animal> animalHandler = AnimalHandler;
                EventHandler<Dog> dogHandler = animalHandler;

                dogHandler(null, new EventArgs<Dog> { Data = new Dog { Name = "Buddy" } });
            }
        }
    }

// 47


namespace ExplicitVarianceDemo
    {
        interface ITransformer<in TIn, out TOut>
        {
            TOut Transform(TIn input);
        }

        class StringToIntTransformer : ITransformer<string, int>
        {
            public int Transform(string input) => int.Parse(input);
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 47: Generic класс с явной вариантностью ===\n");

                ITransformer<string, int> transformer = new StringToIntTransformer();
                ITransformer<object, object> genericTransformer = transformer;

                var result = genericTransformer.Transform("123");
                Console.WriteLine($"Transformed: {result}");
            }
        }
    }

// 48


namespace VarianceConversionDemo
    {
        interface IConverter<in TSource, out TTarget>
        {
            TTarget Convert(TSource source);
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }
        class DogInfo { public string Info { get; set; } }

        class AnimalToStringConverter : IConverter<Animal, string>
        {
            public string Convert(Animal source) => source.Name;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 48: Интерфейс преобразования с вариантностью ===\n");

                IConverter<Animal, string> converter = new AnimalToStringConverter();
                IConverter<Dog, object> dogConverter = converter;

                var result = dogConverter.Convert(new Dog { Name = "Rex" });
                Console.WriteLine($"Converted: {result}");
            }
        }
    }

// 49



namespace VarianceTypeSystemDemo
    {
        interface IReader<out T>
        {
            T Read();
        }

        interface IWriter<in T>
        {
            void Write(T value);
        }

        class Animal { public string Name { get; set; } }
        class Dog : Animal { }

        class AnimalStorage : IReader<Animal>, IWriter<Animal>
        {
            private Animal _animal;
            public Animal Read() => _animal;
            public void Write(Animal value) => _animal = value;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 49: Система типов с ковариантностью ===\n");

                AnimalStorage storage = new AnimalStorage();
                IReader<Animal> reader = storage;
                IWriter<Animal> writer = storage;

                writer.Write(new Dog { Name = "Buddy" });
                var animal = reader.Read();
                Console.WriteLine($"Read: {animal.Name}");
            }
        }
    }

// 51


namespace NullableIntDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 51: Nullable тип int? ===\n");

                int? nullableInt = null;
                int? hasValue = 42;

                Console.WriteLine($"nullableInt = {nullableInt}");
                Console.WriteLine($"nullableInt.HasValue: {nullableInt.HasValue}");

                if (hasValue.HasValue)
                    Console.WriteLine($"hasValue.Value: {hasValue.Value}");

                nullableInt = 100;
                Console.WriteLine($"\nПосле присвоения: nullableInt = {nullableInt}");
                Console.WriteLine($"nullableInt.HasValue: {nullableInt.HasValue}");
                Console.WriteLine($"nullableInt.Value: {nullableInt.Value}");
            }
        }
    }

// 52


namespace NullableMethodsDemo
    {
        static class NullableExtensions
        {
            public static bool IsNull<T>(this T? value) where T : struct => !value.HasValue;
            public static bool IsNotNull<T>(this T? value) where T : struct => value.HasValue;
            public static T GetValueOrDefault<T>(this T? value, T defaultValue) where T : struct => value ?? defaultValue;
            public static string ToStringOrEmpty<T>(this T? value) where T : struct => value?.ToString() ?? "null";
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 52: Методы для nullable ===\n");

                int? a = 10, b = null;

                Console.WriteLine($"a.IsNull(): {a.IsNull()}");
                Console.WriteLine($"a.IsNotNull(): {a.IsNotNull()}");
                Console.WriteLine($"b.GetValueOrDefault(0): {b.GetValueOrDefault(0)}");
                Console.WriteLine($"a.ToStringOrEmpty(): '{a.ToStringOrEmpty()}'");
                Console.WriteLine($"b.ToStringOrEmpty(): '{b.ToStringOrEmpty()}'");
            }
        }
    }

// 53


namespace GenericNullableDemo
    {
        static class NullableHelper
        {
            public static string Describe<T>(T? value) where T : struct
            {
                return value.HasValue ? $"Has value: {value.Value}" : "No value (null)";
            }

            public static T? ParseOrNull<T>(string input) where T : struct
            {
                try
                {
                    if (typeof(T) == typeof(int))
                        return (T)(object)int.Parse(input);
                    if (typeof(T) == typeof(double))
                        return (T)(object)double.Parse(input);
                    if (typeof(T) == typeof(bool))
                        return (T)(object)bool.Parse(input);
                }
                catch { return null; }
                return null;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 53: Generic метод для Nullable ===\n");

                int? i = 42;
                double? d = null;
                bool? b = true;

                Console.WriteLine(NullableHelper.Describe(i));
                Console.WriteLine(NullableHelper.Describe(d));
                Console.WriteLine(NullableHelper.Describe(b));

                var parsed = NullableHelper.ParseOrNull<int>("123");
                Console.WriteLine($"Parsed '123': {NullableHelper.Describe(parsed)}");
            }
        }
    }

// 54


namespace NullableSafetyDemo
    {
        class SafeCalculator
        {
            public static int? Divide(int? a, int? b)
            {
                if (!a.HasValue || !b.HasValue)
                    return null;
                if (b.Value == 0)
                    return null;
                return a.Value / b.Value;
            }

            public static void PrintResult(int? result)
            {
                if (result.HasValue)
                    Console.WriteLine($"Result: {result.Value}");
                else
                    Console.WriteLine("Result: null (division by zero or null input)");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 54: Проверка nullable перед использованием ===\n");

                var r1 = SafeCalculator.Divide(10, 2);
                SafeCalculator.PrintResult(r1);

                var r2 = SafeCalculator.Divide(10, 0);
                SafeCalculator.PrintResult(r2);

                var r3 = SafeCalculator.Divide(null, 5);
                SafeCalculator.PrintResult(r3);
            }
        }
    }

// 55


namespace NullableInStructDemo
    {
        struct Measurement
        {
            public double? Temperature { get; set; }
            public double? Humidity { get; set; }
            public DateTime Timestamp { get; set; }

            public override string ToString()
            {
                return $"Temp: {Temperature?.ToString() ?? "N/A"}, " +
                       $"Hum: {Humidity?.ToString() ?? "N/A"}, " +
                       $"Time: {Timestamp:HH:mm:ss}";
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 55: Nullable в структурах ===\n");

                var m1 = new Measurement
                {
                    Temperature = 23.5,
                    Humidity = 60.0,
                    Timestamp = DateTime.Now
                };

                var m2 = new Measurement
                {
                    Temperature = null,
                    Humidity = 55.0,
                    Timestamp = DateTime.Now.AddMinutes(-5)
                };

                Console.WriteLine(m1);
                Console.WriteLine(m2);
            }
        }
    }

// 56


namespace NullableConversionDemo
    {
        static class NullableConverter
        {
            public static int? ToNullableInt(double? value) => value.HasValue ? (int?)Math.Round(value.Value) : null;
            public static double? ToNullableDouble(int? value) => value.HasValue ? (double?)value.Value : null;
            public static bool? ToNullableBool(int? value) => value.HasValue ? (bool?)(value.Value != 0) : null;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 56: Конвертация между nullable ===\n");

                double? d = 3.7;
                int? i = NullableConverter.ToNullableInt(d);
                Console.WriteLine($"{d} -> {i}");

                i = 42;
                d = NullableConverter.ToNullableDouble(i);
                Console.WriteLine($"{i} -> {d}");

                i = null;
                var b = NullableConverter.ToNullableBool(i);
                Console.WriteLine($"null -> {b}");
            }
        }
    }

// 57


namespace OptionalValueDemo
    {
        class Optional<T> where T : class
        {
            private readonly T _value;
            public bool HasValue { get; }
            public T Value => HasValue ? _value : throw new InvalidOperationException("No value");

            private Optional(T value)
            {
                _value = value;
                HasValue = true;
            }

            private Optional() => HasValue = false;

            public static Optional<T> Of(T value) => value != null ? new Optional<T>(value) : Empty();
            public static Optional<T> Empty() => new Optional<T>();
            public static Optional<T> OfNullable(T value) => value != null ? Of(value) : Empty();

            public T OrElse(T defaultValue) => HasValue ? _value : defaultValue;
            public T OrElseGet(Func<T> supplier) => HasValue ? _value : supplier();
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 57: Класс Optional<T> ===\n");

                var opt1 = Optional<string>.Of("Hello");
                var opt2 = Optional<string>.Empty();

                Console.WriteLine($"opt1.HasValue: {opt1.HasValue}, Value: {opt1.Value}");
                Console.WriteLine($"opt2.OrElse('Default'): {opt2.OrElse("Default")}");
            }
        }
    }

// 58


namespace NullableEqualityDemo
    {
        static class NullableEquality
        {
            public static bool Equals<T>(T? x, T? y) where T : struct
            {
                if (!x.HasValue && !y.HasValue) return true;
                if (!x.HasValue || !y.HasValue) return false;
                return x.Value.Equals(y.Value);
            }

            public static int GetHashCode<T>(T? value) where T : struct
            {
                return value.HasValue ? value.Value.GetHashCode() : 0;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 58: Equals и GetHashCode для nullable ===\n");

                int? a = 10, b = 10, c = null, d = null;

                Console.WriteLine($"a == b: {NullableEquality.Equals(a, b)}");
                Console.WriteLine($"c == d: {NullableEquality.Equals(c, d)}");
                Console.WriteLine($"a == c: {NullableEquality.Equals(a, c)}");
            }
        }
    }

// 59


namespace NullablePropertiesDemo
    {
        class Person
        {
            public string Name { get; set; }
            public int? Age { get; set; }
            public double? Salary { get; set; }
            public DateTime? BirthDate { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age?.ToString() ?? "N/A"}, " +
                       $"Salary: {Salary?.ToString("C") ?? "N/A"}, " +
                       $"Birth: {BirthDate?.ToString("yyyy-MM-dd") ?? "N/A"}";
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 59: Nullable в свойствах класса ===\n");

                var p1 = new Person
                {
                    Name = "Alice",
                    Age = 30,
                    Salary = 50000.0,
                    BirthDate = new DateTime(1993, 5, 15)
                };

                var p2 = new Person
                {
                    Name = "Bob",
                    Age = null,
                    Salary = null
                };

                Console.WriteLine(p1);
                Console.WriteLine(p2);
            }
        }
    }

// 60


namespace NullableValidationDemo
    {
        class UserInput
        {
            public string Name { get; set; }
            public int? Age { get; set; }
            public decimal? Amount { get; set; }

            public bool Validate()
            {
                if (string.IsNullOrWhiteSpace(Name)) return false;
                if (!Age.HasValue || Age < 0) return false;
                if (!Amount.HasValue || Amount < 0) return false;
                return true;
            }

            public string GetErrors()
            {
                var errors = new System.Text.StringBuilder();
                if (string.IsNullOrWhiteSpace(Name)) errors.AppendLine("Name is required");
                if (!Age.HasValue || Age < 0) errors.AppendLine("Valid age required");
                if (!Amount.HasValue || Amount < 0) errors.AppendLine("Valid amount required");
                return errors.ToString();
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 60: Валидация с nullable ===\n");

                var input = new UserInput { Name = "Alice", Age = 25, Amount = 100.50m };
                Console.WriteLine($"Valid: {input.Validate()}");

                var invalid = new UserInput { Name = "", Age = -5 };
                Console.WriteLine($"Valid: {invalid.Validate()}");
                Console.WriteLine(invalid.GetErrors());
            }
        }
    }

// 61


namespace NullableDefaultDemo
    {
        static class NullableDefaults
        {
            public static T GetValueOrDefault<T>(this T? value, T defaultValue) where T : struct
                => value ?? defaultValue;

            public static T GetValueOrZero<T>(this T? value) where T : struct
                => value ?? default(T);

            public static string GetStringOrEmpty<T>(this T? value) where T : struct
                => value?.ToString() ?? string.Empty;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 61: Значение или по умолчанию ===\n");

                int? a = 42, b = null;

                Console.WriteLine($"a.GetValueOrDefault(0): {a.GetValueOrDefault(0)}");
                Console.WriteLine($"b.GetValueOrZero(): {b.GetValueOrZero()}");
                Console.WriteLine($"a.GetStringOrEmpty(): '{a.GetStringOrEmpty()}'");
            }
        }
    }

// 62


using System.Linq;

namespace NullableCollectionDemo
    {
        class NullableIntCollection
        {
            private readonly List<int?> _items = new List<int?>();

            public void Add(int? value) => _items.Add(value);
            public int? this[int index] => _items[index];
            public int Count => _items.Count;
            public IEnumerable<int> NonNullValues => _items.Where(x => x.HasValue).Select(x => x.Value);
            public int? Sum => _items.Where(x => x.HasValue).Sum(x => x);
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 62: Коллекция nullable ===\n");

                var col = new NullableIntCollection();
                col.Add(10); col.Add(null); col.Add(20); col.Add(null); col.Add(30);

                Console.WriteLine($"Count: {col.Count}");
                Console.WriteLine($"Sum of non-null: {col.Sum}");
                Console.WriteLine($"Non-null values: [{string.Join(", ", col.NonNullValues)}]");
            }
        }
    }

// 63


namespace NullToDefaultDemo
    {
        static class NullConverter
        {
            public static int ToInt(this string s, int defaultValue = 0)
                => int.TryParse(s, out int result) ? result : defaultValue;

            public static T ToDefault<T>(this object obj) where T : class, new()
                => obj as T ?? new T();
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 63: null в значение по умолчанию ===\n");

                string s1 = "123", s2 = "abc", s3 = null;

                Console.WriteLine($"'{s1}'.ToInt(): {s1.ToInt()}");
                Console.WriteLine($"'{s2}'.ToInt(): {s2.ToInt()}");
                Console.WriteLine($"'{s3}'.ToInt(): {s3.ToInt()}");
            }
        }
    }

// 64


namespace OptionalParametersDemo
    {
        class Config
        {
            public int? Timeout { get; set; }
            public string Endpoint { get; set; }
            public bool? EnableLogging { get; set; }

            public void ApplyDefaults()
            {
                Timeout ??= 30;
                Endpoint ??= "https://api.example.com";
                EnableLogging ??= false;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 64: Опциональные параметры ===\n");

                var config = new Config { Timeout = 60 };
                config.ApplyDefaults();

                Console.WriteLine($"Timeout: {config.Timeout}");
                Console.WriteLine($"Endpoint: {config.Endpoint}");
                Console.WriteLine($"Logging: {config.EnableLogging}");
            }
        }
    }

// 65


namespace NullableCopyDemo
    {
        static class NullableCloner
        {
            public static T? ToNullable<T>(this T value) where T : struct
                => value;

            public static T? CloneNullable<T>(this T? value) where T : struct
                => value;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 65: Nullable копия ===\n");

                int original = 42;
                int? nullable = original.ToNullable();
                int? copy = nullable.CloneNullable();

                Console.WriteLine($"Original: {original}, Nullable: {nullable}, Copy: {copy}");
            }
        }
    }

// 66


namespace NullableComparisonDemo
    {
        static class NullableComparer
        {
            public static int Compare<T>(T? x, T? y) where T : struct, IComparable<T>
            {
                if (!x.HasValue && !y.HasValue) return 0;
                if (!x.HasValue) return -1;
                if (!y.HasValue) return 1;
                return x.Value.CompareTo(y.Value);
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 66: Сравнение nullable ===\n");

                int? a = 10, b = 20, c = null;

                Console.WriteLine($"Compare(a,b): {NullableComparer.Compare(a, b)}");
                Console.WriteLine($"Compare(a,c): {NullableComparer.Compare(a, c)}");
                Console.WriteLine($"Compare(c,c): {NullableComparer.Compare(c, c)}");
            }
        }
    }

// 67


using System.Linq;

namespace NullableLinqDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 67: Nullable в LINQ ===\n");

                var data = new List<int?> { 1, null, 3, null, 5, 2, null, 4 };

                var nonNull = data.Where(x => x.HasValue).Select(x => x.Value);
                var sum = data.Sum(x => x ?? 0);
                var average = data.Where(x => x.HasValue).Average(x => x);

                Console.WriteLine($"Non-null: [{string.Join(", ", nonNull)}]");
                Console.WriteLine($"Sum (null=0): {sum}");
                Console.WriteLine($"Average: {average:F2}");
            }
        }
    }

// 68


namespace NullableExceptionDemo
    {
        class SafeOperations
        {
            public static int Divide(int? a, int? b)
            {
                if (!a.HasValue) throw new ArgumentNullException(nameof(a));
                if (!b.HasValue) throw new ArgumentNullException(nameof(b));
                if (b.Value == 0) throw new DivideByZeroException();
                return a.Value / b.Value;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 68: Исключения при nullable ===\n");

                try
                {
                    var result = SafeOperations.Divide(null, 5);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }

// 69


using System.Linq;

namespace FilterNullsDemo
    {
        static class CollectionFilter
        {
            public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : struct
                => source.Where(x => x.HasValue).Select(x => x.Value);

            public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> source) where T : class
                => source.Where(x => x != null);
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 69: Фильтрация null ===\n");

                var nullableInts = new int?[] { 1, null, 3, null, 5 };
                var nonNullInts = nullableInts.WhereNotNull();

                Console.WriteLine($"Non-null ints: [{string.Join(", ", nonNullInts)}]");

                var objects = new string[] { "a", null, "b", null, "c" };
                var nonNullStrings = objects.WhereNotNull();
                Console.WriteLine($"Non-null strings: [{string.Join(", ", nonNullStrings)}]");
            }
        }
    }

// 70


namespace NullableWrapperDemo
    {
        class NullableWrapper<T> where T : struct
        {
            public T? Value { get; set; }

            public NullableWrapper() { }
            public NullableWrapper(T value) => Value = value;

            public bool HasValue => Value.HasValue;
            public T GetValueOrDefault(T defaultValue) => Value ?? defaultValue;
            public override string ToString() => Value?.ToString() ?? "null";
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 70: Wrapper для nullability ===\n");

                var wrapper = new NullableWrapper<int>();
                Console.WriteLine($"Initial: {wrapper}");

                wrapper.Value = 42;
                Console.WriteLine($"After set: {wrapper}, HasValue: {wrapper.HasValue}");
            }
        }
    }

// 71


namespace GenericNullableDemo
    {
        class DataProcessor<T> where T : struct
        {
            public T? Process(T? input)
            {
                return input.HasValue ? (T?)(input.Value * 2) : null;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 71: Nullable в генериках ===\n");

                var intProc = new DataProcessor<int>();
                var result = intProc.Process(21);
                Console.WriteLine($"21 * 2 = {result}");

                var doubleProc = new DataProcessor<double>();
                var dResult = doubleProc.Process(null);
                Console.WriteLine($"null -> {dResult}");
            }
        }
    }

// 72


namespace NullableMapperDemo
    {
        static class NullableMapper
        {
            public static TTarget Map<TSource, TTarget>(TSource? source, Func<TSource, TTarget> mapper, TTarget defaultValue)
                where TSource : struct
                where TTarget : class
            {
                return source.HasValue ? mapper(source.Value) : defaultValue;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 72: Мэппинг null ===\n");

                int? input = 42;
                string result = NullableMapper.Map(input, i => i.ToString(), "N/A");
                Console.WriteLine($"42 -> {result}");

                input = null;
                result = NullableMapper.Map(input, i => i.ToString(), "N/A");
                Console.WriteLine($"null -> {result}");
            }
        }
    }

// 73



namespace MissingValueSystemDemo
    {
        enum MissingReason { NotProvided, Invalid, Unknown }

        class OptionalValue<T>
        {
            public T Value { get; }
            public bool HasValue { get; }
            public MissingReason? Reason { get; }

            private OptionalValue(T value)
            {
                Value = value;
                HasValue = true;
            }

            private OptionalValue(MissingReason reason)
            {
                Reason = reason;
                HasValue = false;
            }

            public static OptionalValue<T> Of(T value) => new OptionalValue<T>(value);
            public static OptionalValue<T> Missing(MissingReason reason) => new OptionalValue<T>(reason);
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 73: Система отсутствующих значений ===\n");

                var v1 = OptionalValue<int>.Of(42);
                var v2 = OptionalValue<int>.Missing(MissingReason.Invalid);

                Console.WriteLine($"v1: HasValue={v1.HasValue}, Value={v1.Value}");
                Console.WriteLine($"v2: HasValue={v2.HasValue}, Reason={v2.Reason}");
            }
        }
    }

// 74


namespace NullableLoggingDemo
    {
        static class NullableLogger
        {
            public static void Log<T>(string name, T? value) where T : struct
            {
                string status = value.HasValue ? $"Value={value.Value}" : "NULL";
                Console.WriteLine($"[LOG] {name}: {status}");
            }

            public static void Log<T>(string name, T value) where T : class
            {
                string status = value != null ? $"Value={value}" : "NULL";
                Console.WriteLine($"[LOG] {name}: {status}");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 74: Логирование nullable ===\n");

                int? age = 30;
                string name = null;

                NullableLogger.Log("age", age);
                NullableLogger.Log("name", name);
            }
        }
    }

// 75



namespace NullableCacheDemo
    {
        class NullableCache<TKey, TValue> where TValue : struct
        {
            private readonly Dictionary<TKey, TValue?> _cache = new Dictionary<TKey, TValue?>();
            private readonly Func<TKey, TValue?> _loader;

            public NullableCache(Func<TKey, TValue?> loader)
            {
                _loader = loader;
            }

            public TValue? Get(TKey key)
            {
                if (!_cache.ContainsKey(key))
                    _cache[key] = _loader(key);
                return _cache[key];
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 75: Кеширование nullable ===\n");

                var cache = new NullableCache<string, int>(key =>
                {
                    Console.WriteLine($"Loading {key}...");
                    return key == "valid" ? (int?)42 : null;
                });

                var v1 = cache.Get("valid");
                var v2 = cache.Get("invalid");
                var v3 = cache.Get("valid");

                Console.WriteLine($"v1: {v1}, v2: {v2}");
            }
        }
    }
// 76


namespace NullCoalescingStringDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 76: Оператор ?? для строк ===\n");

                string userInput = null;
                string defaultName = "Guest";

                string name = userInput ?? defaultName;
                Console.WriteLine($"Name: {name}");

                userInput = "Alice";
                name = userInput ?? defaultName;
                Console.WriteLine($"Name: {name}");
            }
        }
    }

// 77


namespace NullCoalescingHandlingDemo
    {
        class Config
        {
            public string ApiUrl { get; set; }
            public int? Timeout { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 77: ?? для обработки null ===\n");

                Config config = null;
                string url = config?.ApiUrl ?? "https://default-api.com";
                int timeout = config?.Timeout ?? 30;

                Console.WriteLine($"URL: {url}");
                Console.WriteLine($"Timeout: {timeout} sec");

                config = new Config { ApiUrl = "https://myapi.com", Timeout = 60 };
                url = config.ApiUrl ?? "https://default-api.com";
                timeout = config.Timeout ?? 30;

                Console.WriteLine($"\nWith config: URL={url}, Timeout={timeout}");
            }
        }
    }

// 78


namespace NullCoalescingChainDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 78: Цепочка ?? ===\n");

                string a = null;
                string b = null;
                string c = "Hello";
                string d = "World";

                string result = a ?? b ?? c ?? d ?? "Default";
                Console.WriteLine($"Result: {result}");

                a = "First";
                result = a ?? b ?? c ?? d ?? "Default";
                Console.WriteLine($"Result: {result}");
            }
        }
    }

// 79

using System.Linq;

namespace FirstNonNullDemo
    {
        static class NullHelper
        {
            public static T FirstNonNull<T>(params T[] values) where T : class
            {
                return values.FirstOrDefault(v => v != null);
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 79: Первый не-null ===\n");

                string result = NullHelper.FirstNonNull(null, null, "Hi", "World");
                Console.WriteLine($"First: {result}");

                result = NullHelper.FirstNonNull("Alpha", null, "Beta");
                Console.WriteLine($"First: {result}");
            }
        }
    }

// 80


namespace NullCoalescingAssignmentDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 80: Оператор ??= ===\n");

                string name = null;
                Console.WriteLine($"Before: {name ?? "null"}");

                name ??= "DefaultUser";
                Console.WriteLine($"After first: {name}");

                name ??= "Override";
                Console.WriteLine($"After second: {name}");
            }
        }
    }

// 81


namespace NullCoalescingConditionalDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 81: ?? в условных выражениях ===\n");

                string input = null;
                bool isValid = (input ?? "").Length > 0;

                Console.WriteLine($"Input valid: {isValid}");

                input = "test";
                isValid = (input ?? "").Length > 0;
                Console.WriteLine($"Input valid: {isValid}");
            }
        }
    }

// 82


namespace SetIfNullDemo
    {
        static class ObjectExtensions
        {
            public static void SetIfNull<T>(ref T field, T value) where T : class
            {
                field ??= value;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 82: Установка если null ===\n");

                string cache = null;
                ObjectExtensions.SetIfNull(ref cache, "CachedValue");
                Console.WriteLine($"Cache: {cache}");

                ObjectExtensions.SetIfNull(ref cache, "NewValue");
                Console.WriteLine($"Cache: {cache}");
            }
        }
    }

// 83



namespace NullCoalescingCollectionsDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 83: ?? с коллекциями ===\n");

                List<string> items = null;
                var list = items ?? new List<string>();

                list.Add("Item1");
                Console.WriteLine($"Count: {list.Count}");

                items = new List<string> { "A", "B" };
                list = items ?? new List<string>();
                Console.WriteLine($"Items: [{string.Join(", ", list)}]");
            }
        }
    }

// 84


using System.Linq;

namespace NullCoalescingLinqDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 84: ?? в LINQ ===\n");

                var data = new List<string> { "apple", null, "banana", null, "cherry" };

                var result = data
                    .Where(x => (x ?? "").Length > 0)
                    .Select(x => x ?? "empty")
                    .ToList();

                Console.WriteLine($"Filtered: [{string.Join(", ", result)}]");
            }
        }
    }

// 85


namespace NullSafeNavigationDemo
    {
        class Person
        {
            public Address Home { get; set; }
        }

        class Address
        {
            public string City { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 85: ?? с null-safe ===\n");

                Person person = null;
                string city = person?.Home?.City ?? "Unknown";
                Console.WriteLine($"City: {city}");

                person = new Person { Home = new Address { City = "Moscow" } };
                city = person?.Home?.City ?? "Unknown";
                Console.WriteLine($"City: {city}");
            }
        }
    }

// 86


namespace SetPropertyIfNullDemo
    {
        class Config
        {
            public string ConnectionString { get; set; }
            public int? MaxRetries { get; set; }

            public void InitializeDefaults()
            {
                ConnectionString ??= "Server=localhost;Database=app;";
                MaxRetries ??= 3;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 86: Установка свойства если null ===\n");

                var config = new Config();
                config.InitializeDefaults();
                Console.WriteLine($"Conn: {config.ConnectionString}");
                Console.WriteLine($"Retries: {config.MaxRetries}");
            }
        }
    }

// 87


namespace NullCoalescingEventDemo
    {
        class Button
        {
            public event EventHandler Click;

            public void SimulateClick()
            {
                Click?.Invoke(this, EventArgs.Empty);
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 87: ?? в обработчиках событий ===\n");

                Button button = new Button();
                button.Click += (s, e) => Console.WriteLine("Clicked!");

                button.SimulateClick();

                Button nullButton = null;
                nullButton?.Click?.Invoke(nullButton, EventArgs.Empty);
            }
        }
    }

// 88


namespace NullCoalescingParseDemo
    {
        static class Parser
        {
            public static int? TryParseInt(string s)
            {
                return int.TryParse(s, out int result) ? result : (int?)null;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 88: ?? при парсинге ===\n");

                string input = "123";
                int value = Parser.TryParseInt(input) ?? 0;
                Console.WriteLine($"Parsed: {value}");

                input = "abc";
                value = Parser.TryParseInt(input) ?? -1;
                Console.WriteLine($"Parsed: {value}");
            }
        }
    }

// 89


namespace NullSafeChainDemo
    {
        class User
        {
            public Profile Profile { get; set; }
        }

        class Profile
        {
            public Settings Settings { get; set; }
        }

        class Settings
        {
            public string Theme { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 89: Цепочка ?? ===\n");

                User user = null;
                string theme = user?.Profile?.Settings?.Theme ?? "light";
                Console.WriteLine($"Theme: {theme}");

                user = new User
                {
                    Profile = new Profile
                    {
                        Settings = new Settings { Theme = "dark" }
                    }
                };
                theme = user?.Profile?.Settings?.Theme ?? "light";
                Console.WriteLine($"Theme: {theme}");
            }
        }
    }

// 90



namespace NullCoalescingCollectionDemo
    {
        static class CollectionHelper
        {
            public static IEnumerable<T> OrEmpty<T>(this IEnumerable<T> source)
            {
                return source ?? Enumerable.Empty<T>();
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 90: ?? для коллекций ===\n");

                List<string> items = null;
                foreach (var item in items.OrEmpty())
                    Console.WriteLine(item);

                items = new List<string> { "A", "B" };
                foreach (var item in items.OrEmpty())
                    Console.WriteLine(item);
            }
        }
    }

// 91


namespace NullCoalescingParamsDemo
    {
        class Logger
        {
            public static void Log(string message, string level = null)
            {
                string logLevel = level ?? "INFO";
                Console.WriteLine($"[{logLevel}] {message}");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 91: ?? для параметров ===\n");

                Logger.Log("App started");
                Logger.Log("Error occurred", "ERROR");
            }
        }
    }

// 92


namespace NullCoalescingDelegateDemo
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 92: ?? с Invoke ===\n");

                Action<string> handler = null;
                handler?.Invoke("Direct");

                (handler ?? (msg => Console.WriteLine($"Fallback: {msg}")))("Fallback call");
            }
        }
    }

// 93

using System.Threading.Tasks;

namespace NullCoalescingAsyncDemo
    {
        class DataService
        {
            public static async Task<string> GetDataAsync(bool fail = false)
            {
                await Task.Delay(100);
                return fail ? null : "Success";
            }
        }

        class Program
        {
            static async Task Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 93: ?? в async ===\n");

                string result = await DataService.GetDataAsync() ?? "Default";
                Console.WriteLine($"Result: {result}");

                result = await DataService.GetDataAsync(true) ?? "Default";
                Console.WriteLine($"Result: {result}");
            }
        }
    }

// 94


namespace NullCoalescingConfigDemo
    {
        class AppConfig
        {
            public string DatabaseUrl { get; set; }
            public int? Port { get; set; }
            public bool? EnableCache { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 94: ?? в конфигурации ===\n");

                AppConfig config = new AppConfig();

                string db = config.DatabaseUrl ?? "sqlite://localhost/app.db";
                int port = config.Port ?? 8080;
                bool cache = config.EnableCache ?? true;

                Console.WriteLine($"DB: {db}, Port: {port}, Cache: {cache}");
            }
        }
    }

// 95


namespace DefaultValuesDemo
    {
        class UserSettings
        {
            public string Language { get; set; }
            public string Theme { get; set; }

            public void ApplyDefaults()
            {
                Language ??= "en";
                Theme ??= "light";
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 95: ?? для значений по умолчанию ===\n");

                var settings = new UserSettings();
                settings.ApplyDefaults();
                Console.WriteLine($"Lang: {settings.Language}, Theme: {settings.Theme}");
            }
        }
    }

// 96



namespace NullToEmptyCollectionDemo
    {
        static class CollectionExtensions
        {
            public static List<T> ToEmptyListIfNull<T>(this List<T> list)
            {
                return list ?? new List<T>();
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 96: null в пустую коллекцию ===\n");

                List<string> items = null;
                var safeList = items.ToEmptyListIfNull();
                safeList.Add("Safe");

                Console.WriteLine($"Count: {safeList.Count}");
            }
        }
    }

// 97


namespace NullCoalescingLoggingDemo
    {
        class Logger
        {
            public static void Info(string message, string context = null)
            {
                string ctx = context ?? "General";
                Console.WriteLine($"[INFO] [{ctx}] {message}");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 97: ?? в логировании ===\n");

                Logger.Info("App started");
                Logger.Info("User logged in", "Auth");
            }
        }
    }

// 98


namespace NullCoalescingDbDemo
    {
        class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        class DbResult
        {
            public User User { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 98: ?? с БД ===\n");

                DbResult result = null;
                string name = result?.User?.Name ?? "Anonymous";
                Console.WriteLine($"User: {name}");

                result = new DbResult { User = new User { Name = "Alice", Email = "a@example.com" } };
                name = result?.User?.Name ?? "Anonymous";
                Console.WriteLine($"User: {name}");
            }
        }
    }

// 99


namespace NullCoalescingConstructorDemo
    {
        class Service
        {
            public string Endpoint { get; }
            public int Timeout { get; }

            public Service(string endpoint = null, int? timeout = null)
            {
                Endpoint = endpoint ?? "http://localhost:5000";
                Timeout = timeout ?? 30;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 99: ?? в конструкторах ===\n");

                var s1 = new Service();
                var s2 = new Service("https://api.com", 60);

                Console.WriteLine($"S1: {s1.Endpoint}, {s1.Timeout}s");
                Console.WriteLine($"S2: {s2.Endpoint}, {s2.Timeout}s");
            }
        }
    }

// 100



    {
        class Order
        {
            public string CustomerName { get; set; }
            public decimal? Amount { get; set; }

            public bool ValidateAndSetDefaults()
            {
                CustomerName = (CustomerName ?? "").Trim();
                if (string.IsNullOrEmpty(CustomerName))
                    return false;

                Amount ??= 0m;
                if (Amount < 0)
                    return false;

                return true;
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== ЗАДАНИЕ 100: Валидация с ?? ===\n");

                var order = new Order { CustomerName = null, Amount = null };
                bool valid = order.ValidateAndSetDefaults();

                Console.WriteLine($"Valid: {valid}");
                Console.WriteLine($"Name: '{order.CustomerName}', Amount: {order.Amount}");
            }
        }
    }
}