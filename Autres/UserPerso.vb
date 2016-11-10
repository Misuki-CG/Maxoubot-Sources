Public Class UserPerso

    Private Sub SeConnecterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeConnecterToolStripMenuItem.Click
        comptes(Form.Tab.SelectedIndex).CreateSocket()
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.LabelEtat.ForeColor = Color.Blue
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.LabelEtat.Text = "Connexion"
        comptes(Form.Tab.SelectedIndex).autoReconnect = True
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 0) Then
            comptes(Form.Tab.SelectedIndex).socket.Connexion(False)
        Else
            comptes(Form.Tab.SelectedIndex).sock.Connexion(False)
        End If
        comptes(Form.Tab.SelectedIndex).connexionTermine = 0
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.LabelEtat.ForeColor = Color.Red
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.LabelEtat.Text = "Déconnecté"
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.SeDéconnecterToolStripMenuItem.Enabled = False
        comptes(Form.Tab.SelectedIndex).TabUtilisateur.SeConnecterToolStripMenuItem.Enabled = True
        comptes(Form.Tab.SelectedIndex).autoReconnect = False
    End Sub

    Private Sub PlusTerre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusTerre.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB10")
        End If
    End Sub

    Private Sub PlusVie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusVie.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB11")
        End If
    End Sub

    Private Sub PlusSag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusSag.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB12")
        End If
    End Sub

    Private Sub PlusFeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusFeu.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB15")
        End If
    End Sub

    Private Sub PlusEau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusEau.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB13")
        End If
    End Sub

    Private Sub PlusAir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusAir.Click
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("AB14")
        End If
    End Sub

    Private Sub SendToSock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SendToSock.KeyDown
        If (comptes(Form.Tab.SelectedIndex).connexionTermine = 1) Then
            If (e.KeyCode = Keys.Enter) Then
                comptes(Form.Tab.SelectedIndex).sock.Envoyer(SendToSock.Text)
                SendToSock.Text = ""
            End If
        End If
    End Sub

    Private Sub SendChatbox(ByVal caractere As String)

        With comptes(Form.Tab.SelectedIndex)

            If (Gettoks(SendToChat.Text, " ") > 1) Then
                Dim toSend As String = ""
                For i As Integer = 2 To Gettoks(SendToChat.Text, " ")
                    toSend &= Gettok(SendToChat.Text, " ", i) & " "
                Next
                toSend = Mid(toSend, 1, toSend.Length - 1)
                .sock.Envoyer("BM" & caractere & "|" & toSend & "|")
            End If

        End With

    End Sub

    Private Sub SendToChat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SendToChat.KeyDown

        With comptes(Form.Tab.SelectedIndex)

            If (.connexionTermine = 1) Then
                If (e.KeyCode = Keys.Enter) Then

                    If (Mid(SendToChat.Text, 1, 1) <> "/") Then
                        .sock.Envoyer("BM*|" & SendToChat.Text & "|")
                    ElseIf (Mid(SendToChat.Text, 2, 20) = "multilaunch") Then
                        MultiLaunch(Form.Tab.SelectedIndex)
                    ElseIf (Mid(SendToChat.Text, 2, 20) = "autolaunch") Then
                        AutoLauncher(Form.Tab.SelectedIndex)
                    ElseIf (Mid(SendToChat.Text, 2, 20) = "stop") Then
                        StopLaunch(Form.Tab.SelectedIndex)
                    ElseIf (Mid(SendToChat.Text, 2, 20) = "startjoin") Then
                        StartJoin(Form.Tab.SelectedIndex)
                    ElseIf (Mid(SendToChat.Text, 2, 20) = "stopjoin") Then
                        StopJoin(Form.Tab.SelectedIndex)

                    ElseIf (Mid(SendToChat.Text, 2, 20) = "debug") Then
                        toDebug = True
                        frmDebug = New FormDebug
                        frmDebug.Show()

                    ElseIf (Mid(SendToChat.Text, 2, 1) = "p") Then
                        SendChatbox("$")
                    ElseIf (Mid(SendToChat.Text, 2, 1) = "g") Then
                        SendChatbox("%")
                    ElseIf (Mid(SendToChat.Text, 2, 1) = "b") Then
                        SendChatbox("?")
                    ElseIf (Mid(SendToChat.Text, 2, 1) = "r") Then
                        SendChatbox(":")

                    ElseIf (Mid(SendToChat.Text, 2, 1) = "w") Then
                        If (Gettoks(SendToChat.Text, " ") > 2) Then
                            Dim player As String = Gettok(SendToChat.Text, " ", 2)
                            Dim toSend As String = ""
                            For i As Integer = 3 To Gettoks(SendToChat.Text, " ")
                                toSend &= Gettok(SendToChat.Text, " ", i) & " "
                            Next
                            toSend = Mid(toSend, 1, toSend.Length - 1)
                            .sock.Envoyer("BM" & player & "|" & toSend & "|")
                        End If

                    ElseIf (Mid(SendToChat.Text, 2, 6) = "invite") Then
                        If (Gettoks(SendToChat.Text, " ") > 1) Then
                            ChatBox.Text &= "<BOT> Invitation de " & Gettok(SendToChat.Text, " ", 2) & vbCrLf
                            .sock.Envoyer("PI" & Gettok(SendToChat.Text, " ", 2))
                        End If
                    End If

                    SendToChat.Text = ""

                End If
            End If

        End With

    End Sub

    Private Sub UpSpell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpSpell.Click
        With comptes(Form.Tab.SelectedIndex)

            If (.connexionTermine = 1) Then
                If (.idSort > 0) Then
                    .sock.Envoyer("SB" & .idSort)
                End If
            End If

        End With
    End Sub

    Private Sub DeleteLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteLog.Tick
        TextLog.Clear()
        Me.Refresh()
    End Sub

    Private Sub AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItem.Click
        Dim Lancer As String = Gettok(Objets.Text, "(", 2)
        Lancer = Mid(Lancer, 1, Len(Lancer) - 1)
        ListeObjets.Items.Add(Lancer & " - " & Gettok(Objets.Text, "(", 1))
        ListePrix.Items.Add(Prix.Text)
    End Sub

    Private Sub DelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelItem.Click
        If (ListeObjets.SelectedIndex > -1) Then
            ListePrix.Items.RemoveAt(ListeObjets.SelectedIndex)
            ListeObjets.Items.RemoveAt(ListeObjets.SelectedIndex)
        End If
    End Sub

    Private Sub Flooder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Flooder.CheckedChanged
        With comptes(Form.Tab.SelectedIndex)

            If (.connexionTermine = 1) Then
                If (Flooder.Checked = False) Then
                    .TimerFlood.Enabled = False
                Else
                    If (Secondes.Text = "0") Then
                        Secondes.Text = "1"
                    End If
                    .TimerFlood.Interval = CInt(Secondes.Text) * 1000
                    .TimerFlood.Enabled = True
                End If
            Else
                Flooder.Checked = False
            End If

        End With
    End Sub

    Private Sub Echange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With comptes(Form.Tab.SelectedIndex)

            If (.connexionTermine <> 1) Then
                Echange.Checked = False
            End If

        End With
    End Sub

    Private Sub DeleteInventaire_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DeleteInventaire.Opening

        If (ListeInventaire.SelectedItems.Count = 0) Then
            DestroyItemToolStripMenuItem.Enabled = False
            DonnerAuChefToolStripMenuItem.Enabled = False
        Else
            DestroyItemToolStripMenuItem.Enabled = True
            DonnerAuChefToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub DestroyItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestroyItemToolStripMenuItem.Click

        If (ListeInventaire.SelectedItems.Count > 1) Then
            Dim nombre As Integer = ListeInventaire.SelectedItems.Count
            Dim rez As Integer = MsgBox("Veux-tu vraiment détruire ces " & nombre.ToString & " objets ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Attention !")
            If (rez = MsgBoxResult.Yes) Then
                If (nombre < 6) Then
                    For i As Integer = 0 To nombre - 1
                        Dim id As String = ListeInventaire.SelectedItems(i).SubItems(3).Text
                        Dim quantite As String = ListeInventaire.SelectedItems(i).SubItems(2).Text
                        comptes(Form.Tab.SelectedIndex).sock.Envoyer("Od" & id & "|" & quantite)
                    Next
                Else
                    MsgBox("Pas plus de 5 objets à la fois !", MsgBoxStyle.Exclamation, "Va y doucement !")
                End If
            End If
        Else
            Dim id As String = ListeInventaire.SelectedItems(0).SubItems(3).Text
            Dim quantite As String = ListeInventaire.SelectedItems(0).SubItems(2).Text
            comptes(Form.Tab.SelectedIndex).sock.Envoyer("Od" & id & "|" & quantite)
        End If

    End Sub

    Private Sub DonnerAuChefToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonnerAuChefToolStripMenuItem.Click
        With comptes(Form.Tab.SelectedIndex)

            If (.enEchange = 0) Then
                MsgBox("Tu dois d'abord lancer un échange au bot !", MsgBoxStyle.Exclamation, "Impossible !")
            Else
                Dim nombre As Integer = ListeInventaire.SelectedItems.Count
                For i As Integer = 0 To nombre - 1
                    Dim id As String = ListeInventaire.SelectedItems(i).SubItems(3).Text
                    Dim quantite As String = ListeInventaire.SelectedItems(i).SubItems(2).Text
                    .sock.Envoyer("EMO+" & id & "|" & quantite)
                    wait(1000)
                    .sock.Envoyer("EK")
                Next
            End If

        End With
    End Sub

    Private Sub LaunchRessource(ByVal CheckedBox As CheckBox, ByVal name As String, ByVal id As Integer)
        With comptes(Form.Tab.SelectedIndex)

            If (CheckedBox.Checked) Then
                If (.TimerFauche.Enabled = False) Then
                    .idRessource = id
                    .nomRessource = name
                    .TimerFauche.Enabled = True
                    .GetFauche()
                Else
                    CheckedBox.Checked = False
                End If
            ElseIf (.idRessource = id) Then
                .TimerFauche.Enabled = False
            End If

        End With
    End Sub

