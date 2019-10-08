using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class ServiceScope
    {
        public static bool ValidTitle(this Service service)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(service.Title, 3, 30, "Título deve possuir mais que 3 até 30 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(service.Title, "Informe o título")
            );
        }

        public static bool ValidPhone(this Service service)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(service.Phone, 12, 12, "Telefone incorreto."),
                AssertionConcern.AssertArgumentNotEmpty(service.Phone, "Informe um número de telefone.")
            );
        }

        public static bool ValidDescription(this Service service)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(service.Description, "Informe algo sobre sua empresa."),
                AssertionConcern.AssertArgumentLength(service.Description, 10, 120, "Descrição deve possuir mais que 10 até 120 caracteres.")
            );
        }

        #region used to tests
        public static bool ServiceValid(this Service service)
        {
            int result = 0;

            result = ValidTitle(service) ? result : result + 1;
            result = ValidPhone(service) ? result : result + 1;
            result = ValidDescription(service) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
