// 1
using System;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

class Program1
{
    static void Main()
    {
        Cat cat = new Cat();
        cat.Speak();
    }
}

// 2
using System;

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

public class Bus : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bus engine started");
    }
}

class Program2
{
    static void Main()
    {
        Car car = new Car();
        Bus bus = new Bus();
        car.Start();
        bus.Start();
    }
}

// 3
using System;

public class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width * Height;
    }
}

class Program3
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        Rectangle r = new Rectangle { Width = 4, Height = 6 };
        Console.WriteLine($"Circle: {c.Area():F2}, Rectangle: {r.Area()}");
    }
}

// 4
using System;

public class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Base display");
    }
}

public class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Derived display");
    }
}

class Program4
{
    static void Main()
    {
        DerivedClass d = new DerivedClass();
        d.Display();
    }
}

// 5
using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal created: {Name}");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine("Dog created");
    }
}

class Program5
{
    static void Main()
    {
        Dog dog = new Dog("Rex");
    }
}

// 6
using System;

public class Employee
{
    public string Name { get; set; }
    public virtual decimal CalculateSalary() => 50000m;
}

public class Manager : Employee
{
    public override decimal CalculateSalary() => 80000m;
}

public class Developer : Employee
{
    public override decimal CalculateSalary() => 70000m;
}

class Program6
{
    static void Main()
    {
        Manager m = new Manager { Name = "Alice" };
        Developer d = new Developer { Name = "Bob" };
        Console.WriteLine($"{m.Name}: {m.CalculateSalary():C}");
        Console.WriteLine($"{d.Name}: {d.CalculateSalary():C}");
    }
}

// 7
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Student : Person
{
    public string StudentId { get; set; }
}

class Program7
{
    static void Main()
    {
        Student s = new Student { Name = "John", Age = 20, StudentId = "S123" };
        Console.WriteLine($"{s.Name}, {s.Age}, {s.StudentId}");
    }
}

// 8
using System;

public class BaseClass
{
    protected string Secret = "I'm protected";
}

public class DerivedClass : BaseClass
{
    public void ShowSecret()
    {
        Console.WriteLine(Secret);
    }
}

class Program8
{
    static void Main()
    {
        DerivedClass d = new DerivedClass();
        d.ShowSecret();
    }
}

// 9
using System;

public class Figure
{
    public virtual double Perimeter() => 0;
}

public class Triangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public override double Perimeter() => A + B + C;
}

public class Square : Figure
{
    public double Side { get; set; }
    public override double Perimeter() => 4 * Side;
}

class Program9
{
    static void Main()
    {
        Triangle t = new Triangle { A = 3, B = 4, C = 5 };
        Square s = new Square { Side = 4 };
        Console.WriteLine($"Triangle: {t.Perimeter()}, Square: {s.Perimeter()}");
    }
}

// 10
using System;

public class Device
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Device is on");
    }
}

public class Phone : Device
{
    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine("Phone is on");
    }
}

public class Laptop : Device
{
    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine("Laptop is on");
    }
}

class Program10
{
    static void Main()
    {
        Phone p = new Phone();
        Laptop l = new Laptop();
        p.TurnOn();
        l.TurnOn();
    }
}

// 11
using System;

public abstract class Animal
{
    public abstract void Eat();
}

public class Lion : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Lion eats meat");
    }
}

class Program11
{
    static void Main()
    {
        Lion lion = new Lion();
        lion.Eat();
    }
}

// 12
using System;

public class Base
{
    public virtual void Greet()
    {
        Console.WriteLine("Hello from Base");
    }
}

public class Derived : Base
{
    public override void Greet()
    {
        Console.WriteLine("Hello from Derived");
    }
}

class Program12
{
    static void Main()
    {
        Base b = new Derived();
        b.Greet();
    }
}

// 13
using System;

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Some sound");
    }
}

public class Dog : Animal
{
    public override void Sound() => Console.WriteLine("Woof");
}

public class Cat : Animal
{
    public override void Sound() => Console.WriteLine("Meow");
}

