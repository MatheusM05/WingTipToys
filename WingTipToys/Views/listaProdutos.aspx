<%@ Page Title="Produtos - Wingtip Toys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="listaProdutos.aspx.cs" Inherits="WingTipToys.produtos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Produtos</h2>
    <br />
    <div class="container-fluid">
        <asp:ListView runat="server" ID="lst_produtos" ItemType="WingTipToys.Models.Produto" SelectMethod="lst_produtos_GetData">
            <ItemTemplate>
                <div class="col-md-3 col-sm-4" style="text-align: center; margin-bottom: 30px">
                    <a href="descricaoProduto.aspx?ProdutoId=<%# Item.ProdutoId %>">
                        <img src="<%#: "/Images/" + Item.ProdutoImagem %>" style="width: 200px; height: 200px" /><br />
                        <%#: Item.ProdutoNome %></a><br />
                    <%#: Item.ProdutoPreco.ToString("C2") %><br />
                    <a href="addAoCarrinho.aspx?ProdutoId=<%# Item.ProdutoId %>" class="btn btn-primary" style="padding: 5px; height: 35px">+ Carrinho</a>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
