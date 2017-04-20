<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaTurno.aspx.cs" Inherits="TrabajoPractico.AltaTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos básicos</div>
            <div class="panel-body">

                <div class="form-group">
                    
                    <div class="col-md-12">
                        <asp:DropDownList ID="ddlPersona" runat="server" Enabled="true"  CssClass="form-control" OnLoad="ddlPersona_Load"></asp:DropDownList>
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
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardar_Click" />

                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:GridView ID="gdvTurnos" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">

                <Columns>
                    <asp:BoundField HeaderText="Nombre del Cliente" DataField="nombre" />
                    <asp:BoundField HeaderText="Apellido del Cliente" DataField="apellido" />
                    <asp:BoundField HeaderText="Fecha Registro del Turno" DataField="fechaRegistroTurno" />
                    <asp:BoundField HeaderText="Fecha del Turno" DataField="fechaTurno" />
                    <asp:BoundField HeaderText="Motivos del Turno" DataField="motivosTurno" />
                    <asp:BoundField HeaderText="Tareas a realizar" DataField="tareas" />
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
