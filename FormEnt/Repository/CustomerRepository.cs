using FormEnt.Data;
using FormEnt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEnt.Repository
{
    public class CustomerRepository:IRepository<Customer>
    {
        private readonly AutoLotContext autoLotContext;
        public CustomerRepository(AutoLotContext context)
        {
            autoLotContext = context;
        }

        public void Add(Customer entity)
        {
            autoLotContext.Customers.Add(entity);
            autoLotContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = autoLotContext.Customers.Find(id);
            if (entity != null)
            {
                autoLotContext.Customers.Remove(entity);
                autoLotContext.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            return autoLotContext.Customers.ToList();
        }

        public Customer GetByID(int id)
        {
            return autoLotContext.Customers.Find(id);
        }

        public void Update(Customer entity)
        {
            autoLotContext.Entry(entity).State = EntityState.Modified;
            autoLotContext.SaveChanges();
        }
    }
}
