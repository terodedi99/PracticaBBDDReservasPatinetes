Public Class Patinetes
    Private identificacionPatinete As Integer
    Private descrip As String
    Private identificacionTipo As Integer
    Private gestor As GestorPatinetes


    Sub New()
        gestor = New GestorPatinetes
    End Sub

    Sub New(ByVal idPatinete As Integer)
        gestor = New GestorPatinetes
        Me.identificacionPatinete = idPatinete
    End Sub

    Sub New(ByVal idPatinete As Integer, ByVal Descripcion As String, ByVal idTipo As Integer)
        gestor = New GestorPatinetes
        Me.identificacionPatinete = idPatinete
        Me.descrip = Descripcion
        Me.identificacionTipo = idTipo
    End Sub

    Public ReadOnly Property migestor As GestorPatinetes
        Get
            Return gestor
        End Get
    End Property

    Public Property pidPatinete As Integer
        Get
            Return identificacionPatinete
        End Get
        Set(value As Integer)
            identificacionPatinete = value
        End Set
    End Property

    Public Property pDescripcion As String
        Get
            Return descrip
        End Get
        Set(value As String)
            descrip = value
        End Set
    End Property

    Public Property pidTipo As Integer
        Get
            Return identificacionTipo
        End Get
        Set(value As Integer)
            identificacionTipo = value
        End Set
    End Property

    Public Function historial(inicio As Date, fin As Date) As DataTable
        Return gestor.historialPatinetes(inicio, fin)
    End Function

    Public Function ranking(inicio As Date, fin As Date) As DataTable
        Return gestor.rankingTipos(inicio, fin)
    End Function
    Public Sub insertarPatinete()
        gestor.insertPatinete(Me)
    End Sub
    Public Sub eliminarPatinete()
        gestor.deletePatinete(Me)
    End Sub
    Public Sub modificarPatinete()
        gestor.updatePatinete(Me)
    End Sub
    Public Sub leerPatinete()
        gestor.readPatinete(Me)
    End Sub
    Public Sub leerTodasPatinetes()
        gestor.readAllPatinetes()
    End Sub

End Class
