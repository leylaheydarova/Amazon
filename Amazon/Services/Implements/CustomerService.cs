using Amazon.DTOs.Customer;
using Amazon.Exceptions.NotFoundExceptions;
using Amazon.Models;
using Amazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class CustomerService : IGenericService<CustomerCreateDto>
    {
        private readonly List<Customer> _customers = new List<Customer>();
        public void Create(CustomerCreateDto dto)
        {
            var customer = new Customer()
            {
                Id = dto.Id,
                Email = dto.Email,
                Firstname = dto.Firstname,
                Lastname = dto.Lastname,
                Password = dto.Password,
                PhoneNumber = dto.PhoneNumber
            };
            _customers.Add(customer);
        }

        public void Delete(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) throw new CustomerNotFoundException();
            _customers.Remove(customer);
        }

        public void GetAll()
        {
            foreach(var customer in _customers)
            {
                Console.WriteLine($"ID:{customer.Id} - {customer.Firstname} {customer.Lastname}\n{customer.PhoneNumber}\n{customer.Email}\n");
            }
        }

        public void GetById(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) throw new CustomerNotFoundException();
            Console.WriteLine($"ID:{customer.Id} - {customer.Firstname} {customer.Lastname}\n{customer.PhoneNumber}\n{customer.Email}");
        }
    }
}
