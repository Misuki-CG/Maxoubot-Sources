Module Combat

    Public Sub PacketCombat(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            If (Mid(packet, 1, 2) = "GP") Then
                .enCombat = 1
                .TabUtilisateur.ListPlayers.Items.Clear()
                .SendGo()

            ElseIf (Mid(packet, 1, 3) = "Gc+") Then

                If ((.joinChef) Or (.joinAll)) Then
                    Dim idCombat As String = Mid(packet, 4)
                    idCombat = Gettok(idCombat, ";", 1)
                    If ((idCombat = .idChef) Or (.joinAll)) Then
                        .JoinCombat(idCombat)
                    End If

                End If

            ElseIf (Mid(packet, 1, 4) = "GTM|") Then

                Dim i As Integer

                For i = 2 To Gettoks(packet, "|")
                    Dim Groupe As String = Gettok(packet, "|", i)
                    Dim estMort As String = Gettok(Groupe, ";", 2)
                    If (estMort = "0") Then

                        Dim afrappe As String = Gettok(Groupe, ";", 6)
                        Dim idMob As String = Gettok(Groupe, ";", 1)

                        If (IsNumeric(idMob)) Then
                            Dim idMobInt As Integer = idMob
                            If (IsNumeric(afrappe)) Then
                                If (idMob = .monIdDofus) Then
                                    .toMe = afrappe
                                End If
                            End If
                        End If

                    End If
                Next

                Dim meilleurDistance As Integer = 999
                Dim meilleurDistanceHeal As Integer = 999

                For i = 2 To Gettoks(packet, "|")
                    Dim Groupe As String = Gettok(packet, "|", i)
                    Dim estMort As String = Gettok(Groupe, ";", 2)

                    If (estMort = "0") Then

                        Dim afrappe As String = Gettok(Groupe, ";", 6)
                        Dim idMob As String = Gettok(Groupe, ";", 1)

                        If (IsNumeric(idMob)) Then
                            Dim idMobInt As Integer = idMob

                            If (IsNumeric(afrappe)) Then

                                If (idMobInt < 0) Then
                                    If (goalDistance(.toMe, afrappe) < meilleurDistance) Then
                                        .toFrappe = afrappe
                                        meilleurDistance = goalDistance(.toMe, afrappe)
                                    End If

                                ElseIf (idMobInt > 0) And idMob <> .monIdDofus Then
                                    If (goalDistance(.toMe, afrappe) < meilleurDistanceHeal) Then
                                        .toHeal = afrappe
                                        meilleurDistanceHeal = goalDistance(.toMe, afrappe)
                                    End If
                                End If
                            End If

                        End If

                    End If
                Next

            ElseIf (Mid(packet, 1, 3) = "GTR") Then
                .sock.Envoyer("GT")

            ElseIf (Mid(packet, 1, 3) = "GTS") Then
                Dim lID As String = Mid(Gettok(packet, "|", 1), 4)
                If (lID = .monIdDofus) Then
                    If (.idSort <> 0) Then

                        If (.Cible = 1) Then
                            .caseDeLance = .toFrappe
                        ElseIf (.Cible = 2) Then
                            .caseDeLance = .toHeal
                        ElseIf (.Cible = 3) Then
                            .caseDeLance = .toMe
                        End If

                        Dim maxAvance As Integer = 1

                        If (sortsMin(.idSort) <> -1) Then
                            maxAvance = sortsMin(.idSort)
                        End If

                        If (goalDistance(.toMe, .caseDeLance) > maxAvance) Then
                            Dim pather As New Pathfinding
                            Dim path As String = pather.pathing(.mapDataActuel, .toMe, .caseDeLance, False, True, 3)
                            .sock.Envoyer("GA001" & path)
                            .sock.Envoyer("GKK0")
                        End If

                        If (sortsMax(.idSort) <> -1) Then
                            Dim distNeed As Integer = sortsMax(.idSort) + 1
                            If goalDistance(.toMe, .caseDeLance) <= distNeed Then
                                For i As Integer = 1 To .nombreLance
                                    .sock.Envoyer("GA300" & .idSort & ";" & .caseDeLance)
                                    .sock.Envoyer("GKK0")
                                Next
                            End If
                        Else
                            For i As Integer = 1 To .nombreLance
                                .sock.Envoyer("GA300" & .idSort & ";" & .caseDeLance)
                                .sock.Envoyer("GKK0")
                            Next
                        End If

                    End If

                    .sock.Envoyer("Gt")

                End If
                .sock.Envoyer("GT")

            ElseIf (Mid(packet, 1, 3) = "GAF") Then
                Dim lowlPacket As String = Mid(packet, 4)
                .sock.Envoyer("GKK" & Gettok(lowlPacket, "|", 1))

            ElseIf (Mid(packet, 1, 2) = "GE") Then
                .nombreDeCombat += 1
                If ((.nombreDeCombat >= AuBoutDeCombats) AndAlso (ChangerDeMap)) Then
                    .changeDeMap = 1
                End If
                .TimerLaunch.Enabled = False
                .enCombat = 0
                .sock.Envoyer("GC1")
                wait(500)
                If (.autoLaunch) Then
                    Dim Quota As Integer = .TabUtilisateur.Vie.Maximum / 2
                    Dim Vie As Integer = .TabUtilisateur.Vie.Value
                    If (Vie < Quota) Then
                        .sock.Envoyer("eU1")
                        .Regenerate(Quota * 1000)
                    End If
                    If ((.nombreDeCombat >= AuBoutDeCombats) And (ChangerDeMap) And .enRegen = 0) Then
                        .ChangerMap()
                    End If
                End If
                .TimerLaunch.Enabled = True

            ElseIf (Mid(packet, 1, 3) = "GV") Then
                .enCombat = 0
                .sock.Envoyer("GC1")

            End If

        End With

    End Sub

End Module
