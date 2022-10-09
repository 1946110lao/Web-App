using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TheBigZuydChallenge.Models
{
    public partial class MakeAdventure : DbContext
    {
        public MakeAdventure()
            : base("name=MakeAdventure2")
        {
        }

        public virtual DbSet<Adventure> Adventures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adventure>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.Tag1)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.Tag2)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.Tag3)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.Costs)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.IdealTime)
                .IsUnicode(false);

            modelBuilder.Entity<AdminReview>()
               .Property(e => e.Duration)
               .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.Size)
                .IsUnicode(false);


            modelBuilder.Entity<Adventure>()
               .Property(e => e.Description)
               .IsUnicode(false);
        }
    }
}
