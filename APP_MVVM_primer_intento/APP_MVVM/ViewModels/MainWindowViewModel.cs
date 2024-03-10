using APP_MVVM.DAI;
using APP_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APP_MVVM.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        private List<Customer> customers;

        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                if (customers == value)
                {
                    return;
                }
                customers = value;
                OnPropertyChanged("Customers");
            }
        }

        #endregion



        #region Commands
            private ICommand customerCommand;

            public ICommand CustomerCommand
            {
                get
                {
                    if (customerCommand == null) {
                        customerCommand = new RelayCommand(param => this.CustomerCommandExecute(), null);
                    }
                    return customerCommand;
                }
            }


        #endregion


        public MainWindowViewModel()
        {

        }

        private void CustomerCommandExecute()
        {
            var customerService = new CustomerService();
            var result = customerService.GetCustomers();

            Customers = new List<Customer>(result);
        }
    }
}