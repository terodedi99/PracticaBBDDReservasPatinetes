<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BDconectar
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.MistyRose
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(277, 257)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 42)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.MistyRose
        Me.btnConectar.Enabled = False
        Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConectar.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnConectar.Location = New System.Drawing.Point(113, 257)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(110, 42)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnRuta)
        Me.GroupBox1.Controls.Add(Me.txtRuta)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(27, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 212)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Base de Datos"
        '
        'btnRuta
        '
        Me.btnRuta.BackColor = System.Drawing.Color.MistyRose
        Me.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRuta.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnRuta.Location = New System.Drawing.Point(293, 103)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(110, 42)
        Me.btnRuta.TabIndex = 3
        Me.btnRuta.Text = "Ruta"
        Me.btnRuta.UseVisualStyleBackColor = False
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuta.Location = New System.Drawing.Point(46, 70)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(218, 101)
        Me.txtRuta.TabIndex = 0
        Me.txtRuta.Text = ""
        '
        'BDconectar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(490, 320)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BDconectar"
        Me.Text = "BD Conexion"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRuta As Button
    Friend WithEvents txtRuta As RichTextBox
End Class
