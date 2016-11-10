<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDebug
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDebug))
        Me.TextDebug = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'TextDebug
        '
        Me.TextDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextDebug.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDebug.Location = New System.Drawing.Point(0, 0)
        Me.TextDebug.Name = "TextDebug"
        Me.TextDebug.Size = New System.Drawing.Size(390, 353)
        Me.TextDebug.TabIndex = 0
        Me.TextDebug.Text = ""
        '
        'FormDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 353)
        Me.Controls.Add(Me.TextDebug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDebug"
        Me.Text = "Debug KimKiLL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextDebug As System.Windows.Forms.RichTextBox
End Class
