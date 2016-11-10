Imports SwfDotNet.IO
Imports SwfDotNet.IO.Tags
Imports SwfDotNet.IO.ByteCode
Imports SwfDotNet.IO.ByteCode.Actions

Class SwfUnpacker

    Dim mapToDecompress As String = ""

    Public Sub SwfUnpack(ByVal FileName As String)

        mapToDecompress = FileName

        Dim Uncompresser As New Threading.Thread(AddressOf UncompressSwf)
        Uncompresser.IsBackground = True
        Uncompresser.Start()

        While Uncompresser.IsAlive

            Application.DoEvents()
            System.Threading.Thread.Sleep(1)

        End While

    End Sub

    Private Sub UncompressSwf()

        Try

            If Not IO.Directory.Exists("temp") Then IO.Directory.CreateDirectory("temp")

            My.Computer.Network.DownloadFile("http://staticns.ankama.com/dofus/gamedata/dofus/maps/" & mapToDecompress, "temp/" & mapToDecompress)

            Dim swfReader As New SwfReader("temp/" & mapToDecompress)

            Dim swf As Swf = swfReader.ReadSwf()

            Dim tagsEnu As IEnumerator = swf.Tags.GetEnumerator()

            While tagsEnu.MoveNext()

                Dim tag As BaseTag = DirectCast(tagsEnu.Current, BaseTag)

                If tag.ActionRecCount <> 0 Then

                    Dim sb As String = ""
                    Dim enum2 As IEnumerator = tag.GetEnumerator()

                    While enum2.MoveNext()

                        Dim dc As New Decompiler(swf.Version)
                        Dim actions As ArrayList = dc.Decompile(DirectCast(enum2.Current, Byte()))

                        For Each obj As BaseAction In actions
                            sb &= obj.ToString() & vbCrLf
                        Next

                    End While

                    Dim map_data As String = Gettok(sb.ToString, "'", 30)
                    Dim map_id As String = Gettok(Gettok(sb.ToString, "push", 14), " ", 2)
                    Dim map_x As String = Gettok(Gettok(sb.ToString, "push", 16), " ", 2)
                    Dim map_y As String = Gettok(Gettok(sb.ToString, "push", 18), " ", 2)

                    Dim efileName As String = "maps/" & Gettok(mapToDecompress, ".", 1) & ".txt"
                    Dim writer As New IO.StreamWriter(efileName)
                    writer.Write(map_id & "|" & map_data & "|" & map_x & "|" & map_y)
                    writer.Close()

                End If

            End While

            My.Computer.FileSystem.DeleteFile("temp/" & mapToDecompress)

        Catch
        End Try

    End Sub

End Class
