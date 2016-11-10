Module InfoPerso

    Public Sub PacketAs(ByVal index As Integer, ByVal packet As String)

        With comptes(index)

            .TabUtilisateur.Kamas.Text = Gettok(packet, "|", 2)
            .TabUtilisateur.Comp.Text = Gettok(packet, "|", 3)
            .TabUtilisateur.CompSpell.Text = Gettok(packet, "|", 4)

            Dim groupeVie As String = Gettok(packet, "|", 6)
            .TabUtilisateur.Vie.Maximum = Gettok(groupeVie, ",", 2)
            .TabUtilisateur.Vie.Value = Gettok(groupeVie, ",", 1)
            .TabUtilisateur.Vie.ToolTipText = Gettok(groupeVie, ",", 1) & "/" & Gettok(groupeVie, ",", 2)

            Dim groupeExp As String = Gettok(packet, "|", 1)
            groupeExp = Mid(groupeExp, 3)
            .TabUtilisateur.Exp.Maximum = Gettok(groupeExp, ",", 3)
            .TabUtilisateur.Exp.Minimum = Gettok(groupeExp, ",", 2)
            .TabUtilisateur.Exp.Value = Gettok(groupeExp, ",", 1)
            .TabUtilisateur.Exp.ToolTipText = Gettok(groupeExp, ",", 1) & "/" & Gettok(groupeExp, ",", 3)

            Dim groupeStatTerre As String = Gettok(packet, "|", 12)
            .TabUtilisateur.StatTerre.Text = Gettok(groupeStatTerre, ",", 1) & "(+" & Gettok(groupeStatTerre, ",", 2) & ")"

            Dim groupeStatVie As String = Gettok(packet, "|", 13)
            .TabUtilisateur.StatVie.Text = Gettok(groupeStatVie, ",", 1) & "(+" & Gettok(groupeStatVie, ",", 2) & ")"

            Dim groupeStatSag As String = Gettok(packet, "|", 14)
            .TabUtilisateur.StatSag.Text = Gettok(groupeStatSag, ",", 1) & "(+" & Gettok(groupeStatSag, ",", 2) & ")"

            Dim groupeStatEau As String = Gettok(packet, "|", 15)
            .TabUtilisateur.StatEau.Text = Gettok(groupeStatEau, ",", 1) & "(+" & Gettok(groupeStatEau, ",", 2) & ")"

            Dim groupeStatAir As String = Gettok(packet, "|", 16)
            .TabUtilisateur.StatAir.Text = Gettok(groupeStatAir, ",", 1) & "(+" & Gettok(groupeStatAir, ",", 2) & ")"

            Dim groupeStatFeu As String = Gettok(packet, "|", 17)
            .TabUtilisateur.StatFeu.Text = Gettok(groupeStatFeu, ",", 1) & "(+" & Gettok(groupeStatFeu, ",", 2) & ")"

            .sock.Envoyer("BD")

        End With

    End Sub

End Module
