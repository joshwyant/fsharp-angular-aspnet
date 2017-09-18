using Crud.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Roles = new List<Role>();
            ItemsCreated = new List<CrudItem>();
            ItemsReviewing = new List<CrudItem>();
            ItemsCompleted = new List<CrudItem>();
            ItemsCanceled = new List<CrudItem>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Username { get; set; }

        public IList<Role> Roles { get; set; }

        public IList<CrudItem> ItemsCreated { get; set; }
        public IList<CrudItem> ItemsReviewing { get; set; }
        public IList<CrudItem> ItemsCompleted { get; set; }
        public IList<CrudItem> ItemsCanceled { get; set; }
    }
}
