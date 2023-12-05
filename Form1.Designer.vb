<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalk = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.btnTask2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalk
        '
        Me.btnCalk.Location = New System.Drawing.Point(490, 309)
        Me.btnCalk.Name = "btnCalk"
        Me.btnCalk.Size = New System.Drawing.Size(99, 23)
        Me.btnCalk.TabIndex = 1
        Me.btnCalk.Text = "Task 1"
        Me.btnCalk.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(490, 42)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Output.Size = New System.Drawing.Size(264, 232)
        Me.Output.TabIndex = 2
        '
        'btnTask2
        '
        Me.btnTask2.Location = New System.Drawing.Point(615, 309)
        Me.btnTask2.Name = "btnTask2"
        Me.btnTask2.Size = New System.Drawing.Size(99, 23)
        Me.btnTask2.TabIndex = 3
        Me.btnTask2.Text = "Task 2"
        Me.btnTask2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTask2)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.btnCalk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalk As Button
    Friend WithEvents Output As TextBox
    Friend WithEvents btnTask2 As Button
End Class
