// 2
 
using System.Text.RegularExpressions;

public partial class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

public partial class Calculator
{
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}

class Program2
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 3));
        Console.WriteLine(calc.Subtract(10, 4));
    }
}

// 3
 

public partial class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public partial class Customer
{
    public string GetContactInfo()
    {
        return $"Email: {Email}, Phone: {Phone}";
    }

    public void UpdateEmail(string newEmail)
    {
        Email = newEmail;
    }

    public void UpdatePhone(string newPhone)
    {
        Phone = newPhone;
    }
}

class Program3
{
    static void Main()
    {
        Customer cust = new Customer { Id = 1, Name = "John", Email = "john@example.com", Phone = "123-456" };
        Console.WriteLine(cust.GetContactInfo());
    }
}

// 4
 

public partial class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }
}

public partial class Product
{
    public decimal TotalPrice()
    {
        return Price * Quantity * (1 - Discount);
    }

    public decimal TaxAmount(decimal taxRate)
    {
        return TotalPrice() * taxRate;
    }

    public decimal FinalPrice(decimal taxRate)
    {
        return TotalPrice() + TaxAmount(taxRate);
    }
}

class Program4
{
    static void Main()
    {
        Product prod = new Product { Name = "Laptop", Price = 1000m, Quantity = 2, Discount = 0.1m };
        Console.WriteLine($"Final: {prod.FinalPrice(0.2m):C}");
    }
}

// 5
 

public partial class Student
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Age;
    public string Major;
}

public partial class Student
{
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetInfo()
    {
        return $"ID: {Id}, Name: {GetFullName()}, Age: {Age}, Major: {Major}";
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}

class Program5
{
    static void Main()
    {
        Student student = new Student { Id = 101, FirstName = "Anna", LastName = "Smith", Age = 20, Major = "CS" };
        Console.WriteLine(student.GetInfo());
    }
}

// 6
 

public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }
    public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }
}

public partial class Employee
{
    public decimal CalculateMonthlySalary()
    {
        return BaseSalary + (HoursWorked * HourlyRate);
    }

    public decimal CalculateBonus(decimal percentage)
    {
        return CalculateMonthlySalary() * percentage / 100;
    }

    public decimal TotalCompensation(decimal bonusPercent)
    {
        return CalculateMonthlySalary() + CalculateBonus(bonusPercent);
    }
}

class Program6
{
    static void Main()
    {
        Employee emp = new Employee { Id = 1, Name = "Tom", BaseSalary = 3000m, HoursWorked = 40, HourlyRate = 25m };
        Console.WriteLine($"Total: {emp.TotalCompensation(10):C}");
    }
}

// 7
 

public partial class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public partial class Rectangle
{
    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public bool IsSquare()
    {
        return Math.Abs(Width - Height) < 0.0001;
    }
}

class Program7
{
    static void Main()
    {
        Rectangle rect = new Rectangle { Width = 5, Height = 5 };
        Console.WriteLine($"Area: {rect.Area()}, Square: {rect.IsSquare()}");
    }
}

// 8
 

public partial class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Log($"Deposited {amount:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Log($"Withdrew {amount:C}");
        }
        else
        {
            Log("Insufficient funds");
        }
    }
}

public partial class BankAccount
{
    private void Log(string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"[LOG {timestamp}] Account {AccountNumber}: {message}");
    }
}

class Program8
{
    static void Main()
    {
        BankAccount acc = new BankAccount { AccountNumber = "12345", Balance = 1000m };
        acc.Deposit(500m);
        acc.Withdraw(200m);
    }
}

// 9
 

public partial class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }
}

public partial class Book
{
    public bool ContainsKeyword(string keyword)
    {
        return Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
               Author.Contains(keyword, StringComparison.OrdinalIgnoreCase);
    }

    public string GetSummary()
    {
        return $"\"{Title}\" by {Author}, {Pages} pages, ISBN: {ISBN}";
    }

    public bool IsLongBook()
    {
        return Pages > 300;
    }
}

class Program9
{
    static void Main()
    {
        Book book = new Book { Title = "1984", Author = "Orwell", ISBN = "123456", Pages = 328, Genre = "Dystopia" };
        Console.WriteLine(book.GetSummary());
        Console.WriteLine($"Contains 'Orwell': {book.ContainsKeyword("Orwell")}");
    }
}

// 10
 

public partial class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Speed { get; private set; }
    public bool IsEngineOn { get; private set; }
}

public partial class Car
{
    public void StartEngine()
    {
        IsEngineOn = true;
        Console.WriteLine("Engine started");
    }

    public void StopEngine()
    {
        IsEngineOn = false;
        Speed = 0;
        Console.WriteLine("Engine stopped");
    }

    public void Accelerate(double increment)
    {
        if (IsEngineOn)
        {
            Speed += increment;
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }

    public void Brake(double decrement)
    {
        Speed = Math.Max(0, Speed - decrement);
        Console.WriteLine($"Speed: {Speed} km/h");
    }
}

class Program10
{
    static void Main()
    {
        Car car = new Car { Make = "Toyota", Model = "Corolla", Year = 2023 };
        car.StartEngine();
        car.Accelerate(50);
        car.Brake(20);
        car.StopEngine();
    }
}

// 11
 

public partial class House
{
    public string Address { get; set; }
    public int Rooms { get; set; }
    public double Area { get; set; }
    public decimal Price { get; set; }
}

public partial class House
{
    public double PricePerSquareMeter()
    {
        return Area > 0 ? (double)(Price / (decimal)Area) : 0;
    }

    public string GetDescription()
    {
        return $"{Rooms}-room house at {Address}, {Area} sq.m, {Price:C}";
    }

