using AutoFacDemo.Interfaces;

namespace AutoFacDemo
{
    public class Printer : IPrinter
    {
        public void Print(string print)
        {
            Console.WriteLine(print);
        }
    }
}
