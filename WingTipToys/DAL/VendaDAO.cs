using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToys.Models;

namespace WingTipToys.DAL {
    public class VendaDAO {
        private static Context ctx = Singleton.Instance.Context;

        public static void addVenda(Venda v) {
            ctx.Vendas.Add(v);
            ctx.SaveChanges();
        }

        public static void deletaVenda(Int32 id) {
            Venda v = ctx.Vendas.FirstOrDefault(vd => vd.VendaId == id);
            ctx.Vendas.Remove(v);
            ctx.SaveChanges();
        }
    }
}