    public bool IsExpensive(decimal threshold)
    {
        return Price > threshold;
    }
}

class Program11
{
    static void Main()
    {
        House house = new House { Address = "123 Main St", Rooms = 4, Area = 120, Price = 300000m };
        Console.WriteLine(house.GetDescription());
        Console.WriteLine($"Price/sq.m: {house.PricePerSquareMeter():C}");
    }
}

// 12
 

public partial class Game
{
    public string Title { get; set; }
    public int MaxPlayers { get; set; }
    public List<string> Players { get; private set; }
}

public partial class Game
{
    public Game()
    {
        Players = new List<string>();
    }

    public void Initialize()
    {
        Console.WriteLine($"Initializing {Title} for {MaxPlayers} players");
        Players.Clear();
    }

    public void Start()
    {
        if (Players.Count > 0)
            Console.WriteLine($"Game started with {Players.Count} players");
        else
            Console.WriteLine("No players to start");
    }

    public void AddPlayer(string name)
    {
        if (Players.Count < MaxPlayers)
        {
            Players.Add(name);
            Console.WriteLine($"{name} joined");
        }
    }

    public void End()
    {
        Console.WriteLine("Game ended");
        Players.Clear();
    }
}

class Program12
{
    static void Main()
    {
        Game game = new Game { Title = "Chess", MaxPlayers = 2 };
        game.Initialize();
        game.AddPlayer("Alice");
        game.AddPlayer("Bob");
        game.Start();
        game.End();
    }
}

// 13
 

public partial class Database
{
    public string ConnectionString { get; set; }
    public bool IsConnected { get; private set; }
}

public partial class Database
{
    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine($"Connected to: {ConnectionString}");
    }

    public void Disconnect()
    {
        IsConnected = false;
        Console.WriteLine("Disconnected");
    }

    public void ExecuteQuery(string sql)
    {
        if (IsConnected)
            Console.WriteLine($"Executing: {sql}");
        else
            Console.WriteLine("Not connected");
    }

    public List<string> FetchData(string table)
    {
        if (IsConnected)
        {
            Console.WriteLine($"Fetching from {table}");
            return new List<string> { "row1", "row2" };
        }
        return new List<string>();
    }
}

class Program13
{
    static void Main()
    {
        Database db = new Database { ConnectionString = "Server=localhost;Database=test" };
        db.Connect();
        db.ExecuteQuery("SELECT * FROM Users");
        db.FetchData("Users");
        db.Disconnect();
    }
}

// 14
 

public partial class Logger
{
    public string LogFilePath { get; set; }
}

public partial class Logger
{
    public void LogToFile(string message)
    {
        string log = $"{DateTime.Now}: {message}";
        try
        {
            File.AppendAllText(LogFilePath, log + Environment.NewLine);
            Console.WriteLine($"Logged to file: {message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"File log error: {ex.Message}");
        }
    }

    public void LogToConsole(string message)
    {
        Console.WriteLine($"[CONSOLE] {DateTime.Now}: {message}");
    }

    public void Log(string message)
    {
        LogToConsole(message);
        LogToFile(message);
    }
}

class Program14
{
    static void Main()
    {
        Logger logger = new Logger { LogFilePath = "app.log" };
        logger.Log("Application started");
        logger.Log("User logged in");
    }
}

// 15
 

public partial class Configuration
{
    public string AppName { get; set; }
    public int Timeout { get; set; }
    public bool EnableLogging { get; set; }
    public string Theme { get; set; }
}

public partial class Configuration
{
    public void LoadFromFile(string path)
    {
        try
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    switch (key)
                    {
                        case "AppName": AppName = value; break;
                        case "Timeout": Timeout = int.Parse(value); break;
                        case "EnableLogging": EnableLogging = bool.Parse(value); break;
                        case "Theme": Theme = value; break;
                    }
                }
            }
            Console.WriteLine("Configuration loaded");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Load error: {ex.Message}");
        }
    }

    public void SaveToFile(string path)
    {
        string[] lines = {
            $"AppName={AppName}",
            $"Timeout={Timeout}",
            $"EnableLogging={EnableLogging}",
            $"Theme={Theme}"
        };
        File.WriteAllLines(path, lines);
        Console.WriteLine("Configuration saved");
    }
}

class Program15
{
    static void Main()
    {
        Configuration config = new Configuration();
        config.LoadFromFile("config.txt");
        config.SaveToFile("config_backup.txt");
    }
}



// 16
 

public partial class DataValidator
{
    partial void OnValidation(string data);

    public bool Validate(string data)
    {
        Console.WriteLine($"Validating: {data}");
        OnValidation(data);
        return !string.IsNullOrEmpty(data);
    }
}

public partial class DataValidator
{
    partial void OnValidation(string data)
    {
        Console.WriteLine($"Custom validation for: {data}");
    }
}

class Program16
{
    static void Main()
    {
        DataValidator validator = new DataValidator();
        validator.Validate("test");
    }
}

// 17
 

public partial class Logger
{
    partial void OnError(string message, Exception ex);

    public void LogError(string message, Exception ex)
    {
        Console.WriteLine($"Error: {message}");
        OnError(message, ex);
    }
}

public partial class Logger
{
    partial void OnError(string message, Exception ex)
    {
        Console.WriteLine($"Detailed error: {ex.Message}");
    }
}

class Program17
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.LogError("File not found", new FileNotFoundException());
    }
}

// 18
 

public partial class NotificationObject
{
    partial void OnPropertyChanged(string propertyName);

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
}

public partial class NotificationObject
{
    partial void OnPropertyChanged(string propertyName)
    {
        Console.WriteLine($"Property {propertyName} changed to {_name}");
    }
}

class Program18
{
    static void Main()
    {
        NotificationObject obj = new NotificationObject();
        obj.Name = "Test";
    }
}

// 19
 

public partial class Application
{
    partial void OnInitialize();

    public void Start()
    {
        Console.WriteLine("Application starting...");
        OnInitialize();
        Console.WriteLine("Application started");
    }
}

public partial class Application
{
    partial void OnInitialize()
    {
        Console.WriteLine("Custom initialization");
    }
}

class Program19
{
    static void Main()
    {
        Application app = new Application();
        app.Start();
    }
}

