<%@ Page Title="" Language="C#" MasterPageFile="~/AdminUI/adminmaster/AdminMaster.Master" AutoEventWireup="true" CodeBehind="addproducts.aspx.cs" Inherits="XEHAR2017.AdminUI.adminviews.addproducts" EnableEventValidation="false"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

        <script>
            $(function () {
                $("#datepicker").datepicker();
            });
  </script>
   <div class="content-wrapper">
         <div class="box box-warning">
                                     <!-- /.box-header -->
             <div class="box box-solid box-success" id="successBox" runat="server" visible="false">
                    <div class="box-header">
                        <h3 class="box-title">Success! </h3>
                    </div><!-- /.box-header -->
                    <div class="box-body">
                        Please click the following link to view all <a href="products.aspx">products</a>  
                    </div><!-- /.box-body -->
                </div>

                                <div class="box-body" style="width:50% !important;">
                                 
                                        <!-- text input -->
                                        <div class="form-group">
                                            <label>SKU</label>
                                            <input type="text" class="form-control" placeholder="Enter SKU" id="txtSku" runat="server" />
                                           
                                        </div>
                                        <div class="form-group">
                                            <label>Product Name</label>
                                            <input type="text" class="form-control" placeholder="Enter Product Name" id="txtProductname" runat="server" />
                                        </div>
                                        <div class="form-group">
                                            <label>Description</label>
                                            <textarea class="form-control" placeholder="Enter Description" id="txtDescription" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Model Number</label>
                                            <input type="text" class="form-control" placeholder="Enter Model Number" id="txtModelnumber" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Department</label>
                                            <input type="text" class="form-control" placeholder="Enter Department" id="txtDepartment" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Tax Code</label>
                                            <input type="text" class="form-control" placeholder="Enter Tax Code" id="txtTaxcode" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Brand</label>
                                            <input type="text" class="form-control" placeholder="Enter Brand" id="txtBrand" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Manufactuer</label>
                                            <input type="text" class="form-control" placeholder="Enter Manufactuer" id="txtManufactuer" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Vendor Cost</label>
                                            <input type="number" class="form-control" placeholder="Enter Vendor Cost" id="txtVendorcost" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Gender</label>
                                            <select class="form-control" id="ddlGender" runat="server">
                                                <option>Male</option>
                                                <option>Female</option>                                                
                                            </select>
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Warranty</label>
                                            <input type="number" class="form-control" placeholder="Enter Warranty" id="txtWarranty" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Weight</label>
                                            <input type="number" class="form-control" placeholder="Enter Weight" id="txtWeight" runat="server" />
                                        </div>
                                        
                                        
                                         <div class="form-group">
                                        <label>Start Date:</label>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <i class="fa fa-calendar"></i>
                                            </div>
                                            <input type="text" class="form-control" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="" disabled="disabled" />
                                        </div><!-- /.input group -->
                                    </div>
                                        
                                    

                                        <div class="form-group">
                <label>End Date:</label>

                <div class="input-group date">
                  <div class="input-group-addon">
                    <i class="fa fa-calendar"></i>
                  </div>
                  <input type="text" class="form-control pull-right" id="datepicker"  runat="server" ClientIDMode="Static" />
                </div>
                <!-- /.input group -->
              </div>
                                        
                                        <div class="form-group">
                                            <label>Quality</label>
                                            <input type="text" class="form-control" placeholder="Enter Quality"  id="txtQuality" runat="server" />
                                        </div>
                                        
                                        
                                        
                                        <div class="form-group">
                                            <label>SupplierCost</label>
                                            <input type="text" class="form-control" placeholder="Enter SupplierCost"  id="txtSuppliercost" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>CountryOrigin</label>
                                            <input type="text" class="form-control" placeholder="Enter CountryOrigin"  id="txtCountryorigin" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Replinishable</label>
                                            <input type="number" class="form-control" placeholder="Enter Replinishable"  id="txtReplinishable" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Expeditable</label>
                                            <input type="number" class="form-control" placeholder="Enter Expeditable"  id="txtExpeditable" runat="server" />
                                        </div>
                                        
                                        <div class="form-group">
                                            <label>Reorder Time</label>
                                            <input type="number" class="form-control" placeholder="Enter Reorder Time"  id="txtReordertime" runat="server" />
                                        </div> 
                                        
                                        <div class="form-group">
                                            <label>Sold Quantity</label>
                                            <input type="number" class="form-control" placeholder="Enter Sold Quantity"  id="txtSoldquantity" runat="server" />
                                        </div>   
                                       <%-- <button type="button" id="btnSubmit2" runat="server"  class="btn btn-block btn-primary btn-lg" value="Submit" onServerClick="Addproducts"></button>--%>
                                    <button type="button"  id="btnSubmitProduct" runat="server"  class="btn btn-block btn-primary btn-lg" onServerClick="Addproducts" style="padding-bottom:30px !important;">Submit</button>
                                    
                                </div><!-- /.box-body -->
                            </div>
       </div>

    
</asp:Content>
