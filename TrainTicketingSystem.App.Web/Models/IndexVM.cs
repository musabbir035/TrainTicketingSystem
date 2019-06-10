using System.Collections.Generic;
using TrainTicketingSystem.Core.Domain;

namespace TrainTicketingSystem.App.Web.Models
{
    public class IndexVM
    {
        public User User { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}