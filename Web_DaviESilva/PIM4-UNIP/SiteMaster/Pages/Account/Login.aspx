<%@ Page Title="Login" Language="C#" MasterPageFile="~/UnloggedSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiteMaster.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background: url("/images/convertendo-dinheiro-bitcoin-real.jpg") no-repeat fixed;
            background-size: cover;
        }
    </style>

    <div class="LoginBlock">
        <h2>Venha ser feliz com a gente!<br />
            Começe a investir agora!</h2>

        <asp:TextBox ID="txtlogin" runat="server" placeholder="Usuário"></asp:TextBox>
        <br />

        <asp:TextBox ID="txtPass" runat="server" placeholder="Senha" Style="margin-top: 20px;"></asp:TextBox>
        <br />

        <div class="KeepLogged">
            <input type="checkbox" id="KeepLogged" name="KeepLogged"/>
            <label for="KeepLogged">Lembrar de mim</label>
        </div>

        <asp:Button ID="button" runat="server" Text="Login" onclick="btnLogin_Click"/>
        <br />

        <div class="Forgot">
            <a href="ForgotPassword.aspx">Esqueci minha senha</a>
            <br />
        </div>

        <p>Não possui uma conta? <a href="Register.aspx">Criar Conta</a> </p>
    </div>

    <div id="containerPopUp" class="popup" runat="server">
        <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
            Style="width: 25px; height:auto;" />
        <asp:TextBox ID="txtCode" runat="server" Enabled="false" Text="" CssClass="text"></asp:TextBox>
    </div>

</asp:Content>
