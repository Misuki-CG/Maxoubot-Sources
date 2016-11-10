<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoad))
        Me.LoadAll = New System.Windows.Forms.Button
        Me.Charger = New System.Windows.Forms.Button
        Me.ListeDesComptes = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'LoadAll
        '
        Me.LoadAll.Location = New System.Drawing.Point(10, 168)
        Me.LoadAll.Name = "LoadAll"
        Me.LoadAll.Size = New System.Drawing.Size(147, 24)
        Me.LoadAll.TabIndex = 11
        Me.LoadAll.Text = "Selecionar uma conta"
        Me.LoadAll.UseVisualStyleBackColor = True
        '
        'Charger
        '
        Me.Charger.Location = New System.Drawing.Point(163, 168)
        Me.Charger.Name = "Charger"
        Me.Charger.Size = New System.Drawing.Size(107, 24)
        Me.Charger.TabIndex = 10
        Me.Charger.Text = "Cobrar a conta"
        Me.Charger.UseVisualStyleBackColor = True
        '
        'ListeDesComptes
        '
        Me.ListeDesComptes.FormattingEnabled = True
        Me.ListeDesComptes.Location = New System.Drawing.Point(10, 10)
        Me.ListeDesComptes.Name = "ListeDesComptes"
        Me.ListeDesComptes.Size = New System.Drawing.Size(260, 147)
        Me.ListeDesComptes.TabIndex = 9
        '
        'FormLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 203)
        Me.Controls.Add(Me.LoadAll)
        Me.Controls.Add(Me.Charger)
        Me.Controls.Add(Me.ListeDesComptes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormLoad"
        Me.ShowInTaskbar = False
        Me.Text = "Selecionar uma conta"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadAll As System.Windows.Forms.Button
    Friend WithEvents Charger As System.Windows.Forms.Button
    Friend WithEvents ListeDesComptes As System.Windows.Forms.ListBox
End Class