// 20
 

public partial class DataManager
{
    partial void OnDataLoaded(List<string> data);

    public List<string> LoadData()
    {
        Console.WriteLine("Loading data...");
        var data = new List<string> { "item1", "item2" };
        OnDataLoaded(data);
        return data;
    }
}

public partial class DataManager
{
    partial void OnDataLoaded(List<string> data)
    {
        Console.WriteLine($"Data loaded: {data.Count} items");
    }
}

class Program20
{
    static void Main()
    {
        DataManager manager = new DataManager();
        manager.LoadData();
    }
}

// 21
 

public partial class StateMachine
{
    partial void OnStateChanged(string oldState, string newState);

    private string _currentState = "Idle";
    public string CurrentState
    {
        get => _currentState;
        set
        {
            string old = _currentState;
            _currentState = value;
            OnStateChanged(old, _currentState);
        }
    }
}

public partial class StateMachine
{
    partial void OnStateChanged(string oldState, string newState)
    {
        Console.WriteLine($"State changed: {oldState} -> {newState}");
    }
}

class Program21
{
    static void Main()
    {
        StateMachine sm = new StateMachine();
        sm.CurrentState = "Running";
    }
}

// 22
 

public partial class Entity
{
    partial void OnBeforeSave();

    public void Save()
    {
        OnBeforeSave();
        Console.WriteLine("Entity saved to database");
    }
}

public partial class Entity
{
    partial void OnBeforeSave()
    {
        Console.WriteLine("Validating entity before save");
    }
}

class Program22
{
    static void Main()
    {
        Entity entity = new Entity();
        entity.Save();
    }
}

// 23
 

public partial class Repository
{
    partial void OnAfterDelete(int id);

    public void Delete(int id)
    {
        Console.WriteLine($"Deleting entity {id}");
        OnAfterDelete(id);
    }
}

public partial class Repository
{
    partial void OnAfterDelete(int id)
    {
        Console.WriteLine($"Cleanup after delete {id}");
    }
}

class Program23
{
    static void Main()
    {
        Repository repo = new Repository();
        repo.Delete(42);
    }
}

// 24
 

public partial class DataProcessor
{
    partial void OnProcessing(int progress);

    public void Process()
    {
        for (int i = 0; i <= 100; i += 20)
        {
            OnProcessing(i);
            System.Threading.Thread.Sleep(100);
        }
    }
}

public partial class DataProcessor
{
    partial void OnProcessing(int progress)
    {
        Console.WriteLine($"Processing: {progress}%");
    }
}

class Program24
{
    static void Main()
    {
        DataProcessor processor = new DataProcessor();
        processor.Process();
    }
}

// 25
 

public partial class Connection
{
    partial void OnConnectionOpened();

    public void Open()
    {
        Console.WriteLine("Opening connection...");
        OnConnectionOpened();
    }
}

public partial class Connection
{
    partial void OnConnectionOpened()
    {
        Console.WriteLine("Connection established");
    }
}

class Program25
{
    static void Main()
    {
        Connection conn = new Connection();
        conn.Open();
    }
}

// 26
 

public partial class Authenticator
{
    partial void OnAuthenticationFailed(string reason);

    public bool Authenticate(string user, string pass)
    {
        bool success = user == "admin" && pass == "123";
        if (!success)
            OnAuthenticationFailed("Invalid credentials");
        return success;
    }
}

public partial class Authenticator
{
    partial void OnAuthenticationFailed(string reason)
    {
        Console.WriteLine($"Auth failed: {reason}");
    }
}

class Program26
{
    static void Main()
    {
        Authenticator auth = new Authenticator();
        auth.Authenticate("user", "wrong");
    }
}

// 27
 

public partial class Cache
{
    partial void OnCacheExpired(string key);

    public void Invalidate(string key)
    {
        Console.WriteLine($"Invalidating {key}");
        OnCacheExpired(key);
    }
}

public partial class Cache
{
    partial void OnCacheExpired(string key)
    {
        Console.WriteLine($"Cache expired for {key}");
    }
}

class Program27
{
    static void Main()
    {
        Cache cache = new Cache();
        cache.Invalidate("userData");
    }
}

// 28
 

public partial class RetryPolicy
{
    partial void OnRetry(int attempt);

    public bool ExecuteWithRetry(Func<bool> action, int maxAttempts)
    {
        for (int i = 1; i <= maxAttempts; i++)
        {
            if (action())
                return true;
            OnRetry(i);
        }
        return false;
    }
}

public partial class RetryPolicy
{
    partial void OnRetry(int attempt)
    {
        Console.WriteLine($"Retry attempt {attempt}");
    }
}

class Program28
{
    static void Main()
    {
        RetryPolicy policy = new RetryPolicy();
        policy.ExecuteWithRetry(() => false, 3);
    }
}

// 29
 

public partial class Request
{
    partial void OnTimeout();

    public void Send()
    {
        Console.WriteLine("Sending request...");
        System.Threading.Thread.Sleep(6000);
        OnTimeout();
    }
}

public partial class Request
{
    partial void OnTimeout()
    {
        Console.WriteLine("Request timed out");
    }
}

class Program29
{
    static void Main()
    {
        Request req = new Request();
        req.Send();
    }
}

// 30
 

public partial class AsyncTask
{
    partial void OnCompleted(bool success);

    public async Task RunAsync()
    {
        await Task.Delay(1000);
        bool success = true;
        OnCompleted(success);
    }
}

public partial class AsyncTask
{
    partial void OnCompleted(bool success)
    {
        Console.WriteLine($"Task completed: {(success ? "Success" : "Failed")}");
    }
}

class Program30
{
    static async Task Main()
    {
        AsyncTask task = new AsyncTask();
        await task.RunAsync();
    }
}



// 31
 

public class Circle
{
    public readonly double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area => Math.PI * Radius * Radius;
    public double Circumference => 2 * Math.PI * Radius;
}

class Program31
{
    static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine($"Area: {c.Area:F2}");
    }
}

