using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDatPhongKhachSan.model
{
    public partial class db : DbContext
    {
        public db()
            : base("name=db")
        {
        }

        public virtual DbSet<blog> blogs { get; set; }
        public virtual DbSet<booking> bookings { get; set; }
        public virtual DbSet<restaurant> restaurants { get; set; }
        public virtual DbSet<review> reviews { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<room>()
                .HasMany(e => e.bookings)
                .WithRequired(e => e.room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<room>()
                .HasMany(e => e.reviews)
                .WithRequired(e => e.room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.blogs)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.bookings)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reviews)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
