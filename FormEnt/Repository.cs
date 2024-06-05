using FormEnt.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEnt
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        
        public void Add(TEntity entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var _context = new AutoLotContext())
            {
                var entity = _context.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                    _context.SaveChanges();
                }
            }
        }
        public TEntity GetByID(int id)
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll()
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var _context = new AutoLotContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public List<TEntity> Buscar(Func<TEntity, bool> predicate)
        {
            using (var _context = new AutoLotContext())
            {
                return _context.Set<TEntity>().Where(predicate).ToList();
            }
        }
        
    }
}
