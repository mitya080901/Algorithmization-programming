//   1
using System;
using System.Text.RegularExpressions;

class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}

class Program1
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound();
    }
}

//   2
using System;

class Car
{
    public string Brand;
    public string Model;
    public int Year;

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
    }
}

class Program2
{
    static void Main()
    {
        Car car = new Car();
        car.Brand = "Toyota";
        car.Model = "Camry";
        car.Year = 2023;
        car.DisplayInfo();
    }
}

//   3
using System;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}, {Age} years old.");
    }
}

class Program3
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Alice";
        person.Age = 30;
        person.Introduce();
    }
}

//   4
using System;

class Rectangle
{
    public double Width;
    public double Height;

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program4
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5.5;
        rect.Height = 3.2;
        Console.WriteLine($"Area: {rect.Area()}");
        Console.WriteLine($"Perimeter: {rect.Perimeter()}");
    }
}

//   5
using System;

class Student
{
    public string Name;
    public int Age;
    public double GPA;
}

class Program5
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Ivan";
        student1.Age = 20;
        student1.GPA = 4.5;

        Student student2 = new Student();
        student2.Name = "Maria";
        student2.Age = 19;
        student2.GPA = 4.8;

        Console.WriteLine($"Student 1: {student1.Name}, Age: {student1.Age}, GPA: {student1.GPA}");
        Console.WriteLine($"Student 2: {student2.Name}, Age: {student2.Age}, GPA: {student2.GPA}");
    }
}

//   6
using System;

class Book
{
    public string Title;
    public string Author;
    public int Pages;

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title} by {Author}, Pages: {Pages}");
    }
}

class Program6
{
    static void Main()
    {
        Book book = new Book();
        book.Title = "C# Programming";
        book.Author = "John Doe";
        book.Pages = 500;
        book.DisplayInfo();
    }
}

//   7
using System;

class Circle
{
    public double Radius;

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program7
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Radius = 7.0;
        Console.WriteLine($"Area: {circle.Area():F2}");
        Console.WriteLine($"Circumference: {circle.Circumference():F2}");
    }
}

//   8
using System;

class BankAccount
{
    public decimal Balance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient funds");
    }
}

class Program8
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000m);
        account.Withdraw(300m);
        Console.WriteLine($"Balance: {account.Balance}");
    }
}

//   9
using System;

class Temperature
{
    public double Celsius;

    public double ToFahrenheit()
    {
        return Celsius * 9.0 / 5.0 + 32;
    }

    public double ToKelvin()
    {
        return Celsius + 273.15;
    }
}

class Program9
{
    static void Main()
    {
        Temperature temp = new Temperature();
        temp.Celsius = 25.0;
        Console.WriteLine($"Fahrenheit: {temp.ToFahrenheit():F1}");
        Console.WriteLine($"Kelvin: {temp.ToKelvin():F2}");
    }
}

//   10
using System;

class Time
{
    public int Hours;
    public int Minutes;
    public int Seconds;

    public string ToString12()
    {
        string period = Hours >= 12 ? "PM" : "AM";
        int displayHours = Hours % 12;
        if (displayHours == 0) displayHours = 12;
        return $"{displayHours:D2}:{Minutes:D2}:{Seconds:D2} {period}";
    }
}

class Program10
{
    static void Main()
    {
        Time time = new Time();
        time.Hours = 14;
        time.Minutes = 30;
        time.Seconds = 45;
        Console.WriteLine(time.ToString12());
    }
}

//   11
using System;

class Point
{
    public double X;
    public double Y;
    public double Z;

    public double DistanceToOrigin()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }
}

class Program11
{
    static void Main()
    {
        Point p = new Point();
        p.X = 3; p.Y = 4; p.Z = 5;
        Console.WriteLine($"Distance to origin: {p.DistanceToOrigin():F2}");
    }
}

//   12
using System;

class Color
{
    public byte R;
    public byte G;
    public byte B;

    public string ToHex()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
}

class Program12
{
    static void Main()
    {
        Color color = new Color();
        color.R = 255; color.G = 100; color.B = 50;
        Console.WriteLine($"Hex: {color.ToHex()}");
    }
}

//   13
using System;

class Email
{
    public string Address;
    public string Subject;
    public string Body;

    public void Send()
    {
        Console.WriteLine($"Email sent to {Address}");
    }
}

class Program13
{
    static void Main()
    {
        Email email = new Email();
        email.Address = "user@example.com";
        email.Subject = "Hello";
        email.Body = "This is a test email.";
        email.Send();
    }
}

