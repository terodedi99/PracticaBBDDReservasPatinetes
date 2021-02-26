<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaGeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabCli = New System.Windows.Forms.TabPage()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnGuardarClientes = New System.Windows.Forms.Button()
        Me.btnEliminarClientes = New System.Windows.Forms.Button()
        Me.btnNuevoClientes = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.listClientes = New System.Windows.Forms.ListBox()
        Me.tabPatin = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tPrecio = New System.Windows.Forms.TextBox()
        Me.tVelocidad = New System.Windows.Forms.TextBox()
        Me.tPeso = New System.Windows.Forms.TextBox()
        Me.tMarca = New System.Windows.Forms.TextBox()
        Me.bGuardarTipo = New System.Windows.Forms.Button()
        Me.lTipos = New System.Windows.Forms.ListBox()
        Me.bNuevoTipo = New System.Windows.Forms.Button()
        Me.bEliminarTipo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bGuardarPatinetes = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lPatinetes = New System.Windows.Forms.ListBox()
        Me.cPatinete = New System.Windows.Forms.ComboBox()
        Me.bNuevoPatinetes = New System.Windows.Forms.Button()
        Me.tDescripcion = New System.Windows.Forms.TextBox()
        Me.bEliminarPatinetes = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabRes = New System.Windows.Forms.TabPage()
        Me.lpatinetesout = New System.Windows.Forms.ListBox()
        Me.lPatinetesin = New System.Windows.Forms.ListBox()
        Me.bout = New System.Windows.Forms.Button()
        Me.bin = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bGuardarReservas = New System.Windows.Forms.Button()
        Me.bNuevaReserva = New System.Windows.Forms.Button()
        Me.bEliminarReservas = New System.Windows.Forms.Button()
        Me.lClientesReservas = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tprecioReserva = New System.Windows.Forms.TextBox()
        Me.fend = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fstart = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lReservas = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tabCons = New System.Windows.Forms.TabPage()
        Me.r3 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.gridConsultas = New System.Windows.Forms.DataGridView()
        Me.dfin = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnReservas = New System.Windows.Forms.Button()
        Me.btnPatinetes = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tabControl.SuspendLayout()
        Me.tabCli.SuspendLayout()
        Me.tabPatin.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabRes.SuspendLayout()
        Me.tabCons.SuspendLayout()
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabCli)
        Me.tabControl.Controls.Add(Me.tabPatin)
        Me.tabControl.Controls.Add(Me.tabRes)
        Me.tabControl.Controls.Add(Me.tabCons)
        Me.tabControl.Location = New System.Drawing.Point(120, 24)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Padding = New System.Drawing.Point(0, 0)
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(851, 640)
        Me.tabControl.TabIndex = 9
        '
        'tabCli
        '
        Me.tabCli.BackColor = System.Drawing.Color.GhostWhite
        Me.tabCli.Controls.Add(Me.lblClientes)
        Me.tabCli.Controls.Add(Me.txtEmail)
        Me.tabCli.Controls.Add(Me.lblemail)
        Me.tabCli.Controls.Add(Me.lbldireccion)
        Me.tabCli.Controls.Add(Me.lblTelefono)
        Me.tabCli.Controls.Add(Me.lblNombre)
        Me.tabCli.Controls.Add(Me.lblDNI)
        Me.tabCli.Controls.Add(Me.btnGuardarClientes)
        Me.tabCli.Controls.Add(Me.btnEliminarClientes)
        Me.tabCli.Controls.Add(Me.btnNuevoClientes)
        Me.tabCli.Controls.Add(Me.txtDireccion)
        Me.tabCli.Controls.Add(Me.txtTelefono)
        Me.tabCli.Controls.Add(Me.txtNombre)
        Me.tabCli.Controls.Add(Me.txtDNI)
        Me.tabCli.Controls.Add(Me.listClientes)
        Me.tabCli.Location = New System.Drawing.Point(4, 22)
        Me.tabCli.Name = "tabCli"
        Me.tabCli.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCli.Size = New System.Drawing.Size(843, 614)
        Me.tabCli.TabIndex = 0
        Me.tabCli.Text = "CLIENTES"
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Nirmala UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(26, 49)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(178, 53)
        Me.lblClientes.TabIndex = 147
        Me.lblClientes.Text = "Clientes"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(476, 295)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(233, 22)
        Me.txtEmail.TabIndex = 146
        '
        'lblemail
        '
        Me.lblemail.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(410, 298)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(63, 22)
        Me.lblemail.TabIndex = 145
        Me.lblemail.Text = "Email:"
        '
        'lbldireccion
        '
        Me.lbldireccion.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(381, 260)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(92, 22)
        Me.lbldireccion.TabIndex = 144
        Me.lbldireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(387, 221)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(86, 22)
        Me.lblTelefono.TabIndex = 143
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(397, 183)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 22)
        Me.lblNombre.TabIndex = 142
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDNI
        '
        Me.lblDNI.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(428, 146)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(45, 22)
        Me.lblDNI.TabIndex = 141
        Me.lblDNI.Text = "DNI:"
        '
        'btnGuardarClientes
        '
        Me.btnGuardarClientes.BackColor = System.Drawing.Color.MistyRose
        Me.btnGuardarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarClientes.Font = New System.Drawing.Font("Nirmala UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarClientes.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarClientes.Location = New System.Drawing.Point(485, 361)
        Me.btnGuardarClientes.Name = "btnGuardarClientes"
        Me.btnGuardarClientes.Size = New System.Drawing.Size(139, 54)
        Me.btnGuardarClientes.TabIndex = 135
        Me.btnGuardarClientes.Text = "Guardar Cambios"
        Me.btnGuardarClientes.UseVisualStyleBackColor = False
        '
        'btnEliminarClientes
        '
        Me.btnEliminarClientes.BackColor = System.Drawing.Color.MistyRose
        Me.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarClientes.Font = New System.Drawing.Font("Nirmala UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarClientes.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarClientes.Location = New System.Drawing.Point(206, 465)
        Me.btnEliminarClientes.Name = "btnEliminarClientes"
        Me.btnEliminarClientes.Size = New System.Drawing.Size(139, 54)
        Me.btnEliminarClientes.TabIndex = 134
        Me.btnEliminarClientes.Text = "Eliminar Seleccionado"
        Me.btnEliminarClientes.UseVisualStyleBackColor = False
        '
        'btnNuevoClientes
        '
        Me.btnNuevoClientes.BackColor = System.Drawing.Color.MistyRose
        Me.btnNuevoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoClientes.Font = New System.Drawing.Font("Nirmala UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoClientes.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoClientes.Location = New System.Drawing.Point(34, 465)
        Me.btnNuevoClientes.Name = "btnNuevoClientes"
        Me.btnNuevoClientes.Size = New System.Drawing.Size(139, 54)
        Me.btnNuevoClientes.TabIndex = 132
        Me.btnNuevoClientes.Text = "Crear Nuevo"
        Me.btnNuevoClientes.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(476, 259)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(233, 22)
        Me.txtDireccion.TabIndex = 126
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(476, 222)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 22)
        Me.txtTelefono.TabIndex = 124
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(476, 184)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(233, 22)
        Me.txtNombre.TabIndex = 122
        '
        'txtDNI
        '
        Me.txtDNI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(476, 147)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(233, 22)
        Me.txtDNI.TabIndex = 120
        '
        'listClientes
        '
        Me.listClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClientes.FormattingEnabled = True
        Me.listClientes.ItemHeight = 18
        Me.listClientes.Location = New System.Drawing.Point(36, 118)
        Me.listClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.listClientes.Name = "listClientes"
        Me.listClientes.Size = New System.Drawing.Size(309, 326)
        Me.listClientes.TabIndex = 119
        '
        'tabPatin
        '
        Me.tabPatin.BackColor = System.Drawing.Color.MintCream
        Me.tabPatin.Controls.Add(Me.GroupBox2)
        Me.tabPatin.Controls.Add(Me.GroupBox1)
        Me.tabPatin.Location = New System.Drawing.Point(4, 22)
        Me.tabPatin.Name = "tabPatin"
        Me.tabPatin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatin.Size = New System.Drawing.Size(843, 614)
        Me.tabPatin.TabIndex = 1
        Me.tabPatin.Text = "PATINETES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tPrecio)
        Me.GroupBox2.Controls.Add(Me.tVelocidad)
        Me.GroupBox2.Controls.Add(Me.tPeso)
        Me.GroupBox2.Controls.Add(Me.tMarca)
        Me.GroupBox2.Controls.Add(Me.bGuardarTipo)
        Me.GroupBox2.Controls.Add(Me.lTipos)
        Me.GroupBox2.Controls.Add(Me.bNuevoTipo)
        Me.GroupBox2.Controls.Add(Me.bEliminarTipo)
        Me.GroupBox2.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(46, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 283)
        Me.GroupBox2.TabIndex = 168
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos de patinetes"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 22)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "Precio/hora €:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 22)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "Velocidad:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(341, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 22)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Peso:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(337, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 22)
        Me.Label12.TabIndex = 181
        Me.Label12.Text = "Marca: "
        '
        'tPrecio
        '
        Me.tPrecio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPrecio.Location = New System.Drawing.Point(432, 151)
        Me.tPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.Size = New System.Drawing.Size(124, 22)
        Me.tPrecio.TabIndex = 180
        '
        'tVelocidad
        '
        Me.tVelocidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tVelocidad.Location = New System.Drawing.Point(432, 114)
        Me.tVelocidad.Margin = New System.Windows.Forms.Padding(0)
        Me.tVelocidad.Name = "tVelocidad"
        Me.tVelocidad.Size = New System.Drawing.Size(124, 22)
        Me.tVelocidad.TabIndex = 179
        '
        'tPeso
        '
        Me.tPeso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPeso.Location = New System.Drawing.Point(432, 76)
        Me.tPeso.Margin = New System.Windows.Forms.Padding(0)
        Me.tPeso.Name = "tPeso"
        Me.tPeso.Size = New System.Drawing.Size(124, 22)
        Me.tPeso.TabIndex = 178
        '
        'tMarca
        '
        Me.tMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMarca.Location = New System.Drawing.Point(432, 39)
        Me.tMarca.Margin = New System.Windows.Forms.Padding(0)
        Me.tMarca.Name = "tMarca"
        Me.tMarca.Size = New System.Drawing.Size(233, 22)
        Me.tMarca.TabIndex = 177
        '
        'bGuardarTipo
        '
        Me.bGuardarTipo.BackColor = System.Drawing.Color.AliceBlue
        Me.bGuardarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarTipo.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardarTipo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bGuardarTipo.Location = New System.Drawing.Point(432, 218)
        Me.bGuardarTipo.Name = "bGuardarTipo"
        Me.bGuardarTipo.Size = New System.Drawing.Size(139, 54)
        Me.bGuardarTipo.TabIndex = 155
        Me.bGuardarTipo.Text = "Guardar Cambios"
        Me.bGuardarTipo.UseVisualStyleBackColor = False
        '
        'lTipos
        '
        Me.lTipos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTipos.FormattingEnabled = True
        Me.lTipos.ItemHeight = 18
        Me.lTipos.Location = New System.Drawing.Point(27, 36)
        Me.lTipos.Margin = New System.Windows.Forms.Padding(0)
        Me.lTipos.Name = "lTipos"
        Me.lTipos.Size = New System.Drawing.Size(204, 236)
        Me.lTipos.TabIndex = 148
        '
        'bNuevoTipo
        '
        Me.bNuevoTipo.BackColor = System.Drawing.Color.AliceBlue
        Me.bNuevoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevoTipo.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoTipo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bNuevoTipo.Location = New System.Drawing.Point(262, 218)
        Me.bNuevoTipo.Name = "bNuevoTipo"
        Me.bNuevoTipo.Size = New System.Drawing.Size(139, 54)
        Me.bNuevoTipo.TabIndex = 153
        Me.bNuevoTipo.Text = "Crear Nuevo"
        Me.bNuevoTipo.UseVisualStyleBackColor = False
        '
        'bEliminarTipo
        '
        Me.bEliminarTipo.BackColor = System.Drawing.Color.AliceBlue
        Me.bEliminarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminarTipo.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminarTipo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bEliminarTipo.Location = New System.Drawing.Point(603, 218)
        Me.bEliminarTipo.Name = "bEliminarTipo"
        Me.bEliminarTipo.Size = New System.Drawing.Size(139, 54)
        Me.bEliminarTipo.TabIndex = 154
        Me.bEliminarTipo.Text = "Eliminar Seleccionado"
        Me.bEliminarTipo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bGuardarPatinetes)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lPatinetes)
        Me.GroupBox1.Controls.Add(Me.cPatinete)
        Me.GroupBox1.Controls.Add(Me.bNuevoPatinetes)
        Me.GroupBox1.Controls.Add(Me.tDescripcion)
        Me.GroupBox1.Controls.Add(Me.bEliminarPatinetes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 291)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patienetes"
        '
        'bGuardarPatinetes
        '
        Me.bGuardarPatinetes.BackColor = System.Drawing.Color.AliceBlue
        Me.bGuardarPatinetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarPatinetes.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardarPatinetes.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bGuardarPatinetes.Location = New System.Drawing.Point(345, 147)
        Me.bGuardarPatinetes.Name = "bGuardarPatinetes"
        Me.bGuardarPatinetes.Size = New System.Drawing.Size(139, 54)
        Me.bGuardarPatinetes.TabIndex = 155
        Me.bGuardarPatinetes.Text = "Guardar Cambios"
        Me.bGuardarPatinetes.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(522, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Tipo Patinete:"
        '
        'lPatinetes
        '
        Me.lPatinetes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lPatinetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lPatinetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPatinetes.FormattingEnabled = True
        Me.lPatinetes.ItemHeight = 18
        Me.lPatinetes.Location = New System.Drawing.Point(27, 36)
        Me.lPatinetes.Margin = New System.Windows.Forms.Padding(0)
        Me.lPatinetes.Name = "lPatinetes"
        Me.lPatinetes.Size = New System.Drawing.Size(204, 236)
        Me.lPatinetes.TabIndex = 148
        '
        'cPatinete
        '
        Me.cPatinete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cPatinete.FormattingEnabled = True
        Me.cPatinete.Location = New System.Drawing.Point(526, 52)
        Me.cPatinete.Name = "cPatinete"
        Me.cPatinete.Size = New System.Drawing.Size(228, 42)
        Me.cPatinete.TabIndex = 165
        '
        'bNuevoPatinetes
        '
        Me.bNuevoPatinetes.BackColor = System.Drawing.Color.AliceBlue
        Me.bNuevoPatinetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevoPatinetes.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoPatinetes.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bNuevoPatinetes.Location = New System.Drawing.Point(262, 218)
        Me.bNuevoPatinetes.Name = "bNuevoPatinetes"
        Me.bNuevoPatinetes.Size = New System.Drawing.Size(139, 54)
        Me.bNuevoPatinetes.TabIndex = 153
        Me.bNuevoPatinetes.Text = "Crear Nuevo"
        Me.bNuevoPatinetes.UseVisualStyleBackColor = False
        '
        'tDescripcion
        '
        Me.tDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDescripcion.Location = New System.Drawing.Point(276, 51)
        Me.tDescripcion.Margin = New System.Windows.Forms.Padding(0)
        Me.tDescripcion.Multiline = True
        Me.tDescripcion.Name = "tDescripcion"
        Me.tDescripcion.Size = New System.Drawing.Size(233, 78)
        Me.tDescripcion.TabIndex = 164
        '
        'bEliminarPatinetes
        '
        Me.bEliminarPatinetes.BackColor = System.Drawing.Color.AliceBlue
        Me.bEliminarPatinetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminarPatinetes.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminarPatinetes.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bEliminarPatinetes.Location = New System.Drawing.Point(432, 218)
        Me.bEliminarPatinetes.Name = "bEliminarPatinetes"
        Me.bEliminarPatinetes.Size = New System.Drawing.Size(139, 54)
        Me.bEliminarPatinetes.TabIndex = 154
        Me.bEliminarPatinetes.Text = "Eliminar Seleccionado"
        Me.bEliminarPatinetes.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(272, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 22)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Descripcion:"
        '
        'tabRes
        '
        Me.tabRes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabRes.Controls.Add(Me.lpatinetesout)
        Me.tabRes.Controls.Add(Me.lPatinetesin)
        Me.tabRes.Controls.Add(Me.bout)
        Me.tabRes.Controls.Add(Me.bin)
        Me.tabRes.Controls.Add(Me.Label16)
        Me.tabRes.Controls.Add(Me.bGuardarReservas)
        Me.tabRes.Controls.Add(Me.bNuevaReserva)
        Me.tabRes.Controls.Add(Me.bEliminarReservas)
        Me.tabRes.Controls.Add(Me.lClientesReservas)
        Me.tabRes.Controls.Add(Me.Label15)
        Me.tabRes.Controls.Add(Me.tprecioReserva)
        Me.tabRes.Controls.Add(Me.fend)
        Me.tabRes.Controls.Add(Me.Label17)
        Me.tabRes.Controls.Add(Me.fstart)
        Me.tabRes.Controls.Add(Me.Label18)
        Me.tabRes.Controls.Add(Me.lReservas)
        Me.tabRes.Controls.Add(Me.Label13)
        Me.tabRes.Location = New System.Drawing.Point(4, 22)
        Me.tabRes.Name = "tabRes"
        Me.tabRes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRes.Size = New System.Drawing.Size(843, 614)
        Me.tabRes.TabIndex = 2
        Me.tabRes.Text = "RESERVAS"
        '
        'lpatinetesout
        '
        Me.lpatinetesout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lpatinetesout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lpatinetesout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpatinetesout.FormattingEnabled = True
        Me.lpatinetesout.ItemHeight = 18
        Me.lpatinetesout.Location = New System.Drawing.Point(655, 258)
        Me.lpatinetesout.Margin = New System.Windows.Forms.Padding(0)
        Me.lpatinetesout.Name = "lpatinetesout"
        Me.lpatinetesout.Size = New System.Drawing.Size(173, 236)
        Me.lpatinetesout.TabIndex = 183
        '
        'lPatinetesin
        '
        Me.lPatinetesin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lPatinetesin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lPatinetesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPatinetesin.FormattingEnabled = True
        Me.lPatinetesin.ItemHeight = 18
        Me.lPatinetesin.Location = New System.Drawing.Point(375, 258)
        Me.lPatinetesin.Margin = New System.Windows.Forms.Padding(0)
        Me.lPatinetesin.Name = "lPatinetesin"
        Me.lPatinetesin.Size = New System.Drawing.Size(178, 236)
        Me.lPatinetesin.TabIndex = 182
        '
        'bout
        '
        Me.bout.BackColor = System.Drawing.Color.AliceBlue
        Me.bout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bout.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bout.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bout.Location = New System.Drawing.Point(568, 374)
        Me.bout.Name = "bout"
        Me.bout.Size = New System.Drawing.Size(66, 54)
        Me.bout.TabIndex = 181
        Me.bout.Text = "<<<"
        Me.bout.UseVisualStyleBackColor = False
        '
        'bin
        '
        Me.bin.BackColor = System.Drawing.Color.AliceBlue
        Me.bin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bin.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bin.Location = New System.Drawing.Point(568, 292)
        Me.bin.Name = "bin"
        Me.bin.Size = New System.Drawing.Size(66, 54)
        Me.bin.TabIndex = 180
        Me.bin.Text = ">>>"
        Me.bin.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(621, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 30)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "Cliente:"
        '
        'bGuardarReservas
        '
        Me.bGuardarReservas.BackColor = System.Drawing.Color.AliceBlue
        Me.bGuardarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bGuardarReservas.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardarReservas.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bGuardarReservas.Location = New System.Drawing.Point(528, 524)
        Me.bGuardarReservas.Name = "bGuardarReservas"
        Me.bGuardarReservas.Size = New System.Drawing.Size(139, 54)
        Me.bGuardarReservas.TabIndex = 161
        Me.bGuardarReservas.Text = "Guardar Cambios"
        Me.bGuardarReservas.UseVisualStyleBackColor = False
        '
        'bNuevaReserva
        '
        Me.bNuevaReserva.BackColor = System.Drawing.Color.AliceBlue
        Me.bNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevaReserva.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevaReserva.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bNuevaReserva.Location = New System.Drawing.Point(31, 502)
        Me.bNuevaReserva.Name = "bNuevaReserva"
        Me.bNuevaReserva.Size = New System.Drawing.Size(139, 54)
        Me.bNuevaReserva.TabIndex = 159
        Me.bNuevaReserva.Text = "Crear Nuevo"
        Me.bNuevaReserva.UseVisualStyleBackColor = False
        '
        'bEliminarReservas
        '
        Me.bEliminarReservas.BackColor = System.Drawing.Color.AliceBlue
        Me.bEliminarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminarReservas.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminarReservas.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bEliminarReservas.Location = New System.Drawing.Point(206, 502)
        Me.bEliminarReservas.Name = "bEliminarReservas"
        Me.bEliminarReservas.Size = New System.Drawing.Size(139, 54)
        Me.bEliminarReservas.TabIndex = 160
        Me.bEliminarReservas.Text = "Eliminar Seleccionado"
        Me.bEliminarReservas.UseVisualStyleBackColor = False
        '
        'lClientesReservas
        '
        Me.lClientesReservas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lClientesReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lClientesReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lClientesReservas.FormattingEnabled = True
        Me.lClientesReservas.ItemHeight = 18
        Me.lClientesReservas.Location = New System.Drawing.Point(624, 139)
        Me.lClientesReservas.Margin = New System.Windows.Forms.Padding(0)
        Me.lClientesReservas.Name = "lClientesReservas"
        Me.lClientesReservas.Size = New System.Drawing.Size(204, 92)
        Me.lClientesReservas.TabIndex = 158
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(385, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(237, 22)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Precio Reserva (Calculado):"
        '
        'tprecioReserva
        '
        Me.tprecioReserva.Enabled = False
        Me.tprecioReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tprecioReserva.Location = New System.Drawing.Point(624, 46)
        Me.tprecioReserva.Multiline = True
        Me.tprecioReserva.Name = "tprecioReserva"
        Me.tprecioReserva.Size = New System.Drawing.Size(117, 33)
        Me.tprecioReserva.TabIndex = 156
        '
        'fend
        '
        Me.fend.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fend.Location = New System.Drawing.Point(389, 207)
        Me.fend.Name = "fend"
        Me.fend.Size = New System.Drawing.Size(190, 24)
        Me.fend.TabIndex = 153
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(385, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 30)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "Fecha Fin:"
        '
        'fstart
        '
        Me.fstart.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.fstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fstart.Location = New System.Drawing.Point(389, 137)
        Me.fstart.Name = "fstart"
        Me.fstart.Size = New System.Drawing.Size(194, 24)
        Me.fstart.TabIndex = 151
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(385, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 30)
        Me.Label18.TabIndex = 150
        Me.Label18.Text = "Fecha Inicio:"
        '
        'lReservas
        '
        Me.lReservas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lReservas.FormattingEnabled = True
        Me.lReservas.ItemHeight = 18
        Me.lReservas.Location = New System.Drawing.Point(31, 74)
        Me.lReservas.Margin = New System.Windows.Forms.Padding(0)
        Me.lReservas.Name = "lReservas"
        Me.lReservas.Size = New System.Drawing.Size(323, 398)
        Me.lReservas.TabIndex = 149
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 53)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "RESERVAS"
        '
        'tabCons
        '
        Me.tabCons.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabCons.Controls.Add(Me.r3)
        Me.tabCons.Controls.Add(Me.r2)
        Me.tabCons.Controls.Add(Me.r1)
        Me.tabCons.Controls.Add(Me.gridConsultas)
        Me.tabCons.Controls.Add(Me.dfin)
        Me.tabCons.Controls.Add(Me.Label19)
        Me.tabCons.Controls.Add(Me.dInicio)
        Me.tabCons.Controls.Add(Me.Label20)
        Me.tabCons.Controls.Add(Me.Label14)
        Me.tabCons.Location = New System.Drawing.Point(4, 22)
        Me.tabCons.Name = "tabCons"
        Me.tabCons.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCons.Size = New System.Drawing.Size(843, 614)
        Me.tabCons.TabIndex = 3
        Me.tabCons.Text = "CONSULTAS"
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.r3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.r3.Location = New System.Drawing.Point(588, 126)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(218, 26)
        Me.r3.TabIndex = 193
        Me.r3.TabStop = True
        Me.r3.Text = "Ranking Tipos Patinetes"
        Me.r3.UseVisualStyleBackColor = True
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.r2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.r2.Location = New System.Drawing.Point(317, 126)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(177, 26)
        Me.r2.TabIndex = 192
        Me.r2.TabStop = True
        Me.r2.Text = "Historial Patinetes"
        Me.r2.UseVisualStyleBackColor = True
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.r1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.r1.Location = New System.Drawing.Point(65, 126)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(167, 26)
        Me.r1.TabIndex = 191
        Me.r1.TabStop = True
        Me.r1.Text = "Historial Clientes"
        Me.r1.UseVisualStyleBackColor = True
        '
        'gridConsultas
        '
        Me.gridConsultas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridConsultas.Location = New System.Drawing.Point(44, 171)
        Me.gridConsultas.Name = "gridConsultas"
        Me.gridConsultas.Size = New System.Drawing.Size(762, 407)
        Me.gridConsultas.TabIndex = 190
        '
        'dfin
        '
        Me.dfin.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dfin.Location = New System.Drawing.Point(524, 66)
        Me.dfin.Name = "dfin"
        Me.dfin.Size = New System.Drawing.Size(190, 24)
        Me.dfin.TabIndex = 189
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(520, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 30)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Fecha Fin:"
        '
        'dInicio
        '
        Me.dInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dInicio.Location = New System.Drawing.Point(280, 66)
        Me.dInicio.Name = "dInicio"
        Me.dInicio.Size = New System.Drawing.Size(194, 24)
        Me.dInicio.TabIndex = 187
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(276, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 30)
        Me.Label20.TabIndex = 186
        Me.Label20.Text = "Fecha Inicio:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(214, 53)
        Me.Label14.TabIndex = 185
        Me.Label14.Text = "CONSULTAS"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 37)
        Me.Panel1.TabIndex = 7
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.Color.MistyRose
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.Location = New System.Drawing.Point(12, 190)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(110, 42)
        Me.btnConsultas.TabIndex = 13
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'btnReservas
        '
        Me.btnReservas.BackColor = System.Drawing.Color.MistyRose
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservas.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.Location = New System.Drawing.Point(12, 142)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Size = New System.Drawing.Size(110, 42)
        Me.btnReservas.TabIndex = 12
        Me.btnReservas.Text = "Reservas"
        Me.btnReservas.UseVisualStyleBackColor = False
        '
        'btnPatinetes
        '
        Me.btnPatinetes.BackColor = System.Drawing.Color.MistyRose
        Me.btnPatinetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatinetes.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatinetes.Location = New System.Drawing.Point(12, 94)
        Me.btnPatinetes.Name = "btnPatinetes"
        Me.btnPatinetes.Size = New System.Drawing.Size(110, 42)
        Me.btnPatinetes.TabIndex = 11
        Me.btnPatinetes.Text = "Patinetes"
        Me.btnPatinetes.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.MistyRose
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(12, 46)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(110, 42)
        Me.btnClientes.TabIndex = 10
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.MistyRose
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(12, 596)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 42)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'VistaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnReservas)
        Me.Controls.Add(Me.btnPatinetes)
        Me.Controls.Add(Me.btnClientes)
        Me.Name = "VistaGeneral"
        Me.Text = "VistaGeneral"
        Me.tabControl.ResumeLayout(False)
        Me.tabCli.ResumeLayout(False)
        Me.tabCli.PerformLayout()
        Me.tabPatin.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabRes.ResumeLayout(False)
        Me.tabRes.PerformLayout()
        Me.tabCons.ResumeLayout(False)
        Me.tabCons.PerformLayout()
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabCli As TabPage
    Friend WithEvents lblClientes As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents btnGuardarClientes As Button
    Friend WithEvents btnEliminarClientes As Button
    Friend WithEvents btnNuevoClientes As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents listClientes As ListBox
    Friend WithEvents tabPatin As TabPage
    Friend WithEvents tabRes As TabPage
    Friend WithEvents tabCons As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnReservas As Button
    Friend WithEvents btnPatinetes As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents bGuardarPatinetes As Button
    Friend WithEvents bEliminarPatinetes As Button
    Friend WithEvents bNuevoPatinetes As Button
    Friend WithEvents lPatinetes As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tPrecio As TextBox
    Friend WithEvents tVelocidad As TextBox
    Friend WithEvents tPeso As TextBox
    Friend WithEvents tMarca As TextBox
    Friend WithEvents bGuardarTipo As Button
    Friend WithEvents lTipos As ListBox
    Friend WithEvents bNuevoTipo As Button
    Friend WithEvents bEliminarTipo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cPatinete As ComboBox
    Friend WithEvents tDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lpatinetesout As ListBox
    Friend WithEvents lPatinetesin As ListBox
    Friend WithEvents bout As Button
    Friend WithEvents bin As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents bGuardarReservas As Button
    Friend WithEvents bNuevaReserva As Button
    Friend WithEvents bEliminarReservas As Button
    Friend WithEvents lClientesReservas As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tprecioReserva As TextBox
    Friend WithEvents fend As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents fstart As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents lReservas As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gridConsultas As DataGridView
    Friend WithEvents dfin As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents dInicio As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents r3 As RadioButton
    Friend WithEvents r2 As RadioButton
    Friend WithEvents r1 As RadioButton
End Class
