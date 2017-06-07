using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingTipToys.Models;

namespace WingTipToys.DAL {
    public class CategoriaDAO {
        private static Context ctx = Singleton.Instance.Context;
        public static List<Categoria> listaTodasCategorias() {
            return ctx.Categorias.ToList();
        }

        public static void cadastraCategoria(Categoria cat) {
            ctx.Categorias.Add(cat);
            ctx.SaveChanges();
        }

        public static Categoria buscarCategoriaPorId(int categoriaID) {
            return ctx.Categorias.Find(categoriaID);
        }
    }
}