//   14
using System;

class PhoneNumber
{
    public string CountryCode;
    public string Number;

    public string FullNumber => $"+{CountryCode} {Number}";
}

class Program14
{
    static void Main()
    {
        PhoneNumber phone = new PhoneNumber();
        phone.CountryCode = "1";
        phone.Number = "555-123-4567";
        Console.WriteLine(phone.FullNumber);
    }
}

//   15
using System;

class URL
{
    public string Protocol;
    public string Host;
    public string Path;

    public string FullUrl => $"{Protocol}://{Host}{Path}";
}

class Program15
{
    static void Main()
    {
        URL url = new URL();
        url.Protocol = "https";
        url.Host = "example.com";
        url.Path = "/api/data";
        Console.WriteLine(url.FullUrl);
    }
}

//   16
using System;

class Dog
{
    public string Name;

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Program16
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Name = "Rex";
        dog.Bark();
    }
}

//   17
using System;

class RectangleCalc
{
    public double Length;
    public double Width;

    public double Area()
    {
        return Length * Width;
    }

    public double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

class Program17
{
    static void Main()
    {
        RectangleCalc rect = new RectangleCalc();
        rect.Length = 10;
        rect.Width = 5;
        Console.WriteLine($"Area: {rect.Area()}");
        Console.WriteLine($"Perimeter: {rect.Perimeter()}");
    }
}

//   18
using System;

class Triangle
{
    public double SideA;
    public double SideB;
    public double SideC;

    public double Perimeter()
    {
        return SideA + SideB + SideC;
    }

    public double Area()
    {
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
}

class Program18
{
    static void Main()
    {
        Triangle tri = new Triangle();
        tri.SideA = 3; tri.SideB = 4; tri.SideC = 5;
        Console.WriteLine($"Perimeter: {tri.Perimeter()}");
        Console.WriteLine($"Area: {tri.Area():F2}");
    }
}

//   19
using System;

class Employee
{
    public string Name;
    public decimal Salary;

    public void GiveRaise(decimal percent)
    {
        Salary += Salary * percent / 100;
    }
}

class Program19
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Name = "John";
        emp.Salary = 50000m;
        emp.GiveRaise(10);
        Console.WriteLine($"New salary: {emp.Salary}");
    }
}

//   20
using System;

class Product
{
    public string Name;
    public decimal Price;
    public int Quantity;

    public decimal TotalValue()
    {
        return Price * Quantity;
    }
}

class Program20
{
    static void Main()
    {
        Product prod = new Product();
        prod.Name = "Laptop";
        prod.Price = 1200m;
        prod.Quantity = 5;
        Console.WriteLine($"Total: {prod.TotalValue()}");
    }
}

//   21
using System;

class StudentInfo
{
    public string Name;
    public int Age;
    public double GPA;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}");
    }
}

class Program21
{
    static void Main()
    {
        StudentInfo student = new StudentInfo();
        student.Name = "Anna";
        student.Age = 21;
        student.GPA = 3.9;
        student.Display();
    }
}

//   22
using System;

class House
{
    public int Rooms;
    public double Area;

    public double AreaPerRoom()
    {
        return Area / Rooms;
    }
}

class Program22
{
    static void Main()
    {
        House house = new House();
        house.Rooms = 4;
        house.Area = 120.5;
        Console.WriteLine($"Area per room: {house.AreaPerRoom():F2}");
    }
}

//   23
using System;

class Account
{
    public string AccountNumber;
    public decimal Balance;

    public void Transfer(Account to, decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            to.Balance += amount;
        }
    }
}

class Program23
{
    static void Main()
    {
        Account acc1 = new Account();
        acc1.AccountNumber = "123";
        acc1.Balance = 1000m;

        Account acc2 = new Account();
        acc2.AccountNumber = "456";
        acc2.Balance = 500m;

        acc1.Transfer(acc2, 200m);
        Console.WriteLine($"Acc1: {acc1.Balance}, Acc2: {acc2.Balance}");
    }
}

//   24
using System;

class Bicycle
{
    public int Gears;
    public int CurrentGear = 1;

    public void ShiftUp()
    {
        if (CurrentGear < Gears) CurrentGear++;
    }

    public void ShiftDown()
    {
        if (CurrentGear > 1) CurrentGear--;
    }
}

class Program24
{
    static void Main()
    {
        Bicycle bike = new Bicycle();
        bike.Gears = 21;
        bike.ShiftUp();
        bike.ShiftUp();
        Console.WriteLine($"Current gear: {bike.CurrentGear}");
    }
}

