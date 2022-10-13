using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main" + " " + Thread.CurrentThread.ManagedThreadId); //Thread.CurrentThread.ManagedThreadId аргумент с поиском текущего потока
            MethodAsync();
            Console.WriteLine("End Main" + " " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        static async void MethodAsync()
        {
            Console.WriteLine("Start MethodAsync" + " " + Thread.CurrentThread.ManagedThreadId);
            await Task.Run(TaskRun); 
            //await Task.Run(() => Thread.Sleep(5000)); // Запуск выполнения кода параллельно через Лямбда функцию (задержка на 5000 милисекунд)
            Console.WriteLine("End MethodAsync" + " " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void TaskRun() // Аналогичная остановка с помощью метода
        {
            Console.WriteLine("Start TaskRun" + " " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("End TaskRun" + " " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
