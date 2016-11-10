Module Inventaire

    Public Sub PacketInventaire(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            If (Mid(packet, 1, 2) = "Ow") Then
                Dim bloc As String = Mid(packet, 3)
                Dim actuel As Integer = Gettok(bloc, "|", 1)
                Dim max As Integer = Gettok(bloc, "|", 2)
                If (actuel >= max) Then
                    .TabUtilisateur.ChatBox.AppendText("<BOT> Personnage full pods !" & vbCrLf)
                    actuel = max
                End If
                If DisconnectWhenFull Then
                    If (actuel >= max - 5) Then
                        .autoReconnect = False
                        .sock.Connexion(False)
                        .TabUtilisateur.ChatBox.AppendText("<BOT> Déconnexion (full pods)" & vbCrLf)
                    End If
                End If
                .TabUtilisateur.Pods.Maximum = max
                .TabUtilisateur.Pods.Value = actuel
                .TabUtilisateur.Pods.ToolTipText = actuel.ToString & "/" & max.ToString

            ElseIf (Mid(packet, 1, 4) = "OAKO") Then
                PacketObjets2(index, packet)

            ElseIf (Mid(packet, 1, 2) = "OQ") Then
                For i As Integer = 0 To .TabUtilisateur.ListeInventaire.Items.Count - 1
                    If (.TabUtilisateur.ListeInventaire.Items(i).SubItems.Count = 4) Then
                        If (.TabUtilisateur.ListeInventaire.Items(i).SubItems(3).Text = Gettok(Mid(packet, 3), "|", 1)) Then
                            .TabUtilisateur.ListeInventaire.Items(i).SubItems(2).Text = Gettok(packet, "|", 2)
                            If (.TabUtilisateur.DétruireObjetAutomatiquementToolStripMenuItem.Checked = True) Then
                                If (CInt(Gettok(packet, "|", 2)) > 9) Then
                                    .sock.Envoyer("Od" & Gettok(Mid(packet, 3), "|", 1) & "|" & Gettok(packet, "|", 2))
                                End If
                            End If
                        End If
                    End If
                Next

            ElseIf (Mid(packet, 1, 2) = "OR") Then
                For i As Integer = 0 To .TabUtilisateur.ListeInventaire.Items.Count - 1
                    If (.TabUtilisateur.ListeInventaire.Items(i).SubItems.Count = 4) Then
                        If (.TabUtilisateur.ListeInventaire.Items(i).SubItems(3).Text = Mid(packet, 3)) Then
                            .TabUtilisateur.ListeInventaire.Items.Remove(.TabUtilisateur.ListeInventaire.Items(i))
                            Exit For
                        End If
                    End If
                Next
            End If

        End With

    End Sub

End Module
