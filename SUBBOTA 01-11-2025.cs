// 1
using System;
using System.ComponentModel;
using System.Diagnostics;

public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Woof");
}

class Program1
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.MakeSound();
    }
}

// 2
using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

class Program2
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        Console.WriteLine($"Area: {c.CalculateArea():F2}");
    }
}

// 3
using System;

public abstract class Vehicle
{
    public abstract void Start();
    public abstract void Stop();
}

public class Car : Vehicle
{
    public override void Start() => Console.WriteLine("Car started");
    public override void Stop() => Console.WriteLine("Car stopped");
}

public class Motorcycle : Vehicle
{
    public override void Start() => Console.WriteLine("Motorcycle started");
    public override void Stop() => Console.WriteLine("Motorcycle stopped");
}

class Program3
{
    static void Main()
    {
        Vehicle car = new Car();
        Vehicle bike = new Motorcycle();
        car.Start(); car.Stop();
        bike.Start(); bike.Stop();
    }
}

// 4
using System;

public abstract class Product
{
    public abstract string GetDescription();
}

public class Book : Product
{
    public string Title { get; set; }
    public override string GetDescription() => $"Book: {Title}";
}

class Program4
{
    static void Main()
    {
        Product book = new Book { Title = "C# Guide" };
        Console.WriteLine(book.GetDescription());
    }
}

// 5
using System;

public abstract class Employee
{
    public string Name { get; set; }
    public abstract decimal CalculateSalary();
}

public class Manager : Employee
{
    public override decimal CalculateSalary() => 80000m;
}

class Program5
{
    static void Main()
    {
        Employee mgr = new Manager { Name = "Alice" };
        Console.WriteLine($"{mgr.Name}: {mgr.CalculateSalary():C}");
    }
}

// 6
using System;

public abstract class Database
{
    public abstract void Connect();
    public abstract void Disconnect();
    public abstract void Execute(string query);
}

public class SqlDatabase : Database
{
    public override void Connect() => Console.WriteLine("SQL Connected");
    public override void Disconnect() => Console.WriteLine("SQL Disconnected");
    public override void Execute(string query) => Console.WriteLine($"SQL: {query}");
}

class Program6
{
    static void Main()
    {
        Database db = new SqlDatabase();
        db.Connect();
        db.Execute("SELECT *");
        db.Disconnect();
    }
}

// 7
using System;

public abstract class Vehicle
{
    public abstract string Model { get; set; }
}

public class Car : Vehicle
{
    public override string Model { get; set; } = "Default Car";
}

class Program7
{
    static void Main()
    {
        Car car = new Car { Model = "Toyota" };
        Console.WriteLine(car.Model);
    }
}

// 8
using System;

public abstract class Animal
{
    public abstract void Speak();
}

public class Lion : Animal { public override void Speak() => Console.WriteLine("Roar"); }
public class Elephant : Animal { public override void Speak() => Console.WriteLine("Trumpet"); }

class Program8
{
    static void Main()
    {
        Animal[] animals = { new Lion(), new Elephant() };
        foreach (var a in animals) a.Speak();
    }
}

// 9
using System;

public abstract class Payment
{
    public abstract bool Process(decimal amount);
}

public class CreditCard : Payment
{
    public override bool Process(decimal amount)
    {
        Console.WriteLine($"Processed {amount:C} via card");
        return true;
    }
}

class Program9
{
    static void Main()
    {
        Payment payment = new CreditCard();
        payment.Process(100m);
    }
}

// 10
using System;

public abstract class Device
{
    protected string brand;
    public Device(string brand) => this.brand = brand;
    public abstract void PowerOn();
}

public class Phone : Device
{
    public Phone(string brand) : base(brand) { }
    public override void PowerOn() => Console.WriteLine($"{brand} phone on");
}

class Program10
{
    static void Main()
    {
        Phone p = new Phone("Samsung");
        p.PowerOn();
    }
}

// 11
using System;

public abstract class Figure
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Rectangle : Figure
{
    public double W { get; set; }
    public double H { get; set; }
    public override double Area() => W * H;
    public override double Perimeter() => 2 * (W + H);
}

class Program11
{
    static void Main()
    {
        Rectangle r = new Rectangle { W = 4, H = 5 };
        Console.WriteLine($"Area: {r.Area()}, Perimeter: {r.Perimeter()}");
    }
}

// 12
using System;

public abstract class Logger
{
    public abstract void Log(string message);
}

public class ConsoleLogger : Logger
{
    public override void Log(string message) => Console.WriteLine($"[CONSOLE] {message}");
}

public class FileLogger : Logger
{
    public override void Log(string message) => Console.WriteLine($"[FILE] {message}");
}

class Program12
{
    static void Main()
    {
        Logger[] loggers = { new ConsoleLogger(), new FileLogger() };
        foreach (var l in loggers) l.Log("Event");
    }
}

// 13
using System;

public abstract class DataService
{
    public abstract void Load();
    public abstract void Save();
    public abstract void Process();
}

