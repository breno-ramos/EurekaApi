using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class ProductScope
    {
        public static bool ValidName(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(product.Name, 3, 20, "Produto deve possuir mais que 3 até 20 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(product.Name, "Informe o produto.")
            );
        }

        public static bool ValidDescription(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLength(product.Description, 3, 120, "Descrição do produto deve possuir mais que 3 até 120 caracteres."),
                AssertionConcern.AssertArgumentNotEmpty(product.Description, "Informe a descrição do produto.")
            );
        }

        public static bool ValidPrice(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentLessThanOrEquals(product.Price, 0, "Preço do produto não pode ser menor ou igual a zero."),
                AssertionConcern.AssertArgumentNotNull(product.Price, "Informe o preço do produto.")
            );
        }

        public static bool ValidImage(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotNull(product.Images, "Informe ao menos uma imagem do produto."),
                AssertionConcern.AssertArgumentEquals(product.Images.Count, 0, "Informe ao menos uma imagem do produto.")
            );
        }

        public static bool ValidCategory(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotNull(product.Categories, "Informe ao menos uma categoria para o produto."),
                AssertionConcern.AssertArgumentEquals(product.Categories.Count, 0, "Informe ao menos uma categoria para o produto.")
            );
        }

        public static bool ValidBrand(this Product product)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(product.Brand.Name, "Informe a marca.")
            );
        }

        #region used to tests
        public static bool ProductValid(this Product product)
        {
            int result = 0;

            result = ValidName(product) ? result : result + 1;
            result = ValidDescription(product) ? result : result + 1;
            result = ValidPrice(product) ? result : result + 1;
            result = ValidImage(product) ? result : result + 1;
            result = ValidCategory(product) ? result : result + 1;
            result = ValidBrand(product) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
