Module Chat

    Public Function AsciiDecoder(ByVal msg As String)

        Dim msgFinal As String = ""

        Dim iMax As Integer = msg.Length
        Dim i As Integer = 0

        While (i < iMax)

            Dim caractC As Char = msg(i)
            Dim caractI As Integer = Asc(caractC)
            Dim nbLettreCode As Integer = 1

            If (caractI And 128) = 0 Then

                msgFinal &= ChrW(caractI)

            Else

                Dim temp As Integer = 64
                Dim codecPremLettre As Integer = 63

                While (caractI And temp)

                    temp >>= 1
                    codecPremLettre = codecPremLettre Xor temp
                    nbLettreCode += 1

                End While

                codecPremLettre = codecPremLettre And 255

                Dim caractIFinal As Integer = caractI And codecPremLettre

                nbLettreCode -= 1
                i += 1

                While (nbLettreCode <> 0)

                    caractC = msg(i)
                    caractI = Asc(caractC)

                    caractIFinal <<= 6
                    caractIFinal = caractIFinal Or (caractI And 63)

                    nbLettreCode -= 1
                    i += 1

                End While

                msgFinal &= ChrW(caractIFinal)

            End If

            i += nbLettreCode

        End While

        Return msgFinal

    End Function

    Public Sub PacketChat(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            Dim idDuMec As String = Gettok(packet, "|", 2)
            Dim nomDuMec As String = Gettok(packet, "|", 3)
            Dim recu As String = Gettok(packet, "|", 4)

            recu = AsciiDecoder(recu)

            If (Mid(packet, 1, 4) = "cMK|") Then
                .TabUtilisateur.ChatBox.AppendText("[Général] " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMK$") Then
                .TabUtilisateur.ChatBox.AppendText("[Groupe] " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMKF") Then
                .TabUtilisateur.ChatBox.AppendText("[Privé] de " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMK%") Then
                .TabUtilisateur.ChatBox.AppendText("[Guilde] " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMK?") Then
                .TabUtilisateur.ChatBox.AppendText("[Commerce] " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMK:") Then
                .TabUtilisateur.ChatBox.AppendText("[Recrutement] " & nomDuMec & " : " & recu & vbCrLf)
            ElseIf (Mid(packet, 1, 4) = "cMKT") Then
                .TabUtilisateur.ChatBox.AppendText("[Privé] à " & nomDuMec & " : " & recu & vbCrLf)
            End If

            .TabUtilisateur.ChatBox.ScrollToCaret()

            If InStr(recu, .passBot, CompareMethod.Text) Then
                wait(2000)
                .sock.Envoyer("BM" & nomDuMec & "|" & "Bonjour " & nomDuMec & " (" & idDuMec & "), vous êtes mon chef." & "|")
                .idChef = idDuMec
                .nomChef = nomDuMec
                .TabUtilisateur.TextChef.Text = "Chef: " & nomDuMec
            End If

            If ((idDuMec = .idChef) AndAlso (.monIdDofus <> idDuMec)) Then

                If InStr(recu, .passJoin, CompareMethod.Text) Then
                    wait(1000)
                    If Not .joinChef Then
                        .sock.Envoyer("BM" & nomDuMec & "|" & "Bien " & nomDuMec & ", je rejoindrais tes combats." & "|")
                        .joinChef = True
                    Else
                        .sock.Envoyer("BM" & nomDuMec & "|" & "Soit, je ne rejoindrais plus tes combats.|")
                        .joinChef = False
                    End If

                ElseIf InStr(recu, .passFollow, CompareMethod.Text) Then
                    wait(1000)
                    If Not .followChef Then
                        .sock.Envoyer("BM" & nomDuMec & "|" & "Bien " & nomDuMec & ", je te suis." & "|")
                        .followChef = True
                    Else
                        .sock.Envoyer("BM" & nomDuMec & "|" & "Soit, je ne te suis plus.|")
                        .followChef = False
                    End If

                ElseIf InStr(recu, ".go", CompareMethod.Text) Then
                    If (Gettoks(recu, " ") >= 2) Then
                        Dim toGo As String = Gettok(recu, " ", 2)
                        If (IsNumeric(toGo)) Then
                            .SeDeplacer(CInt(toGo))
                            .nombreDeCombat = 0
                        End If
                    End If

                ElseIf Mid(recu, 1, 4) = ".say" Then
                    .sock.Envoyer("BM*|" & Mid(recu, 6))

                ElseIf Mid(recu, 1, 7) = ".smiley" Then
                    .sock.Envoyer("BS" & Mid(recu, 9))

                ElseIf Mid(recu, 1, 4) = ".sit" Then
                    .sock.Envoyer("eU1")

                ElseIf Mid(recu, 1, 4) = ".dir" Then
                    .sock.Envoyer("eD" & Mid(recu, 6))

                ElseIf Mid(recu, 1, 7) = ".gauche" Then
                    If Gettoks(recu, " ") = 1 Then recu &= " 1"
                    .SeDeplacer(.caseActuelle + 14 * CInt(Gettok(recu, " ", 2)))

                ElseIf Mid(recu, 1, 5) = ".haut" Then
                    If Gettoks(recu, " ") = 1 Then recu &= " 1"
                    .SeDeplacer(.caseActuelle - 15 * CInt(Gettok(recu, " ", 2)))

                ElseIf Mid(recu, 1, 4) = ".bas" Then
                    If Gettoks(recu, " ") = 1 Then recu &= " 1"
                    .SeDeplacer(.caseActuelle + 15 * CInt(Gettok(recu, " ", 2)))

                ElseIf Mid(recu, 1, 7) = ".droite" Then
                    If Gettoks(recu, " ") = 1 Then recu &= " 1"
                    .SeDeplacer(.caseActuelle - 14 * CInt(Gettok(recu, " ", 2)))

                ElseIf Mid(recu, 1, 4) = ".msg" Then
                    Dim message As String = ""
                    For i As Integer = 3 To Gettoks(recu, " ")
                        message &= Gettok(recu, " ", i) & " "
                    Next
                    .sock.Envoyer("BM" & Gettok(recu, " ", 2) & "|" & message)

                End If

            End If

        End With

    End Sub

End Module