public class UserService : DataService
{
    public override void Load() => Console.WriteLine("Load users");
    public override void Save() => Console.WriteLine("Save users");
    public override void Process() => Console.WriteLine("Process users");
}

class Program13
{
    static void Main()
    {
        DataService service = new UserService();
        service.Load(); service.Process(); service.Save();
    }
}

// 14
using System;

public abstract class Animal
{
    public abstract void Eat();
    public abstract void Sleep();
}

public class Tiger : Animal
{
    public override void Eat() => Console.WriteLine("Tiger eats meat");
    public override void Sleep() => Console.WriteLine("Tiger sleeps");
}

class Program14
{
    static void Main()
    {
        Tiger t = new Tiger();
        t.Eat(); t.Sleep();
    }
}

// 15
using System;

public abstract class DataProcessor
{
    public abstract void Read();
    public abstract void Transform();
    public abstract void Write();
}

public class CsvProcessor : DataProcessor
{
    public override void Read() => Console.WriteLine("Read CSV");
    public override void Transform() => Console.WriteLine("Transform CSV");
    public override void Write() => Console.WriteLine("Write CSV");
}

class Program15
{
    static void Main()
    {
        DataProcessor p = new CsvProcessor();
        p.Read(); p.Transform(); p.Write();
    }
}

// 16
using System;

public abstract class Authentication
{
    public abstract bool Login(string user, string pass);
    public abstract void Logout();
}

public class TokenAuth : Authentication
{
    public override bool Login(string user, string pass) => true;
    public override void Logout() => Console.WriteLine("Logged out");
}

class Program16
{
    static void Main()
    {
        Authentication auth = new TokenAuth();
        auth.Login("user", "pass");
        auth.Logout();
    }
}

// 17
using System;

public abstract class ReportGenerator
{
    public abstract void Generate();
    public abstract void Export(string format);
}

public class SalesReport : ReportGenerator
{
    public override void Generate() => Console.WriteLine("Sales report generated");
    public override void Export(string format) => Console.WriteLine($"Exported as {format}");
}

class Program17
{
    static void Main()
    {
        ReportGenerator r = new SalesReport();
        r.Generate(); r.Export("PDF");
    }
}

// 18
using System;

public abstract class FileHandler
{
    public abstract void Open(string path);
    public abstract void Close();
}

public class TextFile : FileHandler
{
    public override void Open(string path) => Console.WriteLine($"Opened {path}");
    public override void Close() => Console.WriteLine("Closed");
}

class Program18
{
    static void Main()
    {
        FileHandler f = new TextFile();
        f.Open("doc.txt"); f.Close();
    }
}

// 19
using System;

public abstract class Validator
{
    public abstract bool Validate(object data);
}

public class EmailValidator : Validator
{
    public override bool Validate(object data) => data is string s && s.Contains("@");
}

class Program19
{
    static void Main()
    {
        Validator v = new EmailValidator();
        Console.WriteLine(v.Validate("test@example.com"));
    }
}

// 20
using System;

public abstract class Notification
{
    public abstract void Send(string message);
}

public class EmailNotification : Notification
{
    public override void Send(string message) => Console.WriteLine($"Email: {message}");
}

class Program20
{
    static void Main()
    {
        Notification n = new EmailNotification();
        n.Send("Hello");
    }
}

// 21
using System;

public abstract class Calculator
{
    public abstract int Add(int a, int b);
    public abstract int Subtract(int a, int b);
}

public class SimpleCalculator : Calculator
{
    public override int Add(int a, int b) => a + b;
    public override int Subtract(int a, int b) => a - b;
}

class Program21
{
    static void Main()
    {
        Calculator calc = new SimpleCalculator();
        Console.WriteLine(calc.Add(5, 3));
    }
}

// 22
using System;

public abstract class Connection
{
    public abstract void Open();
    public abstract void Close();
}

public class DbConnection : Connection
{
    public override void Open() => Console.WriteLine("DB opened");
    public override void Close() => Console.WriteLine("DB closed");
}

class Program22
{
    static void Main()
    {
        Connection c = new DbConnection();
        c.Open(); c.Close();
    }
}

// 23
using System;

public abstract class Cache
{
    public abstract void Set(string key, object value);
    public abstract object Get(string key);
}

public class MemoryCache : Cache
{
    private Dictionary<string, object> store = new();
    public override void Set(string key, object value) => store[key] = value;
    public override object Get(string key) => store.GetValueOrDefault(key);
}

class Program23
{
    static void Main()
    {
        Cache cache = new MemoryCache();
        cache.Set("x", 10);
        Console.WriteLine(cache.Get("x"));
    }
}

// 24
using System;

public abstract class Parser
{
    public abstract object Parse(string input);
}

public class JsonParser : Parser
{
    public override object Parse(string input) => $"Parsed JSON: {input}";
}

class Program24
{
    static void Main()
    {
        Parser p = new JsonParser();
        Console.WriteLine(p.Parse("{...}"));
    }
}

// 25
using System;

public abstract class Serializer
{
    public abstract string Serialize(object obj);
}

public class JsonSerializer : Serializer
{
    public override string Serialize(object obj) => $"JSON: {obj}";
}

