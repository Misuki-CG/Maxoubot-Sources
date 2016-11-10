Public Class FormModify

    Private Sub FormModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim listeComptes As String = ReturnAccounts()
        Dim i As Integer

        For i = 1 To Gettoks(listeComptes, "|")

            ListeDesComptes.Items.Add(Gettok(listeComptes, "|", i))

        Next

    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charger.Click

        If ListeDesComptes.SelectedIndex <> -1 Then
            Dim frm As New FormAdd
            frm.Show()
            frm.Initialiser(ListeDesComptes.Items.Item(ListeDesComptes.SelectedIndex))
            Me.Close()
        End If

    End Sub

End Class