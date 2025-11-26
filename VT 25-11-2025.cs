//1
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 50, 75, 100, 150 };
        var result = numbers.Where(x => x > 50).ToList();
        Console.WriteLine(string.Join(", ", result));
    }
}

//2
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine(string.Join(", ", evenNumbers));
    }
}

//3
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Apricot", "Orange", "Avocado" };
        var startsWithA = fruits.Where(f => f.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine(string.Join(", ", startsWithA));
    }
}

//4
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Анна", Age = 28 },
            new Person { Name = "Борис", Age = 35 },
            new Person { Name = "Виктор", Age = 42 },
            new Person { Name = "Диана", Age = 31 }
        };
        var olderThan30 = people.Where(p => p.Age > 30).ToList();
        foreach (var p in olderThan30)
            Console.WriteLine($"{p.Name} - {p.Age}");
    }
}

//5
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 9, 12, 15, 18, 20, 21, 22, 24 };
        var divisibleBy3 = numbers.Where(x => x % 3 == 0).ToList();
        Console.WriteLine(string.Join(", ", divisibleBy3));
    }
}

//6
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public double AverageGrade { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Иван", AverageGrade = 4.8 },
            new Student { Name = "Мария", AverageGrade = 3.9 },
            new Student { Name = "Пётр", AverageGrade = 4.5 },
            new Student { Name = "Ольга", AverageGrade = 5.0 }
        };
        var excellent = students.Where(s => s.AverageGrade > 4.0).ToList();
        foreach (var s in excellent)
            Console.WriteLine($"{s.Name}: {s.AverageGrade}");
    }
}

//7
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "Hi", "Hello", "World", "Programming", "C#", "LINQ" };
        var longWords = words.Where(w => w.Length > 5).ToList();
        Console.WriteLine(string.Join(", ", longWords));
    }
}

//8
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Title = "Ноутбук", Price = 85000 },
            new Product { Title = "Мышь", Price = 350 },
            new Product { Title = "Клавиатура", Price = 1200 },
            new Product { Title = "Монитор", Price = 25000 },
            new Product { Title = "Наушники", Price = 450 }
        };
        var midPrice = products.Where(p => p.Price >= 100 && p.Price <= 500).ToList();
        foreach (var p in midPrice)
            Console.WriteLine($"{p.Title} - {p.Price} руб.");
    }
}

//9
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { -10, -5, 0, 3, 7, 12, -8, 15, 20 };
        var positive = numbers.Where(n => n > 0).ToList();
        Console.WriteLine(string.Join(", ", positive));
    }
}

//10
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public int ExperienceYears { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Алексей", Salary = 90000, ExperienceYears = 3 },
            new Employee { Name = "Елена", Salary = 120000, ExperienceYears = 5 },
            new Employee { Name = "Сергей", Salary = 70000, ExperienceYears = 1 },
            new Employee { Name = "Наталья", Salary = 110000, ExperienceYears = 4 }
        };
        decimal averageSalary = employees.Average(e => e.Salary);
        var topEmployees = employees.Where(e => e.Salary > averageSalary && e.ExperienceYears > 2).ToList();
        foreach (var e in topEmployees)
            Console.WriteLine($"{e.Name}: {e.Salary} руб., стаж {e.ExperienceYears} лет");
    }
}

//11
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var squares = numbers.Select(x => x * x).ToList();
        Console.WriteLine(string.Join(", ", squares));
    }
}

//12
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Иван", Age = 25 },
            new Person { Name = "Мария", Age = 30 },
            new Person { Name = "Пётр", Age = 35 }
        };
        var names = people.Select(p => p.Name).ToList();
        Console.WriteLine(string.Join(", ", names));
    }
}

//13
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Анна", Age = 28 },
            new Person { Name = "Борис", Age = 34 },
            new Person { Name = "Вера", Age = 22 }
        };
        var formatted = people.Select(p => $"{p.Name} - {p.Age}").ToList();
        foreach (var item in formatted)
            Console.WriteLine(item);
    }
}

//14
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "C#", "LINQ", "Programming", "Hello", "World" };
        var lengths = words.Select(w => w.Length).ToList();
        Console.WriteLine(string.Join(", ", lengths));
    }
}

//15
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Title = "Laptop", Price = 85000, Category = "Electronics" },
            new Product { Title = "Mouse", Price = 450, Category = "Accessories" },
            new Product { Title = "Book", Price = 1200, Category = "Literature" }
        };
        var projected = products.Select(p => new { p.Title, p.Price }).ToList();
        foreach (var p in projected)
            Console.WriteLine($"{p.Title}: {p.Price}");
    }
}

//16
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        decimal[] pricesRub = { 1000, 2500, 5000, 9900, 15000 };
        const decimal rate = 100m;
        var pricesUsd = pricesRub.Select(p => p / rate).ToList();
        Console.WriteLine(string.Join(", ", pricesUsd));
    }
}

//17
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Игорь", Position = "Developer", Salary = 120000 },
            new Employee { Name = "Светлана", Position = "Designer", Salary = 90000 },
            new Employee { Name = "Михаил", Position = "Manager", Salary = 150000 }
        };
        var anon = employees.Select(e => new { FullName = e.Name, e.Position }).ToList();
        foreach (var a in anon)
            Console.WriteLine($"{a.FullName} - {a.Position}");
    }
}

//18
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] items = { "Apple", "Banana", "Orange", "Grape", "Mango" };
        var prefixed = items.Select(x => "Fruit: " + x).ToList();
        Console.WriteLine(string.Join("\n", prefixed));
    }
}

//19
using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        var users = new List<User>
        {
            new User { FirstName = "Ivan", LastName = "Petrov", Email = "ivan@example.com" },
            new User { FirstName = "Anna", LastName = "Sidorova", Email = "anna.s@example.com" },
            new User { FirstName = "Petr", LastName = "Ivanov", Email = "petr.ivanov@mail.ru" }
        };
        var formattedEmails = users.Select(u => $"<{u.Email.ToUpper()}>").ToList();
        Console.WriteLine(string.Join("\n", formattedEmails));
    }
}

//20
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Pen", Price = 50, Quantity = 100 },
            new Product { Name = "Notebook", Price = 150, Quantity = 50 },
            new Product { Name = "Pencil", Price = 30, Quantity = 200 }
        };
        var tuples = products.Select(p => (p.Name, p.Price, Total = p.Price * p.Quantity)).ToList();
        foreach (var t in tuples)
            Console.WriteLine($"{t.Name}: {t.Price} × {t.Quantity} = {t.Total}");
    }
}

//21
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 9 };
        var sorted = numbers.OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(" → ", sorted));
    }
}

//22
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Олег", "Анна", "Михаил", "Светлана", "Игорь" };
        var sortedDesc = names.OrderByDescending(n => n).ToList();
        Console.WriteLine(string.Join(" → ", sortedDesc));
    }
}

//23
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Иван", Age = 25 },
            new Person { Name = "Мария", Age = 22 },
            new Person { Name = "Пётр", Age = 25 },
            new Person { Name = "Анна", Age = 30 }
        };
        var sorted = people.OrderBy(p => p.Age).ThenBy(p => p.Name).ToList();
        foreach (var p in sorted)
            Console.WriteLine($"{p.Name} — {p.Age}");
    }
}

//24
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "C#", "LINQ", "Hello", "Programming", "World" };
        var sortedByLength = words.OrderBy(w => w.Length).ToList();
        Console.WriteLine(string.Join(" → ", sortedByLength));
    }
}

//25
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Title = "Ноутбук", Price = 85000 },
            new Product { Title = "Мышь", Price = 450 },
            new Product { Title = "Монитор", Price = 25000 }
        };
        var sortedByPriceDesc = products.OrderByDescending(p => p.Price).ToList();
        foreach (var p in sortedByPriceDesc)
            Console.WriteLine($"{p.Title}: {p.Price} ₽");
    }
}

