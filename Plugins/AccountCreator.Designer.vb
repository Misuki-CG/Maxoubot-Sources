<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreator
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.WebAccount = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Você apenas tem que digitar o captcha (imagem), então validar. As contas são arma" & _
            "zenadas em DofusAccount.txt"
        '
        'WebAccount
        '
        Me.WebAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebAccount.Location = New System.Drawing.Point(0, 31)
        Me.WebAccount.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebAccount.Name = "WebAccount"
        Me.WebAccount.Size = New System.Drawing.Size(536, 469)
        Me.WebAccount.TabIndex = 1
        Me.WebAccount.Url = New System.Uri("https://www.dofus.com/fr/creer-un-compte", System.UriKind.Absolute)
        '
        'AccountCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(537, 500)
        Me.Controls.Add(Me.WebAccount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccountCreator"
        Me.Text = "Dofus Criar Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WebAccount As System.Windows.Forms.WebBrowser
End Class
