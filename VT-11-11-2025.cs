using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BoxingAndDateTimeTasks
{
    //1
    class BoxingPerformanceDemo
    {
        static void Main()
        {
            int value = 42;
            object boxed = value;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                object b = i;
            }
            sw.Stop();
            Console.WriteLine($"Boxing time: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                int v = i;
            }
            sw.Stop();
            Console.WriteLine($"Without boxing: {sw.ElapsedMilliseconds} ms");
        }
    }

    //2
    class UnboxingWithCheck
    {
        static void Main()
        {
            object boxed = 42;
            if (boxed is int)
            {
                int unboxed = (int)boxed;
                Console.WriteLine($"Unboxed: {unboxed}");
            }
            else
            {
                Console.WriteLine("Not an int");
            }
        }
    }

    //3
    class SafeUnbox
    {
        static void UnboxToVarious(object obj)
        {
            switch (obj)
            {
                case int i: Console.WriteLine($"Int: {i}"); break;
                case double d: Console.WriteLine($"Double: {d}"); break;
                case bool b: Console.WriteLine($"Bool: {b}"); break;
                default: Console.WriteLine("Unknown type"); break;
            }
        }
        static void Main()
        {
            UnboxToVarious(42);
            UnboxToVarious(3.14);
            UnboxToVarious(true);
        }
    }

    //4
    class BoxingVsUnboxingPerf
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                object b = i;
                int u = (int)b;
            }
            sw.Stop();
            Console.WriteLine($"With boxing/unboxing: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                int v = i;
            }
            sw.Stop();
            Console.WriteLine($"Without: {sw.ElapsedMilliseconds} ms");
        }
    }

    //5
    class ArrayListBoxingDemo
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(42);
            arrayList.Add(3.14);
            arrayList.Add(true);
            arrayList.Add('A');
            arrayList.Add(DateTime.Now);
            arrayList.Add("Hello");
            Console.WriteLine("ArrayList contents:");
            foreach (object item in arrayList)
            {
                Console.WriteLine($"Value: {item}, Type: {item.GetType().Name}");
            }
            int unboxedInt = (int)arrayList[0];
            double unboxedDouble = (double)arrayList[1];
            bool unboxedBool = (bool)arrayList[2];
            Console.WriteLine($"Unboxed int: {unboxedInt}");
            Console.WriteLine($"Unboxed double: {unboxedDouble}");
            Console.WriteLine($"Unboxed bool: {unboxedBool}");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ArrayList list1 = new ArrayList();
            for (int i = 0; i < 100000; i++)
            {
                list1.Add(i);
            }
            sw.Stop();
            Console.WriteLine($"ArrayList (boxing): {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            List<int> list2 = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                list2.Add(i);
            }
            sw.Stop();
            Console.WriteLine($"List<int> (no boxing): {sw.ElapsedMilliseconds} ms");
        }
    }

    //6
    class CountBoxingInArrayList
    {
        static int boxingCount = 0;
        class MonitoredArrayList : ArrayList
        {
            public override int Add(object value)
            {
                if (value != null && value.GetType().IsValueType)
                {
                    boxingCount++;
                }
                return base.Add(value);
            }
        }
        static void Main()
        {
            MonitoredArrayList list = new MonitoredArrayList();
            list.Add(42);
            list.Add("string");
            list.Add(3.14);
            Console.WriteLine($"Boxing operations: {boxingCount}");
        }
    }

    //7
    class ListVsArrayListPerf
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            ArrayList al = new ArrayList();
            for (int i = 0; i < 10000; i++) al.Add(i);
            sw.Stop();
            Console.WriteLine($"ArrayList: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            List<int> list = new List<int>();
            for (int i = 0; i < 10000; i++) list.Add(i);
            sw.Stop();
            Console.WriteLine($"List<int>: {sw.ElapsedMilliseconds} ms");
        }
    }

    //8
    class InvalidCastDemo
    {
        static void Main()
        {
            object boxed = 42;
            try
            {
                double unboxed = (double)boxed;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

    //9
    class ParamsObjectProcessing
    {
        static void ProcessValues(params object[] values)
        {
            Console.WriteLine($"Processing {values.Length} values");
            foreach (object value in values)
            {
                switch (value)
                {
                    case int i: Console.WriteLine($"Int: {i}"); break;
                    case double d: Console.WriteLine($"Double: {d:F2}"); break;
                    case bool b: Console.WriteLine($"Bool: {b}"); break;
                    case string s: Console.WriteLine($"String: {s}"); break;
                    case DateTime dt: Console.WriteLine($"Date: {dt:yyyy-MM-dd}"); break;
                    case null: Console.WriteLine("Null"); break;
                    default: Console.WriteLine($"Other: {value}"); break;
                }
            }
        }
        static Dictionary<Type, int> CountTypes(params object[] values)
        {
            var counts = new Dictionary<Type, int>();
            foreach (object v in values)
            {
                Type t = v?.GetType() ?? typeof(object);
                if (counts.ContainsKey(t)) counts[t]++;
                else counts[t] = 1;
            }
            return counts;
        }
        static void Main()
        {
            ProcessValues(42, 3.14159, true, "Hello", DateTime.Now, 'X', null);
            var counts = CountTypes(10, 20, 30, "test", "hello", 5.5, 7.7, 8.8, true, false);
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key.Name}: {kvp.Value}");
            }
        }
    }

    //10
    struct MyStruct : IComparable
    {
        public int Value;
        public int CompareTo(object obj) => Value.CompareTo(((MyStruct)obj).Value);
    }
    class StructBoxingToInterface
    {
        static void Main()
        {
            MyStruct s = new MyStruct { Value = 42 };
            object boxed = s;
            IComparable comparable = (IComparable)boxed;
            Console.WriteLine(comparable.CompareTo(new MyStruct { Value = 40 }));
        }
    }

    //11
    class IsBoxedValueType
    {
        static bool IsBoxed(object obj)
        {
            return obj != null && obj.GetType().IsValueType;
        }
        static void Main()
        {
            object boxedInt = 42;
            object str = "hello";
            Console.WriteLine($"42 boxed: {IsBoxed(boxedInt)}");
            Console.WriteLine($"String: {IsBoxed(str)}");
        }
    }

    //12
    class NullableBoxing
    {
        static void Main()
        {
            int? nullableInt = 42;
            object boxedInt = nullableInt;
            double? nullableDouble = 3.14;
            object boxedDouble = nullableDouble;
            Console.WriteLine($"Boxed int?: {boxedInt}");
            Console.WriteLine($"Boxed double?: {boxedDouble}");
            int? unboxedInt = (int?)boxedInt;
            Console.WriteLine($"Unboxed: {unboxedInt}");
        }
    }

    //13
    class BoxingProfiler
    {
        static int boxingCount = 0;
        static void MonitorBoxing()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) => { };
        }
        static void Main()
        {
            MonitorBoxing();
            object b = 42;
            Console.WriteLine("Boxing occurred");
        }
    }

    //14
    class GenericNoBoxing
    {
        static void Process<T>(T value) where T : struct
        {
            Console.WriteLine(value);
        }
        static void Main()
        {
            Process(42);
            Process(3.14);
        }
    }

    //15
    class CompareBoxed
    {
        static void Main()
        {
            object boxed1 = 42;
            object boxed2 = 42;
            Console.WriteLine($"Equals: {boxed1.Equals(boxed2)}");
            Console.WriteLine($"ReferenceEquals: {object.ReferenceEquals(boxed1, boxed2)}");
        }
    }

    //16
    enum MyEnum { Value1, Value2 }
    class EnumBoxing
    {
        static void Main()
        {
            MyEnum e = MyEnum.Value1;
            object boxed = e;
            MyEnum unboxed = (MyEnum)boxed;
            Console.WriteLine(unboxed);
        }
    }

    //17
    struct MyStruct2
    {
        public int Value;
        public object Clone()
        {
            object boxed = this;
            return (MyStruct2)boxed;
        }
    }
    class StructCloneViaBoxing
    {
        static void Main()
        {
            MyStruct2 s = new MyStruct2 { Value = 42 };
            MyStruct2 clone = (MyStruct2)s.Clone();
            Console.WriteLine(clone.Value);
        }
    }

    //18
    class BoxingBenchmark
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                object b = i;
                int u = (int)b;
            }
            sw.Stop();
            Console.WriteLine($"Boxing/Unboxing overhead: {sw.ElapsedMilliseconds} ms");
        }
    }

    //19
    class BoxedValueCache
    {
        static Dictionary<int, object> cache = new Dictionary<int, object>();
        static object GetCached(int value)
        {
            if (!cache.ContainsKey(value))
                cache[value] = value;
            return cache[value];
        }
        static void Main()
        {
            object b1 = GetCached(42);
            object b2 = GetCached(42);
            Console.WriteLine(object.ReferenceEquals(b1, b2));
        }
    }

    //20
    struct MutableStruct : IEquatable<MutableStruct>
    {
        public int Value;
        public bool Equals(MutableStruct other) => Value == other.Value;
    }
    class ModifyBoxedViaInterface
    {
        static void Main()
        {
            MutableStruct s = new MutableStruct { Value = 42 };
            object boxed = s;
            ((MutableStruct)boxed).Value = 100;
            Console.WriteLine(s.Value);
        }
    }

    //21
    class ExplicitBoxing
    {
        static void Main()
        {
            int value = 42;
            object boxed = (object)value;
            Console.WriteLine(boxed);
        }
    }

    //22
    class ImplicitBoxingParam
    {
        static void AcceptObject(object o) { Console.WriteLine(o); }
        static void Main()
        {
            int value = 42;
            AcceptObject(value);
        }
    }

    //23
    class VirtualMethodBoxing
    {
        static void Main()
        {
            int value = 42;
            object boxed = value;
            Console.WriteLine(boxed.ToString());
            Console.WriteLine(boxed.GetHashCode());
        }
    }

    //24
    class InterfaceBoxing
    {
        static void Main()
        {
            int value = 42;
            IComparable comparable = value;
            Console.WriteLine(comparable.CompareTo(40));
        }
    }

    //25
    class LinqBoxing
    {
        static void Main()
        {
            int[] values = { 1, 2, 3 };
            var query = from object v in values select v;
            foreach (var item in query) Console.WriteLine(item);
        }
    }

    //26
    class CollectionBoxing
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(42);
            Console.WriteLine(list[0]);
        }
    }

    //27
    class ReflectionBoxing
    {
        static void Main()
        {
            int value = 42;
            MethodInfo method = typeof(Console).GetMethod("WriteLine", new[] { typeof(object) });
            method.Invoke(null, new[] { value });
        }
    }

    //28
    class DelegateBoxing
    {
        delegate void ObjectDelegate(object o);
        static void Process(object o) { Console.WriteLine(o); }
        static void Main()
        {
            ObjectDelegate del = Process;
            del(42);
        }
    }

    //29
    class EventArgsBoxing
    {
        class MyEventArgs : EventArgs
        {
            public object Value { get; set; }
        }
        static event EventHandler<MyEventArgs> MyEvent;
        static void Main()
        {
            MyEvent?.Invoke(null, new MyEventArgs { Value = 42 });
        }
    }

    //30
    class IsAsBoxing
    {
        static void Main()
        {
            object o = 42;
            if (o is int i) Console.WriteLine(i);
            int? asInt = o as int?;
            Console.WriteLine(asInt);
        }
    }

    //31
    class DynamicBoxing
    {
        static void Main()
        {
            dynamic d = 42;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            dynamic d1 = 42;
            dynamic d2 = 3.14;
            dynamic d3 = true;
            dynamic d4 = "text";
            dynamic d5 = DateTime.Now;
            Console.WriteLine(d1.GetType().Name);
            Console.WriteLine(d2.GetType().Name);
            Console.WriteLine(d3.GetType().Name);
            Console.WriteLine(d4.GetType().Name);
            Console.WriteLine(d5.GetType().Name);
            dynamic result = d1 + d1;
            Console.WriteLine(result);
            dynamic changing = 100;
            Console.WriteLine(changing.GetType().Name);
            changing = "Now string";
            Console.WriteLine(changing.GetType().Name);
            changing = 99.99;
            Console.WriteLine(changing.GetType().Name);
            const int iterations = 1000000;
            Stopwatch sw = Stopwatch.StartNew();
            int sum1 = 0;
            for (int i = 0; i < iterations; i++) sum1 += i;
            sw.Stop();
            Console.WriteLine($"int: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            dynamic sum2 = 0;
            for (int i = 0; i < iterations; i++) sum2 += i;
            sw.Stop();
            Console.WriteLine($"dynamic: {sw.ElapsedMilliseconds} ms");
        }
    }

    //32
    class SerializationBoxing
    {
        [DataContract]
        struct MyStruct3 { public int Value; }
        static void Main()
        {
            MyStruct3 s = new MyStruct3 { Value = 42 };
            DataContractSerializer serializer = new DataContractSerializer(typeof(MyStruct3));
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, s);
            }
        }
    }

    //33
    class StringFormatBoxing
    {
        static void Main()
        {
            int age = 25;
            double salary = 50000.50;
            bool isActive = true;
            char grade = 'A';
            string formatted = string.Format("Age: {0}, Salary: {1:C}, Active: {2}, Grade: {3}", age, salary, isActive, grade);
            Console.WriteLine(formatted);
            string interpolated = $"Age: {age}, Salary: {salary:C}, Active: {isActive}, Grade: {grade}";
            Console.WriteLine(interpolated);
            var sb = new StringBuilder();
            sb.Append("Age: ").Append(age).Append(", Salary: ").Append(salary).Append(", Active: ").Append(isActive).Append(", Grade: ").Append(grade);
            Console.WriteLine(sb.ToString());
            string concatenated = string.Concat("Age: ", age, ", Salary: ", salary);
            Console.WriteLine(concatenated);
            const int iterations = 100000;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                string s = string.Format("Number: {0}, Decimal: {1}", i, i * 0.5);
            }
            sw.Stop();
            Console.WriteLine($"String.Format: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                string s = $"Number: {i}, Decimal: {i * 0.5}";
            }
            sw.Stop();
            Console.WriteLine($"Interpolation: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine("Name: {0}, Age: {1}, Height: {2:F2}m", "John", 30, 1.85);
            Console.WriteLine("Price: {0:C}, Quantity: {1}, Total: {2:C}", 99.99, 5, 99.99 * 5);
        }
    }

    //34
    class NullableToObject
    {
        static void Main()
        {
            int? n = 42;
            object o = n;
            Console.WriteLine(o);
            n = null;
            o = n;
            Console.WriteLine(o == null);
        }
    }

    //35
    class EqualsBoxing
    {
        static void Main()
        {
            int a = 42;
            int b = 42;
            Console.WriteLine(a.Equals(b));
            object oa = a;
            object ob = b;
            Console.WriteLine(oa.Equals(ob));
        }
    }

    //36
    class AttributeBoxing
    {
        [AttributeUsage(AttributeTargets.All)]
        class MyAttribute : Attribute
        {
            public object Value { get; set; }
            public MyAttribute(object value) { Value = value; }
        }
        [MyAttribute(42)]
        class MyClass { }
        static void Main()
        {
            var attr = (MyAttribute)typeof(MyClass).GetCustomAttributes(false)[0];
            Console.WriteLine(attr.Value);
        }
    }

    //37
    class MethodInvokeBoxing
    {
        static void Main()
        {
            MethodInfo mi = typeof(Console).GetMethod("WriteLine", new[] { typeof(int) });
            mi.Invoke(null, new object[] { 42 });
        }
    }

    //38
    class WeakReferenceBoxing
    {
        static void Main()
        {
            int value = 42;
            WeakReference wr = new WeakReference(value);
            if (wr.IsAlive) Console.WriteLine(wr.Target);
        }
    }

    //39
    class ConditionalWeakTableBoxing
    {
        static void Main()
        {
            var cwt = new ConditionalWeakTable<object, string>();
            object key = 42;
            cwt.Add(key, "Value");
            if (cwt.TryGetValue(key, out string val)) Console.WriteLine(val);
        }
    }

    //40
    class CompareBoxingTypesPerf
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            object o = (object)42;
            sw.Stop();
            Console.WriteLine($"Explicit: {sw.ElapsedTicks}");
            sw.Restart();
            AcceptObject(42);
            sw.Stop();
            Console.WriteLine($"Implicit param: {sw.ElapsedTicks}");
            static void AcceptObject(object obj) { }
        }
    }

    //41
    class CalculateAge
    {
        static int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }
        static void Main()
        {
            Console.WriteLine(GetAge(new DateTime(1990, 1, 1)));
        }
    }

    //42
    class BusinessDaysCalculator
    {
        static int GetBusinessDays(DateTime start, DateTime end)
        {
            int days = 0;
            while (start < end)
            {
                start = start.AddDays(1);
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday) days++;
            }
            return days;
        }
        static void Main()
        {
            Console.WriteLine(GetBusinessDays(new DateTime(2023, 1, 1), new DateTime(2023, 1, 31)));
        }
    }

    //43
    class DaysToEndOfYear
    {
        static int GetDaysToEndOfYear(DateTime date)
        {
            return (new DateTime(date.Year, 12, 31) - date).Days;
        }
        static void Main()
        {
            Console.WriteLine(GetDaysToEndOfYear(DateTime.Today));
        }
    }

    //44
    class DateTimeFormatCultures
    {
        static string FormatInCulture(DateTime dt, string culture)
        {
            return dt.ToString("f", new CultureInfo(culture));
        }
        static void Main()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(FormatInCulture(dt, "en-US"));
            Console.WriteLine(FormatInCulture(dt, "ru-RU"));
        }
    }

    //45
    class DateDifference
    {
        static (int years, int months, int days) GetDifference(DateTime start, DateTime end)
        {
            int years = end.Year - start.Year;
            int months = end.Month - start.Month;
            int days = end.Day - start.Day;
            if (days < 0) { months--; days += DateTime.DaysInMonth(end.Year, end.Month); }
            if (months < 0) { years--; months += 12; }
            return (years, months, days);
        }
        static void Main()
        {
            var diff = GetDifference(new DateTime(2000, 1, 1), DateTime.Today);
            Console.WriteLine($"Years: {diff.years}, Months: {diff.months}, Days: {diff.days}");
        }
    }

    //46
    class ParseDateTime
    {
        static DateTime Parse(string s)
        {
            return DateTime.Parse(s, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
        static void Main()
        {
            Console.WriteLine(Parse("2023-01-01"));
            Console.WriteLine(Parse("01/01/2023"));
        }
    }

    //47
    class AddBusinessDays
    {
        static DateTime AddBusinessDays(DateTime date, int days)
        {
            while (days > 0)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday) days--;
            }
            return date;
        }
        static void Main()
        {
            Console.WriteLine(AddBusinessDays(DateTime.Today, 5));
        }
    }

    //48
    class IsLeapYear
    {
        static bool IsLeap(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year);
        }
        static void Main()
        {
            Console.WriteLine(IsLeap(new DateTime(2024, 1, 1)));
        }
    }

    //49
    class FirstLastDayOfMonth
    {
        static (DateTime first, DateTime last) GetMonthBounds(DateTime date)
        {
            DateTime first = new DateTime(date.Year, date.Month, 1);
            DateTime last = first.AddMonths(1).AddDays(-1);
            return (first, last);
        }
        static void Main()
        {
            var bounds = GetMonthBounds(DateTime.Today);
            Console.WriteLine($"First: {bounds.first}, Last: {bounds.last}");
        }
    }

    //50
    class CountdownTimer
    {
        static void Countdown(TimeSpan ts)
        {
            while (ts > TimeSpan.Zero)
            {
                Console.WriteLine(ts);
                Thread.Sleep(1000);
                ts = ts.Subtract(TimeSpan.FromSeconds(1));
            }
        }
        static void Main()
        {
            Countdown(TimeSpan.FromSeconds(10));
        }
    }

    //51
    class UtcLocalConvert
    {
        static DateTime ToLocal(DateTime utc) => utc.ToLocalTime();
        static DateTime ToUtc(DateTime local) => local.ToUniversalTime();
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(ToUtc(now));
            Console.WriteLine(ToLocal(DateTime.UtcNow));
        }
    }

    //52
    class GetQuarter
    {
        static int GetQuarter(DateTime date)
        {
            return (date.Month - 1) / 3 + 1;
        }
        static void Main()
        {
            Console.WriteLine(GetQuarter(DateTime.Today));
        }
    }

    //53
    class CompareDatesIgnoreTime
    {
        static bool DatesEqual(DateTime d1, DateTime d2)
        {
            return d1.Date == d2.Date;
        }
        static void Main()
        {
            Console.WriteLine(DatesEqual(DateTime.Now, DateTime.Now.AddHours(1)));
        }
    }

    //54
    class DateTimeStopwatch
    {
        static TimeSpan Measure(Action action)
        {
            DateTime start = DateTime.Now;
            action();
            return DateTime.Now - start;
        }
        static void Main()
        {
            Console.WriteLine(Measure(() => Thread.Sleep(1000)));
        }
    }

    //55
    class TimeSpanDifference
    {
        static TimeSpan Diff(TimeSpan t1, TimeSpan t2)
        {
            return t1 - t2;
        }
        static void Main()
        {
            Console.WriteLine(Diff(TimeSpan.FromHours(2), TimeSpan.FromHours(1)));
        }
    }

    //56
    class RoundDateTime
    {
        static DateTime RoundToHour(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0).AddHours(dt.Minute >= 30 ? 1 : 0);
        }
        static void Main()
        {
            Console.WriteLine(RoundToHour(DateTime.Now));
        }
    }

    //57
    class IsoWeekOfYear
    {
        static int GetIsoWeek(DateTime date)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return ci.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        static void Main()
        {
            Console.WriteLine(GetIsoWeek(DateTime.Today));
        }
    }

    //58
    class TaskScheduler
    {
        static async Task Schedule(Action action, DateTime time)
        {
            await Task.Delay(time - DateTime.Now);
            action();
        }
        static void Main()
        {
            Schedule(() => Console.WriteLine("Task"), DateTime.Now.AddSeconds(5)).Wait();
        }
    }

    //59
    class TimeZoneWork
    {
        static void Main()
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime utc = DateTime.UtcNow;
            DateTime local = TimeZoneInfo.ConvertTimeFromUtc(utc, tz);
            Console.WriteLine(local);
        }
    }

    //60
    class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Duration => End - Start;
        public bool Contains(DateTime date) => date >= Start && date <= End;
    }
    class DateRangeDemo
    {
        static void Main()
        {
            DateRange range = new DateRange { Start = DateTime.Today, End = DateTime.Today.AddDays(5) };
            Console.WriteLine(range.Duration);
            Console.WriteLine(range.Contains(DateTime.Today.AddDays(3)));
        }
    }


