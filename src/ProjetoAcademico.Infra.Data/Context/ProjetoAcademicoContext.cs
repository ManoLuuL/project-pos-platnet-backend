using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjetoAcademico.Domain.Entities;
using ProjetoAcademico.Infra.CrossCutting.NotificationPattern.DTOs;

namespace ProjetoAcademico.Infra.Data.Context
{
    public class ProjetoAcademicoContext(
        DbContextOptions<ProjetoAcademicoContext> options) : DbContext(options)
    {
        public DbSet<Curso> CursoSet { get; set; }
        public DbSet<Professor> ProfessorSet { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
