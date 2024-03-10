using APP_MVVM.Models;
using System;
using System.Collections.Generic;

namespace APP_MVVM.DAI
{
    class CustomerService
    {

        public List<Customer> GetCustomers()
        { 
            var customer = new List<Customer>();

            for (int i = 0; i<20; i++)
            {
                customer.Add(new Customer()
                {
                    Id = i,
                    FirstName = Guid.NewGuid().ToString(),
                    SecondName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    IsEnabled = i > 1 && i < 10,
                    UltimoLogin = DateTime.Now.AddDays(i)
                }) ;
            }
            
            
            return customer; 
        
        
        }

    }
}
