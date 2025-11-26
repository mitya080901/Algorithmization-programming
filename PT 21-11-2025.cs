//1
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Привет из потока");
        });
        thread.Start();
        thread.Join();
    }
}

//2
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(() => Console.WriteLine("Поток 1 работает"));
        Thread thread2 = new Thread(() => Console.WriteLine("Поток 2 работает"));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершили работу");
    }
}

//3
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine($"ID текущего потока: {Thread.CurrentThread.ManagedThreadId}");
    }
}

//4
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            Console.WriteLine("Операция 1 начата");
            Thread.Sleep(3000);
            Console.WriteLine("Операция 1 завершена");
        });

        Thread t2 = new Thread(() =>
        {
            Console.WriteLine("Операция 2 начата");
            Thread.Sleep(1000);
            Console.WriteLine("Операция 2 завершена");
        });

        Thread t3 = new Thread(() =>
        {
            Console.WriteLine("Операция 3 начата");
            Thread.Sleep(2000);
            Console.WriteLine("Операция 3 завершена");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Все операции завершены");
    }
}

//5
using System;
using System.Threading;

class Program
{
    static void PrintMessage(object message)
    {
        Console.WriteLine($"Сообщение из потока: {message}");
    }

    static void Main()
    {
        ParameterizedThreadStart parameterized = new ParameterizedThreadStart(PrintMessage);
        Thread thread = new Thread(parameterized);
        thread.Start("Привет с параметром!");
        thread.Join();
    }
}

//6
using System;
using System.Threading;

class Program
{
    static void Worker()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.Write(Thread.CurrentThread.ManagedThreadId + " ");
            Thread.Sleep(10);
        }
    }

    static void Main()
    {
        Thread high = new Thread(Worker);
        Thread low = new Thread(Worker);

        high.Priority = ThreadPriority.Highest;
        low.Priority = ThreadPriority.Lowest;

        high.Start();
        low.Start();

        high.Join();
        low.Join();
    }
}

//7
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Поток начал работу");
            Thread.Sleep(5000);
            Console.WriteLine("Поток проснулся и завершился");
        });

        thread.Start();
        thread.Join();
        Console.WriteLine("Главный поток завершён");
    }
}

//8
using System;
using System.Threading;

class Program
{
    static void BackgroundWork()
    {
        Console.WriteLine("Фоновый поток работает...");
        Thread.Sleep(3000);
        Console.WriteLine("Фоновый поток завершён");
    }

    static void Main()
    {
        Thread backgroundThread = new Thread(BackgroundWork);
        backgroundThread.IsBackground = true;
        backgroundThread.Start();

        Console.WriteLine("Главный поток завершился (фоновый может не успеть)");
        Thread.Sleep(1000);
    }
}

//9
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.Name = "Основной поток";
        Console.WriteLine($"Имя текущего потока: {Thread.CurrentThread.Name}");

        Thread worker = new Thread(() =>
        {
            Thread.CurrentThread.Name = "Рабочий поток";
            Console.WriteLine($"Имя потока: {Thread.CurrentThread.Name}");
        });
        worker.Start();
        worker.Join();
    }
}

//10
using System;
using System.Threading;

class Program
{
    static readonly object lockObject = new object();

    static void PrintNumbers(int threadId)
    {
        lock (lockObject)
        {
            Console.WriteLine($"Поток {threadId} начал вывод:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Поток {threadId}: {i * 10}");
                Thread.Sleep(200);
            }
            Console.WriteLine($"Поток {threadId} завершил вывод");
        }
    }

    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            int id = i;
            new Thread(() => PrintNumbers(id)).Start();
        }

        Thread.Sleep(5000);
    }
}

//11
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            Console.WriteLine("Задача выполняется в пуле потоков");
            Thread.Sleep(1000);
            Console.WriteLine("Задача завершена");
        });

        task.Wait();
    }
}

//12
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Шаг {i + 1}");
                Task.Delay(500).Wait();
            }
        });

        Console.WriteLine("Ожидание завершения задачи...");
        task.Wait();
        Console.WriteLine("Задача завершена");
    }
}

//13
using System;
using System.Threading.Tasks;

class Program
{
    static Task<int> CalculateSumAsync()
    {
        return Task.Run(() =>
        {
            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
                sum += i;
            return sum;
        });
    }

    static void Main()
    {
        Task<int> task = CalculateSumAsync();
        Console.WriteLine("Задача запущена...");
        int result = task.Result;
        Console.WriteLine($"Сумма = {result}");
    }
}

//14
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t1 = Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("Задача 1 завершена"); });
        Task t2 = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("Задача 2 завершена"); });
        Task t3 = Task.Run(() => { Thread.Sleep(3000); Console.WriteLine("Задача 3 завершена"); });

        Console.WriteLine("Ожидание всех задач...");
        Task.WaitAll(t1, t2, t3);
        Console.WriteLine("Все задачи завершены");
    }
}

//15
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<int> task1 = Task.Delay(2000).ContinueWith(_ => 10);
        Task<int> task2 = Task.Delay(1000).ContinueWith(_ => 20);
        Task<int> task3 = Task.Delay(3000).ContinueWith(_ => 30);

        int[] results = await Task.WhenAll(task1, task2, task3);
        Console.WriteLine($"Результаты: {results[0]}, {results[1]}, {results[2]}");
        Console.WriteLine("Все задачи завершены асинхронно");
    }
}

//16
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task.Run(() =>
        {
            Console.WriteLine("Этап 1: Начало работы");
            Thread.Sleep(1000);
        })
        .ContinueWith(prev =>
        {
            Console.WriteLine("Этап 2: После первой задачи");
            Thread.Sleep(500);
        })
        .ContinueWith(prev =>
        {
            Console.WriteLine("Этап 3: Завершение цепочки");
        })
        .Wait();
    }
}

