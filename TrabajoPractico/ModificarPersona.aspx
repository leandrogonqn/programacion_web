<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarPersona.aspx.cs" Inherits="TrabajoPractico.ModificarPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos a modificar</div>
            <div class="panel-body">


                <div class="form-group">

                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido:" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion:" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-primary" OnClick="btnModificar_Click"/>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
