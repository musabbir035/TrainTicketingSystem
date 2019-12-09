using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class Route
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public TimeSpan SourceDepartureTime { get; set; }
        public TimeSpan DestinationArrivalTime { get; set; }
        public int AcBerthSeats { get; set; }
        public int AcSeatSeats { get; set; }
        public int AcChairSeats { get; set; }
        public int FcBerthSeats { get; set; }
        public int FcSeatSeats { get; set; }
        public int FcChairSeats { get; set; }
        public int ShovonChairSeats { get; set; }
        public int ShovonSeats { get; set; }
        public int AcBerthFare { get; set; }
        public int AcSeatFare { get; set; }
        public int AcChairFare { get; set; }
        public int FcBerthFare { get; set; }
        public int FcSeatFare { get; set; }
        public int FcChairFare { get; set; }
        public int ShovonChairFare { get; set; }
        public int ShovonFare { get; set; }

        public Train Train { get; set; }
        [ForeignKey("SourceId")]
        public Station Station { get; set; }
    }
}