//17
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t1 = Task.Delay(3000).ContinueWith(_ => Console.WriteLine("Задача 1"));
        Task t2 = Task.Delay(1000).ContinueWith(_ => Console.WriteLine("Задача 2"));
        Task t3 = Task.Delay(5000).ContinueWith(_ => Console.WriteLine("Задача 3"));

        int index = Task.WaitAny(t1, t2, t3);
        Console.WriteLine($"Первая завершившаяся задача — номер {index}");
    }
}

//18
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<int> Fast() => await Task.Delay(1000).ContinueWith(_ => 42);
        Task<int> Medium() => await Task.Delay(2000).ContinueWith(_ => 100);
        Task<int> Slow() => await Task.Delay(5000).ContinueWith(_ => 999);

        Task<int> winner = await Task.WhenAny(Fast(), Medium(), Slow());
        Console.WriteLine($"Первая завершилась с результатом: {await winner}");
    }
}

//19
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            Thread.Sleep(1000);
            throw new InvalidOperationException("Что-то пошло не так!");
        });

        try
        {
            task.Wait();
        }
        catch (AggregateException ae)
        {
            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine($"Обработано исключение: {ex.Message}");
            }
        }
    }
}

//20
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var customScheduler = new LimitedConcurrencyLevelTaskScheduler(2);

        Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Задача 1 на потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }, CancellationToken.None, TaskCreationOptions.None, customScheduler);

        Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Задача 2 на потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }, CancellationToken.None, TaskCreationOptions.None, customScheduler);

        Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Задача 3 на потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }, CancellationToken.None, TaskCreationOptions.None, customScheduler);

        Console.WriteLine("Все задачи поставлены в очередь с ограничением в 2 потока");
        Thread.Sleep(4000);
    }
}

public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
{
    private readonly LinkedList<Task> _tasks = new LinkedList<Task>();
    private readonly int _maxDegreeOfParallelism;
    private int _runningTasks = 0;

    public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
    {
        _maxDegreeOfParallelism = maxDegreeOfParallelism > 0 ? maxDegreeOfParallelism : throw new ArgumentOutOfRangeException();
    }

    protected override void QueueTask(Task task)
    {
        lock (_tasks)
        {
            _tasks.AddLast(task);
            if (_runningTasks < _maxDegreeOfParallelism)
            {
                _runningTasks++;
                ThreadPool.UnsafeQueueUserWorkItem(RunNextTask, null);
            }
        }
    }

    private void RunNextTask(object state)
    {
        Task task;
        lock (_tasks)
        {
            if (_tasks.Count == 0)
            {
                _runningTasks--;
                return;
            }
            task = _tasks.First.Value;
            _tasks.RemoveFirst();
        }

        TryExecuteTask(task);

        lock (_tasks)
        {
            if (_tasks.Count > 0)
                ThreadPool.UnsafeQueueUserWorkItem(RunNextTask, null);
            else
                _runningTasks--;
        }
    }

    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) => false;
    protected override IEnumerable<Task> GetScheduledTasks() => _tasks;
    public override int MaximumConcurrencyLevel => _maxDegreeOfParallelism;
}
//21
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DoWorkAsync();
        Console.WriteLine("Работа завершена");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Начало асинхронной работы");
        await Task.Delay(2000);
        Console.WriteLine("Асинхронная работа выполнена");
    }
}

//22
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Запуск операции...");
        await LongRunningOperationAsync();
        Console.WriteLine("Операция завершена, продолжаем");
    }

    static async Task LongRunningOperationAsync()
    {
        await Task.Delay(3000);
        Console.WriteLine("Долгая операция выполнена");
    }
}

//23
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int result = await CalculateAsync(10, 20);
        Console.WriteLine($"Результат: {result}");
    }

    static async Task<int> CalculateAsync(int a, int b)
    {
        await Task.Delay(1000);
        return a * b + 100;
    }
}

//24
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Начало");
        await Task.Delay(5000);
        Console.WriteLine("Прошло 5 секунд асинхронно");
    }
}

//25
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            await FailingOperationAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static async Task FailingOperationAsync()
    {
        await Task.Delay(1000);
        throw new InvalidOperationException("Что-то пошло не так!");
    }
}

//26
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await LibraryMethodAsync().ConfigureAwait(false);
        Console.WriteLine("Продолжение без захвата контекста");
    }

    static async Task LibraryMethodAsync()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        Console.WriteLine("Выполняется в библиотеке");
    }
}

//27
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Этап 1");
        await Step1Async();
        Console.WriteLine("Этап 2");
        await Step2Async();
        Console.WriteLine("Этап 3");
        await Step3Async();
        Console.WriteLine("Цепочка завершена");
    }

    static async Task Step1Async() { await Task.Delay(1000); Console.WriteLine("Шаг 1 завершён"); }
    static async Task Step2Async() { await Task.Delay(800); Console.WriteLine("Шаг 2 завершён"); }
    static async Task Step3Async() { await Task.Delay(1200); Console.WriteLine("Шаг 3 завершён"); }
}

//28
using System;
using System.Windows.Forms;

public class Form1 : Form
{
    private Button button1;

    public Form1()
    {
        button1 = new Button { Text = "Нажми меня" };
        button1.Click += Button1_Click;
        Controls.Add(button1);
    }

    private async void Button1_Click(object sender, EventArgs e)
    {
        button1.Enabled = false;
        await Task.Delay(3000);
        MessageBox.Show("Операция завершена!");
        button1.Enabled = true;
    }
}

class Program
{
    static void Main() { Application.Run(new Form1()); }
}

//29
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string content = await ReadFileAsync("data.txt");
        Console.WriteLine(content);
    }

    static async Task<string> ReadFileAsync(string path)
    {
        using var reader = new StreamReader(path);
        return await reader.ReadToEndAsync();
    }
}

