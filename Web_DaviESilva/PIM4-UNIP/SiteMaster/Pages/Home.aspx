<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SiteMaster.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="color: #fed2d7; text-shadow: 2px 2px 4px #fc03d1, 0 0 5px #ff89ea; text-align: center;display: inline">Bem vindo </h1>
    <asp:TextBox ID="txtUsername" runat="server" Enabled="false" Style="border: none; text-shadow: 2px 2px 4px #fc03d1, 0 0 5px #ff89ea;
font-size: 32px; color: #fed2d7; text-align:center; justify-content: center"></asp:TextBox>
    <br />

    <div class="row" style="margin-top: 30px;">
        <div class="Column">
        <div class="HomeBlock"; style="margin-bottom:40px;">            
            <h3>Atualizações recentes!</h3>
            <p>-Visualização em tempo real do mercado!</p>
            <br />
            <p>-Mudança nos termos de uso e político</p>
            <br />
            <p>-Melhorias do cache e dos cookies do site!</p>
        </div>
        </div>
    </div>
    <div class="Column" style="margin-top: 21px;">
        <div class="YellowBlock1">
            <div class="Column2">
                <h3>Bitcoin BTC</h3>
                <asp:TextBox ID="txtBitcoin" runat="server" Enabled="false"></asp:TextBox> <br />
                <asp:TextBox ID="txtBtcUsd" runat="server" Enabled="false"></asp:TextBox>
                <h3>R$: 100.251,01</h3>
            </div>
        </div>

        <div class="Column2">
            <div class="Yelloblock2">
                <h3>Ethereum ETH</h3>
                <asp:TextBox ID="txtEthereum" runat="server" Enabled="false"></asp:TextBox> <br />
                <asp:TextBox ID="txtEthUsd" runat="server" Enabled="false"></asp:TextBox>
                <h3>R$:
                        2.383,09</h3>
            </div>
        </div>
    </div>

    <br />
    <div class="SocialMedia" style="margin-top: 300px; text-align: center">
        <img src="/images/github_87698.png" style="height: 40px; margin-right: 30px;" />
        <img src="/images/facebook_108044.png" style="height: 40px; margin-right: 30px;" />
        <img src="/images/Twitter_icon-icons.com_60507.png" style="height: 40px; margin-right: 30px;" />
    </div>

    <div id="containerPopUp" class="popup" runat="server">
        <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
            Style="width: 25px; height: auto;" />
        <asp:TextBox ID="txtCode" runat="server" Enabled="false" Text="" CssClass="text"></asp:TextBox>
    </div>

</asp:Content>