//26
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { FirstName = "Иван", LastName = "Петров", Grade = 4.8 },
            new Student { FirstName = "Анна", LastName = "Сидорова", Grade = 4.8 },
            new Student { FirstName = "Михаил", LastName = "Иванов", Grade = 4.5 }
        };
        var sorted = students.OrderByDescending(s => s.Grade).ThenBy(s => s.LastName).ToList();
        foreach (var s in sorted)
            Console.WriteLine($"{s.LastName} {s.FirstName}: {s.Grade}");
    }
}

//27
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 6, 8, 12, 7, 15, 9 };
        var sortedByDivisors = numbers.OrderBy(n => Enumerable.Range(1, n).Count(d => n % d == 0)).ToList();
        Console.WriteLine(string.Join(" → ", sortedByDivisors));
    }
}

//28
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Алексей", Department = "IT", Salary = 120000 },
            new Employee { Name = "Ольга", Department = "HR", Salary = 90000 },
            new Employee { Name = "Сергей", Department = "IT", Salary = 130000 }
        };
        var sorted = employees.OrderBy(e => e.Department).ThenByDescending(e => e.Salary).ToList();
        foreach (var e in sorted)
            Console.WriteLine($"{e.Department} — {e.Name}: {e.Salary}");
    }
}

//29
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        DateTime[] dates = { new DateTime(2023, 5, 10), new DateTime(2023, 1, 20), new DateTime(2023, 12, 3) };
        var sortedDates = dates.OrderBy(d => d).ToList();
        foreach (var d in sortedDates)
            Console.WriteLine(d.ToString("yyyy-MM-dd"));
    }
}

//30
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Popularity { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Popularity = 85 },
            new Product { Name = "Mouse", Category = "Electronics", Popularity = 92 },
            new Product { Name = "Book", Category = "Literature", Popularity = 70 }
        };
        var sorted = products.OrderBy(p => p.Category).ThenByDescending(p => p.Popularity).ToList();
        foreach (var p in sorted)
            Console.WriteLine($"{p.Category} → {p.Name} (популярность: {p.Popularity})");
    }
}

//31
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Чётные" : "Нечётные");
        foreach (var g in grouped)
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g)}");
        }
    }
}

//32
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Иван", Age = 25 },
            new Person { Name = "Мария", Age = 30 },
            new Person { Name = "Пётр", Age = 25 }
        };
        var groupedByAge = people.GroupBy(p => p.Age);
        foreach (var g in groupedByAge)
        {
            Console.WriteLine($"Возраст {g.Key}: {string.Join(", ", g.Select(p => p.Name))}");
        }
    }
}

//33
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics" },
            new Product { Name = "Mouse", Category = "Electronics" },
            new Product { Name = "Book", Category = "Literature" }
        };
        var grouped = products.GroupBy(p => p.Category);
        foreach (var g in grouped)
        {
            Console.WriteLine($"{g.Key}: {g.Count()} товаров");
        }
    }
}

//34
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public string Faculty { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Иван", Faculty = "IT", Grade = 4.7 },
            new Student { Name = "Анна", Faculty = "IT", Grade = 4.9 },
            new Student { Name = "Пётр", Faculty = "Economics", Grade = 4.2 }
        };
        var avgByFaculty = students.GroupBy(s => s.Faculty)
                                   .Select(g => new { Faculty = g.Key, AvgGrade = g.Average(s => s.Grade) });
        foreach (var item in avgByFaculty)
            Console.WriteLine($"{item.Faculty}: средний балл = {item.AvgGrade:F2}");
    }
}

//35
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "Алексей", Department = "IT", Salary = 120000 },
            new Employee { Name = "Ольга", Department = "HR", Salary = 90000 },
            new Employee { Name = "Сергей", Department = "IT", Salary = 130000 }
        };
        var salaryByDept = employees.GroupBy(e => e.Department)
                                    .Select(g => new { Dept = g.Key, TotalSalary = g.Sum(e => e.Salary) });
        foreach (var item in salaryByDept)
            Console.WriteLine($"{item.Dept}: фонд зарплаты = {item.TotalSalary} ₽");
    }
}

//36
using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderId { get; set; }
    public string Customer { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 1, Customer = "Иван", Amount = 5000 },
            new Order { OrderId = 2, Customer = "Иван", Amount = 12000 },
            new Order { OrderId = 3, Customer = "Анна", Amount = 8000 }
        };
        var maxOrderPerCustomer = orders.GroupBy(o => o.Customer)
                                        .Select(g => new { Customer = g.Key, MaxOrder = g.Max(o => o.Amount) });
        foreach (var item in maxOrderPerCustomer)
            Console.WriteLine($"{item.Customer}: самый дорогой заказ = {item.MaxOrder} ₽");
    }
}

//37
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "Apple", "Banana", "Avocado", "Orange", "Apricot" };
        var groupedByFirstLetter = words.GroupBy(w => w[0]);
        foreach (var g in groupedByFirstLetter.OrderBy(g => g.Key))
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g)}");
        }
    }
}

//38
using System;
using System.Collections.Generic;
using System.Linq;

public class Event
{
    public string Title { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static void Main()
    {
        var events = new List<Event>
        {
            new Event { Title = "Meeting", Date = new DateTime(2025, 1, 15) },
            new Event { Title = "Conference", Date = new DateTime(2025, 1, 15) },
            new Event { Title = "Webinar", Date = new DateTime(2025, 2, 20) }
        };
        var eventsByDate = events.GroupBy(e => e.Date.Date)
                                 .Select(g => new { Date = g.Key, Count = g.Count() });
        foreach (var item in eventsByDate)
            Console.WriteLine($"{item.Date:yyyy-MM-dd}: {item.Count} событий");
    }
}

//39
using System;
using System.Collections.Generic;
using System.Linq;

public class Sale
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var sales = new List<Sale>
        {
            new Sale { Date = new DateTime(2025, 1, 10), Amount = 15000 },
            new Sale { Date = new DateTime(2025, 1, 25), Amount = 23000 },
            new Sale { Date = new DateTime(2025, 2, 5), Amount = 18000 }
        };
        var monthlyTotal = sales.GroupBy(s => new { s.Date.Year, s.Date.Month })
                                .Select(g => new { Year = g.Key.Year, Month = g.Key.Month, Total = g.Sum(s => s.Amount) });
        foreach (var item in monthlyTotal)
            Console.WriteLine($"{item.Year}-{item.Month:D2}: {item.Total} ₽");
    }
}

//40
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Category { get; set; }
    public string SubCategory { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Category = "Electronics", SubCategory = "Computers", Name = "Laptop" },
            new Product { Category = "Electronics", SubCategory = "Accessories", Name = "Mouse" },
            new Product { Category = "Books", SubCategory = "Fiction", Name = "Novel" }
        };
        var nestedGroups = products.GroupBy(p => p.Category)
                                   .Select(cg => new
                                   {
                                       Category = cg.Key,
                                       SubCategories = cg.GroupBy(p => p.SubCategory)
                                                         .Select(scg => new { SubCategory = scg.Key, Items = scg.Select(p => p.Name) })
                                   });
        foreach (var cat in nestedGroups)
        {
            Console.WriteLine($"Категория: {cat.Category}");
            foreach (var sub in cat.SubCategories)
            {
                Console.WriteLine($"  Подкатегория: {sub.SubCategory}");
                foreach (var name in sub.Items)
                    Console.WriteLine($"    - {name}");
            }
        }
    }
}
//41
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Grade
{
    public int StudentId { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Иван" },
            new Student { Id = 2, Name = "Анна" },
            new Student { Id = 3, Name = "Пётр" }
        };

        var grades = new List<Grade>
        {
            new Grade { StudentId = 1, Subject = "Математика", Score = 5 },
            new Grade { StudentId = 1, Subject = "Физика", Score = 4 },
            new Grade { StudentId = 2, Subject = "Математика", Score = 5 }
        };

        var result = students.Join(grades,
                                   s => s.Id,
                                   g => g.StudentId,
                                   (s, g) => new { s.Name, g.Subject, g.Score });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} — {item.Subject}: {item.Score}");
    }
}