//62
public interface IConsumer<in T>
{
    void Consume(T item);
}

//63
class CovarianceIEnumerable
{
    class Base { }
    class Derived : Base { }
    static void Main()
    {
        IEnumerable<Derived> derived = new List<Derived> { new Derived() };
        IEnumerable<Base> baseEnum = derived;
    }
}

//64
delegate Derived CovariantReturnDelegate();
class Base { }
class Derived : Base { }
class CovariantDelegateExample
{
    static Derived GetDerived() => new Derived();
    static void Main()
    {
        CovariantReturnDelegate del = GetDerived;
    }
}

//65
delegate void ContravariantParamDelegate(Base param);
class ContravariantDelegateExample
{
    static void ProcessBase(Base b) { }
    static void Main()
    {
        ContravariantParamDelegate del = ProcessBase;
        Derived d = new Derived();
        del(d);
    }
}

//66
public class Animal { }
public class Dog : Animal { }
public class Puppy : Dog { }

//67
public static class IEnumerableExtensions
{
    public static IEnumerable<T> CovariantWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        return source.Where(predicate);
    }
}

//68
public class ContravariantComparer<T> : IComparer<T> where T : Base
{
    public int Compare(T x, T y) => 0;
}

//69
class VarianceError
{
    static void Main()
    {
        List<Derived> derivedList = new List<Derived>();
        // List<Base> baseList = derivedList; // Error
    }
}

