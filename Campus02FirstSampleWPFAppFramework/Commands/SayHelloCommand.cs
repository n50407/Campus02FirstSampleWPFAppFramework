using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Campus02FirstSampleWPFAppFramework.Commands
{
    internal sealed class SayHelloCommand : ICommand
    {


        public SayHelloCommand()
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           MessageBox.Show("Hello from Command!");
        }
    }

}
