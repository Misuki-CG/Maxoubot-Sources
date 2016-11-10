Imports System.IO

Module Config

    Public Sub WriteSettings()

        Try

            Dim monStreamWriter As New StreamWriter("data/config.txt")

            Dim textSpectateur As String = "0", textGroupe As String = "0", textMap As String = "0", textDeco As String = "0"
            Dim Chiffre As String = "0", Lettre As String = "0", Symbole As String = "0", Smiley As String = "0"

            If (BloqueSpectateur) Then textSpectateur = "1"

            If (BloqueGroupe) Then textGroupe = "1"

            If (ChangerDeMap) Then textMap = "1"

            If (DisconnectWhenFull) Then textDeco = "1"

            If addChiffre Then Chiffre = "1"
            If addLettre Then Lettre = "1"
            If addSymbol Then Symbole = "1"
            If addSmiley Then Smiley = "1"

            Dim globals As String = ipServeurLogin & "|" & versionJeu
            Dim lesIA As String = textSpectateur & "|" & textGroupe & "|" & textMap & "|" & AuBoutDeCombats & "|" & textDeco

            Dim FloodAdd As String = Chiffre & "|" & Lettre & "|" & Symbole & "|" & Smiley

            monStreamWriter.WriteLine(globals & "|" & lesIA)
            monStreamWriter.WriteLine(FloodAdd)

            monStreamWriter.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> WriteSettings()")
        End Try

    End Sub

    Public Sub LoadServer(ByVal MyForm As FormAdd)
        Try
            Dim monStreamReader As New StreamReader("data/servers.txt")
            Dim ligne As String = "a"

            While (ligne <> Nothing)
                ligne = monStreamReader.ReadLine
                If ligne <> "" Then
                    MyForm.ListServer.Items.Add(ligne)
                End If
            End While
            monStreamReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> LoadServer()")
        End Try
    End Sub

    Public Sub LoadConfig()
        Try
            Dim monStreamReader As New StreamReader("data/config.txt")
            Dim ligne As String = ""
            ligne = monStreamReader.ReadLine

            ipServeurLogin = Gettok(ligne, "|", 1)
            versionJeu = Gettok(ligne, "|", 2)

            BloqueSpectateur = CInt(Gettok(ligne, "|", 3))
            BloqueGroupe = CInt(Gettok(ligne, "|", 4))

            ChangerDeMap = CInt(Gettok(ligne, "|", 5))
            AuBoutDeCombats = CInt(Gettok(ligne, "|", 6))

            ligne = monStreamReader.ReadLine

            addChiffre = CInt(Gettok(ligne, "|", 1))
            addLettre = CInt(Gettok(ligne, "|", 2))
            addSymbol = CInt(Gettok(ligne, "|", 3))
            addSmiley = CInt(Gettok(ligne, "|", 4))

            monStreamReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> LoadConfig()")
        End Try
    End Sub

    Public Sub LoadSpell(ByVal MyForm As FormAdd)
        MyForm.Sort.Items.Clear()
        MyForm.Sort.Items.Add("Aucun (0)")
        Try

            For i As Integer = 1 To 1000
                sortsMin(CInt(i)) = -1
                sortsMax(CInt(i)) = -1
            Next

            Dim monStreamReader As New StreamReader("data/sorts.txt")
            Dim ligne As String = "a"

            While (ligne <> Nothing)
                ligne = monStreamReader.ReadLine
                If ligne <> "" Then
                    Dim id As String = Gettok(ligne, ":", 1)
                    Dim sort As String = Gettok(ligne, ":", 2)
                    MyForm.Sort.Items.Add(sort & " (" & id & ")")
                    If (Gettoks(ligne, ":") = 4) Then
                        sortsMin(CInt(id)) = CInt(Gettok(ligne, ":", 3))
                        sortsMax(CInt(id)) = CInt(Gettok(ligne, ":", 4))
                    End If
                End If
            End While
            monStreamReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> LoadSpell()")
        End Try
    End Sub

    Public Sub LoadItems(ByVal index As Integer)
        Try
            Dim monStreamReader As New StreamReader("data/objets.txt")
            Dim ligne As String = "a"

            While (ligne <> Nothing)
                ligne = monStreamReader.ReadLine
                If ligne <> "" Then
                    Dim id As String = Gettok(ligne, ":", 1)
                    Dim objet As String = Gettok(ligne, ":", 2)
                    listeDesObjets(id) = objet
                    comptes(index).TabUtilisateur.Objets.Items.Add(objet & " (" & id & ")")
                End If
            End While
            monStreamReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> LoadItems()")
        End Try
    End Sub

    Public Sub WriteTrajetToBank(ByVal map As Integer, ByVal direction As Integer)
        Dim writer As New StreamWriter("data/banque.txt", True)
        writer.WriteLine(map.ToString & ":" & direction.ToString)
        writer.Close()
    End Sub

    Public Function GetMapPos(ByVal mapID As Integer) As String

        Try
            Dim monStreamReader As New StreamReader("data/maps.txt")
            Dim ligne As String = "a"

            While (ligne <> Nothing)
                ligne = monStreamReader.ReadLine
                If ligne <> "" Then
                    If (Gettok(ligne, ":", 1) = mapID.ToString) Then
                        Return Gettok(ligne, ":", 2)
                    End If
                End If
            End While
            monStreamReader.Close()

            Return ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Config.vb --> GetMapPos(" & mapID.ToString & ")")
            Return ""
        End Try

    End Function

End Module