//42
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Алексей", DepartmentId = 10 },
            new Employee { Id = 2, Name = "Мария", DepartmentId = 20 }
        };

        var departments = new List<Department>
        {
            new Department { Id = 10, Name = "IT" },
            new Department { Id = 20, Name = "HR" },
            new Department { Id = 30, Name = "Sales" }
        };

        var result = employees.Join(departments,
                                    e => e.DepartmentId,
                                    d => d.Id,
                                    (e, d) => new { e.Name, Department = d.Name });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} работает в отделе {item.Department}");
    }
}

//43
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Иван" },
            new Customer { Id = 2, Name = "Анна" },
            new Customer { Id = 3, Name = "Пётр" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 101, CustomerId = 1, Amount = 5000 },
            new Order { Id = 102, CustomerId = 1, Amount = 3000 }
        };

        var result = customers.GroupJoin(orders,
                                          c => c.Id,
                                          o => o.CustomerId,
                                          (c, o) => new { Customer = c, Orders = o.DefaultIfEmpty() })
                              .SelectMany(x => x.Orders.Select(o => new { x.Customer.Name, OrderAmount = o?.Amount ?? 0 }));

        foreach (var item in result)
            Console.WriteLine($"{item.Name}: заказ на {item.OrderAmount} ₽ (0 — нет заказов)");
    }
}

//44
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ManufacturerId { get; set; }
}

public class Manufacturer
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop X1", ManufacturerId = 100 },
            new Product { Id = 2, Name = "Mouse Pro", ManufacturerId = 200 }
        };

        var manufacturers = new List<Manufacturer>
        {
            new Manufacturer { Id = 100, CompanyName = "TechCorp" },
            new Manufacturer { Id = 200, CompanyName = "GadgetInc" }
        };

        var result = products.Join(manufacturers,
                                   p => p.ManufacturerId,
                                   m => m.Id,
                                   (p, m) => new { p.Name, Manufacturer = m.CompanyName });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} — производитель: {item.Manufacturer}");
    }
}

//45
using System;
using System.Collections.Generic;
using System.Linq;

public class OrderDetail
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class OrderHeader
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
}

class Program
{
    static void Main()
    {
        var headers = new List<OrderHeader>
        {
            new OrderHeader { OrderId = 1001, CustomerId = 5, OrderDate = new DateTime(2025, 1, 10) }
        };

        var details = new List<OrderDetail>
        {
            new OrderDetail { OrderId = 1001, ProductId = 77, Quantity = 2 }
        };

        var result = headers.Join(details,
                                   h => new { h.OrderId, h.CustomerId },
                                   d => new { d.OrderId, CustomerId = 5 },
                                   (h, d) => new { h.OrderDate, d.ProductId, d.Quantity });

        foreach (var item in result)
            Console.WriteLine($"Заказ от {item.OrderDate:yyyy-MM-dd}, товар {item.ProductId}, кол-во: {item.Quantity}");
    }
}

//46
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer { public int Id { get; set; } public string Name { get; set; } }
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public int ProductId { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } }

class Program
{
    static void Main()
    {
        var customers = new List<Customer> { new Customer { Id = 1, Name = "Иван" } };
        var orders = new List<Order> { new Order { Id = 101, CustomerId = 1, ProductId = 10 } };
        var products = new List<Product> { new Product { Id = 10, Name = "Ноутбук", Price = 85000 } };

        var result = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.Name, o.Id, o.ProductId })
                              .Join(products, co => co.ProductId, p => p.Id, (co, p) => new { co.Name, co.Id, p.Name, p.Price });

        foreach (var item in result)
            Console.WriteLine($"Клиент {item.Name}, заказ {item.Id}: {item.Name} — {item.Price} ₽");
    }
}

//47
using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? DepartmentId { get; set; }
}

class Program
{
    static void Main()
    {
        var departments = new List<Department>
        {
            new Department { Id = 10, Name = "IT" },
            new Department { Id = 20, Name = "HR" }
        };

        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Алексей", DepartmentId = 10 },
            new Employee { Id = 2, Name = "Ольга", DepartmentId = 10 },
            new Employee { Id = 3, Name = "Сергей", DepartmentId = null }
        };

        var result = departments.GroupJoin(employees,
                                            d => d.Id,
                                            e => e.DepartmentId,
                                            (d, emps) => new { Department = d.Name, Employees = emps });

        foreach (var item in result)
        {
            Console.WriteLine($"Отдел: {item.Department}");
            foreach (var e in item.Employees)
                Console.WriteLine($"  - {e.Name}");
        }
    }
}

//48
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] colors = { "Красный", "Синий" };
        string[] sizes = { "S", "M", "L" };

        var combinations = colors.SelectMany(c => sizes, (c, s) => new { Color = c, Size = s });

        foreach (var item in combinations)
            Console.WriteLine($"{item.Color} + {item.Size}");
    }
}

//49
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
}

public class Scholarship
{
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Иван", GroupId = 101 },
            new Student { Id = 2, Name = "Анна", GroupId = 102 }
        }.Where(s => s.GroupId > 100);

        var scholarships = new List<Scholarship>
        {
            new Scholarship { StudentId = 1, Amount = 5000 }
        };

        var result = students.Join(scholarships,
                                   s => s.Id,
                                   sch => sch.StudentId,
                                   (s, sch) => new { s.Name, sch.Amount });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} получает стипендию {item.Amount} ₽");
    }
}

//50
using System;
using System.Collections.Generic;
using System.Linq;

public class OldClient
{
    public int ClientId { get; set; }
    public string FullName { get; set; }
}

public class NewClient
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        var oldClients = new List<OldClient>
        {
            new OldClient { ClientId = 1, FullName = "Иванов Иван" }
        };

        var newClients = new List<NewClient>
        {
            new NewClient { Id = 2, FirstName = "Пётр", LastName = "Петров" }
        };

        var unified = oldClients.Select(c => new { Id = c.ClientId, Name = c.FullName })
                                .Concat(newClients.Select(c => new { Id = c.Id, Name = c.FirstName + " " + c.LastName }));

        foreach (var client in unified)
            Console.WriteLine($"ID: {client.Id}, Имя: {client.Name}");
    }
}

//51
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = numbers.Sum();
        Console.WriteLine($"Сумма: {sum}");
    }
}

//52
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] values = { 10.5, 20.3, 15.7, 30.1 };
        double average = values.Average();
        Console.WriteLine($"Среднее: {average:F2}");
    }
}

//53
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 17, 89, 34, 105, 23 };
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"Максимум: {max}, Минимум: {min}");
    }
}

//54
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 8, 23, 17, 30, 9 };
        int count = numbers.Count(n => n > 10);
        Console.WriteLine($"Чисел больше 10: {count}");
    }
}

//55
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 3, 4, 5 };
        long product = numbers.Aggregate(1L, (acc, x) => acc * x);
        Console.WriteLine($"Произведение: {product}");
    }
}

//56
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        var sorted = numbers.OrderBy(x => x).ToArray();
        double median = sorted.Length % 2 == 0
            ? (sorted[sorted.Length / 2 - 1] + sorted[sorted.Length / 2]) / 2
            : sorted[sorted.Length / 2];
        Console.WriteLine($"Медиана: {median}");
    }
}

//57
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 45, 78, 95, 120, 88 };
        bool hasOver100 = numbers.Any(n => n > 100);
        Console.WriteLine($"Есть число больше 100: {hasOver100}");
    }
}

//58
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 7;
        long factorial = Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);
        Console.WriteLine($"Факториал {n}! = {factorial}");
    }
}

//59
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        long sumOfSquares = numbers.Where(n => n % 2 != 0)
                                   .Select(n => (long)n * n)
                                   .Sum();
        Console.WriteLine($"Сумма квадратов нечётных: {sumOfSquares}");
    }
}

//60
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] values = { 10, 12, 15, 18, 20 };
        double mean = values.Average();
        double variance = values.Select(v => Math.Pow(v - mean, 2)).Average();
        double stdDev = Math.Sqrt(variance);
        Console.WriteLine($"Стандартное отклонение: {stdDev:F3}");
    }
}
//41
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GroupNumber { get; set; }
}

