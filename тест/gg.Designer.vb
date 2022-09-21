<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gg
    Inherits System.Windows.Forms.Form

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
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.c1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(121, 112)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(280, 175)
        Me.c1.TabIndex = 0
        Me.c1.Text = "Button1"
        Me.c1.UseVisualStyleBackColor = True
        '
        'GF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 347)
        Me.Controls.Add(Me.c1)
        Me.Name = "GF"
        Me.Text = "General"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents c1 As Button
End Class
