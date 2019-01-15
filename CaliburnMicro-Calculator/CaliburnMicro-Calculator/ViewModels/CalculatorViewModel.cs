using System.ComponentModel;
using System.Threading;
using System.Windows;
using Caliburn.Micro;

namespace CaliburnMicro_Calculator.ViewModels
{
    public class CalculatorViewModel: Screen, INotifyPropertyChanged
    {
        #region properties
        private double _left;
        private double _right;
        private double _result;

        public double Left
        {
            get { return _left; }
            set
            {
                _left = value;
                NotifyOfPropertyChange();
            }
        }

        public double Right
        {
            get { return _right; }
            set
            {
                _right = value;
                NotifyOfPropertyChange();
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                NotifyOfPropertyChange();
            }
        }
        #endregion

        #region ctor
        public CalculatorViewModel()
        {
        }
        #endregion

        #region Public Methods
        public bool CanDivide(double left, double right)
        {
            return right != 0;
        }

        public async void Divide(double left, double right)
        {
            Thread.Sleep(600);
            if (CanDivide(left, right) == true)
                Result = left / right;
            else MessageBox.Show("Divider cannot be zero.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public async void Plus(double left, double right)
        {
            Result = left + right;
        }

        public async void Minus(double left, double right)
        {
            Result = left - right;
        }

        public async void Multiply(double left, double right)
        {
            Result = left * right;
        }
        #endregion
    }
}