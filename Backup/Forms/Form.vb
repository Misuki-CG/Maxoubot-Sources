Public Class Form

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitializeCells()
        LoadConfig()
        LoadSpell(FormAdd)

        If IO.Directory.Exists("temp") Then IO.Directory.Delete("temp", True)

        With Tray
            .Text = "KimKiLL Bot"
            .Visible = False
            .ContextMenu = TrayMenu
        End With
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason.ToString = "UserClosing") Then
            Dim rez As Integer = MsgBox("Sair do KimKiLL Bot ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Attention !")
            If (rez = MsgBoxResult.No) Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub AjouterUnCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnCompteToolStripMenuItem.Click
        Dim frm As New FormAdd
        frm.Show()
    End Sub

    Private Sub ConfigurationGlobaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurationGlobaleToolStripMenuItem1.Click
        FormConfig.Show()
    End Sub

    Private Sub IntelligenceArtificielleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntelligenceArtificielleToolStripMenuItem.Click
        FormIA.Show()
    End Sub

    Private Sub ChargerUnCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerUnCompteToolStripMenuItem.Click
        If (ReturnAccounts() = "") Then
            MsgBox("Você deve adicionar uma conta antes de carregar um !", MsgBoxStyle.Exclamation, "Não Conta !")
        Else
            FormLoad.Show()
        End If
    End Sub

    Private Sub SupprimerUnCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppriemrUnCompteToolStripMenuItem.Click
        If (ReturnAccounts() = "") Then
            MsgBox("Você não tem uma conta a ser excluída!", MsgBoxStyle.Exclamation, "Não Conta  !")
        Else
            FormDel.Show()
        End If
    End Sub

    Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        For i As Integer = 0 To comptes.Count - 1
            comptes(i).TabUtilisateur.SetBounds(0, 0, Tab.Width, Tab.Height - 30)
        Next
    End Sub

    Private Sub ChargerConnecterTousLesBotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerConnecterTousLesBotsToolStripMenuItem.Click
        If (ReturnAccounts() = "") Then
            MsgBox("Você deve adicionar uma conta antes de carregar um!", MsgBoxStyle.Exclamation, "Não Conta !")
        Else
            FormLoad.Show()
            FormLoad.LoadAll_Click(sender, e)

            For i As Integer = 0 To comptes.Count - 1
                comptes(i).CreateSocket()
                wait(2000)
            Next
        End If
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click

        Dim message As String = ""

        message = "Kim KiLL Bot " & vbCrLf & _
            "não me responsabilizo por ban em sua conta." & vbCrLf


       
        MsgBox(message, MsgBoxStyle.Information, "KimKiLL Bot use com moderação")

    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AideToolStripMenuItem.Click

        Dim message As String = ""

        message = "Comando do Xat Box :" & vbCrLf & _
            "/autolaunch : combat solo" & vbCrLf & _
            "/multilaunch : Começar um luta após carregar" & vbCrLf & _
            "/stop : Parar bots" & vbCrLf & _
            "/startjoin : Começar o Combat" & vbCrLf & _
            "/stopjoin : Parar de seguir"

        MsgBox(message, MsgBoxStyle.Information, "By Kim '-'")

    End Sub

    Private Sub ChargerTousLesBotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerTousLesBotsToolStripMenuItem.Click
        If (ReturnAccounts() = "") Then
            MsgBox("Voce adiciona uma conta antes de carregar um !", MsgBoxStyle.Exclamation, "Senha da Conta!")
        Else
            FormLoad.Show()
            FormLoad.LoadAll_Click(sender, e)
        End If
    End Sub

    Private Sub ConnecterTousLesBotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConencterTousLesBotsToolStripMenuItem.Click
        If (comptes.Count = 0) Then
            MsgBox("Pas de compte chargé !", MsgBoxStyle.Exclamation, "Pas de compte !")
        End If
        For i As Integer = 0 To comptes.Count - 1
            comptes(i).CreateSocket()
            wait(2000)
        Next
    End Sub

    Private Sub ModifierUnCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierUnCompteToolStripMenuItem.Click
        If (ReturnAccounts() = "") Then
            MsgBox("Você deve adicionar uma conta antes de uma mudança !", MsgBoxStyle.Exclamation, "Não Conta !")
        Else
            FormModify.Show()
        End If
    End Sub

    Private Sub TimerRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRefresh.Tick
        If (comptes.Count <> 0) Then

            For i As Integer = 0 To comptes.Count - 1
                With comptes(i)

                    If (.enCombat) Then
                        .TabUtilisateur.LabelStat.ForeColor = Color.Green
                        .TabUtilisateur.LabelStat.Text = "Em Batalha"
                    ElseIf (.enRegen) Then
                        .TabUtilisateur.LabelStat.ForeColor = Color.Orange
                        .TabUtilisateur.LabelStat.Text = "Se Regenerando"
                    ElseIf (.enDeplacement) Then
                        .TabUtilisateur.LabelStat.ForeColor = Color.Blue
                        .TabUtilisateur.LabelStat.Text = "Em Movimento"
                    ElseIf (.enEchange) Then
                        .TabUtilisateur.LabelStat.ForeColor = Color.Purple
                        .TabUtilisateur.LabelStat.Text = "em troca"
                    ElseIf (.enFauche) Then
                        .TabUtilisateur.LabelStat.ForeColor = Color.Magenta
                        .TabUtilisateur.LabelStat.Text = "Na Cultura"
                    Else
                        .TabUtilisateur.LabelStat.ForeColor = Color.Red
                        .TabUtilisateur.LabelStat.Text = "Atendendo"
                    End If

                End With
            Next

        End If

    End Sub

    Private Sub Agrandir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agrandir.Click
        Me.Visible = True
        Tray.Visible = False
    End Sub

    Private Sub Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitter.Click
        Dim rez As Integer = MsgBox("Sair KimKiLL Bot ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Attention !")
        If (rez = MsgBoxResult.Yes) Then
            Tray.Visible = False
            End
        End If
    End Sub

    Private Sub Tray_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tray.DoubleClick
        Me.Visible = True
        Tray.Visible = False
    End Sub

    Private Sub SendToTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToTrayToolStripMenuItem.Click
        Me.Visible = False
        Tray.Visible = True
    End Sub

    Private Sub DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Click
        If (comptes.Count <> 0) Then

            For i As Integer = 0 To Tab.TabCount - 1
                With comptes(i)

                    If (comptes(i).sock.Connecter) Then
                        AutoLauncher(i)
                    End If

                End With
            Next

        End If
    End Sub

    Private Sub StopertousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopertousToolStripMenuItem.Click
        If (comptes.Count <> 0) Then

            For i As Integer = 0 To Tab.TabCount - 1
                With comptes(i)

                    If (comptes(i).sock.Connecter) Then
                        StopLaunch(i)
                    End If

                End With
            Next

        End If
    End Sub

    Private Sub DofusAccountCreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DofusAccountCreatorToolStripMenuItem.Click
        AccountCreator.Show()
    End Sub

    Private Sub CréateurDePersonnageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CréateurDePersonnageToolStripMenuItem.Click
        CharacterCreator.Show()
    End Sub

End Class