//   25
using System;

class Computer
{
    public string CPU;
    public int RAM;

    public void Boot()
    {
        Console.WriteLine($"Booting {CPU} with {RAM}GB RAM");
    }
}

class Program25
{
    static void Main()
    {
        Computer pc = new Computer();
        pc.CPU = "Intel i7";
        pc.RAM = 16;
        pc.Boot();
    }
}

//   26
using System;

class Flower
{
    public string Name;
    public string Color;

    public void Bloom()
    {
        Console.WriteLine($"{Color} {Name} is blooming");
    }
}

class Program26
{
    static void Main()
    {
        Flower flower = new Flower();
        flower.Name = "Rose";
        flower.Color = "Red";
        flower.Bloom();
    }
}

//   27
using System;

class Laptop
{
    public double ScreenSize;
    public int BatteryLife;

    public void Charge()
    {
        BatteryLife = 100;
        Console.WriteLine("Laptop charged");
    }
}

class Program27
{
    static void Main()
    {
        Laptop laptop = new Laptop();
        laptop.ScreenSize = 15.6;
        laptop.BatteryLife = 45;
        laptop.Charge();
        Console.WriteLine($"Battery: {laptop.BatteryLife}%");
    }
}

//   28
using System;

class Pen
{
    public string Color;
    public double InkLevel = 100.0;

    public void Write(string text)
    {
        if (InkLevel > 0)
        {
            Console.WriteLine($"Writing with {Color} pen: {text}");
            InkLevel -= text.Length * 0.1;
        }
    }
}

class Program28
{
    static void Main()
    {
        Pen pen = new Pen();
        pen.Color = "Blue";
        pen.Write("Hello World");
        Console.WriteLine($"Ink left: {pen.InkLevel:F1}%");
    }
}

//   29
using System;

class CoffeeCup
{
    public double Capacity;
    public double CurrentAmount;

    public void Drink(double amount)
    {
        CurrentAmount = Math.Max(0, CurrentAmount - amount);
    }

    public void Refill()
    {
        CurrentAmount = Capacity;
    }
}

class Program29
{
    static void Main()
    {
        CoffeeCup cup = new CoffeeCup();
        cup.Capacity = 300;
        cup.Refill();
        cup.Drink(100);
        Console.WriteLine($"Coffee left: {cup.CurrentAmount}ml");
    }
}

//   30
using System;

class BookInfo
{
    public string Title;
    public string Author;
    public int Year;
    public string ISBN;

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"ISBN: {ISBN}");
    }
}

class Program30
{
    static void Main()
    {
        BookInfo book = new BookInfo();
        book.Title = "1984";
        book.Author = "George Orwell";
        book.Year = 1949;
        book.ISBN = "978-0-452-28423-4";
        book.Display();
    }
}

//   31
using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program31
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 3));
        Console.WriteLine(calc.Add(2.5, 3.7));
        Console.WriteLine(calc.Subtract(10, 4));
    }
}

//   32
using System;

class StringHelper
{
    public string Reverse(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public int CountVowels(string s)
    {
        return s.Count(c => "aeiouAEIOU".Contains(c));
    }
}

class Program32
{
    static void Main()
    {
        StringHelper helper = new StringHelper();
        Console.WriteLine(helper.Reverse("Hello"));
        Console.WriteLine(helper.CountVowels("Education"));
    }
}

//   33
using System;

class MathHelper
{
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    public int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    public double Average(int[] numbers)
    {
        return numbers.Average();
    }
}

class Program33
{
    static void Main()
    {
        MathHelper math = new MathHelper();
        Console.WriteLine(math.Max(10, 20));
        Console.WriteLine(math.Min(5, 3));
        Console.WriteLine(math.Average(new int[] { 1, 2, 3, 4, 5 }));
    }
}

//   34
using System;

class TemperatureConverter
{
    public double CelsiusToFahrenheit(double c)
    {
        return c * 9.0 / 5.0 + 32;
    }

    public double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5.0 / 9.0;
    }
}

class Program34
{
    static void Main()
    {
        TemperatureConverter conv = new TemperatureConverter();
        Console.WriteLine(conv.CelsiusToFahrenheit(0));
        Console.WriteLine(conv.FahrenheitToCelsius(32));
    }
}

//   35
using System;

class LengthConverter
{
    public double MetersToFeet(double m)
    {
        return m * 3.28084;
    }

    public double FeetToMeters(double f)
    {
        return f / 3.28084;
    }

