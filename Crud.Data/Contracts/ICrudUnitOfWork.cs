using Crud.Data.Contracts.Repositories;
using Crud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Contracts
{
    public interface ICrudUnitOfWork
    {
        ICategoryRepository Categories { get; }
        ICrudItemRepository CrudItems { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        IWorkflowStateRepository WorkflowStates { get; }

        int SaveChanges();
    }
}
