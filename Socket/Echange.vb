Module Echange

    Public Delegate Sub PacketDelegate(ByVal index As Integer, ByVal packet As String)

    Public Sub PacketEchange(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                Form.Invoke(New PacketDelegate(AddressOf PacketEchange), index, packet)
            Else

                If (Mid(packet, 1, 3) = "ERK") Then
                    Dim Premz As Integer = packet.IndexOf(Chr(124))
                    Dim Dat1 As Integer = Premz - 3
                    Dim idMec As String = Mid(packet, 4, Dat1)
                    If (idMec = .idChef) Or (idMec = .idMaitre) Then
                        .sock.Envoyer("EA")
                    ElseIf (.TabUtilisateur.Echange.Checked = True) Then
                        .sock.Envoyer("EA")
                        For i As Integer = 1 To 250
                            .objetsQuantite(i) = 0
                            .objetsID(i) = Nothing
                            .objetsIdType(i) = Nothing
                        Next
                    Else
                        .sock.Envoyer("EV")
                    End If

                ElseIf (Mid(packet, 1, 5) = "EmKO+") Then
                    If (.TabUtilisateur.Echange.Checked = True) Then
                        Dim message As String = Mid(packet, 6)
                        Dim EchangeId As String = Gettok(message, "|", 1)
                        Dim quantite As Integer = Gettok(message, "|", 2)
                        Dim idObjet As String = Gettok(message, "|", 3)
                        Dim iEchange As Integer
                        .idEchange = EchangeId
                        For iEchange = 1 To 250
                            If (.objetsID(iEchange) = EchangeId) Then
                                .objetsQuantite(iEchange) = quantite
                                .objetsIdType(iEchange) = idObjet
                                Exit For
                            End If
                        Next
                        If (.objetsQuantite(iEchange) <> quantite) Then
                            For iEchange = 1 To 250
                                If (.objetsID(iEchange) = 0) Then
                                    .objetsID(iEchange) = EchangeId
                                    .objetsIdType(iEchange) = idObjet
                                    .objetsQuantite(iEchange) = quantite
                                    Exit For
                                End If
                            Next
                        End If
                        Dim prix As Integer
                        .nombreE = 0
                        For iEchange = 1 To 250
                            If (.TabUtilisateur.ListeObjets.FindString(.objetsIdType(iEchange)) > -1) Then
                                Dim prixTotalObjet, prixUnitaire As Integer
                                prixUnitaire = CInt(.TabUtilisateur.ListePrix.Items.Item(.TabUtilisateur.ListeObjets.FindString(.objetsIdType(iEchange))))
                                prixTotalObjet = .objetsQuantite(iEchange) * prixUnitaire
                                prix = prix + prixTotalObjet
                                .nombreE += .objetsQuantite(iEchange)
                            End If
                        Next
                        wait(1000)
                        .sock.Envoyer("EMG" & prix)
                        prix = 0
                    End If

                ElseIf (Mid(packet, 1, 5) = "EmKO-") Then
                    If (.TabUtilisateur.Echange.Checked = True) Then
                        .sock.Envoyer("EV")
                    End If

                ElseIf (Mid(packet, 1, 2) = "EK") Then
                    If (.TabUtilisateur.Echange.Checked = True) Then
                        wait(1000)
                        .sock.Envoyer("EK")
                        Dim actuel As Integer = CInt(.TabUtilisateur.NumAchat.Text)
                        actuel = actuel + .nombreE
                        .TabUtilisateur.NumAchat.Text = Str(actuel)
                        .enEchange = 0
                    End If

                ElseIf (Mid(packet, 1, 4) = "ECK1") Then
                    .enEchange = 1
                    If (.TabUtilisateur.Echange.Checked = False) Then
                        wait(1000)
                        .sock.Envoyer("EMG" & .TabUtilisateur.Kamas.Text)
                        wait(2000)
                        .sock.Envoyer("EK")
                    End If
                    For i As Integer = 1 To 250
                        .objetsQuantite(i) = 0
                        .objetsID(i) = Nothing
                    Next

                ElseIf (Mid(packet, 1, 2) = "EV") Then
                    .enEchange = 0
                End If

            End If

        End With

    End Sub

End Module
