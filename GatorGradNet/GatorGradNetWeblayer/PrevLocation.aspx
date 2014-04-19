<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrevLocation.aspx.cs" Inherits="PrevLocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .users {
            border:2px solid;
            padding:2px;
            grid-column-span:5;
            border-spacing:20px;
            border-radius:30px;
            border-collapse:separate;
            word-wrap:break-word;
                      
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 align="center">Previous Location</h1>
        <div id="group" style="width: 380px;overflow-wrap:break-word;word-spacing:5px;line-height:250%" runat="server">
        <a class="users">Balaji</a>
        <a class="users">Aadhavan</a>
        <a class="users">Balaji</a>
        <a class="users">Aadhavan</a>
        <a class="users">Balaji</a>
        <a class="users">Aadhavan</a>
            <a class="users">Balaji</a>
        <a class="users">Aadhavan</a>
        </div>
    </div>
    </form>
</body>
</html>
