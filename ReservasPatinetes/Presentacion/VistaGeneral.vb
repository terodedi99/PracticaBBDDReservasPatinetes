Public Class VistaGeneral
    Private nuevocliente As Boolean
    Private nuevotipo As Boolean
    Private nuevopatinete As Boolean
    Private nuevareserva As Boolean
    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        tabControl.SelectTab(0)
        reset()
    End Sub

    Private Sub bPatinetes_Click(sender As Object, e As EventArgs) Handles btnPatinetes.Click
        tabControl.SelectTab(1)
        resetP()
        resetT()
    End Sub

    Private Sub bReservas_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        tabControl.SelectTab(2)
        resetR()
    End Sub

    Private Sub bConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        tabControl.SelectTab(3)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Sub New()

        'Llamada es exigida por el diseñador.'
        InitializeComponent()

        'Agregar cualquier inicialización después de InitializeComponent().'

        Dim c As New Clientes
        c.leerTodosClientes()
        Dim datos As New DataTable
        datos.Columns.Add("dni", GetType(String))
        datos.Columns.Add("nombre", GetType(String))
        listClientes.DisplayMember = "nombre"
        listClientes.ValueMember = "dni"
        lClientesReservas.DisplayMember = "nombre"
        lClientesReservas.ValueMember = "dni"
        For Each cli As Clientes In c.migestor.plistaClientes
            datos.Rows.Add(cli.pDNI, cli.pNombre & " " & cli.pTelefono & " " & cli.pEmail)
        Next
        listClientes.DataSource = datos
        lClientesReservas.DataSource = datos
        reset()

        Dim tipo As New Tipo_Patinete
        tipo.leerTodosTipo_Patinetes()
        Dim dt As New DataTable
        dt.Columns.Add("id", GetType(String))
        dt.Columns.Add("marca", GetType(String))
        lTipos.DisplayMember = "marca"
        lTipos.ValueMember = "id"
        cPatinete.DisplayMember = "marca"
        cPatinete.ValueMember = "id"
        For Each ti As Tipo_Patinete In tipo.migestor.plistaTipo_Patinete
            dt.Rows.Add(ti.pidTipo, ti.pMarca & " " & ti.pPesoPermitido & " kg " & ti.pVelocidad & " km/h ")
        Next
        lTipos.DataSource = dt
        cPatinete.DataSource = dt
        resetT()

        Dim patinete As New Patinetes
        patinete.leerTodasPatinetes()
        Dim dt2 As New DataTable
        dt2.Columns.Add("id", GetType(String))
        dt2.Columns.Add("Descripcion", GetType(String))
        lPatinetes.DisplayMember = "Descripcion"
        lPatinetes.ValueMember = "id"
        lPatinetesin.DisplayMember = "Descripcion"
        lPatinetesin.ValueMember = "id"
        For Each patin As Patinetes In patinete.migestor.plistaPatinetes
            dt2.Rows.Add(patin.pidPatinete, patin.pDescripcion)
        Next
        lPatinetes.DataSource = dt2
        lPatinetesin.DataSource = dt2
        resetP()

        Dim reserva As New Reservas
        reserva.leerTodosReservas()
        Dim dt3 As New DataTable
        dt3.Columns.Add("id", GetType(String))
        dt3.Columns.Add("Descripcion", GetType(String))
        lReservas.DisplayMember = "Descripcion"
        lReservas.ValueMember = "id"
        For Each res As Reservas In reserva.migestor.plistaReservas
            Dim cli As New Clientes(res.pIdCliente)
            cli.leerCliente()
            dt3.Rows.Add(res.pIdReserva, cli.pNombre & "  " & res.pFechaInicio & "  " & res.pFechaFin)
        Next
        lReservas.DataSource = dt3
        resetR()

    End Sub

    Private Sub bNuevoClientes_Click(sender As Object, e As EventArgs) Handles btnNuevoClientes.Click
        reset()
    End Sub

    Private Sub bEliminarClientes_Click(sender As Object, e As EventArgs) Handles btnEliminarClientes.Click
        Try
            Dim cli As String = listClientes.SelectedValue
            Dim cliente As New Clientes(cli)
            cliente.eliminarCliente()
            Dim DataTable As DataTable = listClientes.DataSource
            DataTable.Rows.RemoveAt(listClientes.SelectedIndex)
            listClientes.DataSource = DataTable
            lClientesReservas.DataSource = DataTable
            MessageBox.Show("El cliente ha sido borrado de la base de datos.")
            reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bGuardarClientes_Click(sender As Object, e As EventArgs) Handles btnGuardarClientes.Click
        Try
            Dim cliente As New Clientes
            cliente.pDNI = txtDNI.Text
            cliente.pNombre = txtNombre.Text
            cliente.pTelefono = Convert.ToInt32(txtTelefono.Text)
            cliente.pDireccion = txtDireccion.Text
            cliente.pEmail = txtEmail.Text
            Dim dt As DataTable = listClientes.DataSource
            If nuevocliente = True Then
                cliente.insertarCliente()
                dt.Rows.Add(cliente.pDNI, cliente.pNombre & " " & cliente.pTelefono & " " & cliente.pEmail)
            Else
                cliente.modificarCliente()
                dt.Rows(listClientes.SelectedIndex).Item(1) = txtNombre.Text & " " & txtTelefono.Text & " " & txtEmail.Text
            End If
            listClientes.DataSource = dt
            lClientesReservas.DataSource = dt
            MessageBox.Show("Los cambios han sido realizados.")
            reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lClientes_Click(sender As Object, e As EventArgs) Handles listClientes.Click
        Try
            Dim cli As String = listClientes.SelectedValue
            Dim cliente As New Clientes(cli)
            cliente.leerCliente()
            txtDNI.Text = cliente.pDNI
            txtNombre.Text = cliente.pNombre
            txtTelefono.Text = cliente.pTelefono
            txtDireccion.Text = cliente.pDireccion
            txtEmail.Text = cliente.pEmail
            nuevocliente = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Sub reset()
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        listClientes.ClearSelected()
        btnNuevoClientes.Enabled = True
        nuevocliente = True
    End Sub

    Private Sub bNuevoTipo_Click(sender As Object, e As EventArgs) Handles bNuevoTipo.Click
        resetT()
    End Sub

    Private Sub bGuardarTipo_Click(sender As Object, e As EventArgs) Handles bGuardarTipo.Click
        Try
            Dim tipo As New Tipo_Patinete
            tipo.pMarca = tMarca.Text
            tipo.pPesoPermitido = Convert.ToInt32(tPeso.Text)
            tipo.pVelocidad = Convert.ToInt32(tVelocidad.Text)
            tipo.pPrecioxHora = Convert.ToDouble(Replace(tPrecio.Text, ".", ","))
            Dim dt As DataTable = lTipos.DataSource
            If nuevotipo = True Then
                tipo.insertarTipo_Patinete()
                dt.Rows.Add(tipo.pidTipo, tipo.pMarca & " " & tipo.pPesoPermitido & " kgs " & tipo.pVelocidad & " km/h ")
            Else
                tipo.pidTipo = lTipos.SelectedValue
                tipo.modificarTipo_Patinete()
                dt.Rows(lTipos.SelectedIndex).Item(1) = tMarca.Text & " " & tipo.pPesoPermitido & " kgs " & tipo.pVelocidad & " km/h "
            End If
            lTipos.DataSource = dt
            MessageBox.Show("Los cambios han sido realizados.")
            resetT()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bEliminarTipo_Click(sender As Object, e As EventArgs) Handles bEliminarTipo.Click
        Try
            Dim t As Integer = lTipos.SelectedValue
            Dim tipo As New Tipo_Patinete(t)
            tipo.eliminarTipo_Patinete()
            Dim DataTable As DataTable = lTipos.DataSource
            DataTable.Rows.RemoveAt(lTipos.SelectedIndex)
            lTipos.DataSource = DataTable
            MessageBox.Show("El tipo de patinete seleccionado ha sido eliminado.")
            resetT()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lTipos_Click(sender As Object, e As EventArgs) Handles lTipos.Click
        Try
            Dim t As Integer = lTipos.SelectedValue
            Dim tipo As New Tipo_Patinete(t)
            tipo.leerTipo_Patinete()
            tMarca.Text = tipo.pMarca
            tPeso.Text = tipo.pPesoPermitido
            tVelocidad.Text = tipo.pVelocidad
            tPrecio.Text = tipo.pPrecioxHora
            nuevotipo = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Sub resetT()
        tMarca.Text = ""
        tPeso.Text = ""
        tVelocidad.Text = ""
        tPrecio.Text = ""
        lTipos.ClearSelected()
        bNuevoTipo.Enabled = True
        nuevotipo = True
    End Sub

    Private Sub bNuevoPatinetes_Click(sender As Object, e As EventArgs) Handles bNuevoPatinetes.Click
        resetP()
    End Sub

    Private Sub bGuardarPatinetes_Click(sender As Object, e As EventArgs) Handles bGuardarPatinetes.Click
        Try
            Dim patinete As New Patinetes
            patinete.pDescripcion = tDescripcion.Text
            patinete.pidTipo = cPatinete.SelectedValue

            Dim dt As DataTable = lPatinetes.DataSource
            If nuevopatinete = True Then
                patinete.insertarPatinete()
                dt.Rows.Add(patinete.pidPatinete, patinete.pDescripcion)
            Else
                patinete.pidPatinete = lPatinetes.SelectedValue
                patinete.modificarPatinete()
                dt.Rows(lPatinetes.SelectedIndex).Item(1) = tDescripcion.Text
            End If
            lPatinetes.DataSource = dt
            lPatinetesin.DataSource = dt
            resetP()
            MessageBox.Show("Los cambios han sido realizados.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bEliminarPatinetes_Click(sender As Object, e As EventArgs) Handles bEliminarPatinetes.Click
        Try
            Dim p As Integer = lPatinetes.SelectedValue
            Dim patinete As New Patinetes(p)
            patinete.eliminarPatinete()
            Dim DataTable As DataTable = lPatinetes.DataSource
            DataTable.Rows.RemoveAt(lPatinetes.SelectedIndex)
            lPatinetes.DataSource = DataTable
            lPatinetesin.DataSource = DataTable
            resetP()
            MessageBox.Show("El patinete ha sido eliminado.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Sub resetP()
        tDescripcion.Text = ""
        lPatinetes.ClearSelected()
        bNuevoPatinetes.Enabled = True
        nuevopatinete = True
    End Sub

    Private Sub lPatinetes_Click(sender As Object, e As EventArgs) Handles lPatinetes.Click
        Try
            Dim p As Integer = lPatinetes.SelectedValue
            Dim patinete As New Patinetes(p)
            patinete.leerPatinete()
            tDescripcion.Text = patinete.pDescripcion
            cPatinete.SelectedValue = patinete.pidTipo
            nuevopatinete = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bNuevaReserva_Click(sender As Object, e As EventArgs) Handles bNuevaReserva.Click
        resetR()
    End Sub

    Private Sub bEliminarReservas_Click(sender As Object, e As EventArgs) Handles bEliminarReservas.Click
        Try
            Dim reserva As New Reservas(lReservas.SelectedValue)
            reserva.eliminarReserva()
            Dim DataTable As DataTable = lReservas.DataSource
            DataTable.Rows.RemoveAt(lReservas.SelectedIndex)
            lReservas.DataSource = DataTable
            resetR()
            MessageBox.Show("La reserva ha sido eliminada.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bGuardarReservas_Click(sender As Object, e As EventArgs) Handles bGuardarReservas.Click
        'Try
        If fstart.Value < fend.Value And Not lClientesReservas.Text = "" Then
            Dim reserva As New Reservas
            reserva.pFechaReserva = Now
            reserva.pFechaInicio = fstart.Value
            reserva.pFechaFin = fend.Value
            reserva.pIdCliente = lClientesReservas.SelectedValue
            reserva.pPrecioReserva = Convert.ToDouble(Replace(tprecioReserva.Text, ".", ","))
            Dim dt As DataTable = lReservas.DataSource
            If nuevareserva = True Then
                reserva.insertarReserva()
                Dim cliente As New Clientes(reserva.pIdCliente)
                cliente.leerCliente()
                dt.Rows.Add(reserva.pIdReserva, cliente.pNombre & "  " & reserva.pFechaInicio & "  " & reserva.pFechaFin)
            Else
                reserva.pIdReserva = lReservas.SelectedValue
                reserva.modificarReserva()
                Dim cliente As New Clientes(reserva.pIdCliente)
                cliente.leerCliente()
                dt.Rows(lReservas.SelectedIndex).Item(1) = cliente.pNombre & "  " & reserva.pFechaInicio & "  " & reserva.pFechaFin
            End If
            lReservas.DataSource = dt
            resetR()
            MessageBox.Show("Se han guardado los cambios correctamente.")
        Else
            MessageBox.Show("Las fechas introducidas son incorrectas o el cliente no ha sido seleccionado.")
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source)
        'End Try
    End Sub

    Private Sub lReservas_Click(sender As Object, e As EventArgs) Handles lReservas.Click
        Try
            Dim reserva As New Reservas(lReservas.SelectedValue)
            reserva.leerReserva()
            fstart.Value = reserva.pFechaInicio
            fend.Value = reserva.pFechaFin
            lClientesReservas.SelectedValue = reserva.pIdCliente
            tprecioReserva.Text = reserva.pPrecioReserva
            Dim data As New DataTable
            data.Columns.Add("id", GetType(String))
            data.Columns.Add("nombre", GetType(String))
            lpatinetesout.DisplayMember = "nombre"
            lpatinetesout.ValueMember = "id"
            For Each patin As Patinetes In reserva.pListaPatinetes
                data.Rows.Add(patin.pidPatinete, patin.pDescripcion)
            Next
            lpatinetesout.DataSource = data
            nuevareserva = False
            lPatinetesin.Enabled = True
            lpatinetesout.Enabled = True
            bin.Enabled = True
            bout.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Sub resetR()
        fstart.Value = Now
        fend.Value = Now
        lReservas.ClearSelected()
        bNuevaReserva.Enabled = True
        lClientesReservas.ClearSelected()
        lPatinetesin.ClearSelected()
        tprecioReserva.Text = 0
        nuevareserva = True
        lPatinetesin.Enabled = False
        lpatinetesout.Enabled = False
        bin.Enabled = False
        bout.Enabled = False
    End Sub

    Private Sub bin_Click(sender As Object, e As EventArgs) Handles bin.Click
        Try
            Dim patinete As New Patinetes(lPatinetesin.SelectedValue)
            Dim reserva As New Reservas(lReservas.SelectedValue)
            reserva.esPosible(patinete)
            If patinete.pDescripcion = "True" Then
                reserva.leerReserva()
                patinete.leerPatinete()
                Dim tipo As New Tipo_Patinete(patinete.pidTipo)
                tipo.leerTipo_Patinete()
                reserva.insertarPatinete(patinete)


                Dim dt As DataTable = lpatinetesout.DataSource
                If IsNothing(dt) Then
                    dt = New DataTable
                    dt.Columns.Add("id", GetType(String))
                    dt.Columns.Add("Name", GetType(String))
                    lpatinetesout.DisplayMember = "Name"
                    lpatinetesout.ValueMember = "id"
                End If
                dt.Rows.Add(patinete.pidPatinete, patinete.pDescripcion)
                lpatinetesout.DataSource = dt
                tprecioReserva.Text = Convert.ToInt32(tprecioReserva.Text) + DateDiff(DateInterval.Hour, reserva.pFechaInicio, reserva.pFechaFin) * tipo.pPrecioxHora
                lPatinetesin.ClearSelected()
            Else
                MessageBox.Show("El patinete seleccionado no se encuentra disponible para reservar.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub bout_Click(sender As Object, e As EventArgs) Handles bout.Click
        Try
            Dim patinete As New Patinetes(lpatinetesout.SelectedValue)
            patinete.leerPatinete()
            Dim tipo As New Tipo_Patinete(patinete.pidTipo)
            tipo.leerTipo_Patinete()
            Dim reserva As New Reservas(lReservas.SelectedValue)
            reserva.leerReserva()
            reserva.eliminarPatinete(patinete)
            Dim dt As DataTable = lpatinetesout.DataSource
            dt.Rows.RemoveAt(lpatinetesout.SelectedIndex)
            lpatinetesout.DataSource = dt
            tprecioReserva.Text = Convert.ToInt32(tprecioReserva.Text) - DateDiff(DateInterval.Hour, reserva.pFechaInicio, reserva.pFechaFin) * tipo.pPrecioxHora
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged
        If dInicio.Value < dfin.Value Then
            Dim cliente As New Clientes
            gridConsultas.DataSource = cliente.historial(dInicio.Value, dfin.Value)
        Else
            MessageBox.Show("La fecha de fin debe superar la fecha de inicio.")
        End If
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs) Handles r2.CheckedChanged
        If dInicio.Value < dfin.Value Then
            Dim patin As New Patinetes
            gridConsultas.DataSource = patin.historial(dInicio.Value, dfin.Value)
        Else
            MessageBox.Show("La fecha de fin debe superar la fecha de inicio.")
        End If
    End Sub

    Private Sub r3_CheckedChanged(sender As Object, e As EventArgs) Handles r3.CheckedChanged
        If dInicio.Value < dfin.Value Then
            Dim patin As New Patinetes
            gridConsultas.DataSource = patin.ranking(dInicio.Value, dfin.Value)
        Else
            MessageBox.Show("La fecha de fin debe superar la fecha de inicio.")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblClientes.Click

    End Sub

    Private Sub LClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listClientes.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class