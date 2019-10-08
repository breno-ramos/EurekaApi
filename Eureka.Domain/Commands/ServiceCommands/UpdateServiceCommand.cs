using System.Collections.Generic;

namespace Eureka.Domain.Commands.ServiceCommands
{
    public class UpdateServiceCommand
    {
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Site { get; set; }
        public IList<string> Pictures { get; set; }
    }
}
