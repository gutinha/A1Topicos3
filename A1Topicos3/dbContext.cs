using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace A1Topicos3
{
    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=Connection")
        {
        }

        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogSystem> LogSystem { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Revisao> Revisao { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .HasMany(e => e.Revisao)
                .WithOptional(e => e.Carro)
                .HasForeignKey(e => e.carro_id);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Carro)
                .WithOptional(e => e.Marca)
                .HasForeignKey(e => e.marca_id);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Carro)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.Usuario_id);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Endereco)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.Usuario_id);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Revisao)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.usuario_id);
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
