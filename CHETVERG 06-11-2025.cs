// =============================================
// Раздел 1: Основы структур (1-25)
// =============================================

// 1
using System;
using System.Collections;
using System.Xml.Linq;
using static NestedRepositoryDemo.Repository<T>;

namespace StructPointDemo
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 1: Структура Point ===\n");
            Point p = new Point(3.5, 4.2);
            Console.WriteLine($"Point: {p}");
        }
    }
}

// 2
using System;

namespace StructRectangleDemo
{
    struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area() => Width * Height;
        public override string ToString() => $"Rectangle: {Width}x{Height}, Area: {Area()}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 2: Rectangle с площадью ===\n");
            Rectangle rect = new Rectangle(5, 3);
            Console.WriteLine(rect);
        }
    }
}

// 3
using System;

namespace StructColorDemo
{
    struct Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public Color(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }

        public string ToHex() => $"#{R:X2}{G:X2}{B:X2}";
        public override string ToString() => $"RGB({R}, {G}, {B}) -> {ToHex()}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 3: Color с hex ===\n");
            Color red = new Color(255, 0, 0);
            Console.WriteLine(red);
        }
    }
}

// 4
using System;

namespace StructDateDemo
{
    struct Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day; Month = month; Year = year;
        }

        public override string ToString() => $"{Day:D2}.{Month:D2}.{Year}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 4: Date ===\n");
            Date d = new Date(13, 11, 2025);
            Console.WriteLine($"Date: {d}");
        }
    }
}

// 5
using System;

namespace StructMoneyDemo
{
    struct Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public string Format() => $"{Amount:N2} {Currency}";
        public override string ToString() => Format();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 5: Money ===\n");
            Money m = new Money(1234.56m, "USD");
            Console.WriteLine($"Money: {m}");
        }
    }
}

// 6
using System;

namespace StructTemperatureDemo
{
    struct Temperature
    {
        public double Celsius { get; }

        public Temperature(double celsius) => Celsius = celsius;

        public double Fahrenheit => Celsius * 9.0 / 5.0 + 32;
        public override string ToString() => $"{Celsius}°C = {Fahrenheit:F1}°F";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 6: Temperature ===\n");
            Temperature t = new Temperature(25);
            Console.WriteLine(t);
        }
    }
}

// 7
using System;

namespace StructVector3DDemo
{
    struct Vector3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Vector3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public double Magnitude() => Math.Sqrt(X * X + Y * Y + Z * Z);
        public Vector3D Add(Vector3D v) => new Vector3D(X + v.X, Y + v.Y, Z + v.Z);
        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 7: Vector3D ===\n");
            Vector3D a = new Vector3D(1, 2, 3);
            Vector3D b = new Vector3D(4, 5, 6);
            Console.WriteLine($"a + b = {a.Add(b)}");
            Console.WriteLine($"|a| = {a.Magnitude():F2}");
        }
    }
}

// 8
using System;

namespace StructSizeDemo
{
    struct Size
    {
        public double Width { get; }
        public double Height { get; }

        public Size(double width, double height)
        {
            Width = width; Height = height;
        }

        public double Perimeter() => 2 * (Width + Height);
        public override string ToString() => $"Size: {Width}x{Height}, P = {Perimeter()}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 8: Size с периметром ===\n");
            Size s = new Size(10, 5);
            Console.WriteLine(s);
        }
    }
}

// 9
using System;

namespace StructCoordinateDemo
{
    struct Coordinate
    {
        public double X { get; }
        public double Y { get; }

        public Coordinate(double x, double y)
        {
            X = x; Y = y;
        }

        public double DistanceTo(Coordinate other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString() => $"({X}, {Y})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 9: Coordinate с расстоянием ===\n");
            Coordinate a = new Coordinate(0, 0);
            Coordinate b = new Coordinate(3, 4);
            Console.WriteLine($"Distance {a} to {b}: {a.DistanceTo(b)}");
        }
    }
}

// 10
using System;

namespace StructPhoneNumberDemo
{
    struct PhoneNumber
    {
        public string CountryCode { get; }
        public string Number { get; }

        public PhoneNumber(string countryCode, string number)
        {
            CountryCode = countryCode;
            Number = number;
        }

        public override string ToString() => $"+{CountryCode} {Number}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 10: PhoneNumber ===\n");
            PhoneNumber pn = new PhoneNumber("1", "555-123-4567");
            Console.WriteLine(pn);
        }
    }
}

// 11
using System;

namespace StructRatingDemo
{
    struct Rating
    {
        private int _value;
        public int Value
        {
            get => _value;
            set => _value = value >= 1 && value <= 5 ? value : throw new ArgumentException("Rating must be 1-5");
        }

        public Rating(int value) { Value = value; }
        public override string ToString() => $"{Value} star";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 11: Rating с валидацией ===\n");
            Rating r = new Rating(4);
            Console.WriteLine(r);
        }
    }
}

// 12
using System;

namespace StructTimeDemo
{
    struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours; Minutes = minutes; Seconds = seconds;
        }

        public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 12: Time ===\n");
            Time t = new Time(14, 30, 45);
            Console.WriteLine($"Time: {t}");
        }
    }
}

// 13
using System;

namespace StructIntervalDemo
{
    struct Interval
    {
        public double Start { get; }
        public double End { get; }

        public Interval(double start, double end)
        {
            Start = start; End = end;
        }

        public double Length => End - Start;
        public override string ToString() => $"[{Start}, {End}] Length: {Length}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 13: Interval ===\n");
            Interval i = new Interval(1.5, 5.5);
            Console.WriteLine(i);
        }
    }
}

// 14
using System;

namespace StructComplexNumberDemo
{
    struct ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real; Imaginary = imaginary;
        }

        public override string ToString() => Imaginary >= 0
            ? $"{Real} + {Imaginary}i"
            : $"{Real} - {-Imaginary}i";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 14: ComplexNumber ===\n");
            ComplexNumber c = new ComplexNumber(3, -4);
            Console.WriteLine(c);
        }
    }
}

// 15
using System;

namespace StructDimensionsDemo
{
    struct Dimensions
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public Dimensions(double l, double w, double h)
        {
            Length = l; Width = w; Height = h;
        }

        public double Volume() => Length * Width * Height;
        public override string ToString() => $"Dim: {Length}x{Width}x{Height}, Vol: {Volume()}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 15: Dimensions ===\n");
            Dimensions d = new Dimensions(2, 3, 4);
            Console.WriteLine(d);
        }
    }
}

// 16
using System;

namespace StructPixelDemo
{
    struct Pixel
    {
        public int X { get; }
        public int Y { get; }
        public Color Color { get; }

        public Pixel(int x, int y, Color color)
        {
            X = x; Y = y; Color = color;
        }

        public override string ToString() => $"Pixel({X},{Y}) = {Color}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 16: Pixel ===\n");
            Color red = new Color(255, 0, 0);
            Pixel p = new Pixel(10, 20, red);
            Console.WriteLine(p);
        }
    }
}

// 17
using System;

namespace StructAngleDemo
{
    struct Angle
    {
        public double Degrees { get; }

        public Angle(double degrees) => Degrees = degrees;

        public double Radians => Degrees * Math.PI / 180.0;
        public override string ToString() => $"{Degrees}° = {Radians:F3} rad";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 17: Angle ===\n");
            Angle a = new Angle(90);
            Console.WriteLine(a);
        }
    }
}

// 18
using System;

namespace StructSpeedDemo
{
    struct Speed
    {
        public double Value { get; }
        public string Unit { get; }

        public Speed(double value, string unit)
        {
            Value = value; Unit = unit;
        }

        public override string ToString() => $"{Value} {Unit}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 18: Speed ===\n");
            Speed s = new Speed(100, "km/h");
            Console.WriteLine(s);
        }
    }
}

