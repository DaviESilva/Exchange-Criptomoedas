<%@ Page Title="Histórico" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="SiteMaster.Pages.Account.History" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="color: #fed2d7; text-shadow: 2px 2px 4px #fc03d1, 0 0 5px #ff89ea; text-align: center;">Histórico</h1>

    <div class="tabelahistorico">
        <table style="width: 100%">
            <tr>
                <th>Data</th>
                <th>Valor</th>
            </tr>
            <tr>
                <td>27/11/2020 18:47</td>
                <td>R$ 5.000,00 </td>
            </tr>
            <tr>
                <td>19/11/2020 23:02</td>
                <td>R$ 300,00</td>
            </tr>
            <tr>
                <td>08/11/2020 14:25</td>
                <td>R$ 2.000,00</td>
            </tr>
            <tr>
                <td>29/10/2020 05:14</td>
                <td>R$ 1.348,59</td>
            </tr>
            <tr>
                <td>14/10/2020 22:58</td>
                <td>R$ 128,79</td>
            </tr>
            <tr>
                <td>01/10/2020 00:59</td>
                <td>R$ 7.000,00</td>
            </tr>
            <tr>
                <td>05/09/2020 03:00</td>
                <td>R$ 549,30</td>
            </tr>
        </table>
    </div>

</asp:Content>
