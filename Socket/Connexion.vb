Module Connexion

    Public Sub PacketConnexion(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                Form.Invoke(New PacketDelegate(AddressOf PacketConnexion), index, packet)
            Else

                If (Mid(packet, 1, 2) = "HC") Then

                    ' Envoi des identifiants et de la version.
                    .socket.Envoyer(versionJeu)
                    .socket.Envoyer(.nomDuCompte & Chr(10) & PassEnc(.passDuCompte, Mid(packet, 3)))
                    .socket.Envoyer("Af")

                ElseIf (Mid(packet, 1, 4) = "AlEf") Then

                    ' Erreur de login !
                    .TabUtilisateur.ChatBox.AppendText("<BOT> Mauvais nom de compte ou mot de passe." & vbCrLf)

                ElseIf (Mid(packet, 1, 4) = "AlEb") Then

                    ' Compte banni...
                    .TabUtilisateur.ChatBox.AppendText("<BOT> Compte banni, désolé !" & vbCrLf)

                ElseIf (Mid(packet, 1, 4) = "AlEk") Then

                    ' IP bannie...
                    .TabUtilisateur.ChatBox.AppendText("<BOT> IP/Compte banni temporairement !" & vbCrLf)

                ElseIf (Mid(packet, 1, 4) = "AlEv") Then

                    ' Mauvaise version
                    FormConfig.Close()
                    Dim version As String = Mid(packet, 5)
                    versionJeu = Mid(packet, 5)
                    FormConfig.Show()
                    FormConfig.ValidConfig()
                    .TabUtilisateur.ChatBox.AppendText("<BOT> Mauvaise version du jeu ! " & version & " configurée !" & vbCrLf)
                    .CreateSocket()
                    .TabUtilisateur.ChatBox.AppendText("<BOT> Reconnexion..." & vbCrLf)

                ElseIf (Mid(packet, 1, 2) = "Ax") Then

                    ' Envoi du serveur
                    .socket.Envoyer("AX" & .idServeur)

                ElseIf (Mid(packet, 1, 2) = "AH") Then

                    ' Refresh la demande des serveurs
                    .socket.Envoyer("Ax")

                ElseIf (Mid(packet, 1, 4) = "AXEf") Then

                    .TabUtilisateur.ChatBox.AppendText("<BOT> Serveur complet ! Nouvel essai !" & vbCrLf)
                    ' Serveur plein, on force doucement !
                    wait(2500)
                    .socket.Envoyer("AX" & .idServeur)

                ElseIf (Mid(packet, 1, 4) = "AXEd") Then

                    .TabUtilisateur.ChatBox.AppendText("<BOT> Serveur en sauvegarde !" & vbCrLf)

                ElseIf (Mid(packet, 1, 3) = "AXK") Then

                    ' Connection au serveur !
                    .idConnexion = Mid(packet, 15)
                    .CreateSock()

                ElseIf (Mid(packet, 1, 3) = "AYK") Then

                    ' Connection au serveur !
                    Dim hostName As String = Gettok(Mid(packet, 4), ";", 1)
                    .ipServeurJeu = Net.Dns.GetHostEntry(hostName).AddressList(0).ToString
                    .idConnexion = Gettok(packet, ";", 2)
                    .CreateSock()

                ElseIf (Mid(packet, 1, 2) = "HG") Then

                        ' Envoi de l'id
                        .sock.Envoyer("AT" & .idConnexion)

                ElseIf (Mid(packet, 1, 3) = "ATK") Then

                        ' Envoi
                        .sock.Envoyer("Ak0")
                        .sock.Envoyer("AV")

                ElseIf (Mid(packet, 1, 2) = "AV") Then

                    ' Envoi de la langue
                    If (.idServeur = 6002) Then
                        .sock.Envoyer("Agen")
                    Else
                        .sock.Envoyer("Agfr")
                    End If
                    .sock.Envoyer("AL")
                    .sock.Envoyer("Af")


                ElseIf (Mid(packet, 1, 3) = "ALK") Then

                    ' Connexion au personnage

                    Dim pate As String = Gettok(packet, "|", 2 + .numeroPerso)
                    Dim monId As String = Gettok(pate, ";", 1)
                    .monIdDofus = monId
                    .sock.Envoyer("AS" & monId)

                ElseIf (Mid(packet, 1, 3) = "ASK") Then

                    ' Fin de la connexion
                    .connexionTermine = 1
                    .sock.Envoyer("GC1") ' Info Perso

                    End If

                End If

        End With

    End Sub

End Module