//70
public class CovariantGeneric<out T>
{
    private T value;
    public CovariantGeneric(T v) { value = v; }
    public T Get() => value;
}

//71
class ActionContravariance
{
    static void ProcessAnimal(Animal a) { }
    static void Main()
    {
        Action<Dog> dogAction = ProcessAnimal;
        dogAction(new Dog());
    }
}

//72
class FuncCovariance
{
    static Dog GetDog() => new Dog();
    static void Main()
    {
        Func<Animal> animalFunc = GetDog;
        Animal a = animalFunc();
    }
}

//73
public interface IRepository<out TEntity, in TKey>
{
    TEntity Get(TKey key);
    void Add(TEntity entity);
}

//74
public interface IFactory<out T>
{
    T Create();
}
public class DogFactory : IFactory<Dog>
{
    public Dog Create() => new Dog();
}
class FactoryCovariance
{
    static void Main()
    {
        IFactory<Animal> animalFactory = new DogFactory();
        Animal a = animalFactory.Create();
    }
}

//75
class CovariantEventArgs : EventArgs { }
delegate void EventHandler<in TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs;
class EventVariance
{
    public event EventHandler<CovariantEventArgs> MyEvent;
}

//76
public interface IVisitor<in T>
{
    void Visit(T item);
}
class AnimalVisitor : IVisitor<Animal>
{
    public void Visit(Animal item) { }
}
class ContravariantVisitor
{
    static void AcceptVisitor(IVisitor<Dog> visitor, Dog dog)
    {
        visitor.Visit(dog);
    }
    static void Main()
    {
        IVisitor<Animal> animalVisitor = new AnimalVisitor();
        AcceptVisitor(animalVisitor, new Dog());
    }
}

