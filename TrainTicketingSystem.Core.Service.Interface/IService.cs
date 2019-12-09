using System;
using System.Collections.Generic;

namespace TrainTicketingSystem.Core.Service.Interface
{
    public interface IService<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        string PrettyDateFormat(DateTime myDate);
        string PrettyDateFormatForward(DateTime myDate);
    }
}
