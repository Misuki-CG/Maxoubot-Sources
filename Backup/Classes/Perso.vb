Public Class Perso

    ' Infos enregistrés
    Public nomDuCompte, passDuCompte As String
    Public idServeur As Integer
    Public passBot, passJoin, passFollow As String
    Public numeroPerso As Integer

    ' Où en suis-je ?
    Public connexionTermine As Integer = 0
    Public enDeplacement, enCombat, enRegen, enEchange, enFauche As Integer
    Public changeDeMap As Integer
    Public autoReconnect As Boolean
    Public inParty As Boolean

    ' L'ID sur le programme
    Dim monId As Integer

    ' Variables de connexion
    Public ipServeurJeu As String
    Public idConnexion As String

    ' Actions diverses
    Public monNom, monIdDofus As String
    Public nomChef, idChef As String
    Public idSort, nombreLance, Cible As String
    Public toFrappe, toHeal, toMe, caseDeLance As String
    Public followChef, joinChef, joinAll, autoLaunch As Boolean

    ' Echange
    Public objetsID(256), objetsIdType(256), idEchange As String
    Public objetsQuantite(256), nombreE As Integer

    ' Flood
    Public WithEvents TimerFlood As New Timer
    Public nombreSend As Integer

    ' Auto Launch
    Public bloqueGA, caseActuelle, dernierMob As Integer
    Public nombreDeCombat As Integer
    Dim lastChangementMap As Integer
    Public WithEvents TimerLaunch As New Timer

    ' Maps
    Public mapDataActuel(1280) As Cell
    Public mapActuelle As Integer
    Public changeurHaut, changeurBas, changeurDroite, changeurGauche As Integer

    ' ElgSocket
    Public socket, sock As ElgSocketClient

    ' Tab Principal
    Dim TabPerso As New TabPage
    Public TabUtilisateur As New UserPerso

    ' Faucher
    Public WithEvents TimerFauche As New Timer
    Public nomRessource As String, idRessource As Integer

    ' Anti afk
    Public WithEvents TimerAfk As New Timer

    ' Maitre absolu
    Public idMaitre, nomMaitre As String

    Public Function isIdle() As Boolean

        Return enDeplacement = 0 And enCombat = 0 And enEchange = 0 And enRegen = 0 And enFauche = 0

    End Function

    Public Sub Initialiser()

        TabPerso.Text = nomDuCompte
        TabPerso.BackColor = Color.White
        Form.Tab.Controls.Add(TabPerso)
        TabPerso.Controls.Add(TabUtilisateur)

        monId = comptes.Count - 1

        LoadItems(monId)
        For i As Integer = 1 To 250
            objetsQuantite(i) = 0
            objetsID(i) = Nothing
            objetsIdType(i) = Nothing
        Next

        TimerFauche.Interval = 1500
        TimerLaunch.Interval = 2000
        TimerAfk.Interval = 60000

        TimerAfk.Enabled = True

        autoReconnect = True
        inParty = False

    End Sub

    Public Sub CreateSocket()


        TabUtilisateur.SeDéconnecterToolStripMenuItem.Enabled = True
        TabUtilisateur.SeConnecterToolStripMenuItem.Enabled = False

        socket = New ElgSocketClient(ipServeurLogin, 443)

        AddHandler socket.OnConnexion, AddressOf e_Connexion
        AddHandler socket.OnEnvoie, AddressOf e_Envoi
        AddHandler socket.OnReception, AddressOf e_Reception
        AddHandler socket.OnErreur, AddressOf e_Erreur

    End Sub

    Public Sub CreateSock()

        Dim ipServeurMod As String = ipServeurJeu.Replace(" ", "")
        sock = New ElgSocketClient(ipServeurMod, 443)

        AddHandler sock.OnConnexion, AddressOf e_ConnexionJeu
        AddHandler sock.OnDeconnexion, AddressOf e_Deconnexion
        AddHandler sock.OnEnvoie, AddressOf e_Envoi
        AddHandler sock.OnReception, AddressOf e_Reception
        AddHandler sock.OnErreur, AddressOf e_Erreur

        TabUtilisateur.LabelEtat.Text = "Connexion au jeu"
        TabUtilisateur.LabelEtat.ForeColor = Color.BlueViolet

    End Sub

    Public Sub e_Connexion(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si on est connecté au serveur Login
        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Connexion), Sender, e)
        Else
            TabUtilisateur.LabelEtat.Text = "Connecté"
            TabUtilisateur.LabelEtat.ForeColor = Color.MediumSeaGreen
        End If

    End Sub

    Public Sub e_ConnexionJeu(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si on est connecté au serveur de Jeu
        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_ConnexionJeu), Sender, e)
        Else
            TabUtilisateur.LabelEtat.Text = "Connecté au jeu"
            TabUtilisateur.LabelEtat.ForeColor = Color.Green
        End If

    End Sub

    Public Sub e_Deconnexion(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si on est déconnnecté
        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Deconnexion), Sender, e)
        Else
            TabUtilisateur.LabelEtat.Text = "Déconnecté"
            TabUtilisateur.LabelEtat.ForeColor = Color.Red
            connexionTermine = 0
        End If

    End Sub

    Public Sub e_Erreur(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si il y a eu une erreur :

        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Erreur), Sender, e)
        Else

            TabUtilisateur.LabelEtat.Text = "Déconnecté"
            TabUtilisateur.LabelEtat.ForeColor = Color.Red
            connexionTermine = 0
            If (autoReconnect) Then
                If (socket.Connecter = False) Then
                    CreateSocket()
                End If
            End If
        End If

    End Sub

    Public Sub e_Envoi(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si on envoie quelque chose
        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Envoi), Sender, e)
        Else

            'Loger
            If (TabUtilisateur.NePasAfficherLeLogToolStripMenuItem.Checked = False) Then
                If (Gettok(e.Message, Chr(10), 1) = nomDuCompte) Then
                    TabUtilisateur.TextLog.AppendText("Send: " & nomDuCompte & "# - Crypt -" & vbCrLf)
                Else
                    Dim Log As String = e.Message.Replace(Chr(10), "").Replace(Chr(0), "")
                    TabUtilisateur.TextLog.AppendText("Send: " & Log & vbCrLf)
                End If
                TabUtilisateur.TextLog.ScrollToCaret()
            End If

        End If

    End Sub

    Public Sub e_Reception(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si on recoit quelque chose

        If (e.Message <> Nothing) Then

            If (Mid(e.Message, 1, 4) = "AXEf") Then ' si le serveur est pas plein
            ElseIf (Mid(e.Message, 1, 4) = "AXEd") Then 'si le serveur est pas en maintenance
            ElseIf (Mid(e.Message, 1, 2) = "AX") Then
                ' Fonction de cryptage serveur
                Dim ipCrypt As String = Mid(e.Message, 4, 8)

                Dim i As Long = 0
                Dim fois As Long = 0
                ipServeurJeu = ""
                While (i < 8)
                    i = i + 1
                    fois = fois + 1
                    Dim dat1 As Integer = Asc(Mid(ipCrypt, i, 1)) - 48
                    i = i + 1
                    Dim dat2 As Integer = Asc(Mid(ipCrypt, i, 1)) - 48
                    Dim Dat3 As String = Str(((dat1 And 15) << 4 Or dat2 And 15))
                    If (fois > 1) Then
                        ipServeurJeu = ipServeurJeu + Mid(Dat3, 2)
                    Else
                        ipServeurJeu = ipServeurJeu + Dat3
                    End If
                    If (i < 8) Then
                        ipServeurJeu = ipServeurJeu + "."
                    End If
                End While
            End If

            If (TabUtilisateur.InvokeRequired) Then
                TabUtilisateur.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Reception), Sender, e)
            Else

                'Loger
                If (TabUtilisateur.NePasAfficherLeLogToolStripMenuItem.Checked = False) Then
                    TabUtilisateur.TextLog.AppendText("Recv: " & e.Message & vbCrLf)
                    TabUtilisateur.TextLog.ScrollToCaret()
                End If

                Try

                    If (connexionTermine = 0) Then
                        PacketConnexion(monId, e.Message)
                    ElseIf (Mid(e.Message, 1, 2) = "As") Then
                        PacketAs(monId, e.Message)
                    ElseIf (Mid(e.Message, 1, 3) = "cMK") Then
                        PacketChat(monId, e.Message)
                    ElseIf (Mid(e.Message, 1, 4) = "GM|+") Then
                        PacketAddMob(monId, e.Message)
                    ElseIf ((Mid(e.Message, 1, 2) = "GA") AndAlso (Mid(e.Message, 1, 3) <> "GAF")) Then
                        PacketGA(monId, e.Message)
                    ElseIf (Mid(e.Message, 1, 1) = "E") Then
                        PacketEchange(monId, e.Message)
                    ElseIf (Mid(e.Message, 1, 1) = "O") Then
                        PacketInventaire(monId, e.Message)

                    ElseIf (Mid(e.Message, 1, 3) = "GDF") Then
                        PacketRessources(monId, e.Message)

                    ElseIf (Mid(e.Message, 1, 3) = "GCK") Then
                        monNom = Gettok(e.Message, "|", 3)
                        TabUtilisateur.TextPerso.Text = Gettok(e.Message, "|", 3)

                    ElseIf (Mid(e.Message, 1, 3) = "GDM") Then
                        TimerLaunch.Enabled = False
                        Dim idMap As String = Gettok(e.Message, "|", 2)
                        Dim indice As String = Gettok(e.Message, "|", 3)
                        Dim clef As String = Gettok(e.Message, "|", 4)
                        TabUtilisateur.ListPlayers.Items.Clear()
                        TabUtilisateur.ListMonster.Items.Clear()
                        LoadMap(monId, idMap, indice, clef)
                        sock.Envoyer("GI")

                    ElseIf (Mid(e.Message, 1, 3) = "GDK") Then
                        If autoLaunch Then
                            LaunchBattle()
                            TimerLaunch.Enabled = True
                        End If

                    ElseIf (Mid(e.Message, 1, 1) = "G") Then
                        PacketCombat(monId, e.Message)

                    ElseIf (Mid(e.Message, 1, 3) = "PIK") Then
                        Dim NomDuMec As String = Mid(Gettok(e.Message, "|", 1), 4)
                        Dim NomDuInvite As String = Gettok(e.Message, "|", 2)
                        If NomDuInvite = monNom Then
                            If (NomDuMec = nomChef) Then
                                sock.Envoyer("PA")
                            Else
                                sock.Envoyer("PR")
                            End If
                        End If

                    ElseIf (Mid(e.Message, 1, 2) = "PC") Then
                        inParty = True
                    ElseIf (Mid(e.Message, 1, 2) = "PV") Then
                        inParty = False
                    End If

                    If (Mid(e.Message, 1, 2) = "GM") Then
                        PacketMovement(monId, e.Message)
                    End If

                    If (Mid(e.Message, 1, 3) = "ASK") Then
                        PacketObjets(monId, e.Message)
                    End If

                    Protect.Process(e.Message, monId)

                Catch ex As Exception
                End Try

            End If
        End If

    End Sub

    Public Sub SendMp()

        Dim rand As New Random

        System.Threading.Thread.Sleep(rand.Next(15000, 25000))

        Dim packet As String = "BM"
        packet &= Threading.Thread.CurrentThread.Name
        packet &= "|"

        sock.envoyer(packet)

    End Sub

    Private Sub TimerFlood_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFlood.Tick
        nombreSend += 1

        Dim theMessage As String = TabUtilisateur.TexteFlood.Text

        If addChiffre Or addLettre Or addSymbol Then
            theMessage &= " ["
            theMessage &= RandomKey(addLettre, addChiffre, addSymbol)
            theMessage &= "]"
        End If

        If addSmiley Then theMessage &= " " & Smiley()

        sock.Envoyer("BM*|" & theMessage & "|")
        TabUtilisateur.NumFlood.Text = nombreSend
    End Sub

    Public Sub ChangerMap()

        nombreDeCombat = 0

        Dim rand As New Random

        If lastChangementMap = 0 Then

            Dim random As Integer = rand.Next(1, 4)
            Dim random2 As Integer = rand.Next(1000, 9999)
            Dim fatal As Boolean = False
            If (random = 4) Then
                If changeurHaut <> -1 Then
                    SeDeplacerMap(changeurHaut)
                    fatal = True
                    lastChangementMap = 1
                Else
                    random = rand.Next(1, 3)
                End If
            End If
            If (random = 3) Then
                If changeurBas <> -1 Then
                    SeDeplacerMap(changeurBas)
                    fatal = True
                    lastChangementMap = 2
                Else
                    random = rand.Next(1, 2)
                End If
            End If
            If (random = 2) Then
                If changeurGauche <> -1 Then
                    SeDeplacerMap(changeurGauche)
                    fatal = True
                    lastChangementMap = 3
                Else
                    random = 1
                End If
            End If
            If (random = 1) Then
                If changeurDroite <> -1 Then
                    SeDeplacerMap(changeurDroite)
                    fatal = True
                    lastChangementMap = 4
                End If
            End If

        ElseIf (lastChangementMap = 1) Then
            If changeurBas <> -1 Then
                SeDeplacerMap(changeurBas)
                lastChangementMap = 0
            End If

        ElseIf (lastChangementMap = 2) Then
            If changeurHaut <> -1 Then
                SeDeplacerMap(changeurHaut)
                lastChangementMap = 0
            End If

        ElseIf (lastChangementMap = 3) Then
            If changeurDroite <> -1 Then
                SeDeplacerMap(changeurDroite)
                lastChangementMap = 0
            End If

        ElseIf (lastChangementMap = 4) Then
            If changeurGauche <> -1 Then
                SeDeplacerMap(changeurGauche)
                lastChangementMap = 0
            End If

        End If

    End Sub

    Private Sub TimerFauche_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFauche.Tick
        GetFauche()
    End Sub

    Private Sub TimerLaunch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLaunch.Tick
        LaunchBattle()
    End Sub

    Private Sub TimerAfk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAfk.Tick

        If TabUtilisateur.CheckAfk.Checked And isIdle() Then

            Dim MegaList As New List(Of Integer)

            For i As Integer = 10 To 1000

                If mapDataActuel(i).movement <> 0 Then
                    If mapDataActuel(i).movement <> 2 Then
                        If mapDataActuel(i).object2Movement = False Then
                            If caseActuelle <> i Then
                                MegaList.Add(i)
                            End If
                        End If
                    End If
                End If

            Next

            If MegaList.Count > 0 Then

                Dim newCellItem As Integer = (New Random).Next(0, MegaList.Count - 1)
                Dim newCell As Integer = MegaList(newCellItem)

                Debug("Anti AFK: Moving to " & newCellItem & "/" & newCell)

                SeDeplacer(newCell)

            End If

        End If

    End Sub

    Delegate Sub DebugDelegate(ByVal Text As String)

    Public Sub Debug(ByVal Text As String)

        If (frmDebug.InvokeRequired) Then
            frmDebug.Invoke(New DebugDelegate(AddressOf Debug), Text)
        Else

            If toDebug Then frmDebug.TextDebug.AppendText("[" & monId & "]" & " " & Text & vbCrLf)

        End If

    End Sub

End Class