public class Bird : Animal
{
    public override void Sound() => Console.WriteLine("Tweet");
}

class Program13
{
    static void Main()
    {
        Animal[] animals = { new Dog(), new Cat(), new Bird() };
        foreach (var a in animals) a.Sound();
    }
}

// 14
using System;

public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Fly() => Console.WriteLine("Bird flies");
}

class Program14
{
    static void Main()
    {
        IFlyable bird = new Bird();
        bird.Fly();
    }
}

// 15
using System;

public class Vehicle
{
    public virtual void Move() => Console.WriteLine("Vehicle moves");
}

public class Car : Vehicle
{
    public override void Move() => Console.WriteLine("Car drives");
}

public class ElectricCar : Car
{
    public override void Move() => Console.WriteLine("Electric car drives silently");
}

class Program15
{
    static void Main()
    {
        ElectricCar ec = new ElectricCar();
        ec.Move();
    }
}

// 16
using System;

public class Person
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value;
    }
}

class Program16
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Alice";
        Console.WriteLine(p.Name);
    }
}

// 17
using System;

public class Base
{
    protected int value = 42;
}

public class Derived : Base
{
    public void Show() => Console.WriteLine(value);
}

class Program17
{
    static void Main()
    {
        new Derived().Show();
    }
}

// 18
internal class InternalClass
{
    public void Say() => Console.WriteLine("I'm internal");
}

class Program18
{
    static void Main()
    {
        new InternalClass().Say();
    }
}

// 19
using System;

public class Base
{
    protected internal int Data = 100;
}

public class Derived : Base
{
    public void Show() => Console.WriteLine(Data);
}

class Program19
{
    static void Main()
    {
        new Derived().Show();
    }
}

// 20
using System;

public class Example
{
    public int Value = 10;
}

class Program20
{
    static void Main()
    {
        Example e = new Example();
        e.Value = 20;
        Console.WriteLine(e.Value);
    }
}

// 21
using System;

public class Secure
{
    private int secret = 999;
}

class Program21
{
    static void Main()
    {
        Secure s = new Secure();
    }
}

// 22
using System;

public class Base
{
    protected void Helper()
    {
        Console.WriteLine("Helper from base");
    }
}

public class Derived : Base
{
    public void UseHelper() => Helper();
}

class Program22
{
    static void Main()
    {
        new Derived().UseHelper();
    }
}

// 23
using System;

public class ProtectedCtor
{
    protected ProtectedCtor()
    {
        Console.WriteLine("Protected constructor");
    }
}

public class Child : ProtectedCtor
{
    public Child() { }
}

class Program23
{
    static void Main()
    {
        new Child();
    }
}

// 24
internal class InternalOnly
{
    public void Act() => Console.WriteLine("Internal access");
}

class Program24
{
    static void Main()
    {
        new InternalOnly().Act();
    }
}

// 25
using System;

public class PrivateField
{
    private int hidden = 5;
}

class Program25
{
    static void Main()
    {
        PrivateField pf = new PrivateField();
    }
}

// 26
using System;

public class OpenClass
{
    public void PublicMethod() => Console.WriteLine("Public");
}

class Program26
{
    static void Main()
    {
        new OpenClass().PublicMethod();
    }
}

// 27
using System;

public class PrivateMethod
{
    private void Secret() => Console.WriteLine("Secret");
    public void CallSecret() => Secret();
}

class Program27
{
    static void Main()
    {
        new PrivateMethod().CallSecret();
    }
}

// 28
using System;

public class PublicClass
{
    public void Say() => Console.WriteLine("Public");
}

internal class InternalClass
{
    public void Say() => Console.WriteLine("Internal");
}

class Program28
{
    static void Main()
    {
        new PublicClass().Say();
        new InternalClass().Say();
    }
}

// 29
using System;

public class Base
{
    protected internal void Combined() => Console.WriteLine("Protected internal");
}

public class Derived : Base
{
    public void Call() => Combined();
}

class Program29
{
    static void Main()
    {
        new Derived().Call();
    }
}

// 30
using System;

