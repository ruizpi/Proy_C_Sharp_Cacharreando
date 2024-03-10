using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace APP_MVVM
{
    // SE NECESITAN 2 ARCHIVOS PARA HACER QUE EL VIEW MODEL FUNCIONE
    // UNO ES ESTE QUE ES LA CLASE VIEWMODELBASE
    // EL PRIMERO ES ESTE
    // TENEMOS QUE INDICAR DE ALGUNA MANERA QUE CUANDO
    // HAYA CAMBIOS EN LOS DATOS QUE LA VISTA SE ACTUALICE
    // PARA ELLO SE DEBE CREAR UNA BASE ABSTRACTA CON LAS INTERFACES INOTIFY QUE SE VEN ABAJO
    // Y DEFINIR LOS 2 EVENTOS QUE INCLUYE
    // DESPUES HAY QUE IMPLEMENTAR CADA UNO COMO PROTECTED
    // SI NO SE TIENE ESTO NO FUNCIONA EL VIEW MODEL
    public abstract class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        protected void OnPropertyChanging([CallerMemberName] string propertyName = "")
        {
            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));       
            }
        }
    }
}
