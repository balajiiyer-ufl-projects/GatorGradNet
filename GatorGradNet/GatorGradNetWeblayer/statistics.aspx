<%@ Page Title="" Language="C#" MasterPageFile="~/GatorGradNet.Master" AutoEventWireup="true" CodeFile="statistics.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 456px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="169px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="160px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Panel ID="pnlInitial" runat="server">
                    <br />
                    <div id="div7">
            <script type="text/javascript">
                var dataset = [100, 120, 50, 80, 101, 80, 103, 104, 40, 109];
                var w = 800;
                var h = 500;
                var barPadding = 1;
                var svg = d3.select("#div7").append("svg").attr("width", w).attr("height", h);
                svg.selectAll("rect").data(dataset).enter().append("rect").attr("x", function (d, i) { return i * (w / dataset.length); }).attr("width", (w / dataset.length) - barPadding).attr("height", function (d) { return d * 4; }).attr("y", function (d) { return h - d * 4; }).attr("fill", "teal");
                svg.selectAll("text").data(dataset).enter().append("text").attr("x", function (d, i) { return i * (w / dataset.length) + 3; }).attr("y", function (d) { return h - (d * 4) + 13 }).text(function (d) { return d; }).attr("font-family", "sans-serif").attr("font-size", "11px").attr("fill", "white");
            </script>
        </div>
                </asp:Panel>
                <asp:Panel ID="Panel2" runat="server">
                </asp:Panel>
            </td>
        </tr>
    </table>

</asp:Content>

