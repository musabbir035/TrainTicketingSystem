namespace TrainTicketingSystem.Core.Domain
{
    public partial class Route
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public System.TimeSpan SourceDepartureTime { get; set; }
        public System.TimeSpan DestinationArrivalTime { get; set; }
        public int AcBerth { get; set; }
        public int AcSeat { get; set; }
        public int AcChair { get; set; }
        public int FcBerth { get; set; }
        public int FcSeat { get; set; }
        public int FcChair { get; set; }
        public int ShovonChair { get; set; }
        public int Shovon { get; set; }
        public int AcBerthFare { get; set; }
        public int AcSeatFare { get; set; }
        public int AcChairFare { get; set; }
        public int FcBerthFare { get; set; }
        public int FcSeatFare { get; set; }
        public int FcChairFare { get; set; }
        public int ShovonChairFare { get; set; }
        public int ShovonFare { get; set; }
    }
}
