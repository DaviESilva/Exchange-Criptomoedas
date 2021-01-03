<%@ Page Title="Seja bem vindo(a)!" Language="C#" MasterPageFile="~/UnloggedSite.Master" AutoEventWireup="true" CodeBehind="UnloggedHome.aspx.cs" Inherits="SiteMaster._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body{
            background: url("/images/backgroundimage.jpg") no-repeat fixed;
            background-size: cover;
        }
    </style>

    <div class="ContainerHome">
        <img src="/images/LogoPIMExchange.png" id="imagelogo" />
        
        <div class="ContainerHome2">
            <h1>Compre e venda de<br />Criptomoedas</h1>
            <form name="PaginaPrincipal" action="." method="post">
        
                <h2>Invista hoje, ganhe dinheiro já!</h2>
                <a href="/Pages/Account/Register.aspx">
                <input type="button" class="button1" value="Cadastrar-se" /><br /> <br />
                </a>
                <a href="/Pages/Account/Login.aspx">
                <input type="button" class="button1" value="Fazer login" />
                </a>

            </form>
        </div>
    </div>

</asp:Content>
