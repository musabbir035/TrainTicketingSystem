using System;
using System.Collections.Generic;
using TrainTicketingSystem.Core.Repository.Interface;
using TrainTicketingSystem.Core.Service.Interface;

namespace TrainTicketingSystem.Core.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> _repo)
        {
            this._repo = _repo;
        }

        public T GetById(int id)
        {
            return _repo.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(T entity)
        {
            _repo.Insert(entity);
            _repo.Save();
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            _repo.InsertRange(entities);
            _repo.Save();
        }

        public void Update(T entity)
        {
            _repo.Update(entity);
            _repo.Save();
        }

        public void Delete(T entity)
        {
            _repo.Delete(entity);
            _repo.Save();
        }

        public string PrettyDateFormat(DateTime myDate)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.Now.Ticks - myDate.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return "Just now";

            if (delta < 2 * MINUTE)
                return "1 minute ago";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes ago";

            if (delta < 90 * MINUTE)
                return "1 hour ago";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours ago";

            if (delta < 48 * HOUR)
                return "Yesterday";

            if (delta < 30 * DAY)
                return ts.Days + " days ago";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "One month ago" : months + " months ago";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "One year ago" : years + " years ago";
            }
        }

        public string PrettyDateFormatForward(DateTime myDate)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(myDate.Ticks - DateTime.Now.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return "1 min";

            if (delta < 2 * MINUTE)
                return "2 mins";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " mins";

            if (delta < 90 * MINUTE)
                return "1 hour";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours";

            if (delta < 48 * HOUR)
                return "Tomorrow " + myDate.ToString("hh:mm tt");

            if (delta < 30 * DAY)
                return ts.Days + " days";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "1 month" : months + " months";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "1 year" : years + " years";
            }
        }
    }
}
