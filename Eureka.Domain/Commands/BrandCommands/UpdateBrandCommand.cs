using System;

namespace Eureka.Domain.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
