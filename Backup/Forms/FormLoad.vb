Public Class FormLoad

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charger.Click

        If ListeDesComptes.SelectedIndex <> -1 Then
            ReadAccount(ListeDesComptes.Items.Item(ListeDesComptes.SelectedIndex))
            For i As Integer = 0 To comptes.Count - 1
                comptes(i).TabUtilisateur.SetBounds(0, 0, Form.Tab.Width, Form.Tab.Height - 30)
            Next
            Form.Tab.SelectedTab = Form.Tab.TabPages.Item(comptes.Count - 1)
            Me.Close()
        End If

    End Sub

    Private Sub FormLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim listeComptes As String = ReturnAccounts()
        Dim i As Integer

        For i = 1 To Gettoks(listeComptes, "|")

            ListeDesComptes.Items.Add(Gettok(listeComptes, "|", i))

        Next

    End Sub

    Public Sub LoadAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadAll.Click

        For compte As Integer = 0 To ListeDesComptes.Items.Count - 1

            ReadAccount(ListeDesComptes.Items.Item(compte))
            For i As Integer = 0 To comptes.Count - 1
                comptes(i).TabUtilisateur.SetBounds(0, 0, Form.Tab.Width, Form.Tab.Height - 30)
            Next

        Next
        Form.Tab.SelectedTab = Form.Tab.TabPages.Item(comptes.Count - 1)
        Me.Close()

    End Sub

End Class