// 19
using System;

namespace StructWeightDemo
{
    struct Weight
    {
        public double Kilograms { get; }

        public Weight(double kg) => Kilograms = kg;

        public double Pounds => Kilograms * 2.20462;
        public override string ToString() => $"{Kilograms} kg = {Pounds:F2} lb";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 19: Weight ===\n");
            Weight w = new Weight(70);
            Console.WriteLine(w);
        }
    }
}

// 20
using System;

namespace StructDurationDemo
{
    struct Duration
    {
        public int Days { get; }
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Duration(int d, int h, int m, int s)
        {
            Days = d; Hours = h; Minutes = m; Seconds = s;
        }

        public override string ToString() => $"{Days}d {Hours}h {Minutes}m {Seconds}s";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 20: Duration ===\n");
            Duration d = new Duration(1, 2, 30, 45);
            Console.WriteLine(d);
        }
    }
}

// 21
using System;

namespace StructPositionDemo
{
    struct Position
    {
        public double X { get; }
        public double Y { get; }

        public Position(double x, double y)
        {
            X = x; Y = y;
        }

        public string Quadrant()
        {
            if (X > 0 && Y > 0) return "I";
            if (X < 0 && Y > 0) return "II";
            if (X < 0 && Y < 0) return "III";
            if (X > 0 && Y < 0) return "IV";
            return "On axis";
        }

        public override string ToString() => $"({X}, {Y}) -> {Quadrant}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 21: Position ===\n");
            Position p = new Position(5, -3);
            Console.WriteLine(p);
        }
    }
}

// 22
using System;

namespace StructFractionDemo
{
    struct Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int num, int den)
        {
            if (den == 0) throw new ArgumentException("Denominator cannot be zero");
            int gcd = GCD(Math.Abs(num), Math.Abs(den));
            Numerator = num / gcd;
            Denominator = den / gcd;
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        private static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

        public override string ToString() => $"{Numerator}/{Denominator}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 22: Fraction ===\n");
            Fraction f = new Fraction(4, 8);
            Console.WriteLine(f);
        }
    }
}

// 23
using System;

namespace StructVersionDemo
{
    struct Version
    {
        public int Major { get; }
        public int Minor { get; }
        public int Build { get; }

        public Version(int major, int minor, int build)
        {
            Major = major; Minor = minor; Build = build;
        }

        public override string ToString() => $"{Major}.{Minor}.{Build}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 23: Version ===\n");
            Version v = new Version(1, 0, 0);
            Console.WriteLine(v);
        }
    }
}

// 24
using System;

namespace StructDataSizeDemo
{
    struct DataSize
    {
        public long Bytes { get; }

        public DataSize(long bytes) => Bytes = bytes;

        public string Format()
        {
            if (Bytes < 1024) return $"{Bytes} B";
            if (Bytes < 1024 * 1024) return $"{Bytes / 1024.0:F1} KB";
            if (Bytes < 1024 * 1024 * 1024) return $"{Bytes / (1024.0 * 1024):F1} MB";
            return $"{Bytes / (1024.0 * 1024 * 1024):F1} GB";
        }

        public override string ToString() => Format();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 24: DataSize ===\n");
            DataSize s = new DataSize(1500000);
            Console.WriteLine(s);
        }
    }
}

// 25
using System;

namespace StructGameScoreDemo
{
    struct GameScore
    {
        public string PlayerName { get; }
        public int Points { get; }

        public GameScore(string name, int points)
        {
            PlayerName = name; Points = points;
        }

        public override string ToString() => $"{PlayerName}: {Points} pts";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 25: GameScore ===\n");
            GameScore gs = new GameScore("Alice", 1500);
            Console.WriteLine(gs);
        }
    }
}

// =============================================
// Раздел 2: Конструкторы в структурах (26-50)
// =============================================

// 26
using System;

namespace StructPointConstructorsDemo
{
    struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point() : this(0, 0) { }

        public Point(double x, double y)
        {
            X = x; Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 26: Point с конструкторами ===\n");
            Point p1 = new Point();
            Point p2 = new Point(5, 10);
            Console.WriteLine($"p1: {p1}, p2: {p2}");
        }
    }
}

// 27
using System;

namespace StructRectangleConstructorDemo
{
    struct Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Dimensions must be positive");
            Width = width; Height = height;
        }

        public double Area => Width * Height;
        public override string ToString() => $"Rectangle {Width}x{Height}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 27: Rectangle с конструктором ===\n");
            Rectangle r = new Rectangle(4, 6);
            Console.WriteLine(r);
        }
    }
}

// 28
using System;

namespace StructColorFromHexDemo
{
    struct Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public Color(string hex)
        {
            if (hex.StartsWith("#")) hex = hex.Substring(1);
            if (hex.Length != 6) throw new ArgumentException("Hex must be 6 chars");
            R = Convert.ToByte(hex.Substring(0, 2), 16);
            G = Convert.ToByte(hex.Substring(2, 2), 16);
            B = Convert.ToByte(hex.Substring(4, 2), 16);
        }

        public override string ToString() => $"#{R:X2}{G:X2}{B:X2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 28: Color из hex ===\n");
            Color c = new Color("#FF5733");
            Console.WriteLine(c);
        }
    }
}

// 29
using System;

namespace StructPersonDemo
{
    struct Person
    {
        public string Name { get; }
        public int Age { get; }
        public string City { get; }

        public Person(string name, int age, string city)
        {
            Name = name; Age = age; City = city;
        }

        public override string ToString() => $"{Name}, {Age}, {City}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 29: Person ===\n");
            Person p = new Person("Bob", 30, "NY");
            Console.WriteLine(p);
        }
    }
}

// 30
using System;

namespace StructDateValidationDemo
{
    struct Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            if (month < 1 || month > 12) throw new ArgumentException("Invalid month");
            if (day < 1 || day > DateTime.DaysInMonth(year, month)) throw new ArgumentException("Invalid day");
            Day = day; Month = month; Year = year;
        }

        public override string ToString() => $"{Day:D2}.{Month:D2}.{Year}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 30: Date с валидацией ===\n");
            Date d = new Date(13, 11, 2025);
            Console.WriteLine(d);
        }
    }
}

// 31
using System;

namespace StructMoneyValidationDemo
{
    struct Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative");
            if (string.IsNullOrEmpty(currency)) throw new ArgumentException("Currency required");
            Amount = amount; Currency = currency;
        }

        public override string ToString() => $"{Amount:C} {Currency}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 31: Money с валидацией ===\n");
            Money m = new Money(100.50m, "EUR");
            Console.WriteLine(m);
        }
    }
}

// 32
using System;

namespace StructVectorDemo
{
    struct Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vector(double x, double y)
        {
            X = x; Y = y;
        }

        public void Normalize()
        {
            double mag = Math.Sqrt(X * X + Y * Y);
            if (mag > 0)
            {
                X /= mag;
                Y /= mag;
            }
        }

        public override string ToString() => $"({X:F2}, {Y:F2})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 32: Vector ===\n");
            Vector v = new Vector(3, 4);
            v.Normalize();
            Console.WriteLine($"Normalized: {v}");
        }
    }
}

// 33
using System;

namespace StructTimeValidationDemo
{
    struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds)
        {
            if (hours < 0 || hours > 23) throw new ArgumentException("Invalid hours");
            if (minutes < 0 || minutes > 59) throw new ArgumentException("Invalid minutes");
            if (seconds < 0 || seconds > 59) throw new ArgumentException("Invalid seconds");
            Hours = hours; Minutes = minutes; Seconds = seconds;
        }

        public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 33: Time с валидацией ===\n");
            Time t = new Time(23, 59, 59);
            Console.WriteLine(t);
        }
    }
}

