using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class BrandScope
    {
        public static bool ValidName(this Brand brand)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(brand.Name, 2, 30, "Nome da marca deve possuir mais que 2 até 30 caracteres."),
                AssertionConcern.AssertArgumentNotNull(brand.Name, "Nome da marca é obrigatório")
                );
        }
    }
}
