using FORMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMS.EntityRepository
{
    public class CustomersRepository : IRepository2<Customer>
    {

        public void Add(Customer entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Set<Customer>().Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var _context = new AutoLotContext())
            {
                var entity = _context.Set<Customer>().Find(id);
                if (entity != null)
                {
                    _context.Set<Customer>().Remove(entity);
                    _context.SaveChanges();
                }
            }
        }

        public List<Customer> GetAll()
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<Customer>().ToList();
            }
        }

        public Customer GetByID(int id)
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<Customer>().Find(id);
            }
        }

        public void Update(Customer entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
