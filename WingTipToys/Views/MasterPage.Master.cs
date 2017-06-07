using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys.Views {
    public partial class MasterPage : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            lbl_itensCarrinho.Text = ItemVendaDAO.retornaTotalItensCarrinho().ToString();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<WingTipToys.Models.Categoria> lst_categorias_GetData() {
            return CategoriaDAO.listaTodasCategorias();
        }
    }
}