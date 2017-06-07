<%@ Page Title="Carrinho de Compras - WingTipToys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="carrinhoDeCompras.aspx.cs" Inherits="WingTipToys.Views.carrinhoDeCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><%: Title %></h1>
    <asp:GridView runat="server" ID="grd_carrinho" ItemType="WingTipToys.Models.ItemVenda" SelectMethod="grd_carrinho_GetData" AutoGenerateColumns="false" CssClass="table table-bordered table-hover">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="ProdutoId" />
            <asp:BoundField HeaderText="Produto" DataField="Produto.ProdutoNome" />
            <asp:BoundField HeaderText="Categoria" DataField="Produto.Categoria.CategoriaNome" />
            <asp:BoundField HeaderText="Quantidade" DataField="Quantidade" />
            <asp:BoundField HeaderText="Preço" DataField="Produto.ProdutoPreco" DataFormatString="{0:C}" />

            <asp:TemplateField HeaderText="Subtotal">
                <ItemTemplate>
                    <%#: (Item.Quantidade * Item.Produto.ProdutoPreco).ToString("C2") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ações">
                <ItemTemplate>
                    <a href="deletaItemVenda.aspx?ProdutoId=<%# Item.ProdutoId %>">
                        <img src="/Images/deleta.png" /></a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <span class="label label-primary" style="font-size: 22px; right: 100px; position: absolute">
        <asp:Label Text="" ID="lbl_total" runat="server" />
    </span>
    <br /><br />
    <span class="label label-primary" style="font-size: 22px; right: 100px; position: absolute">
        <a href="listaProdutos.aspx" style="color:#fff">Continuar Comprando</a>
    </span><br /><br />
    <span class="label label-primary" style="font-size: 22px; right: 100px; position: absolute">
        <a href="finalizaCompra.aspx" style="color:#fff">Finalizar Compra</a>
    </span>
</asp:Content>
