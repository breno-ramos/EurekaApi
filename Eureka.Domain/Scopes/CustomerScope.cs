using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class CustomerScope
    {
        public static bool ValidCompanyName(this Customer customer)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(customer.CompanyName, 3, 80, "Nome da empresa deve possuir mais que 2 até 80 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(customer.CompanyName, "Informe o nome da empresa.")
            );
        }

        public static bool ValidEmail(this Customer customer)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(customer.Email, 5, 60, "Email deve possuir mais que 4 até 60 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(customer.Email, "Informe o email."),
                AssertionConcern.AssertArgumentMatches(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", customer.Email, "Email inválido.")
            );
        }

        public static bool ValidPassword(this Customer customer)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(customer.Password, 8, 16, "Senha deve possuir mais que 7 até 16 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(customer.Password, "Informe a senha.")
            );
        }

        public static bool ValidLogo(this Customer customer)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(customer.Logo, "Informe a logomarca da sua empresa.")
            );
        }

        #region used to tests
        public static bool CreateCustomerIsValid(this Customer customer)
        {
            int result = 0;

            result = ValidCompanyName(customer) ? result : result + 1;
            result = ValidEmail(customer) ? result : result + 1;
            result = ValidPassword(customer) ? result : result + 1;
            result = ValidLogo(customer) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
