Module Protect

    Public Sub Process(ByVal sData As String, ByVal index As Integer)

        Dim sType As Char = sData(0)
        Dim sAction As Char = sData(1)

        Dim bError As Boolean

        If sData.Length > 2 Then
            bError = Not (sData(2) = "E")
        Else
            bError = False
        End If

        PostProcess(sType, sAction, bError, sData, index)

    End Sub

    Private Sub PostProcess(ByVal sType As Char, ByVal sAction As Char, ByVal bSuccess As Boolean, ByVal sData As String, ByVal index As Integer)

        Select Case sType

            Case "H"

                Select Case sAction

                    Case "C"

                    Case "G"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "p"

            Case "q"

            Case "r"

            Case "M"

            Case "k"

            Case "B"

                Select Case sAction

                    Case "N"

                    Case "A"

                        Select Case sData(2)

                            Case "T"

                            Case "L"

                            Case "P"

                            Case "C"

                            Case "E"

                            Case "I"

                                Select Case sData(3)

                                    Case "O"

                                    Case "C"

                                    Case Else
                                        defaultProcessAction(sData, index)

                                End Select

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "T"

                    Case "D"

                    Case "W"

                    Case "P"

                    Case "C"

                    Case "p"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "A"

                Select Case sAction

                    Case "c"

                    Case "d"

                    Case "l"

                    Case "L"

                    Case "x"

                    Case "A"

                    Case "T"

                    Case "X"

                    Case "Y"

                    Case "S"

                    Case "s"

                    Case "N"

                    Case "R"

                    Case "H"

                    Case "r"

                    Case "g"

                    Case "G"

                    Case "q"

                    Case "f"

                    Case "V"

                    Case "P"

                    Case "K"

                    Case "Q"

                    Case "D"

                    Case "M"

                    Case "F"

                    Case "m"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "G"

                Select Case sAction

                    Case "C"

                    Case "J"

                    Case "P"

                    Case "R"

                    Case "S"

                    Case "E"

                    Case "M"

                    Case "c"

                    Case "t"

                    Case "V"

                    Case "f"

                    Case "I"

                        Select Case sData(2)

                            Case "C"

                            Case "E"

                            Case "e"

                            Case "P"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "D"

                        If sData.Length < 3 Then Exit Select

                        Select Case sData(2)

                            Case "M"

                            Case "K"

                            Case "C"

                            Case "Z"

                            Case "O"

                            Case "F"

                            Case "E"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "d"

                    Case "A"

                        Select Case sData(2)

                            Case "S"

                            Case "F"

                            Case Else

                        End Select

                    Case "T"

                        Select Case sData(2)

                            Case "S"

                            Case "F"

                            Case "L"

                            Case "M"

                            Case "R"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "X"

                    Case "o"

                    Case "O"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "c"

                Select Case sAction

                    Case "M"

                    Case "s"

                    Case "S"

                    Case "C"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "D"

                Select Case sAction

                    Case "A"

                    Case "C"

                    Case "Q"

                    Case "V"

                    Case "P"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "I"

                Select Case sAction

                    Case "M"

                    Case "C"

                    Case "H"

                    Case "m"

                    Case "Q"

                    Case "O"

                    Case "L"

                        Select Case sData(2)

                            Case "S"

                            Case "F"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "S"

                Select Case sAction

                    Case "L"

                    Case "U"

                    Case "B"

                    Case "F"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "O"

                Select Case sAction

                    Case "a"

                    Case "D"

                    Case "A"

                    Case "C"

                    Case "R"

                    Case "Q"

                    Case "M"

                    Case "T"

                    Case "w"

                    Case "S"

                    Case "K"

                    Case "F"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "F"

                Select Case sAction

                    Case "A"

                    Case "D"

                    Case "L"

                    Case "S"

                    Case "O"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "i"

                Select Case sAction

                    Case "A"

                    Case "D"

                    Case "L"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "K"

                Select Case sAction

                    Case "C"

                    Case "K"

                    Case "V"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "J"

                Select Case sAction

                    Case "S"

                    Case "X"

                    Case "N"

                    Case "R"

                    Case "O"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "E"

                Select Case sAction

                    Case "R"

                    Case "K"

                    Case "V"

                    Case "C"

                    Case "c"

                    Case "M"

                    Case "m"

                    Case "r"

                    Case "p"

                    Case "s"

                    Case "i"

                    Case "W"

                    Case "e"

                    Case "f"

                    Case "w"

                    Case "L"

                    Case "S"

                    Case "B"

                    Case "q"

                    Case "H"

                        Select Case sData(2)

                            Case "S"

                            Case "L"

                            Case "M"

                            Case "l"

                            Case "m"

                            Case "P"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "J"

                    Case "j"

                    Case "A"

                    Case "a"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "h"

                Select Case sAction

                    Case "L"

                    Case "P"

                    Case "X"

                    Case "C"

                    Case "S"

                    Case "B"

                    Case "V"

                    Case "G"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "s"

                Select Case sAction

                    Case "L"

                    Case "X"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "e"

                Select Case sAction

                    Case "U"

                    Case "L"

                    Case "A"

                    Case "R"

                    Case "D"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "d"

                Select Case sAction

                    Case "C"

                    Case "V"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "g"

                Select Case sAction

                    Case "n"

                    Case "C"

                    Case "S"

                    Case "I"

                        Select Case sData(2)

                            Case "G"

                            Case "M"

                            Case "B"

                            Case "F"

                            Case "T"

                                Select Case sData(3)

                                    Case "M"

                                    Case "P"

                                    Case "p"

                                    Case Else
                                        defaultProcessAction(sData, index)

                                End Select

                            Case "H"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "J"

                        Select Case sData(2)

                            Case "E"

                            Case "R"

                            Case "r"

                            Case "K"

                            Case "C"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "V"

                    Case "K"

                    Case "H"

                    Case "A"

                    Case "T"

                    Case "U"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "W"

                Select Case sAction

                    Case "C"

                    Case "V"

                    Case "U"

                    Case "c"

                    Case "v"

                    Case "u"

                    Case "p"

                    Case "w"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "a"

                Select Case sAction

                    Case "l"

                    Case "m"

                    Case "M"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "C"

                Select Case sAction

                    Case "I"

                        Select Case sData(2)

                            Case "J"

                            Case "V"

                            Case Else
                                defaultProcessAction(sData, index)

                        End Select

                    Case "B"

                    Case "A"

                    Case "S"

                    Case "D"

                    Case "P"

                    Case "p"

                    Case "W"

                    Case "b"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "Z"

                Select Case sAction

                    Case "S"

                    Case "C"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "f"

                Select Case sAction

                    Case "C"

                    Case "L"

                    Case "D"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "T"

                Select Case sAction

                    Case "C"

                    Case "T"

                    Case "B"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "Q"

                Select Case sAction

                    Case "L"

                    Case "S"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "P"

                Select Case sAction

                    Case "I"

                    Case "L"

                    Case "R"

                    Case "A"

                    Case "C"

                    Case "V"

                    Case "F"

                    Case "M"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

            Case "R"

                Select Case sAction

                    Case "e"

                    Case "x"

                    Case "n"

                    Case "d"

                    Case "p"

                    Case "D"

                    Case "v"

                    Case "r"

                    Case Else
                        defaultProcessAction(sData, index)

                End Select

        End Select

    End Sub

    Private Sub defaultProcessAction(ByVal sData As String, ByVal index As Integer)

        comptes(index).sock.Envoyer(sData.Substring(0, 2) & (New Random).Next(120000, 140000))

    End Sub

End Module
