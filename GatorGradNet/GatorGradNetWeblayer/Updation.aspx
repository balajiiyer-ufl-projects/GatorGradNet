<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/GatorGradNet.Master" AutoEventWireup="true" CodeFile="Updation.aspx.cs" Inherits="GatorGradNet.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function clearAll() {
            
            $("#txtFirstName").val('');
            $("#txtLastName").val("");
            $("#txtEmail").val("");
            $("#txtPhoneNo").val("");
            $("#txtBranch").val("");
            $("#txtGPA").val("");
            $("#txtDesignation").val("");
            $("#txtRange").val("");
            $("#txtCurrentWork").val("");
            $("#txtPrevUniv").val("");
            $("#txtPrevWork").val("");
            $("#txtPrevLoc").val("");
            $("#txtDreamCompany").val("");
            $("#txtLocation").val("");
            //document.write("Cleared");
        }
    </script>
    <script type="text/javascript">
        function clearForm() {
            $("#txtName").val("");
            $("#txtPassword").val("");
            $("#txtRetypePassword").val("");
            $("#txtEmail").val("");
            $("#txtLocation").val("");
        }
   </script>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 303px;
            height: 24px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style11 {
            width: 315px;
            height: 24px;
        }
        .auto-style14 {
            width: 194px;
        }
        .auto-style15 {
            height: 23px;
            width: 194px;
        }
        .auto-style16 {
            height: 24px;
            width: 194px;
        }
        .auto-style17 {
            width: 315px;
        }
        .auto-style18 {
            width: 315px;
            height: 23px;
        }
        .auto-style19 {
        }
        .auto-style20 {
            width: 303px;
            height: 23px;
        }
        #Reset1 {
            height: 29px;
            width: 97px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server"><table class="auto-style1">
        <tr>
            <td class="auto-style17">
                &nbsp;</td>
            <td class="auto-style19" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblResult" runat="server" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblPhoneNo" runat="server" Text="Phone No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Label ID="lblBranch" runat="server" Text="Branch"></asp:Label>
            </td>
            <td class="auto-style20">
                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:Label ID="lblGPA" runat="server" Text="GPA"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtGPA" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18"></td>
            <td class="auto-style20"></td>
            <td class="auto-style15"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblCurrentWork" runat="server" Text="Company"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtCurrentWork" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblPrevUniv" runat="server" Text="Past University"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtPrevUniv" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblprevWork" runat="server" Text="Past Employment"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrevWork" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style5"></td>
            <td class="auto-style16"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblPrevLoc" runat="server" Text="Past Location"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtPrevLoc" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblDreamCompany" runat="server" Text="Dream Company"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDreamCompany" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style19">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="29px" Width="97px" OnClick="btnUpdate_Click" />
            </td>
            <td class="auto-style14">
               
                <input id="Reset1" type="reset"  value="Clear" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table></asp:Panel>
    <asp:Panel ID="Panel2" runat="server"></asp:Panel>

</asp:Content>