// 34
using System;

namespace StructBookDemo
{
    struct Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }
        public string ISBN { get; }

        public Book(string title, string author, int year, string isbn)
        {
            Title = title; Author = author; Year = year; ISBN = isbn;
        }

        public override string ToString() => $"'{Title}' by {Author} ({Year})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 34: Book ===\n");
            Book b = new Book("1984", "Orwell", 1949, "978-0-452-28423-4");
            Console.WriteLine(b);
        }
    }
}

// 35
using System;

namespace StructCircleDemo
{
    struct Circle
    {
        public Point Center { get; }
        public double Radius { get; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius > 0 ? radius : throw new ArgumentException("Radius must be positive");
        }

        public double Area => Math.PI * Radius * Radius;
        public override string ToString() => $"Circle at {Center}, R={Radius:F2}, Area={Area:F2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 35: Circle ===\n");
            Circle c = new Circle(new Point(0, 0), 5);
            Console.WriteLine(c);
        }
    }
}

// 36
using System;

namespace StructProductDemo
{
    struct Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; }

        public Product(int id, string name, decimal price, int quantity)
        {
            Id = id; Name = name; Price = price; Quantity = quantity;
        }

        public decimal Total => Price * Quantity;
        public override string ToString() => $"{Id}: {Name} x{Quantity} = {Total:C}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 36: Product ===\n");
            Product p = new Product(1, "Laptop", 999.99m, 2);
            Console.WriteLine(p);
        }
    }
}

// 37
using System;

namespace StructTriangleDemo
{
    struct Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Sides must be positive");
            if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Invalid triangle");
            A = a; B = b; C = c;
        }

        public double Perimeter => A + B + C;
        public override string ToString() => $"Triangle({A},{B},{C}), P={Perimeter:F2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 37: Triangle ===\n");
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t);
        }
    }
}

// 38
using System;

namespace StructStudentDemo
{
    struct Student
    {
        public string FullName { get; }
        public int StudentId { get; }
        public string Major { get; }
        public double GPA { get; }

        public Student(string name, int id, string major, double gpa)
        {
            FullName = name; StudentId = id; Major = major; GPA = gpa;
        }

        public override string ToString() => $"{FullName} (ID: {StudentId}), {Major}, GPA: {GPA:F2}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 38: Student ===\n");
            Student s = new Student("Anna Smith", 12345, "CS", 3.8);
            Console.WriteLine(s);
        }
    }
}

// 39
using System;

namespace StructAddressDemo
{
    struct Address
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
        public string Country { get; }

        public Address(string street, string city, string state, string zip, string country)
        {
            Street = street; City = city; State = state; Zip = zip; Country = country;
        }

        public override string ToString() => $"{Street}, {City}, {State} {Zip}, {Country}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 39: Address ===\n");
            Address a = new Address("123 Main St", "Springfield", "IL", "62701", "USA");
            Console.WriteLine(a);
        }
    }
}

// 40
using System;

namespace StructBankAccountDemo
{
    struct BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string number, decimal initialBalance)
        {
            AccountNumber = number;
            Balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Balance cannot be negative");
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0) Balance += amount;
        }

        public override string ToString() => $"Account {AccountNumber}: {Balance:C}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 40: BankAccount ===\n");
            BankAccount acc = new BankAccount("123456789", 1000m);
            acc.Deposit(500m);
            Console.WriteLine(acc);
        }
    }
}

// 41
using System;

namespace StructCarDemo
{
    struct Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public Car(string make, string model, int year)
        {
            Make = make; Model = model; Year = year;
        }

        public override string ToString() => $"{Year} {Make} {Model}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 41: Car ===\n");
            Car c = new Car("Toyota", "Camry", 2023);
            Console.WriteLine(c);
        }
    }
}

// 42
using System;

namespace StructPhoneNumberParseDemo
{
    struct PhoneNumber
    {
        public string CountryCode { get; }
        public string Number { get; }

        public PhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone)) throw new ArgumentException("Phone required");
            if (phone.StartsWith("+"))
            {
                int space = phone.IndexOf(' ');
                CountryCode = space > 1 ? phone.Substring(1, space - 1) : "1";
                Number = phone.Substring(space + 1);
            }
            else
            {
                CountryCode = "1";
                Number = phone;
            }
        }

        public override string ToString() => $"+{CountryCode} {Number}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 42: PhoneNumber парсинг ===\n");
            PhoneNumber p = new PhoneNumber("+7 999-123-4567");
            Console.WriteLine(p);
        }
    }
}

// 43
using System;

namespace StructMatrixDemo
{
    struct Matrix
    {
        public int Rows { get; }
        public int Cols { get; }
        private readonly double[,] data;

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0) throw new ArgumentException("Dimensions must be positive");
            Rows = rows; Cols = cols;
            data = new double[rows, cols];
        }

        public double this[int r, int c]
        {
            get => data[r, c];
            set => data[r, c] = value;
        }

        public override string ToString() => $"Matrix {Rows}x{Cols}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 43: Matrix ===\n");
            Matrix m = new Matrix(2, 3);
            m[0, 0] = 1.5;
            Console.WriteLine(m);
        }
    }
}

// 44
using System;

namespace StructEmployeeDemo
{
    struct Employee
    {
        public string FullName { get; }
        public string Position { get; }
        public decimal Salary { get; }

        public Employee(string name, string position, decimal salary)
        {
            FullName = name; Position = position; Salary = salary;
        }

        public override string ToString() => $"{FullName}, {Position}, {Salary:C}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 44: Employee ===\n");
            Employee e = new Employee("John Doe", "Developer", 75000m);
            Console.WriteLine(e);
        }
    }
}

// 45
using System;

namespace StructEmailDemo
{
    struct Email
    {
        public string Address { get; }

        public Email(string address)
        {
            if (!address.Contains("@") || !address.Contains(".")) throw new ArgumentException("Invalid email");
            Address = address.ToLower();
        }

        public override string ToString() => Address;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 45: Email с валидацией ===\n");
            Email e = new Email("user@example.com");
            Console.WriteLine(e);
        }
    }
}

// 46
using System;

namespace StructAppointmentDemo
{
    struct Appointment
    {
        public DateTime DateTime { get; }
        public string Description { get; }

        public Appointment(DateTime dt, string desc)
        {
            DateTime = dt; Description = desc;
        }

        public override string ToString() => $"{DateTime:yyyy-MM-dd HH:mm} - {Description}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 46: Appointment ===\n");
            Appointment a = new Appointment(new DateTime(2025, 11, 13, 14, 0, 0), "Team meeting");
            Console.WriteLine(a);
        }
    }
}

// 47
using System;
using System.Collections.Generic;

namespace StructRecipeDemo
{
    struct Recipe
    {
        public string Name { get; }
        public List<string> Ingredients { get; }

        public Recipe(string name, List<string> ingredients)
        {
            Name = name; Ingredients = ingredients ?? new List<string>();
        }

        public override string ToString() => $"{Name}: {Ingredients.Count} ingredients";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 47: Recipe ===\n");
            var ingredients = new List<string> { "Flour", "Water", "Yeast" };
            Recipe r = new Recipe("Bread", ingredients);
            Console.WriteLine(r);
        }
    }
}

// 48
using System;

namespace StructSocialProfileDemo
{
    struct SocialProfile
    {
        public string Username { get; }
        public string Platform { get; }

        public SocialProfile(string username, string platform)
        {
            Username = username; Platform = platform;
        }

        public override string ToString() => $"@{Username} on {Platform}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 48: SocialProfile ===\n");
            SocialProfile sp = new SocialProfile("dev", "GitHub");
            Console.WriteLine(sp);
        }
    }
}

// 49
using System;

