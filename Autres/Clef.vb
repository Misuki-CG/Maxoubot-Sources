Public Class Clef

    Dim hash() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"}
    Dim hash2Nd() As String = {"F", "E", "D", "C", "B", "A", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"}

    Private Function Crypt(ByVal text As String)

        Dim returnText As String = ""

        For i As Integer = 0 To text.Length - 1
            returnText &= hash(Asc(text(i)) Mod hash.Length)
        Next

        Return returnText

    End Function

    Private Function Crypt2Nd(ByVal text As String)

        Dim returnText As String = ""

        For i As Integer = 0 To text.Length - 1
            returnText &= hash2Nd(Asc(text(i)) Mod hash2Nd.Length)
        Next

        Return returnText.ToUpper

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (Crypt2Nd(TextBox1.Text) = TextBox2.Text) Then
            Dim writer As New IO.StreamWriter("data/key.txt")
            writer.WriteLine(TextBox2.Text)
            writer.Close()
            Form.Show()
            Me.Close()
        Else
            MsgBox("Mauvaise clef !", MsgBoxStyle.Exclamation, "Ativado")
        End If

    End Sub

    Private Sub Clef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = Mid(Crypt(Environment.MachineName) & Crypt(Crypt(Environment.MachineName)) & Crypt(Mid(Environment.OSVersion.VersionString, 1, 15)) & Crypt(Crypt(Mid(Environment.OSVersion.VersionString, 1, 15))), 1, 24)
        If (IO.File.Exists("data/key.txt")) Then
            Dim reader As New IO.StreamReader("data/key.txt")
            TextBox2.Text = reader.ReadLine()
            reader.Close()
        End If

    End Sub

End Class