//77
public interface IReadOnlyCollection<out T> : IEnumerable<T>
{
    int Count { get; }
}

//78
class SafeCastVariance
{
    static void Main()
    {
        IEnumerable<Dog> dogs = new List<Dog>();
        IEnumerable<Animal> animals = dogs;
    }
}

//79
public interface IProcessor<in TIn, out TOut>
{
    TOut Process(TIn input);
}

//80
public class GenericMethodVariance
{
    public static TOutput Process<TInput, TOutput>(TInput input) where TOutput : TInput
    {
        return (TOutput)input;
    }
}

//81
public enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
class WeekendChecker
{
    public static bool IsWeekend(DaysOfWeek day)
    {
        return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
    }
}

//82
public enum Status { None = 0, Pending = 1, Active = 2 }

//83
[Flags]
public enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    Delete = 8,
    ReadWrite = Read | Write,
    ReadExecute = Read | Execute,
    ReadWriteExecute = Read | Write | Execute,
    FullControl = Read | Write | Execute | Delete
}
class FilePermissionsDemo
{
    static void DisplayPermissions(FilePermissions permissions)
    {
        Console.WriteLine(permissions);
        Console.WriteLine(Convert.ToString((int)permissions, 2).PadLeft(4, '0'));
        if (permissions.HasFlag(FilePermissions.Read)) Console.WriteLine("Read");
        if (permissions.HasFlag(FilePermissions.Write)) Console.WriteLine("Write");
        if (permissions.HasFlag(FilePermissions.Execute)) Console.WriteLine("Execute");
        if (permissions.HasFlag(FilePermissions.Delete)) Console.WriteLine("Delete");
    }
    static int CountSetFlags(FilePermissions permissions)
    {
        int count = 0;
        int value = (int)permissions;
        while (value > 0)
        {
            if ((value & 1) == 1) count++;
            value >>= 1;
        }
        return count;
    }
}

