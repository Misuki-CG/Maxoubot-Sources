<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinPhrase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFinPhrase))
        Me.CheckSmiley = New System.Windows.Forms.CheckBox
        Me.CheckLettre = New System.Windows.Forms.CheckBox
        Me.CheckChiffre = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckSymbol = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'CheckSmiley
        '
        Me.CheckSmiley.AutoSize = True
        Me.CheckSmiley.Location = New System.Drawing.Point(156, 40)
        Me.CheckSmiley.Name = "CheckSmiley"
        Me.CheckSmiley.Size = New System.Drawing.Size(56, 17)
        Me.CheckSmiley.TabIndex = 0
        Me.CheckSmiley.Text = "Smiley"
        Me.CheckSmiley.UseVisualStyleBackColor = True
        '
        'CheckLettre
        '
        Me.CheckLettre.AutoSize = True
        Me.CheckLettre.Location = New System.Drawing.Point(92, 40)
        Me.CheckLettre.Name = "CheckLettre"
        Me.CheckLettre.Size = New System.Drawing.Size(58, 17)
        Me.CheckLettre.TabIndex = 1
        Me.CheckLettre.Text = "Lettres"
        Me.CheckLettre.UseVisualStyleBackColor = True
        '
        'CheckChiffre
        '
        Me.CheckChiffre.AutoSize = True
        Me.CheckChiffre.Location = New System.Drawing.Point(25, 40)
        Me.CheckChiffre.Name = "CheckChiffre"
        Me.CheckChiffre.Size = New System.Drawing.Size(58, 17)
        Me.CheckChiffre.TabIndex = 2
        Me.CheckChiffre.Text = "Chifres"
        Me.CheckChiffre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Adicione no final da sentença:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Validar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckSymbol
        '
        Me.CheckSymbol.AutoSize = True
        Me.CheckSymbol.Location = New System.Drawing.Point(218, 40)
        Me.CheckSymbol.Name = "CheckSymbol"
        Me.CheckSymbol.Size = New System.Drawing.Size(71, 17)
        Me.CheckSymbol.TabIndex = 5
        Me.CheckSymbol.Text = "Symboles"
        Me.CheckSymbol.UseVisualStyleBackColor = True
        '
        'FormFinPhrase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 103)
        Me.Controls.Add(Me.CheckSymbol)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckChiffre)
        Me.Controls.Add(Me.CheckLettre)
        Me.Controls.Add(Me.CheckSmiley)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormFinPhrase"
        Me.ShowInTaskbar = False
        Me.Text = "Configurando para a sentença"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckSmiley As System.Windows.Forms.CheckBox
    Friend WithEvents CheckLettre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckChiffre As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckSymbol As System.Windows.Forms.CheckBox
End Class
