<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarTurno.aspx.cs" Inherits="TrabajoPractico.ModificarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos a modificar</div>
            <div class="panel-body">

                <div class="form-group">

                    <div class="col-md-12">
                        <asp:DropDownList ID="ddlPersona" runat="server" Enabled="true" CssClass="form-control" OnLoad="ddlPersona_Load"></asp:DropDownList>
                    </div>
                    <asp:Label ID="Label2" runat="server" Text="Fecha y horario del turno:" CssClass="control-label col-md-4"></asp:Label>
                    <div class="col-md-4">
                        <input id="dtDiaDelTurno" runat="server" type="date" name="fecha" />
                    </div>
                    <div class="col-md-4">
                        <input id="dtHoraDelTurno" runat="server" type="time" name="hora" />
                    </div>
                    <asp:Label ID="lblMotivoTurno" runat="server" Text="Motivo del Turno:" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtMotivoTurno" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblTareas" runat="server" Text="Tareas a realizar" CssClass="control-label col-md-2"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTareas" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-primary" OnClick="btnModificar_Click"/>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
