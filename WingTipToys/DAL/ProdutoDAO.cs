using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToys;
using WingTipToys.Models;

namespace WingTipToys.DAL {
    public class ProdutoDAO {
        private static Context cxt = Singleton.Instance.Context;
        public static List<Produto> listaTodosProdutos() {
            return cxt.Produtos.ToList();
        }
        public static List<Produto> listaProdutoEspecifico(Int32 CatID) {
            return cxt.Produtos.Where(c => c.CategoriaId == CatID).ToList();
        }

        public static Produto buscarProdutoPorId(int produtoId) {
            return cxt.Produtos.Find(produtoId);
        }

        public static void cadastraProduto(Produto prod) {
            cxt.Produtos.Add(prod);
            cxt.SaveChanges();
        }
    }
}