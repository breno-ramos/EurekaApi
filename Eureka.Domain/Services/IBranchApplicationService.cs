using Eureka.Domain.Commands.BranchCommands;
using Eureka.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Services
{
    public interface IBranchApplicationService
    {
        List<Branch> Get(int skip, int take);
        Branch GetById(Guid id);
        Branch Create(CreateBranchCommand branch);
        Branch Update(CreateBranchCommand branch);
        Branch Delete(Guid id);
    }
}