public class PrivateProperty
{
    private string data = "hidden";
    public string GetData() => data;
}

class Program30
{
    static void Main()
    {
        Console.WriteLine(new PrivateProperty().GetData());
    }
}

// 31
using System;

public class Animal
{
    public string Name { get; set; }
    public Animal(string name) => Name = name;
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }
}

class Program31
{
    static void Main()
    {
        Cat c = new Cat("Whiskers");
        Console.WriteLine(c.Name);
    }
}

// 32
using System;

public class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}

public class Student : Person
{
    public Student(string name) : base(name) { }
}

class Program32
{
    static void Main()
    {
        Student s = new Student("Alice");
        Console.WriteLine(s.Name);
    }
}

// 33
using System;

public class Grandparent
{
    public Grandparent() => Console.WriteLine("Grandparent");
}

public class Parent : Grandparent
{
    public Parent() => Console.WriteLine("Parent");
}

public class Child : Parent
{
    public Child() => Console.WriteLine("Child");
}

class Program33
{
    static void Main()
    {
        new Child();
    }
}

// 34
using System;

public class Base
{
    public string Info;
    public Base(string info) => Info = info;
}

public class Derived : Base
{
    public Derived(string info) : base(info) { }
}

class Program34
{
    static void Main()
    {
        Derived d = new Derived("Data");
        Console.WriteLine(d.Info);
    }
}

// 35
using System;

public class Base
{
    public Base() => Console.WriteLine("Default");
    public Base(int x) => Console.WriteLine($"Int: {x}");
}

public class Derived : Base
{
    public Derived() : base() { }
    public Derived(int x) : base(x) { }
}

class Program35
{
    static void Main()
    {
        new Derived();
        new Derived(10);
    }
}

// 36
using System;

public class Animal
{
    public string Name;
    public Animal(string name) => Name = name;
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
}

class Program36
{
    static void Main()
    {
        Dog d = new Dog("Buddy");
        Console.WriteLine(d.Name);
    }
}

// 37
using System;

public class Vehicle
{
    public string Brand;
    public Vehicle(string brand) => Brand = brand;
}

public class Car : Vehicle
{
    public Car(string brand) : base(brand) { }
}

class Program37
{
    static void Main()
    {
        Car c = new Car("Toyota");
        Console.WriteLine(c.Brand);
    }
}

// 38
using System;

public class Base
{
    public int Value;
    public Base(int value) => Value = value;
}

public class Derived : Base
{
    public Derived(int value) : base(value) { }
}

class Program38
{
    static void Main()
    {
        Derived d = new Derived(42);
        Console.WriteLine(d.Value);
    }
}

// 39
using System;

public class Base
{
    public Base(string s) => Console.WriteLine(s);
    public Base(int i) => Console.WriteLine(i);
}

public class Derived : Base
{
    public Derived(string s) : base(s) { }
    public Derived(int i) : base(i) { }
}

class Program39
{
    static void Main()
    {
        new Derived("Text");
        new Derived(123);
    }
}

// 40
using System;

public class Base
{
    public Base() => Console.WriteLine("Base default");
    public Base(int x) => Console.WriteLine($"Base: {x}");
}

public class Derived : Base
{
    public Derived() { }
    public Derived(int x) : base(x) { }
}

class Program40
{
    static void Main()
    {
        new Derived();
        new Derived(5);
    }
}

// 41
using System;

public class Base
{
    public Base() => Console.WriteLine("Base");
    public Base(int x) => Console.WriteLine($"Base {x}");
}

public class Derived : Base
{
    public Derived() : this(10) { }
    public Derived(int x) : base(x) => Console.WriteLine($"Derived {x}");
}

class Program41
{
    static void Main()
    {
        new Derived();
    }
}

// 42
using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("Initializing base...");
    }
}

public class Derived : Base
{
    public Derived() => Console.WriteLine("Derived ready");
}

class Program42
{
    static void Main()
    {
        new Derived();
    }
}

// 43
using System;

public class Person
{
    public string Name;
    public Person(string name) => Name = name;
}

public class Employee : Person
{
    public Employee(string name) : base(name) { }
}

