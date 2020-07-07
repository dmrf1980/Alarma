<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NudHoras = New System.Windows.Forms.NumericUpDown()
        Me.NudMinutos = New System.Windows.Forms.NumericUpDown()
        Me.LbxAlarmas = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnVaciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NudHoras
        '
        Me.NudHoras.Location = New System.Drawing.Point(15, 36)
        Me.NudHoras.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudHoras.Name = "NudHoras"
        Me.NudHoras.Size = New System.Drawing.Size(120, 20)
        Me.NudHoras.TabIndex = 0
        '
        'NudMinutos
        '
        Me.NudMinutos.Location = New System.Drawing.Point(170, 36)
        Me.NudMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudMinutos.Name = "NudMinutos"
        Me.NudMinutos.Size = New System.Drawing.Size(120, 20)
        Me.NudMinutos.TabIndex = 0
        '
        'LbxAlarmas
        '
        Me.LbxAlarmas.FormattingEnabled = True
        Me.LbxAlarmas.Location = New System.Drawing.Point(16, 99)
        Me.LbxAlarmas.Name = "LbxAlarmas"
        Me.LbxAlarmas.Size = New System.Drawing.Size(274, 121)
        Me.LbxAlarmas.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(307, 34)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(102, 58)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(307, 98)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 58)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnVaciar
        '
        Me.BtnVaciar.Location = New System.Drawing.Point(307, 162)
        Me.BtnVaciar.Name = "BtnVaciar"
        Me.BtnVaciar.Size = New System.Drawing.Size(102, 58)
        Me.BtnVaciar.TabIndex = 2
        Me.BtnVaciar.Text = "Vaciar"
        Me.BtnVaciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 228)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVaciar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LbxAlarmas)
        Me.Controls.Add(Me.NudMinutos)
        Me.Controls.Add(Me.NudHoras)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarma"
        CType(Me.NudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NudHoras As NumericUpDown
    Friend WithEvents NudMinutos As NumericUpDown
    Friend WithEvents LbxAlarmas As ListBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnVaciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
