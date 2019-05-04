using System.Collections.Generic;

namespace TrainTicketingSystem.Core.Service.Interface
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T t);
        void InsertMultiple(IEnumerable<T> ts);
        void Update(T t);
        void Delete(T t);
        void DeleteMultiple(IEnumerable<T> ts);
    }
}
