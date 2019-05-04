using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class Service<T> : IService<T> where T : class
    {
        protected IRepository<T> repo;

        public Service(IRepository<T> repo)
        {
            this.repo = repo;
        }

        public IEnumerable<T> GetAll()
        {
            return repo.GetAll();
        }

        public T GetById(int id)
        {
            return repo.Get(id);
        }

        public void InsertMultiple(IEnumerable<T> ts)
        {
            repo.InsertRange(ts);
            repo.Save();
        }

        public void Insert(T t)
        {
            repo.Insert(t);
            repo.Save();
        }

        public void Update(T t)
        {
            repo.Update(t);
            repo.Save();
        }

        public void DeleteMultiple(IEnumerable<T> ts)
        {
            repo.DeleteRange(ts);
            repo.Save();
        }

        public void Delete(T t)
        {
            repo.Delete(t);
            repo.Save();
        }
    }
}
