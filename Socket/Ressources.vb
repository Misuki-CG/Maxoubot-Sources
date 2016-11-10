Module Ressources

    Public Sub PacketRessources(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            packet = Mid(packet, 4)

            For item As Integer = 1 To Gettoks(packet, "|")

                Dim pate As String = Gettok(packet, "|", item)

                For i As Integer = 0 To .TabUtilisateur.ListeRessources.Items.Count - 1
                    If (.TabUtilisateur.ListeRessources.Items(i).SubItems.Count = 3) Then

                        If (.TabUtilisateur.ListeRessources.Items(i).SubItems(1).Text = Gettok(pate, ";", 1)) Then
                            If (Gettok(pate, ";", 3) = "1") Then
                                .TabUtilisateur.ListeRessources.Items(i).SubItems(2).Text = "Non coupé"
                            ElseIf (Gettok(pate, ";", 3) = "0") Then
                                .TabUtilisateur.ListeRessources.Items(i).SubItems(2).Text = "Coupé"
                            End If
                        End If

                    End If
                Next

            Next

        End With

    End Sub

End Module
