using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToys.Models;

namespace WingTipToys.DAL {
    public class ClienteDAO {
        private static Context ctx = Singleton.Instance.Context;
        public static void addCliente(Cliente c) {
            ctx.Clientes.Add(c);
            ctx.SaveChanges();
        }

        public static void deletaCliente(Int32 id) {
            Cliente c = ctx.Clientes.FirstOrDefault(cl => cl.ClienteId == id);
            ctx.Clientes.Remove(c);
            ctx.SaveChanges();
        }

        public static Int32 retornaIdCliente(string nomeCliente) {
            Cliente c = ctx.Clientes.FirstOrDefault(cl => cl.Nome.Equals(nomeCliente));
            return c.ClienteId;
        }
    }
}