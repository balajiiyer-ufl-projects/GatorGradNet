<%@ Page Language="C#" MasterPageFile="~/GatorGradNet.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="GatorGradNet.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="js/init.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="divCircle">
     <script type="text/javascript">
         var svgContainer = d3.select("#divCircle").append("svg")
                                            .attr("width", 1500)
                                             .attr("height", 500).attr("fill", "#ABCDEF");
         var circle = svgContainer.append("a").attr("xlink:href", "PrevLocation.aspx").append("circle").attr("cx", 400).attr("cy", 100).attr("r", 75).attr("fill", "#4CC417");;
         svgContainer.append("a").attr("xlink:href", "PrevLocation.aspx").append("text").attr("x", 360).attr("y", 100).text("By Location").style("fill", "white").style("font-family", "Calibri").style("font-size", "20px");
         svgContainer.append("a").attr("xlink:href", "PrevWork.aspx").append("circle").attr("cx", 600).attr("cy", 100).attr("r", 75).attr("fill", "#F87431");
         svgContainer.append("a").attr("xlink:href", "PrevWork.aspx").append("text").attr("x", 570).attr("y", 100).text("By Work").style("fill", "white").style("font-family", "Calibri").style("font-size", "20px");
         svgContainer.append("a").attr("xlink:href", "PrevEdu.aspx").append("circle").attr("cx", 800).attr("cy", 100).attr("r", 75).attr("fill", "#38ACEC");
         svgContainer.append("a").attr("xlink:href", "PrevEdu.aspx").append("text").attr("x", 750).attr("y", 100).text("By Education").style("fill", "white").style("font-family", "Calibri").style("font-size", "20px");
            </script>
        </div>
</asp:Content>


