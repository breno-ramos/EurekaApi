using Eureka.Domain.Commands.CustomerCommands;
using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Domain.Services;
using Eureka.Domain.Shared.ValueObjects;
using Eureka.Infra;
using System;
using System.Collections.Generic;

namespace Eureka.ApplicationService.Services
{
    public class CustomerApplicationService : ApplicationServiceBase, ICustomerApplicationService
    {
        private ICustomerRepository _customerRepository;

        public CustomerApplicationService(ICustomerRepository customerRepository, IUnitOfWork uow)
            : base(uow)
        {
            _customerRepository = customerRepository;
        }

        public Customer Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Customer Create(CreateCustomerCommand command)
        {
            var name = new CustomerName(command.FirstName, command.LastName);
            var document = new Document(command.DocumentType, command.DocumentValue);
            var branch = new Branch(command.Branch.Description);
            var address = new Address(command.Address.Number, command.Address.Street, command.Address.Neighborhood, command.Address.City, command.Address.State, command.Address.Country);
            var subscription = new Subscription(command.Subscription.Type, command.Subscription.Plan);

            var customer = new Customer(command.CompanyName, name, document, command.Email, command.Password, command.Logo, branch, subscription, address);
            _customerRepository.Create(customer);

            if (Commit())
                return customer;

            return null;
        }

        public Customer Delete(Guid id)
        {
            var customer = _customerRepository.GetById(id);
            _customerRepository.Delete(customer);

            if (Commit())
                return customer;

            return null;
        }

        public List<Customer> Get(int skip, int take)
        {
            return _customerRepository.Get(skip, take);
        }

        public Customer GetByEmail(string email)
        {
            return _customerRepository.GetByEmail(email);
        }

        public Customer GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public Customer Update(UpdateCustomerCommand command)
        {
            var name = new CustomerName(command.FirstName, command.LastName);
            var document = new Document(command.DocumentType, command.DocumentValue);
            var branch = new Branch(command.Branch.Description);
            var address = new Address(command.Address.Number, command.Address.Street, command.Address.Neighborhood, command.Address.City, command.Address.State, command.Address.Country);
            var subscription = new Subscription(command.Subscription.Type, command.Subscription.Plan);

            var customer = new Customer(command.CompanyName, name, document, command.Email, command.Password, command.Logo, branch, subscription, address);
            _customerRepository.Update(customer);

            if (Commit())
                return customer;

            return null;
        }
    }
}
