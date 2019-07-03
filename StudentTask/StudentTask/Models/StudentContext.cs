namespace StudentTask.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=StudentContext")
        {
        }

        public virtual DbSet<course_questions> course_questions { get; set; }
        public virtual DbSet<courses> courses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user_course> user_course { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<courses>()
                .HasMany(e => e.course_questions)
                .WithRequired(e => e.courses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<courses>()
                .HasMany(e => e.user_course)
                .WithRequired(e => e.courses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_course>()
                .Property(e => e.degree)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .HasMany(e => e.user_course)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);
        }
    }
}
