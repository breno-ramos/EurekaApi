using Eureka.Domain.Entities;
using Eureka.SharedKernel.Validation;

namespace Eureka.Domain.Scopes
{
    public static class BranchScope
    {
        public static bool ValidDescription(this Branch branch)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(branch.Description, "Preencha o ramo."),
                AssertionConcern.AssertArgumentLength(branch.Description, 3, 30, "Ramo deve possuir mais que 3 até 30 caracteres.")
            );
        }

        public static bool ValidStatus(this Branch branch)
        {
            return AssertionConcern.IsValid(
                AssertionConcern.AssertArgumentNotEmpty(branch.Status.ToString(), "Informe o status.")
            );
        }

        #region used to tests
        public static bool BranchValid(this Branch branch)
        {
            int result = 0;

            result = ValidDescription(branch) ? result : result + 1;
            result = ValidStatus(branch) ? result : result + 1;

            return result == 0;
        }
        #endregion
    }
}
