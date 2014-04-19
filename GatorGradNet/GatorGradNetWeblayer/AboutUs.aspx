<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .font-style {
	font-family: Perpetua, Baskerville, "Big Caslon", "Palatino Linotype", Palatino, "URW Palladio L", "Nimbus Roman No9 L", serif;
	color: #D13C17;
	font-size: 19px;
	padding: 21px;
	font-style: italic;
	letter-spacing: 0px;
	line-height: 29px;
	text-align: justify;
}

    .header-style {
	font-family: Perpetua, Baskerville, "Big Caslon", "Palatino Linotype", Palatino, "URW Palladio L", "Nimbus Roman No9 L", serif;
	color: #D13C17;
	padding: 21px;
	font-style: italic;
	letter-spacing: 0px;
	line-height: 29px;
            height: 24px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 358px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            font-family: Perpetua, Baskerville, "Big Caslon", "Palatino Linotype", Palatino, "URW Palladio L", "Nimbus Roman No9 L", serif;
            color: #D13C17;
            font-size: 19px;
            padding: 21px;
            font-style: italic;
            letter-spacing: 0px;
            line-height: 29px;
            text-align: justify;
            width: 358px;
        }
    </style>
</head>
<body bgcolor="#E6E6FA">
    <form id="form1" runat="server">
    <div>
        <h1 align="center" class="header-style">
            ABOUT US</h1>
        <p class="font-style">
            We are graduate students in Computer Science at the University of Florida. International students who come for graduate education face certain difficulties when it comes to alumni connections, job prospects and career development. This inspired us to build Gator Grad Net.</p>
        &nbsp;<table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl="~/authors/balaji.jpg" Width="203px" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Image ID="Image3" runat="server" Height="140px" ImageUrl="~/authors/aadhavan.jpg" Width="203px" style="margin-top: 0px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balaji C. Iyer</td>
                <td class="auto-style4"></td>
                <td class="font-style">Aadhavan Ramesh</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image2" runat="server" Height="140px" ImageUrl="~/authors/balajir.jpg" Width="203px" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Image ID="Image4" runat="server" Height="140px" ImageUrl="~/authors/manipal.jpg" Width="203px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balaji Ramasubramaniam</td>
                <td>&nbsp;</td>
                <td class="font-style">Manipal Reddy</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