//30
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        int result = await GetCachedValueAsync();
        Console.WriteLine($"Кэшированное значение: {result}");
    }

    static Task<int> GetCachedValueAsync()
    {
        return Task.FromResult(42);
    }
}

//31
using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object lockObj = new object();

    static void Increment()
    {
        for (int i = 0; i < 100000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(Increment);
            threads[i].Start();
        }

        foreach (var t in threads) t.Join();
        Console.WriteLine($"Итоговое значение: {counter}");
    }
}

//32
using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object locker = new object();

    static void Worker()
    {
        for (int i = 0; i < 50000; i++)
        {
            lock (locker)
            {
                int temp = counter;
                temp++;
                counter = temp;
            }
        }
    }

    static void Main()
    {
        var t1 = new Thread(Worker);
        var t2 = new Thread(Worker);
        t1.Start(); t2.Start();
        t1.Join(); t2.Join();
        Console.WriteLine($"Счётчик: {counter}");
    }
}

//33
using System;
using System.Threading;

class Program
{
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    static void Thread1()
    {
        lock (lock1)
        {
            Console.WriteLine("Thread1 захватил lock1");
            Thread.Sleep(500);
            Console.WriteLine("Thread1 ждёт lock2...");
            lock (lock2)
            {
                Console.WriteLine("Thread1 захватил lock2");
            }
        }
    }

    static void Thread2()
    {
        lock (lock2)
        {
            Console.WriteLine("Thread2 захватил lock2");
            Thread.Sleep(500);
            Console.WriteLine("Thread2 ждёт lock1...");
            lock (lock1)
            {
                Console.WriteLine("Thread2 захватил lock1");
            }
        }
    }

    static void Main()
    {
        new Thread(Thread1).Start();
        new Thread(Thread2).Start();
        Console.ReadLine();
    }
}

//34
using System;
using System.Threading;

class Program
{
    static readonly object lockA = new object();
    static readonly object lockB = new object();

    static void SafeMethod1()
    {
        lock (lockA)
        {
            Thread.Sleep(100);
            lock (lockB)
            {
                Console.WriteLine("Метод 1 выполняется безопасно");
            }
        }
    }

    static void SafeMethod2()
    {
        lock (lockA)
        {
            Thread.Sleep(100);
            lock (lockB)
            {
                Console.WriteLine("Метод 2 выполняется безопасно");
            }
        }
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            new Thread(SafeMethod1).Start();
            new Thread(SafeMethod2).Start();
        }
        Console.ReadLine();
    }
}

//35
using System;
using System.Threading;

class Program
{
    static int counter1 = 0;
    static int counter2 = 0;
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    static void Increment1() { lock (lock1) counter1++; }
    static void Increment2() { lock (lock2) counter2++; }

    static void Main()
    {
        Thread[] threads = new Thread[20];
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
                threads[i] = new Thread(() => { for (int j = 0; j < 10000; j++) Increment1(); });
            else
                threads[i] = new Thread(() => { for (int j = 0; j < 10000; j++) Increment2(); });
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        Console.WriteLine($"Counter1: {counter1}, Counter2: {counter2}");
    }
}

//36
using System;
using System.Threading;

public class ThreadSafeCounter
{
    private int _value = 0;
    private readonly object _lock = new object();

    public void Increment()
    {
        lock (_lock)
        {
            _value++;
        }
    }

    public void Decrement()
    {
        lock (_lock)
        {
            _value--;
        }
    }

    public int Value
    {
        get
        {
            lock (_lock)
            {
                return _value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var counter = new ThreadSafeCounter();
        Thread[] threads = new Thread[10];

        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 10000; j++)
                {
                    counter.Increment();
                    counter.Decrement();
                }
            });
            threads[i].Start();
        }

        foreach (var t in threads) t.Join();
        Console.WriteLine($"Финальное значение: {counter.Value}");
    }
}

//37
using System;
using System.Threading;

class Program
{
    static readonly ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();
    static int sharedData = 0;

    static void Reader()
    {
        for (int i = 0; i < 100; i++)
        {
            rwLock.EnterReadLock();
            try
            {
                Console.WriteLine($"Читатель видит: {sharedData}");
            }
            finally
            {
                rwLock.ExitReadLock();
            }
            Thread.Sleep(10);
        }
    }

    static void Writer()
    {
        for (int i = 0; i < 20; i++)
        {
            rwLock.EnterWriteLock();
            try
            {
                sharedData++;
                Console.WriteLine($"Писатель записал: {sharedData}");
            }
            finally
            {
                rwLock.ExitWriteLock();
            }
            Thread.Sleep(200);
        }
    }

    static void Main()
    {
        Thread writer = new Thread(Writer);
        Thread[] readers = new Thread[5];

        writer.Start();
        for (int i = 0; i < 5; i++)
        {
            readers[i] = new Thread(Reader);
            readers[i].Start();
        }

        writer.Join();
        foreach (var r in readers) r.Join();
    }
}

//38
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object lockObj = new object();
    static readonly ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();

    static void WithLock() { lock (lockObj) { counter++; } }
    static void WithRWLock() { rwLock.EnterWriteLock(); counter++; rwLock.ExitWriteLock(); }

    static void Benchmark(Action action, string name)
    {
        counter = 0;
        var sw = Stopwatch.StartNew();
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100000; j++) action();
            });
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Benchmark(WithLock, "lock");
        Benchmark(WithRWLock, "ReaderWriterLockSlim");
    }
}

//39
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static List<int> sharedList = new List<int>();
    static readonly object listLock = new object();

    static void AddItems()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (listLock)
            {
                sharedList.Add(i);
            }
        }
    }

    static void ReadItems()
    {
        lock (listLock)
        {
            Console.WriteLine($"Элементов в списке: {sharedList.Count}");
        }
    }

    static void Main()
    {
        Thread[] writers = new Thread[5];
        Thread reader = new Thread(() =>
        {
            while (true)
            {
                ReadItems();
                Thread.Sleep(500);
            }
        });

        reader.Start();
        for (int i = 0; i < 5; i++)
        {
            writers[i] = new Thread(AddItems);
            writers[i].Start();
        }

        Thread.Sleep(3000);
        reader.Abort();
    }
}

