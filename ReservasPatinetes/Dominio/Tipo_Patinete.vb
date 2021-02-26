Public Class Tipo_Patinete
    Private identificacionTipo As Integer
    Private marca As String
    Private pesoPerm As Integer
    Private velocidad As Integer
    Private precioHora As Double
    Private gestor As GestorTipo_Patinete

    Sub New()
        gestor = New GestorTipo_Patinete
    End Sub

    Sub New(ByVal idTipo As Integer)
        gestor = New GestorTipo_Patinete
        Me.identificacionTipo = idTipo
    End Sub

    Sub New(ByVal idTipo As String, ByVal Marca As String, ByVal PersoPermitido As Integer, ByVal Velocidad As Integer, ByVal PrecioxHora As Double)
        gestor = New GestorTipo_Patinete
        Me.identificacionTipo = idTipo
        Me.marca = Marca
        Me.pesoPerm = PersoPermitido
        Me.velocidad = Velocidad
        Me.precioHora = PrecioxHora
    End Sub

    Public ReadOnly Property migestor As GestorTipo_Patinete
        Get
            Return gestor
        End Get
    End Property

    Public Property pidTipo As Integer
        Get
            Return identificacionTipo
        End Get
        Set(value As Integer)
            identificacionTipo = value
        End Set
    End Property
    Public Property pMarca As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property pPesoPermitido As Integer
        Get
            Return pesoPerm
        End Get
        Set(value As Integer)
            pesoPerm = value
        End Set
    End Property

    Public Property pVelocidad As Integer
        Get
            Return velocidad
        End Get
        Set(value As Integer)
            velocidad = value
        End Set
    End Property

    Public Property pPrecioxHora As Double
        Get
            Return precioHora
        End Get
        Set(value As Double)
            precioHora = value
        End Set
    End Property

    Public Sub insertarTipo_Patinete()
        gestor.insertTipo_Patinete(Me)
    End Sub
    Public Sub eliminarTipo_Patinete()
        gestor.deleteTipo_Patinete(Me)
    End Sub
    Public Sub modificarTipo_Patinete()
        gestor.updateTipo_Patinete(Me)
    End Sub
    Public Sub leerTipo_Patinete()
        gestor.readTipo_Patinete(Me)
    End Sub
    Public Sub leerTodosTipo_Patinetes()
        gestor.readAllTipo_Patinetes()
    End Sub

End Class
