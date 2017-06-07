using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys {
    public partial class produtos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<WingTipToys.Models.Produto> lst_produtos_GetData() {
            try {
                Int32 catId = Int32.Parse(Request.QueryString["CategoriaId"]);

                Context ctx = new Context();
                if (catId > 0 && catId <= ctx.Categorias.Count()) {
                    return ProdutoDAO.listaProdutoEspecifico(catId);
                }
                else {
                    return ProdutoDAO.listaTodosProdutos();
                }
            }
            catch (Exception) {
                return ProdutoDAO.listaTodosProdutos();
            }
        }
    }
}