using System;
using WingTipToys.DAL;

namespace WingTipToys.Views {
    public partial class addAoCarrinho : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                Int32 prodId = Int32.Parse(Request.QueryString["ProdutoId"]);
                ItemVendaDAO.addAoCarrinho(prodId);
            }
            catch (Exception) {
                Response.Redirect("listaProdutos.aspx");
            }
            Response.Redirect("carrinhoDeCompras.aspx");
        }
    }
}