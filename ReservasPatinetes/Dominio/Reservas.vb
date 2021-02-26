Public Class Reservas
    Private identificacionReserva As Integer
    Private fechaIni As Date
    Private fechaFin As Date
    Private identificacionCliente As String
    Private fechaReserva As Date
    Private precioReserva As Integer
    Private listaPatinetes As Collection
    Private gestor As GestorReservas

    Sub New()
        gestor = New GestorReservas
        listaPatinetes = New Collection
    End Sub

    Sub New(ByVal idReserva As Integer)
        gestor = New GestorReservas
        Me.identificacionReserva = idReserva
        listaPatinetes = New Collection
    End Sub

    Sub New(ByVal idReserva As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal idCliente As String, ByVal FechaReserva As Date, PrecioReserva As Integer)
        gestor = New GestorReservas
        Me.identificacionReserva = idReserva
        Me.fechaIni = FechaInicio
        Me.fechaFin = FechaFin
        Me.identificacionCliente = idCliente
        Me.fechaReserva = FechaReserva
        Me.precioReserva = PrecioReserva
        listaPatinetes = New Collection
    End Sub

    Public ReadOnly Property migestor As GestorReservas
        Get
            Return gestor
        End Get
    End Property

    Public Property pIdReserva As Integer
        Get
            Return identificacionReserva
        End Get
        Set(value As Integer)
            identificacionReserva = value
        End Set
    End Property

    Public Property pFechaInicio As Date
        Get
            Return fechaIni
        End Get
        Set(value As Date)
            fechaIni = value
        End Set
    End Property

    Public Property pFechaFin As Date
        Get
            Return fechaFin
        End Get
        Set(value As Date)
            fechaFin = value
        End Set
    End Property

    Public Property pIdCliente As String
        Get
            Return identificacionCliente
        End Get
        Set(value As String)
            identificacionCliente = value
        End Set
    End Property

    Public Property pFechaReserva As Date
        Get
            Return fechaReserva
        End Get
        Set(value As Date)
            fechaReserva = value
        End Set
    End Property

    Public Property pPrecioReserva As Integer
        Get
            Return precioReserva
        End Get
        Set(value As Integer)
            precioReserva = value
        End Set
    End Property

    Public Property pListaPatinetes As Collection
        Get
            Return listaPatinetes
        End Get
        Set(value As Collection)
            listaPatinetes = value
        End Set
    End Property

    Public Sub insertarReserva()
        gestor.insertReserva(Me)
    End Sub

    Public Sub insertarPatinete(patinete As Patinetes)
        gestor.insertarPatineteReserva(Me, patinete)
    End Sub
    Public Sub eliminarReserva()
        gestor.deleteReserva(Me)
    End Sub
    Public Sub eliminarPatinete(patinete As Patinetes)
        gestor.deletePatineteReserva(Me, patinete)
    End Sub
    Public Sub modificarReserva()
        gestor.updateReserva(Me)
    End Sub
    Public Sub leerReserva()
        gestor.readReserva(Me)
    End Sub
    Public Sub leerTodosReservas()
        gestor.readAllReservas()
    End Sub
    Public Sub esPosible(patiente As Patinetes)
        gestor.isPossible(patiente)
    End Sub

End Class
