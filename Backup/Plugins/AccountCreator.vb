Public Class AccountCreator

    Dim voyelles As String = "aeiouy"
    Dim consonnes As String = "bcdfghjklmnpqrstvwxz"

    Dim lastAccount As String = ""
    Dim lastPassword As String = ""

    Dim Rand As New Random

    Dim accountWriter As New IO.StreamWriter("DofusAccounts.txt", True)

    Private Function Consonne() As String
        Return consonnes(Rand.Next(0, consonnes.Length - 1))
    End Function

    Private Function Voyelle() As String
        Return voyelles(Rand.Next(0, voyelles.Length - 1))
    End Function

    Private Function AccountName() As String

        Dim theAccount As String = ""

        theAccount &= Consonne().ToUpper & Voyelle()
        For i As Integer = 1 To Rand.Next(3, 5)
            theAccount &= Consonne() & Voyelle()
        Next

        Return theAccount

    End Function

    Private Function Password() As String

        Dim thePassword As String = ""

        For i As Integer = 1 To Rand.Next(8, 12)

            Dim type As Integer = Rand.Next(1, 3)
            If (type = 1) Then
                thePassword &= Rand.Next(0, 9)
            ElseIf (type = 2) Then
                thePassword &= Consonne()
            Else
                thePassword &= Voyelle()
            End If

        Next

        Return thePassword

    End Function

    Private Sub WebAccount_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebAccount.DocumentCompleted

        If (e.Url.OriginalString = "https://www.dofus.com/fr/creer-un-compte") Then

            If lastAccount <> "" Then accountWriter.WriteLine(lastAccount & " " & lastPassword)

            Dim theAccount As String = AccountName()
            Dim thePassword As String = Password()
            Dim Email As String = AccountName() & Rand.Next(1, 9999) & "@gmail.com"
            Dim BirthYear As String = Rand.Next(1950, 1990).ToString
            Dim sexe As Integer = 0
            If Rand.Next(1, 4) = 1 Then
                sexe = 103
            Else
                sexe = 101
            End If

            With WebAccount.Document.All

                .Item(56).SetAttribute("value", theAccount)
                .Item(57).SetAttribute("value", theAccount)

                .Item(67).SetAttribute("value", thePassword)
                .Item(68).SetAttribute("value", thePassword)

                .Item(72).SetAttribute("value", thePassword)
                .Item(73).SetAttribute("value", thePassword)

                .Item(81).SetAttribute("value", Email)
                .Item(82).SetAttribute("value", Email)

                .Item(92).SetAttribute("value", AccountName())
                .Item(93).SetAttribute("value", AccountName())

                .Item(sexe).SetAttribute("checked", "checked")
                .Item(sexe + 1).SetAttribute("checked", "checked")

                .Item(109).SetAttribute("value", BirthYear)
                .Item(110).SetAttribute("value", BirthYear)

            End With

            lastAccount = theAccount
            lastPassword = thePassword

        Else

            WebAccount.Navigate("https://www.dofus.com/fr/creer-un-compte")

        End If

    End Sub

    Private Sub AccountCreator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        accountWriter.Close()
    End Sub

    Private Sub AccountCreator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        accountWriter.AutoFlush = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class