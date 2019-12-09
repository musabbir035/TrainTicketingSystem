using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TrainTicketingSystem.Core.Repository.Interface;

namespace TrainTicketingSystem.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        public Repository(DbContext _context)
        {
            this._context = _context;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
