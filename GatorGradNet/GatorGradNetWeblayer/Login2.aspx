<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="Login2" %>

<!DOCTYPE HTML>
<!--
	Helios 1.5 by HTML5 UP
	html5up.net | @n33co
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->
<html>
	<head>
		<title>GatorGradNet</title>
        <link rel="icon" type="image/png" href="/images/G.png" />
		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="description" content="" />
		<meta name="keywords" content="" />
		<link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600|Arvo:700" rel="stylesheet" type="text/css" />
		<!--[if lte IE 8]><script src="js2/html5shiv.js"></script><![endif]-->
		<script src="js2/jquery.min.js"></script>
		<script src="js2/jquery.dropotron.min.js"></script>
		<script src="js2/skel.min.js"></script>
		<script src="js2/skel-panels.min.js"></script>
		<script src="js2/init.js"></script>
		<noscript>
			<link rel="stylesheet" href="css2/skel-noscript.css" />
			<link rel="stylesheet" href="css2/style.css" />
			<link rel="stylesheet" href="css2/style-desktop.css" />
			<link rel="stylesheet" href="css2/style-noscript.css" />
		</noscript>
		<!--[if lte IE 8]><link rel="stylesheet" href="css2/ie8.css" /><![endif]-->
        <script type="text/javascript">
            function login_btn() {
                $("#btn_click").click();
            }
            function register_btn() {
                $("#btn_register").click();
            }
        </script>
	    <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
            .textboxlogin {
                margin-left: 0px;
            }
            .auto-style14 {
                height: 3em;
            }
            .auto-style15 {
                height: 1em;
            }
            .dividerTest {
     border-left:1px solid #38546d; 
     border-right:1px solid #16222c; 
     height:80px;
     position:relative;
     right:249px;
     top:10px; 
}
            .auto-style16 {
                position:absolute;
                width: 1.2em;
            }
            .auto-style17 {
                width: 37.4em;
            }
            </style>
        <script type="text/javascript" src="Scripts/jquery.fancybox.js"></script>
        <script type="text/javascript" src="Scripts/jquery.fancybox.pack.js"></script>
        <link rel="stylesheet" href="fancybox/jquery.fancybox.css" type="text/css" media="screen"/>
        <script type="text/javascript">
            function LoginFailLaunchBox() {
                $("#loginfail").fancybox({
                    'transitionIn': 'elastic',
                    'transitionOut': 'elastic',
                    'speedIn': 600,
                    'speedOut': 200,
                    'overlayShow': false
                }).trigger('click');
            }
        </script>
	</head>
	<body class="homepage" >
        <form runat="server">
		<!-- Header -->
			<div id="header">
						
				<!-- Inner -->
					<div class="inner">
						<header>
							<h1><a href="#" id="logo">GATOR GRAD NET</a></h1>
							<hr />
						</header>
						<footer>
							<a href="#banner" class="button circled scrolly">Login</a>
						</footer>
					</div>
				

			</div>
			
		<!-- Banner -->
			<div id="banner">
               
			</div>

					
		<!-- Main -->
			<div class="wrapper style2">

				<article id="main" class="container special">
					
                    
				    <table class="auto-style1">
                        <tr>
                            <td class="auto-style17" rowspan="7">
                                <br />
                                <br />
                                Facebook, Glassdoor and Linkedin all in one package...&nbsp;&nbsp;&nbsp;&nbsp; and thats
                                <br />
                                <br />
                                GATOR GRAD NET<br />
                                <br />
                                <br />
                                This website provides you with all information about The University of Florida that any
                                <br />
                                prospective graduate studnt would need.<br />
                                <br />
                                And what are they?<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1. Connections with UF Alumni.<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2. The Craigslist for Internships.<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3. Post-Grad Recruitment Statistics.</td>
                            <td class="auto-style16" rowspan="7">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/divider.png" style="margin-left: 0px" Height="442px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                &nbsp;</td>
                            <td class="auto-style14">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Image ID="Image1" runat="server" Height="134px" ImageUrl="~/images/avatar_2x.png" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label1" runat="server" Text="Label">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Username</asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox1" Cssclass="textboxlogin" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label2" runat="server" Text="Label">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Password</asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox2" Cssclass="textboxlogin" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style14">
                                <a id="A1" class="button" runat="server" onclick="login_btn();">Login</a>
                                <asp:Button ID="btn_click" runat="server" Text="Button" style="display:none" OnClick="Login_ButtonClick" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15"></td>
                            <td class="auto-style15">
                                <a id="A2" class="button2" runat="server" onclick="register_btn();">Register</a>
                                <asp:Button ID="btn_register" runat="server" Text="Button" style="display:none" OnClick="Register_ButtonClick" />
                            </td>
                        </tr>
                    </table>
					
                    
				</article>

			</div>

	
            <!-- Footer -->
			
            <asp:Literal ID="Literal1" runat="server" Visible="false"></asp:Literal>
            <a id="loginfail" href="LoginFail.html" style="display:none"></a>
            </form>
	</body>
</html>
