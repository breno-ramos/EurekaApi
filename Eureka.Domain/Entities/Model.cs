using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Entities
{
    public class Model : Entity
    {
        public Model(string nome, Brand brand)
        {
            Nome = nome;
            Status = EStatusType.Active;
            Brand = brand;

            this.ValidName();
            BrandScope.ValidName(Brand);
        }

        public string Nome { get; private set; }
        public EStatusType Status { get; private set; }
        public Brand Brand { get; private set; }
    }
}
