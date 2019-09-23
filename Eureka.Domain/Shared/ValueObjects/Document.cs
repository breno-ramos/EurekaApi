using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Shared.Scopes;

namespace Eureka.Domain.Shared.ValueObjects
{
    public class Document
    {
        public Document(EDocumentType documentType, string documentValue)
        {
            DocumentType = documentType;
            DocumentValue = documentValue;

            this.ValidTypeDocument();
            this.ValidValueDocument();
        }

        public EDocumentType DocumentType { get; private set; }
        public string DocumentValue { get; private set; }
    }
}