// 32
 

public class Point
{
    public readonly double X;
    public readonly double Y;

    public Point(double x, double y)
    {
        X = x; Y = y;
    }

    public double DistanceToOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program32
{
    static void Main()
    {
        Point p = new Point(3, 4);
        Console.WriteLine($"Distance: {p.DistanceToOrigin()}");
    }
}

// 33
 

public class Color
{
    public readonly byte Red;
    public readonly byte Green;
    public readonly byte Blue;

    public Color(byte r, byte g, byte b)
    {
        Red = r; Green = g; Blue = b;
    }

    public string Hex => $"#{Red:X2}{Green:X2}{Blue:X2}";
}

class Program33
{
    static void Main()
    {
        Color c = new Color(255, 87, 51);
        Console.WriteLine(c.Hex);
    }
}

// 34
 

public class Vector
{
    public readonly double Magnitude;

    public Vector(double x, double y)
    {
        Magnitude = Math.Sqrt(x * x + y * y);
    }
}

class Program34
{
    static void Main()
    {
        Vector v = new Vector(3, 4);
        Console.WriteLine($"Magnitude: {v.Magnitude}");
    }
}

// 35
 

public class Complex
{
    public readonly double Real;
    public readonly double Imaginary;

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public double Magnitude => Math.Sqrt(Real * Real + Imaginary * Imaginary);
}

class Program35
{
    static void Main()
    {
        Complex c = new Complex(3, 4);
        Console.WriteLine($"Magnitude: {c.Magnitude}");
    }
}

// 36
 

public class Fraction
{
    public readonly int Numerator;
    public readonly int Denominator;

    public Fraction(int num, int den)
    {
        if (den == 0) throw new ArgumentException("Denominator cannot be zero");
        Numerator = num;
        Denominator = den;
    }

    public double ToDouble() => (double)Numerator / Denominator;
}

class Program36
{
    static void Main()
    {
        Fraction f = new Fraction(3, 4);
        Console.WriteLine(f.ToDouble());
    }
}

// 37
 

public class Date
{
    public readonly int Day;
    public readonly int Month;
    public readonly int Year;

    public Date(int day, int month, int year)
    {
        Day = day; Month = month; Year = year;
    }

    public override string ToString() => $"{Day:D2}/{Month:D2}/{Year}";
}

class Program37
{
    static void Main()
    {
        Date d = new Date(25, 12, 2025);
        Console.WriteLine(d);
    }
}

// 38
 

public class Time
{
    public readonly int Hours;
    public readonly int Minutes;
    public readonly int Seconds;

    public Time(int h, int m, int s)
    {
        Hours = h; Minutes = m; Seconds = s;
    }

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
}

class Program38
{
    static void Main()
    {
        Time t = new Time(14, 30, 45);
        Console.WriteLine(t);
    }
}

// 39
 

public class Money
{
    public readonly decimal Amount;
    public readonly string Currency;

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override string ToString() => $"{Amount:C} {Currency}";
}

class Program39
{
    static void Main()
    {
        Money m = new Money(100.50m, "USD");
        Console.WriteLine(m);
    }
}

// 40
 

public class Range
{
    public readonly double Min;
    public readonly double Max;

    public Range(double min, double max)
    {
        Min = min; Max = max;
    }

    public bool Contains(double value) => value >= Min && value <= Max;
}

class Program40
{
    static void Main()
    {
        Range r = new Range(0, 100);
        Console.WriteLine(r.Contains(50));
    }
}

// 41
 

public class Rectangle
{
    public readonly double Width;
    public readonly double Height;

    public Rectangle(double w, double h)
    {
        Width = w; Height = h;
    }

    public double Area => Width * Height;
}

class Program41
{
    static void Main()
    {
        Rectangle r = new Rectangle(10, 5);
        Console.WriteLine($"Area: {r.Area}");
    }
}

// 42
 

public class Triangle
{
    public readonly double SideA;
    public readonly double SideB;
    public readonly double SideC;

    public Triangle(double a, double b, double c)
    {
        SideA = a; SideB = b; SideC = c;
    }

    public double Perimeter => SideA + SideB + SideC;
}

class Program42
{
    static void Main()
    {
        Triangle t = new Triangle(3, 4, 5);
        Console.WriteLine($"Perimeter: {t.Perimeter}");
    }
}

// 43
 

public class Coordinates
{
    public readonly double Latitude;
    public readonly double Longitude;

    public Coordinates(double lat, double lon)
    {
        Latitude = lat; Longitude = lon;
    }

    public override string ToString() => $"({Latitude}, {Longitude})";
}

class Program43
{
    static void Main()
    {
        Coordinates c = new Coordinates(40.7128, -74.0060);
        Console.WriteLine(c);
    }
}

// 44
 

public class Version
{
    public readonly int Major;
    public readonly int Minor;
    public readonly int Patch;

    public Version(int major, int minor, int patch)
    {
        Major = major; Minor = minor; Patch = patch;
    }

    public override string ToString() => $"{Major}.{Minor}.{Patch}";
}

class Program44
{
    static void Main()
    {
        Version v = new Version(1, 0, 0);
        Console.WriteLine(v);
    }
}

// 45
 

public class Interval
{
    public readonly DateTime Start;
    public readonly DateTime End;

    public Interval(DateTime start, DateTime end)
    {
        Start = start; End = end;
    }

    public TimeSpan Duration => End - Start;
}

class Program45
{
    static void Main()
    {
        Interval i = new Interval(DateTime.Now, DateTime.Now.AddHours(2));
        Console.WriteLine($"Duration: {i.Duration}");
    }
}

// 46
 

public class Matrix
{
    public readonly int Order;

    public Matrix(int order)
    {
        Order = order;
    }

    public int Size => Order * Order;
}

class Program46
{
    static void Main()
    {
        Matrix m = new Matrix(3);
        Console.WriteLine($"Size: {m.Size}");
    }
}

// 47
 

public class Person
{
    public readonly DateTime BirthDate;

    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
    }

