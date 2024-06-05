using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormEnt.Data;
using FormEnt.Models;
using Microsoft.EntityFrameworkCore;

namespace FormEnt.Repository
{
    public class CreditRisksRepository:IRepository<CreditRisk>
    {
        private readonly AutoLotContext _context;

        public CreditRisksRepository(AutoLotContext context)
        {
            _context = context;
        }

        public void Add(CreditRisk entity)
        {
            _context.CreditRisks.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.CreditRisks.Find(id);
            if (entity != null)
            {
                _context.CreditRisks.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<CreditRisk> GetAll()
        {
            return _context.CreditRisks.ToList();
        }

        public CreditRisk GetByID(int id)
        {
            return _context.CreditRisks.Find(id);
        }

        public void Update(CreditRisk entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
