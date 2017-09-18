using Crud.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Entities
{
    public class WorkflowState : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }

        public IList<CrudItem> CrudItems { get; set; }

    }
}
