using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketingSystem.Core.Domain.Custom_Models
{
    public class ErrorHandler
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
