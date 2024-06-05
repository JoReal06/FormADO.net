using FORMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMS.EntityRepository
{
    public class CreditRisksRepository : IRepository2<CreditRisks>
    {
       
        public void Add(CreditRisks entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Set<CreditRisks>().Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var _context = new AutoLotContext())
            {
                var entity = _context.Set<CreditRisks>().Find(id);
                if (entity != null)
                {
                    _context.Set<CreditRisks>().Remove(entity);
                    _context.SaveChanges();
                }
            }
        }

        public List<CreditRisks> GetAll()
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<CreditRisks>().ToList();
            }
        }

        public CreditRisks GetByID(int id)
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<CreditRisks>().Find(id);
            }
        }

        public void Update(CreditRisks entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
    
}