public class Grade
{
    public int StudentId { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Иван", LastName = "Петров", GroupNumber = 101 },
            new Student { Id = 2, FirstName = "Мария", LastName = "Сидорова", GroupNumber = 102 },
            new Student { Id = 3, FirstName = "Алексей", LastName = "Иванов", GroupNumber = 101 },
            new Student { Id = 4, FirstName = "Елена", LastName = "Козлова", GroupNumber = 103 }
        };

        var grades = new List<Grade>
        {
            new Grade { StudentId = 1, Subject = "Математика", Score = 5, Date = new DateTime(2025, 1, 15) },
            new Grade { StudentId = 1, Subject = "Физика", Score = 4, Date = new DateTime(2025, 1, 20) },
            new Grade { StudentId = 2, Subject = "Математика", Score = 5, Date = new DateTime(2025, 1, 18) },
            new Grade { StudentId = 3, Subject = "Программирование", Score = 5, Date = new DateTime(2025, 2, 1) }
        };

        var result = students.Join(grades,
                                   s => s.Id,
                                   g => g.StudentId,
                                   (s, g) => new
                                   {
                                       FullName = $"{s.FirstName} {s.LastName}",
                                       Group = s.GroupNumber,
                                       g.Subject,
                                       g.Score,
                                       g.Date
                                   })
                             .OrderBy(x => x.FullName);

        Console.WriteLine("Оценки студентов:");
        foreach (var item in result)
            Console.WriteLine($"{item.FullName} (группа {item.Group}) — {item.Subject}: {item.Score} ({item.Date:dd.MM.yyyy})");
    }
}

//42
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DepartmentId { get; set; }
    public decimal Salary { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Алексей", LastName = "Смирнов", DepartmentId = 10, Salary = 120000 },
            new Employee { Id = 2, FirstName = "Ольга", LastName = "Петрова", DepartmentId = 20, Salary = 95000 },
            new Employee { Id = 3, FirstName = "Дмитрий", LastName = "Козлов", DepartmentId = 10, Salary = 135000 },
            new Employee { Id = 4, FirstName = "Наталья", LastName = "Иванова", DepartmentId = 30, Salary = 88000 }
        };

        var departments = new List<Department>
        {
            new Department { Id = 10, Name = "IT-отдел", Location = "Москва" },
            new Department { Id = 20, Name = "HR", Location = "Санкт-Петербург" },
            new Department { Id = 30, Name = "Бухгалтерия", Location = "Москва" }
        };

        var result = employees.Join(departments,
                                    e => e.DepartmentId,
                                    d => d.Id,
                                    (e, d) => new
                                    {
                                        FullName = $"{e.FirstName} {e.LastName}",
                                        Department = d.Name,
                                        Location = d.Location,
                                        e.Salary
                                    });

        Console.WriteLine("Сотрудники по отделам:");
        foreach (var item in result.OrderBy(x => x.Department))
            Console.WriteLine($"{item.FullName} → {item.Department} ({item.Location}), зарплата: {item.Salary:N0} ₽");
    }
}

//43
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
    public DateTime OrderDate { get; set; }
}

class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Иван Петров", City = "Москва" },
            new Customer { Id = 2, Name = "Анна Сидорова", City = "Казань" },
            new Customer { Id = 3, Name = "Пётр Иванов", City = "Новосибирск" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 101, CustomerId = 1, Amount = 45000, OrderDate = new DateTime(2025, 1, 10) },
            new Order { Id = 102, CustomerId = 1, Amount = 120000, OrderDate = new DateTime(2025, 2, 5) },
            new Order { Id = 103, CustomerId = 2, Amount = 78000, OrderDate = new DateTime(2025, 1, 20) }
        };

        var result = customers.GroupJoin(orders,
                                          c => c.Id,
                                          o => o.CustomerId,
                                          (c, orderGroup) => new { Customer = c, Orders = orderGroup.DefaultIfEmpty() })
                              .SelectMany(
                                  x => x.Orders.Select(o => new
                                  {
                                      x.Customer.Name,
                                      x.Customer.City,
                                      OrderId = o?.Id ?? 0,
                                      Amount = o?.Amount ?? 0m,
                                      Date = o?.OrderDate ?? DateTime.MinValue
                                  }));

        Console.WriteLine("Все клиенты и их заказы (включая без заказов):");
        foreach (var item in result.OrderBy(x => x.Name))
        {
            if (item.OrderId == 0)
                Console.WriteLine($"{item.Name} ({item.City}) — заказов нет");
            else
                Console.WriteLine($"{item.Name} ({item.City}) → Заказ №{item.OrderId}: {item.Amount:N0} ₽ от {item.Date:dd.MM.yyyy}");
        }
    }
}

//44
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ManufacturerId { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }
}

public class Manufacturer
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Country { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop Pro 15", ManufacturerId = 100, Price = 125000, Year = 2024 },
            new Product { Id = 2, Name = "Wireless Mouse X", ManufacturerId = 200, Price = 3500, Year = 2025 },
            new Product { Id = 3, Name = "Gaming Keyboard RGB", ManufacturerId = 100, Price = 8900, Year = 2024 }
        };

        var manufacturers = new List<Manufacturer>
        {
            new Manufacturer { Id = 100, CompanyName = "TechMaster", Country = "Китай" },
            new Manufacturer { Id = 200, CompanyName = "GadgetWorld", Country = "Тайвань" },
            new Manufacturer { Id = 300, CompanyName = "OfficePlus", Country = "Япония" }
        };

        var result = products.Join(manufacturers,
                                   p => p.ManufacturerId,
                                   m => m.Id,
                                   (p, m) => new
                                   {
                                       p.Name,
                                       p.Price,
                                       p.Year,
                                       Manufacturer = m.CompanyName,
                                       Country = m.Country
                                   });

        Console.WriteLine("Товары с производителями:");
        foreach (var item in result.OrderByDescending(x => x.Price))
            Console.WriteLine($"{item.Name} ({item.Year}) — {item.Manufacturer} ({item.Country}), цена: {item.Price:N0} ₽");
    }
}

//45
using System;
using System.Collections.Generic;
using System.Linq;

public class OrderHeader
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
}

public class OrderDetail
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}

class Program
{
    static void Main()
    {
        var headers = new List<OrderHeader>
        {
            new OrderHeader { OrderId = 1001, CustomerId = 501, OrderDate = new DateTime(2025, 3, 10), Status = "Оплачен" },
            new OrderHeader { OrderId = 1002, CustomerId = 502, OrderDate = new DateTime(2025, 3, 12), Status = "В обработке" }
        };

        var details = new List<OrderDetail>
        {
            new OrderDetail { OrderId = 1001, ProductId = 77, Quantity = 2, UnitPrice = 45000 },
            new OrderDetail { OrderId = 1001, ProductId = 88, Quantity = 1, UnitPrice = 12000 }
        };

        var result = headers.Join(details,
                                   h => new { h.OrderId, h.CustomerId },
                                   d => new { d.OrderId, CustomerId = 501 },
                                   (h, d) => new
                                   {
                                       h.OrderId,
                                       h.OrderDate,
                                       h.Status,
                                       d.ProductId,
                                       d.Quantity,
                                       Total = d.Quantity * d.UnitPrice
                                   });

        Console.WriteLine("Заказы с составным ключом:");
        foreach (var item in result)
            Console.WriteLine($"Заказ №{item.OrderId} от {item.OrderDate:dd.MM.yyyy} ({item.Status}) — Товар {item.ProductId}, кол-во: {item.Quantity}, сумма: {item.Total:N0} ₽");
    }
}

//46
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer { public int Id { get; set; } public string Name { get; set; } public string Phone { get; set; } }
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public int ProductId { get; set; } public DateTime Date { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } public string Category { get; set; } }