//40
using System;
using System.Threading;

class Program
{
    static int data = 0;
    static readonly object readerLock = new object();
    static readonly object writerLock = new object();
    static int readingCount = 0;

    static void Reader()
    {
        lock (readerLock)
        {
            readingCount++;
            if (readingCount == 1)
                Monitor.Enter(writerLock);
        }

        Console.WriteLine($"Читатель видит: {data}");
        Thread.Sleep(100);

        lock (readerLock)
        {
            readingCount--;
            if (readingCount == 0)
                Monitor.Exit(writerLock);
        }
    }

    static void Writer()
    {
        Monitor.Enter(writerLock);
        try
        {
            data++;
            Console.WriteLine($"Писатель записал: {data}");
            Thread.Sleep(200);
        }
        finally
        {
            Monitor.Exit(writerLock);
        }
    }

    static void Main()
    {
        Thread[] readers = new Thread[10];
        Thread writer = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Writer();
                Thread.Sleep(500);
            }
        });

        writer.Start();
        for (int i = 0; i < 10; i++)
        {
            readers[i] = new Thread(() =>
            {
                for (int j = 0; j < 20; j++)
                {
                    Reader();
                    Thread.Sleep(50);
                }
            });
            readers[i].Start();
        }
    }
}

//41
using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();

    static void Worker(int id)
    {
        Console.WriteLine($"Поток {id} ждёт мьютекс...");
        mutex.WaitOne();
        try
        {
            Console.WriteLine($"Поток {id} вошёл в критическую секцию");
            Thread.Sleep(2000);
        }
        finally
        {
            mutex.ReleaseMutex();
            Console.WriteLine($"Поток {id} вышел из секции");
        }
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            new Thread(() => Worker(id)).Start();
        }
        Console.ReadLine();
    }
}

//42
using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();

    static void CriticalSection(int id)
    {
        if (mutex.WaitOne(1000))
        {
            try
            {
                Console.WriteLine($"Поток {id} в критической секции");
                Thread.Sleep(3000);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
        else
        {
            Console.WriteLine($"Поток {id} не смог захватить мьютекс");
        }
    }

    static void Main()
    {
        Thread[] threads = new Thread[6];
        for (int i = 0; i < 6; i++)
        {
            int id = i;
            threads[i] = new Thread(() => CriticalSection(id));
            threads[i].Start();
        }
        Console.ReadLine();
    }
}

//43
using System;
using System.Threading;

class Program
{
    static Semaphore semaphore = new Semaphore(3, 3);

    static void AccessResource(int id)
    {
        Console.WriteLine($"Поток {id} ждёт доступа...");
        semaphore.WaitOne();
        try
        {
            Console.WriteLine($"Поток {id} получил доступ");
            Thread.Sleep(2000);
        }
        finally
        {
            Console.WriteLine($"Поток {id} освобождает ресурс");
            semaphore.Release();
        }
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            int id = i;
            new Thread(() => AccessResource(id)).Start();
        }
        Console.ReadLine();
    }
}

//44
using System;
using System.Threading;

class ResourcePool
{
    private readonly Semaphore _pool;

    public ResourcePool(int size)
    {
        _pool = new Semaphore(size, size);
    }

    public void UseResource(int workerId)
    {
        _pool.WaitOne();
        try
        {
            Console.WriteLine($"Рабочий {workerId} использует ресурс");
            Thread.Sleep(3000);
        }
        finally
        {
            Console.WriteLine($"Рабочий {workerId} освободил ресурс");
            _pool.Release();
        }
    }
}

class Program
{
    static void Main()
    {
        var pool = new ResourcePool(4);

        for (int i = 0; i < 15; i++)
        {
            int id = i;
            new Thread(() => pool.UseResource(id)).Start();
        }
        Console.ReadLine();
    }
}

//45
using System;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim semaphore = new SemaphoreSlim(2, 2);

    static async Task AccessAsync(int id)
    {
        Console.WriteLine($"Задача {id} ждёт...");
        await semaphore.WaitAsync();
        try
        {
            Console.WriteLine($"Задача {id} работает");
            await Task.Delay(2000);
        }
        finally
        {
            Console.WriteLine($"Задача {id} завершила");
            semaphore.Release();
        }
    }

    static async Task Main()
    {
        var tasks = new Task[10];
        for (int i = 0; i < 10; i++)
        {
            int id = i;
            tasks[i] = AccessAsync(id);
        }
        await Task.WhenAll(tasks);
    }
}

//46
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Mutex mutex = new Mutex();
        Thread thread = new Thread(() =>
        {
            mutex.WaitOne();
            Console.WriteLine("Поток захватил мьютекс и завершается без Release");
        });

        thread.Start();
        thread.Join();

        try
        {
            mutex.WaitOne();
            Console.WriteLine("Главный поток захватил мьютекс");
            mutex.ReleaseMutex();
        }
        catch (AbandonedMutexException)
        {
            Console.WriteLine("Обнаружен брошенный мьютекс!");
            mutex.ReleaseMutex();
        }
    }
}

//47
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool createdNew;
        using var mutex = new Mutex(true, "Global\\MyAppMutex", out createdNew);

        if (!createdNew)
        {
            Console.WriteLine("Приложение уже запущено!");
            return;
        }

        Console.WriteLine("Приложение запущено. Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}

//48
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object lockObj = new object();
    static Mutex mutex = new Mutex();

    static void WithLock() { lock (lockObj) counter++; }
    static void WithMutex() { mutex.WaitOne(); counter++; mutex.ReleaseMutex(); }

    static void Benchmark(Action action, string name)
    {
        counter = 0;
        var sw = Stopwatch.StartNew();
        var t1 = new Thread(() => { for (int i = 0; i < 1000000; i++) action(); });
        var t2 = new Thread(() => { for (int i = 0; i < 1000000; i++) action(); });
        t1.Start(); t2.Start();
        t1.Join(); t2.Join();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Benchmark(WithLock, "lock");
        Benchmark(WithMutex, "Mutex");
    }
}