class Program43
{
    static void Main()
    {
        Employee e = new Employee("John");
        Console.WriteLine(e.Name);
    }
}

// 44
using System;

public class Base
{
    public int X, Y;
    public Base(int x, int y)
    {
        X = x; Y = y;
    }
}

public class Derived : Base
{
    public Derived(int x, int y) : base(x, y) { }
}

class Program44
{
    static void Main()
    {
        Derived d = new Derived(3, 4);
        Console.WriteLine($"{d.X}, {d.Y}");
    }
}

// 45
using System;

public class A
{
    public A() => Console.WriteLine("A");
}

public class B : A
{
    public B() => Console.WriteLine("B");
}

public class C : B
{
    public C() => Console.WriteLine("C");
}

class Program45
{
    static void Main()
    {
        new C();
    }
}

// 46
using System;

public class Animal { public void Eat() => Console.WriteLine("Eating"); }
public class Dog : Animal { public void Bark() => Console.WriteLine("Woof"); }

class Program46
{
    static void Main()
    {
        Animal animal = new Dog();
        animal.Eat();
    }
}

// 47
using System;

public interface IFlyable { void Fly(); }
public class Bird : IFlyable { public void Fly() => Console.WriteLine("Flying"); }

class Program47
{
    static void Main()
    {
        IFlyable flyable = new Bird();
        flyable.Fly();
    }
}

// 48
using System;
using System.Collections.Generic;

public class Shape { public virtual void Draw() => Console.WriteLine("Draw shape"); }
public class Circle : Shape { public override void Draw() => Console.WriteLine("Draw circle"); }

class Program48
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape> { new Circle(), new Shape() };
        foreach (var s in shapes) s.Draw();
    }
}

// 49
using System;

public class Vehicle { public void Start() => Console.WriteLine("Started"); }
public class Car : Vehicle { }

class Program49
{
    static void Main()
    {
        void StartVehicle(Vehicle v) => v.Start();
        StartVehicle(new Car());
    }
}

// 50
using System;

public class Animal { public void Sound() => Console.WriteLine("..."); }
public class Cat : Animal { public override void Sound() => Console.WriteLine("Meow"); }
public class Dog : Animal { public override void Sound() => Console.WriteLine("Woof"); }

class Program50
{
    static void Main()
    {
        Animal[] animals = { new Cat(), new Dog() };
        foreach (var a in animals) a.Sound();
    }
}

// 51
using System;

public abstract class Device { public abstract void PowerOn(); }
public class Phone : Device { public override void PowerOn() => Console.WriteLine("Phone on"); }

class Program51
{
    static void Main()
    {
        Device d = new Phone();
        d.PowerOn();
    }
}

// 52
using System;

public class Base { public virtual void Show() => Console.WriteLine("Base"); }
public class Derived : Base { public override void Show() => Console.WriteLine("Derived"); }

class Program52
{
    static void Main()
    {
        Base b = new Derived();
        b.Show();
    }
}

// 53
using System;

public class Animal { public void Eat() => Console.WriteLine("Eating"); }
public class Tiger : Animal { public void Roar() => Console.WriteLine("Roar"); }

class Program53
{
    static void Main()
    {
        Animal a = new Tiger();
        a.Eat();
    }
}

// 54
using System;

public class Shape { public void Draw() => Console.WriteLine("Drawing"); }
public class Circle : Shape { public void Fill() => Console.WriteLine("Filling"); }

class Program54
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
        ((Circle)s).Fill();
    }
}

// 55
using System;

public class Base { }
public class Derived : Base { }

class Program55
{
    static void Main()
    {
        Base b = new Derived();
        Console.WriteLine("Upcast succeeded");
    }
}

// 56
using System;

public class Animal { }
public class Dog : Animal { public void Bark() => Console.WriteLine("Woof"); }

class Program56
{
    static void Main()
    {
        Animal a = new Dog();
        Dog d = (Dog)a;
        d.Bark();
    }
}

// 57
using System;

