namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TGDDDbContext : DbContext
    {
        public TGDDDbContext()
            : base("name=TGDDDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.Slug)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.SeoTitle)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.Slug)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Slug)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.Image)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.Link)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();
        }
    }
}