class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Иван Смирнов", Phone = "+7(999)111-22-33" },
            new Customer { Id = 2, Name = "Елена Козлова", Phone = "+7(999)444-55-66" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 1001, CustomerId = 1, ProductId = 10, Date = new DateTime(2025, 2, 15) },
            new Order { Id = 1002, CustomerId = 1, ProductId = 20, Date = new DateTime(2025, 3, 1) }
        };

        var products = new List<Product>
        {
            new Product { Id = 10, Name = "Смартфон Galaxy X", Price = 85000, Category = "Электроника" },
            new Product { Id = 20, Name = "Наушники Pro", Price = 15000, Category = "Аксессуары" }
        };

        var result = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.Name, c.Phone, o.Id, o.Date, o.ProductId })
                              .Join(products, co => co.ProductId, p => p.Id,
                                    (co, p) => new { co.Name, co.Phone, co.Id, co.Date, p.Name, p.Price, p.Category });

        Console.WriteLine("Полная информация по заказам:");
        foreach (var item in result)
            Console.WriteLine($"Клиент: {item.Name} ({item.Phone})\n  Заказ №{item.Id} от {item.Date:dd.MM.yyyy}\n  Товар: {item.Name} ({item.Category}) — {item.Price:N0} ₽\n");
    }
}

//47
using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Building { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? DepartmentId { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var departments = new List<Department>
        {
            new Department { Id = 10, Name = "Разработка", Building = "Корпус A" },
            new Department { Id = 20, Name = "Тестирование", Building = "Корпус B" },
            new Department { Id = 30, Name = "Продажи", Building = "Корпус C" }
        };

        var employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Андрей", LastName = "Иванов", DepartmentId = 10, Salary = 140000 },
            new Employee { Id = 2, FirstName = "Ольга", LastName = "Петрова", DepartmentId = 10, Salary = 130000 },
            new Employee { Id = 3, FirstName = "Сергей", LastName = "Сидоров", DepartmentId = null, Salary = 90000 },
            new Employee { Id = 4, FirstName = "Марина", LastName = "Козлова", DepartmentId = 20, Salary = 110000 }
        };

        var result = departments.GroupJoin(employees,
                                            d => d.Id,
                                            e => e.DepartmentId,
                                            (d, emps) => new
                                            {
                                                Department = d.Name,
                                                Building = d.Building,
                                                EmployeeCount = emps.Count(),
                                                Employees = emps.Select(e => $"{e.FirstName} {e.LastName} ({e.Salary:N0} ₽)")
                                            });

        Console.WriteLine("Отделы и сотрудники (GroupJoin):");
        foreach (var item in result)
        {
            Console.WriteLine($"Отдел: {item.Department} ({item.Building}), сотрудников: {item.EmployeeCount}");
            if (item.EmployeeCount > 0)
                foreach (var emp in item.Employees)
                    Console.WriteLine($"  → {emp}");
            else
                Console.WriteLine("  (нет сотрудников)");
            Console.WriteLine();
        }
    }
}

//48
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] colors = { "Красный", "Синий", "Зелёный", "Чёрный" };
        string[] sizes = { "S", "M", "L", "XL" };
        string[] materials = { "Хлопок", "Полиэстер", "Шерсть" };

        var combinations = colors.SelectMany(c => sizes,
                                (c, s) => new { c, s })
                                .SelectMany(cs => materials,
                                (cs, m) => new { cs.c, cs.s, m });

        Console.WriteLine("Все возможные комбинации одежды:");
        int count = 1;
        foreach (var item in combinations)
            Console.WriteLine($"{count++}. Цвет: {item.c}, Размер: {item.s}, Материал: {item.m}");
        Console.WriteLine($"Всего комбинаций: {combinations.Count()}");
    }
}

//49
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Year { get; set; }
    public double AverageGrade { get; set; }
}

public class Scholarship
{
    public int StudentId { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var excellentStudents = new List<Student>
        {
            new Student { Id = 1, FirstName = "Иван", LastName = "Петров", Year = 3, AverageGrade = 4.9 },
            new Student { Id = 2, FirstName = "Анна", LastName = "Сидорова", Year = 4, AverageGrade = 4.8 },
            new Student { Id = 3, FirstName = "Пётр", LastName = "Иванов", Year = 2, AverageGrade = 4.7 }
        }.Where(s => s.AverageGrade >= 4.7 && s.Year >= 2);

        var scholarships = new List<Scholarship>
        {
            new Scholarship { StudentId = 1, Type = "Повышенная", Amount = 8000 },
            new Scholarship { StudentId = 2, Type = "Академическая", Amount = 5000 }
        };

        var result = excellentStudents.Join(scholarships,
                                            s => s.Id,
                                            sch => sch.StudentId,
                                            (s, sch) => new
                                            {
                                                FullName = $"{s.FirstName} {s.LastName}",
                                                s.Year,
                                                s.AverageGrade,
                                                Scholarship = sch.Type,
                                                sch.Amount
                                            });

        Console.WriteLine("Отличники со стипендией:");
        foreach (var item in result.OrderByDescending(x => x.Amount))
            Console.WriteLine($"{item.FullName} ({item.Year} курс, средний балл {item.AverageGrade}) — {item.Scholarship}: {item.Amount:N0} ₽");
    }
}

//50
using System;
using System.Collections.Generic;
using System.Linq;

public class LegacyClient
{
    public int ClientCode { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
}

public class ModernClient
{
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Login { get; set; }
    public DateTime CreatedAt { get; set; }
}

class Program
{
    static void Main()
    {
        var legacy = new List<LegacyClient>
        {
            new LegacyClient { ClientCode = 1001, FullName = "Смирнов Иван Петрович", Email = "smirnov@example.com", RegistrationDate = new DateTime(2018, 5, 10) },
            new LegacyClient { ClientCode = 1002, FullName = "Козлова Анна Сергеевна", Email = "kozlova@mail.ru", RegistrationDate = new DateTime(2019, 8, 22) }
        };

        var modern = new List<ModernClient>
        {
            new ModernClient { UserId = Guid.NewGuid(), FirstName = "Пётр", LastName = "Иванов", Login = "petr_ivanov", CreatedAt = new DateTime(2024, 1, 15) },
            new ModernClient { UserId = Guid.NewGuid(), FirstName = "Мария", LastName = "Петрова", Login = "maria_p", CreatedAt = new DateTime(2025, 2, 1) }
        };

        var unified = legacy.Select(c => new
        {
            Id = c.ClientCode.ToString(),
            Name = c.FullName,
            Contact = c.Email,
            Registered = c.RegistrationDate,
            Source = "Старая система"
        })
        .Concat(modern.Select(c => new
        {
            Id = c.UserId.ToString().Substring(0, 8),
            Name = $"{c.FirstName} {c.LastName}",
            Contact = c.Login,
            Registered = c.CreatedAt,
            Source = "Новая система"
        }));

        Console.WriteLine("Объединённый список клиентов:");
        foreach (var client in unified.OrderBy(c => c.Registered))
            Console.WriteLine($"[{client.Source}] {client.Name} | {client.Contact} | ID: {client.Id} | с {client.Registered:dd.MM.yyyy}");
    }
}

//51
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var transactions = new List<decimal> { 15000.50m, 28750.75m, 8930.25m, 45120.00m, 12300.50m, 67890.25m };
        decimal total = transactions.Sum();
        Console.WriteLine($"Всего транзакций: {transactions.Count}");
        Console.WriteLine($"Сумма всех операций: {total:N2} ₽");
    }
}

//52
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var temperatures = new double[] { 18.5, 19.2, 17.8, 20.1, 21.3, 19.9, 18.7, 22.0 };
        double avg = temperatures.Average();
        Console.WriteLine($"Температуры за неделю: {string.Join(", ", temperatures)}");
        Console.WriteLine($"Средняя температура: {avg:F2}°C");
    }
}

//53
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sales = new int[] { 125000, 98000, 156000, 142000, 178000, 134000, 199000 };
        int max = sales.Max();
        int min = sales.Min();
        Console.WriteLine($"Продажи за 7 дней: {string.Join(" → ", sales)}");
        Console.WriteLine($"Лучший день: {max:N0} ₽");
        Console.WriteLine($"Худший день: {min:N0} ₽");
    }
}

