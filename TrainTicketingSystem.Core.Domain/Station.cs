using System.Collections.Generic;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Train> Trains { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
