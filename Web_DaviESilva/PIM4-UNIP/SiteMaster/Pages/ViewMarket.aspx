<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewMarket.aspx.cs" Inherits="SiteMaster.ViewMarket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #fed2d7; text-shadow: 2px 2px 4px #fc03d1, 0 0 5px #ff89ea; text-align: center;">Compra e venda de<br />
        criptomoedas!</h1>


    <div class="tabela">
        <table style="width: 100%;">
            <tr>
                <th>Criptomoeda</th>
                <th>Preço</th>
                <th>Volume de mercado</th>
                <th>Volume 24H</th>
                <th>Mudança 24H</th>
            </tr>
            <tr>
                <td><a href="/Pages/Crypto/BitcoinPage.aspx">
                    <div class="bitcoin">
                        <img src="/images/bitcoin_logo_icon_147311.png" style="height: 60px; display: inline;" />
                    </div>
                    <div class="color1">
                        <p style="display: inline;">Bitcoin</p>
                    </div>
                    <div class="sigla1">
                        <p style="display: inline;">BTC</p>
                    </div>
                </a>
                </td>
                <td><a href="/Pages/Crypto/BitcoinPage.aspx">R$ 100.879,05</a></td>
                <td><a href="/Pages/Crypto/BitcoinPage.aspx">R$ 1.635.238.614.036</a></td>
                <td><a href="/Pages/Crypto/BitcoinPage.aspx">R$ 769.596.704.828</a></td>
                <td>
                    <div class="corfundo1"><a href="/Pages/Crypto/BitcoinPage.aspx">+0,02%</a></div>
                </td>
            </tr>
            <tr>
                <td><a href="/Pages/Crypto/EthereumPage.aspx">
                    <div class="ethereum">
                        <img src="/images/ethereum.png" style="height: 60px; display: inline;" />
                    </div>
                    <div class="color1">
                        <p style="display: inline;">Ethereum</p>
                    </div>
                    <div class="sigla1">
                        <p style="display: inline;">ETH</p>
                    </div>
                </a>
                </td>
                <td><a href="/Pages/Crypto/EthereumPage.aspx">R$ 2.086,05</a></td>
                <td><a href="/Pages/Crypto/EthereumPage.aspx">R$ 227.535.856.882</a></td>
                <td><a href="/Pages/Crypto/EthereumPage.aspx">R$ 102.632.837.599</a></td>
                <td>
                    <div class="corfundo1"><a href="/Pages/Crypto/EthereumPage.aspx">+3,64%</a></div>
                    
                </td>
            </tr>
            <tr>
                <td><a href="/Pages/Crypto/XRPPage.aspx">
                    <div class="XRP">
                        <img src="/images/xrp_cryptocurrency_logo_icon_131379.png" style="height: 60px; display: inline;" />
                    </div>
                    <div class="color1">
                        <p style="display: inline;">XRP</p>
                    </div>
                    <div class="sigla1">
                        <p style="display: inline;">XRP</p>
                    </div>
                </a>
                </td>
                <td><a href="/Pages/Crypto/XRPPage.aspx">R$ 1,04</a></td>
                <td><a href="/Pages/Crypto/XRPPage.aspx">R$ 46.601.304.952</a></td>
                <td><a href="/Pages/Crypto/XRPPage.aspx">R$ 5.859.431.811</a></td>
                <td>
                    <div class="corfundo2"><a href="/Pages/Crypto/XRPPage.aspx">-0,68%</a></div>
                </td>
            </tr>
            <tr>
                <td><a href="/Pages/Crypto/TetherPage.aspx">
                    <div class="tether">
                        <img src="/images/usdt.png" style="height: 60px; display: inline;" />
                    </div>
                    <div class="color1">
                        <p style="display: inline;">Tether</p>
                    </div>
                    <div class="sigla1">
                        <p style="display: inline;">USDT</p>
                    </div></a>
                </td>
                <td><a href="/Pages/Crypto/TetherPage.aspx">R$ 5,35</a></td>
                <td><a href="/Pages/Crypto/TetherPage.aspx">R$ 45.813.228.299</a></td>
                <td><a href="/Pages/Crypto/TetherPage.aspx">160.624.734.835</a></td>
                <td>
                    <div class="corfundo2"><a href="/Pages/Crypto/TetherPage.aspx">-0,02%</a></div>
                </td>
            </tr>
            <tr>
                <td><a href="/Pages/Crypto/DogecoinPage.aspx">
                    <div class="doge">
                        <img src="/images/doge.png" style="height: 60px; display: inline;" />
                    </div>
                    <div class="color1">
                        <p style="display: inline;">Dogecoin</p>
                    </div>
                    <div class="sigla1">
                        <p style="display: inline;">DOGE</p>
                    </div></a>
                </td>
                <td><a href="/Pages/Crypto/DogecoinPage.aspx">R$ 0,01</a></td>
                <td><a href="/Pages/Crypto/DogecoinPage.aspx">R$ 1.653.649.801</a></td>
                <td><a href="/Pages/Crypto/DogecoinPage.aspx">R$ 962.792.781</a></td>
                <td>
                    <div class="corfundo2"><a href="/Pages/Crypto/DogecoinPage.aspx">-1,74%</a></div>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>