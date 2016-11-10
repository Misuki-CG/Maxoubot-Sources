Module Action

    Private Function isOnMonsterTab(ByVal index As Integer, ByVal id As String) As Boolean
        With comptes(index).TabUtilisateur.ListMonster

            For Each Item As ListViewItem In .Items

                If Item.Text = id Then Return True

            Next

        End With
        Return False
    End Function

    Private Function onMonsterTab(ByVal index As Integer, ByVal id As String) As ListViewItem
        With comptes(index).TabUtilisateur.ListMonster

            For Each Item As ListViewItem In .Items

                If Item.Text = id Then Return Item

            Next

        End With
        Return Nothing
    End Function

    Public Sub PacketGA(ByVal index As Integer, ByVal packet As String)
        With comptes(index)

            If (packet = "GA;0") Then
                If .autoLaunch Then
                    .TabUtilisateur.ListPlayers.Items.Clear()
                    .TabUtilisateur.ListMonster.Items.Clear()
                    .sock.Envoyer("GI")
                End If

            ElseIf (Mid(packet, 1, 5) = "GA;4;") Then
                Dim pate As String = Gettok(packet, ";", 4)
                .caseActuelle = Gettok(pate, ",", 1)

            ElseIf (Mid(packet, 1, 6) = "GA;900") Then
                .sock.Envoyer("GA902" & Gettok(packet, ";", 3))

            ElseIf (Mid(packet, 1, 7) = "GA1;501") Then
                If (Gettok(packet, ";", 3) = .monIdDofus) Then

                    Dim pate As String = Gettok(packet, ";", 4)
                    Dim tempsDeFauche As Integer = CInt(Gettok(pate, ",", 2))

                    .WaitFauche(tempsDeFauche)

                End If

            ElseIf (Mid(packet, 1, 6) = "GA0;1;") Then
                If (.enCombat = 0) Then

                    If (Gettok(packet, ";", 3) = .monIdDofus) Then

                        Dim cherche As String = Gettok(packet, ";", 4)
                        cherche = Mid(cherche, cherche.Length - 1)
                        Dim trouve As Integer = -1

                        For i As Integer = 0 To 1024
                            If (cases(i) = cherche) Then
                                trouve = i
                                i = 1025
                            End If
                        Next

                        If (trouve <> -1) Then
                            .caseActuelle = trouve
                            .Debug("Moving cell " & trouve & " found")
                        End If

                    ElseIf isOnMonsterTab(index, Gettok(packet, ";", 3)) Then

                        Dim item As ListViewItem = onMonsterTab(index, Gettok(packet, ";", 3))

                        Dim cherche As String = Gettok(packet, ";", 4)
                        cherche = Mid(cherche, cherche.Length - 1)
                        Dim trouve As Integer = -1

                        For i As Integer = 0 To 1024
                            If (cases(i) = cherche) Then
                                trouve = i
                                i = 1025
                            End If
                        Next

                        If trouve <> -1 Then item.SubItems(1).Text = trouve.ToString

                    ElseIf (.followChef) Then

                        If (Gettok(packet, ";", 3) = .idChef) Then

                            Dim cherche As String = Gettok(packet, ";", 4)
                            cherche = Mid(cherche, cherche.Length - 1)
                            Dim trouve As Integer = -1

                            For i As Integer = 0 To 1024
                                If (cases(i) = cherche) Then
                                    trouve = i
                                    i = 1025
                                End If
                            Next

                            If (trouve <> -1) Then
                                Dim caseFin As Integer = trouve
                                .SeDeplacer(caseFin)
                            End If

                        End If

                    End If

                End If

            End If

        End With
    End Sub

End Module
