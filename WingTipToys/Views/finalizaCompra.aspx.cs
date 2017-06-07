using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToys.DAL;
using WingTipToys.Models;

namespace WingTipToys.Views {
    public partial class finalizaCompra : System.Web.UI.Page {
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

        protected void btn_salvar_Click(object sender, EventArgs e) {
            Cliente cli = new Cliente();
            cli.Nome = txt_nome.Text;
            cli.Endereco = txt_endereco.Text;
            cli.Telefone = txt_telefone.Text;

            ClienteDAO.addCliente(cli);

            Venda vd = new Venda();
            vd.ClienteId = ClienteDAO.retornaIdCliente(txt_nome.Text);
            vd.CarrinhoId = ItemVendaDAO.retornaCarrinhoId();
            vd.Data = DateTime.Now;

            VendaDAO.addVenda(vd);

            Response.Redirect("index.aspx?VendaFinalizada=1");
        }

        protected void btn_voltar_Click(object sender, EventArgs e) {
            Response.Redirect("carrinhoDeCompras.aspx");
        }
    }
}