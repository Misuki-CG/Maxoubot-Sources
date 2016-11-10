Partial Public Class Perso

    Dim caseDeFauche As Integer
    Dim PacketDuCombat As String
    Dim CaseDuDeplacement As Integer
    Dim tempsFauche As Integer
    Dim tempsRegenerate As Integer
    Delegate Sub ThreadDelegate()

    Public Sub Regenerate(ByVal time As Integer)
        tempsRegenerate = time
        Dim thread As New Threading.Thread(AddressOf Regenerating)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Private Sub Regenerating()

        enRegen = 1

        Threading.Thread.Sleep(tempsRegenerate)

        enRegen = 0

    End Sub

    Public Sub LaunchBattle()

        If autoLaunch And isIdle() Then
            Dim ThreadBattle As New Threading.Thread(AddressOf Launching)
            ThreadBattle.IsBackground = True
            ThreadBattle.Start()
        End If

    End Sub

    Private Sub Launching()

        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ThreadDelegate(AddressOf Launching))
        Else

            System.Threading.Thread.Sleep(500)


            If TabUtilisateur.ListMonster.Items.Count = 0 Then
                If ChangerDeMap Then ChangerMap()
            Else

                Dim cell As Integer = CInt(TabUtilisateur.ListMonster.Items(0).SubItems(1).Text)
                If caseActuelle <> cell And cell <> -1 Then
                    Debug("Monster " & cell & " found")
                    SeDeplacer(cell)
                Else
                    Debug("Error on moster " & cell & ", deleting")
                    TabUtilisateur.ListMonster.Items.RemoveAt(0)
                End If

            End If

        End If

    End Sub

    Public Sub GetFauche()

        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ThreadDelegate(AddressOf GetFauche))
        Else

            If isIdle() Then

                For i As Integer = 0 To TabUtilisateur.ListeRessources.Items.Count - 1

                    If (TabUtilisateur.ListeRessources.Items(i).SubItems(0).Text = nomRessource) Then
                        If (TabUtilisateur.ListeRessources.Items(i).SubItems(2).Text = "Non coupé") Then

                            Dim caseAFaucher As Integer = TabUtilisateur.ListeRessources.Items(i).SubItems(1).Text

                            If caseAFaucher <> caseActuelle Then
                                Faucher(caseAFaucher)
                                Exit Sub
                            End If

                        End If
                    End If

                Next

                ChangerMap()

            End If

        End If

    End Sub

    Public Sub Faucher(ByVal caseFauche As Integer)

        Dim ThreadFauche As New Threading.Thread(AddressOf Fauche)
        ThreadFauche.IsBackground = True
        caseDeFauche = caseFauche
        ThreadFauche.Start()

    End Sub

    Private Sub Fauche()

        If (TabUtilisateur.InvokeRequired) Then
            TabUtilisateur.Invoke(New ThreadDelegate(AddressOf Fauche))
        Else

            Dim caseFauche As Integer = caseDeFauche
            If (bloqueGA = 0) Then
                bloqueGA = 1

                Debug("Collecting cell " & caseFauche)

                Dim Rand As New Random

                Dim path As String = ""
                Dim pather As New Pathfinding
                If (mapDataActuel(caseFauche).movement = 2) Then
                    path = pather.pathing(mapDataActuel, caseActuelle, caseFauche)
                Else
                    path = pather.pathing(mapDataActuel, caseActuelle, caseFauche, True)
                End If

                If path <> "" Then

                    sock.Envoyer("GA001" & path)
                    enDeplacement = 1

                    wait(distance(caseActuelle, caseFauche) * 330)

                    sock.Envoyer("GA500" & caseFauche & ";" & idRessource)
                    sock.Envoyer("GKK0")
                    bloqueGA = 0
                    enDeplacement = 0

                Else

                    bloqueGA = 0

                    Debug("Error on cell " & caseFauche & ", deleting")

                    For i As Integer = 0 To TabUtilisateur.ListeRessources.Items.Count - 1

                        If (TabUtilisateur.ListeRessources.Items(i).SubItems(0).Text = nomRessource) Then
                            If (TabUtilisateur.ListeRessources.Items(i).SubItems(2).Text = "Non coupé") Then

                                Dim caseAFaucher As Integer = TabUtilisateur.ListeRessources.Items(i).SubItems(1).Text

                                If caseAFaucher <> caseActuelle Then
                                    TabUtilisateur.ListeRessources.Items.RemoveAt(i)
                                    Exit Sub
                                End If

                            End If

                        End If

                    Next

                End If

            End If

        End If

    End Sub

    Public Sub WaitFauche(ByVal tempsDeFauche As Integer)

        Dim ThreadWaitFauche As New Threading.Thread(AddressOf WaitingFauche)
        tempsFauche = tempsDeFauche
        ThreadWaitFauche.IsBackground = True
        ThreadWaitFauche.Start()

    End Sub

    Public Sub WaitingFauche()

        Debug("Waiting for collect")

        Dim Rand As New Random
        Dim tempsDeFauche As Integer = tempsFauche

        enFauche = 1

        Threading.Thread.Sleep(tempsDeFauche)
        sock.Envoyer("GKK1")

        enFauche = 0

        Debug("End of collect-waiting")

    End Sub

    Public Sub SeDeplacer(ByVal caseFin As Integer)

        Dim ThreadDeplac As New Threading.Thread(AddressOf SeDeplace)
        CaseDuDeplacement = caseFin
        ThreadDeplac.IsBackground = True
        ThreadDeplac.Start()

    End Sub

    Private Sub SeDeplace()

        Dim caseFin As Integer = CaseDuDeplacement
        If (bloqueGA = 0) Then
            bloqueGA = 1

            Debug("Moving from " & caseActuelle & " to " & caseFin)

            Dim path As String = ""
            Dim pather As New Pathfinding
            path = pather.pathing(mapDataActuel, caseActuelle, caseFin, True)

            If path <> "" Then

                sock.Envoyer("GA001" & path)
                enDeplacement = 1

                If (distance(caseActuelle, caseFin) < 6) Then
                    wait(distance(caseActuelle, caseFin) * 300)
                Else
                    wait(distance(caseActuelle, caseFin) * 250)
                End If

                sock.Envoyer("GKK0")

            Else

                Debug("Error on path from " & caseActuelle & " to " & caseFin & " !")
                TabUtilisateur.ListPlayers.Items.Clear()
                TabUtilisateur.ListMonster.Items.Clear()
                sock.Envoyer("GI")

            End If

            wait(500)

            bloqueGA = 0
            enDeplacement = 0

        End If

    End Sub

    Public Sub SeDeplacerMap(ByVal caseFin As Integer)

        Dim ThreadMap As New Threading.Thread(AddressOf SeDeplaceMap)
        CaseDuDeplacement = caseFin
        ThreadMap.IsBackground = True
        ThreadMap.Start()

    End Sub

    Private Sub SeDeplaceMap()

        Dim caseFin As Integer = CaseDuDeplacement
        If (bloqueGA = 0) Then
            bloqueGA = 1

            Dim Rand As New Random

            If inParty Then
                sock.Envoyer("BM$|.go" & Rand.Next(1000, 9999) & " " & caseFin.ToString)
            End If

            wait(Rand.Next(500, 1000))

            Debug("Moving from " & caseActuelle & " to " & caseFin)

            Dim path As String = ""
            Dim pather As New Pathfinding
            path = pather.pathing(mapDataActuel, caseActuelle, caseFin, True)

            If path <> "" Then

                sock.Envoyer("GA001" & path)
                enDeplacement = 1

                If (distance(caseActuelle, caseFin) < 6) Then
                    wait(distance(caseActuelle, caseFin) * 300)
                Else
                    wait(distance(caseActuelle, caseFin) * 250)
                End If

                sock.Envoyer("GKK0")

            Else

                Debug("Error on path from " & caseActuelle & " to " & caseFin & " !")
                sock.Envoyer("GI")

            End If

            wait(500)

            changeDeMap = 0
            bloqueGA = 0
            enDeplacement = 0

        End If

    End Sub

    Public Sub SendGo()

        Dim ThreadGo As New Threading.Thread(AddressOf SendGoing)
        ThreadGo.IsBackground = True
        ThreadGo.Start()

    End Sub

    Private Sub SendGoing()

        Dim Rand As New Random

        If autoLaunch And BloqueGroupe And inParty Then
            sock.Envoyer("fP")
        End If

        If autoLaunch And BloqueSpectateur Then
            Dim random As Integer = Rand.Next(300, 700)
            System.Threading.Thread.Sleep(random)
            sock.Envoyer("fS")
        End If

        If autoLaunch And inParty Then
            Dim random As Integer = Rand.Next(1900, 2300)
            System.Threading.Thread.Sleep(random)
        Else
            Dim random As Integer = Rand.Next(300, 800)
            System.Threading.Thread.Sleep(random)
        End If
        sock.Envoyer("GR1")

    End Sub

    Public Sub JoinCombat(ByVal combat As String)

        PacketDuCombat = combat
        Dim ThreadJoin As New Threading.Thread(AddressOf JoiningCombat)
        ThreadJoin.IsBackground = True
        ThreadJoin.Start()

    End Sub

    Private Sub JoiningCombat()

        Dim Rand As New Random
        System.Threading.Thread.Sleep(Rand.Next(900, 1600))
        sock.Envoyer("GA903" & PacketDuCombat & ";" & PacketDuCombat)

    End Sub

End Class
