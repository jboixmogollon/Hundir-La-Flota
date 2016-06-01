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
        Me.l1 = New System.Windows.Forms.Label()
        Me.up_array = New System.Windows.Forms.Button()
        Me.labelresultado = New System.Windows.Forms.Label()
        Me.disparar = New System.Windows.Forms.Button()
        Me.l2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.up_array.Location = New System.Drawing.Point(12, 7)
        Me.up_array.Name = "up_array"
        Me.up_array.Size = New System.Drawing.Size(220, 23)
        Me.up_array.TabIndex = 4
        Me.up_array.Text = "Introducir coordenadas de barcos"
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
        Me.disparar.Location = New System.Drawing.Point(12, 36)
        Me.disparar.Name = "disparar"
        Me.disparar.Size = New System.Drawing.Size(220, 23)
        Me.disparar.TabIndex = 6
        Me.disparar.Text = "Disparar"
        Me.disparar.UseVisualStyleBackColor = True
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(277, 82)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(0, 13)
        Me.l2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 410)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.disparar)
        Me.Controls.Add(Me.labelresultado)
        Me.Controls.Add(Me.up_array)
        Me.Controls.Add(Me.l1)
        Me.Name = "Form1"
        Me.Text = "Hundir La Flota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l1 As Label
    Friend WithEvents up_array As Button
    Friend WithEvents labelresultado As Label
    Friend WithEvents disparar As Button
    Friend WithEvents l2 As Label
End Class
