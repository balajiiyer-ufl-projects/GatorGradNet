<%@ Page Title="" Language="C#" MasterPageFile="~/GatorGradNet.Master" AutoEventWireup="true" CodeFile="YearVsSalary.aspx.cs" Inherits="GatorGradNet.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="d3/d3.js"></script>
         <style type="text/css">
        .bar {
            display: inline-block;
            width:20px;
            height:75px;
            background-color:steelblue;
            text-align:start;
        }
        .axis path,
        .axis line {
            fill: none;
            stroke: black;
            shape-rendering: crispEdges;
        }

        


.axis path,
.axis line {
  fill: none;
  stroke: #000;
  shape-rendering: crispEdges;
}

.x.axis path {
  display: none;
}

.line {
  fill: none;
  stroke: steelblue;
  stroke-width: 1.5px;
}


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <div id="chartContainer">
  <script src="http://d3js.org/d3.v3.min.js"></script>
  <script src="http://dimplejs.org/dist/dimple.v1.1.5.min.js"></script>
  <script type="text/javascript">
      var svg = dimple.newSvg("#chartContainer", 1200, 500);
      d3.tsv("data.tsv", function (data) {


          // Create and Position a Chart
          var myChart = new dimple.chart(svg, data);
          //myChart.setBounds(60, 30, 500, 300);
          var x = myChart.addCategoryAxis("x", "date");
          myChart.addMeasureAxis("y", "hires");

          // Order the x axis by date
          x.addOrderRule("date");

          // Min price will be green, middle price yellow and max red
          myChart.addColorAxis("hires", ["red", "yellow", "green"]);

          // Add a thick line with markers
          var lines = myChart.addSeries(null, dimple.plot.line);
          lines.lineWeight = 5;
          lines.lineMarkers = true;

          // Draw the chart
          myChart.draw();

      });
  </script>
</div>
</asp:Content>
