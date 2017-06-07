<%@ Page Title="Descrição Produto - Wingtip Toys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="descricaoProduto.aspx.cs" Inherits="WingTipToys.Views.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="margin: 0px auto">
        <asp:FormView runat="server" ID="frm_detalheProduto" ItemType="WingTipToys.Models.Produto" SelectMethod="frm_detalheProduto_GetItem">
            <ItemTemplate>
                <div style="margin: 0 auto; text-align: left; width: 50%">
                    <h1 style="margin: 30px 20px"><%# Item.ProdutoNome %></h1>
                </div>
                <%--<div class="col-md-2 col-sm-1"></div>--%>
                <div class="col-md-6 col-sm-12" style="text-align: center">
                    <img src="<%#: "/Images/" + Item.ProdutoImagem %>" style="border: 2px solid; height: 300px; width: 300px" />
                </div>
                <div class="col-md-6 col-sm-12" style="padding: 0px 10px">
                    <b>Descrição:</b><br />
                    <p><%# Item.ProdutoDescricao %></p>

                    <p><b>Preço: </b><%# Item.ProdutoPreco.ToString("C2") %></p>

                    <p><b>Quantidade: </b><%# Item.ProdutoQuantidade %></p>

                    <a href="addAoCarrinho.aspx?ProdutoId=<%# Item.ProdutoId %>" class="btn btn-primary" style="padding: 5px; height: 35px">+ Carrinho</a>
                </div>
                <%--<div class="col-md-2 col-sm-1"></div>--%>
            </ItemTemplate>
        </asp:FormView>
    </div>
</asp:Content>
