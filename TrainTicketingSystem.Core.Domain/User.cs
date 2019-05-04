namespace TrainTicketingSystem.Core.Domain
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public System.DateTime JoinDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    }
}
