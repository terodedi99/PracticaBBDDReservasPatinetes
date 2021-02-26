Public Class Clientes
    Private DNI As String
    Private nombre As String
    Private numTlfn As Integer
    Private dir As String
    Private e_mail As String
    Private gestor As GestorClientes

    Sub New()
        gestor = New GestorClientes
    End Sub

    Sub New(ByVal DNI As String)
        gestor = New GestorClientes
        Me.DNI = DNI
    End Sub

    Sub New(ByVal DNI As String, ByVal Nombre As String, ByVal Telefono As Integer, ByVal Direccion As String, ByVal Email As String)
        gestor = New GestorClientes
        Me.DNI = DNI
        Me.nombre = Nombre
        Me.numTlfn = Telefono
        Me.dir = Direccion
        Me.e_mail = Email
    End Sub

    Public ReadOnly Property migestor As GestorClientes
        Get
            Return gestor
        End Get
    End Property

    Public Property pDNI As String
        Get
            Return DNI
        End Get
        Set(value As String)
            DNI = value
        End Set
    End Property

    Public Property pNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property pTelefono As Integer
        Get
            Return numTlfn
        End Get
        Set(value As Integer)
            numTlfn = value
        End Set
    End Property

    Public Property pDireccion As String
        Get
            Return dir
        End Get
        Set(value As String)
            dir = value
        End Set
    End Property

    Public Property pEmail As String
        Get
            Return e_mail
        End Get
        Set(value As String)
            e_mail = value
        End Set
    End Property

    Public Sub insertarCliente()
        gestor.insertCliente(Me)
    End Sub
    Public Sub eliminarCliente()
        gestor.deleteCliente(Me)
    End Sub
    Public Sub modificarCliente()
        gestor.updateCliente(Me)
    End Sub
    Public Sub leerCliente()
        gestor.readCliente(Me)
    End Sub
    Public Sub leerTodosClientes()
        gestor.readAllClientes()
    End Sub

    Public Sub comprobarTablasBd()
        gestor.tablasbDexistentes()
    End Sub
    Public Function historial(inicio As Date, fin As Date) As DataTable
        Return gestor.historialClientes(inicio, fin)
    End Function

End Class