    public double KmToMiles(double km)
    {
        return km * 0.621371;
    }
}

class Program35
{
    static void Main()
    {
        LengthConverter conv = new LengthConverter();
        Console.WriteLine(conv.MetersToFeet(10));
        Console.WriteLine(conv.KmToMiles(5));
    }
}

//   36
using System;

class WeightConverter
{
    public double KgToPounds(double kg)
    {
        return kg * 2.20462;
    }

    public double PoundsToKg(double lb)
    {
        return lb / 2.20462;
    }
}

class Program36
{
    static void Main()
    {
        WeightConverter conv = new WeightConverter();
        Console.WriteLine(conv.KgToPounds(70));
        Console.WriteLine(conv.PoundsToKg(154));
    }
}

//   37
using System;

class ArrayHelper
{
    public int FindMax(int[] arr)
    {
        return arr.Max();
    }

    public int FindMin(int[] arr)
    {
        return arr.Min();
    }

    public double Average(int[] arr)
    {
        return arr.Average();
    }
}

class Program37
{
    static void Main()
    {
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 5, 2, 9, 1, 5, 6 };
        Console.WriteLine(helper.FindMax(numbers));
        Console.WriteLine(helper.FindMin(numbers));
        Console.WriteLine(helper.Average(numbers));
    }
}

//   38
using System;
using System.Text.RegularExpressions;

class StringValidator
{
    public bool IsValidEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }

    public bool IsValidPhone(string phone)
    {
        string pattern = @"^\+?\d{10,15}$";
        return Regex.IsMatch(phone, pattern);
    }
}

class Program38
{
    static void Main()
    {
        StringValidator validator = new StringValidator();
        Console.WriteLine(validator.IsValidEmail("test@example.com"));
        Console.WriteLine(validator.IsValidPhone("+1234567890"));
    }
}

//   39
using System;

class NumberChecker
{
    public bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }
}

class Program39
{
    static void Main()
    {
        NumberChecker checker = new NumberChecker();
        Console.WriteLine(checker.IsPrime(17));
        Console.WriteLine(checker.IsPrime(4));
    }
}

//   40
using System;

class DateHelper
{
    public string GetDayOfWeek(DateTime date)
    {
        return date.ToString("dddd");
    }

    public bool IsWeekend(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}

class Program40
{
    static void Main()
    {
        DateHelper helper = new DateHelper();
        DateTime today = DateTime.Today;
        Console.WriteLine(helper.GetDayOfWeek(today));
        Console.WriteLine(helper.IsWeekend(today));
    }
}

//   41
using System;
using System.IO;

class FileHelper
{
    public string ReadFile(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }

    public void WriteFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }
}

class Program41
{
    static void Main()
    {
        FileHelper helper = new FileHelper();
        string text = helper.ReadFile("test.txt");
        Console.WriteLine(text);
    }
}

//   42
using System;

class Logger
{
    public void Log(string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"[{timestamp}] {message}");
    }

    public void LogError(string error)
    {
        Log($"ERROR: {error}");
    }
}

class Program42
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.Log("Application started");
        logger.LogError("File not found");
    }
}

//   43
using System;
using System.Text.RegularExpressions;

class Validator
{
    public bool IsStrongPassword(string password)
    {
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, @"[A-Z]")) return false;
        if (!Regex.IsMatch(password, @"[a-z]")) return false;
        if (!Regex.IsMatch(password, @"\d")) return false;
        if (!Regex.IsMatch(password, @"[!@#$%^&*]")) return false;
        return true;
    }
}

class Program43
{
    static void Main()
    {
        Validator validator = new Validator();
        Console.WriteLine(validator.IsStrongPassword("Passw0rd!"));
        Console.WriteLine(validator.IsStrongPassword("weak"));
    }
}

//   44
using System;

class Formatter
{
    public string ToTitleCase(string text)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
    }

    public string PadString(string text, int length)
    {
        return text.PadRight(length);
    }
}

class Program44
{
    static void Main()
    {
        Formatter fmt = new Formatter();
        Console.WriteLine(fmt.ToTitleCase("hello world"));
        Console.WriteLine(fmt.PadString("Test", 10));
    }
}

//   45
using System;

class Counter
{
    public int Value { get; private set; }

    public void Increment()
    {
        Value++;
    }

    public void Decrement()
    {
        Value--;
    }

    public void Reset()
    {
        Value = 0;
    }
}

class Program45
{
    static void Main()
    {
        Counter counter = new Counter();
        counter.Increment();
        counter.Increment();
        Console.WriteLine(counter.Value);
        counter.Decrement();
        Console.WriteLine(counter.Value);
        counter.Reset();
        Console.WriteLine(counter.Value);
    }
}

