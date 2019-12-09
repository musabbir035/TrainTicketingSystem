using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrainTicketingSystem.Core.Domain
{
    public class TicketSeat
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Compartment { get; set; }
        public string Seat { get; set; }

        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
    }
}
