using AutoFacDemo.Interfaces;

namespace AutoFacDemo
{
    public class FileNumericStore : INumericStore
    {
        private readonly IPrinter _printer;

        public FileNumericStore(IPrinter printer)
        {
            _printer = printer;
        }

        private static string GetFilePath(int number) => $"./{number}.txt";

        public void Add(int number) => File.WriteAllText(GetFilePath(number), "");

        public bool Contains(int number) => File.Exists(GetFilePath(number));

        public void Remove(int number) => File.Delete(GetFilePath(number));
    }
}
