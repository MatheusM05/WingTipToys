using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToys.Models;

namespace WingTipToys.DAL {
    public class ItemVendaDAO {
        static Context ctx = Singleton.Instance.Context;

        public static string retornaCarrinhoId() {
            if (HttpContext.Current.Session["CarrinhoId"] == null) {
                Guid novoGuid = Guid.NewGuid();
                HttpContext.Current.Session["CarrinhoId"] = novoGuid.ToString();
            }

            return HttpContext.Current.Session["CarrinhoId"].ToString();
        }

        public static Int32 retornaTotalItensCarrinho() {
            string carrinhoId = retornaCarrinhoId();

            return ctx.ItensVenda.Where(iv => iv.CarrinhoId.Equals(carrinhoId)).Count();
        }

        public static void delItemVenda(Int32 prodId) {
            string carrinhoId = retornaCarrinhoId();
            ItemVenda iv = ctx.ItensVenda.FirstOrDefault(i => i.CarrinhoId.Equals(carrinhoId) && i.ProdutoId == prodId);
            if (iv.Quantidade == 1) {
                ctx.ItensVenda.Remove(iv);
            }
            while (iv.Quantidade > 1) {
                iv.Quantidade--;
            }
            ctx.SaveChanges();
        }

        public static void addAoCarrinho(Int32 prodId) {
            string carrinhoId = retornaCarrinhoId();
            ItemVenda iv = ctx.ItensVenda.FirstOrDefault(i => i.CarrinhoId.Equals(carrinhoId) && i.ProdutoId == prodId);
            if (iv == null) {
                iv = new ItemVenda();
                iv.Produto = ProdutoDAO.buscarProdutoPorId(prodId);
                iv.ProdutoId = prodId;
                iv.Quantidade = 1;
                iv.Data = DateTime.Now;
                iv.CarrinhoId = retornaCarrinhoId();
                ctx.ItensVenda.Add(iv);
            }
            else {
                iv.Quantidade += 1;
            }
            ctx.SaveChanges();
        }

        public static List<ItemVenda> retornaItensVenda() {
            string carrinhoID = retornaCarrinhoId();

            return ctx.ItensVenda.Where(iv => iv.CarrinhoId.Equals(carrinhoID)).ToList();
            //return ctx.ItensVenda.ToList();
        }

        public static Double calculaTotalCarrinho() {
            Double total = 0;
            foreach (var itemAtual in ItemVendaDAO.retornaItensVenda()) {
                total += (itemAtual.Produto.ProdutoPreco * itemAtual.Quantidade);
            }

            return total;
        }
    }
}