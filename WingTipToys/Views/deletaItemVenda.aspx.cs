using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;

namespace WingTipToys.Views {
    public partial class deletaItemVenda : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                Int32 prodId = Int32.Parse(Request.QueryString["ProdutoId"]);
                ItemVendaDAO.delItemVenda(prodId);
            }
            catch (Exception) {
                Response.Redirect("carrinhoDeCompras.aspx");
            }
            Response.Redirect("carrinhoDeCompras.aspx");
        }
    }
}