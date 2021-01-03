<%@ Page Title="Carteira" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Wallet.aspx.cs" Inherits="SiteMaster.Pages.Account.Wallet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="WalletPage">
        <table>
            <tr>
                <td>
                    <a href="/Pages/Account/Profile.aspx">
                        <asp:Label ID="lblUser" runat="server">Usuário:</asp:Label><br />
                        <img src="/images/account_avatar_people_profile_user_icon_123297.png" style="height: 25px;" />
                        <asp:TextBox ID="txtUser" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
                <td>
                    <a href="/Pages/Crypto/BitcoinPage.aspx">
                        <asp:Label ID="lblBitcoin" runat="server">Bitcoin:</asp:Label><br />
                        <img src="/images/bitcoin_logo_icon_147311.png" style="height: 25px;" />
                        <asp:TextBox ID="txtBitcoin" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="/Pages/Crypto/EthereumPage.aspx">
                        <asp:Label ID="lblEthereum" runat="server">Ethereum:</asp:Label><br />
                        <img src="/images/ethereum.png" style="height: 25px;" />
                        <asp:TextBox ID="txtEthereum" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
                <td>
                    <a href="/Pages/Crypto/DogecoinPage.aspx">
                        <asp:Label ID="lblDoge" runat="server">DogeCoin:</asp:Label><br />
                        <img src="/images/doge.png" style="height: 25px;" />
                        <asp:TextBox ID="txtDoge" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="/Pages/Crypto/TetherPage.aspx">
                        <asp:Label ID="lblUSDT" runat="server">Tether:</asp:Label><br />
                        <img src="/images/usdt.png" style="height: 25px;" />
                        <asp:TextBox ID="txtUSDT" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
                <td>
                    <a href="/Pages/Crypto/XRPPage.aspx">
                        <asp:Label ID="lblXRP" runat="server">XRP:</asp:Label><br />
                        <img src="/images/xrp_cryptocurrency_logo_icon_131379.png" style="height: 25px;" />
                        <asp:TextBox ID="txtXRP" runat="server" Enabled="false"></asp:TextBox>
                    </a>
                </td>
                <td>
            </tr>
        </table>

        <div id="containerPopUp" class="popup" runat="server">
            <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
                Style="width: 25px; height: auto;" />
            <asp:TextBox ID="txtCode" runat="server" Enabled="false" Text="" CssClass="text"></asp:TextBox>
        </div>
    </div>
</asp:Content>