//54
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 100).ToArray();
        int countEven = numbers.Count(n => n % 2 == 0);
        int countDivBy7 = numbers.Count(n => n % 7 == 0);
        int countPrimeLike = numbers.Count(n => n > 50 && n % 3 != 0 && n % 5 != 0);
        Console.WriteLine($"Чётных чисел от 1 до 100: {countEven}");
        Console.WriteLine($"Кратных 7: {countDivBy7}");
        Console.WriteLine($"Чисел >50 и не кратных 3 и 5: {countPrimeLike}");
    }
}

//55
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var factors = new int[] { 2, 3, 4, 5, 6 };
        long product = factors.Aggregate(1L, (acc, x) => acc * x);
        Console.WriteLine($"Числа: {string.Join(" × ", factors)}");
        Console.WriteLine($"Произведение = {product}");
    }
}

//56
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var values = new double[] { 23, 45, 12, 67, 34, 89, 56, 78, 90, 11, 55 };
        var sorted = values.OrderBy(x => x).ToArray();
        double median;
        int n = sorted.Length;
        if (n % 2 == 0)
            median = (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
        else
            median = sorted[n / 2];

        Console.WriteLine($"Исходные данные: {string.Join(", ", values)}");
        Console.WriteLine($"Отсортировано: {string.Join(", ", sorted)}");
        Console.WriteLine($"Медиана = {median}");
    }
}

//57
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var scores = new int[] { 98, 105, 87, 120, 150, 78, 199, 201 };
        bool hasOver200 = scores.Any(s => s > 200);
        bool allAbove70 = scores.All(s => s >= 70);
        bool hasPerfect = scores.Contains(200);
        Console.WriteLine($"Есть оценки выше 200: {hasOver200}");
        Console.WriteLine($"Все оценки не ниже 70: {allAbove70}");
        Console.WriteLine($"Есть идеальная оценка 200: {hasPerfect}");
    }
}

//58
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 10;
        long factorial = Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);
        Console.WriteLine($"Факториал {n}!");
        Console.WriteLine($"Результат = {factorial:N0}");
    }
}

//59
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 20).ToArray();
        long sumOfOddSquares = numbers.Where(n => n % 2 == 1)
                                      .Select(n => (long)n * n)
                                      .Sum();
        Console.WriteLine($"Нечётные числа до 20: {string.Join(", ", numbers.Where(n => n % 2 == 1))}");
        Console.WriteLine($"Сумма их квадратов = {sumOfOddSquares:N0}");
    }
}

//60
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var measurements = new double[] { 23.5, 24.1, 22.9, 25.3, 24.8, 23.7, 26.1, 24.5 };
        double mean = measurements.Average();
        double variance = measurements.Select(x => Math.Pow(x - mean, 2)).Average();
        double stdDev = Math.Sqrt(variance);

        Console.WriteLine($"Измерения: {string.Join(" | ", measurements)}");
        Console.WriteLine($"Среднее значение: {mean:F3}");
        Console.WriteLine($"Дисперсия: {variance:F4}");
        Console.WriteLine($"Стандартное отклонение: {stdDev:F4}");
    }
}
//61
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 9 };
        var unique = numbers.Distinct().OrderBy(x => x).ToList();
        Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
        Console.WriteLine("Без дубликатов: " + string.Join(", ", unique));
    }
}

//62
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var listA = new List<int> { 1, 2, 3, 4, 5 };
        var listB = new List<int> { 3, 4, 5, 6, 7, 8 };
        var union = listA.Union(listB).OrderBy(x => x).ToList();
        Console.WriteLine("Список A: " + string.Join(", ", listA));
        Console.WriteLine("Список B: " + string.Join(", ", listB));
        Console.WriteLine("Объединение (Union): " + string.Join(", ", union));
    }
}

//63
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var listA = new List<int> { 1, 2, 3, 4, 5, 6 };
        var listB = new List<int> { 4, 5, 6, 7, 8 };
        var difference = listA.Except(listB).OrderBy(x => x).ToList();
        Console.WriteLine("Список A: " + string.Join(", ", listA));
        Console.WriteLine("Список B: " + string.Join(", ", listB));
        Console.WriteLine("Только в A (Except): " + string.Join(", ", difference));
    }
}

//64
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var listA = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var listB = new List<int> { 3, 4, 5, 8, 9, 10 };
        var intersection = listA.Intersect(listB).OrderBy(x => x).ToList();
        Console.WriteLine("Список A: " + string.Join(", ", listA));
        Console.WriteLine("Список B: " + string.Join(", ", listB));
        Console.WriteLine("Пересечение (Intersect): " + string.Join(", ", intersection));
    }
}

//65
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new List<string> { "Apple", "banana", "APPLE", "Banana", "ORANGE", "apple", "orange" };
        var uniqueIgnoreCase = words.Select(w => w.ToLower())
                                   .Distinct()
                                   .Select(w => words.First(x => x.ToLower() == w))
                                   .ToList();
        Console.WriteLine("Исходный список: " + string.Join(", ", words));
        Console.WriteLine("Без дубликатов (без учёта регистра): " + string.Join(", ", uniqueIgnoreCase));
    }
}

//66
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class PersonComparer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y) => string.Equals(x.FirstName, y.FirstName, StringComparison.OrdinalIgnoreCase) &&
                                               string.Equals(x.LastName, y.LastName, StringComparison.OrdinalIgnoreCase);
    public int GetHashCode(Person obj) => (obj.FirstName.ToLower() + obj.LastName.ToLower()).GetHashCode();
}

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { FirstName = "Иван", LastName = "Петров", Age = 30 },
            new Person { FirstName = "иван", LastName = "петров", Age = 25 },
            new Person { FirstName = "Анна", LastName = "Сидорова", Age = 28 },
            new Person { FirstName = "Анна", LastName = "СИДОРОВА", Age = 32 }
        };

        var unique = people.Distinct(new PersonComparer()).ToList();
        Console.WriteLine("Уникальные люди (без учёта регистра имён):");
        foreach (var p in unique)
            Console.WriteLine($"{p.FirstName} {p.LastName}, возраст: {p.Age}");
    }
}

//67
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var registeredUsers = new List<string> { "ivan", "anna", "petr", "maria", "oleg" };
        var activeUsers = new List<string> { "Anna", "Oleg", "ivan", "sveta", "dmitry" };
        var common = registeredUsers.Intersect(activeUsers.Select(u => u.ToLower())).ToList();
        Console.WriteLine("Зарегистрированные: " + string.Join(", ", registeredUsers));
        Console.WriteLine("Активные: " + string.Join(", ", activeUsers));
        Console.WriteLine("Есть в обоих списках: " + string.Join(", ", common));
    }
}

//68
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var setA = new List<int> { 1, 2, 3, 4, 5, 6 };
        var setB = new List<int> { 4, 5, 6, 7, 8, 9 };
        var symmetricDiff = setA.Except(setB).Union(setB ";
        Console.WriteLine("Множество A: " + string.Join(", ", setA));
        Console.WriteLine("Множество B: " + string.Join(", ", setB));
        Console.WriteLine("Симметрическая разность: " + string.Join(", ", symmetricDiff));
    }
}

//69
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 20).ToList();
        var firstThree = numbers.Take(3).ToList();
        Console.WriteLine("Полный список: " + string.Join(", ", numbers));
        Console.WriteLine("Первые 3 элемента: " + string.Join(", ", firstThree));
    }
}

//70
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new List<string> { "C#", "Java", "Python", "JavaScript", "Go", "Rust", "Kotlin" };
        var afterSkip = words.Skip(2).ToList();
        Console.WriteLine("Все языки: " + string.Join(" → ", words));
        Console.WriteLine("Пропустив первые 2: " + string.Join(" → ", afterSkip));
    }
}

//71
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 5, 12, 8, 23, 17, 30, 9, 41, 55 };
        var firstEvenGreaterThan20 = numbers.FirstOrDefault(n => n % 2 == 0 && n > 20);
        Console.WriteLine("Список: " + string.Join(", ", numbers));
        Console.WriteLine($"Первый чётный > 20: {(firstEvenGreaterThan20 != 0 ? firstEvenGreaterThan20 : -1)}");
    }
}

