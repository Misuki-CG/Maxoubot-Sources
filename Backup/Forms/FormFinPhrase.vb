Public Class FormFinPhrase

    Private Sub FormFinPhrase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckChiffre.Checked = addChiffre
        CheckLettre.Checked = addLettre
        CheckSmiley.Checked = addSmiley
        CheckSymbol.Checked = addSymbol
    End Sub

    Private Sub Validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        addChiffre = CheckChiffre.Checked
        addLettre = CheckLettre.Checked
        addSmiley = CheckSmiley.Checked
        addSymbol = CheckSymbol.Checked
        WriteSettings()
        Me.Close()
    End Sub

End Class