//84
class EnumStringConverter
{
    public static string ToString<TEnum>(TEnum value) where TEnum : Enum
    {
        return value.ToString();
    }
    public static TEnum FromString<TEnum>(string s) where TEnum : Enum
    {
        return (TEnum)Enum.Parse(typeof(TEnum), s);
    }
}

//85
public enum MyEnumWithDesc
{
    [Description("First Value")]
    Value1,
    [Description("Second Value")]
    Value2
}
public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());
        DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }
}

//86
public static class EnumExtensions2
{
    public static IEnumerable<T> GetAllValues<T>() where T : Enum
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }
}

//87
class EnumValidator
{
    public static bool IsValid<T>(object value) where T : Enum
    {
        return Enum.IsDefined(typeof(T), value);
    }
}

//88
public enum OrderStatus { New, Processing, Shipped, Delivered }
class OrderStatusTransitions
{
    public static OrderStatus Next(OrderStatus current)
    {
        switch (current)
        {
            case OrderStatus.New: return OrderStatus.Processing;
            case OrderStatus.Processing: return OrderStatus.Shipped;
            case OrderStatus.Shipped: return OrderStatus.Delivered;
            default: return current;
        }
    }
}

//89
class GenericEnumParser
{
    public static T Parse<T>(string value) where T : struct, Enum
    {
        return Enum.Parse<T>(value);
    }
}