//49
using System;
using System.Threading;

class Program
{
    static CountdownEvent countdown = new CountdownEvent(5);

    static void Worker(int id)
    {
        Console.WriteLine($"Рабочий {id} начал");
        Thread.Sleep(1000 + id * 300);
        Console.WriteLine($"Рабочий {id} завершил");
        countdown.Signal();
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            new Thread(() => Worker(id)).Start();
        }

        Console.WriteLine("Ожидание всех рабочих...");
        countdown.Wait();
        Console.WriteLine("Все рабочие завершили работу!");
    }
}

//50
using System;
using System.Threading;

class Program
{
    static ManualResetEvent mre = new ManualResetEvent(false);

    static void Worker()
    {
        Console.WriteLine("Рабочий ждёт сигнала...");
        mre.WaitOne();
        Console.WriteLine("Сигнал получен! Рабочий продолжает");
    }

    static void Main()
    {
        new Thread(Worker).Start();
        new Thread(Worker).Start();

        Thread.Sleep(3000);
        Console.WriteLine("Отправка сигнала...");
        mre.Set();

        Console.ReadLine();
    }
}

//51
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = LongOperationAsync(cts.Token);

        Console.WriteLine("Нажмите любую клавишу для отмены...");
        Console.ReadKey();
        cts.Cancel();

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция была отменена");
        }
    }

    static async Task LongOperationAsync(CancellationToken token)
    {
        for (int i = 0; i < 100; i++)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(100);
            Console.WriteLine($"Прогресс: {i + 1}%");
        }
    }
}

//52
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        try
        {
            await DoWorkAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Работа отменена по таймауту");
        }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        while (true)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine("Работаю...");
            await Task.Delay(1000, token);
        }
    }
}

//53
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = ProcessWithCancellation(cts.Token);

        await Task.Delay(2000);
        cts.Cancel();

        try { await task; }
        catch (OperationCanceledException) { Console.WriteLine("Отменено"); }
    }

    static async Task ProcessWithCancellation(CancellationToken token)
    {
        for (int i = 0; i < 100; i++)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(100);
        }
    }
}

//54
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var cts = new CancellationTokenSource(3000);
        try
        {
            await LongTaskAsync(cts.Token);
            Console.WriteLine("Задача завершена успешно");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Задача отменена по таймауту");
        }
    }

    static async Task LongTaskAsync(CancellationToken token)
    {
        await Task.Delay(10000, token);
    }
}

//55
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = RunWithCancellation(cts.Token);

        await Task.Delay(1500);
        cts.Cancel();

        try
        {
            await task;
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine($"Операция отменена: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static async Task RunWithCancellation(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(500);
            Console.WriteLine($"Шаг {i + 1}");
        }
    }
}

//56
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var cts = new CancellationTokenSource();

        cts.Token.Register(() =>
        {
            Console.WriteLine("Выполняется очистка ресурсов...");
        });

        Console.WriteLine("Нажмите любую клавишу для отмены");
        Console.ReadKey();
        cts.Cancel();

        await Task.Delay(1000);
    }
}

//57
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var cts = new CancellationTokenSource();

        var task = Task.Delay(10000, cts.Token)
            .ContinueWith(t => Console.WriteLine("Задержка завершена"), TaskContinuationOptions.OnlyOnRanToCompletion);

        await Task.Delay(3000);
        cts.Cancel();
        Console.WriteLine("Отмена отправлена");

        try { await task; }
        catch (OperationCanceledException) { Console.WriteLine("Delay был отменён"); }
    }
}

//58
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static CancellationTokenSource cts = new CancellationTokenSource();

    static async Task Main()
    {
        Console.CancelKeyPress += (s, e) =>
        {
            e.Cancel = true;
            Console.WriteLine("\nПолучен сигнал завершения...");
            cts.Cancel();
        };

        var worker = BackgroundWorker(cts.Token);

        Console.WriteLine("Приложение работает. Нажмите Ctrl+C для graceful shutdown");
        await worker;
        Console.WriteLine("Приложение завершено чисто");
    }

    static async Task BackgroundWorker(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            Console.WriteLine($"Фоновая работа... {DateTime.Now}");
            try
            {
                await Task.Delay(1000, token);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Фоновая работа остановлена");
                break;
            }
        }

        Console.WriteLine("Очистка ресурсов...");
        await Task.Delay(2000, CancellationToken.None);
        Console.WriteLine("Очистка завершена");
    }
}
//59
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.QueueUserWorkItem(state =>
        {
            Console.WriteLine($"Работа в ThreadPool, поток: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine("Работа завершена");
        });

        Console.WriteLine("Работа отправлена в ThreadPool");
        Thread.Sleep(3000);
    }
}

//60
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.GetMaxThreads(out int maxWorker, out int maxIOC);
        ThreadPool.GetAvailableThreads(out int availWorker, out int availIOC);
        ThreadPool.GetMinThreads(out int minWorker, out int minIOC);

        Console.WriteLine($"Макс. рабочих потоков: {maxWorker}, I/O: {maxIOC}");
        Console.WriteLine($"Доступно рабочих: {availWorker}, I/O: {availIOC}");
        Console.WriteLine($"Мин. рабочих потоков: {minWorker}, I/O: {minIOC}");
    }
}

//61
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        ThreadPool.SetMinThreads(8, 4);
        ThreadPool.SetMaxThreads(32, 16);

        for (int i = 0; i < 50; i++)
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            });
        }

        Thread.Sleep(5000);
    }
}

