<%@ Page Title="Register" Language="C#" MasterPageFile="~/UnloggedSite.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SiteMaster.Account.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background: url("/images/Top-Cryptocurrencies-That-Are-Not-Listed-in-The-Top-100-By-CoinMarketCap.jpg") no-repeat fixed;
            background-size: cover;
        }
    </style>

    <div class="Register">
        <h1>Cadastro</h1>

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblUser" runat="server" Text="Insira seu usuário:" for="txtUsuário"></asp:Label><br />
                    <asp:TextBox ID="txtUser" runat="server" placeholder="Digite seu usuário!" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label><br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite seu e-mail!" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBirthday" runat="server" Text="Data de Nascimento:"></asp:Label><br />
                    <asp:TextBox ID="txtBirthday" runat="server" placeholder="dd/mm/aaaa" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="lblDocument" runat="server" Text="Documento:"></asp:Label><br />
                    <asp:TextBox ID="txtDocument" runat="server" placeholder="12.345.678-9" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPass" runat="server" Text="Sua senha (8 caracteres no minímo):"></asp:Label><br />
                    <asp:TextBox ID="txtPass" runat="server" placeholder="Digite sua senha!" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="lblPassConfirm" runat="server" Text="Confirmar Senha"></asp:Label><br />
                    <asp:TextBox ID="txtPassConfirm" runat="server" placeholder="Confirme sua senha" CssClass="RegisterInput"></asp:TextBox><br />
                    <br />
                </td>
            </tr>

        </table>
        <div class="Terms">
            Ao cliclar em registrar-se você declara que leu e está de acordo com os <a href="/Pages/TermsAndConditions.aspx">Termos e Condições de Serviço!</a>"
        </div>

        <div class="AlreadyRegistered">
            Já possui uma conta? <a href="/Pages/Account/Login.aspx">Faça seu login aqui!</a>
        </div>

        <div id="containerPopUp" class="popup" runat="server">
            <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
                Style="width: 25px;" />
            <asp:TextBox ID="txtCode" runat="server" Enabled="false" Visible="false" Text="" CssClass="text"></asp:TextBox>
        </div>

        <asp:Button ID="RegisterButton" runat="server" Text="Registrar-se" Style="height: 35px" CssClass="Submit" OnClick="RegisterButton_Click" />
    </div>
</asp:Content>
