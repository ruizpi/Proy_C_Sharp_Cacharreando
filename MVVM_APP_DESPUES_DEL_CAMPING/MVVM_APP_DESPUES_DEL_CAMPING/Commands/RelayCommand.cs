using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_APP_DESPUES_DEL_CAMPING.Commands
{
    internal class RelayCommand : ICommand
    {

        // ESTE DELEGADO SE CREA CON EL FIN DE PODER RESPONDER A METODOS QUE SON DE TIPO VOID Y CON UN SOLO PARAMETRO OBJECT
        private readonly Action<object> _execute;

        // ESTE DELEGADO HACE REFERENCIA A METODOS QUE DEVUELVAN BOOL Y CON UN SOLO PARAMETRO OBJECT
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = null;
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute) 
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        //public RelayCommand(Action<object> execute) : this(execute, null) { 

        //}



        public bool CanExecute(object parameter)
        {
            return _canExecute == null? true: _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        private void CommandManager_RequerySuggested(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