//62
using System;
using System.Threading;

class Program
{
    static AutoResetEvent handle = new AutoResetEvent(false);

    static void Main()
    {
        RegisteredWaitHandle reg = ThreadPool.RegisterWaitForSingleObject(
            handle,
            (state, timedOut) =>
            {
                if (!timedOut)
                    Console.WriteLine("Событие сработало!");
                else
                    Console.WriteLine("Таймаут ожидания");
            },
            null,
            5000,
            true);

        Console.WriteLine("Ожидание сигнала...");
        Thread.Sleep(7000);
        handle.Set();

        Thread.Sleep(1000);
    }
}

//63
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Benchmark(Action action, string name)
    {
        var sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Benchmark(() =>
        {
            for (int i = 0; i < 100; i++)
                ThreadPool.QueueUserWorkItem(_ => Thread.Sleep(10));
            Thread.Sleep(3000);
        }, "ThreadPool");

        Benchmark(() =>
        {
            var tasks = new Task[100];
            for (int i = 0; i < 100; i++)
                tasks[i] = Task.Run(() => Thread.Sleep(10));
            Task.WaitAll(tasks);
        }, "Task.Run");
    }
}

//64
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            ThreadPool.GetAvailableThreads(out int w, out int c);
            Console.WriteLine($"Доступно рабочих потоков: {w}, I/O: {c}");
            ThreadPool.QueueUserWorkItem(_ => Thread.Sleep(1000));
            Thread.Sleep(200);
        }
    }
}

//65
using System;
using System.Collections.Concurrent;
using System.Threading;

public class SimpleThreadPool
{
    private readonly ConcurrentQueue<Action> _queue = new ConcurrentQueue<Action>();
    private readonly Thread[] _workers;
    private readonly ManualResetEvent _hasWork = new ManualResetEvent(false);
    private volatile bool _stopping = false;

    public SimpleThreadPool(int count)
    {
        _workers = new Thread[count];
        for (int i = 0; i < count; i++)
        {
            _workers[i] = new Thread(WorkerLoop) { IsBackground = true };
            _workers[i].Start();
        }
    }

    public void QueueWork(Action work)
    {
        _queue.Enqueue(work);
        _hasWork.Set();
    }

    public void Shutdown()
    {
        _stopping = true;
        _hasWork.Set();
        foreach (var t in _workers) t.Join();
    }

    private void WorkerLoop()
    {
        while (true)
        {
            _hasWork.WaitOne();
            if (_stopping) break;
            if (_queue.TryDequeue(out Action work))
            {
                work();
            }
            else
            {
                _hasWork.Reset();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var pool = new SimpleThreadPool(4);
        for (int i = 0; i < 20; i++)
        {
            int id = i;
            pool.QueueWork(() => Console.WriteLine($"Задача {id} на потоке {Thread.CurrentThread.ManagedThreadId}"));
        }
        Thread.Sleep(3000);
        pool.Shutdown();
    }
}

//66
using System;
using System.IO;
using System.Threading;

class Program
{
    static unsafe void Main()
    {
        using var file = File.Open("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        byte[] buffer = new byte[4096];
        var handle = file.SafeFileHandle;

        ThreadPool.BindHandle(handle);
        ThreadPool.QueueUserWorkItem(state =>
        {
            Console.WriteLine("Асинхронное чтение через IOCP");
        });

        Console.WriteLine("IOCP привязан");
        Thread.Sleep(1000);
    }
}

//67
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(0, 20, i =>
        {
            Console.WriteLine($"Индекс {i} на потоке {Task.CurrentId}");
            Task.Delay(100).Wait();
        });
        Console.WriteLine("Parallel.For завершён");
    }
}

//68
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 100).ToList();

        Parallel.ForEach(numbers, num =>
        {
            Console.WriteLine($"Обработка {num} на потоке {Task.CurrentId}");
            Task.Delay(50).Wait();
        });

        Console.WriteLine("Parallel.ForEach завершён");
    }
}

//69
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.Invoke(
            () => { Console.WriteLine("Действие 1"); Task.Delay(1000).Wait(); },
            () => { Console.WriteLine("Действие 2"); Task.Delay(1500).Wait(); },
            () => { Console.WriteLine("Действие 3"); Task.Delay(800).Wait(); }
        );

        Console.WriteLine("Все действия выполнены");
    }
}

//70
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

        Parallel.For(0, 20, options, i =>
        {
            Console.WriteLine($"Задача {i} на потоке {Task.CurrentId}");
            Task.Delay(500).Wait();
        });
    }
}

//71
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        using var cts = new CancellationTokenSource(2000);

        try
        {
            Parallel.For(0, 1000000, new ParallelOptions { CancellationToken = cts.Token }, i =>
            {
                if (i % 10000 == 0) Thread.SpinWait(100000);
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Параллельная операция отменена");
        }
    }
}

//72
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var data = Enumerable.Range(0, 1000000).ToArray();
        var partitioner = Partitioner.Create(data, true);

        Parallel.ForEach(partitioner, item =>
        {
            // имитация работы
            Thread.SpinWait(1000);
        });

        Console.WriteLine("Оптимизированный Parallel.ForEach завершён");
    }
}

//73
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        using var cts = new CancellationTokenSource();

        var task = Task.Run(() =>
        {
            try
            {
                Parallel.For(0, 1000, new ParallelOptions { CancellationToken = cts.Token }, i =>
                {
                    Thread.Sleep(10);
                });
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция корректно отменена");
            }
        });

        Thread.Sleep(100);
        cts.Cancel();
        task.Wait();
    }
}

//74
using System;
using System.Threading.Tasks;

class Program
{
    static long FibonacciParallel(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 0;
        Parallel.Invoke(
            () => a = FibonacciParallel(n - 1),
            () => b = FibonacciParallel(n - 2)
        );
        return a + b;
    }

