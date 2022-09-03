using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Domain.Models;
using Escola.Infra.DataBase.Mappings;
using Microsoft.Extensions.Configuration;

namespace Escola.Infra.DataBase
{
    public class EscolaDBContexto : DbContext
    {
        private readonly IConfiguration _configuration;

        public EscolaDBContexto(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Boletim> Boletins {get; set;}  
        public DbSet<Materia> Materias { get; set; }
        public DbSet<NotasMateria> NotasMaterias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);

            options.UseSqlServer(
                _configuration.GetConnectionString("ConexaoBanco")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new AlunoMap());

            modelBuilder.ApplyConfiguration(new BoletimMap());

            modelBuilder.ApplyConfiguration(new MateriaMap());

            modelBuilder.ApplyConfiguration(new NotasMateriaMap());
        }
    }
}