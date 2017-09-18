using Crud.Data.Contracts;
using Crud.Data.Contracts.Repositories;
using Crud.Data.Entities;
using Crud.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data
{
    class CrudUnitOfWork : ICrudUnitOfWork
    {
        public ICategoryRepository Categories { get; private set; }
        public ICrudItemRepository CrudItems { get; private set; }
        public IRoleRepository Roles { get; private set; }
        public IUserRepository Users { get; private set; }
        public IWorkflowStateRepository WorkflowStates { get; private set; }

        ICrudDataContext context;
        public CrudUnitOfWork(ICrudDataContext context)
        {
            this.context = context;
            Categories = new CategoryRepository(context);
            CrudItems = new CrudItemRepository(context);
            Roles = new RoleRepository(context);
            Users = new UserRepository(context);
            WorkflowStates = new WorkflowStateRepository(context);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