//   46
using System;

class PersonProp
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program46
{
    static void Main()
    {
        PersonProp person = new PersonProp();
        person.Name = "Alexander";
        Console.WriteLine(person.Name);
    }
}

//   47
using System;

class StudentProp
{
    public double GPA { get; set; }
}

class Program47
{
    static void Main()
    {
        StudentProp student = new StudentProp();
        student.GPA = 4.5;
        Console.WriteLine($"GPA: {student.GPA}");
    }
}

//   48
using System;

class BankAccountProp
{
    public decimal Balance { get; set; }
}

class Program48
{
    static void Main()
    {
        BankAccountProp acc = new BankAccountProp();
        acc.Balance = 1000m;
        Console.WriteLine($"Balance: {acc.Balance}");
    }
}

//   49
using System;

class ProductProp
{
    public decimal Price { get; set; }
}

class Program49
{
    static void Main()
    {
        ProductProp prod = new ProductProp();
        prod.Price = 99.99m;
        Console.WriteLine($"Price: {prod.Price:C}");
    }
}

//   50
using System;

class CarProp
{
    public int Speed { get; set; }
}

class Program50
{
    static void Main()
    {
        CarProp car = new CarProp();
        car.Speed = 120;
        Console.WriteLine($"Speed: {car.Speed} km/h");
    }
}

//   51
using System;

class TemperatureProp
{
    public double Celsius { get; set; }

    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32;
}

class Program51
{
    static void Main()
    {
        TemperatureProp temp = new TemperatureProp();
        temp.Celsius = 25;
        Console.WriteLine($"F: {temp.Fahrenheit}");
    }
}

//   52
using System;

class RectangleProp
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;
}

class Program52
{
    static void Main()
    {
        RectangleProp rect = new RectangleProp();
        rect.Width = 10; rect.Height = 5;
        Console.WriteLine($"Area: {rect.Area}");
    }
}

//   53
using System;

class CircleProp
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
}

class Program53
{
    static void Main()
    {
        CircleProp circle = new CircleProp();
        circle.Radius = 7;
        Console.WriteLine($"Area: {circle.Area:F2}");
    }
}

//   54
using System;

class EmployeeProp
{
    public decimal Salary { get; set; }
}

class Program54
{
    static void Main()
    {
        EmployeeProp emp = new EmployeeProp();
        emp.Salary = 60000m;
        Console.WriteLine($"Salary: {emp.Salary:C}");
    }
}

//   55
using System;

class BookProp
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Program55
{
    static void Main()
    {
        BookProp book = new BookProp();
        book.Title = "Clean Code";
        book.Author = "Robert Martin";
        Console.WriteLine($"{book.Title} by {book.Author}");
    }
}

//   56
using System;

class HouseProp
{
    public double Area { get; set; }
}

class Program56
{
    static void Main()
    {
        HouseProp house = new HouseProp();
        house.Area = 150.5;
        Console.WriteLine($"Area: {house.Area} sq.m");
    }
}

//   57
using System;

class ComputerProp
{
    public int RAM { get; set; }
}

class Program57
{
    static void Main()
    {
        ComputerProp pc = new ComputerProp();
        pc.RAM = 32;
        Console.WriteLine($"RAM: {pc.RAM} GB");
    }
}

//   58
using System;

class AccountProp
{
    public string Username { get; set; }
}

class Program58
{
    static void Main()
    {
        AccountProp acc = new AccountProp();
        acc.Username = "user123";
        Console.WriteLine($"User: {acc.Username}");
    }
}

//   59
using System;

class VehicleProp
{
    public string Brand { get; set; }
}

class Program59
{
    static void Main()
    {
        VehicleProp vehicle = new VehicleProp();
        vehicle.Brand = "BMW";
        Console.WriteLine($"Brand: {vehicle.Brand}");
    }
}

//   60
using System;

class ColorProp
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public string Hex => $"#{Red:X2}{Green:X2}{Blue:X2}";
}

class Program60
{
    static void Main()
    {
        ColorProp color = new ColorProp();
        color.Red = 255; color.Green = 165; color.Blue = 0;
        Console.WriteLine($"Hex: {color.Hex}");
    }
}

//   61
using System;

class PersonReadOnly
{
    public int Age { get; }

    public PersonReadOnly(int age)
    {
        Age = age;
    }
}

