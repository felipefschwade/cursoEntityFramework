using CursoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.DAO
{
    class CategoriaDAO
    {
        EntidadesContext Context;
        public CategoriaDAO()
        {
            Context = new EntidadesContext();
        }

        public void Salva(Categoria categoria)
        {
            Context.Categorias.Add(categoria);
            Context.SaveChanges();
            Context.Dispose();
        }

        public Categoria BuscaPorId(int id)
        {
            return Context.Categorias.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(Categoria categoria)
        {
            Context.Remove(categoria);
            Context.SaveChanges();
        }

    }
}
