using System.Collections.Generic;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OffDay { get; set; }
        public int StartStation { get; set; }
        public int LastStation { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
