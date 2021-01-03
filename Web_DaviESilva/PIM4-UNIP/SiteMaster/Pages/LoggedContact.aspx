<%@ Page Title="Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoggedContact.aspx.cs" Inherits="SiteMaster.LoggedContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="ContactContainer">
    <h3>Entre em contato diretamente conosco!</h3>

    <form name="Contact" action="#" method="post">
        <label for="txtEmail">Seu Email:</label><br />
        <input type="email" id="txtEmail" name="txtEmail" placeholder="Digite seu e-mail!" required /><br /><br />

        <label for="txtMessage">Sua Mensagem:</label><br /> 
        <textarea maxlength="1000" name="txtMessage" id="txtMessage" required style="resize:none;"></textarea><br />

        <input type="submit" value="Enviar Mensagem" class="Submit" style="height: 35px"/>
    </form>
    </div>    

    <div class="SocialMedias">
        <img src="/images/github_87698.png" /> <a>GitHub.com/PIMExchange</a> 
        <br />
        <img src="/images/Twitter_icon-icons.com_60507.png" /> <a>Twitter.com/@PIMExchange</a>
        <br />
        <img src="/images/facebook_108044.png" /> <a>Facebook.com/PIMExchange</a>
        <br />
        <img src="/images/Email_30017.png" /> <a>Contato@PIMExchange.com</a>
        <br />
    </div>
</asp:Content>
