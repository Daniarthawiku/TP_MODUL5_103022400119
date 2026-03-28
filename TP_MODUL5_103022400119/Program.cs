using System;

namespace ModulGeneric
{
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"nim dani adalah {this.data}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> objekData = new DataGeneric<string>("103022400119");
            objekData.PrintData();
        }
    }
}