//72
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var cities = new List<string> { "Москва", "Санкт-Петербург", "Казань", "Новосибирск", "Екатеринбург" };
        var lastCity = cities.Last();
        Console.WriteLine("Города: " + string.Join(" → ", cities));
        Console.WriteLine("Последний город: " + lastCity);
    }
}

//73
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var products = Enumerable.Range(1, 50).Select(i => $"Товар {i}").ToList();
        int page = 3;
        int pageSize = 10;
        var paged = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        Console.WriteLine($"Страница {page} (по {pageSize} элементов):");
        foreach (var p in paged)
            Console.WriteLine(p);
        Console.WriteLine($"Всего товаров: {products.Count}");
    }
}

//74
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 2, 4, 6, 8, 9, 10, 12, 15, 18 };
        var whileEven = numbers.TakeWhile(n => n % 2 == 0).ToList();
        Console.WriteLine("Список: " + string.Join(" → ", numbers));
        Console.WriteLine("Пока чётные (TakeWhile): " + string.Join(" → ", whileEven));
    }
}

//75
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var values = new List<int> { 1, 3, 5, 7, 8, 10, 12, 15 };
        var afterOdd = values.SkipWhile(n => n % 2 == 1).ToList();
        Console.WriteLine("Список: " + string.Join(" → ", values));
        Console.WriteLine("Пропустив нечётные (SkipWhile): " + string.Join(" → ", afterOdd));
    }
}

//76
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var scores = new List<int> { 78, 85, 92, 88, 95, 91, 87, 99, 100, 96 };
        var lastThree = scores.TakeLast(3).ToList();
        Console.WriteLine("Все оценки: " + string.Join(", ", scores));
        Console.WriteLine("Последние 3 оценки: " + string.Join(", ", lastThree));
    }
}

//77
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var nested = new List<List<string>>
        {
            new List<string> { "Яблоко", "Банан" },
            new List<string> { "Апельсин", "Груша", "Киви" },
            new List<string> { "Виноград" }
        };
        var flat = nested.SelectMany(list => list).OrderBy(f => f).ToList();
        Console.WriteLine("Вложенные списки:");
        foreach (var list in nested)
            Console.WriteLine("  • " + string.Join(", ", list));
        Console.WriteLine("Плоский список: " + string.Join(" → ", flat));
    }
}

//78
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var letters = new List<string> { "A", "B", "C" };
        var numbers = new List<int> { 1, 2, 3 };
        var cartesian = letters.SelectMany(l => numbers, (l, n) => $"{l}{n}").ToList();
        Console.WriteLine("Декартово произведение:");
        foreach (var item in cartesian)
            Console.WriteLine(item);
        Console.WriteLine($"Всего комбинаций: {cartesian.Count}");
    }
}

//79
using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    public string Name { get; set; }
    public List<string> Employees { get; set; }
}

class Program
{
    static void Main()
    {
        var company = new List<Department>
        {
            new Department { Name = "IT", Employees = new List<string> { "Иван", "Анна", "Пётр" } },
            new Department { Name = "HR", Employees = new List<string> { "Мария", "Ольга" } },
            new Department { Name = "Бухгалтерия", Employees = new List<string> { "Сергей", "Елена", "Дмитрий" } }
        };

        var allEmployees = company.SelectMany(d => d.Employees.Select(e => new { Department = d.Name, Employee = e })).ToList();
        Console.WriteLine("Все сотрудники компании:");
        foreach (var item in allEmployees)
            Console.WriteLine($"{item.Employee} — {item.Department}");
    }
}

//80
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var orders = new List<List<string>>
        {
            new List<string> { "Ноутбук", "Мышь" },
            new List<string> { "Монитор", "Клавиатура", "Наушники" },
            new List<string> { "Принтер" }
        };
        var allProducts = orders.SelectMany((order, index) => order.Select(product => new { OrderNumber = index + 1, Product = product })).ToList();
        Console.WriteLine("Все товары из всех заказов:");
        foreach (var item in allProducts)
            Console.WriteLine($"Заказ {item.OrderNumber}: {item.Product}");
    }
}

//81
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var toppings = new List<string> { "Сыр", "Пепперони", "Грибы" };
        var sauces = new List<string> { "Томатный", "Сливочный" };
        var sizes = new List<string> { "Маленькая", "Средняя", "Большая" };

        var combinations = toppings.SelectMany(t => sauces,
                                 (t, s) => new { t, s })
                                 .SelectMany(ts => sizes,
                                 (ts, sz) => $"Пицца: {sz}, соус: {ts.s}, начинка: {ts.t}");

        Console.WriteLine("Все возможные пиццы:");
        foreach (var pizza in combinations)
            Console.WriteLine(pizza);
        Console.WriteLine($"Всего вариантов: {combinations.Count()}");
    }
}

//82
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var phrases = new List<string> { "LINQ", "C#", "Программирование", "SelectMany" };
        var allChars = phrases.SelectMany(p => p.ToCharArray()).Distinct().OrderBy(c => c).ToList();
        Console.WriteLine("Фразы: " + string.Join(" | ", phrases));
        Console.WriteLine("Все уникальные символы: " + string.Join(" ", allChars));
    }
}

//83
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sentences = new List<string>
        {
            "LINQ очень мощный",
            "SelectMany разворачивает коллекции",
            "C# лучший язык"
        };

        var wordsWithPosition = sentences.SelectMany(
            (sentence, sentenceIndex) => sentence.Split(' ').Select(
                (word, wordIndex) => new { Sentence = sentenceIndex + 1, WordPosition = wordIndex + 1, Word = word }));

        Console.WriteLine("Слова с позициями:");
        foreach (var item in wordsWithPosition)
            Console.WriteLine($"Предложение {item.Sentence}, слово {item.WordPosition}: {item.Word}");
    }
}

//84
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var teamA = new List<string> { "Иван", "Анна", "Пётр" };
        var teamB = new List<string> { "Мария", "Олег" };
        var teamC = new List<string> { "Сергей", "Елена", "Дмитрий" };

        var allTeams = new[] { teamA, teamB, teamC };
        var allMembers = allTeams.SelectMany((team, index) => team.Select(member => new { Team = index + 1, Member = member })).ToList();

        Console.WriteLine("Все участники команд:");
        foreach (var item in allMembers)
            Console.WriteLine($"Команда {item.Team}: {item.Member}");
        Console.WriteLine($"Общее количество: {allMembers.Count}");
    }
}
//85
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 3, 7, 12, 8, 15, 4, 9, 22 };
        bool hasGreaterThan10 = numbers.Any(n => n > 10);
        Console.WriteLine("Список: " + string.Join(", ", numbers));
        Console.WriteLine($"Есть число больше 10: {hasGreaterThan10}");
    }
}

//86
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var values = new List<decimal> { 15.5m, 23.1m, 8.9m, 45.0m, 12.3m };
        bool allPositive = values.All(v => v > 0);
        Console.WriteLine("Значения: " + string.Join(" | ", values));
        Console.WriteLine($"Все положительные: {allPositive}");
        if (!allPositive)
            Console.WriteLine("Внимание: есть неположительные значения!");
    }
}

//87
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var cities = new List<string> { "Москва", "Париж", "Токио", "Лондон", "Берлин" };
        string target = "Токио";
        bool containsTokyo = cities.Contains(target);
        Console.WriteLine("Города: " + string.Join(" → ", cities));
        Console.WriteLine($"Содержит \"{target}\": {containsTokyo}");
    }
}

//88
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Ноутбук Pro", Price = 125000, Category = "Электроника" },
            new Product { Name = "Книга по C#", Price = 2500, Category = "Книги" },
            new Product { Name = "Мышь игровая", Price = 4500, Category = "Электроника" }
        };

        bool hasExpensiveElectronics = products.Any(p => p.Category == "Электроника" && p.Price > 100000);
        Console.WriteLine("Есть дорогая электроника (>100000 ₽): " + hasExpensiveElectronics);
    }
}

