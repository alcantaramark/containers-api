using System;
using containers_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace containers_api
{
    public class ContainersApiDbContext : DbContext
    {
        public ContainersApiDbContext(DbContextOptions<ContainersApiDbContext> options)
            :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            configureEmployees(modelBuilder.Entity<Employee>());
        }

        private void configureEmployees(EntityTypeBuilder<Employee> employee)
        {
            employee.HasKey(_ => _.Id);
            employee.ToTable("employee");

            employee.Property(_ => _.Id).HasColumnName("id");
            employee.Property(_ => _.Name).HasColumnName("name");
            employee.Property(_ => _.Title).HasColumnName("title");
        }
    }
}

