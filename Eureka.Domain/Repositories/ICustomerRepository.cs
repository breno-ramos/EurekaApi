using Eureka.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> Get(int skip, int take);
        Customer GetById(Guid id);
        Customer GetByEmail(string email);
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer Authenticate(string email, string password);
    }
}
