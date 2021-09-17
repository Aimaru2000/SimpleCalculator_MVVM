using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_MultiBinding.Command;


namespace MVVM_MultiBinding.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ICommand MyCommandSum { get; set; }
        public ICommand MyCommandDiff { get; set; }
        public ICommand MyCommandProd { get; set; }
        public ICommand MyCommandQuot { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged( string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set { _number1 = value; OnPropertyChanged("Number1"); }
        }


        private int _number2;
        public int Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged("Number2"); }
        }


        private int nubersum;
        public int NumberSum
        {
            get { return nubersum; }
            set { nubersum = value; OnPropertyChanged("NumberSum"); }
        }

        private int difference;
        public int NumberDiff
        {
            get { return difference; }
            set { difference = value; OnPropertyChanged("NumberDiff"); }
        }

        private int product;
        public int NumberProd
        {
            get { return product; }
            set { product = value; OnPropertyChanged("NumberProd"); }
        }

        private int quotient;
        public int NumberQuot
        {
            get { return quotient; }
            set { quotient = value; OnPropertyChanged("NumberQuot"); }
        }


        public ViewModel()
        {
            MyCommandSum = new RelayCommand(executeSum, canexecute);
            MyCommandDiff = new RelayCommand(executeDiff, canexecute);
            MyCommandProd = new RelayCommand(executeProd, canexecute);
            MyCommandQuot = new RelayCommand(executeDiv, canexecute);
        }


        private bool canexecute(object parameter)
        {             
            return true;
        }

        private void executeSum(object parameter)
        {
            NumberSum = Number1 + Number2;
        }
        private void executeDiff(object parameter)
        {
            NumberDiff = Number1 - Number2;
        }
        private void executeProd(object parameter)
        {
            NumberProd = Number1 * Number2;
        }
        private void executeDiv(object parameter)
        {
            NumberQuot = Number1 / Number2;
        }

    }
}
