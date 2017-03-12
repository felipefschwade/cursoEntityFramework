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
            UsuarioDAO dao = new UsuarioDAO();
            Usuario outro = new Usuario() { Nome = "Outro", Senha = "123" };
            dao.Salva(outro);
            Console.WriteLine("salvou");
            Console.ReadKey();
        }
    }
}
