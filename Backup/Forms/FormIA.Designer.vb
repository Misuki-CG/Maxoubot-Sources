<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIA))
        Me.ChangeMap = New System.Windows.Forms.CheckBox
        Me.NombreCombat = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Spectateur = New System.Windows.Forms.CheckBox
        Me.BGroupe = New System.Windows.Forms.CheckBox
        Me.ValidButton = New System.Windows.Forms.Button
        Me.AutoDeco = New System.Windows.Forms.CheckBox
        CType(Me.NombreCombat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChangeMap
        '
        Me.ChangeMap.AutoSize = True
        Me.ChangeMap.Location = New System.Drawing.Point(12, 12)
        Me.ChangeMap.Name = "ChangeMap"
        Me.ChangeMap.Size = New System.Drawing.Size(261, 17)
        Me.ChangeMap.TabIndex = 0
        Me.ChangeMap.Text = "Mudança de mapa de todas as                batalhas"
        Me.ChangeMap.UseVisualStyleBackColor = True
        '
        'NombreCombat
        '
        Me.NombreCombat.Location = New System.Drawing.Point(183, 11)
        Me.NombreCombat.Name = "NombreCombat"
        Me.NombreCombat.Size = New System.Drawing.Size(38, 20)
        Me.NombreCombat.TabIndex = 1
        Me.NombreCombat.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bloquiar:"
        '
        'Spectateur
        '
        Me.Spectateur.AutoSize = True
        Me.Spectateur.Location = New System.Drawing.Point(64, 59)
        Me.Spectateur.Name = "Spectateur"
        Me.Spectateur.Size = New System.Drawing.Size(80, 17)
        Me.Spectateur.TabIndex = 3
        Me.Spectateur.Text = "Espectador"
        Me.Spectateur.UseVisualStyleBackColor = True
        '
        'BGroupe
        '
        Me.BGroupe.AutoSize = True
        Me.BGroupe.Location = New System.Drawing.Point(148, 60)
        Me.BGroupe.Name = "BGroupe"
        Me.BGroupe.Size = New System.Drawing.Size(55, 17)
        Me.BGroupe.TabIndex = 4
        Me.BGroupe.Text = "Grupo"
        Me.BGroupe.UseVisualStyleBackColor = True
        '
        'ValidButton
        '
        Me.ValidButton.Location = New System.Drawing.Point(249, 33)
        Me.ValidButton.Name = "ValidButton"
        Me.ValidButton.Size = New System.Drawing.Size(55, 29)
        Me.ValidButton.TabIndex = 5
        Me.ValidButton.Text = "Validar"
        Me.ValidButton.UseVisualStyleBackColor = True
        '
        'AutoDeco
        '
        Me.AutoDeco.AutoSize = True
        Me.AutoDeco.Location = New System.Drawing.Point(12, 37)
        Me.AutoDeco.Name = "AutoDeco"
        Me.AutoDeco.Size = New System.Drawing.Size(198, 17)
        Me.AutoDeco.TabIndex = 6
        Me.AutoDeco.Text = "Desconectar quando completa-pods"
        Me.AutoDeco.UseVisualStyleBackColor = True
        '
        'FormIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 86)
        Me.Controls.Add(Me.AutoDeco)
        Me.Controls.Add(Me.ValidButton)
        Me.Controls.Add(Me.BGroupe)
        Me.Controls.Add(Me.Spectateur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NombreCombat)
        Me.Controls.Add(Me.ChangeMap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormIA"
        Me.ShowInTaskbar = False
        Me.Text = "Inteligencia Artificial"
        Me.TopMost = True
        CType(Me.NombreCombat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChangeMap As System.Windows.Forms.CheckBox
    Friend WithEvents NombreCombat As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Spectateur As System.Windows.Forms.CheckBox
    Friend WithEvents BGroupe As System.Windows.Forms.CheckBox
    Friend WithEvents ValidButton As System.Windows.Forms.Button
    Friend WithEvents AutoDeco As System.Windows.Forms.CheckBox
End Class
