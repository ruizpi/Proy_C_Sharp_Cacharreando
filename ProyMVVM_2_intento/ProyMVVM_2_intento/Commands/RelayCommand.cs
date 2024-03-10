using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyMVVM_2_intento.Commands
{
    internal class RelayCommand : ICommand
    {
        //SE CREAN 2 DELEGADOS 
        // HACE REFERENCIA A METODOS QUE DEVUELVAN UN TIPO VOID Y QUE TENGAN UN PARAMETRO DE TIPO OBJECT
        private readonly Action<object> _execute;

        // ESTE DELEGADO HACE REFERENCIA A METODOS QUE DEVUELVAN UN TIPO BOOL Y COMO PARAMETRO TENGA OBJECT
        private readonly Predicate<object> _canExecute; 

        // CREAMOS EL CONSTRUCTOR DE ESTA CLASE QUE VAN A SER LOS 2 PARAMETROS DEFINIDOS ANTERIORMENTE
        public RelayCommand(Action<Object> execute, Predicate<Object> canExecute)
        {
            // SE LE ASIGNAN LOS DELEGADOS QUE VENIAN DE PARAMETROS A LOS DELEGADOS INTERNOS
            _execute = execute;
            _canExecute = canExecute;
        }

        //CON ESTE DELEGADO LO QUE SE HACE ES SOBRECARGAR EL ANTERIOR
        // Y EN ESTE CASO, SE LE DICE CON THIS QUE SEA COMO INTERFAZ EL METODO ANTERIOR
        // Y CON ESO LO QUE HACEMOS ES QUE EJECUTE PRIMERO EL PRIMER METODO RELAY COMMAND 
        // Y DESPUÉS ESTE
        public RelayCommand(Action<Object> execute): this(execute, null) 
        {

        }


        // ESTO OCURRE CUANDO SE DETECTEN CONDICIONES QUE PUEDAN CAMBIAR LA CAPACIDAD
        // DE EJECUTARSE

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



        public bool CanExecute(object parameter)
        {
            return _canExecute == null? true: _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
