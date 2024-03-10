using MVVM_01.BD;
using MVVM_01.Commands;
using MVVM_01.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_01.Model;

namespace MVVM_01.ViewModel
{
    internal class UserViewModel: ViewModelBase
    {
        private readonly DataBase db;

        private ObservableCollection<UserModel> _users;

        private UserModel _user;



        public UserViewModel()
        {
            db = new DataBase();
            _user = new UserModel();
            _users = db.Get();
        }

        public UserModel User
        {
            get => _user;
            set
            {
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

        public ICommand AddCommand
        {
            get
            {
                return new RelayCommand(AddExecute, AddCanExecute);
            }
        }


        public void AddExecute(Object user)
        {
            db.Add(User);
            Users = db.Get();
        }

        private bool AddCanExecute(Object user)
        {
            return true;
        }

    }
}
