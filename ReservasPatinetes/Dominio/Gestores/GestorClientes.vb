Imports System.Data.OleDb

Public Class GestorClientes
    Private listaClientes As Collection
    Private miAgente As AgenteBD

    Public Sub New()
        listaClientes = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    Public ReadOnly Property plistaClientes As Collection
        Get
            Return listaClientes
        End Get
    End Property

    Public Sub insertCliente(cliente As Clientes)
        miAgente.modificar("Insert into Clientes values ('" & cliente.pDNI & "','" & cliente.pNombre & "'
                            ," & cliente.pTelefono & ",'" & cliente.pDireccion & "','" & cliente.pEmail & "');")
    End Sub

    Public Sub deleteCliente(cliente As Clientes)
        miAgente.modificar("DELETE FROM Clientes WHERE DNI='" & cliente.pDNI & "';")
    End Sub

    Public Sub updateCliente(cliente As Clientes)
        miAgente.modificar("update Clientes set Nombre = '" & cliente.pNombre & "', Teléfono =" & cliente.pTelefono & "
        , Dirección='" & cliente.pDireccion & "', Email ='" & cliente.pEmail & "' WHERE DNI='" & cliente.pDNI & "';")

    End Sub

    Public Sub readCliente(ByRef cliente As Clientes)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT * FROM Clientes WHERE DNI='" & cliente.pDNI & "'")

        If lista.Read() Then
            cliente.pNombre = lista(1)
            cliente.pTelefono = lista(2)
            cliente.pDireccion = lista(3)
            cliente.pEmail = lista(4)
        End If
    End Sub

    Public Sub readAllClientes()
        Dim lista As OleDbDataReader = miAgente.leer("Select DNI from Clientes;")
        Dim cliente As Clientes

        While lista.Read()
            cliente = New Clientes(lista(0))
            readCliente(cliente)
            listaClientes.Add(cliente)
        End While
    End Sub

    Public Function historialClientes(inicio As Date, fin As Date) As DataTable
        Dim lista As OleDbDataReader = miAgente.leer("SELECT CLIENTES.DNI, Clientes.Nombre, Reservas.Fecha_inicio, Reservas.Fecha_fin, Patinetes.Descripción
FROM(Clientes INNER JOIN RESERVAS On CLIENTES.DNI = RESERVAS.IdCliente) INNER JOIN (PATINETES INNER JOIN USO_PATINETES On PATINETES.IdPatinete = USO_PATINETES.IdPatinete) On RESERVAS.IdReserva = USO_PATINETES.IdReserva
WHERE(((Reservas.Fecha_inicio) >= #" & FormatDateTime(inicio, DateFormat.GeneralDate) & "#) And ((Reservas.Fecha_fin) <= #" & FormatDateTime(fin, DateFormat.GeneralDate) & "#))
        ORDER BY CLIENTES.Nombre, Patinetes.Descripción;")
        Dim dt As New DataTable
        dt.Load(lista)
        Return dt
    End Function

    Public Sub tablasbDexistentes()
        Dim lista As OleDbDataReader
        lista = miAgente.leer("Select * from Clientes;")
        lista = miAgente.leer("Select * from Patinetes;")
        lista = miAgente.leer("Select * from Reservas;")
        lista = miAgente.leer("Select * from Tipo_Patinete;")
        lista = miAgente.leer("Select * from Uso_Patinetes;")
    End Sub

End Class
