<%@ Page Title="" Language="C#" MasterPageFile="~/GatorGradNet.Master" AutoEventWireup="true" CodeFile="top10.aspx.cs" Inherits="GatorGradNet.WebForm4" %>
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

        .axis text {
            font-family: sans-serif;
            font-size: 11px;
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
     <div id="div11">
            <script type="text/javascript">
                var width = 450;
                var height = 450;
                radius = Math.min(width, height) / 2;
                var color = d3.scale.category20();
                var arc = d3.svg.arc().outerRadius(radius - 10).innerRadius(100);
                var pie = d3.layout.pie().sort(null).value(function (d) { return d.population; });
                var svg = d3.select("#div11").append("svg")
                          .attr("width", width)
                          .attr("height", height)
                          .append("g")
                          .attr("transform", "translate(" + width / 2 + "," + height / 2 + ")");
                d3.csv("pieData.csv", function (error, data) {

                    data.forEach(function (d) {
                        d.population = +d.population;
                    });

                    var g = svg.selectAll(".arc")
                        .data(pie(data))
                      .enter().append("g")
                        .attr("class", "arc");

                    g.append("path")
                        .attr("d", arc)
                        .style("fill", function (d) { return color(d.data.age); });

                    g.append("text")
                        .attr("transform", function (d) { return "translate(" + arc.centroid(d) + ")"; })
                        .attr("dy", ".35em")
                        .style("text-anchor", "middle")
                        .text(function (d) { return d.data.age; });

                });

            </script>
        </div>

</asp:Content>
