<%@ Page Title="" Language="C#" MasterPageFile="~/VendorPortal/vendorPortalMaster/VendorMaster.Master" AutoEventWireup="true" CodeBehind="vendorportalproduct.aspx.cs" Inherits="XEHAR2017.AdminUI.adminviews.vendorportalproduct" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <script src='//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js'></script>
 
   
    <script src="../../scripts/custom/incrementing.js"></script>

    <div class="content-wrapper">
        <div class="col-xs-12">
            <div class="box pad10">
                <div class="row">
                    <div class="col-md-4">
                        <img src="../../images/noimage_19.jpg" />

                    </div>


                    <div class="col-md-6">

                        <div class="form-group">
                            <label class="fs-24">Product Description</label>
                            <div class="clearfix"></div>
                            <label id="lblVendorDescription" runat="server"></label>
                        </div>
                    </div>

                    <div class="col-md-2">

                        <div class="form-group">
                            <label class="fs-24">Vendor Price</label>
                            <label id="lblVendorPrice" runat="server"></label>

                            <label class="fs-24">Buyer Target</label>
                            <input type="text" class="form-control" placeholder="Enter Buyer target" id="txtBuyertarget" runat="server" />
                        </div>
                    </div>

                
                </div>

                <div class="row">
                     <label class="fs-24">Sizes</label>
                    <div class="clearfix"></div>
                    <div class="col-md-2">

                       

      <div class="numbers-row">
        <label for="name" class="fs-24">S</label>
        <input type="text" name="french-hens" id="txtSmall" value="0" runat="server" style="width:20% !important;"/>
      </div>
                        </div>
                    <div class="col-md-2">
      <div class="numbers-row">
        <label for="name" class="fs-24">M</label>
        <input type="text" name="turtle-doves" id="txtM" value="0" runat="server" style="width:20% !important;" />
      </div>
                        </div>
                    <div class="col-md-2">
      <div class="numbers-row">
        <label for="name" class="fs-24">L</label>
        <input type="text" name="partridge" id="txtL" value="0" runat="server" style="width:20% !important;" />
      </div>
            
                    </div>

 <div class="col-md-6 text-right">
    		<button type="button" id="btnSubmitProduct" runat="server" class="btn btn-warning custom-button-width .navbar-right" onserverclick="Updateproducts" style="padding-bottom: 30px !important;">Update</button>
			<button type="button" id="Button1" runat="server" class="btn btn-danger custom-button-width .navbar-right" onserverclick="Cancelupdateproducts" style="padding-bottom: 30px !important;">Cancel</button>
 
    	</div>
                </div>

                    
               
            </div>
        </div>
       
    </div>

 
</asp:Content>
