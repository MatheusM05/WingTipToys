using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;

namespace WingTipToys.Views {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public WingTipToys.Models.Produto frm_detalheProduto_GetItem() {
            int produtoId = Convert.ToInt32(Request.QueryString["ProdutoId"]);
            return ProdutoDAO.buscarProdutoPorId(produtoId);
        }
    }
}