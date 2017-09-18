using Crud.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            CrudItems = new List<CrudItem>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CrudItem> CrudItems { get; set; }
    }
}
