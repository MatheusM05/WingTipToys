using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys.Views {
    public partial class cadastroCategoria : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_salvar_Click(object sender, EventArgs e) {
            Categoria cat = new Categoria();
            cat.CategoriaNome = txt_nome.Text;

            CategoriaDAO.cadastraCategoria(cat);
            Response.Redirect("cadastroCategoria.aspx");
        }
    }
}