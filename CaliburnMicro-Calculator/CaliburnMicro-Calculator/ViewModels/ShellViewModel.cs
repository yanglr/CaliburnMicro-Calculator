using Caliburn.Micro;

namespace CaliburnMicro_Calculator.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
        }
        public void ShowCalculator()
        {
            ActivateItem(new CalculatorViewModel());
        }
    }
}