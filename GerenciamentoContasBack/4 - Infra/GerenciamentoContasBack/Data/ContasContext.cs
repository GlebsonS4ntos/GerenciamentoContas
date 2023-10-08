using GerenciamentoContasBack.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Infra.Data
{
    public class ContasContext : DbContext
    {
        public DbSet<TipoConta> TiposContas { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<PagamentoMensal> PagamentosMensais { get; set; }

        public ContasContext(DbContextOptions<ContasContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<TipoConta>().HasOne(tp => tp.Conta)
                   .WithMany(c => c.TiposContas).HasForeignKey(tp => tp.ContaId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TipoConta>().HasOne(tp => tp.Tipo)
                    .WithMany(t => t.TiposContas).HasForeignKey(tp => tp.TipoId).OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PagamentoMensal>().HasOne(pm => pm.Conta)
                    .WithMany(c => c.PagementosMensais).HasForeignKey(pm => pm.ContaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
