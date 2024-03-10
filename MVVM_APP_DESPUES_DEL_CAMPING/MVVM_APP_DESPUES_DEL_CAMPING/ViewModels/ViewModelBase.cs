using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_APP_DESPUES_DEL_CAMPING.ViewModels
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null){

                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            

        }
    }
}
