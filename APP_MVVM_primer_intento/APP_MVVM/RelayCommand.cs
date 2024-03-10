using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APP_MVVM
{

    // LOS DOS FICHEROS PRINCIPALES SON VIEWMODELBASE Y RELAYCOMMANDS
    // ESTE ES EL RELAY COMMANDS
    // LOS METODOS Y FUNCIONES SE DEFINEN MIRANDO LA CLASE ICOMMAND Y SE IMPLEMENTA TODO



    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;


        public RelayCommand(Action<object> execute) : this(execute,null)
        {

        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            return this.canExecute == null ? true : this.canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
     }

}
