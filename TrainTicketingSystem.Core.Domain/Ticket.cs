using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainId { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public DateTime JourneyDate { get; set; }
        public DateTime PurchaseDate { get; set; }

        public ICollection<TicketSeat> TicketSeats { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("TrainId")]
        public Train Train { get; set; }
        [ForeignKey("SourceId")]
        public Station Station { get; set; }
    }
}
