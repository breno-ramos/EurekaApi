using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class AddressScope
    {
        public static bool ValidNumber(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.Number.ToString(), "Informe o número"),
                AssertionConcern.AssertArgumentRange(address.Number, 1, 99999, "Número inválido.")
            );
        }

        public static bool ValidStreet(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.Street, "Informe a rua.")
            );
        }

        public static bool ValidNeighborhood(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.Neighborhood, "Informe o bairro.")
            );
        }

        public static bool ValidCity(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.City, "Informe a cidade.")
            );
        }

        public static bool ValidState(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.State, "Informe o estado.")
            );
        }

        public static bool ValidCountry(this Address address)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(address.Country, "Informe o país.")
            );
        }

        #region used to tests
        public static bool AddressValid(this Address address)
        {
            int result = 0;

            result = ValidNumber(address) ? result : result + 1;
            result = ValidStreet(address) ? result : result + 1;
            result = ValidNeighborhood(address) ? result : result + 1;
            result = ValidCity(address) ? result : result + 1;
            result = ValidState(address) ? result : result + 1;
            result = ValidCountry(address) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
