using MVVM_APP_DESPUES_DEL_CAMPING.BD;
using MVVM_APP_DESPUES_DEL_CAMPING.Commands;
using MVVM_APP_DESPUES_DEL_CAMPING.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_APP_DESPUES_DEL_CAMPING.ViewModels
{
    internal class UserViewModel : ViewModelBase
    {
        private readonly Bd bd;
        private ObservableCollection<UserModel> _users;
        private UserModel _user;

        public UserViewModel()
        {
            bd = new Bd();  
            _user = new UserModel();
            _users = bd.Get();
        }

        public UserModel User
        {
            get => _user;
            set {
                if (_user != value)
                {
                    _user = value;
                    OnPropertyChanged(nameof(User));

                }
                
            }

        }

        public ObservableCollection<UserModel> Users
        {
            get => _users;
            set
            {
                if (_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        private void AddExecute(Object user)
        {
            bd.Add(User);
            Users = bd.Get();
        }

        private bool AddCanExecute(Object user)
        {
            return true;
        }

        private void EditExecute(Object user)
        {
            bd.Edit(User);
            Users = bd.Get();
        }

        private bool EditCanExecute(Object user)
        {
            return true;
        }

        public ICommand AddCommand
        {
            get
            {
                return new RelayCommand(AddExecute,AddCanExecute);
            }
        }


        public ICommand EditCommand
        {
            get
            {
                return new RelayCommand(EditExecute, EditCanExecute);
            }
        }
    }
}
