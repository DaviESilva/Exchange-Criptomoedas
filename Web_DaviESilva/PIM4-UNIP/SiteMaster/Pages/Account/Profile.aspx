<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="SiteMaster.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Profile">
        <h2 style="color: #fcc0c7; text-shadow: 2px 2px 4px #ea00c2, 0 0 5px #ff89ea">Seja bem vindo(a) ao seu perfil!</h2>
        <br />

        <img src="/images/account_avatar_people_profile_user_icon_123297.png" style="height: 80px;" />

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server">E-mail:</asp:Label><br />
                    <asp:TextBox ID="txtEmail" runat="server" Enabled="false"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDocument" runat="server">Documento:</asp:Label><br />
                    <asp:TextBox ID="txtDocument" runat="server" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUser" runat="server">Usuário:</asp:Label><br />
                    <asp:TextBox ID="txtUser" runat="server" Enabled="false"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblPass" runat="server">Senha:</asp:Label><br />
                    <asp:TextBox ID="txtPass" runat="server" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBithday" runat="server">Data de nascimento:</asp:Label><br />
                    <asp:TextBox ID="txtBirthday" runat="server" Enabled="false"></asp:TextBox>
                </td>
                <td>

<%--IDEIA DE FUNCIONALIDADE  
                    <asp:Button ID="changeData" runat="server" Text="Mudar dados" OnClick="changeData_Click" CssClass=""/>
--%>
                </td>
            </tr>
        </table>

      

        <a href="/Pages/Account/Wallet.aspx" style="height: 35px; margin-top: 20px; font-weight: bold; width: 50px; background-color: #ffa9a9;" class="Submit">
            <input type="button" value="Ver minha carteira" /><br />
            <br />
        </a>

        <div id="containerPopUp" class="popup" runat="server">
            <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
                Style="width: 25px; height: auto;" />
            <asp:TextBox ID="txtCode" runat="server" Enabled="false" Text="" CssClass="text"></asp:TextBox>
        </div>

    </div>
</asp:Content>
