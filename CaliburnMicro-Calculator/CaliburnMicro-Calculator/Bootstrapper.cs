using System.Windows;
using Caliburn.Micro;
using CaliburnMicro_Calculator.ViewModels;

namespace CaliburnMicro_Calculator
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object obj, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
