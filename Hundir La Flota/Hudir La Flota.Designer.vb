<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.beginning = New System.Windows.Forms.Button()
        Me.mostrar = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.Label()
        Me.up_array = New System.Windows.Forms.Button()
        Me.labelresultado = New System.Windows.Forms.Label()
        Me.disparar = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'beginning
        '
        Me.beginning.Location = New System.Drawing.Point(12, 12)
        Me.beginning.Name = "beginning"
        Me.beginning.Size = New System.Drawing.Size(130, 23)
        Me.beginning.TabIndex = 0
        Me.beginning.Text = "Generar mapa"
        Me.beginning.UseVisualStyleBackColor = True
        '
        'mostrar
        '
        Me.mostrar.Location = New System.Drawing.Point(12, 42)
        Me.mostrar.Name = "mostrar"
        Me.mostrar.Size = New System.Drawing.Size(130, 23)
        Me.mostrar.TabIndex = 1
        Me.mostrar.Text = "Mostrar"
        Me.mostrar.UseVisualStyleBackColor = True
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Location = New System.Drawing.Point(13, 82)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(0, 13)
        Me.l1.TabIndex = 2
        '
        'up_array
        '
        Me.up_array.Location = New System.Drawing.Point(148, 12)
        Me.up_array.Name = "up_array"
        Me.up_array.Size = New System.Drawing.Size(129, 23)
        Me.up_array.TabIndex = 4
        Me.up_array.Text = "Actualizar Array"
        Me.up_array.UseVisualStyleBackColor = True
        '
        'labelresultado
        '
        Me.labelresultado.AutoSize = True
        Me.labelresultado.Location = New System.Drawing.Point(324, 17)
        Me.labelresultado.Name = "labelresultado"
        Me.labelresultado.Size = New System.Drawing.Size(0, 13)
        Me.labelresultado.TabIndex = 5
        '
        'disparar
        '
        Me.disparar.Location = New System.Drawing.Point(148, 41)
        Me.disparar.Name = "disparar"
        Me.disparar.Size = New System.Drawing.Size(129, 23)
        Me.disparar.TabIndex = 6
        Me.disparar.Text = "Disparar"
        Me.disparar.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 410)
        Me.Controls.Add(Me.disparar)
        Me.Controls.Add(Me.labelresultado)
        Me.Controls.Add(Me.up_array)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.mostrar)
        Me.Controls.Add(Me.beginning)
        Me.Name = "Form1"
        Me.Text = "Hundir La Flota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents beginning As Button
    Friend WithEvents mostrar As Button
    Friend WithEvents l1 As Label
    Friend WithEvents up_array As Button
    Friend WithEvents labelresultado As Label
    Friend WithEvents disparar As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
