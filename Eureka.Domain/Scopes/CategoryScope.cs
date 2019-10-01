using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class CategoryScope
    {
        public static bool ValidName(this Category category)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(category.Name, 3, 30, "Nome da categoria deve possuir mais que 3 até 30 caracteres."),
                AssertionConcern.AssertArgumentNotNull(category.Name, "Informe o nome da categoria.")
                );
        }
    }
}
