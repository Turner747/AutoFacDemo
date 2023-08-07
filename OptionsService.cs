using AutoFacDemo.Interfaces;

namespace AutoFacDemo
{
    public class OptionsService : IOptionsService
    {
        private readonly INumericStore _numericStore;
        private readonly IPrinter _printer;
        public OptionsService(INumericStore store, IPrinter printer)
        {
            _numericStore = store;
            _printer = printer;
        }

        public void DisableOption(int option)
        {
            _printer.Print($"Disabling option {option}...");
            _numericStore.Remove(option);
            _printer.Print($"Option {option} is disabled");
        }

        public void EnableOption(int option)
        {
            _printer.Print($"Enabling option {option}...");
            _numericStore.Add(option);
            _printer.Print($"Option {option} is enabled");
        }

        public bool IsOptionEnabled(int option) => _numericStore.Contains(option);
    }
}