namespace StructMeasurementDemo
{
    struct Measurement
    {
        public double Value { get; }
        public string Unit { get; }

        public Measurement(double value, string unit)
        {
            Value = value; Unit = unit;
        }

        public override string ToString() => $"{Value} {Unit}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 49: Measurement ===\n");
            Measurement m = new Measurement(25.5, "°C");
            Console.WriteLine(m);
        }
    }
}

// 50
using System;

namespace StructPasswordDemo
{
    struct Password
    {
        public string Value { get; }

        public Password(string password)
        {
            if (password.Length < 8) throw new ArgumentException("Password too short");
            if (!password.Any(char.IsUpper)) throw new ArgumentException("Needs uppercase");
            if (!password.Any(char.IsDigit)) throw new ArgumentException("Needs digit");
            Value = password;
        }

        public override string ToString() => new string('*', Value.Length);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 50: Password с валидацией ===\n");
            Password p = new Password("Secure123");
            Console.WriteLine($"Password: {p}");
        }
    }
}

// =============================================
// Раздел 3: Наследование в структурах (51-75)
// =============================================

// 51
using System;

namespace StructShapeDemo
{
    struct Shape
    {
        public virtual double Area => 0;
    }

    struct Point : Shape
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x; Y = y;
        }

        public override double Area => 0;
        public override string ToString() => $"Point({X},{Y})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 51: Shape и Point ===\n");
            Point p = new Point(1, 2);
            Console.WriteLine(p);
        }
    }
}

// 52
using System;

namespace StructVehicleDemo
{
    struct Vehicle
    {
        public string Name { get; }
        public Vehicle(string name) => Name = name;
        public virtual string Move() => "Moving";
    }

    struct Car : Vehicle
    {
        public Car(string name) : base(name) { }
        public override string Move() => $"{Name} drives on road";
    }

    struct Bicycle : Vehicle
    {
        public Bicycle(string name) : base(name) { }
        public override string Move() => $"{Name} pedals";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 52: Vehicle иерархия ===\n");
            Car c = new Car("Tesla");
            Bicycle b = new Bicycle("BMX");
            Console.WriteLine(c.Move());
            Console.WriteLine(b.Move());
        }
    }
}

// 53
using System;

namespace StructAnimalDemo
{
    struct Animal
    {
        public string Name { get; }
        public Animal(string name) => Name = name;
    }

    struct Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public string Bark() => $"{Name} says Woof!";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 53: Animal и Dog ===\n");
            Dog d = new Dog("Rex");
            Console.WriteLine(d.Bark());
        }
    }
}

// 54
using System;

namespace StructPointComparableDemo
{
    struct Point : IComparable<Point>
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) { X = x; Y = y; }

        public int CompareTo(Point other)
        {
            double d1 = X * X + Y * Y;
            double d2 = other.X * other.X + other.Y * other.Y;
            return d1.CompareTo(d2);
        }

        public override string ToString() => $"({X},{Y})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 54: IComparable<Point> ===\n");
            Point[] points = { new Point(3, 4), new Point(1, 1), new Point(0, 0) };
            Array.Sort(points);
            foreach (var p in points) Console.WriteLine(p);
        }
    }
}

// 55
using System;

namespace StructNumberEquatableDemo
{
    struct Number : IEquatable<Number>
    {
        public int Value { get; }
        public Number(int value) => Value = value;

        public bool Equals(Number other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Number n && Equals(n);
        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 55: IEquatable ===\n");
            Number a = new Number(42);
            Number b = new Number(42);
            Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
        }
    }
}

// 56
using System;

namespace StructEmployeeCloneableDemo
{
    struct Employee : ICloneable
    {
        public string Name { get; }
        public int Id { get; }

        public Employee(string name, int id) { Name = name; Id = id; }

        public object Clone() => new Employee(Name, Id);
        public override string ToString() => $"{Name} (ID: {Id})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 56: ICloneable ===\n");
            Employee e1 = new Employee("Alice", 1);
            Employee e2 = (Employee)e1.Clone();
            Console.WriteLine($"Clone: {e2}");
        }
    }
}

// 57
using System;

namespace StructShapeDrawableDemo
{
    interface IDrawable
    {
        void Draw();
    }

    struct Rectangle : IDrawable
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double w, double h) { Width = w; Height = h; }

        public void Draw() => Console.WriteLine($"Drawing rectangle {Width}x{Height}");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 57: IDrawable ===\n");
            IDrawable r = new Rectangle(5, 3);
            r.Draw();
        }
    }
}

// 58
using System;

namespace StructPersonValidatableDemo
{
    interface IValidatable
    {
        bool IsValid();
    }

    struct Person : IValidatable
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age) { Name = name; Age = age; }

        public bool IsValid() => !string.IsNullOrEmpty(Name) && Age >= 0;
        public override string ToString() => $"{Name}, {Age}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 58: IValidatable ===\n");
            Person p = new Person("Bob", 25);
            Console.WriteLine($"Valid: {p.IsValid()}");
        }
    }
}

// 59
using System;

namespace StructDocumentSaveableDemo
{
    interface ISaveable
    {
        void Save(string path);
    }

    struct Document : ISaveable
    {
        public string Title { get; }
        public string Content { get; }

        public Document(string title, string content) { Title = title; Content = content; }

        public void Save(string path) => Console.WriteLine($"Saving '{Title}' to {path}");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 59: ISaveable ===\n");
            Document d = new Document("Report", "Content...");
            d.Save("report.txt");
        }
    }
}

// 60
using System;
using System.Collections;
using System.Collections.Generic;

namespace StructContainerEnumerableDemo
{
    struct Container : IEnumerable<int>
    {
        private readonly int[] items;

        public Container(int[] data) => items = data;

        public IEnumerator<int> GetEnumerator() => ((IEnumerable<int>)items).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 60: IEnumerable ===\n");
            Container c = new Container(new[] { 1, 2, 3 });
            foreach (int i in c) Console.WriteLine(i);
        }
    }
}

// 61
using System;

namespace StructStreamDisposableDemo
{
    struct Stream : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Stream disposed");
                disposed = true;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 61: IDisposable ===\n");
            using (var s = new Stream()) { }
        }
    }
}

// 62
using System;

namespace StructComparableDemo
{
    struct Money : IComparable<Money>
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency) { Amount = amount; Currency = currency; }

        public int CompareTo(Money other)
        {
            if (Currency != other.Currency) throw new InvalidOperationException("Different currencies");
            return Amount.CompareTo(other.Amount);
        }

        public override string ToString() => $"{Amount} {Currency}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 62: IComparable ===\n");
            Money[] moneys = { new Money(100, "USD"), new Money(50, "USD"), new Money(200, "USD") };
            Array.Sort(moneys);
            foreach (var m in moneys) Console.WriteLine(m);
        }
    }
}

// 63
using System;

namespace StructMoneyFormattableDemo
{
    struct Money : IFormattable
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency) { Amount = amount; Currency = currency; }

        public string ToString(string format, IFormatProvider provider)
        {
            return format switch
            {
                "C" => $"{Amount:C} {Currency}",
                "N" => $"{Amount:N2} {Currency}",
                _ => $"{Amount} {Currency}"
            };
        }

        public override string ToString() => ToString(null, null);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 63: IFormattable ===\n");
            Money m = new Money(1234.56m, "EUR");
            Console.WriteLine(m.ToString("C", null));
            Console.WriteLine(m.ToString("N", null));
        }
    }
}

// 64
using System;

namespace StructEventDemo
{
    struct Event
    {
        public string Name { get; }
        public DateTime Date { get; }

        public Event(string name, DateTime date) { Name = name; Date = date; }

        public override string ToString() => $"{Date:yyyy-MM-dd} - {Name}";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 64: Event ===\n");
            Event e = new Event("Conference", new DateTime(2025, 12, 1));
            Console.WriteLine(e);
        }
    }
}

