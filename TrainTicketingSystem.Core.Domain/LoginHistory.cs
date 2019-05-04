namespace TrainTicketingSystem.Core.Domain
{
    public partial class LoginHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime LoginTime { get; set; }
        public System.DateTime LogoutTime { get; set; }
        public string Ip { get; set; }
    }
}