public class Animal { }
public class Cat : Animal { public void Meow() => Console.WriteLine("Meow"); }

class Program57
{
    static void Main()
    {
        Animal a = new Cat();
        Cat c = a as Cat;
        c?.Meow();
    }
}

// 58
using System;

public class Animal { }
public class Bird : Animal { public void Fly() => Console.WriteLine("Flying"); }

class Program58
{
    static void Main()
    {
        Animal a = new Bird();
        if (a is Bird b)
            b.Fly();
    }
}

// 59
using System;

public class Animal { }
public class Fish : Animal { public void Swim() => Console.WriteLine("Swimming"); }

class Program59
{
    static void Main()
    {
        Animal a = new Animal();
        Fish f = a as Fish;
        if (f == null) Console.WriteLine("Not a fish");
    }
}

// 60
using System;

public class Animal { }
public class Snake : Animal { public void Slither() => Console.WriteLine("Slither"); }

class Program60
{
    static void Main()
    {
        Animal a = new Animal();
        try
        {
            Snake s = (Snake)a;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Cast failed");
        }
    }
}

// 61
using System;

public class Animal { }
public class Lion : Animal { public void Roar() => Console.WriteLine("Roar"); }

class Program61
{
    static void Main()
    {
        Animal a = new Lion();
        if (a is Lion lion)
            lion.Roar();
    }
}

// 62
using System;

public class Vehicle { }
public class Car : Vehicle { public void Drive() => Console.WriteLine("Driving"); }

class Program62
{
    static void Main()
    {
        Vehicle v = new Car();
        ((Car)v).Drive();
    }
}

// 63
using System;

public class Animal { }
public class Dog : Animal { }

class Program63
{
    static void Main()
    {
        Animal a = new Animal();
        try { Dog d = (Dog)a; }
        catch { Console.WriteLine("Exception thrown"); }
    }
}

// 64
using System;

public class Shape { }
public class Circle : Shape { public void Roll() => Console.WriteLine("Rolling"); }

class Program64
{
    static void Main()
    {
        Shape s = new Circle();
        Circle c = (Circle)s;
        c.Roll();
    }
}

// 65
using System;

public class Base { }
public class Derived : Base { public void Special() => Console.WriteLine("Special"); }

class Program65
{
    static void Main()
    {
        Base b = new Derived();
        ((Derived)b).Special();
    }
}

// 66
using System;

public class Animal
{
    public virtual void Speak() => Console.WriteLine("...");
}

public class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
}

class Program66
{
    static void Main()
    {
        Animal a = new Dog();
        a.Speak();
    }
}

// 67
using System;

public abstract class Shape
{
    public abstract double Area();
    public virtual void Draw() => Console.WriteLine("Drawing");
}

public class Circle : Shape
{
    public double R { get; set; }
    public override double Area() => Math.PI * R * R;
}

class Program67
{
    static void Main()
    {
        Shape s = new Circle { R = 5 };
        s.Draw();
        Console.WriteLine(s.Area());
    }
}

// 68
using System;

public interface IPrintable { void Print(); }
public class Document : IPrintable { public void Print() => Console.WriteLine("Doc"); }
public class Image : IPrintable { public void Print() => Console.WriteLine("Img"); }

class Program68
{
    static void Main()
    {
        IPrintable[] items = { new Document(), new Image() };
        foreach (var i in items) i.Print();
    }
}

// 69
using System;

public class Animal { public virtual void Sound() => Console.WriteLine("..."); }
public class Cat : Animal { public override void Sound() => Console.WriteLine("Meow"); }
public class Dog : Animal { public override void Sound() => Console.WriteLine("Woof"); }

class Program69
{
    static void Main()
    {
        Animal[] animals = { new Cat(), new Dog() };
        foreach (var a in animals) a.Sound();
    }
}

// 70
using System;

public class Vehicle { public virtual void Move() => Console.WriteLine("Moving"); }
public class Car : Vehicle { public override void Move() => Console.WriteLine("Car moving"); }
public class Bike : Vehicle { public override void Move() => Console.WriteLine("Bike moving"); }

