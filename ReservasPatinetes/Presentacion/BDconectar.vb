Public Class BDconectar
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            Dim comprobar As New Clientes
            comprobar.comprobarTablasBd()
            MessageBox.Show("Conexión establecida, base de datos comprobada y contiene todas las tablas.")
            VistaGeneral.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos." & vbNewLine & "Pruebe de nuevo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgenteBD.mInstancia = Nothing
        End Try
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Try
            btnConectar.Enabled = False

            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = Application.StartupPath.Replace("ReservasPatinetes\bin\Debug", "")
            openFileDialog1.Filter = "Ficheros de bases de datos (*.accdb)|*.accdb|All files (*.*)|*.*"
            openFileDialog1.RestoreDirectory = True

            If (openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                txtRuta.Text = openFileDialog1.FileName()
                btnConectar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            btnConectar.Enabled = False

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub TxtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
