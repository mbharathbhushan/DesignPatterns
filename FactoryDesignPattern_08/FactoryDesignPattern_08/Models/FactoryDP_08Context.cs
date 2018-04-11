using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FactoryDesignPattern_08.Models
{
    public partial class FactoryDP_08Context : DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server=.;Database=FactoryDP_08;Trusted_Connection=True;");
        //            }
        //        }

        public FactoryDP_08Context(DbContextOptions<FactoryDP_08Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.HourlyPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_EmployeeType");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("Employee_Type");

                entity.Property(e => e.EmployeeType1)
                    .IsRequired()
                    .HasColumnName("EmployeeType")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
