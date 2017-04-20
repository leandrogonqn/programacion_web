<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="TrabajoPractico.AltaPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos básicos</div>
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
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardar_Click" />

                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:GridView ID="gdvPersonas" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="gdvPersonas_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="personasId" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                    <asp:BoundField HeaderText="Direccion" DataField="direccion" />
                    <asp:BoundField HeaderText="Telefono" DataField="telefono" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Modificar" runat="server" CommandName="Modificar" CommandArgument='<%# Eval("personasId")%>' Text="Modificar" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>

    </div>
</asp:Content>
