using CursoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    class UsuarioDAO
    {
        private EntidadesContext Context;
        public UsuarioDAO()
        {
            this.Context = new EntidadesContext();
        }

    
        public void Salva(Usuario usuario)
        {
            Context.Usuarios.Add(usuario);
            Context.SaveChanges();
            Context.Dispose();
        }

        public Usuario BuscaPorId(int id)
        {
            return Context.Usuarios.FirstOrDefault(u => u.ID == id);
        }
        
        public void Remove(Usuario usuario)
        {
            Context.Remove(usuario);
            Context.SaveChanges();
        }

    }
}
