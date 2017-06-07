using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys.Views {
    public partial class cadastroProduto : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                drp_categorias.DataSource = CategoriaDAO.listaTodasCategorias();
                drp_categorias.DataTextField = "CategoriaNome";
                drp_categorias.DataValueField = "CategoriaId";
                drp_categorias.DataBind();
            }
        }

        protected void btn_salvar_Click(object sender, EventArgs e) {
            Produto prod = new Produto();
            prod.ProdutoNome = txt_nome.Text;
            prod.ProdutoDescricao = txt_descricao.Text;
            prod.ProdutoPreco = Convert.ToDouble(txt_preco.Text);
            prod.ProdutoQuantidade = Convert.ToInt32(txt_quantidade.Text);

            if (fup_imagem.HasFile) {
                fup_imagem.SaveAs(Server.MapPath("../Images/" + fup_imagem.FileName));
                prod.ProdutoImagem = fup_imagem.FileName;
            }
            else {
                prod.ProdutoImagem = "semImagem.jpg";
            }

            prod.CategoriaId = Convert.ToInt32(drp_categorias.SelectedValue);
            prod.Categoria = CategoriaDAO.buscarCategoriaPorId(prod.CategoriaId);

            ProdutoDAO.cadastraProduto(prod);
            Response.Redirect("listaProdutos.aspx?CategoriaId=" + prod.CategoriaId);
        }
    }
}