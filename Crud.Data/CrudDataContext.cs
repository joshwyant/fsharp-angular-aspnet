using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Entities;

namespace Crud.Data
{
    class CrudDataContext : DbContext, ICrudDataContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<CrudItem> CrudItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkflowState> WorkflowStates { get; set; }

        public CrudDataContext()
            : base("CrudDataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrudItem>()
                .HasRequired(ci => ci.Category)
                .WithMany(c => c.CrudItems)
                .HasForeignKey(ci => ci.CategoryId);

            modelBuilder.Entity<CrudItem>()
                .HasRequired(ci => ci.WorkflowState)
                .WithMany(ws => ws.CrudItems)
                .HasForeignKey(ci => ci.WorkflowStateId);

            modelBuilder.Entity<CrudItem>()
                .HasRequired(ci => ci.CreatedBy)
                .WithMany(u => u.ItemsCreated)
                .HasForeignKey(ci => ci.CreatedById);

            modelBuilder.Entity<CrudItem>()
                .HasOptional(ci => ci.ReviewingBy)
                .WithMany(u => u.ItemsReviewing)
                .HasForeignKey(ci => ci.ReviewingById);

            modelBuilder.Entity<CrudItem>()
                .HasOptional(ci => ci.CompletedBy)
                .WithMany(u => u.ItemsCompleted)
                .HasForeignKey(ci => ci.CompletedById);

            modelBuilder.Entity<CrudItem>()
                .HasOptional(ci => ci.CanceledBy)
                .WithMany(u => u.ItemsCanceled)
                .HasForeignKey(ci => ci.CanceledById);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users);
        }
    }
}