class Program70
{
    static void Main()
    {
        Vehicle[] vehicles = { new Car(), new Bike() };
        foreach (var v in vehicles) v.Move();
    }
}

// 71
using System;

public interface ISwimmable { void Swim(); }
public class Fish : ISwimmable { public void Swim() => Console.WriteLine("Swimming"); }

class Program71
{
    static void Main()
    {
        object o = new Fish();
        if (o is ISwimmable s) s.Swim();
    }
}

// 72
using System;

public class Base { public virtual void Act() => Console.WriteLine("Base"); }
public class Derived : Base { public override void Act() => Console.WriteLine("Derived"); }

class Program72
{
    static void Main()
    {
        Base b = new Derived();
        b.Act();
    }
}

// 73
using System;

public class MathOps
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}

class Program73
{
    static void Main()
    {
        MathOps m = new MathOps();
        Console.WriteLine(m.Add(1, 2));
        Console.WriteLine(m.Add(1.5, 2.5));
    }
}

// 74
using System;

public class Animal { public virtual void Eat() => Console.WriteLine("Eating"); }
public class Tiger : Animal { public override void Eat() => Console.WriteLine("Tiger eats meat"); }

class Program74
{
    static void Main()
    {
        void Feed(Animal a) => a.Eat();
        Feed(new Tiger());
    }
}

// 75
using System;

public abstract class Device { public abstract void On(); public virtual void Off() => Console.WriteLine("Off"); }
public class TV : Device { public override void On() => Console.WriteLine("TV on"); }

class Program75
{
    static void Main()
    {
        Device d = new TV();
        d.On();
        d.Off();
    }
}

// 76
using System;

public interface IConnectable { void Connect(); }
public class Wifi : IConnectable { public void Connect() => Console.WriteLine("WiFi"); }
public class Bluetooth : IConnectable { public void Connect() => Console.WriteLine("BT"); }

class Program76
{
    static void Main()
    {
        IConnectable[] cons = { new Wifi(), new Bluetooth() };
        foreach (var c in cons) c.Connect();
    }
}

// 77
using System;

public class Base { public virtual void Run() => Console.WriteLine("Base run"); }
public class Derived : Base { public override void Run() => Console.WriteLine("Derived run"); }

class Program77
{
    static void Main()
    {
        Base b = new Derived();
        b.Run();
    }
}

// 78
using System;

public class Shape { public virtual void Draw() => Console.WriteLine("Shape"); }
public class Circle : Shape { public override void Draw() => Console.WriteLine("Circle"); }

class Program78
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}

// 79
using System;
using System.Collections.Generic;

public class Animal { public virtual string Speak() => "…"; }
public class Dog : Animal { public override string Speak() => "Woof"; }
public class Cat : Animal { public override string Speak() => "Meow"; }

class Program79
{
    static void Main()
    {
        List<Animal> animals = new List<Animal> { new Dog(), new Cat() };
        foreach (var a in animals) Console.WriteLine(a.Speak());
    }
}

// 80
using System;

public class Base { public virtual void Execute() => Console.WriteLine("Base"); }
public class Derived : Base { public override void Execute() => Console.WriteLine("Override"); }

class Program80
{
    static void Main()
    {
        Base b = new Derived();
        b.Execute();
    }
}

// 81
using System;

public class Animal { }
public class Dog : Animal { }

class Program81
{
    static void Main()
    {
        Animal a = new Dog();
        Console.WriteLine(a is Dog);
    }
}

// 82
using System;

public class Animal { }
public class Cat : Animal { public void Meow() => Console.WriteLine("Meow"); }

class Program82
{
    static void Main()
    {
        Animal a = new Cat();
        (a as Cat)?.Meow();
    }
}

// 83
using System;

public class Shape { }
public class Circle : Shape { }

class Program83
{
    static void Main()
    {
        Shape s = new Circle();
        Console.WriteLine(s is Circle);
    }
}

// 84
using System;

public class Vehicle { }
public class Car : Vehicle { public void Drive() => Console.WriteLine("Driving"); }