class Program25
{
    static void Main()
    {
        Serializer s = new JsonSerializer();
        Console.WriteLine(s.Serialize(new { Name = "Test" }));
    }
}

// 26
using System;

public abstract class Compressor
{
    public abstract byte[] Compress(byte[] data);
}

public class GzipCompressor : Compressor
{
    public override byte[] Compress(byte[] data) => data;
}

class Program26
{
    static void Main()
    {
        Compressor c = new GzipCompressor();
        c.Compress(new byte[] { 1, 2, 3 });
    }
}

// 27
using System;

public abstract class Encryptor
{
    public abstract string Encrypt(string plain);
}

public class AesEncryptor : Encryptor
{
    public override string Encrypt(string plain) => $"Encrypted: {plain}";
}

class Program27
{
    static void Main()
    {
        Encryptor e = new AesEncryptor();
        Console.WriteLine(e.Encrypt("secret"));
    }
}

// 28
using System;

public abstract class Formatter
{
    public abstract string Format(object data);
}

public class DateFormatter : Formatter
{
    public override string Format(object data) => data is DateTime d ? d.ToShortDateString() : "";
}

class Program28
{
    static void Main()
    {
        Formatter f = new DateFormatter();
        Console.WriteLine(f.Format(DateTime.Now));
    }
}

// 29
using System;

public abstract class Filter
{
    public abstract IEnumerable<T> Apply<T>(IEnumerable<T> source);
}

public class EvenFilter : Filter
{
    public override IEnumerable<int> Apply(IEnumerable<int> source) => source.Where(x => x % 2 == 0);
}

class Program29
{
    static void Main()
    {
        Filter f = new EvenFilter();
        foreach (var n in f.Apply(new[] { 1, 2, 3, 4 })) Console.WriteLine(n);
    }
}

// 30
using System;

public abstract class Sorter
{
    public abstract IEnumerable<T> Sort<T>(IEnumerable<T> source);
}

public class QuickSorter : Sorter
{
    public override IEnumerable<T> Sort<T>(IEnumerable<T> source) => source.OrderBy(x => x);
}

class Program30
{
    static void Main()
    {
        Sorter s = new QuickSorter();
        foreach (var n in s.Sort(new[] { 3, 1, 4, 1 })) Console.WriteLine(n);
    }
}

// 31
using System;

public abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract object GetResult();
}

public class CarBuilder : Builder
{
    private string result = "";
    public override void BuildPartA() => result += "Engine ";
    public override void BuildPartB() => result += "Wheels";
    public override object GetResult() => result;
}

class Program31
{
    static void Main()
    {
        Builder b = new CarBuilder();
        b.BuildPartA(); b.BuildPartB();
        Console.WriteLine(b.GetResult());
    }
}

// 32
using System;

public abstract class Strategy
{
    public abstract int Execute(int a, int b);
}

public class AddStrategy : Strategy
{
    public override int Execute(int a, int b) => a + b;
}

class Program32
{
    static void Main()
    {
        Strategy s = new AddStrategy();
        Console.WriteLine(s.Execute(2, 3));
    }
}

// 33
using System;

public abstract class Adapter
{
    public abstract string Adapt(string input);
}

public class LegacyAdapter : Adapter
{
    public override string Adapt(string input) => input.ToUpper();
}

class Program33
{
    static void Main()
    {
        Adapter a = new LegacyAdapter();
        Console.WriteLine(a.Adapt("hello"));
    }
}

// 34
using System;

public abstract class Observable
{
    public abstract void Notify(string message);
}

public class Subject : Observable
{
    public override void Notify(string message) => Console.WriteLine($"Observed: {message}");
}

class Program34
{
    static void Main()
    {
        Observable o = new Subject();
        o.Notify("Change");
    }
}

// 35
using System;

public abstract class Command
{
    public abstract void Execute();
}

public class LightOnCommand : Command
{
    public override void Execute() => Console.WriteLine("Light on");
}

class Program35
{
    static void Main()
    {
        Command c = new LightOnCommand();
        c.Execute();
    }
}

// 36
using System;

public interface IAnimal
{
    void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound() => Console.WriteLine("Woof");
}

class Program36
{
    static void Main()
    {
        IAnimal dog = new Dog();
        dog.MakeSound();
    }
}

// 37
using System;

public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea() => Width * Height;
}

class Program37
{
    static void Main()
    {
        IShape r = new Rectangle { Width = 4, Height = 5 };
        Console.WriteLine(r.CalculateArea());
    }
}

// 38
using System;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person other) => Age.CompareTo(other.Age);
}

class Program38
{
    static void Main()
    {
        Person p1 = new() { Name = "A", Age = 30 };
        Person p2 = new() { Name = "B", Age = 25 };
        Console.WriteLine(p1.CompareTo(p2));
    }
}

// 39
using System;

public interface IPayable
{
    decimal GetAmount();
}

public class Invoice : IPayable
{
    public decimal GetAmount() => 100m;
}

class Program39
{
    static void Main()
    {
        IPayable inv = new Invoice();
        Console.WriteLine(inv.GetAmount());
    }
}

