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
            var contexto = new EntidadesContext();
            var c = new Categoria
            {
                Nome = "Informatica"
            };
            contexto.Categorias.Add(c);
            contexto.SaveChanges();
            var produto = new Produto
            {
                Preco = 20,
                Nome = "Mouse",
                Categoria = c
            };
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
    }
}