#Region "Récolte"

    Private Sub BotBle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBle.CheckedChanged
        LaunchRessource(BotBle, "Ble", 45)
    End Sub

    Private Sub BotOrge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotOrge.CheckedChanged
        LaunchRessource(BotOrge, "Orge", 53)
    End Sub

    Private Sub BotAvoine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotAvoine.CheckedChanged
        LaunchRessource(BotAvoine, "Avoine", 57)
    End Sub

    Private Sub BotSeigle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotSeigle.CheckedChanged
        LaunchRessource(BotSeigle, "Seigle", 52)
    End Sub

    Private Sub BotHoublon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotHoublon.CheckedChanged
        LaunchRessource(BotHoublon, "Houblon", 46)
    End Sub

    Private Sub BotMalt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotMalt.CheckedChanged
        LaunchRessource(BotMalt, "Malt", 58)
    End Sub

    Private Sub BotFrene_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotFrene.CheckedChanged
        LaunchRessource(BotFrene, "Frene", 6)
    End Sub

    Private Sub BotChataignier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotChataignier.CheckedChanged
        LaunchRessource(BotChataignier, "Chataigner", 39)
    End Sub

    Private Sub BotNoyer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotNoyer.CheckedChanged
        LaunchRessource(BotNoyer, "Noyer", 40)
    End Sub

    Private Sub BotChene_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotChene.CheckedChanged
        LaunchRessource(BotChene, "Chene", 10)
    End Sub

    Private Sub BotBombu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBombu.CheckedChanged
        LaunchRessource(BotBombu, "Bombu", 139)
    End Sub

    Private Sub BotOliviolet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotOliviolet.CheckedChanged
        LaunchRessource(BotOliviolet, "Oliviolet", 141)
    End Sub

    Private Sub BotErable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotErable.CheckedChanged
        LaunchRessource(BotErable, "Erable", 37)
    End Sub

    Private Sub BotRiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotRiz.CheckedChanged
        LaunchRessource(BotRiz, "Riz", 159)
    End Sub

    Private Sub BotIf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotIf.CheckedChanged
        LaunchRessource(BotIf, "If", 33)
    End Sub

    Private Sub BotLin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotLin.CheckedChanged
        LaunchRessource(BotLin, "Lin", 50)
    End Sub

    Private Sub BotBambou_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBambou.CheckedChanged
        LaunchRessource(BotBambou, "Bambou", 154)
    End Sub

    Private Sub BotMerisier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotMerisier.CheckedChanged
        LaunchRessource(BotMerisier, "Merisier", 41)
    End Sub

    Private Sub BotEbene_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotEbene.CheckedChanged
        LaunchRessource(BotEbene, "Ebene", 34)
    End Sub

    Private Sub BotKaliptus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotKaliptus.CheckedChanged
        LaunchRessource(BotKaliptus, "Kaliptus", 174)
    End Sub

    Private Sub BotCharme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotCharme.CheckedChanged
        LaunchRessource(BotCharme, "Charme", 38)
    End Sub

    Private Sub BotBombouSombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBombouSombre.CheckedChanged
        LaunchRessource(BotBombouSombre, "Bambou Sombre", 155)
    End Sub

    Private Sub BotOrme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotOrme.CheckedChanged
        LaunchRessource(BotOrme, "Orme", 35)
    End Sub

    Private Sub BotBambouSacre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBambouSacre.CheckedChanged
        LaunchRessource(BotBambouSacre, "Bambou Sacre", 158)
    End Sub

    Private Sub BotLinAlchi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotLinAlchi.CheckedChanged
        LaunchRessource(BotLinAlchi, "Lin", 68)
    End Sub

    Private Sub BotFer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotFer.CheckedChanged
        LaunchRessource(BotFer, "Fer", 24)
    End Sub

    Private Sub BotChanvreAlchi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotChanvreAlchi.CheckedChanged
        LaunchRessource(BotChanvreAlchi, "Chanvre", 69)
    End Sub

    Private Sub BotChanvre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotChanvre.CheckedChanged
        LaunchRessource(BotChanvre, "Chanvre", 54)
    End Sub

    Private Sub BotTrefle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotTrefle.CheckedChanged
        LaunchRessource(BotTrefle, "Trefle a 5 feuilles", 71)
    End Sub

    Private Sub BotMentheSauvage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotMentheSauvage.CheckedChanged
        LaunchRessource(BotMentheSauvage, "Menthe Sauvage", 72)
    End Sub

    Private Sub BotOrchideeFreyesque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotOrchideeFreyesque.CheckedChanged
        LaunchRessource(BotOrchideeFreyesque, "Orchidee Freyesque", 73)
    End Sub

    Private Sub BotEdelweiss_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotEdelweiss.CheckedChanged
        LaunchRessource(BotEdelweiss, "Edelweiss", 74)
    End Sub

    Private Sub BotPandouille_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotPandouille.CheckedChanged
        LaunchRessource(BotPandouille, "Pandouille", 160)
    End Sub

    Private Sub BotCuivre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotCuivre.CheckedChanged
        LaunchRessource(BotCuivre, "Cuivre", 25)
    End Sub

    Private Sub BotBronze_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBronze.CheckedChanged
        LaunchRessource(BotBronze, "Bronze", 26)
    End Sub

    Private Sub BotKobalte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotKobalte.CheckedChanged
        LaunchRessource(BotKobalte, "Kobalte", 28)
    End Sub

    Private Sub BotManganese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotManganese.CheckedChanged
        LaunchRessource(BotManganese, "Manganese", 56)
    End Sub

    Private Sub BotDolomite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotDolomite.CheckedChanged
        LaunchRessource(BotDolomite, "Dolomite", 161)
    End Sub

    Private Sub BotOr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotOr.CheckedChanged
        LaunchRessource(BotOr, "Or", 30)
    End Sub

    Private Sub BotBauxite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotBauxite.CheckedChanged
        LaunchRessource(BotBauxite, "Bauxite", 31)
    End Sub

    Private Sub BotArgent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotArgent.CheckedChanged
        LaunchRessource(BotArgent, "Argent", 29)
    End Sub

    Private Sub BotSilicate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotSilicate.CheckedChanged
        LaunchRessource(BotSilicate, "Silicate", 162)
    End Sub

    Private Sub BotEtain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotEtain.CheckedChanged
        LaunchRessource(BotEtain, "Etain", 55)
    End Sub

    Private Sub PetitsPoissonsRiviere_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetitsPoissonsRiviere.CheckedChanged
        LaunchRessource(PetitsPoissonsRiviere, "Petits poissons (riviere)", 124)
    End Sub

    Private Sub PetitsPoissonsMer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetitsPoissonsMer.CheckedChanged
        LaunchRessource(PetitsPoissonsMer, "Petits poissons (mer)", 128)
    End Sub

    Private Sub PoissonsRiviere_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoissonsRiviere.CheckedChanged
        LaunchRessource(PoissonsRiviere, "Poissons (riviere)", 125)
    End Sub

    Private Sub PoissonsMer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoissonsMer.CheckedChanged
        LaunchRessource(PoissonsMer, "Poissons (mer)", 129)
    End Sub

    Private Sub GrosPoissonsRiviere_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrosPoissonsRiviere.CheckedChanged
        LaunchRessource(GrosPoissonsRiviere, "Gros poissons (riviere)", 126)
    End Sub

    Private Sub GrosPoissonsMer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrosPoissonsMer.CheckedChanged
        LaunchRessource(GrosPoissonsMer, "Gros poissons (mer)", 130)
    End Sub

    Private Sub PoissonsGeantsRiviere_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoissonsGeantsRiviere.CheckedChanged
        LaunchRessource(PoissonsGeantsRiviere, "Poissons geants (riviere)", 127)
    End Sub

    Private Sub PoissonsGeantsMer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoissonsGeantsMer.CheckedChanged
        LaunchRessource(PoissonsGeantsMer, "Poissons geantss (mer)", 131)
    End Sub

