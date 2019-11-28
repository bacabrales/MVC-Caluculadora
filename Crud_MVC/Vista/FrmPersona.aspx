<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPersona.aspx.cs" Inherits="Crud_MVC.Vista.FrmPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CRUD</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <div class="border w-50 m-auto ">
                        <div class="form-group">
                            <label>Nombre: </label>
                            <input class="form-control" type="text" id="txtNombre" runat="server" placeholder="Nombre" />
                        </div>
                        <div class="form-group">
                            <label>Apellido: </label>
                            <input class="form-control" type="text" id="txtApellido" runat="server" placeholder="Apellido" />
                        </div>
                        <div class="form-group">
                            <label>Edad: </label>
                            <input class="form-control" type="text" id="txtEdad" runat="server" placeholder="Edad" />
                        </div>
                    </div>
                    
            <p>
                
            </p>
            <p>
                
            </p>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                </div>
            </div>
        </div>
        <div>
            <asp:DataGrid runat="server" ID="dvgDatos" AutoGenerateColumns="False" OnEditCommand="dvgDatos_edit" OnDeleteCommand="dvgDatos_delete">
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
