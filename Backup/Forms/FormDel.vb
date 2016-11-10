Public Class FormDel

    Private Sub FormDel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim listeComptes As String = ReturnAccounts()
        Dim i As Integer

        For i = 1 To Gettoks(listeComptes, "|")

            ListeDesComptes.Items.Add(Gettok(listeComptes, "|", i))

        Next

    End Sub

    Private Sub Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del.Click

        If ListeDesComptes.SelectedIndex <> -1 Then
            DelAccount(ListeDesComptes.Items.Item(ListeDesComptes.SelectedIndex))
            ListeDesComptes.Items.Clear()
            FormDel_Load(sender, e)
        End If

    End Sub

End Class