// 65
using System;

namespace StructLoggerDemo
{
    interface ILogger
    {
        void Log(string message);
    }

    struct Logger : ILogger
    {
        public void Log(string message) => Console.WriteLine($"[LOG] {message}");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 65: ILogger ===\n");
            ILogger logger = new Logger();
            logger.Log("Application started");
        }
    }
}

// 66
using System;
using System.Collections;

namespace StructCollectionDemo
{
    struct Collection : ICollection
    {
        private readonly ArrayList list;

        public Collection() => list = new ArrayList();

        public int Count => list.Count;
        public bool IsSynchronized => list.IsSynchronized;
        public object SyncRoot => list.SyncRoot;

        public void CopyTo(Array array, int index) => list.CopyTo(array, index);
        public IEnumerator GetEnumerator() => list.GetEnumerator();
        public void Add(object item) => list.Add(item);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 66: ICollection ===\n");
            Collection c = new Collection();
            c.Add("Item1");
            Console.WriteLine($"Count: {c.Count}");
        }
    }
}

// 67
using System;

namespace StructObserverDemo
{
    interface IObserver<T>
    {
        void OnNext(T value);
    }

    struct ConsoleObserver : IObserver<int>
    {
        public void OnNext(int value) => Console.WriteLine($"Observed: {value}");
        public void OnError(Exception error) { }
        public void OnCompleted() { }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 67: IObserver ===\n");
            IObserver<int> observer = new ConsoleObserver();
            observer.OnNext(42);
        }
    }
}

// 68
using System;

namespace StructServiceDisposableDemo
{
    struct Service : IDisposable
    {
        private bool disposed;

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Service cleanup");
                disposed = true;
            }
        }

        ~Service()
        {
            if (!disposed)
            {
                Console.WriteLine("Finalizer cleanup");
                Dispose();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 68: IDisposable с финализатором ===\n");
            using (var s = new Service()) { }
        }
    }
}

// 69
using System;

namespace StructValidatorDemo
{
    interface IValidator<T>
    {
        bool Validate(T value);
    }

    struct RangeValidator : IValidator<int>
    {
        private readonly int min, max;
        public RangeValidator(int min, int max) { this.min = min; this.max = max; }
        public bool Validate(int value) => value >= min && value <= max;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 69: IValidator ===\n");
            IValidator<int> v = new RangeValidator(1, 100);
            Console.WriteLine($"42 valid: {v.Validate(42)}");
        }
    }
}

// 70
using System;

namespace StructHandlerDemo
{
    interface IHandler
    {
        void Handle();
    }

    struct ClickHandler : IHandler
    {
        public void Handle() => Console.WriteLine("Click handled");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 70: IHandler ===\n");
            IHandler h = new ClickHandler();
            h.Handle();
        }
    }
}

// 71
using System;

namespace StructCacheDemo
{
    interface ICacheable
    {
        void Cache();
        void Invalidate();
    }

    struct CacheItem : ICacheable
    {
        public string Key { get; }
        public CacheItem(string key) => Key = key;

        public void Cache() => Console.WriteLine($"Cached: {Key}");
        public void Invalidate() => Console.WriteLine($"Invalidated: {Key}");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 71: ICacheable ===\n");
            ICacheable c = new CacheItem("user:123");
            c.Cache();
        }
    }
}

// 72
using System;

namespace StructParserDemo
{
    interface IParser<T>
    {
        T Parse(string input);
    }

    struct IntParser : IParser<int>
    {
        public int Parse(string input) => int.Parse(input);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 72: IParser ===\n");
            IParser<int> p = new IntParser();
            Console.WriteLine(p.Parse("123"));
        }
    }
}

// 73
using System;
using System.Collections.Generic;

namespace StructComparerDemo
{
    struct StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Length.CompareTo(y.Length);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 73: IComparer ===\n");
            var list = new List<string> { "apple", "hi", "banana" };
            list.Sort(new StringLengthComparer());
            Console.WriteLine(string.Join(", ", list));
        }
    }
}

// 74
using System;

namespace StructSerializableDemo
{
    interface ISerializable
    {
        string Serialize();
    }

    struct Point : ISerializable
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) { X = x; Y = y; }

        public string Serialize() => $"{X},{Y}";
        public override string ToString() => Serialize();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 74: ISerializable ===\n");
            Point p = new Point(1.5, 2.5);
            Console.WriteLine(p.Serialize());
        }
    }
}

// 75
using System;
using System.Threading.Tasks;

namespace StructAsyncTaskDemo
{
    interface IAsyncOperation
    {
        Task ExecuteAsync();
    }

    struct DelayOperation : IAsyncOperation
    {
        private readonly int ms;

        public DelayOperation(int ms) => this.ms = ms;

        public async Task ExecuteAsync()
        {
            Console.WriteLine("Starting...");
            await Task.Delay(ms);
            Console.WriteLine("Done!");
        }
    }

    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 75: IAsyncOperation ===\n");
            IAsyncOperation op = new DelayOperation(1000);
            await op.ExecuteAsync();
        }
    }
}

// =============================================
// Раздел 4: Вложенные структуры и классы (76-100)
// =============================================

// 76
using System;

namespace NestedCompanyDemo
{
    struct Company
    {
        public string Name { get; }
        public Employee CEO { get; }

        public Company(string name, Employee ceo)
        {
            Name = name; CEO = ceo;
        }

        public struct Employee
        {
            public string Name { get; }
            public string Title { get; }

            public Employee(string name, string title)
            {
                Name = name; Title = title;
            }

            public override string ToString() => $"{Name}, {Title}";
        }

        public override string ToString() => $"{Name} (CEO: {CEO})";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 76: Company с Employee ===\n");
            var ceo = new Company.Employee("Elon", "CEO");
            Company c = new Company("SpaceX", ceo);
            Console.WriteLine(c);
        }
    }
}

// 77
using System;

namespace NestedTreeDemo
{
    struct Tree
    {
        public Node Root { get; }

        public Tree(Node root) => Root = root;

        public class Node
        {
            public int Value { get; }
            public Node Left { get; }
            public Node Right { get; }

            public Node(int value, Node left = null, Node right = null)
            {
                Value = value; Left = left; Right = right;
            }

            public override string ToString() => Value.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 77: Tree с Node ===\n");
            var leaf = new Tree.Node(1);
            var root = new Tree.Node(2, leaf);
            Tree tree = new Tree(root);
            Console.WriteLine($"Root: {tree.Root}");
        }
    }
}

// 78
using System;

namespace NestedGraphDemo
{
    struct Graph
    {
        public List<Vertex> Vertices { get; }
        public List<Edge> Edges { get; }

        public Graph(List<Vertex> v, List<Edge> e)
        {
            Vertices = v; Edges = e;
        }

        public class Vertex
        {
            public string Id { get; }
            public Vertex(string id) => Id = id;
            public override string ToString() => Id;
        }

        public class Edge
        {
            public Vertex From { get; }
            public Vertex To { get; }
            public Edge(Vertex from, Vertex to) { From = from; To = to; }
            public override string ToString() => $"{From} -> {To}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 78: Graph с Vertex/Edge ===\n");
            var a = new Graph.Vertex("A");
            var b = new Graph.Vertex("B");
            var edge = new Graph.Edge(a, b);
            Console.WriteLine(edge);
        }
    }
}

// 79
using System;

namespace NestedLibraryDemo
{
    struct Library
    {
        public string Name { get; }
        public List<Book> Books { get; }

        public Library(string name, List<Book> books)
        {
            Name = name; Books = books;
        }

        public struct Book
        {
            public string Title { get; }
            public string Author { get; }

