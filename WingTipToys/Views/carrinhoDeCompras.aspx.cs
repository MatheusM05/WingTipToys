using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys.Views {
    public partial class carrinhoDeCompras : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lbl_total.Text = ItemVendaDAO.calculaTotalCarrinho().ToString("C2");
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<WingTipToys.Models.ItemVenda> grd_carrinho_GetData() {
            return ItemVendaDAO.retornaItensVenda();
        }
    }
}