    public int Age => (DateTime.Now - BirthDate).Days / 365;
}

class Program47
{
    static void Main()
    {
        Person p = new Person(new DateTime(1990, 1, 1));
        Console.WriteLine($"Age: {p.Age}");
    }
}

// 48
 

public class Employee
{
    public readonly int EmployeeID;

    public Employee(int id)
    {
        EmployeeID = id;
    }
}

class Program48
{
    static void Main()
    {
        Employee e = new Employee(1001);
        Console.WriteLine($"ID: {e.EmployeeID}");
    }
}

// 49
 

public class Document
{
    public readonly Guid DocumentID;
    public readonly DateTime CreatedDate;

    public Document()
    {
        DocumentID = Guid.NewGuid();
        CreatedDate = DateTime.Now;
    }
}

class Program49
{
    static void Main()
    {
        Document d = new Document();
        Console.WriteLine($"ID: {d.DocumentID}, Created: {d.CreatedDate}");
    }
}

// 50
 

public class ISBN
{
    public readonly string Code;

    public ISBN(string code)
    {
        Code = code;
    }
}

class Program50
{
    static void Main()
    {
        ISBN isbn = new ISBN("978-3-16-148410-0");
        Console.WriteLine(isbn.Code);
    }
}



// 51
 

public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }

    public decimal GetBalance() => balance;
}

class Program51
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Withdraw(500);
        Console.WriteLine($"Balance: {acc.GetBalance():C}");
    }
}

// 52
 

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get => name;
        set => name = value ?? "";
    }

    public int Age
    {
        get => age;
        set => age = value >= 0 ? value : 0;
    }
}

class Program52
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "John";
        p.Age = 30;
        Console.WriteLine($"{p.Name}, {p.Age}");
    }
}

// 53
 

public class Password
{
    private string value;

    private bool IsValid(string pwd)
    {
        return pwd.Length >= 8 && pwd.Any(char.IsUpper) && pwd.Any(char.IsDigit);
    }

    public void SetPassword(string pwd)
    {
        if (IsValid(pwd))
            value = pwd;
        else
            throw new ArgumentException("Invalid password");
    }
}

class Program53
{
    static void Main()
    {
        Password p = new Password();
        p.SetPassword("Pass1234");
    }
}

// 54
 


public class Email
{
    private string address;

    private bool IsValid(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public void SetEmail(string email)
    {
        if (IsValid(email))
            address = email;
        else
            throw new ArgumentException("Invalid email");
    }

    public string GetEmail() => address;
}

class Program54
{
    static void Main()
    {
        Email e = new Email();
        e.SetEmail("test@example.com");
        Console.WriteLine(e.GetEmail());
    }
}

// 55
 

public class Temperature
{
    private double celsius;

    public double Celsius
    {
        get => celsius;
        set => celsius = value;
    }

    public double Fahrenheit
    {
        get => celsius * 9.0 / 5.0 + 32;
        set => celsius = (value - 32) * 5.0 / 9.0;
    }
}

class Program55
{
    static void Main()
    {
        Temperature t = new Temperature();
        t.Celsius = 25;
        Console.WriteLine($"F: {t.Fahrenheit}");
        t.Fahrenheit = 77;
        Console.WriteLine($"C: {t.Celsius}");
    }
}


// 56
 

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program56
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();
    }
}

// 57
 

public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car engine started");
    }
}

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle engine started");
    }
}

class Program57
{
    static void Main()
    {
        Car c = new Car(); c.Start();
        Motorcycle m = new Motorcycle(); m.Start();
    }
}

// 58
 

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area() => Width * Height;
}

class Program58
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        Rectangle r = new Rectangle { Width = 4, Height = 6 };
        Console.WriteLine($"Circle area: {c.Area():F2}");
        Console.WriteLine($"Rectangle area: {r.Area()}");
    }
}

// 59
 

public class Employee
{
    public string Name { get; set; }
    public virtual decimal CalculateSalary() => 50000m;
}

public class Manager : Employee
{
    public override decimal CalculateSalary() => 80000m + 20000m;
}

public class Developer : Employee
{
    public override decimal CalculateSalary() => 70000m;
}

class Program59
{
    static void Main()
    {
        Manager m = new Manager(); m.Name = "John";
        Developer d = new Developer(); d.Name = "Jane";
        Console.WriteLine($"{m.Name}: {m.CalculateSalary():C}");
        Console.WriteLine($"{d.Name}: {d.CalculateSalary():C}");
    }
}

// 60
 

public class Account
{
    public decimal Balance { get; protected set; }
    public virtual void Deposit(decimal amount) => Balance += amount;
}

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; } = 0.02m;
    public void AddInterest() => Balance += Balance * InterestRate;
}

public class CheckingAccount : Account
{
    public decimal OverdraftLimit { get; set; } = 500m;
    public override void Deposit(decimal amount) => Balance += amount;
}

class Program60
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount();
        s.Deposit(1000);
        s.AddInterest();
        Console.WriteLine($"Savings: {s.Balance:C}");
    }
}



// 61
 

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program61
{
    static void Main()
    {
        Animal[] animals = { new Dog(), new Cat(), new Animal() };
        foreach (var a in animals)
            a.MakeSound();
    }
}

// 62
 

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

class Program62
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        Console.WriteLine($"Area: {c.CalculateArea():F2}");
    }
}

// 63
 

public interface IPayable
{
    decimal CalculatePayment();
}

public class Employee : IPayable
{
    public decimal Salary { get; set; }
    public decimal CalculatePayment() => Salary;
}

public class Contractor : IPayable
{
    public decimal HourlyRate { get; set; }
    public int Hours { get; set; }
    public decimal CalculatePayment() => HourlyRate * Hours;
}

