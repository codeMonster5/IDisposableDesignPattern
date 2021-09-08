using System;
using System.Net.Http;

namespace IDisposableDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using ServiceProxy obj = new ServiceProxy();

            obj.Get("https://alive");

            obj.Post("https://alive","");

            obj.Dispose();

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