            public Book(string title, string author)
            {
                Title = title; Author = author;
            }

            public override string ToString() => $"'{Title}' by {Author}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 79: Library с Book ===\n");
            var book = new Library.Book("1984", "Orwell");
            Console.WriteLine(book);
        }
    }
}

// =============================================
// Раздел 4: Вложенные структуры и классы (80-100)
// =============================================

// 80
using System;

namespace NestedDictionaryDemo
{
    struct Dictionary
    {
        public List<Entry> Entries { get; }

        public Dictionary(List<Entry> entries)
        {
            Entries = entries ?? new List<Entry>();
        }

        public struct Entry
        {
            public string Key { get; }
            public string Value { get; }

            public Entry(string key, string value)
            {
                Key = key; Value = value;
            }

            public override string ToString() => $"{Key}: {Value}";
        }

        public override string ToString() => $"Dictionary with {Entries.Count} entries";
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 80: Dictionary с Entry ===\n");
            var entries = new List<Dictionary.Entry>
            {
                new Dictionary.Entry("name", "Alice"),
                new Dictionary.Entry("age", "30")
            };
            Dictionary dict = new Dictionary(entries);
            foreach (var e in dict.Entries)
                Console.WriteLine(e);
        }
    }
}

// 81
using System;

namespace NestedLinkedListDemo
{
    struct LinkedList<T>
    {
        public Node Head { get; }

        public LinkedList(Node head) => Head = head;

        public class Node
        {
            public T Data { get; }
            public Node Next { get; }

            public Node(T data, Node next = null)
            {
                Data = data; Next = next;
            }

            public override string ToString() => Data?.ToString() ?? "null";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 81: LinkedList с Node ===\n");
            var node3 = new LinkedList<int>.Node(3);
            var node2 = new LinkedList<int>.Node(2, node3);
            var node1 = new LinkedList<int>.Node(1, node2);
            LinkedList<int> list = new LinkedList<int>(node1);

            var current = list.Head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}

// 82
using System;

namespace NestedDatabaseDemo
{
    struct Database
    {
        public string Name { get; }
        public List<Table> Tables { get; }

        public Database(string name, List<Table> tables)
        {
            Name = name; Tables = tables ?? new List<Table>();
        }

        public class Table
        {
            public string Name { get; }
            public List<Column> Columns { get; }

            public Table(string name, List<Column> columns)
            {
                Name = name; Columns = columns ?? new List<Column>();
            }

            public class Column
            {
                public string Name { get; }
                public string Type { get; }

                public Column(string name, string type)
                {
                    Name = name; Type = type;
                }

                public override string ToString() => $"{Name} ({Type})";
            }

            public override string ToString() => $"{Name} ({Columns.Count} columns)";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 82: Database с Table и Column ===\n");
            var columns = new List<Database.Table.Column>
            {
                new Database.Table.Column("Id", "INT"),
                new Database.Table.Column("Name", "VARCHAR(50)")
            };
            var table = new Database.Table("Users", columns);
            var db = new Database("AppDB", new List<Database.Table> { table });

            Console.WriteLine(db.Name);
            foreach (var t in db.Tables)
            {
                Console.WriteLine($"  {t}");
                foreach (var c in t.Columns)
                    Console.WriteLine($"    {c}");
            }
        }
    }
}

// 83
using System;

namespace NestedWindowDemo
{
    struct Window
    {
        public string Title { get; }
        public List<Button> Buttons { get; }
        public List<TextField> TextFields { get; }

        public Window(string title, List<Button> buttons, List<TextField> textFields)
        {
            Title = title;
            Buttons = buttons ?? new List<Button>();
            TextFields = textFields ?? new List<TextField>();
        }

        public class Button
        {
            public string Label { get; }
            public Button(string label) => Label = label;
            public override string ToString() => $"[Button: {Label}]";
        }

        public class TextField
        {
            public string Placeholder { get; }
            public TextField(string placeholder) => Placeholder = placeholder;
            public override string ToString() => $"[Text: {Placeholder}]";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 83: Window с Button и TextField ===\n");
            var buttons = new List<Window.Button> { new Window.Button("OK"), new Window.Button("Cancel") };
            var texts = new List<Window.TextField> { new Window.TextField("Enter name") };
            Window win = new Window("Login", buttons, texts);

            Console.WriteLine(win.Title);
            foreach (var b in win.Buttons) Console.WriteLine(b);
            foreach (var t in win.TextFields) Console.WriteLine(t);
        }
    }
}

// 84
using System;

namespace NestedGameDemo
{
    struct Game
    {
        public string Title { get; }
        public Player CurrentPlayer { get; }
        public Level CurrentLevel { get; }

        public Game(string title, Player player, Level level)
        {
            Title = title; CurrentPlayer = player; CurrentLevel = level;
        }

        public struct Player
        {
            public string Name { get; }
            public int Score { get; }

            public Player(string name, int score)
            {
                Name = name; Score = score;
            }

            public override string ToString() => $"{Name} ({Score} pts)";
        }

        public struct Level
        {
            public int Number { get; }
            public string Name { get; }

            public Level(int number, string name)
            {
                Number = number; Name = name;
            }

            public override string ToString() => $"Level {Number}: {Name}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 84: Game с Player и Level ===\n");
            Game.Player p = new Game.Player("Hero", 1500);
            Game.Level l = new Game.Level(5, "Boss Fight");
            Game game = new Game("Adventure", p, l);

            Console.WriteLine($"{game.Title} - {game.CurrentPlayer} - {game.CurrentLevel}");
        }
    }
}

// 85
using System;

namespace NestedAPIDemo
{
    struct API
    {
        public string BaseUrl { get; }

        public API(string baseUrl) => BaseUrl = baseUrl;

        public class Request
        {
            public string Endpoint { get; }
            public string Method { get; }

            public Request(string endpoint, string method = "GET")
            {
                Endpoint = endpoint; Method = method;
            }

            public override string ToString() => $"{Method} {Endpoint}";
        }

        public class Response
        {
            public int StatusCode { get; }
            public string Body { get; }

            public Response(int status, string body)
            {
                StatusCode = status; Body = body;
            }

            public override string ToString() => $"{StatusCode}: {Body}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 85: API с Request и Response ===\n");
            API api = new API("https://api.example.com");
            API.Request req = new API.Request("/users", "POST");
            API.Response res = new API.Response(201, "User created");

            Console.WriteLine($"{api.BaseUrl}{req} -> {res}");
        }
    }
}

// 86
using System;

namespace NestedProjectDemo
{
    struct Project
    {
        public string Name { get; }
        public List<Task> Tasks { get; }
        public List<Milestone> Milestones { get; }

        public Project(string name, List<Task> tasks, List<Milestone> milestones)
        {
            Name = name; Tasks = tasks ?? new List<Task>(); Milestones = milestones ?? new List<Milestone>();
        }

        public class Task
        {
            public string Description { get; }
            public bool IsCompleted { get; }

            public Task(string desc, bool completed = false)
            {
                Description = desc; IsCompleted = completed;
            }

            public override string ToString() => $"{(IsCompleted ? "[x]" : "[ ]")} {Description}";
        }

        public class Milestone
        {
            public string Name { get; }
            public DateTime DueDate { get; }

            public Milestone(string name, DateTime due)
            {
                Name = name; DueDate = due;
            }

            public override string ToString() => $"{Name} - {DueDate:yyyy-MM-dd}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 86: Project с Task и Milestone ===\n");
            var tasks = new List<Project.Task>
            {
                new Project.Task("Design UI", true),
                new Project.Task("Implement API")
            };
            var milestones = new List<Project.Milestone>
            {
                new Project.Milestone("Alpha", new DateTime(2025, 12, 1))
            };
            Project proj = new Project("App v2", tasks, milestones);