class Program63
{
    static void Main()
    {
        IPayable[] payees = {
            new Employee { Salary = 5000m },
            new Contractor { HourlyRate = 50m, Hours = 160 }
        };
        foreach (var p in payees)
            Console.WriteLine($"Payment: {p.CalculatePayment():C}");
    }
}

// 64
 

public class Product
{
    public virtual decimal Price => 100m;
}

public class DigitalProduct : Product
{
    public override decimal Price => 50m;
}

class Program64
{
    static void Main()
    {
        Product p1 = new Product();
        Product p2 = new DigitalProduct();
        Console.WriteLine($"Regular: {p1.Price:C}, Digital: {p2.Price:C}");
    }
}

// 65
 

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area() => Width * Height;
}

class Program65
{
    static void Main()
    {
        Shape[] shapes = {
            new Circle { Radius = 5 },
            new Rectangle { Width = 4, Height = 6 },
            new Circle { Radius = 3 }
        };
        double total = 0;
        foreach (var s in shapes)
            total += s.Area();
        Console.WriteLine($"Total area: {total:F2}");
    }
}



// 66
 

public abstract class DatabaseConnection
{
    public abstract void Connect();
    public abstract void Disconnect();
    public abstract void Execute(string query);
}

public class SqlConnection : DatabaseConnection
{
    public override void Connect() => Console.WriteLine("SQL Connected");
    public override void Disconnect() => Console.WriteLine("SQL Disconnected");
    public override void Execute(string query) => Console.WriteLine($"SQL: {query}");
}

class Program66
{
    static void Main()
    {
        DatabaseConnection conn = new SqlConnection();
        conn.Connect();
        conn.Execute("SELECT * FROM Users");
        conn.Disconnect();
    }
}

// 67
 

public interface IRepository<T>
{
    void Add(T entity);
    T Get(int id);
    IEnumerable<T> GetAll();
    void Update(T entity);
    void Delete(int id);
}

public class UserRepository : IRepository<User>
{
    private List<User> users = new();
    public void Add(User entity) => users.Add(entity);
    public User Get(int id) => users.Find(u => u.Id == id);
    public IEnumerable<User> GetAll() => users;
    public void Update(User entity) { }
    public void Delete(int id) => users.RemoveAll(u => u.Id == id);
}

public class User { public int Id { get; set; } public string Name { get; set; } }

class Program67
{
    static void Main()
    {
        IRepository<User> repo = new UserRepository();
        repo.Add(new User { Id = 1, Name = "John" });
    }
}

// 68
 

public abstract class Logger
{
    public abstract void Log(string message);
    public abstract void LogError(string message, Exception ex);
}

public class ConsoleLogger : Logger
{
    public override void Log(string message) => Console.WriteLine(message);
    public override void LogError(string message, Exception ex) => Console.WriteLine($"ERROR: {message} - {ex.Message}");
}

class Program68
{
    static void Main()
    {
        Logger logger = new ConsoleLogger();
        logger.Log("App started");
        logger.LogError("Failed", new Exception("Test"));
    }
}

// 69
 

public interface IValidator<T>
{
    bool Validate(T entity);
    IEnumerable<string> GetErrors(T entity);
}

public class UserValidator : IValidator<User>
{
    public bool Validate(User entity) => !string.IsNullOrEmpty(entity.Name);
    public IEnumerable<string> GetErrors(User entity)
    {
        if (string.IsNullOrEmpty(entity.Name))
            yield return "Name is required";
    }
}

class Program69
{
    static void Main()
    {
        IValidator<User> validator = new UserValidator();
        User user = new User { Name = "" };
        Console.WriteLine(validator.Validate(user));
    }
}

// 70
 

public abstract class PaymentProcessor
{
    public abstract bool ProcessPayment(decimal amount, string currency);
    public abstract bool Refund(string transactionId);
}

public class StripeProcessor : PaymentProcessor
{
    public override bool ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Stripe: Processing {amount:C} {currency}");
        return true;
    }

    public override bool Refund(string transactionId)
    {
        Console.WriteLine($"Stripe: Refunding {transactionId}");
        return true;
    }
}

class Program70
{
    static void Main()
    {
        PaymentProcessor processor = new StripeProcessor();
        processor.ProcessPayment(100m, "USD");
    }
}



// 71
 
 

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public int CopiesAvailable { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
    public List<Author> Authors { get; set; } = new();

    public void AddBook(Book book) => Books.Add(book);
    public Book FindBook(string title) => Books.Find(b => b.Title.Contains(title));
}

class Program71
{
    static void Main()
    {
        Library lib = new Library { Name = "City Library" };
        Author author = new Author { Id = 1, Name = "Orwell" };
        Book book = new Book { Id = 1, Title = "1984", Author = author, CopiesAvailable = 5 };
        lib.AddBook(book);
    }
}

// 72 
 
 

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new();
}

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new();
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; } = new();
}

class Program72
{
    static void Main()
    {
        Course math = new Course { Id = 1, Name = "Math" };
        Teacher t = new Teacher { Id = 1, Name = "Smith" };
        Student s = new Student { Id = 1, Name = "John" };
        math.Teacher = t;
        math.Students.Add(s);
        s.Courses.Add(math);
    }
}

// 73 
 
 

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; } = new();
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Order> Orders { get; set; } = new();
}

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; } = new();
}

class Program73
{
    static void Main()
    {
        Customer c = new Customer { Id = 1, Name = "Alice" };
        Product p = new Product { Id = 1, Name = "Laptop", Price = 1000m };
        Order o = new Order { Id = 1, Date = DateTime.Now, Customer = c };
        o.Products.Add(p);
        c.Orders.Add(o);
    }
}

// 74
 
 

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Task> Tasks { get; set; } = new();
    public Team Team { get; set; }
}

public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public Project Project { get; set; }
}

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Project> Projects { get; set; } = new();
}

class Program74
{
    static void Main()
    {
        Team team = new Team { Id = 1, Name = "DevTeam" };
        Project proj = new Project { Id = 1, Name = "Website", Team = team };
        Task task = new Task { Id = 1, Description = "Design", Project = proj };
        proj.Tasks.Add(task);
    }
}

