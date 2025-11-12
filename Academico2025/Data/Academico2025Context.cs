using Academico2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico2025.Data
{
    public class Academico2025Context : DbContext
    {
        public Academico2025Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos{ get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
    }
}