//90
public enum ByteEnum : byte { Value1, Value2 }

//91
class CyclicEnum
{
    public static T Next<T>(T current) where T : Enum
    {
        var values = Enum.GetValues(typeof(T)).Cast<T>().ToArray();
        int index = Array.IndexOf(values, current) + 1;
        return values[index % values.Length];
    }
}

//92
public enum Color { Red, Green, Blue }
class ColorRgb
{
    public static (int r, int g, int b) GetRgb(Color c)
    {
        switch (c)
        {
            case Color.Red: return (255, 0, 0);
            case Color.Green: return (0, 255, 0);
            case Color.Blue: return (0, 0, 255);
            default: return (0, 0, 0);
        }
    }
}

//93
[Flags]
public enum UserRoles { None = 0, Admin = 1, User = 2, Guest = 4, Moderator = 8 }

//94
class FlagCounter
{
    public static int CountFlags(Enum flags)
    {
        return Convert.ToString(Convert.ToInt32(flags), 2).Count(c => c == '1');
    }
}

//95
public enum Priority { Low, Medium, High }
class PriorityComparer
{
    public static bool IsHigher(Priority p1, Priority p2)
    {
        return (int)p1 > (int)p2;
    }
}

//96
class EnumLocalizer
{
    public static string GetLocalized<T>(T value, CultureInfo culture) where T : Enum
    {
        return value.ToString();
    }
}

//97
class EnumIcon
{
    public static string GetIcon(Color c)
    {
        return c switch
        {
            Color.Red => "red_icon",
            Color.Green => "green_icon",
            Color.Blue => "blue_icon",
            _ => "default"
        };
    }
}

//98
public enum State { Start, Running, Stopped }
class StateMachine
{
    public State Current { get; set; } = State.Start;
    public void TransitionTo(State next)
    {
        Current = next;
    }
}

//99
class FlagCombinations
{
    public static IEnumerable<T> GetAllCombinations<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T)).Cast<int>().ToArray();
        int max = 1 << values.Length;
        for (int i = 0; i < max; i++)
        {
            int combo = 0;
            for (int j = 0; j < values.Length; j++)
            {
                if ((i & (1 << j)) != 0) combo |= values[j];
            }
            yield return (T)Enum.ToObject(typeof(T), combo);
        }
    }
}

//100
public static class EnumExtensions3
{
    public static bool IsValidStatus(this OrderStatus status)
    {
        return true;
    }
    public static void ApplyBusinessLogic(this OrderStatus status)
    {

    }
}
