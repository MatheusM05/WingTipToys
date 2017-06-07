<%@ Page Title="Cadastro de Categorias - Wingtip Toys" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="cadastroCategoria.aspx.cs" Inherits="WingTipToys.Views.cadastroCategoria" %>
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
            <div class="col-sm-offset-2 form-inline">
                <asp:Button Text="Salvar" ID="btn_salvar" runat="server" class="btn btn-primary" OnClick="btn_salvar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
