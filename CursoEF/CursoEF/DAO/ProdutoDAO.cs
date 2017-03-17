using CursoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.DAO
{
    class ProdutoDAO
    {
        EntidadesContext Context;
        public ProdutoDAO()
        {
            Context = new EntidadesContext();
        }

        public List<Produto> BuscaPorMaiorEMenorPreco(decimal maior, decimal menor)
        {
            var busca = from p in Context.Produtos select p;

            if (menor > 0) busca = busca.Where(p => p.Preco >= menor);
            if (maior > 0) busca = busca.Where(p => p.Preco <= maior);

            return busca.ToList();
        }

        public List<Produto> BuscaPorNomePrecoECategoria(string nome, decimal preco, string categoria)
        {
            var busca = from p in Context.Produtos select p;

            if (!String.IsNullOrEmpty(nome)) busca = busca.Where(p => p.Nome.Contains(nome));
            if (preco > 0) busca = busca.Where(p => p.Preco == preco);
            if (!String.IsNullOrEmpty(categoria)) busca = busca.Where(p => p.Categoria.Nome.Contains(categoria));

                return busca.ToList();
        }

        public void Salva(Produto produto)
        {
            Context.Produtos.Add(produto);
            Context.SaveChanges();
            Context.Dispose();
        }

        public Produto BuscaPorId(int id)
        {
            return Context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(Produto produto)
        {
            Context.Remove(produto);
            Context.SaveChanges();
        }

    }
}
