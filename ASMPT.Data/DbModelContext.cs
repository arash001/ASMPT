
using ASMPT.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Reflection;

namespace ASMTP.Data
{
    public class DbModelContext : DbContext
    {
        public DbModelContext(DbContextOptions<DbModelContext> options)
       : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Borrow> Borrows { get; set; }


        public class StudentConfiguration : IEntityTypeConfiguration<Student>
        {
            public void Configure(EntityTypeBuilder<Student> builder)
            {
                builder
                    .HasOne(s => s.Address)
                    .WithOne(a => a.Student)
                    .HasForeignKey<Address>(a => a.Id);

                // Other configurations for Student entity
                builder.Property(s => s.Name).IsRequired();
                builder.Property(s => s.Surename).IsRequired();
                builder.Property(s => s.Email);

                // Additional configurations as needed
            }
        }

        public class AddressConfiguration : IEntityTypeConfiguration<Address>
        {
            public void Configure(EntityTypeBuilder<Address> builder)
            {
                // Other configurations for Address entity
                builder.Property(a => a.Street).IsRequired();
                builder.Property(a => a.HouseNumber);
                builder.Property(a => a.PostalCode);
                builder.Property(a => a.City);

                // Additional configurations as needed
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>()
             .HasMany(o => o.Book)            
             .WithOne(oi => oi.Author)                
             .HasForeignKey(oi => oi.AuthorId);
        }

    }
}