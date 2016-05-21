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
        Me.beginning = New System.Windows.Forms.Button()
        Me.mostrar = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.Label()
        Me.ubicar = New System.Windows.Forms.Button()
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
        'ubicar
        '
        Me.ubicar.Location = New System.Drawing.Point(12, 72)
        Me.ubicar.Name = "ubicar"
        Me.ubicar.Size = New System.Drawing.Size(130, 23)
        Me.ubicar.TabIndex = 3
        Me.ubicar.Text = "Ubicar barcos"
        Me.ubicar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 410)
        Me.Controls.Add(Me.ubicar)
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
    Friend WithEvents ubicar As Button
End Class
