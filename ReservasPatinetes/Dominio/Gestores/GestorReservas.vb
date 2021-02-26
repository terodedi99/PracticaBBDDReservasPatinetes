Imports System.Data.OleDb
Public Class GestorReservas
    Private listaReservas As Collection
    Private miAgente As AgenteBD

    Public Sub New()
        listaReservas = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    Public ReadOnly Property plistaReservas As Collection
        Get
            Return listaReservas
        End Get
    End Property

    Public Sub insertReserva(reserva As Reservas)
        miAgente.modificar("Insert into Reservas (Fecha_inicio,Fecha_fin,idCliente,Fecha_Reserva,Precio_Reserva) values
                           ('" & FormatDateTime(reserva.pFechaInicio, DateFormat.GeneralDate) & "'
                            ,'" & FormatDateTime(reserva.pFechaFin, DateFormat.GeneralDate) & "'
                            ,'" & reserva.pIdCliente & "','" & FormatDateTime(reserva.pFechaReserva, DateFormat.GeneralDate) & "'
                            ," & reserva.pPrecioReserva & ");")
        readId(reserva)
        For Each patin As Patinetes In reserva.pListaPatinetes
            miAgente.modificar("Insert into uso_patinetes values (" & reserva.pIdReserva & "
                            ," & patin.pidPatinete & ");")
        Next

    End Sub

    Public Sub insertarPatineteReserva(reserva As Reservas, patinete As Patinetes)
        miAgente.modificar("Insert into uso_patinetes values (" & reserva.pIdReserva & "," & patinete.pidPatinete & " );")
    End Sub
    Public Sub deleteReserva(reserva As Reservas)
        miAgente.modificar("DELETE FROM Reservas WHERE idReserva=" & reserva.pIdReserva & ";")
    End Sub

    Public Sub deletePatineteReserva(reserva As Reservas, patinete As Patinetes)
        miAgente.modificar("DELETE FROM uso_patinetes WHERE idReserva=" & reserva.pIdReserva & " and idPatinete=" & patinete.pidPatinete & ";")
    End Sub

    Public Sub updateReserva(reserva As Reservas)
        miAgente.modificar("update Reservas set Fecha_inicio = '" & FormatDateTime(reserva.pFechaInicio, DateFormat.GeneralDate) & "'
                            , Fecha_fin ='" & FormatDateTime(reserva.pFechaFin, DateFormat.GeneralDate) & "'
                            , idCliente='" & reserva.pIdCliente & "'
                            , Fecha_Reserva ='" & FormatDateTime(reserva.pFechaReserva, DateFormat.GeneralDate) & "' 
                            , Precio_Reserva=" & reserva.pPrecioReserva & " WHERE idReserva=" & reserva.pIdReserva & ";")

    End Sub

    Public Sub readId(ByRef reserva As Reservas)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT MAX(idReserva) FROM Reservas;")

        If lista.Read() Then
            reserva.pIdReserva = Convert.ToInt32(lista(0))
        End If
    End Sub
    Public Sub readReserva(ByRef reserva As Reservas)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT * FROM Reservas WHERE idReserva=" & reserva.pIdReserva & ";")

        If lista.Read() Then
            reserva.pFechaInicio = lista(1)
            reserva.pFechaFin = lista(2)
            reserva.pIdCliente = lista(3)
            reserva.pFechaReserva = lista(4)
            reserva.pPrecioReserva = lista(5)
        End If

        lista = miAgente.leer("SELECT idPatinete FROM uso_patinetes WHERE idReserva=" & reserva.pIdReserva & ";")
        Dim patinete As Patinetes
        While lista.Read()
            patinete = New Patinetes(lista(0))
            patinete.leerPatinete()
            reserva.pListaPatinetes.Add(patinete)
        End While

    End Sub

    Public Sub readAllReservas()
        Dim lista As OleDbDataReader = miAgente.leer("Select idReserva from Reservas;")
        Dim reserva As Reservas

        While lista.Read()
            reserva = New Reservas(lista(0))
            reserva.leerReserva()
            listaReservas.Add(reserva)
        End While
    End Sub

    Public Sub isPossible(patinete As Patinetes)
        Dim lista As OleDbDataReader = miAgente.leer("Select USO_PATINETES.IdPatinete
        From USO_PATINETES Where (((USO_PATINETES.IdPatinete) = " & patinete.pidPatinete & "));")
        If lista.Read() Then
            patinete.pDescripcion = "False"
        Else
            patinete.pDescripcion = "True"
        End If
    End Sub

End Class
