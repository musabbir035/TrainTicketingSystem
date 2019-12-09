using System;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class LoginHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime LogoutDate { get; set; }
        public string Ip { get; set; }

        public User User { get; set; }
    }
}
