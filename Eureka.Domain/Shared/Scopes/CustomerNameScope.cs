using Eureka.Domain.Shared.ValueObjects;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Shared.Scopes
{
    public static class CustomerNameScope
    {
        public static bool ValidFirstName(this CustomerName customerName)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(customerName.FirstName, 3, 40, "Primeiro nome deve possuir mais que 2 até 40 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(customerName.FirstName, "Informe seu primeiro nome.")
            );
        }

        public static bool ValidLastName(this CustomerName customerName)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(customerName.LastName, 3, 40, "Último nome deve possuir mais que 2 até 40 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(customerName.LastName, "Informe seu último nome.")
            );
        }

        #region used to tests
        public static bool CustomerNameIsValid(this CustomerName customerName)
        {
            int result = 0;

            result = ValidFirstName(customerName) ? result : result + 1;
            result = ValidLastName(customerName) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
