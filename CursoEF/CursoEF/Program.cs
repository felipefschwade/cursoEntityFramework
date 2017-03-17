using CursoEF.DAO;
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
            var dao = new ProdutoDAO();
            var busca = dao.BuscaPorNomePrecoECategoria(null , 0, "Informatica");
            foreach (var p in busca.ToList())
            {
                Console.WriteLine(p.Nome + p.Preco);
            }
            Console.WriteLine("####### BUSCA 2 ########");
            busca = dao.BuscaPorMaiorEMenorPreco(200, 0);
            foreach (var p in busca.ToList())
            {
                Console.WriteLine(p.Nome + p.Preco);
            }
            Console.ReadKey();
        }
    }
}