// 40
using System;

public interface IDrawable
{
    void Draw();
}

public class Circle : IDrawable
{
    public void Draw() => Console.WriteLine("Drawing circle");
}

class Program40
{
    static void Main()
    {
        IDrawable c = new Circle();
        c.Draw();
    }
}

// 41
using System;
using System.Collections;

public class MyCollection : IEnumerable
{
    private int[] data = { 1, 2, 3 };
    public IEnumerator GetEnumerator() => ((IEnumerable)data).GetEnumerator();
}

class Program41
{
    static void Main()
    {
        foreach (var item in new MyCollection()) Console.WriteLine(item);
    }
}

// 42
using System;

public class Resource : IDisposable
{
    public void Dispose() => Console.WriteLine("Disposed");
}

class Program42
{
    static void Main()
    {
        using var r = new Resource();
    }
}

// 43
using System;

public class ClonableObject : ICloneable
{
    public int Value { get; set; }
    public object Clone() => new ClonableObject { Value = Value };
}

class Program43
{
    static void Main()
    {
        ClonableObject o1 = new() { Value = 10 };
        ClonableObject o2 = (ClonableObject)o1.Clone();
        Console.WriteLine(o2.Value);
    }
}

// 44
using System;
using System.ComponentModel;

public class ViewModel : INotifyPropertyChanged
{
    private string name;
    public string Name
    {
        get => name;
        set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))); }
    }
    public event PropertyChangedEventHandler PropertyChanged;
}

class Program44
{
    static void Main()
    {
        ViewModel vm = new();
        vm.PropertyChanged += (s, e) => Console.WriteLine($"Property {e.PropertyName} changed");
        vm.Name = "Test";
    }
}

// 45
using System;
using System.Collections.Generic;

public interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
}

public class UserRepo : IRepository<string>
{
    public void Add(string item) => Console.WriteLine($"Added {item}");
    public string Get(int id) => $"User {id}";
}

class Program45
{
    static void Main()
    {
        IRepository<string> repo = new UserRepo();
        repo.Add("Alice");
    }
}

// 46
using System;

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

class Program46
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Event");
    }
}

// 47
using System;

public interface IValidator
{
    bool Validate(string input);
}

public class EmailValidator : IValidator
{
    public bool Validate(string input) => input.Contains("@");
}

class Program47
{
    static void Main()
    {
        IValidator v = new EmailValidator();
        Console.WriteLine(v.Validate("a@b.c"));
    }
}

// 48
using System;

public interface IConverter
{
    string Convert(object input);
}

public class ToStringConverter : IConverter
{
    public string Convert(object input) => input.ToString();
}

class Program48
{
    static void Main()
    {
        IConverter c = new ToStringConverter();
        Console.WriteLine(c.Convert(123));
    }
}

// 49
using System;

public interface IParser
{
    int Parse(string s);
}

public class IntParser : IParser
{
    public int Parse(string s) => int.Parse(s);
}

class Program49
{
    static void Main()
    {
        IParser p = new IntParser();
        Console.WriteLine(p.Parse("42"));
    }
}

// 50
using System;

public interface ISerializer
{
    string Serialize(object obj);
}

public class JsonSerializer : ISerializer
{
    public string Serialize(object obj) => $"{{ \"data\": \"{obj}\" }}";
}

class Program50
{
    static void Main()
    {
        ISerializer s = new JsonSerializer();
        Console.WriteLine(s.Serialize("test"));
    }
}

// 51
using System;

public interface IEncryptor
{
    string Encrypt(string text);
}

public class SimpleEncryptor : IEncryptor
{
    public string Encrypt(string text) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
}

class Program51
{
    static void Main()
    {
        IEncryptor e = new SimpleEncryptor();
        Console.WriteLine(e.Encrypt("hello"));
    }
}

// 52
using System;

public interface ICompressor
{
    byte[] Compress(string input);
}

public class DummyCompressor : ICompressor
{
    public byte[] Compress(string input) => System.Text.Encoding.UTF8.GetBytes(input);
}

class Program52
{
    static void Main()
    {
        ICompressor c = new DummyCompressor();
        c.Compress("data");
    }
}

// 53
using System;

public interface IFilter
{
    IEnumerable<int> Filter(IEnumerable<int> source);
}

public class PositiveFilter : IFilter
{
    public IEnumerable<int> Filter(IEnumerable<int> source) => source.Where(x => x > 0);
}

class Program53
{
    static void Main()
    {
        IFilter f = new PositiveFilter();
        foreach (var n in f.Filter(new[] { -1, 2, -3, 4 })) Console.WriteLine(n);
    }
}

// 54
using System;

public interface ISorter
{
    IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>;
}

public class BubbleSorter : ISorter
{
    public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T> => source.OrderBy(x => x);
}

class Program54
{
    static void Main()
    {
        ISorter s = new BubbleSorter();
        foreach (var n in s.Sort(new[] { 3, 1, 4 })) Console.WriteLine(n);
    }
}

// 55
using System;

public interface IBuilder
{
    void Build();
}

