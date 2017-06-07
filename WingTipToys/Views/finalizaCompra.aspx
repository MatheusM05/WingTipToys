<%@ Page Title="Finalização de compra - WingTipToys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="finalizaCompra.aspx.cs" Inherits="WingTipToys.Views.finalizaCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><%: Title %></h1>
    <br />

    <div">
        <h2>Cadastre seus dados:</h2>
        <div class="form-horizontal" style="margin-left:50px">
            <div class="form-group">
                <strong>
                    <asp:Label Text="Nome: " runat="server" ID="lbl_nome" Style="width: 200px;" /></strong>
                <div class="form-inline">
                    <asp:TextBox runat="server" ID="txt_nome" Width="30%" />
                    <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_nome" ID="req_nome" runat="server" class="text-danger" />
                </div>
            </div>
            <div class="form-group">
                <strong>
                    <asp:Label Text="Endereço: " runat="server" ID="lbl_endereco" /></strong>
                <div class="form-inline">
                    <asp:TextBox runat="server" ID="txt_endereco" Width="30%" />
                    <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_endereco" ID="req_endereco" runat="server" class="text-danger" />
                </div>
            </div>
            <div class="form-group">
                <strong>
                    <asp:Label Text="Telefone: " runat="server" ID="lbl_telefone" /></strong>
                <div class="form-inline">
                    <asp:TextBox runat="server" ID="txt_telefone" Width="30%" />
                    <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_telefone" ID="req_telefone" runat="server" class="text-danger" />
                </div>
            </div>
        </div>
        <br />

            <h2>Revise seus itens:</h2>
        <div  style="margin:0px 50px">
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
                </Columns>
            </asp:GridView>
        </div>
        <span class="label label-primary" style="font-size: 22px; right: 100px; position: absolute">
            <asp:Label Text="" ID="lbl_total" runat="server" />
        </span><br /><br />
        <div style="right: 100px; position: absolute">
            <asp:Button Text="Voltar ao Carrinho" ID="btn_voltar" runat="server" class="btn btn-primary" OnClick="btn_voltar_Click" CausesValidation="false"/>
            <asp:Button Text="Finalizar" ID="btn_salvar" runat="server" class="btn btn-primary" OnClick="btn_salvar_Click" />
        </div>
    </div>
</asp:Content>
