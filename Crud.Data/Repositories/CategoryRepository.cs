using Crud.Data.Contracts.Repositories;
using Crud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Repositories
{
    class CategoryRepository : EntityRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ICrudDataContext context) : base(context) { }
    }
}
