using AutoFacDemo.Interfaces;

namespace AutoFacDemo
{
    public class Application
    {
        private readonly IOptionsService _optionsService;
        private readonly IPrinter _printer;

        public Application(IOptionsService service, IPrinter printer)
        {
            _optionsService = service;
            _printer = printer;

            Initialise();
        }

        private void Initialise()
        {
            _optionsService.EnableOption(1);
            _optionsService.DisableOption(2);
        }

        public void Run()
        {
            if(_optionsService.IsOptionEnabled(1))
            {
                _printer.Print("Do something...");
            }
        }
    }
}
