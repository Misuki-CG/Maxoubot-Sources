<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModify))
        Me.Charger = New System.Windows.Forms.Button
        Me.ListeDesComptes = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Charger
        '
        resources.ApplyResources(Me.Charger, "Charger")
        Me.Charger.Name = "Charger"
        Me.Charger.UseVisualStyleBackColor = True
        '
        'ListeDesComptes
        '
        Me.ListeDesComptes.FormattingEnabled = True
        resources.ApplyResources(Me.ListeDesComptes, "ListeDesComptes")
        Me.ListeDesComptes.Name = "ListeDesComptes"
        '
        'FormModify
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Charger)
        Me.Controls.Add(Me.ListeDesComptes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormModify"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Charger As System.Windows.Forms.Button
    Friend WithEvents ListeDesComptes As System.Windows.Forms.ListBox
End Class
