using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Shared.ValueObjects;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Shared.Scopes
{
    public static class DocumentScope
    {
        public static bool ValidTypeDocument(this Document document)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(document.DocumentType.ToString(), "Informe o tipo da empresa: CPF ou CNPJ.")
            );
        }

        public static bool ValidValueDocument(this Document document)
        {
            bool result = false;

            if (document.DocumentType == EDocumentType.CPF)
            {
                result = AssertionConcern.IsValid(
                    AssertionConcern.AssertArgumentNotEmpty(document.DocumentValue, "Informe o CPF."),
                    AssertionConcern.AssertIsCpf(document.DocumentValue, "CPF inválido.")
                );
            }
            else if (document.DocumentType == EDocumentType.CNPJ)
            {
                result = AssertionConcern.IsValid(
                    AssertionConcern.AssertArgumentNotEmpty(document.DocumentValue, "Informe o CNPJ."),
                    AssertionConcern.AssertIsCnpj(document.DocumentValue, "CNPJ inválido.")
                );
            }

            return result;
        }

        #region used to tests
        public static bool DocumentIsValid(this Document document)
        {
            int result = 0;

            result = ValidTypeDocument(document) ? result : result + 1;
            result = ValidValueDocument(document) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
