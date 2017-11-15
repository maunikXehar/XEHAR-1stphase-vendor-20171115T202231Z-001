<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VendorPortal.aspx.cs" Inherits="XEHAR2017.GridTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="PID" EnableModelValidation="true"

OnRowUpdating="OnRowUpdating" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"   EmptyDataText="No records has been added.">
<Columns>

    <asp:TemplateField HeaderText="Product ID" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:LinkButton ID="link1" runat="server" Text='<%# Eval("PID") %>' onClick="link1Click" > </asp:LinkButton>
            <asp:Button ID="Nine" BackColor="Wheat"  runat="server"/>
            
            <%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="PID_Click"/>--%> 
            <asp:Label ID="txtPID" runat="server"></asp:Label>       
        </ItemTemplate>
        </asp:TemplateField>
    

    
    <asp:TemplateField HeaderText="Available Stock" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblStock" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtStock" runat="server" Text='<%# Eval("Stock") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="false" ItemStyle-Width="150"/>





    <asp:TemplateField HeaderText="Sales at Xehar" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblSales_Xehar" runat="server" Text='<%# Eval("Sales_Xehar") %>'></asp:Label>
        </ItemTemplate>
        
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Vendor Selling Price" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblVSP" runat="server" Text='<%# Eval("VSP") %>'></asp:Label>
        </ItemTemplate>
        
    </asp:TemplateField>
    
</Columns>




</asp:GridView>
<table border="1"  style="border-collapse: collapse">
</table>
    </form>
</body>
</html>