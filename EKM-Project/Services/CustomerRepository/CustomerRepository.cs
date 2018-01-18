﻿using EKM_Project.Models;
using System;

namespace EKM_Project.Services.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly ApplicationDbContext _context;

        public CustomerRepository()
        {
            _context = new ApplicationDbContext();
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}