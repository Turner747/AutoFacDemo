using AutoFacDemo.Interfaces;

namespace AutoFacDemo
{
    public class InMemoryNumericStore : INumericStore
    {
        private readonly IPrinter _printer;
        private readonly HashSet<int> _store = new HashSet<int>();

        public InMemoryNumericStore(IPrinter printer)
        {
            _printer = printer;
        }

        public void Add(int number) => _store.Add(number);

        public bool Contains(int number) => _store.Contains(number);

        public void Remove(int number) => _store.Remove(number);
    }
}
