Module MobPlus

    Public Sub PacketAddMob(ByVal index As Integer, ByVal packet As String)
        With comptes(index)

            If (.enCombat = 0) Then
                Dim number As Integer = Gettoks(packet, "|")
                Dim actuel As String

                If .TabUtilisateur.MPFlooder.Checked Then
                    For i = 2 To number
                        actuel = Gettok(packet, "|", i)
                        Dim lasuperid As Integer = Gettok(actuel, ";", 4)
                        Dim lesupernom As String = Gettok(actuel, ";", 5)
                        Dim pate As String = Gettok(actuel, ";", 9)
                        Dim lvlCrypt As Integer = Gettok(pate, ",", 4)
                        Dim level As String = (lvlCrypt - lasuperid).ToString

                        Dim aligmentData() As String = pate.Split(",")
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

                        If lasuperid > 0 And Not lesupernom.Contains("[") Then

                            Dim listOfFlood As New List(Of ListViewItem)

                            For Each item As ListViewItem In .TabUtilisateur.ListFloodMP.Items

                                If Not IsNumeric(item.SubItems(1).Text) Then Exit For
                                If Not IsNumeric(item.SubItems(2).Text) Then Exit For

                                Dim lvlMin As Integer = item.SubItems(1).Text
                                Dim lvlMax As Integer = item.SubItems(2).Text
                                Dim lvl As Integer = level

                                If lvl >= lvlMin And lvl <= lvlMax Then

                                    listOfFlood.Add(item)

                                End If

                            Next

                            If listOfFlood.Count > 0 Then

                                Dim Rand As New Random

                                Dim theMessage As String = listOfFlood(Rand.Next(0, listOfFlood.Count - 1)).Text.Replace("%level%", level).Replace("%alignement%", alignement).Replace("%nom%", lesupernom)

                                If addChiffre Or addLettre Or addSymbol Then
                                    theMessage &= " ["
                                    theMessage &= RandomKey(addLettre, addChiffre, addSymbol)
                                    theMessage &= "]"
                                End If

                                If addSmiley Then theMessage &= " " & Smiley()

                                Dim nombre As Integer = CInt(.TabUtilisateur.NumFloodMP.Text)
                                nombre += 1
                                .TabUtilisateur.NumFloodMP.Text = nombre

                                If .TabUtilisateur.CheckLiaisonFlood.Enabled Then
                                    Dim mpThread As New Threading.Thread(AddressOf comptes(.TabUtilisateur.NumericLiaison.Value - 1).SendMp)
                                    mpThread.Name = lesupernom & "|" & theMessage
                                    mpThread.Start()
                                Else
                                    Dim mpThread As New Threading.Thread(AddressOf .SendMp)
                                    mpThread.Name = lesupernom & "|" & theMessage
                                    mpThread.Start()
                                End If

                            End If

                        End If
                    Next
                End If

            End If

        End With
    End Sub

End Module
