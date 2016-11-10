<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdd
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cible = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Fois = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Sort = New System.Windows.Forms.ComboBox
        Me.TextPassJoin = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextPassSuivre = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextPassBot = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListServer = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumPerso = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextPass = New System.Windows.Forms.TextBox
        Me.TextCompte = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Creer = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.Fois, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumPerso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sur :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome da Conta:"
        '
        'Cible
        '
        Me.Cible.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cible.FormattingEnabled = True
        Me.Cible.Items.AddRange(New Object() {"1 - Un Ennemi", "2 - Un Allié", "3 - Sois même"})
        Me.Cible.Location = New System.Drawing.Point(195, 47)
        Me.Cible.Name = "Cible"
        Me.Cible.Size = New System.Drawing.Size(133, 22)
        Me.Cible.TabIndex = 8
        Me.Cible.Text = "1 - Un Ennemi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Cible)
        Me.GroupBox3.Controls.Add(Me.Fois)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Sort)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 81)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Magia"
        '
        'Fois
        '
        Me.Fois.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fois.Location = New System.Drawing.Point(100, 47)
        Me.Fois.Name = "Fois"
        Me.Fois.Size = New System.Drawing.Size(53, 20)
        Me.Fois.TabIndex = 5
        Me.Fois.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Muitas Vezes :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Primeira Magia"
        '
        'Sort
        '
        Me.Sort.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sort.FormattingEnabled = True
        Me.Sort.Location = New System.Drawing.Point(102, 19)
        Me.Sort.Name = "Sort"
        Me.Sort.Size = New System.Drawing.Size(227, 22)
        Me.Sort.TabIndex = 4
        Me.Sort.Text = "Aucun (0)"
        '
        'TextPassJoin
        '
        Me.TextPassJoin.Location = New System.Drawing.Point(113, 60)
        Me.TextPassJoin.Name = "TextPassJoin"
        Me.TextPassJoin.Size = New System.Drawing.Size(105, 20)
        Me.TextPassJoin.TabIndex = 6
        Me.TextPassJoin.Text = ".join"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextPassSuivre)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextPassJoin)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextPassBot)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(264, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 133)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Senha de ADM"
        '
        'TextPassSuivre
        '
        Me.TextPassSuivre.Location = New System.Drawing.Point(113, 86)
        Me.TextPassSuivre.Name = "TextPassSuivre"
        Me.TextPassSuivre.Size = New System.Drawing.Size(105, 20)
        Me.TextPassSuivre.TabIndex = 8
        Me.TextPassSuivre.Text = ".follow"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 14)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Senha para Seguir:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Senha para reunir:"
        '
        'TextPassBot
        '
        Me.TextPassBot.Location = New System.Drawing.Point(113, 34)
        Me.TextPassBot.Name = "TextPassBot"
        Me.TextPassBot.Size = New System.Drawing.Size(105, 20)
        Me.TextPassBot.TabIndex = 3
        Me.TextPassBot.Text = ".password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Senha Admin"
        '
        'ListServer
        '
        Me.ListServer.FormattingEnabled = True
        Me.ListServer.Location = New System.Drawing.Point(121, 72)
        Me.ListServer.Name = "ListServer"
        Me.ListServer.Size = New System.Drawing.Size(105, 22)
        Me.ListServer.TabIndex = 2
        Me.ListServer.Text = "1:Jiva"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumPerso)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListServer)
        Me.GroupBox1.Controls.Add(Me.TextPass)
        Me.GroupBox1.Controls.Add(Me.TextCompte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 133)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conecção"
        '
        'NumPerso
        '
        Me.NumPerso.Location = New System.Drawing.Point(121, 100)
        Me.NumPerso.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumPerso.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumPerso.Name = "NumPerso"
        Me.NumPerso.Size = New System.Drawing.Size(105, 20)
        Me.NumPerso.TabIndex = 6
        Me.NumPerso.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 14)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Personagem nº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selecione o Serve"
        '
        'TextPass
        '
        Me.TextPass.Location = New System.Drawing.Point(121, 46)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TextPass.Size = New System.Drawing.Size(105, 20)
        Me.TextPass.TabIndex = 1
        '
        'TextCompte
        '
        Me.TextCompte.Location = New System.Drawing.Point(121, 19)
        Me.TextCompte.Name = "TextCompte"
        Me.TextCompte.Size = New System.Drawing.Size(105, 20)
        Me.TextCompte.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Creer
        '
        Me.Creer.Location = New System.Drawing.Point(389, 168)
        Me.Creer.Name = "Creer"
        Me.Creer.Size = New System.Drawing.Size(105, 28)
        Me.Creer.TabIndex = 9
        Me.Creer.Text = "Criar Conta"
        Me.Creer.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(395, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Por Maniaco Traduzido"
        '
        'FormAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 239)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Creer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormAdd"
        Me.ShowInTaskbar = False
        Me.Text = "Insira uma Conta"
        Me.TopMost = True
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Fois, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumPerso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cible As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Fois As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sort As System.Windows.Forms.ComboBox
    Friend WithEvents TextPassJoin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextPassBot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListServer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextPass As System.Windows.Forms.TextBox
    Friend WithEvents TextCompte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Creer As System.Windows.Forms.Button
    Friend WithEvents TextPassSuivre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumPerso As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
