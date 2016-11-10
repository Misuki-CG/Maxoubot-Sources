<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterCreator
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
        Me.LabelEtat = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CharacterClass = New System.Windows.Forms.ComboBox
        Me.RadioGenre2 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.RadioGenre = New System.Windows.Forms.RadioButton
        Me.TextCharacterName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Servers = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pass = New System.Windows.Forms.TextBox
        Me.Compte = New System.Windows.Forms.TextBox
        Me.RejoinPlayer = New System.Windows.Forms.TextBox
        Me.Joinplayer = New System.Windows.Forms.CheckBox
        Me.SaveToZaap = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckColor = New System.Windows.Forms.CheckBox
        Me.GoToAstrub = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'LabelEtat
        '
        Me.LabelEtat.AutoSize = True
        Me.LabelEtat.Location = New System.Drawing.Point(25, 275)
        Me.LabelEtat.Name = "LabelEtat"
        Me.LabelEtat.Size = New System.Drawing.Size(86, 13)
        Me.LabelEtat.TabIndex = 34
        Me.LabelEtat.Text = "Status:Pendente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Classe Do Personagem"
        '
        'CharacterClass
        '
        Me.CharacterClass.FormattingEnabled = True
        Me.CharacterClass.Items.AddRange(New Object() {"1:Feca", "2:Osamodas", "3:Enutrof", "4:Sram", "5:Xelor", "6:Ecaflip", "7:Eniripsia", "8:Iop", "9:Cra", "10:Sadida", "11:Sacrieur", "12:Pandawa"})
        Me.CharacterClass.Location = New System.Drawing.Point(162, 123)
        Me.CharacterClass.Name = "CharacterClass"
        Me.CharacterClass.Size = New System.Drawing.Size(130, 21)
        Me.CharacterClass.TabIndex = 32
        '
        'RadioGenre2
        '
        Me.RadioGenre2.AutoSize = True
        Me.RadioGenre2.Location = New System.Drawing.Point(235, 149)
        Me.RadioGenre2.Name = "RadioGenre2"
        Me.RadioGenre2.Size = New System.Drawing.Size(61, 17)
        Me.RadioGenre2.TabIndex = 25
        Me.RadioGenre2.Text = "Feminio"
        Me.RadioGenre2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Sexo :"
        '
        'RadioGenre
        '
        Me.RadioGenre.AutoSize = True
        Me.RadioGenre.Checked = True
        Me.RadioGenre.Location = New System.Drawing.Point(162, 149)
        Me.RadioGenre.Name = "RadioGenre"
        Me.RadioGenre.Size = New System.Drawing.Size(73, 17)
        Me.RadioGenre.TabIndex = 24
        Me.RadioGenre.TabStop = True
        Me.RadioGenre.Text = "Masculino"
        Me.RadioGenre.UseVisualStyleBackColor = True
        '
        'TextCharacterName
        '
        Me.TextCharacterName.Location = New System.Drawing.Point(162, 97)
        Me.TextCharacterName.Name = "TextCharacterName"
        Me.TextCharacterName.Size = New System.Drawing.Size(131, 20)
        Me.TextCharacterName.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nome do Personagem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Serve para Jogar"
        '
        'Servers
        '
        Me.Servers.FormattingEnabled = True
        Me.Servers.Items.AddRange(New Object() {"1:Jiva", "2:Rushu", "3:Djaul", "4:Raval", "5:Ecate", "6:Sumens", "7:Menalt", "8:Rosal", "9:Mainne", "10:Silvosse", "11:Brumaire", "12:Pouchecot", "13:Silouate", "14:Domen", "15:Amariyo", "16:Rykke-errel", "17:Hyrkul", "18:Helsephine", "19:Alister", "20:Otomai", "21:Lily", "22:Oto Mustam", "23:Hel Munster", "24:Danator", "25:Kuri", "26:Mylaise", "27:Goultard", "28:Ulette", "29:Vil Smisse", "30:Many"})
        Me.Servers.Location = New System.Drawing.Point(162, 70)
        Me.Servers.Name = "Servers"
        Me.Servers.Size = New System.Drawing.Size(130, 21)
        Me.Servers.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 34)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Criar Personagem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nome da Conta"
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(162, 44)
        Me.Pass.Name = "Pass"
        Me.Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.Pass.Size = New System.Drawing.Size(131, 20)
        Me.Pass.TabIndex = 21
        '
        'Compte
        '
        Me.Compte.Location = New System.Drawing.Point(161, 18)
        Me.Compte.Name = "Compte"
        Me.Compte.Size = New System.Drawing.Size(131, 20)
        Me.Compte.TabIndex = 20
        '
        'RejoinPlayer
        '
        Me.RejoinPlayer.Location = New System.Drawing.Point(161, 192)
        Me.RejoinPlayer.Name = "RejoinPlayer"
        Me.RejoinPlayer.Size = New System.Drawing.Size(131, 20)
        Me.RejoinPlayer.TabIndex = 36
        Me.RejoinPlayer.Text = "Não"
        '
        'Joinplayer
        '
        Me.Joinplayer.AutoSize = True
        Me.Joinplayer.Location = New System.Drawing.Point(26, 194)
        Me.Joinplayer.Name = "Joinplayer"
        Me.Joinplayer.Size = New System.Drawing.Size(111, 17)
        Me.Joinplayer.TabIndex = 37
        Me.Joinplayer.Text = "Participar do Jogo"
        Me.Joinplayer.UseVisualStyleBackColor = True
        '
        'SaveToZaap
        '
        Me.SaveToZaap.AutoSize = True
        Me.SaveToZaap.Enabled = False
        Me.SaveToZaap.Location = New System.Drawing.Point(26, 218)
        Me.SaveToZaap.Name = "SaveToZaap"
        Me.SaveToZaap.Size = New System.Drawing.Size(190, 17)
        Me.SaveToZaap.TabIndex = 38
        Me.SaveToZaap.Text = "Salvar para ZAAP depois de entrar"
        Me.SaveToZaap.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Cores Aleatorias"
        '
        'CheckColor
        '
        Me.CheckColor.AutoSize = True
        Me.CheckColor.Location = New System.Drawing.Point(162, 172)
        Me.CheckColor.Name = "CheckColor"
        Me.CheckColor.Size = New System.Drawing.Size(15, 14)
        Me.CheckColor.TabIndex = 42
        Me.CheckColor.UseVisualStyleBackColor = True
        '
        'GoToAstrub
        '
        Me.GoToAstrub.AutoSize = True
        Me.GoToAstrub.Enabled = False
        Me.GoToAstrub.Location = New System.Drawing.Point(26, 241)
        Me.GoToAstrub.Name = "GoToAstrub"
        Me.GoToAstrub.Size = New System.Drawing.Size(126, 17)
        Me.GoToAstrub.TabIndex = 43
        Me.GoToAstrub.Text = "Saia em Astrub juntar"
        Me.GoToAstrub.UseVisualStyleBackColor = True
        '
        'CharacterCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 303)
        Me.Controls.Add(Me.GoToAstrub)
        Me.Controls.Add(Me.CheckColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SaveToZaap)
        Me.Controls.Add(Me.Joinplayer)
        Me.Controls.Add(Me.RejoinPlayer)
        Me.Controls.Add(Me.LabelEtat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CharacterClass)
        Me.Controls.Add(Me.RadioGenre2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioGenre)
        Me.Controls.Add(Me.TextCharacterName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Servers)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Compte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CharacterCreator"
        Me.Text = "Dofus Criador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelEtat As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CharacterClass As System.Windows.Forms.ComboBox
    Friend WithEvents RadioGenre2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioGenre As System.Windows.Forms.RadioButton
    Friend WithEvents TextCharacterName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Servers As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pass As System.Windows.Forms.TextBox
    Friend WithEvents Compte As System.Windows.Forms.TextBox
    Friend WithEvents RejoinPlayer As System.Windows.Forms.TextBox
    Friend WithEvents Joinplayer As System.Windows.Forms.CheckBox
    Friend WithEvents SaveToZaap As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckColor As System.Windows.Forms.CheckBox
    Friend WithEvents GoToAstrub As System.Windows.Forms.CheckBox
End Class