    static void Main()
    {
        var result = FibonacciParallel(30);
        Console.WriteLine($"Fib(30) = {result}");
    }
}

//75
using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Benchmark(Action action, string name)
    {
        var sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        var data = new int[100000000];

        Benchmark(() =>
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = i * i;
        }, "Обычный цикл");

        Benchmark(() =>
        {
            Parallel.For(0, data.Length, i => data[i] = i * i);
        }, "Parallel.For");
    }
}

//76
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 4,
            CancellationToken = CancellationToken.None
        };

        Parallel.For(0, 50, options, i =>
        {
            Console.WriteLine($"Работа {i} на потоке {Task.CurrentId}");
            Thread.Sleep(100);
        });
    }
}

//77
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10000000);

        var result = numbers.AsParallel()
                           .Where(x => x % 3 == 0)
                           .Select(x => x * x)
                           .Take(100);

        Console.WriteLine($"Найдено: {result.Count()}");
    }
}

//78
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var result = Enumerable.Range(1, 5000000)
            .AsParallel()
            .WithDegreeOfParallelism(2)
            .Where(x => x % 1000 == 0)
            .Sum();

        Console.WriteLine($"Сумма: {result}");
    }
}

//79
using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        using var cts = new CancellationTokenSource(100);

        try
        {
            var result = Enumerable.Range(1, 100000000)
                .AsParallel()
                .WithCancellation(cts.Token)
                .Where(x => x % 100000 == 0)
                .Sum();

            Console.WriteLine(result);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("PLINQ запрос отменён");
        }
    }
}

//80
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var result = ParallelEnumerable.Range(0, 1000000)
            .Where(x => x % 1000 == 0)
            .Select(x => x * 2)
            .ToArray();

        Console.WriteLine($"Результатов: {result.Length}");
    }
}

//81
using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        var data = Enumerable.Range(1, 20000000).ToArray();

        var sw = Stopwatch.StartNew();
        var linqResult = data.Where(x => x % 100 == 0).Sum();
        sw.Stop();
        Console.WriteLine($"LINQ: {sw.ElapsedMilliseconds} мс");

        sw.Restart();
        var plinqResult = data.AsParallel().Where(x => x % 100 == 0).Sum();
        sw.Stop();
        Console.WriteLine($"PLINQ: {sw.ElapsedMilliseconds} мс");
    }
}

//82
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var list = Enumerable.Range(1, 1000000)
            .AsParallel()
            .Where(x => x % 1000 == 0)
            .Select(x => x * x)
            .ToList();

        Console.WriteLine($"Элементов в списке: {list.Count}");
    }
}

//83
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var dict = new ConcurrentDictionary<int, string>();

        Parallel.For(0, 1000, i =>
        {
            dict.TryAdd(i, $"Value{i}");
        });

        Console.WriteLine($"Элементов: {dict.Count}");
    }
}

//84
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var queue = new ConcurrentQueue<int>();

        Task producer = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                queue.Enqueue(i);
                Thread.Sleep(10);
            }
        });

        Task consumer = Task.Run(() =>
        {
            while (!queue.IsEmpty || producer.Status != TaskStatus.RanToCompletion)
            {
                if (queue.TryDequeue(out int value))
                    Console.WriteLine($"Получено: {value}");
                else
                    Thread.Sleep(50);
            }
        });

        await Task.WhenAll(producer, consumer);
    }
}

//85
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var bag = new ConcurrentBag<int>();

        Parallel.For(0, 1000, i =>
        {
            bag.Add(i * 2);
        });

        Console.WriteLine($"В мешке: {bag.Count} элементов");
    }
}

//86
using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        var collection = new BlockingCollection<int>(boundedCapacity: 10);

        var producer = Task.Run(() =>
        {
            for (int i = 0; i < 50; i++)
            {
                collection.Add(i);
                Console.WriteLine($"Добавлено: {i}");
                Thread.Sleep(100);
            }
            collection.CompleteAdding();
        });

        var consumer = Task.Run(() =>
        {
            foreach (var item in collection.GetConsumingEnumerable())
            {
                Console.WriteLine($"Получено: {item}");
                Thread.Sleep(150);
            }
        });

        Task.WaitAll(producer, consumer);
    }
}

//87
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var queue = new BlockingCollection<string>(10);

        Task producer = Task.Run(() =>
        {
            for (int i = 1; i <= 30; i++)
            {
                queue.Add($"Сообщение {i}");
                Console.WriteLine($"Произведено: Сообщение {i}");
                Task.Delay(100).Wait();
            }
            queue.CompleteAdding();
        });

        Task[] consumers = new Task[3];
        for (int c = 0; c < 3; c++)
        {
            int id = c + 1;
            consumers[c] = Task.Run(() =>
            {
                foreach (var msg in queue.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Потребитель {id} обработал: {msg}");
                    Task.Delay(200).Wait();
                }
            });
        }

        await Task.WhenAll(new[] { producer }.Concat(consumers));
        Console.WriteLine("Все сообщения обработаны");
    }
}

//88
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var stack = new ConcurrentStack<int>();

        Parallel.Invoke(
            () => { for (int i = 0; i < 500; i++) stack.Push(i); },
            () => { for (int i = 0; i < 500; i++) stack.Push(i + 1000); },
            () =>
            {
                while (stack.TryPop(out int value))
                {
                    Console.WriteLine($"Извлечено: {value}");
                }
            }
        );
    }
}

//89
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Benchmark(Action action, string name)
    {
        var sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        var dict = new Dictionary<int, int>();
        var cdict = new ConcurrentDictionary<int, int>();
        var locker = new object();

        Benchmark(() =>
        {
            Parallel.For(0, 1000000, i =>
            {
                lock (locker) dict[i] = i;
            });
        }, "Dictionary + lock");

        Benchmark(() =>
        {
            Parallel.For(0, 1000000, i =>
            {
                cdict[i] = i;
            });
        }, "ConcurrentDictionary");
    }
}

