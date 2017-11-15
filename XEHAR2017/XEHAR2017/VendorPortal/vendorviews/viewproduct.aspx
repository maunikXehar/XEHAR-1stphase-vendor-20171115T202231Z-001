<%@ Page Title="" Language="C#" MasterPageFile="~/VendorPortal/vendorPortalMaster/VendorMaster.Master" AutoEventWireup="true" CodeBehind="viewproduct.aspx.cs" Inherits="XEHAR2017.AdminUI.adminviews.viewproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        
        

        <asp:repeater id="rptProducts" runat="server">  
            <HeaderTemplate></HeaderTemplate>     
            <ItemTemplate>
              
                <div class="table" style="padding:100px !important;">
                    <div class="col-xs-6">
                 <table class="table">
              <tbody><tr>
                <th style="width:50%">SKU:</th>
                <td> <%# DataBinder.Eval(Container, "DataItem.SKU")%></td>
              </tr>
              <tr>
                <th>Product Name</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Product Name")%></td>
              </tr>
              <tr>
                <th>Description:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Description")%></td>
              </tr>
              <tr>
                <th>Model Number:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Model Number")%></td>
              </tr>

                  <tr>
                <th>Department:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Department")%></td>
              </tr>
                  <tr>
                <th>Tax Code:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Tax Code")%></td>
              </tr>
                  <tr>
                <th>Brandtal:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Brand")%></td>
              </tr>
                  <tr>
                <th>Manufacturer:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Manufactuer")%></td>
              </tr>
                  <tr>
                <th>Vendor Cost:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Vendor Cost")%></td>
              </tr>
                  <tr>
                <th>Gender:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Gender")%></td>
              </tr>
                    <tr>
                <th>Warranty:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Warranty")%></td>
              </tr>
                    <tr>
                <th>Weight:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Weight")%></td>
              </tr>
                   <tr>
                <th>StartDate:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.StartDate")%></td>
              </tr>
                    <tr>
                <th>EndDate:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.EndDate")%></td>
              </tr>
                    <tr>
                <th>Quality:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Qaulity")%></td>
              </tr>
                      <tr>
                <th>Supplier Cost:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.SupplierCost")%></td>
              </tr>
                      <tr>
                <th>Country Origin:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.CountryOrigin")%></td>
              </tr>
                      <tr>
                <th>Replinishable:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Replinishable")%></td>
              </tr>
                      <tr>
                <th>Expeditable:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Expeditable")%></td>
              </tr>
                      <tr>
                <th>Reorder Time:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Reorder Time")%></td>
              </tr>
                      <tr>
                <th>Sold Quantity:</th>
                <td><%# DataBinder.Eval(Container, "DataItem.Sold Quantity")%></td>
              </tr>
            </tbody></table>
                        </div>
                    </div>
            </ItemTemplate>
            <FooterTemplate></FooterTemplate>
            </asp:repeater>
        </div>
</asp:Content>
