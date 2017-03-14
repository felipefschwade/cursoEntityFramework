using CursoEF.Model;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Documentos\Alura\entityFramework\codigos\cursoEntityFramework\CursoEF\lojaDB.mdf;Integrated Security=True;Connect Timeout=30");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
