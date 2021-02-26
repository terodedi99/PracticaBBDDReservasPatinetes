Imports System.Data.OleDb
Public Class AgenteBD

    Private Shared CadConexion
    Private Shared mConexion As OleDbConnection
    Public Shared mInstancia As AgenteBD 'La usaremos para comunicarnos con la BBDD.'

    Private Sub New()
        CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & BDconectar.txtRuta.Text
        AgenteBD.mConexion = New OleDbConnection(CadConexion)
        AgenteBD.mConexion.Open()
    End Sub

    Public Shared Function getAgente() As AgenteBD

        If mInstancia Is Nothing Then
            mInstancia = New AgenteBD()
        End If

        Return mInstancia
    End Function

    ReadOnly Property get_oleDb() As OleDbConnection
        Get
            Return mConexion
        End Get
    End Property

    Public Function modificar(ByVal sql As String) As Integer

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()

    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()

    End Function
End Class
