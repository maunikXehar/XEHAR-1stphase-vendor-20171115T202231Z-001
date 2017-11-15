<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Quicky.index" MasterPageFile="~/Quicky.Master"%>
<asp:Content ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ContentPlaceHolderID="Title" runat="server">Home</asp:Content>
<asp:Content ContentPlaceHolderID="Body" runat="server">
    <%--<h1 runat="server" id="CLT"></h1>--%>
    <input type="hidden" name="json" id="json" runat="server" />
    <%--<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>--%>
    
     <script src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
    <script type="text/javascript">
        
       

        PageMethods.Customers(onSucess, onError);

        function onSucess(result) {
            
            var result1 = [];
            result1 = JSON.parse(result);
           
          
            var dataPoints1 = [];
            
           for (var i = 0; i < result1.length; i++) {
               dataPoints1.push({
                   label:result1[i].ProductName ,y:result1[i].s
               })
           }
            var chart = new CanvasJS.Chart("piechart", {
                title: {
                    text: "Top 5 Selling Products"
                },
                data: [
                {
                    // Change type to "doughnut", "line", "splineArea", etc.
                    type: "pie",
                    dataPoints: dataPoints1,
                   
                }
                ]
               
            });
           
            chart.render();
           
   }

        function onError(result) {
            alert('Cannot process your request at the moment, please try later.');
        }
       

        </script>
</asp:Content>
