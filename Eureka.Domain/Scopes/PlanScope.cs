using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class PlanScope
    {
        public static bool ValidName(this Plan plan)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(plan.Name, 3, 80, "Nome do plano deve possuir mais que 2 até 80 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(plan.Name, "Informe o nome do plano.")
                );
        }

        public static bool ValidDescription(this Plan plan)
        {
            return AssertionConcern.IsValid(
                    AssertionConcern.AssertArgumentLength(plan.Description, 10, 150, "Descrição do plano deve possuir mais do que 9 até 150 caracteres."),
                    AssertionConcern.AssertArgumentNotEmpty(plan.Description, "Informe uma descrição para o plano.")
                );
        }

        public static bool ValidPrice(this Plan plan)
        {           
          return  AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEquals(plan.Price, 0, "Preço do plano não pode ser igual a 0.")
                );
        }
    }
}
