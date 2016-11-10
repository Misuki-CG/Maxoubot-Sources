Public Class FormIA

    Private Sub FormIA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (ChangerDeMap) Then
            ChangeMap.Checked = True
        End If
        If (BloqueSpectateur) Then
            Spectateur.Checked = True
        End If
        If (BloqueGroupe) Then
            BGroupe.Checked = True
        End If
        If (DisconnectWhenFull) Then
            AutoDeco.Checked = True
        End If
        NombreCombat.Value = AuBoutDeCombats

    End Sub

    Private Sub ValidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidButton.Click

        ChangerDeMap = ChangeMap.Checked
        BloqueSpectateur = Spectateur.Checked
        BloqueGroupe = BGroupe.Checked
        AuBoutDeCombats = NombreCombat.Value
        DisconnectWhenFull = AutoDeco.Checked

        WriteSettings()
        Me.Close()

    End Sub

End Class