#End Region

    Private Sub ChangeMapHaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeMapHaut.Click
        If (comptes(Form.Tab.SelectedIndex).changeurHaut <> -1) Then comptes(Form.Tab.SelectedIndex).SeDeplacer(comptes(Form.Tab.SelectedIndex).changeurHaut)
    End Sub

    Private Sub ChangeMapBas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeMapBas.Click
        If (comptes(Form.Tab.SelectedIndex).changeurBas <> -1) Then comptes(Form.Tab.SelectedIndex).SeDeplacer(comptes(Form.Tab.SelectedIndex).changeurBas)
    End Sub

    Private Sub ChangeMapGauche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeMapGauche.Click
        If (comptes(Form.Tab.SelectedIndex).changeurGauche <> -1) Then comptes(Form.Tab.SelectedIndex).SeDeplacer(comptes(Form.Tab.SelectedIndex).changeurGauche)
    End Sub

    Private Sub ChangeMapDroite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeMapDroite.Click
        If (comptes(Form.Tab.SelectedIndex).changeurDroite <> -1) Then comptes(Form.Tab.SelectedIndex).SeDeplacer(comptes(Form.Tab.SelectedIndex).changeurDroite)
    End Sub

    Private Sub RejoindreLeChefToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejoindreLeChefToolStripMenuItem.Click
        With comptes(Form.Tab.SelectedIndex)
            If .nomChef <> "" Then
                .sock.Envoyer("FJF" & .nomChef)
            End If
        End With
    End Sub

    Private Sub CongigurerLesFinsDePhraseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CongigurerLesFinsDePhraseToolStripMenuItem.Click
        FormFinPhrase.Show()
    End Sub

    Private Sub AddMessageMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMessageMP.Click
        Dim theItem As ListViewItem = ListFloodMP.Items.Add(MessageToAdd.Text)
        theItem.SubItems.Add(NivMin.Text)
        theItem.SubItems.Add(NivMax.Text)
    End Sub

End Class