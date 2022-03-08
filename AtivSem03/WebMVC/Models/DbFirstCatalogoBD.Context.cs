namespace WebMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CatalogoBDEntities : DbContext
    {
        public CatalogoBDEntities()
            : base("name=CatalogoBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Filmes> Filmes { get; set; }
        public virtual DbSet<Series> Series { get; set; }
    }
}