class Program61
{
    static void Main()
    {
        PersonReadOnly p = new PersonReadOnly(25);
        Console.WriteLine(p.Age);
    }
}

//   62
using System;

class StudentReadOnly
{
    public int ID { get; }

    public StudentReadOnly(int id)
    {
        ID = id;
    }
}

class Program62
{
    static void Main()
    {
        StudentReadOnly s = new StudentReadOnly(1001);
        Console.WriteLine(s.ID);
    }
}

//   63
using System;

class BankAccountReadOnly
{
    public string AccountNumber { get; }

    public BankAccountReadOnly(string number)
    {
        AccountNumber = number;
    }
}

class Program63
{
    static void Main()
    {
        BankAccountReadOnly acc = new BankAccountReadOnly("1234567890");
        Console.WriteLine(acc.AccountNumber);
    }
}

//   64
using System;

class ProductReadOnly
{
    public string Code { get; }

    public ProductReadOnly(string code)
    {
        Code = code;
    }
}

class Program64
{
    static void Main()
    {
        ProductReadOnly prod = new ProductReadOnly("ABC123");
        Console.WriteLine(prod.Code);
    }
}

//   65
using System;

class EmployeeReadOnly
{
    public int EmployeeID { get; }

    public EmployeeReadOnly(int id)
    {
        EmployeeID = id;
    }
}

class Program65
{
    static void Main()
    {
        EmployeeReadOnly emp = new EmployeeReadOnly(5001);
        Console.WriteLine(emp.EmployeeID);
    }
}

//   66
using System;

class CarReadOnly
{
    public string VIN { get; }

    public CarReadOnly(string vin)
    {
        VIN = vin;
    }
}

class Program66
{
    static void Main()
    {
        CarReadOnly car = new CarReadOnly("1HGBH41JXMN109186");
        Console.WriteLine(car.VIN);
    }
}

//   67
using System;

class HouseReadOnly
{
    public string Address { get; }

    public HouseReadOnly(string address)
    {
        Address = address;
    }
}

class Program67
{
    static void Main()
    {
        HouseReadOnly house = new HouseReadOnly("123 Main St");
        Console.WriteLine(house.Address);
    }
}

//   68
using System;

class BookReadOnly
{
    public string ISBN { get; }

    public BookReadOnly(string isbn)
    {
        ISBN = isbn;
    }
}

class Program68
{
    static void Main()
    {
        BookReadOnly book = new BookReadOnly("978-3-16-148410-0");
        Console.WriteLine(book.ISBN);
    }
}

//   69
using System;

class ComputerReadOnly
{
    public string SerialNumber { get; }

    public ComputerReadOnly(string sn)
    {
        SerialNumber = sn;
    }
}

class Program69
{
    static void Main()
    {
        ComputerReadOnly pc = new ComputerReadOnly("SN123456789");
        Console.WriteLine(pc.SerialNumber);
    }
}

//   70
using System;

class DocumentReadOnly
{
    public DateTime CreatedDate { get; }

    public DocumentReadOnly()
    {
        CreatedDate = DateTime.Now;
    }
}

class Program70
{
    static void Main()
    {
        DocumentReadOnly doc = new DocumentReadOnly();
        Console.WriteLine(doc.CreatedDate);
    }
}

//   71
using System;

class OrderReadOnly
{
    public int OrderID { get; }

    public OrderReadOnly(int id)
    {
        OrderID = id;
    }
}

class Program71
{
    static void Main()
    {
        OrderReadOnly order = new OrderReadOnly(9001);
        Console.WriteLine(order.OrderID);
    }
}

//   72
using System;

class InvoiceReadOnly
{
    public string InvoiceNumber { get; }

    public InvoiceReadOnly(string number)
    {
        InvoiceNumber = number;
    }
}

class Program72
{
    static void Main()
    {
        InvoiceReadOnly inv = new InvoiceReadOnly("INV-2025-001");
        Console.WriteLine(inv.InvoiceNumber);
    }
}

//   73
using System;

class UserReadOnly
{
    public Guid UID { get; }

    public UserReadOnly()
    {
        UID = Guid.NewGuid();
    }
}

class Program73
{
    static void Main()
    {
        UserReadOnly user = new UserReadOnly();
        Console.WriteLine(user.UID);
    }
}

//   74
using System;

class DeviceReadOnly
{
    public string MAC { get; }

    public DeviceReadOnly(string mac)
    {
        MAC = mac;
    }
}

class Program74
{
    static void Main()
    {
        DeviceReadOnly dev = new DeviceReadOnly("00:1A:2B:3C:4D:5E");
        Console.WriteLine(dev.MAC);
    }
}

