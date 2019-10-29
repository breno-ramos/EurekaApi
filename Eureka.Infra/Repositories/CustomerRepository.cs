using System;
using System.Collections.Generic;
using System.Linq;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;
using System.Data.Entity;

namespace Eureka.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private EurekaDataContext _context;

        public CustomerRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            _context.Entry<Customer>(customer).State = EntityState.Modified;
        }

        public List<Customer> Get(int skip, int take)
        {
            return _context.Customers.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public Customer GetByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(x => x.Email == email);
        }

        public Customer GetById(Guid id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Customer Authenticate(string email, string password)
        {
            return _context.Customers.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
