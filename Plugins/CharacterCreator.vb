Public Class CharacterCreator

    Public Sock As ElgSocketClient
    Public Socket As ElgSocketClient
    Dim id, ip, ax, monNom As String
    Dim caseActuelle As Integer
    Dim mapDataActuel(1280) As Maphandler.Cell
    Dim state As Integer = 0

    Dim voyelles As String = "aeiouy"
    Dim consonnes As String = "bcdfghjklmnpqrstvwxz"

    Dim rand As New Random

    Private Sub SaveZaap(ByVal caseFin As Integer)

        Dim path As String = ""
        Dim pather As New Pathfinding
        If (mapDataActuel(caseFin).movement = 2) Then
            path = pather.pathing(mapDataActuel, caseActuelle, caseFin)
        Else
            path = pather.pathing(mapDataActuel, caseActuelle, caseFin, True)
        End If
        Sock.Envoyer("GA001" & path)
        Sock.Envoyer("GA500214;44")

        If (distance(caseActuelle, caseFin) < 6) Then
            wait(distance(caseActuelle, caseFin) * 300)
        Else
            wait(distance(caseActuelle, caseFin) * 250)
        End If

        Sock.Envoyer("GKK0")
        wait(700)


    End Sub

    Private Function Consonne() As String
        Return consonnes(Rand.Next(0, consonnes.Length - 1))
    End Function

    Private Function Voyelle() As String
        Return voyelles(Rand.Next(0, voyelles.Length - 1))
    End Function

    Private Function AccountName() As String

        Dim theAccount As String = ""

        theAccount &= Consonne().ToUpper & Voyelle()
        For i As Integer = 1 To Rand.Next(3, 5)
            theAccount &= Consonne() & Voyelle()
        Next

        Return theAccount

    End Function

    Private Function AColor() As String

        Dim color1 As Integer = rand.Next(0, 255)
        Dim color2 As Integer = rand.Next(0, 255)
        Dim color3 As Integer = rand.Next(0, 255)

        Return color1.ToString & color2.ToString & color3.ToString

    End Function

    Public Sub CreateSocket()

        ' Démarrage de la connexion au serveur login

        Socket = New ElgSocketClient("213.248.126.180", 443) ' IP login Dofus

        AddHandler Socket.OnReception, AddressOf e_Reception
        AddHandler Socket.OnErreur, AddressOf e_Erreur

    End Sub

    Public Sub CreateSock()

        ' Démarrage de la connexion au serveur de jeu

        Dim ipServeur As String = ip.Replace(" ", "") ' Nettoyage de l'IP
        Sock = New ElgSocketClient(ipServeur, 443)

        AddHandler Sock.OnReception, AddressOf e_Reception
        AddHandler Sock.OnErreur, AddressOf e_Erreur

    End Sub

    Public Sub e_Erreur(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si il y a eu une erreur :

        If (Me.InvokeRequired) Then
            Me.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Erreur), Sender, e)
        Else

            ' Afficher l'erreur
            MessageBox.Show(e.Message, "Socket error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Public Sub e_Reception(ByVal Sender As Object, ByVal e As ElgSocketEventArgs)

        ' Si un recoit quelque chose

        If (e.Message <> "") Then

            If (Mid(e.Message, 1, 4) = "AXEf") Then ' si le serveur est pas plein
            ElseIf (Mid(e.Message, 1, 4) = "AXEd") Then 'si le serveur est pas en maintenance
            ElseIf (Mid(e.Message, 1, 2) = "AX") Then
                ' Fonction de cryptage serveur
                Dim ipCrypt As String = Mid(e.Message, 4, 8)

                Dim i As Long = 0
                Dim fois As Long = 0
                ip = ""
                While (i < 8)
                    i = i + 1
                    fois = fois + 1
                    Dim dat1 As Integer = Asc(Mid(ipCrypt, i, 1)) - 48
                    i = i + 1
                    Dim dat2 As Integer = Asc(Mid(ipCrypt, i, 1)) - 48
                    Dim Dat3 As String = Str(((dat1 And 15) << 4 Or dat2 And 15))
                    If (fois > 1) Then
                        ip = ip + Mid(Dat3, 2)
                    Else
                        ip = ip + Dat3
                    End If
                    If (i < 8) Then
                        ip = ip + "."
                    End If
                End While
            End If
        End If

        If (Me.InvokeRequired) Then
            Me.Invoke(New ElgSocketClient.ElgSocketDelegate(AddressOf e_Reception), Sender, e)
        Else

            If (Mid(e.Message, 1, 2) = "HC") Then

                ' Envoi des identifiants et de la version.
                LabelEtat.Text = "État : Identification"
                Socket.Envoyer(versionJeu)
                Socket.Envoyer(Compte.Text & Chr(10) & PassEnc(Pass.Text, Mid(e.Message, 3)))
                Socket.Envoyer("Af")

            ElseIf (Mid(e.Message, 1, 4) = "AlEf") Then

                ' Erreur de login !
                MsgBox("Mauvais nom de compte ou mot de passe.", MsgBoxStyle.Exclamation, "Recv: AlEf")
                LabelEtat.Text = "État : En attente"

            ElseIf (Mid(e.Message, 1, 4) = "AlEb") Then

                ' Compte banni...
                MsgBox("Compte banni, désolé !", MsgBoxStyle.Exclamation, "Recv: AlEb")
                LabelEtat.Text = "État : En attente"

            ElseIf (Mid(e.Message, 1, 4) = "AlEk") Then

                ' IP bannie...
                MsgBox("Votre IP est bannie pour l'instant.", MsgBoxStyle.Exclamation, "Recv: " & e.Message)
                LabelEtat.Text = "État : En attente"

            ElseIf (Mid(e.Message, 1, 2) = "Ad") Then

                ' Envoi de la demande des serveurs
                Socket.Envoyer("Ax")

            ElseIf (Mid(e.Message, 1, 2) = "Ax") Then

                ' Envoi du serveur
                Socket.Envoyer(ax)

            ElseIf (Mid(e.Message, 1, 4) = "AXEf") Then

                ' Serveur plein, on force !
                Socket.Envoyer("Ax")
                Socket.Envoyer(ax)

            ElseIf (Mid(e.Message, 1, 3) = "AXK") Then

                ' Connection au serveur !
                id = Mid(e.Message, 15)
                CreateSock()

            ElseIf (Mid(e.Message, 1, 3) = "AYK") Then

                ' Connection au serveur !
                Dim hostName As String = Gettok(Mid(e.Message, 4), ";", 1)
                ip = Net.Dns.GetHostEntry(hostName).AddressList(0).ToString
                id = Gettok(e.Message, ";", 2)
                CreateSock()

            ElseIf (Mid(e.Message, 1, 2) = "HG") Then

                ' Envoi de l'id
                Sock.Envoyer("AT" & id)

            ElseIf (Mid(e.Message, 1, 3) = "ATK") Then

                ' Envoi
                Sock.Envoyer("Ak0")
                Sock.Envoyer("AV")

            ElseIf (Mid(e.Message, 1, 2) = "AV") Then

                ' Envoi de la langue
                Sock.Envoyer("Agfr")
                Sock.Envoyer("AL")
                Sock.Envoyer("Af")


            ElseIf (Mid(e.Message, 1, 3) = "ALK") Then

                If (state = 1) Then

                    If (Joinplayer.Checked = False) Then Exit Sub

                    Dim pate As String = Gettok(e.Message, "|", 3)
                    Dim monId As String = Gettok(pate, ";", 1)
                    Sock.Envoyer("AS" & monId)

                    state = 2

                Else
                    LabelEtat.Text = "État : Création"
                    Dim packet As String = "AA"
                    packet &= TextCharacterName.Text & "|" & Gettok(CharacterClass.Text, ":", 1) & "|"
                    If (RadioGenre.Checked) Then
                        packet &= "0" & "|"
                    Else
                        packet &= "1" & "|"
                    End If
                    If (CheckColor.Checked) Then
                        packet &= AColor() & "|" & AColor() & "|" & AColor()
                    Else
                        packet &= "-1|-1|-1"
                    End If

                    Sock.Envoyer(packet)
                End If

            ElseIf (Mid(e.Message, 1, 3) = "AAK") Then

                state = 1
                monNom = TextCharacterName.Text

                If (Joinplayer.Checked = False) Then
                    LabelEtat.Text = "État : Terminé"
                    MsgBox("Personnage crée ! (" & monNom & ")", MsgBoxStyle.Information, "Character Creator")
                End If
                TextCharacterName.Text = AccountName()

            ElseIf (Mid(e.Message, 1, 3) = "AAE") Then

                MsgBox("Personnage non crée ! Nom déjà utilisé ou incorrect.", MsgBoxStyle.Critical, "Character Creator")
                LabelEtat.Text = "État : Erreur"
                TextCharacterName.Text = AccountName()

            ElseIf (Mid(e.Message, 1, 3) = "ASK") Then

                ' Fin de la connexion
                Sock.Envoyer("GC1")
                wait(200)

            ElseIf (Mid(e.Message, 1, 4) = "GM|+") Then

                Dim number As Integer = Gettoks(e.Message, "|")
                Dim actuel, prenom As String

                For i = 2 To number
                    actuel = Gettok(e.Message, "|", i)
                    prenom = Gettok(actuel, ";", 5)
                    If (prenom = monNom) Then
                        caseActuelle = Gettok(actuel, ";", 1)
                        If (state = 3) Then

                            If (SaveToZaap.Checked) Then
                                LabelEtat.Text = "État : Sauvegarde"
                                wait(500)
                                SaveZaap(214)
                            End If
                            If (GoToAstrub.Checked) Then
                                LabelEtat.Text = "État : Descente"
                                wait(500)
                                Sock.Envoyer("DC-1")
                            Else
                                LabelEtat.Text = "État : Terminé"

                                MsgBox("Personnage crée ! (" & monNom & ")", MsgBoxStyle.Information, "Character Creator")

                                state = 4
                            End If

                        End If
                    End If
                Next


                If (state = 2) Then
                    LabelEtat.Text = "État : Rejointe"
                    wait(500)
                    Sock.Envoyer("FJF" & RejoinPlayer.Text)
                    state = 3
                End If

            ElseIf (Mid(e.Message, 1, 3) = "GDM") Then

                Dim idMap As String = Gettok(e.Message, "|", 2)
                Dim indice As String = Gettok(e.Message, "|", 3)
                Dim clef As String = Gettok(e.Message, "|", 4)

                If Not IO.Directory.Exists("maps") Then IO.Directory.CreateDirectory("maps")

                If Not IO.File.Exists("maps/" & idMap & "_" & indice & "X.txt") Then

                    Dim Unpacker As New SwfUnpacker
                    Unpacker.SwfUnpack(idMap & "_" & indice & "X.swf")

                End If

                Try

                    Dim mapReader As New IO.StreamReader("maps/" & idMap & "_" & indice & "X.txt")

                    Dim mapData As String = mapReader.ReadLine

                    mapReader.Close()

                    mapData = Gettok(mapData, "|", 2)

                    Dim preparedKey As String = prepareKey(clef)
                    Dim sData As String = decypherData(mapData, preparedKey, Convert.ToInt64(checksum(preparedKey), 16) * 2)

                    mapDataActuel = uncompressMap(sData)

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Maps.vb --> LoadMap(" & idMap & ")")
                End Try

                Sock.Envoyer("GI")

            ElseIf Mid(e.Message, 1, 2) = "DQ" Then

                Dim extraData As String = Mid(e.Message, 3)
                Dim speakingID As String = Gettok(extraData, "|", 1)
                Dim responseID As String = Gettok(Gettok(extraData, "|", 2), ";", 1)

                wait(500)

                Sock.Envoyer("DR" & speakingID & "|" & responseID)

                LabelEtat.Text = "État : Terminé"

                MsgBox("Personnage crée ! (" & monNom & ")", MsgBoxStyle.Information, "Character Creator")

                state = 4
            End If

        End If


    End Sub

    Private Sub CharacterCreator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If state > 0 Then
            Try
                Sock.Connexion(False)
            Catch
            End Try
        End If
    End Sub


    Private Sub CharacterCreator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextCharacterName.Text = AccountName()

    End Sub


    Private Sub Joinplayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Joinplayer.CheckedChanged
        If (Joinplayer.Checked = False) Then
            SaveToZaap.Checked = False
            SaveToZaap.Enabled = False
            GoToAstrub.Checked = False
            GoToAstrub.Enabled = False
        Else
            SaveToZaap.Enabled = True
            GoToAstrub.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If state > 0 Then
            Try
                Sock.Connexion(False)
            Catch
            End Try
        End If
        ax = "AX" & Gettok(Servers.Text, ":", 1)
        state = 0
        CreateSocket()
    End Sub

    Private Sub GoToAstrub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToAstrub.Click
        If GoToAstrub.Checked = True Then
            SaveToZaap.Enabled = False
            SaveToZaap.Checked = False
        Else
            SaveToZaap.Enabled = True
        End If
    End Sub

    Private Sub SaveToZaap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToZaap.Click
        If SaveToZaap.Checked = True Then
            GoToAstrub.Enabled = False
            GoToAstrub.Checked = False
        Else
            GoToAstrub.Enabled = True
        End If
    End Sub

    Private Sub Servers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Servers.SelectedIndexChanged

    End Sub
End Class