//   75
using System;

class TicketReadOnly
{
    public string TicketNumber { get; }

    public TicketReadOnly(string number)
    {
        TicketNumber = number;
    }
}

class Program75
{
    static void Main()
    {
        TicketReadOnly ticket = new TicketReadOnly("TKT-2025-ABC123");
        Console.WriteLine(ticket.TicketNumber);
    }
}

//   76
using System;

class UserWriteOnly
{
    private string password;

    public string Password
    {
        set { password = Hash(value); }
    }

    private string Hash(string input)
    {
        return "hashed_" + input;
    }
}

class Program76
{
    static void Main()
    {
        UserWriteOnly user = new UserWriteOnly();
        user.Password = "secret123";
    }
}

//   77
using System;

class BankAccountWriteOnly
{
    private string pin;

    public string PIN
    {
        set { pin = Encrypt(value); }
    }

    private string Encrypt(string input)
    {
        return "encrypted_" + input;
    }
}

class Program77
{
    static void Main()
    {
        BankAccountWriteOnly acc = new BankAccountWriteOnly();
        acc.PIN = "1234";
    }
}

//   78
using System;

class SecureDocumentWriteOnly
{
    private string key;

    public string EncryptionKey
    {
        set { key = value; }
    }
}

class Program78
{
    static void Main()
    {
        SecureDocumentWriteOnly doc = new SecureDocumentWriteOnly();
        doc.EncryptionKey = "my-secret-key-256";
    }
}

//   79
using System;

class AccountWriteOnly
{
    private string token;

    public string Token
    {
        set { token = value; }
    }
}

class Program79
{
    static void Main()
    {
        AccountWriteOnly acc = new AccountWriteOnly();
        acc.Token = "jwt.token.here";
    }
}

//   80
using System;

class LoggerWriteOnly
{
    private string apiKey;

    public string ApiKey
    {
        set { apiKey = value; }
    }
}

class Program80
{
    static void Main()
    {
        LoggerWriteOnly logger = new LoggerWriteOnly();
        logger.ApiKey = "log-api-key-123";
    }
}

//   81
using System;

class EmailServiceWriteOnly
{
    private string password;

    public string SMTPPassword
    {
        set { password = value; }
    }
}

class Program81
{
    static void Main()
    {
        EmailServiceWriteOnly service = new EmailServiceWriteOnly();
        service.SMTPPassword = "smtp-pass";
    }
}

//   82
using System;

class SecureConnectionWriteOnly
{
    private string connStr;

    public string ConnectionString
    {
        set { connStr = value; }
    }
}

class Program82
{
    static void Main()
    {
        SecureConnectionWriteOnly conn = new SecureConnectionWriteOnly();
        conn.ConnectionString = "Server=...;Password=...";
    }
}

//   83
using System;

class AuthenticatorWriteOnly
{
    private string secret;

    public string Secret
    {
        set { secret = value; }
    }
}

class Program83
{
    static void Main()
    {
        AuthenticatorWriteOnly auth = new AuthenticatorWriteOnly();
        auth.Secret = "super-secret";
    }
}

//   84
using System;

class PaymentServiceWriteOnly
{
    private string card;

    public string CreditCard
    {
        set { card = Mask(value); }
    }

    private string Mask(string input)
    {
        return "****-****-****-" + input.Substring(input.Length - 4);
    }
}

class Program84
{
    static void Main()
    {
        PaymentServiceWriteOnly payment = new PaymentServiceWriteOnly();
        payment.CreditCard = "1234567890123456";
    }
}

//   85
using System;

class VPNClientWriteOnly
{
    private string password;

    public string VPNPassword
    {
        set { password = value; }
    }
}

class Program85
{
    static void Main()
    {
        VPNClientWriteOnly vpn = new VPNClientWriteOnly();
        vpn.VPNPassword = "vpn-pass-123";
    }
}

//   86
using System;

