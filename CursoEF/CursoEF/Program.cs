using CursoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();
            Usuario felipe = new Usuario() { Nome = "Felipe", Senha = "123" };
            contexto.Usuarios.Add(felipe);
            contexto.SaveChanges();
            contexto.Dispose();
            Console.WriteLine("salvou");
            Console.ReadKey();
        }
    }
}
