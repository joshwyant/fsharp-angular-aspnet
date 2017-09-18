using Crud.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Entities
{
    public class CrudItem : IEntity
    {
        [Key]
        public int Id { get; set; }
        
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int WorkflowStateId { get; set; }
        public WorkflowState WorkflowState { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int? ReviewingById { get; set; }
        public User ReviewingBy { get; set; }
        public DateTime? ReviewingDate { get; set; }
    
        public int? CompletedById { get; set; }
        public User CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }

        public int? CanceledById { get; set; }
        public User CanceledBy { get; set; }
        public DateTime? CanceledDate { get; set; }

    }
}
