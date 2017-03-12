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
            Usuario outro = dao.BuscaPorId(4);
            dao.Remove(outro);
            Console.WriteLine("Removeu!");
            Console.ReadKey();
        }
    }
}
