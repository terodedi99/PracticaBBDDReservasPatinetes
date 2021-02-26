Imports System.Data.OleDb

Public Class GestorPatinetes
    Private listaPatinetes As Collection
    Private miAgente As AgenteBD

    Public Sub New()
        listaPatinetes = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    Public ReadOnly Property plistaPatinetes As Collection
        Get
            Return listaPatinetes
        End Get
    End Property

    Public Sub insertPatinete(patinete As Patinetes)
        miAgente.modificar("Insert into Patinetes (Descripción,idTipo) values ('" & patinete.pDescripcion & "'
                            ," & patinete.pidTipo & ");")
        readId(patinete)
    End Sub

    Public Sub deletePatinete(patinete As Patinetes)
        miAgente.modificar("DELETE FROM Patinetes WHERE idPatinete=" & patinete.pidPatinete & ";")
    End Sub

    Public Sub updatePatinete(patinete As Patinetes)
        miAgente.modificar("update Patinetes set Descripción = '" & patinete.pDescripcion & "', idTipo =" & patinete.pidTipo & "
         WHERE idPatinete=" & patinete.pidPatinete & ";")

    End Sub
    Public Sub readId(ByRef patinete As Patinetes)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT MAX(idPatinete) FROM Patinetes;")

        If lista.Read() Then
            patinete.pidPatinete = Convert.ToInt32(lista(0))
        End If
    End Sub


    Public Sub readPatinete(ByRef patinete As Patinetes)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT * FROM Patinetes WHERE idPatinete=" & patinete.pidPatinete & ";")

        If lista.Read() Then
            patinete.pDescripcion = lista(1)
            patinete.pidTipo = lista(2)
        End If
    End Sub

    Public Sub readAllPatinetes()
        Dim lista As OleDbDataReader = miAgente.leer("Select idPatinete from Patinetes;")
        Dim patinete As Patinetes

        While lista.Read()
            patinete = New Patinetes(lista(0))
            readPatinete(patinete)
            listaPatinetes.Add(patinete)
        End While
    End Sub

    Public Function historialPatinetes(inicio As Date, fin As Date) As DataTable
        Dim lista As OleDbDataReader = miAgente.leer("SELECT PATINETES.Descripción, Tipo_Patinete.Marca, Reservas.Fecha_inicio, Reservas.Fecha_fin, Clientes.DNI, Clientes.Nombre
From TIPO_PATINETE INNER Join (PATINETES INNER Join ((CLIENTES INNER Join RESERVAS On Clientes.DNI = RESERVAS.IdCliente) INNER Join USO_PATINETES On RESERVAS.IdReserva = USO_PATINETES.IdReserva) ON PATINETES.IdPatinete = USO_PATINETES.IdPatinete) ON TIPO_PATINETE.IdTipo = PATINETES.IdTipo
Where (((RESERVAS.Fecha_inicio) >= #" & FormatDateTime(inicio, DateFormat.GeneralDate) & "#) And ((RESERVAS.Fecha_fin) <=  #" & FormatDateTime(fin, DateFormat.GeneralDate) & "#))
Order By Patinetes.Descripción, TIPO_PATINETE.Marca;")
        Dim dt As New DataTable
        dt.Load(lista)
        Return dt
    End Function

    Public Function rankingTipos(inicio As Date, fin As Date) As DataTable
        Dim lista As OleDbDataReader = miAgente.leer("SELECT TIPO_PATINETE.Marca, Sum(Reservas.Precio_Reserva) AS Total
From RESERVAS INNER Join ((TIPO_PATINETE INNER Join PATINETES On Tipo_Patinete.idTipo = PATINETES.IdTipo) INNER Join USO_PATINETES On PATINETES.IdPatinete = USO_PATINETES.IdPatinete) ON RESERVAS.IdReserva = USO_PATINETES.IdReserva
Where (((RESERVAS.Fecha_inicio) >= #" & FormatDateTime(inicio, DateFormat.GeneralDate) & "#) And ((RESERVAS.Fecha_fin) <=  #" & FormatDateTime(fin, DateFormat.GeneralDate) & "#))
Group By Tipo_Patinete.Marca;")
        Dim dt As New DataTable
        dt.Load(lista)
        Return dt
    End Function



End Class
