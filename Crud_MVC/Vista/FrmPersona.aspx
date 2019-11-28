<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPersona.aspx.cs" Inherits="Crud_MVC.Vista.FrmPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <input type="text" id="txtNombre" runat="server" placeholder="Nombre" />
            </p>
            <p>
                <input type="text" id="txtApellido" runat="server" placeholder="Apellido" />
            </p>
            <p>
                <input type="text" id="txtEdad" runat="server" placeholder="Edad" />
            </p>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
        </div>
        <div>
            <asp:DataGrid runat="server" ID="dvgDatos" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundColumn DataField="id" HeaderText="ID" SortExpression="id"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nombre" HeaderText="Nombre" SortExpression="id"></asp:BoundColumn>
                    <asp:BoundColumn DataField="apellido" HeaderText="Apellido" SortExpression="id"></asp:BoundColumn>
                    <asp:BoundColumn DataField="edad" HeaderText="Edad" SortExpression="id"></asp:BoundColumn>
                    <asp:ButtonColumn CommandName="Delete" HeaderText="Eliminar" Text="Eliminar"></asp:ButtonColumn>
                    <asp:EditCommandColumn CancelText="Cancelar" EditText="Editar" HeaderText="Modificar" UpdateText="Actualizar"></asp:EditCommandColumn>
                </Columns>
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
