using System;

namespace TrainTicketingSystem.Core.Domain
{
    public class PasswordReset
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
    }
}
