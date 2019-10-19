using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class ModelScope
    {
        public static bool ValidName(this Model model)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(model.Nome, 3, 50, "Modelo deve possuir mais que 3 até 50 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(model.Nome, "Informe o modelo.")
            );
        }
    }
}