//89
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var emptyList = new List<int>();
        var nonEmptyList = new List<int> { 1, 2, 3 };

        Console.WriteLine($"Пустой список — пустой: {emptyList.Any() == false}");
        Console.WriteLine($"Непустой список — пустой: {nonEmptyList.Any() == false}");
    }
}

//90
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var scores = new List<int> { 95, 88, 92, 100, 87 };
        int requiredCount = 5;
        bool hasExactlyFive = scores.Count() == requiredCount;
        Console.WriteLine($"Оценок: {scores.Count}");
        Console.WriteLine($"Ровно {requiredCount} оценок: {hasExactlyFive}");
    }
}

//91
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var part1 = new[] { 1, 2, 3, 4, 5 };
        var part2 = new[] { 6, 7, 8, 9, 10 };
        var combined = part1.Concat(part2).ToArray();
        Console.WriteLine("Часть 1: " + string.Join(", ", part1));
        Console.WriteLine("Часть 2: " + string.Join(", ", part2));
        Console.WriteLine("Объединено (Concat): " + string.Join(" → ", combined));
    }
}

//92
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var languages = new List<string> { "C#", "Java", "Python" };
        var frameworks = new List<string> { "ASP.NET", "Spring", "Django" };
        var tools = new List<string> { "Visual Studio", "IntelliJ", "PyCharm" };

        var all = languages.Concat(frameworks).Concat(tools).OrderBy(x => x).ToList();
        Console.WriteLine("Все технологии: " + string.Join(" | ", all));
    }
}

//93
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 10, 20, 30 };
        var strings = new List<string> { "40", "50", "60" };
        var mixed = new List<object> { 70, "80", 90 };

        var allAsStrings = numbers.Select(n => n.ToString())
                                  .Concat(strings)
                                  .Concat(mixed.Cast<string>())
                                  .Select(int.Parse)
                                  .OrderBy(x => x)
                                  .ToList();

        Console.WriteLine("Все числа после приведения: " + string.Join(" → ", allAsStrings));
    }
}

//94
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sorted1 = new List<int> { 1, 3, 5, 7, 9 };
        var sorted2 = new List<int> { 2, 4, 6, 8, 10 };
        var mergedSorted = sorted1.Concat(sorted2).OrderBy(x => x).ToList();
        Console.WriteLine("Первый отсортированный: " + string.Join(", ", sorted1));
        Console.WriteLine("Второй отсортированный: " + string.Join(", ", sorted2));
        Console.WriteLine("Объединено и отсортировано: " + string.Join(" → ", mergedSorted));
    }
}

//95
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var objectList = new List<object> { 10, "не число", 25, 30, "ошибка", 45 };
        var integers = objectList.OfType<int>().ToList();
        Console.WriteLine("Исходный список объектов:");
        foreach (var item in objectList) Console.WriteLine($"  • {item} ({item.GetType().Name})");
        Console.WriteLine("Только целые числа: " + string.Join(", ", integers));
    }
}

//96
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var mixed = new List<object>
        {
            "Строка 1", 100, "Строка 2", 3.14, "Строка 3", true, 200, "Последняя строка"
        };

        var onlyStrings = mixed.OfType<string>().ToList();
        var onlyNumbers = mixed.OfType<int>().ToList();

        Console.WriteLine("Только строки:");
        foreach (var s in onlyStrings) Console.WriteLine($"  → {s}");
        Console.WriteLine("Только целые числа:");
        foreach (var n in onlyNumbers) Console.WriteLine($"  → {n}");
    }
}

//97
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var heterogeneous = new List<object>
        {
            42, "Привет", 3.14, new List<int> { 1, 2, 3 }, true, "Мир", 100, null, 5.5
        };

        var strings = heterogeneous.OfType<string>().ToList();
        var integers = heterogeneous.OfType<int>().ToList();
        var lists = heterogeneous.OfType<List<int>>().SelectMany(l => l).ToList();

        Console.WriteLine("Строки: " + string.Join(" | ", strings));
        Console.WriteLine("Целые числа: " + string.Join(", ", integers));
        Console.WriteLine("Числа из вложенных списков: " + string.Join(", ", lists));
    }
}

//98
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var stringNumbers = new List<string> { "10", "25", "37", "не число", "50", "88" };
        var safeIntegers = stringNumbers
            .Select(s =>
            {
                if (int.TryParse(s, out int result))
                    return (int?)result;
                return null;
            })
            .Where(n => n.HasValue)
            .Select(n => n.Value)
            .ToList();

        Console.WriteLine("Успешно преобразованные числа: " + string.Join(" → ", safeIntegers));
    }
}

//99
using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int Id { get; set; }
    public string Customer { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { Id = 1, Customer = "Иван", Amount = 15000, Date = new DateTime(2025, 1, 10) },
            new Order { Id = 2, Customer = "Анна", Amount = 45000, Date = new DateTime(2025, 1, 15) },
            new Order { Id = 3, Customer = "Иван", Amount = 30000, Date = new DateTime(2025, 2, 5) },
            new Order { Id = 4, Customer = "Пётр", Amount = 80000, Date = new DateTime(2025, 2, 20) },
            new Order { Id = 5, Customer = "Анна", Amount = 20000, Date = new DateTime(2025, 3, 1) }
        };

        var result = orders
            .GroupBy(o => o.Customer)
            .Select(g => new
            {
                Customer = g.Key,
                TotalAmount = g.Sum(o => o.Amount),
                OrderCount = g.Count(),
                AvgOrder = g.Average(o => o.Amount),
                LastOrderDate = g.Max(o => o.Date)
            })
            .Where(x => x.TotalAmount > 50000)
            .OrderByDescending(x => x.TotalAmount);

        Console.WriteLine("Клиенты с общей суммой заказов > 50 000 ₽:");
        foreach (var item in result)
            Console.WriteLine($"{item.Customer}: {item.TotalAmount:N0} ₽ ({item.OrderCount} заказов, средний: {item.AvgOrder:N0} ₽, последний: {item.LastOrderDate:dd.MM.yyyy})");
    }
}

//100
using System;
using System.Collections.Generic;
using System.Linq;

public class Customer { public int Id { get; set; } public string Name { get; set; } }
public class Order { public int Id { get; set; } public int CustomerId { get; set; } public int ProductId { get; set; } public decimal Amount { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } public string Category { get; set; } }

class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Иван Петров" },
            new Customer { Id = 2, Name = "Анна Сидорова" },
            new Customer { Id = 3, Name = "Пётр Иванов" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 101, CustomerId = 1, ProductId = 10, Amount = 85000 },
            new Order { Id = 102, CustomerId = 1, ProductId = 20, Amount = 15000 },
            new Order { Id = 103, CustomerId = 2, ProductId = 10, Amount = 90000 },
            new Order { Id = 104, CustomerId = 3, ProductId = 30, Amount = 45000 }
        };

        var products = new List<Product>
        {
            new Product { Id = 10, Name = "Ноутбук Pro", Category = "Электроника" },
            new Product { Id = 20, Name = "Наушники", Category = "Аксессуары" },
            new Product { Id = 30, Name = "Книга по C#", Category = "Литература" }
        };

        var report = customers
            .Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.Name, o.Amount, o.ProductId })
            .Join(products, co => co.ProductId, p => p.Id, (co, p) => new { co.Name, co.Amount, p.Category })
            .GroupBy(x => x.Category)
            .Select(g => new
            {
                Category = g.Key,
                TotalSales = g.Sum(x => x.Amount),
                CustomerCount = g.Select(x => x.Name).Distinct().Count(),
                TopCustomer = g.GroupBy(x => x.Name)
                               .OrderByDescending(cg => cg.Sum(x => x.Amount))
                               .First().Key
            })
            .OrderByDescending(x => x.TotalSales);

        Console.WriteLine("Отчёт по категориям товаров:");
        foreach (var item in report)
            Console.WriteLine($"Категория: {item.Category}\n" +
                              $"  Общая выручка: {item.TotalSales:N0} ₽\n" +
                              $"  Покупателей: {item.CustomerCount}\n" +
                              $"  Лучший покупатель: {item.TopCustomer}\n");
    }
}