class PersonCtor
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonCtor(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program86
{
    static void Main()
    {
        PersonCtor p = new PersonCtor("Ivan", 30);
        p.Display();
    }
}

//   87
using System;

class StudentCtor
{
    public int ID { get; set; }
    public string Name { get; set; }

    public StudentCtor(int id, string name)
    {
        ID = id;
        Name = name;
    }
}

class Program87
{
    static void Main()
    {
        StudentCtor s = new StudentCtor(101, "Maria");
        Console.WriteLine($"ID: {s.ID}, Name: {s.Name}");
    }
}

//   88
using System;

class RectangleCtor
{
    public double Length { get; set; }
    public double Width { get; set; }

    public RectangleCtor(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Area() => Length * Width;
}

class Program88
{
    static void Main()
    {
        RectangleCtor r = new RectangleCtor(10, 5);
        Console.WriteLine($"Area: {r.Area()}");
    }
}

//   89
using System;

class CircleCtor
{
    public double Radius { get; set; }

    public CircleCtor(double radius)
    {
        Radius = radius;
    }

    public double Area() => Math.PI * Radius * Radius;
}

class Program89
{
    static void Main()
    {
        CircleCtor c = new CircleCtor(5);
        Console.WriteLine($"Area: {c.Area():F2}");
    }
}

//   90
using System;

class BankAccountCtor
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public BankAccountCtor(string number, decimal balance)
    {
        AccountNumber = number;
        Balance = balance;
    }
}

class Program90
{
    static void Main()
    {
        BankAccountCtor acc = new BankAccountCtor("123456", 1000m);
        Console.WriteLine($"Account: {acc.AccountNumber}, Balance: {acc.Balance}");
    }
}

//   91
using System;

class CarCtor
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public CarCtor(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine($"{Year} {Brand} {Model}");
    }
}

class Program91
{
    static void Main()
    {
        CarCtor car = new CarCtor("Honda", "Civic", 2022);
        car.Display();
    }
}

//   92
using System;

class BookCtor
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public BookCtor(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void Info()
    {
        Console.WriteLine($"\"{Title}\" by {Author}, {Pages} pages");
    }
}

class Program92
{
    static void Main()
    {
        BookCtor book = new BookCtor("Dune", "Frank Herbert", 412);
        book.Info();
    }
}

//   93
using System;

class EmployeeCtor
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public EmployeeCtor(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Program93
{
    static void Main()
    {
        EmployeeCtor emp = new EmployeeCtor("Peter", 75000m);
        Console.WriteLine($"{emp.Name}: {emp.Salary:C}");
    }
}

//   94
using System;

class ProductCtor
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ProductCtor(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Program94
{
    static void Main()
    {
        ProductCtor prod = new ProductCtor("Phone", 899.99m);
        Console.WriteLine($"{prod.Name}: {prod.Price:C}");
    }
}

//   95
using System;

class HouseCtor
{
    public string Address { get; set; }
    public int Rooms { get; set; }

    public HouseCtor(string address, int rooms)
    {
        Address = address;
        Rooms = rooms;
    }
}

class Program95
{
    static void Main()
    {
        HouseCtor house = new HouseCtor("456 Oak St", 3);
        Console.WriteLine($"House at {house.Address}, {house.Rooms} rooms");
    }
}

//   96
using System;

class TriangleCtor
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public TriangleCtor(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public double Perimeter() => A + B + C;
}

class Program96
{
    static void Main()
    {
        TriangleCtor tri = new TriangleCtor(3, 4, 5);
        Console.WriteLine($"Perimeter: {tri.Perimeter()}");
    }
}

//   97
using System;

class TimeCtor
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public TimeCtor(int h, int m, int s)
    {
        Hours = h; Minutes = m; Seconds = s;
    }

    public override string ToString()
    {
        return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }
}

class Program97
{
    static void Main()
    {
        TimeCtor time = new TimeCtor(14, 30, 45);
        Console.WriteLine(time);
    }
}

//   98
using System;

class TemperatureCtor
{
    public double Celsius { get; set; }

    public TemperatureCtor(double celsius)
    {
        Celsius = celsius;
    }

    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32;
}

class Program98
{
    static void Main()
    {
        TemperatureCtor temp = new TemperatureCtor(20);
        Console.WriteLine($"F: {temp.Fahrenheit}");
    }
}

//   99
using System;

class ColorCtor
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public ColorCtor(byte r, byte g, byte b)
    {
        R = r; G = g; B = b;
    }

    public string Hex => $"#{R:X2}{G:X2}{B:X2}";
}

class Program99
{
    static void Main()
    {
        ColorCtor color = new ColorCtor(255, 87, 51);
        Console.WriteLine(color.Hex);
    }
}

//   100
using System;

class PointCtor
{
    public double X { get; set; }
    public double Y { get; set; }

    public PointCtor(double x, double y)
    {
        X = x; Y = y;
    }

    public double DistanceToOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program100
{
    static void Main()
    {
        PointCtor p = new PointCtor(3, 4);
        Console.WriteLine($"Distance: {p.DistanceToOrigin()}");
    }
}