<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TetherPage.aspx.cs" Inherits="SiteMaster.Pages.Crypto.TetherPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="CryptoPage">
        <tr>
            <td>
                <div class="blue-container">
                    <img class="image-crypto" src="/images/usdt.png" alt="Logo da Criptomoeda" />
                    <div class="title-crypto">
                        Tether<br>
                        USDT<br>
                    </div>
                    <div class="prices">
                        <label for="">R$5,35 BRL</label>
                        <br />
                        <label for="">$0.99 USD</label>
                    </div>
                </div>
            </td>
            <td>
                <!--Inicio do card comprar-->
                <div class="BuyCard">
                    <div class="Top">
                        <h2>Comprar</h2>
                        <img src="/images/bitcoin-15486.png" alt="Comprar mini-logo" class="BuyLogo" style="height: 50px" />
                    </div>
                    <%-- Carteira --%>
                    <div class="wallet" style="float: right;">
                        Carteira:
                        <br />

                        <asp:TextBox ID="WalletBalance1" runat="server" Enabled="false"></asp:TextBox>
                    </div>

                    <br />
                    <br />
                    <br />
                    Comprar:

                    <div class="Input">
                        <asp:TextBox ID="InputBuy" runat="server"></asp:TextBox>
                    </div>
                    <div class="btn">
                        <asp:Button ID="btnClear1" class="btnClear" runat="server" Text="Limpar" OnClick="BuyClear_Click" />
                        <asp:Button ID="btnSend1" class="btnSend" runat="server" Text="Confirmar" OnClick="BuySend_Click" />
                    </div>
                </div>
                <!--FInal do card de compra-->
            </td>
        </tr>
        <tr>
            <td>
                <%--Inicio do Gráfico--%>
                <div class="grafic">
                    <img class="grafic" src="/images/grafico.png" alt="Gráfico da criptomoeda">
                </div>
                <%--Fim do gráfico--%>
            </td>
            <td>
                <!--Inicio do card vender-->
                <div class="SellCard">
                    <div class="Top">
                        <h2>Vender</h2>
                        <img src="/images/money-icons-6117.png" alt="Vender mini-logo" class="SellLogo" style="height: 50px" />
                    </div>

                    <%-- Carteira --%>
                    <div class="wallet"; style="float:right;">
                        Carteira:
                        <br>

                    <asp:TextBox ID="WalletBalance2" runat="server" Enabled="false"></asp:TextBox>
                </div>
                <br>
                <br />
                <br />
                Vender:
            <div class="InputLogo">
                <%--Logo Cripto--%>
            </div>

                <div class="Input">
                    <asp:TextBox ID="InputSell" runat="server"></asp:TextBox>
                </div>
                <div class="btn">
                    <asp:Button ID="btnClear2" class="btnClear" runat="server" Text="Limpar" OnClick="SellClear_Click" />
                    <asp:Button ID="btnSend2" class="btnSend" runat="server" Text="Confirmar" OnClick="SellSend_Click" />
                </div>
                </div>
                <!--FInal do card de vender-->
            </td>
        </tr>
    </table>

    <br />

    <div id="containerPopUp" class="popup" runat="server">
        <asp:Button ID="closePopup" runat="server" Text="X " OnClick="ClosePopup_Click" CssClass="btnClose"
            Style="width: 25px; height: auto;" />
        <asp:TextBox ID="txtCode" runat="server" Enabled="false" Text="" CssClass="text"></asp:TextBox>
    </div>
</asp:Content>
