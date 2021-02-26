Imports System.Data.OleDb
Public Class GestorTipo_Patinete
    Private listaTipo_Patinete As Collection
    Private miAgente As AgenteBD

    Public Sub New()
        listaTipo_Patinete = New Collection
        miAgente = AgenteBD.getAgente()
    End Sub

    Public ReadOnly Property plistaTipo_Patinete As Collection
        Get
            Return listaTipo_Patinete
        End Get
    End Property

    Public Sub insertTipo_Patinete(tipo_patinete As Tipo_Patinete)
        miAgente.modificar("Insert into Tipo_Patinete (Marca,PesoPermitido,Velocidad,PrecioxHora) values
                           ('" & tipo_patinete.pMarca & "'," & tipo_patinete.pPesoPermitido & "
                            ," & tipo_patinete.pVelocidad & ",'" & tipo_patinete.pPrecioxHora & "');")
        readId(tipo_patinete)
    End Sub

    Public Sub deleteTipo_Patinete(tipo_patinete As Tipo_Patinete)
        miAgente.modificar("DELETE FROM Tipo_Patinete WHERE idTipo=" & tipo_patinete.pidTipo & ";")
    End Sub

    Public Sub updateTipo_Patinete(tipo_patinete As Tipo_Patinete)
        miAgente.modificar("update Tipo_Patinete set Marca = '" & tipo_patinete.pMarca & "',PesoPermitido =" & tipo_patinete.pPesoPermitido & "
        ,Velocidad=" & tipo_patinete.pVelocidad & ", PrecioxHora =" & tipo_patinete.pPrecioxHora & " WHERE idTipo=" & tipo_patinete.pidTipo & ";")

    End Sub
    Public Sub readId(ByRef tipo As Tipo_Patinete)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT MAX(idTipo) FROM Tipo_Patinete;")

        If lista.Read() Then
            tipo.pidTipo = Convert.ToInt32(lista(0))
        End If
    End Sub
    Public Sub readTipo_Patinete(ByRef tipo_patinete As Tipo_Patinete)
        Dim lista As OleDbDataReader = miAgente.leer("SELECT * FROM Tipo_Patinete WHERE idTipo=" & tipo_patinete.pidTipo)

        If lista.Read() Then
            tipo_patinete.pMarca = lista(1)
            tipo_patinete.pPesoPermitido = lista(2)
            tipo_patinete.pVelocidad = lista(3)
            tipo_patinete.pPrecioxHora = lista(4)
        End If
    End Sub

    Public Sub readAllTipo_Patinetes()
        Dim lista As OleDbDataReader = miAgente.leer("Select idTipo from Tipo_Patinete;")
        Dim tipo_patinete As Tipo_Patinete

        While lista.Read()
            tipo_patinete = New Tipo_Patinete(lista(0))
            readTipo_Patinete(tipo_patinete)
            listaTipo_Patinete.Add(tipo_patinete)
        End While
    End Sub



End Class
