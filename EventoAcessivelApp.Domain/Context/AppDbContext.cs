using EventoAcessivelApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoAcessivelApp.Domain.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual void AddOrUpdate(object entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Update(entity);
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interprete>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Empresa>()
                .HasKey(m => m.Id);
        }

    }
}
