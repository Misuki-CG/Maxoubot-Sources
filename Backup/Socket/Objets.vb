Module Objets

    Public Sub PacketObjets(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            .TabUtilisateur.ListeInventaire.Items.Clear()

            Dim objets As String = Gettok(packet, "|", 11)

            For i As Integer = 1 To Gettoks(objets, ";") - 1

                Dim pate As String = Gettok(objets, ";", i)

                Dim idObjet As String = Convert.ToInt64(Gettok(pate, "~", 2), 16)
                Dim nomObjet As String = listeDesObjets(idObjet)
                If (nomObjet = "") Then nomObjet = "Inconnu"
                Dim idObjetInv As String = Convert.ToInt64(Gettok(pate, "~", 1), 16)
                Dim numObjet As String = Convert.ToInt64(Gettok(pate, "~", 3), 16)

                .TabUtilisateur.ListeInventaire.Items.Add(idObjet)
                .TabUtilisateur.ListeInventaire.Items(i - 1).SubItems.Add(nomObjet)
                .TabUtilisateur.ListeInventaire.Items(i - 1).SubItems.Add(numObjet)
                .TabUtilisateur.ListeInventaire.Items(i - 1).SubItems.Add(idObjetInv)

            Next

        End With

    End Sub

    Public Sub PacketObjets2(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            Dim objets As String = Mid(packet, 5)

            For i As Integer = 1 To Gettoks(objets, ";") - 1

                Dim pate As String = Gettok(objets, ";", i)

                Dim idObjet As String = Convert.ToInt64(Gettok(pate, "~", 2), 16)
                Dim nomObjet As String = listeDesObjets(idObjet)
                If (nomObjet = "") Then nomObjet = "Inconnu"
                Dim idObjetInv As String = Convert.ToInt64(Gettok(pate, "~", 1), 16)
                Dim numObjet As String = Convert.ToInt64(Gettok(pate, "~", 3), 16)

                .TabUtilisateur.ListeInventaire.Items.Add(idObjet)
                .TabUtilisateur.ListeInventaire.Items(.TabUtilisateur.ListeInventaire.Items.Count - 1).SubItems.Add(nomObjet)
                .TabUtilisateur.ListeInventaire.Items(.TabUtilisateur.ListeInventaire.Items.Count - 1).SubItems.Add(numObjet)
                .TabUtilisateur.ListeInventaire.Items(.TabUtilisateur.ListeInventaire.Items.Count - 1).SubItems.Add(idObjetInv)

            Next

        End With

    End Sub

End Module