public class HouseBuilder : IBuilder
{
    public void Build() => Console.WriteLine("House built");
}

class Program55
{
    static void Main()
    {
        IBuilder b = new HouseBuilder();
        b.Build();
    }
}

// 56
using System;

public interface IStrategy
{
    int Execute(int a, int b);
}

public class MultiplyStrategy : IStrategy
{
    public int Execute(int a, int b) => a * b;
}

class Program56
{
    static void Main()
    {
        IStrategy s = new MultiplyStrategy();
        Console.WriteLine(s.Execute(2, 3));
    }
}

// 57
using System;

public interface IAdapter
{
    string Adapt(string input);
}

public class XmlToJsonAdapter : IAdapter
{
    public string Adapt(string input) => $"{{json: \"{input}\"}}";
}

class Program57
{
    static void Main()
    {
        IAdapter a = new XmlToJsonAdapter();
        Console.WriteLine(a.Adapt("<data/>"));
    }
}

// 58
using System;

public interface IObserver
{
    void Update(string state);
}

public class Display : IObserver
{
    public void Update(string state) => Console.WriteLine($"Display: {state}");
}

class Program58
{
    static void Main()
    {
        IObserver o = new Display();
        o.Update("On");
    }
}

// 59
using System;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class MoveCommand : ICommand
{
    public void Execute() => Console.WriteLine("Moved");
    public void Undo() => Console.WriteLine("Undo move");
}

class Program59
{
    static void Main()
    {
        ICommand c = new MoveCommand();
        c.Execute(); c.Undo();
    }
}

// 60
using System;

public interface IFactory
{
    object Create();
}

public class CarFactory : IFactory
{
    public object Create() => new { Type = "Car" };
}

class Program60
{
    static void Main()
    {
        IFactory f = new CarFactory();
        Console.WriteLine(f.Create());
    }
}

// 61
using System;

public interface IConnection
{
    void Open();
    void Close();
}

public class TcpConnection : IConnection
{
    public void Open() => Console.WriteLine("TCP open");
    public void Close() => Console.WriteLine("TCP close");
}

class Program61
{
    static void Main()
    {
        IConnection c = new TcpConnection();
        c.Open(); c.Close();
    }
}

// 62
using System;

public interface ICache
{
    void Set(string key, object value);
    object Get(string key);
}

public class MemoryCache : ICache
{
    private Dictionary<string, object> store = new();
    public void Set(string key, object value) => store[key] = value;
    public object Get(string key) => store.GetValueOrDefault(key);
}

class Program62
{
    static void Main()
    {
        ICache cache = new MemoryCache();
        cache.Set("k", "v");
        Console.WriteLine(cache.Get("k"));
    }
}

// 63
using System;

public interface IAuthentication
{
    bool Authenticate(string user, string pass);
}

public class SimpleAuth : IAuthentication
{
    public bool Authenticate(string user, string pass) => user == "admin" && pass == "123";
}

class Program63
{
    static void Main()
    {
        IAuthentication auth = new SimpleAuth();
        Console.WriteLine(auth.Authenticate("admin", "123"));
    }
}

// 64
using System;

public interface IAuthorization
{
    bool IsAuthorized(string role, string action);
}

public class RoleAuth : IAuthorization
{
    public bool IsAuthorized(string role, string action) => role == "admin";
}

class Program64
{
    static void Main()
    {
        IAuthorization auth = new RoleAuth();
        Console.WriteLine(auth.IsAuthorized("admin", "delete"));
    }
}

// 65
using System;

public interface ILoggable { void Log(); }
public interface IValidatable { bool Validate(); }

public class Service : ILoggable, IValidatable
{
    public void Log() => Console.WriteLine("Logged");
    public bool Validate() => true;
}

class Program65
{
    static void Main()
    {
        Service s = new Service();
        s.Log();
        Console.WriteLine(s.Validate());
    }
}

// 66
using System;

public interface IEntity
{
    int Id { get; set; }
    void Save();
}

public class User : IEntity
{
    public int Id { get; set; }
    public void Save() => Console.WriteLine($"Saved {Id}");
}

class Program66
{
    static void Main()
    {
        IEntity u = new User { Id = 1 };
        u.Save();
    }
}

// 67
using System;

public interface IPrintable
{
    void Print();
}

public class Doc : IPrintable
{
    public void Print() => Console.WriteLine("Print doc");
}

class Program67
{
    static void Main()
    {
        IPrintable p = new Doc();
        p.Print();
    }
}

// 68
using System;

public interface IConnectable
{
    void Connect();
}

public class Wifi : IConnectable
{
    void IConnectable.Connect() => Console.WriteLine("WiFi connected");
}

class Program68
{
    static void Main()
    {
        IConnectable w = new Wifi();
        w.Connect();
    }
}

// 69
using System;

public interface IBase { void BaseMethod(); }
public interface IDerived : IBase { void DerivedMethod(); }

public class Impl : IDerived
{
    public void BaseMethod() => Console.WriteLine("Base");
    public void DerivedMethod() => Console.WriteLine("Derived");
}

