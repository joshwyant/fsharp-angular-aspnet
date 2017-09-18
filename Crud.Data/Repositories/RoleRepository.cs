using Crud.Data.Contracts.Repositories;
using Crud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Repositories
{
    class RoleRepository : EntityRepository<Role>, IRoleRepository
    {
        public RoleRepository(ICrudDataContext context) : base(context) { }
    }
}
