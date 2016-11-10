Module Maps

    Private Sub LoadRessources(ByVal index As Integer, ByVal spritesHandler() As Cell)

        With comptes(index)

            Dim listeID As New List(Of Integer)
            Dim listeNom As New List(Of String)
            Dim listeMovement As New List(Of Boolean)

            Dim ligne As String = "a"
            Dim reader As New IO.StreamReader("data/ressources.txt")

            While (ligne <> Nothing)
                ligne = reader.ReadLine
                If ligne <> "" Then
                    Dim total() As String = ligne.Split(":")
                    If (total.Length = 3) Then
                        Dim id As Integer = total(0)
                        Dim nom As String = total(1)
                        Dim movement As String = total(2)
                        listeID.Add(id)
                        listeNom.Add(nom)
                        If (movement = "o") Then
                            listeMovement.Add(True)
                        Else
                            listeMovement.Add(False)
                        End If
                    End If
                End If
            End While

            reader.Close()

            Dim j As Integer = 0

            .TabUtilisateur.ListeRessources.Items.Clear()
            For i As Integer = 1 To 1000
                If (listeID.Contains(spritesHandler(i).layerObject2Num)) Then
                    .TabUtilisateur.ListeRessources.Items.Add(listeNom(listeID.IndexOf(spritesHandler(i).layerObject2Num)))
                    .TabUtilisateur.ListeRessources.Items(j).SubItems.Add(i.ToString)
                    .TabUtilisateur.ListeRessources.Items(j).SubItems.Add("Non coupé")
                    spritesHandler(i).object2Movement = listeMovement(listeID.IndexOf(spritesHandler(i).layerObject2Num))
                    j += 1
                End If
            Next

        End With

    End Sub

    Public Sub LoadMap(ByVal index As Integer, ByVal idMap As String, ByVal indice As String, ByVal clef As String)

        With comptes(index)

            Try

                .changeurBas = -1
                .changeurDroite = -1
                .changeurGauche = -1
                .changeurHaut = -1

                .Debug("Loading map " & idMap)

                If Not IO.Directory.Exists("maps") Then IO.Directory.CreateDirectory("maps")

                If Not IO.File.Exists("maps/" & idMap & "_" & indice & "X.txt") Then

                    Dim Unpacker As New SwfUnpacker
                    Unpacker.SwfUnpack(idMap & "_" & indice & "X.swf")

                End If

                Dim mapReader As New IO.StreamReader("maps/" & idMap & "_" & indice & "X.txt")

                Dim mapData As String = mapReader.ReadLine

                mapReader.Close()

                mapData = Gettok(mapData, "|", 2)

                Dim preparedKey As String = prepareKey(clef)
                Dim sData As String = decypherData(mapData, preparedKey, Convert.ToInt64(checksum(preparedKey), 16) * 2)

                .mapDataActuel = uncompressMap(sData)
                .mapActuelle = idMap
                .TabUtilisateur.CoordsMap.Text = GetMapPos(idMap)

                For i As Integer = 1 To 500

                    If (.mapDataActuel(i).movement = 2) Then

                        Dim x As Integer = getX(i)
                        Dim y As Integer = getY(i)

                        If ((x - 1) = y) Then
                            .changeurGauche = i
                        ElseIf ((x - 27) = y) Then
                            .changeurDroite = i
                        ElseIf ((x + y) = 31) Then
                            .changeurBas = i
                        ElseIf (y < 0) Then
                            y = Math.Abs(y)
                            If (x - y = 1) Then
                                .changeurHaut = i
                            End If
                        End If

                    End If

                Next

                LoadRessources(index, .mapDataActuel)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Maps.vb --> LoadMap(" & idMap & ")")
            End Try

        End With

    End Sub

End Module
