<%@ Page Title="" Language="C#" MasterPageFile="~/VendorPortal/vendorPortalMaster/VendorMaster.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="XEHAR2017.VendorUI.vendorviews.statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <div class="row">
        <!-- Left col -->
        <section class="col-lg-7 connectedSortable">
         <div class="nav-tabs-custom">
            <!-- Tabs within a box -->
            <ul class="nav nav-tabs pull-right">
               
                  <li class="active"><a href="#chart-pie" data-toggle="tab">Pie</a></li>
                <li >Show Top: <select id="ddlRows">
    <option value="2" selected="selected">2</option>
    <option value="4">4</option>
    <option value="6">6</option>
<option value="10">10</option>
                     </select>
</li>
              <li class="pull-left header"><i class="fa fa-inbox"></i> Sales</li>
            </ul>
             
            <div class="tab-content no-padding">
              <!-- Morris chart - Sales -->
              
                <div class="chart tab-pane active" id="chart-pie" style="position: relative; height: 300px;">
                              <canvas id="pieChart" style="height:250px"></canvas>

                    </div>

            </div>
          </div>
            </section>
            </div>
        </div>

    <script src="../../admincomponents/bower_components/chart.js/Chart.js"></script>
    <script src="../../admincomponents/bower_components/chart.js/src/Chart.Bar.js"></script>

       <script src='//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js'></script>

    <script type="text/javascript">

        function DisplayChart(ddlValue){
            $.ajax({
                type: "POST",
                url: "home.aspx/MyMethod",
                data: "{Param1: '" + ddlValue + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: "true",
                cache: "false",
                success: function (data) {

                    var arr = [];
                    var aData = JSON.parse(data.d);

                    $.each(aData, function (inx, val) {
                        var obj = {};
                        obj.color = val.color;
                        obj.value = val.value;
                        obj.label = val.label;
                        arr.push(obj);
                    });

                    //pie chart

                    var pieChartCanvas = $('#pieChart').get(0).getContext('2d');
                    var myPieChart = new Chart(pieChartCanvas).Pie(arr);


                },
                Error: function (x, e) {
                    // On Error
                }
            });
        }
        $(document).ready(function () {

            var defaultval = $('#ddlRows').val();
            DisplayChart(defaultval);
            $('#ddlRows').change(function () {

                var val = $('#ddlRows').val();
                DisplayChart(val);
            });
            
        });
</script>
</asp:Content>
