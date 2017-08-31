namespace Example1Snippet.fonts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Example1Snippet.Models;

    /// <summary>
    /// I kan bruges jeres egen DbContext også
    /// </summary>
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<NewsPost> NewsPosts { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