class Program69
{
    static void Main()
    {
        IDerived d = new Impl();
        d.BaseMethod(); d.DerivedMethod();
    }
}

// 70
using System;

public interface IGreeter
{
    void Greet() => Console.WriteLine("Hello from default");
}

public class Person : IGreeter { }

class Program70
{
    static void Main()
    {
        IGreeter g = new Person();
        g.Greet();
    }
}

// 71
using System;

public interface ILogger { void Log(string msg); }

public class Service
{
    private readonly ILogger _logger;
    public Service(ILogger logger) => _logger = logger;
    public void Do() => _logger.Log("Doing work");
}

class Program71
{
    static void Main()
    {
        var logger = new ConsoleLogger();
        var service = new Service(logger);
        service.Do();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 72
using System;

public interface ILogger { void Log(string msg); }

public class App
{
    private readonly ILogger _logger;
    public App(ILogger logger) => _logger = logger;
    public void Run() => _logger.Log("App running");
}

class Program72
{
    static void Main()
    {
        new App(new ConsoleLogger()).Run();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 73
using System;

public interface ILogger { void Log(string msg); }
public interface IRepository { void Save(); }

public class OrderService
{
    private readonly ILogger _logger;
    private readonly IRepository _repo;
    public OrderService(ILogger logger, IRepository repo)
    {
        _logger = logger; _repo = repo;
    }
    public void Process() { _logger.Log("Processing"); _repo.Save(); }
}

class Program73
{
    static void Main()
    {
        var service = new OrderService(new ConsoleLogger(), new DummyRepo());
        service.Process();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }
class DummyRepo : IRepository { public void Save() => Console.WriteLine("Saved"); }

// 74
using System;
using System.Collections.Generic;

public interface IService { }
public class ServiceA : IService { }
public class ServiceB : IService { }

public class SimpleContainer
{
    private Dictionary<Type, object> services = new();
    public void Register<T>(T instance) => services[typeof(T)] = instance;
    public T Resolve<T>() => (T)services[typeof(T)];
}

class Program74
{
    static void Main()
    {
        var container = new SimpleContainer();
        container.Register<IService>(new ServiceA());
        var s = container.Resolve<IService>();
    }
}

// 75
using System;

public interface ILogger { void Log(string msg); }

public class Worker
{
    public ILogger Logger { get; set; }
    public void Work() => Logger?.Log("Working");
}

class Program75
{
    static void Main()
    {
        var w = new Worker();
        w.Logger = new ConsoleLogger();
        w.Work();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 76
using System;

public interface ILogger { void Log(string msg); }

public class ServiceFactory
{
    private readonly ILogger _logger;
    public ServiceFactory(ILogger logger) => _logger = logger;
    public Service Create() => new Service(_logger);
}

public class Service
{
    private readonly ILogger _logger;
    public Service(ILogger logger) => _logger = logger;
    public void Run() => _logger.Log("Service run");
}

class Program76
{
    static void Main()
    {
        var factory = new ServiceFactory(new ConsoleLogger());
        factory.Create().Run();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 77
using System;
using System.Collections.Generic;

public interface IService { void Execute(); }

public class SingletonService : IService
{
    public void Execute() => Console.WriteLine("Singleton");
}

public class DIContainer
{
    private Dictionary<Type, object> singletons = new();
    public void RegisterSingleton<T>(T instance) => singletons[typeof(T)] = instance;
    public T GetSingleton<T>() => (T)singletons[typeof(T)];
}

class Program77
{
    static void Main()
    {
        var container = new DIContainer();
        var svc = new SingletonService();
        container.RegisterSingleton<IService>(svc);
        container.GetSingleton<IService>().Execute();
    }
}

// 78
using System;
using System.Collections.Generic;

public interface IService { void Execute(); }

public class TransientService : IService
{
    public void Execute() => Console.WriteLine("Transient");
}

public class DIContainer
{
    private Dictionary<Type, Func<object>> transients = new();
    public void RegisterTransient<T>(Func<T> factory) => transients[typeof(T)] = () => factory();
    public T Resolve<T>() => (T)transients[typeof(T)]();
}

class Program78
{
    static void Main()
    {
        var container = new DIContainer();
        container.RegisterTransient<IService>(() => new TransientService());
        container.Resolve<IService>().Execute();
    }
}

// 79
using System;
using System.Collections.Generic;
using System.Reflection;

public interface IService { }

public class AutoContainer
{
    private Dictionary<Type, Type> mappings = new();
    public void Register<TInterface, TImplementation>() => mappings[typeof(TInterface)] = typeof(TImplementation);
    public T Resolve<T>()
    {
        var type = mappings[typeof(T)];
        var ctor = type.GetConstructors()[0];
        var parameters = ctor.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();
        return (T)ctor.Invoke(parameters);
    }
    private object Resolve(Type t) => Activator.CreateInstance(t);
}



// 80
using System;

public interface ILogger { void Log(string msg); }
public interface IRepository { void Save(); }
public interface IService { void Run(); }

public class Logger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }
public class Repository : IRepository { public void Save() => Console.WriteLine("Saved"); }
public class Service : IService
{
    private readonly ILogger _log;
    private readonly IRepository _repo;
    public Service(ILogger log, IRepository repo) { _log = log; _repo = repo; }
    public void Run() { _log.Log("Run"); _repo.Save(); }
}

class Program80
{
    static void Main()
    {
        var service = new Service(new Logger(), new Repository());
        service.Run();
    }
}

// 81
using System;
using System.Collections.Generic;

public interface IA { }
public interface IB { }

public class A : IA
{
    private readonly IB _b;
    public A(IB b) => _b = b;
}

public class B : IB
{
    private readonly IA _a;
    public B(IA a) => _a = a;
}

public class CircularContainer
{
    private Dictionary<Type, Func<object>> factory = new();
    private Dictionary<Type, object> resolving = new();

    public void Register<T>(Func<CircularContainer, T> f) => factory[typeof(T)] = () => f(this);

    public T Resolve<T>()
    {
        var type = typeof(T);
        if (resolving.ContainsKey(type)) throw new InvalidOperationException("Cycle");
        resolving[type] = null;
        var result = (T)factory[type]();
        resolving.Remove(type);
        return result;
    }
}



// 82
using System;

public interface ILogger { void Log(string msg); }

public class Service
{
    private ILogger _logger;
    public void Inject(ILogger logger) => _logger = logger;
    public void Run() => _logger?.Log("Injected");
}

class Program82
{
    static void Main()
    {
        var s = new Service();
        s.Inject(new ConsoleLogger());
        s.Run();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 83
using System;

public interface ILogger { void Log(string msg); }

public static class ServiceLocator
{
    private static ILogger _logger;
    public static void SetLogger(ILogger logger) => _logger = logger;
    public static ILogger GetLogger() => _logger;
}

public class Worker
{
    public void Do() => ServiceLocator.GetLogger().Log("Work");
}

class Program83
{
    static void Main()
    {
        ServiceLocator.SetLogger(new ConsoleLogger());
        new Worker().Do();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 84
using System;

public interface ILogger { void Log(string msg); }

public class ConfigurableService
{
    private readonly ILogger _logger;
    public ConfigurableService(ILogger logger) => _logger = logger;
    public void Run() => _logger.Log("Configured");
}

class Program84
{
    static void Main()
    {
        var service = new ConfigurableService(new ConsoleLogger());
        service.Run();
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 85
using System;
using System.Collections.Generic;

public interface IRepository<T> { void Save(T item); }

public class GenericRepo<T> : IRepository<T>
{
    public void Save(T item) => Console.WriteLine($"Saved {item}");
}

public class GenericContainer
{
    private Dictionary<Type, object> repos = new();
    public IRepository<T> GetRepo<T>() => (IRepository<T>)repos.GetValueOrDefault(typeof(IRepository<T>)) ?? CreateRepo<T>();

    private IRepository<T> CreateRepo<T>()
    {
        var repo = new GenericRepo<T>();
        repos[typeof(IRepository<T>)] = repo;
        return repo;
    }
}

class Program85
{
    static void Main()
    {
        var container = new GenericContainer();
        container.GetRepo<string>().Save("data");
    }
}

// 86
using System;

public interface ILogger { void Log(string msg); }

public class DecoratedLogger : ILogger
{
    private readonly ILogger _inner;
    public DecoratedLogger(ILogger inner) => _inner = inner;
    public void Log(string msg) { Console.Write("DECOR: "); _inner.Log(msg); }
}

class Program86
{
    static void Main()
    {
        var logger = new DecoratedLogger(new ConsoleLogger());
        logger.Log("test");
    }
}

class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine(msg); }

// 87
using System;

public interface IService { void Execute(); }

public class InterceptedService : IService
{
    private readonly IService _inner;
    public InterceptedService(IService inner) => _inner = inner;
    public void Execute()
    {
        Console.WriteLine("Before");
        _inner.Execute();
        Console.WriteLine("After");
    }
}

public class RealService : IService { public void Execute() => Console.WriteLine("Real"); }

class Program87
{
    static void Main()
    {
        var service = new InterceptedService(new RealService());
        service.Execute();
    }
}

// 88
using System;

public interface IService { void Run(); }

public class ServiceFactory
{
    private readonly Func<IService> _factory;
    public ServiceFactory(Func<IService> factory) => _factory = factory;
    public IService Create() => _factory();
}

class Program88
{
    static void Main()
    {
        var container = new ServiceFactory(() => new RealService());
        container.Create().Run();
    }
}

class RealService : IService { public void Run() => Console.WriteLine("Running"); }

// 89
using System;

public class TracedContainer
{
    private readonly Dictionary<Type, object> services = new();
    public void Register<T>(T instance)
    {
        Console.WriteLine($"Registering {typeof(T)}");
        services[typeof(T)] = instance;
    }
    public T Resolve<T>()
    {
        Console.WriteLine($"Resolving {typeof(T)}");
        return (T)services[typeof(T)];
    }
}

class Program89
{
    static void Main()
    {
        var container = new TracedContainer();
        container.Register<IService>(new RealService());
        container.Resolve<IService>().Run();
    }
}

public interface IService { void Run(); }
class RealService : IService { public void Run() => Console.WriteLine("Run"); }

// 90
using System;
using System.Diagnostics;

public class ProfilingContainer
{
    private readonly Dictionary<Type, object> services = new();
    public void Register<T>(T instance) => services[typeof(T)] = instance;
    public T Resolve<T>()
    {
        var sw = Stopwatch.StartNew();
        var result = (T)services[typeof(T)];
        sw.Stop();
        Console.WriteLine($"Resolved {typeof(T)} in {sw.ElapsedMilliseconds}ms");
        return result;
    }
}

class Program90
{
    static void Main()
    {
        var container = new ProfilingContainer();
        container.Register<IService>(new RealService());
        container.Resolve<IService>().Run();
    }
}

public interface IService { void Run(); }
class RealService : IService { public void Run() => Console.WriteLine("Run"); }

// 91
using System;

public interface ILevel1 { void L1(); }
public interface ILevel2 { void L2(); }

public class Level1 : ILevel1 { public void L1() => Console.WriteLine("L1"); }
public class Level2 : ILevel2
{
    private readonly ILevel1 _l1;
    public Level2(ILevel1 l1) => _l1 = l1;
    public void L2() { _l1.L1(); Console.WriteLine("L2"); }
}

class Program91
{
    static void Main()
    {
        var l2 = new Level2(new Level1());
        l2.L2();
    }
}

// 92
using System;

public interface IService { void Run(); }

public class MockService : IService { public void Run() => Console.WriteLine("Mock"); }

class Program92
{
    static void Main()
    {
        var service = new MockService();
        service.Run();
    }
}

// 93
using System;

public class Config
{
    public string ConnectionString { get; set; } = "config";
}

public interface IDb { void Connect(); }

public class Db : IDb
{
    private readonly Config _config;
    public Db(Config config) => _config = config;
    public void Connect() => Console.WriteLine($"Connect: {_config.ConnectionString}");
}

class Program93
{
    static void Main()
    {
        var config = new Config();
        var db = new Db(config);
        db.Connect();
    }
}

// 94
using System;

public interface IPlugin { void Execute(); }

public class PluginA : IPlugin { public void Execute() => Console.WriteLine("Plugin A"); }

public class PluginContainer
{
    private readonly List<IPlugin> plugins;
    public PluginContainer(IEnumerable<IPlugin> plugins) => this.plugins = plugins.ToList();
    public void RunAll() => plugins.ForEach(p => p.Execute());
}

class Program94
{
    static void Main()
    {
        var container = new PluginContainer(new[] { new PluginA() });
        container.RunAll();
    }
}

// 95
using System;

[AttributeUsage(AttributeTargets.Class)]
public class ServiceAttribute : Attribute { }

[Service]
public class AttributedService
{
    public void Run() => Console.WriteLine("Attributed");
}

class Program95
{
    static void Main()
    {
        var type = typeof(AttributedService);
        if (type.GetCustomAttributes(typeof(ServiceAttribute), false).Length > 0)
            Console.WriteLine("Is service");
    }
}

// 96
using System;
using System.Threading.Tasks;

public interface IAsyncService { Task InitAsync(); }

public class AsyncInitService : IAsyncService
{
    public async Task InitAsync()
    {
        await Task.Delay(100);
        Console.WriteLine("Async init done");
    }
}

class Program96
{
    static async Task Main()
    {
        var service = new AsyncInitService();
        await service.InitAsync();
    }
}

// 97
using System;

public interface IService { void Run(); }

public class Service : IService
{
    private readonly IService _next;
    public Service(IService next = null) => _next = next;
    public void Run() { Console.WriteLine("Service"); _next?.Run(); }
}

class Program97
{
    static void Main()
    {
        var chain = new Service(new Service());
        chain.Run();
    }
}

// 98
using System;

public interface IMicroservice { void Start(); }

public class AuthService : IMicroservice { public void Start() => Console.WriteLine("Auth started"); }

class Program98
{
    static void Main()
    {
        var service = new AuthService();
        service.Start();
    }
}

// 99
using System;

public interface IServiceV1 { void V1(); }
public interface IServiceV2 { void V2(); }

public class ServiceV1 : IServiceV1 { public void V1() => Console.WriteLine("V1"); }
public class ServiceV2Adapter : IServiceV2
{
    private readonly IServiceV1 _v1;
    public ServiceV2Adapter(IServiceV1 v1) => _v1 = v1;
    public void V2() { _v1.V1(); Console.WriteLine("V2"); }
}

class Program99
{
    static void Main()
    {
        var v2 = new ServiceV2Adapter(new ServiceV1());
        v2.V2();
    }
}

// 100
using System;

public interface IStateful { void SaveState(); void RestoreState(); }

public class StatefulService : IStateful
{
    private object state;
    public void SaveState() => state = new { Data = "backup" };
    public void RestoreState() => Console.WriteLine(state ?? "No state");
}

class Program100
{
    static void Main()
    {
        var s = new StatefulService();
        s.SaveState();
        s.RestoreState();
    }
}