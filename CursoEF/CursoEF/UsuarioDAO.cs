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
            this.Context.Usuarios.Add(usuario);
            Context.SaveChanges();
            Context.Dispose();
        }

    }
}
