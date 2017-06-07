<%@ Page Title="Cadastro de Produtos - Wingtip Toys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="cadastroProduto.aspx.cs" Inherits="WingTipToys.Views.cadastroProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 30px 0">
        <%: Title %>
    </div>
    
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label Text="Nome: *" ID="lbl_nome" runat="server" class="control-label col-sm-2" />
            <div class="form-inline">
                <asp:TextBox ID="txt_nome" runat="server" class="form-control" style="width:30%"/>
                <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_nome" ID="req_nome" runat="server" class="text-danger"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Descrição: *" id="lbl_descicao" runat="server" class="control-label col-sm-2"/>
            <div class="form-inline">
                <asp:TextBox ID="txt_descricao" runat="server" class="form-control" style="width:30%" TextMode="MultiLine"/>
                <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_descricao" ID="req_descricao" runat="server" class="text-danger"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Preço: *" id="lbl_preco" runat="server" class="control-label col-sm-2"/>
            <div class="form-inline">
                <asp:TextBox ID="txt_preco" runat="server" class="form-control" style="width:30%"/>
                <asp:RequiredFieldValidator ErrorMessage="Campo Obrigatório!" ControlToValidate="txt_preco" ID="req_preco" runat="server" class="text-danger"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Quantidade: " id="lbl_quantidade" runat="server" class="control-label col-sm-2"/>
            <div class="form-inline">
                <asp:TextBox ID="txt_quantidade" runat="server" class="form-control" style="width:30%"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Imagem: " id="lbl_imagem" runat="server" class="control-label col-sm-2"/>
            <div class="form-inline">
                <asp:FileUpload ID="fup_imagem" runat="server" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Categoria: " id="lbl_categoria" runat="server" class="control-label col-sm-2"/>
            <div class="form-inline">
                <asp:DropDownList id="drp_categorias" runat="server" CssClass="form-control" style="width:30%"/>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 form-inline">
                <asp:Button Text="Salvar" ID="btn_salvar" runat="server" class="btn btn-primary" OnClick="btn_salvar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>