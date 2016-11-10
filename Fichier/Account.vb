Imports System.IO

Module Account

    Public Function ReturnAccounts()

        Try
            Dim monStreamReader As New StreamReader("data/accounts.txt")
            Dim ligne As String = "a"

            ligne = monStreamReader.ReadLine
            monStreamReader.Close()

            ReturnAccounts = ligne

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> ReturnAccounts()")
            ReturnAccounts = ""
        End Try

    End Function

    Public Sub WriteAccounts(ByVal ligne As String)
        Try
            Dim monStreamWriter As New StreamWriter("data/accounts.txt")

            monStreamWriter.WriteLine(ligne)

            monStreamWriter.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> WriteAccounts(" & ligne & ")")
        End Try
    End Sub

    Public Sub AddAccount(ByVal MyForm As FormAdd)

        Try

            With MyForm

                Dim ligne1 As String = .TextCompte.Text & "|" & .TextPass.Text & _
                    "|" & Gettok(.ListServer.Text, ":", 1) & "|" & .NumPerso.Value.ToString
                Dim ligne2 As String = .TextPassBot.Text & "|" & .TextPassJoin.Text & "|" & .TextPassSuivre.Text
                Dim ligne3 As String = Mid(Gettok(.Sort.Text, "(", 2), 1, Len(Gettok(.Sort.Text, "(", 2)) - 1) & _
                    "|" & .Fois.Text & "|" & Mid(.Cible.Text, 1, 1)

                Dim monStreamWriter As New StreamWriter("saves/" & .TextCompte.Text & ".bot")

                monStreamWriter.WriteLine(ligne1)
                monStreamWriter.WriteLine(ligne2)
                monStreamWriter.WriteLine(ligne3)

                monStreamWriter.Close()

            End With

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> AddAccount()")
        End Try

    End Sub

    Public Sub LoadAccount(ByVal MyForm As FormAdd, ByVal compte As String)

        Try
            Dim monStreamReader As New StreamReader("saves/" & compte & ".bot")

            Dim ligne1 As String = monStreamReader.ReadLine()
            Dim ligne2 As String = monStreamReader.ReadLine()
            Dim ligne3 As String = monStreamReader.ReadLine()

            monStreamReader.Close()

            With MyForm

                .TextCompte.Text = Gettok(ligne1, "|", 1)
                .TextPass.Text = Gettok(ligne1, "|", 2)
                .ListServer.Text = Gettok(ligne1, "|", 3) & ":Serveur"
                .NumPerso.Value = CInt(Gettok(ligne1, "|", 4))

                .TextPassBot.Text = Gettok(ligne2, "|", 1)
                .TextPassJoin.Text = Gettok(ligne2, "|", 2)
                .TextPassSuivre.Text = Gettok(ligne2, "|", 3)

                .Sort.Text = "Sort (" & Gettok(ligne3, "|", 1) & ")"
                .Fois.Value = Gettok(ligne3, "|", 2)
                .Cible.Text = Gettok(ligne3, "|", 3) & " - Cible"

            End With

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> LoadAccount(" & compte & ")")
        End Try


    End Sub

    Public Sub ReadAccount(ByVal compte As String)

        Try

            For i As Integer = 0 To comptes.Count - 1
                If (compte = comptes(i).nomDuCompte) Then
                    Exit Sub
                End If
            Next

            Dim monStreamReader As New StreamReader("saves/" & compte & ".bot")

            Dim ligne1 As String = monStreamReader.ReadLine()
            Dim ligne2 As String = monStreamReader.ReadLine()
            Dim ligne3 As String = monStreamReader.ReadLine()

            monStreamReader.Close()

            comptes.Add(New Perso)

            With comptes(comptes.Count - 1)

                .nomDuCompte = Gettok(ligne1, "|", 1)
                .passDuCompte = Gettok(ligne1, "|", 2)
                .idServeur = Gettok(ligne1, "|", 3)
                .numeroPerso = CInt(Gettok(ligne1, "|", 4))

                .passBot = Gettok(ligne2, "|", 1)
                .passJoin = Gettok(ligne2, "|", 2)
                .passFollow = Gettok(ligne2, "|", 3)

                .idSort = Gettok(ligne3, "|", 1)
                .nombreLance = Gettok(ligne3, "|", 2)
                .Cible = Gettok(ligne3, "|", 3)

                .Initialiser()

            End With

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> ReadAccount(" & compte & ")")
        End Try

    End Sub

    Public Sub DelAccount(ByVal account As String, Optional ByVal modify As Boolean = False)

        Try

            Kill("saves/" & account & ".bot")
            If (modify = False) Then
                If (ReturnAccounts() = account) Then
                    WriteAccounts("")
                Else
                    Dim ligne As String = ""
                    Dim liste As String = ReturnAccounts()
                    For i As Integer = 1 To Gettoks(liste, "|")
                        If (Gettok(liste, "|", i) <> account) Then
                            ligne = ligne & Gettok(liste, "|", i) & "|"
                        End If
                    Next
                    ligne = Mid(ligne, 1, Len(ligne) - 1)
                    WriteAccounts(ligne)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error : Account.vb --> DelAccount()")
        End Try

    End Sub

End Module