// 75 
 
 

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public List<Appointment> Appointments { get; set; } = new();
}

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Appointment> Appointments { get; set; } = new();
}

public class Appointment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
}

class Program75
{
    static void Main()
    {
        Doctor d = new Doctor { Id = 1, Name = "Smith", Specialty = "Cardiology" };
        Patient p = new Patient { Id = 1, Name = "John" };
        Appointment a = new Appointment { Id = 1, Date = DateTime.Now, Doctor = d, Patient = p };
        d.Appointments.Add(a);
        p.Appointments.Add(a);
    }
}

// 76
 
 

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Inventory Inventory { get; set; }
}

public class Inventory
{
    public int Id { get; set; }
    public Character Owner { get; set; }
    public List<Item> Items { get; set; } = new();
}

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Inventory> Inventories { get; set; } = new();
}

class Program76
{
    static void Main()
    {
        Character c = new Character { Id = 1, Name = "Hero" };
        Inventory inv = new Inventory { Id = 1, Owner = c };
        Item sword = new Item { Id = 1, Name = "Sword" };
        inv.Items.Add(sword);
        c.Inventory = inv;
    }
}

// 77 
 
 

public class Menu
{
    public int Id { get; set; }
    public List<Dish> Dishes { get; set; } = new();
}

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Menu Menu { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public List<Dish> Dishes { get; set; } = new();
}

class Program77
{
    static void Main()
    {
        Menu menu = new Menu { Id = 1 };
        Dish pizza = new Dish { Id = 1, Name = "Pizza", Price = 12.99m, Menu = menu };
        Order order = new Order { Id = 1 };
        order.Dishes.Add(pizza);
        menu.Dishes.Add(pizza);
    }
}

// 78 
 
 

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Room> Rooms { get; set; } = new();
}

public class Room
{
    public int Id { get; set; }
    public int Number { get; set; }
    public Hotel Hotel { get; set; }
    public List<Booking> Bookings { get; set; } = new();
}

public class Booking
{
    public int Id { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public Room Room { get; set; }
}

class Program78
{
    static void Main()
    {
        Hotel h = new Hotel { Id = 1, Name = "Grand Hotel" };
        Room r = new Room { Id = 1, Number = 101, Hotel = h };
        Booking b = new Booking { Id = 1, CheckIn = DateTime.Today, CheckOut = DateTime.Today.AddDays(3), Room = r };
        r.Bookings.Add(b);
        h.Rooms.Add(r);
    }
}

// 79 
 
 

public class Vehicle
{
    public int Id { get; set; }
    public string LicensePlate { get; set; }
    public List<Route> Routes { get; set; } = new();
}

public class Driver
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Route> Routes { get; set; } = new();
}

public class Route
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Vehicle Vehicle { get; set; }
    public Driver Driver { get; set; }
}

class Program79
{
    static void Main()
    {
        Vehicle v = new Vehicle { Id = 1, LicensePlate = "ABC-123" };
        Driver d = new Driver { Id = 1, Name = "John" };
        Route r = new Route { Id = 1, Name = "City Route", Vehicle = v, Driver = d };
        v.Routes.Add(r);
        d.Routes.Add(r);
    }
}

// 80 
 
 

public class Bank
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Account> Accounts { get; set; } = new();
}

public class Account
{
    public int Id { get; set; }
    public string Number { get; set; }
    public Bank Bank { get; set; }
    public List<Transaction> Transactions { get; set; } = new();
}

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Account Account { get; set; }
}

class Program80
{
    static void Main()
    {
        Bank b = new Bank { Id = 1, Name = "National Bank" };
        Account a = new Account { Id = 1, Number = "123456", Bank = b };
        Transaction t = new Transaction { Id = 1, Amount = 1000m, Date = DateTime.Now, Account = a };
        a.Transactions.Add(t);
        b.Accounts.Add(a);
    }
}

// 81 
 
 

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Grade> Grades { get; set; } = new();
}

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Grade> Grades { get; set; } = new();
}

public class Grade
{
    public int Id { get; set; }
    public int Value { get; set; }
    public Student Student { get; set; }
    public Subject Subject { get; set; }
}

class Program81
{
    static void Main()
    {
        Student s = new Student { Id = 1, Name = "Alice" };
        Subject math = new Subject { Id = 1, Name = "Math" };
        Grade g = new Grade { Id = 1, Value = 95, Student = s, Subject = math };
        s.Grades.Add(g);
        math.Grades.Add(g);
    }
}

// 82
 
 

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Attendee> Attendees { get; set; } = new();
}

public class Attendee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Event> Events { get; set; } = new();
}

public class Venue
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Event> Events { get; set; } = new();
}

class Program82
{
    static void Main()
    {
        Event e = new Event { Id = 1, Name = "Conference" };
        Attendee a = new Attendee { Id = 1, Name = "John" };
        Venue v = new Venue { Id = 1, Name = "Hall A" };
        e.Attendees.Add(a);
        a.Events.Add(e);
    }
}

// 83 
 
 

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public List<Post> Posts { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();
}

public class Post
{
    public int Id { get; set; }
    public string Content { get; set; }
    public User Author { get; set; }
    public List<Comment> Comments { get; set; } = new();
}

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public User Author { get; set; }
    public Post Post { get; set; }
}

class Program83
{
    static void Main()
    {
        User u = new User { Id = 1, Username = "alice" };
        Post p = new Post { Id = 1, Content = "Hello", Author = u };
        Comment c = new Comment { Id = 1, Text = "Hi!", Author = u, Post = p };
        p.Comments.Add(c);
        u.Posts.Add(p);
        u.Comments.Add(c);
    }
}

// 84 
 
 

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Player> Players { get; set; } = new();
    public List<Match> Matches { get; set; } = new();
}

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Team Team { get; set; }
}

public class Match
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Team HomeTeam { get; set; }
    public Team AwayTeam { get; set; }
}

