Module Movement

    Public Sub PacketMovement(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            If .enCombat = 0 Then

                Dim extraData As String = Mid(packet, 4)
                Dim datas() As String = extraData.Split("|")
                For i As Integer = 0 To datas.Length - 1

                    If Mid(datas(i), 1, 1) = "+" Then

                        Dim playerData() As String = datas(i).Split(";")

                        Dim typeS As String = playerData(5)
                        Dim type As Integer = 0
                        If typeS.Contains(",") Then
                            type = Split(typeS, ",")(0)
                        Else
                            type = typeS
                        End If

                        If (type > 0) Then

                            Dim cell As Integer = playerData(0)
                            Dim dir As Integer = playerData(1)
                            Dim id As String = playerData(3)
                            Dim nom As String = playerData(4)
                            Dim guilde As String = playerData(16)
                            If guilde = "" Then guilde = "Aucune"

                            Dim aligmentData() As String = playerData(8).Split(",")
                            Dim align As Integer = aligmentData(0)
                            Dim align2 As Integer = aligmentData(1)
                            Dim alignement As String = ""
                            Select Case align
                                Case 0
                                    alignement = "Neutre"
                                Case 1
                                    alignement = "Bontarien"
                                Case 2
                                    alignement = "Brakmarien"
                            End Select
                            If (alignement = "") Then
                                Select Case align2
                                    Case 0
                                        alignement = "Neutre"
                                    Case 1
                                        alignement = "Bontarien"
                                    Case 2
                                        alignement = "Brakmarien"
                                End Select
                            End If

                            If (id = .monIdDofus) Then
                                .caseActuelle = cell
                                .Debug("Basic cell " & cell & " found")
                            End If

                            Dim lvlCrypt As Integer = aligmentData(3)
                            Dim level As String = (lvlCrypt - id).ToString

                            With .TabUtilisateur.ListPlayers

                                .Items.Add(id)
                                .Items(.Items.Count - 1).SubItems.Add(nom)
                                .Items(.Items.Count - 1).SubItems.Add(level)
                                .Items(.Items.Count - 1).SubItems.Add(guilde)
                                .Items(.Items.Count - 1).SubItems.Add(alignement)

                            End With

                        ElseIf type = "-3" Then

                            Dim cell As String = playerData(0)
                            Dim id As String = playerData(3)

                            With .TabUtilisateur.ListMonster

                                .Items.Add(id)
                                .Items(.Items.Count - 1).SubItems.Add(cell)

                            End With

                        End If

                    ElseIf Mid(datas(i), 1, 1) = "-" Then

                        With .TabUtilisateur.ListPlayers

                            Dim id As String = Mid(datas(i), 2)
                            For list As Integer = 0 To .Items.Count - 1
                                If (list >= .Items.Count) Then Exit For
                                If (.Items(list).SubItems.Count = 5) Then
                                    If (.Items(list).SubItems(0).Text = id) Then
                                        .Items.RemoveAt(list)
                                        Exit Sub
                                    End If
                                End If
                            Next

                        End With

                        With .TabUtilisateur.ListMonster

                            Dim id As String = Mid(datas(i), 2)
                            For list As Integer = 0 To .Items.Count - 1
                                If (list >= .Items.Count) Then Exit For
                                If (.Items(list).SubItems.Count = 2) Then
                                    If (.Items(list).SubItems(0).Text = id) Then
                                        .Items.RemoveAt(list)
                                        Exit Sub
                                    End If
                                End If
                            Next

                        End With

                    End If

                Next

            End If

        End With

    End Sub

End Module