            Console.WriteLine(proj.Name);
            foreach (var t in proj.Tasks) Console.WriteLine($"  {t}");
            foreach (var m in proj.Milestones) Console.WriteLine($"  {m}");
        }
    }
}

// 87
using System;

namespace NestedMenuDemo
{
    struct Menu
    {
        public string Title { get; }
        public List<Item> Items { get; }

        public Menu(string title, List<Item> items)
        {
            Title = title; Items = items ?? new List<Item>();
        }

        public class Item
        {
            public string Label { get; }
            public Submenu Submenu { get; }

            public Item(string label, Submenu submenu = null)
            {
                Label = label; Submenu = submenu;
            }

            public override string ToString() => Submenu != null ? $"{Label} >" : Label;
        }

        public class Submenu
        {
            public List<Item> Items { get; }

            public Submenu(List<Item> items) => Items = items ?? new List<Item>();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 87: Menu с Item и Submenu ===\n");
            var fileItems = new List<Menu.Item>
            {
                new Menu.Item("New"),
                new Menu.Item("Open"),
                new Menu.Item("Save")
            };
            var fileSubmenu = new Menu.Submenu(fileItems);
            var menuItems = new List<Menu.Item>
            {
                new Menu.Item("File", fileSubmenu),
                new Menu.Item("Edit"),
                new Menu.Item("Help")
            };
            Menu menu = new Menu("Main Menu", menuItems);

            Console.WriteLine(menu.Title);
            foreach (var item in menu.Items)
                Console.WriteLine($"  {item}");
        }
    }
}

// 88
using System;

namespace NestedDocumentDemo
{
    struct Document
    {
        public string Title { get; }
        public List<Section> Sections { get; }

        public Document(string title, List<Section> sections)
        {
            Title = title; Sections = sections ?? new List<Section>();
        }

        public class Section
        {
            public string Heading { get; }
            public List<Paragraph> Paragraphs { get; }

            public Section(string heading, List<Paragraph> paragraphs)
            {
                Heading = heading; Paragraphs = paragraphs ?? new List<Paragraph>();
            }

            public class Paragraph
            {
                public string Text { get; }

                public Paragraph(string text) => Text = text;

                public override string ToString() => Text;
            }

            public override string ToString() => $"## {Heading}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 88: Document с Section и Paragraph ===\n");
            var p1 = new Document.Section.Paragraph("This is the first paragraph.");
            var p2 = new Document.Section.Paragraph("This is the second one.");
            var section = new Document.Section("Introduction", new List<Document.Section.Paragraph> { p1, p2 });
            var doc = new Document("Report", new List<Document.Section> { section });

            Console.WriteLine(doc.Title);
            foreach (var s in doc.Sections)
            {
                Console.WriteLine(s);
                foreach (var p in s.Paragraphs)
                    Console.WriteLine($"  {p}");
            }
        }
    }
}

// 89
using System;

namespace NestedNetworkDemo
{
    struct Network
    {
        public string Name { get; }
        public List<Host> Hosts { get; }

        public Network(string name, List<Host> hosts)
        {
            Name = name; Hosts = hosts ?? new List<Host>();
        }

        public struct Host
        {
            public string IP { get; }
            public List<Port> OpenPorts { get; }

            public Host(string ip, List<Port> ports)
            {
                IP = ip; OpenPorts = ports ?? new List<Port>();
            }

            public override string ToString() => $"{IP}";
        }

        public struct Port
        {
            public int Number { get; }
            public string Service { get; }

            public Port(int number, string service)
            {
                Number = number; Service = service;
            }

            public override string ToString() => $"{Number}/{Service}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 89: Network с Host и Port ===\n");
            var ports = new List<Network.Port>
            {
                new Network.Port(80, "HTTP"),
                new Network.Port(443, "HTTPS")
            };
            var host = new Network.Host("192.168.1.10", ports);
            var net = new Network("Local", new List<Network.Host> { host });

            Console.WriteLine(net.Name);
            foreach (var h in net.Hosts)
            {
                Console.WriteLine($"  Host: {h}");
                foreach (var p in h.OpenPorts)
                    Console.WriteLine($"    Port: {p}");
            }
        }
    }
}

// 90
using System;

namespace NestedTransactionDemo
{
    struct Transaction
    {
        public string Id { get; }
        public decimal Amount { get; }
        public List<Detail> Details { get; }

        public Transaction(string id, decimal amount, List<Detail> details)
        {
            Id = id; Amount = amount; Details = details ?? new List<Detail>();
        }

        public struct Detail
        {
            public string Description { get; }
            public decimal Value { get; }

            public Detail(string desc, decimal value)
            {
                Description = desc; Value = value;
            }

            public override string ToString() => $"{Description}: {Value:C}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 90: Transaction с Detail ===\n");
            var details = new List<Transaction.Detail>
            {
                new Transaction.Detail("Item A", 10.99m),
                new Transaction.Detail("Item B", 25.50m)
            };
            Transaction tx = new Transaction("TX123", 36.49m, details);

            Console.WriteLine($"Transaction {tx.Id} - Total: {tx.Amount:C}");
            foreach (var d in tx.Details)
                Console.WriteLine($"  {d}");
        }
    }
}

// 91
using System;

namespace NestedFormDemo
{
    struct Form
    {
        public string Title { get; }
        public List<Field> Fields { get; }

        public Form(string title, List<Field> fields)
        {
            Title = title; Fields = fields ?? new List<Field>();
        }

        public class Field
        {
            public string Label { get; }
            public string Type { get; }
            public bool IsRequired { get; }

            public Field(string label, string type, bool required = false)
            {
                Label = label; Type = type; IsRequired = required;
            }

            public override string ToString() => $"{Label} ({Type}){(IsRequired ? " *" : "")}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 91: Form с Field ===\n");
            var fields = new List<Form.Field>
            {
                new Form.Field("Name", "text", true),
                new Form.Field("Email", "email", true),
                new Form.Field("Subscribe", "checkbox")
            };
            Form form = new Form("Contact", fields);

            Console.WriteLine(form.Title);
            foreach (var f in form.Fields)
                Console.WriteLine($"  {f}");
        }
    }
}

// 92
using System;

namespace NestedReportDemo
{
    struct Report
    {
        public Header ReportHeader { get; }
        public Body ReportBody { get; }

        public Report(Header header, Body body)
        {
            ReportHeader = header; ReportBody = body;
        }

        public class Header
        {
            public string Title { get; }
            public DateTime Generated { get; }

            public Header(string title, DateTime generated)
            {
                Title = title; Generated = generated;
            }

            public override string ToString() => $"{Title} - {Generated:yyyy-MM-dd HH:mm}";
        }

        public class Body
        {
            public string Content { get; }

            public Body(string content) => Content = content;

            public override string ToString() => Content;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 92: Report с Header и Body ===\n");
            Report.Header h = new Report.Header("Monthly Report", DateTime.Now);
            Report.Body b = new Report.Body("Sales increased by 15%...");
            Report r = new Report(h, b);

            Console.WriteLine(r.ReportHeader);
            Console.WriteLine(r.ReportBody);
        }
    }
}

// 93
using System;

namespace NestedShoppingDemo
{
    struct ShoppingCart
    {
        public List<CartItem> Items { get; }

        public ShoppingCart(List<CartItem> items) => Items = items ?? new List<CartItem>();

        public struct CartItem
        {
            public string ProductName { get; }
            public int Quantity { get; }
            public decimal Price { get; }

            public CartItem(string name, int qty, decimal price)
            {
                ProductName = name; Quantity = qty; Price = price;
            }

            public decimal Total => Quantity * Price;
            public override string ToString() => $"{ProductName} x{Quantity} = {Total:C}";
        }