class Program84
{
    static void Main()
    {
        Team t1 = new Team { Id = 1, Name = "Lakers" };
        Team t2 = new Team { Id = 2, Name = "Bulls" };
        Player p = new Player { Id = 1, Name = "Jordan", Team = t2 };
        Match m = new Match { Id = 1, Date = DateTime.Today, HomeTeam = t1, AwayTeam = t2 };
        t1.Matches.Add(m);
        t2.Matches.Add(m);
        t2.Players.Add(p);
    }
}

// 85 
 
 

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Actor> Actors { get; set; } = new();
}

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Movie> Movies { get; set; } = new();
}

public class Cinema
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Movie> Screening { get; set; } = new();
}

class Program85
{
    static void Main()
    {
        Movie m = new Movie { Id = 1, Title = "Inception" };
        Actor a = new Actor { Id = 1, Name = "DiCaprio" };
        Cinema c = new Cinema { Id = 1, Name = "AMC" };
        m.Actors.Add(a);
        a.Movies.Add(m);
        c.Screening.Add(m);
    }
}


// 86
 

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Person Manager { get; set; }
}

class Program86
{
    static void Main()
    {
        Person manager = new Person { Id = 1, Name = "Boss" };
        Person employee = new Person { Id = 2, Name = "John", Manager = manager };
        Console.WriteLine($"{employee.Name}'s manager: {employee.Manager.Name}");
    }
}

// 87
 

public class Node
{
    public int Id { get; set; }
    public Node Parent { get; set; }
    public List<Node> Children { get; set; } = new();
}

class Program87
{
    static void Main()
    {
        Node root = new Node { Id = 1 };
        Node child = new Node { Id = 2, Parent = root };
        root.Children.Add(child);
    }
}

// 88
 

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee Manager { get; set; }
    public List<Employee> Subordinates { get; set; } = new();
}

class Program88
{
    static void Main()
    {
        Employee mgr = new Employee { Id = 1, Name = "Alice" };
        Employee emp = new Employee { Id = 2, Name = "Bob", Manager = mgr };
        mgr.Subordinates.Add(emp);
    }
}

// 89
 

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Parent { get; set; }
    public List<Category> Subcategories { get; set; } = new();
}

class Program89
{
    static void Main()
    {
        Category electronics = new Category { Id = 1, Name = "Electronics" };
        Category phones = new Category { Id = 2, Name = "Phones", Parent = electronics };
        electronics.Subcategories.Add(phones);
    }
}

// 90
 

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
}

class Program90
{
    static void Main()
    {
        TreeNode root = new TreeNode { Value = 1 };
        root.Left = new TreeNode { Value = 2 };
        root.Right = new TreeNode { Value = 3 };
    }
}

// 91
 

public class LinkedListNode
{
    public int Value { get; set; }
    public LinkedListNode Next { get; set; }
}

class Program91
{
    static void Main()
    {
        LinkedListNode head = new LinkedListNode { Value = 1 };
        head.Next = new LinkedListNode { Value = 2 };
        head.Next.Next = new LinkedListNode { Value = 3 };
    }
}



// 92
 
 

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; } = new();
}

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Student> Students { get; set; } = new();
}

class Program92
{
    static void Main()
    {
        Student s = new Student { Id = 1, Name = "John" };
        Course c = new Course { Id = 1, Title = "Math" };
        s.Courses.Add(c);
        c.Students.Add(s);
    }
}

// 93
 
 

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Patient> Patients { get; set; } = new();
}

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Doctor PrimaryDoctor { get; set; }
}

class Program93
{
    static void Main()
    {
        Doctor d = new Doctor { Id = 1, Name = "Smith" };
        Patient p = new Patient { Id = 1, Name = "John", PrimaryDoctor = d };
        d.Patients.Add(p);
    }
}

// 94
 
 

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
}

class Program94
{
    static void Main()
    {
        Author a = new Author { Id = 1, Name = "Orwell" };
        Book b = new Book { Id = 1, Title = "1984", Author = a };
        a.Books.Add(b);
    }
}

// 95
 
 

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Class> Classes { get; set; } = new();
}

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
}

class Program95
{
    static void Main()
    {
        Teacher t = new Teacher { Id = 1, Name = "Brown" };
        Class c = new Class { Id = 1, Name = "10A", Teacher = t };
        t.Classes.Add(c);
    }
}

// 96
 
 

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new();
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Company Company { get; set; }
}

class Program96
{
    static void Main()
    {
        Company comp = new Company { Id = 1, Name = "TechCorp" };
        Employee emp = new Employee { Id = 1, Name = "Alice", Company = comp };
        comp.Employees.Add(emp);
    }
}

// 97
 
 

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Library Library { get; set; }
}

class Program97
{
    static void Main()
    {
        Library lib = new Library { Id = 1, Name = "City Library" };
        Book b = new Book { Id = 1, Title = "C# Guide", Library = lib };
        lib.Books.Add(b);
    }
}

// 98
 
 

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Player> Players { get; set; } = new();
}

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Team Team { get; set; }
}

class Program98
{
    static void Main()
    {
        Team t = new Team { Id = 1, Name = "Warriors" };
        Player p = new Player { Id = 1, Name = "Curry", Team = t };
        t.Players.Add(p);
    }
}

// 99
 
 

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = new();
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; } = new();
}

class Program99
{
    static void Main()
    {
        Order o = new Order { Id = 1 };
        Product p = new Product { Id = 1, Name = "Laptop" };
        o.Products.Add(p);
        p.Orders.Add(o);
    }
}

// 100
 
 

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Developer> Developers { get; set; } = new();
}

public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Project> Projects { get; set; } = new();
}

class Program100
{
    static void Main()
    {
        Project proj = new Project { Id = 1, Name = "WebApp" };
        Developer dev = new Developer { Id = 1, Name = "Alice" };
        proj.Developers.Add(dev);
        dev.Projects.Add(proj);
    }
}