//90
using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        var dict = new ConcurrentDictionary<string, int>();

        dict.AddOrUpdate("count", 1, (key, old) => old + 1);
        dict.TryRemove("count", out int removed);

        if (dict.TryAdd("newkey", 42))
            Console.WriteLine("Ключ успешно добавлен");

        Console.WriteLine($"Размер словаря: {dict.Count}");
    }
}

//91
using System;
using System.Threading;

class Program
{
    static int counter = 0;

    static void Main()
    {
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100000; j++)
                    Interlocked.Increment(ref counter);
            });
            threads[i].Start();
        }

        foreach (var t in threads) t.Join();
        Console.WriteLine($"Счётчик: {counter}");
    }
}

//92
using System;
using System.Threading;

class Program
{
    static int value = 100;

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            int current;
            do
            {
                current = value;
                Thread.Sleep(100);
            } while (Interlocked.CompareExchange(ref value, 999, current) != current);
            Console.WriteLine("Значение заменено на 999");
        });

        t1.Start();
        t1.Join();
        Console.WriteLine($"Финальное значение: {value}");
    }
}

//93
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object locker = new object();

    static void WithLock() { for (int i = 0; i < 1000000; i++) { lock (locker) counter++; } }
    static void WithInterlocked() { for (int i = 0; i < 1000000; i++) Interlocked.Increment(ref counter); }

    static void Benchmark(Action action, string name)
    {
        counter = 0;
        var sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} мс, результат: {counter}");
    }

    static void Main()
    {
        Benchmark(WithLock, "lock");
        Benchmark(WithInterlocked, "Interlocked");
    }
}

//94
using System;
using System.Threading;

public class SpinLock
{
    private int _locked = 0;

    public void Enter()
    {
        while (Interlocked.CompareExchange(ref _locked, 1, 0) == 1)
        {
            Thread.Yield();
        }
    }

    public void Exit()
    {
        Interlocked.Exchange(ref _locked, 0);
    }
}

class Program
{
    static int counter = 0;
    static SpinLock spinLock = new SpinLock();

    static void Worker()
    {
        for (int i = 0; i < 100000; i++)
        {
            spinLock.Enter();
            counter++;
            spinLock.Exit();
        }
    }

    static void Main()
    {
        Thread[] threads = new Thread[8];
        for (int i = 0; i < 8; i++)
        {
            threads[i] = new Thread(Worker);
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        Console.WriteLine($"Итог: {counter}");
    }
}

//95
using System;
using System.Threading;

class Program
{
    static long value = 1234567890123L;

    static void Main()
    {
        long readValue = Interlocked.Read(ref value);
        Console.WriteLine($"Прочитано 64-битное значение: {readValue}");
    }
}

//96
using System;
using System.Threading;

class Program
{
    static string resource = "Старое значение";

    static void Main()
    {
        string oldValue = Interlocked.Exchange(ref resource, "Новое значение");
        Console.WriteLine($"Старое значение: {oldValue}");
        Console.WriteLine($"Текущее значение: {resource}");
    }
}

//97
using System;
using System.Threading;

class Program
{
    static AutoResetEvent are = new AutoResetEvent(false);

    static void Worker()
    {
        Console.WriteLine("Рабочий ждёт сигнала...");
        are.WaitOne();
        Console.WriteLine("Сигнал получен, работаем!");
    }

    static void Main()
    {
        new Thread(Worker).Start();
        Thread.Sleep(3000);
        Console.WriteLine("Отправляем сигнал...");
        are.Set();
        Thread.Sleep(1000);
    }
}

//98
using System;
using System.Threading;

class Program
{
    static ManualResetEvent mre = new ManualResetEvent(false);

    static void Worker(int id)
    {
        Console.WriteLine($"Рабочий {id} ждёт разрешения...");
        mre.WaitOne();
        Console.WriteLine($"Рабочий {id} начал работу");
    }

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            new Thread(() => Worker(id)).Start();
        }

        Thread.Sleep(3000);
        Console.WriteLine("Разрешаем всем работать!");
        mre.Set();
        Thread.Sleep(1000);
    }
}

//99
using System;
using System.Threading;

class Program
{
    static ManualResetEvent[] events = {
        new ManualResetEvent(false),
        new ManualResetEvent(false),
        new ManualResetEvent(false)
    };

    static void Worker(int id)
    {
        Thread.Sleep(1000 + id * 500);
        Console.WriteLine($"Событие {id} готово");
        events[id].Set();
    }

    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            int id = i;
            new Thread(() => Worker(id)).Start();
        }

        Console.WriteLine("Ожидаем все события...");
        WaitHandle.WaitAll(events);
        Console.WriteLine("Все события сработали!");
    }
}

//100
using System;
using System.Threading;

class Program
{
    static AutoResetEvent itemAvailable = new AutoResetEvent(false);
    static AutoResetEvent spaceAvailable = new AutoResetEvent(true);
    static int buffer = 0;
    static readonly int Capacity = 5;

    static void Producer()
    {
        for (int i = 1; i <= 20; i++)
        {
            spaceAvailable.WaitOne();
            buffer++;
            Console.WriteLine($"Произведено: {i}, буфер: {buffer}");
            itemAvailable.Set();
            Thread.Sleep(200);
        }
    }

    static void Consumer()
    {
        while (true)
        {
            itemAvailable.WaitOne();
            buffer--;
            int item = buffer + 1;
            Console.WriteLine($"Потреблено: {item}, буфер: {buffer}");
            spaceAvailable.Set();
            if (buffer == 0 && item == 20) break;
            Thread.Sleep(300);
        }
    }

    static void Main()
    {
        new Thread(Producer).Start();
        new Thread(Consumer).Start();
        Thread.Sleep(10000);
    }
}