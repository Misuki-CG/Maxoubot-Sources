Public Class FormAdd

    Dim compteModed As String

    Private Sub Creer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Creer.Click
        If (compteModed = "") Then
            Dim liste As String = ReturnAccounts()
            If (liste = "") Then
                liste = TextCompte.Text
            Else
                liste = liste & "|" & TextCompte.Text
            End If
            WriteAccounts(liste)
        Else
            DelAccount(compteModed, True)
        End If
        AddAccount(Me)
        Me.Close()
    End Sub

    Public Sub Initialiser(ByVal compte As String)
        TextCompte.ReadOnly = True
        Me.Text = "Modificar uma conta"
        Creer.Text = "Modificada"
        compteModed = compte
        LoadAccount(Me, compte)
    End Sub

    Private Sub FormAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        compteModed = ""
        LoadServer(Me)
        LoadSpell(Me)
    End Sub

    Private Sub Sort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sort.SelectedIndexChanged

    End Sub
End Class