class Program84
{
    static void Main()
    {
        Vehicle v = new Car();
        (v as Car)?.Drive();
    }
}

// 85
using System;

public class Animal { }
public class Fish : Animal { }

class Program85
{
    static void Main()
    {
        Animal a = new Animal();
        Fish f = a as Fish;
        Console.WriteLine(f == null ? "Not a fish" : "Is fish");
    }
}

// 86
using System;

public class Device { }
public class Phone : Device { public void Call() => Console.WriteLine("Calling"); }

class Program86
{
    static void Main()
    {
        Device d = new Device();
        Phone p = d as Phone;
        if (p == null) Console.WriteLine("Not a phone");
    }
}

// 87
using System;

public class Base { }
public class Derived : Base { }

class Program87
{
    static void Main()
    {
        Base b = new Base();
        try { Derived d = (Derived)b; }
        catch (InvalidCastException) { Console.WriteLine("Cast error"); }
    }
}

// 88
using System;

public interface IPrintable { void Print(); }
public class Doc : IPrintable { public void Print() => Console.WriteLine("Doc"); }

class Program88
{
    static void Main()
    {
        object o = new Doc();
        (o as IPrintable)?.Print();
    }
}

// 89
using System;

public class Animal { }
public class Bird : Animal { public void Fly() => Console.WriteLine("Flying"); }

class Program89
{
    static void Main()
    {
        Animal a = new Bird();
        if (a is Bird b) b.Fly();
    }
}

// 90
using System;

public class Animal { }
public class Dog : Animal { public void Bark() => Console.WriteLine("Woof"); }

class Program90
{
    static void Main()
    {
        Animal a = new Dog();
        Console.WriteLine(a is Dog);
        Dog d = a as Dog;
        d?.Bark();
    }
}

// 91
using System;

public sealed class FinalClass
{
    public void Act() => Console.WriteLine("Final");
}


class Program91
{
    static void Main()
    {
        new FinalClass().Act();
    }
}

// 92
using System;

public sealed class Logger
{
    private void InternalLog() => Console.WriteLine("Log");
    public void Log() => InternalLog();
}

class Program92
{
    static void Main()
    {
        new Logger().Log();
    }
}

// 93
using System;

public sealed class Config
{
    public string Setting { get; set; }
}

class Program93
{
    static void Main()
    {
        Config c = new Config { Setting = "On" };
        Console.WriteLine(c.Setting);
    }
}

// 94
using System;

public class Base
{
    public virtual void Method() => Console.WriteLine("Base");
}

public class Derived : Base
{
    public sealed override void Method() => Console.WriteLine("Sealed override");
}

class Program94
{
    static void Main()
    {
        new Derived().Method();
    }
}

// 95
using System;

public sealed class Utility
{
    public void Help() => Console.WriteLine("Help");
}

class Program95
{
    static void Main()
    {
        new Utility().Help();
    }
}

// 96
using System;

public sealed class SecureData
{
    private SecureData() { }
    public static SecureData Instance = new SecureData();
}

class Program96
{
    static void Main()
    {
        Console.WriteLine("Sealed with private ctor");
    }
}

// 97
using System;

public sealed class AppLogger
{
    public void Info(string msg) => Console.WriteLine($"[INFO] {msg}");
}

class Program97
{
    static void Main()
    {
        AppLogger logger = new AppLogger();
        logger.Info("App started");
    }
}

// 98
using System;

public sealed class Secret
{
    private string data = "TOP SECRET";
    public string Get() => data;
}

class Program98
{
    static void Main()
    {
        Console.WriteLine(new Secret().Get());
    }
}

// 99
using System;

public sealed class Control
{
    protected int Value { get; set; } = 100;
    public int GetValue() => Value;
}

class Program99
{
    static void Main()
    {
        Console.WriteLine(new Control().GetValue());
    }
}

// 100
using System;

public sealed class Counter
{
    private int count;
    public void Increment() => count++;
    public int Value => count;
}

class Program100
{
    static void Main()
    {
        Counter c = new Counter();
        c.Increment();
        Console.WriteLine(c.Value);
    }
}