        public decimal Total => Items.Sum(i => i.Total);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 93: Shopping с CartItem ===\n");
            var items = new List<ShoppingCart.CartItem>
            {
                new ShoppingCart.CartItem("Laptop", 1, 999.99m),
                new ShoppingCart.CartItem("Mouse", 2, 25.50m)
            };
            ShoppingCart cart = new ShoppingCart(items);

            foreach (var item in cart.Items)
                Console.WriteLine(item);
            Console.WriteLine($"Total: {cart.Total:C}");
        }
    }
}

// 94
using System;

namespace NestedSchoolDemo
{
    struct School
    {
        public string Name { get; }
        public List<Class> Classes { get; }

        public School(string name, List<Class> classes)
        {
            Name = name; Classes = classes ?? new List<Class>();
        }

        public class Class
        {
            public string Grade { get; }
            public List<Student> Students { get; }

            public Class(string grade, List<Student> students)
            {
                Grade = grade; Students = students ?? new List<Student>();
            }

            public class Student
            {
                public string Name { get; }
                public int Id { get; }

                public Student(string name, int id)
                {
                    Name = name; Id = id;
                }

                public override string ToString() => $"{Name} (ID: {Id})";
            }

            public override string ToString() => $"{Grade} ({Students.Count} students)";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 94: School с Class и Student ===\n");
            var students = new List<School.Class.Student>
            {
                new School.Class.Student("Alice", 101),
                new School.Class.Student("Bob", 102)
            };
            var class8A = new School.Class("8A", students);
            var school = new School("Central High", new List<School.Class> { class8A });

            Console.WriteLine(school.Name);
            foreach (var c in school.Classes)
            {
                Console.WriteLine($"  {c}");
                foreach (var s in c.Students)
                    Console.WriteLine($"    {s}");
            }
        }
    }
}

// 95
using System;

namespace NestedHospitalDemo
{
    struct Hospital
    {
        public string Name { get; }
        public List<Doctor> Doctors { get; }
        public List<Patient> Patients { get; }

        public Hospital(string name, List<Doctor> doctors, List<Patient> patients)
        {
            Name = name; Doctors = doctors ?? new List<Doctor>(); Patients = patients ?? new List<Patient>();
        }

        public struct Doctor
        {
            public string Name { get; }
            public string Specialty { get; }

            public Doctor(string name, string specialty)
            {
                Name = name; Specialty = specialty;
            }

            public override string ToString() => $"{Name}, {Specialty}";
        }

        public struct Patient
        {
            public string Name { get; }
            public int Room { get; }

            public Patient(string name, int room)
            {
                Name = name; Room = room;
            }

            public override string ToString() => $"{Name}, Room {Room}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 95: Hospital с Doctor и Patient ===\n");
            var doctors = new List<Hospital.Doctor>
            {
                new Hospital.Doctor("Dr. Smith", "Cardiology")
            };
            var patients = new List<Hospital.Patient>
            {
                new Hospital.Patient("John Doe", 205)
            };
            Hospital hospital = new Hospital("City Hospital", doctors, patients);

            Console.WriteLine(hospital.Name);
            Console.WriteLine("Doctors:");
            foreach (var d in hospital.Doctors) Console.WriteLine($"  {d}");
            Console.WriteLine("Patients:");
            foreach (var p in hospital.Patients) Console.WriteLine($"  {p}");
        }
    }
}

// 96
using System;

namespace NestedQueueDemo
{
    struct Queue<T>
    {
        public Node Front { get; }
        public Node Rear { get; }

        public Queue(Node front, Node rear)
        {
            Front = front; Rear = rear;
        }

        public class Node
        {
            public T Data { get; }
            public Node Next { get; }

            public Node(T data, Node next = null)
            {
                Data = data; Next = next;
            }

            public override string ToString() => Data?.ToString() ?? "null";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 96: Queue с Node ===\n");
            var node3 = new Queue<int>.Node(3);
            var node2 = new Queue<int>.Node(2, node3);
            var node1 = new Queue<int>.Node(1, node2);
            Queue<int> queue = new Queue<int>(node1, node3);

            var current = queue.Front;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}

// 97
using System;

namespace NestedStackDemo
{
    struct Stack<T>
    {
        public Element Top { get; }

        public Stack(Element top) => Top = top;

        public class Element
        {
            public T Data { get; }
            public Element Below { get; }

            public Element(T data, Element below = null)
            {
                Data = data; Below = below;
            }

            public override string ToString() => Data?.ToString() ?? "null";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 97: Stack с Element ===\n");
            var bottom = new Stack<int>.Element(1);
            var middle = new Stack<int>.Element(2, bottom);
            var top = new Stack<int>.Element(3, middle);
            Stack<int> stack = new Stack<int>(top);

            var current = stack.Top;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Below;
            }
        }
    }
}

// 98
using System;

namespace NestedContainerDemo
{
    struct Container
    {
        public List<IElement> Elements { get; }

        public Container(List<IElement> elements) => Elements = elements ?? new List<IElement>();

        public interface IElement
        {
            void Render();
        }

        public class Text : IElement
        {
            public string Content { get; }
            public Text(string content) => Content = content;
            public void Render() => Console.WriteLine($"Text: {Content}");
        }

        public class Image : IElement
        {
            public string Url { get; }
            public Image(string url) => Url = url;
            public void Render() => Console.WriteLine($"Image: {Url}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 98: Container с IElement ===\n");
            var elements = new List<Container.IElement>
            {
                new Container.Text("Hello"),
                new Container.Image("logo.png")
            };
            Container container = new Container(elements);

            foreach (var el in container.Elements)
                el.Render();
        }
    }
}

// 99
using System;

namespace NestedBlogDemo
{
    struct Blog
    {
        public List<Post> Posts { get; }

        public Blog(List<Post> posts) => Posts = posts ?? new List<Post>();

        public class Post
        {
            public string Title { get; }
            public string Content { get; }
            public List<Comment> Comments { get; }

            public Post(string title, string content, List<Comment> comments = null)
            {
                Title = title; Content = content; Comments = comments ?? new List<Comment>();
            }

            public class Comment
            {
                public string Author { get; }
                public string Text { get; }

                public Comment(string author, string text)
                {
                    Author = author; Text = text;
                }

                public override string ToString() => $"{Author}: {Text}";
            }

            public override string ToString() => $"{Title} ({Comments.Count} comments)";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 99: Blog с Post и Comment ===\n");
            var comments = new List<Blog.Post.Comment>
            {
                new Blog.Post.Comment("Alice", "Great post!"),
                new Blog.Post.Comment("Bob", "Thanks for sharing.")
            };
            var post = new Blog.Post("C# Tips", "Here are some tips...", comments);
            var blog = new Blog(new List<Blog.Post> { post });

            foreach (var p in blog.Posts)
            {
                Console.WriteLine(p);
                foreach (var c in p.Comments)
                    Console.WriteLine($"  {c}");
            }
        }
    }
}

// 100
using System;

namespace NestedRepositoryDemo
{
    struct Repository<T> where T : Entity
    {
        public List<T> Entities { get; }

        public Repository(List<T> entities) => Entities = entities ?? new List<T>();

        public struct Entity
        {
            public int Id { get; }
            public string Name { get; }

            public Entity(int id, string name)
            {
                Id = id; Name = name;
            }

            public override string ToString() => $"{Id}: {Name}";
        }
    }

    class User : Repository<Entity>.Entity
    {
        public User(int id, string name) : base(id, name) { }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 100: Repository с Entity ===\n");
            var users = new List<User>
            {
                new User(1, "Alice"),
                new User(2, "Bob")
            };
            Repository<User> repo = new Repository<User>(users);

            foreach (var user in repo.Entities)
                Console.WriteLine(user);
        }
    }
}