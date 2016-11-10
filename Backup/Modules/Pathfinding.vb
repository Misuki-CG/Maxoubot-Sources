Public Class Pathfinding

    Public openlist As New ArrayList
    Public closelist As New ArrayList
    Private Plist(1025) As Integer
    Private Flist(1025) As Integer
    Private Glist(1025) As Integer
    Private Hlist(1025) As Integer

    Private fight As Boolean
    Private nombreDePM As Integer

    Private Sub loadCell()

        For i = 0 To 1024
            Plist(i) = 0
            Flist(i) = 0
            Glist(i) = 0
            Hlist(i) = 0
        Next

    End Sub

    Private Sub loadSprites(ByVal mapHandler() As Cell, ByVal eviterChangeurs As Boolean)

        For i As Integer = 1 To 1000
            If mapHandler(i).movement = 0 Then
                closelist.Add(i)
            ElseIf mapHandler(i).object2Movement = True Then
                closelist.Add(i)
            ElseIf (eviterChangeurs) Then
                If mapHandler(i).movement = 2 Then closelist.Add(i)
            End If
        Next

    End Sub

    Public Function pathing(ByVal mapHandler() As Cell, ByVal nCellBegin As Integer, ByVal nCellEnd As Integer, Optional ByVal eviterChangeurs As Boolean = False, Optional ByVal isfight As Boolean = False, Optional ByVal numberPM As Integer = 9999)
        Try
            loadCell()

            loadSprites(mapHandler, eviterChangeurs)
            closelist.Remove(nCellEnd)

            fight = isfight
            nombreDePM = numberPM
            Dim returnPath As String = findpath(nCellBegin, nCellEnd)

            Return cleanPath(returnPath)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Function findpath(ByVal cell1 As Integer, ByVal cell2 As Integer) As String
        Dim current As Integer
        Dim i As Integer = 0

        openlist.Add(cell1)

        Do Until openlist.Contains(cell2)
            i += 1
            If i > 1000 Then Return ""

            current = getFpoint()
            If current = cell2 Then Exit Do
            closelist.Add(current)
            openlist.Remove(current)

            For Each cell As Integer In getChild(current)

                If closelist.Contains(cell) = False Then

                    If openlist.Contains(cell) Then

                        If Glist(current) + 5 < Glist(cell) Then
                            Plist(cell) = current
                            Glist(cell) = Glist(current) + 5
                            Hlist(cell) = goalDistance("X", cell, cell2)
                            Flist(cell) = Glist(cell) + Hlist(cell)
                        End If

                    Else
                        openlist.Add(cell)
                        openlist.Item(openlist.Count - 1) = cell
                        Glist(cell) = Glist(current) + 5
                        Hlist(cell) = goalDistance("X", cell, cell2)
                        Flist(cell) = Glist(cell) + Hlist(cell)
                        Plist(cell) = current
                    End If

                End If

            Next
        Loop

        Return (getParent(cell1, cell2))

    End Function

    Private Function getParent(ByVal cell1 As Integer, ByVal cell2 As Integer)
        Dim current As Integer = cell2
        Dim pathCell As New ArrayList
        pathCell.Add(current)

        Do Until current = cell1
            pathCell.Add(Plist(current))
            current = Plist(current)
        Loop

        Return getPath(pathCell)
    End Function


    Private Function getPath(ByVal pathCell As ArrayList)
        pathCell.Reverse()
        Dim pathing As String = ""
        Dim current
        Dim child
        Dim PMUsed As Integer = 0
        For i = 0 To pathCell.Count - 2
            PMUsed += 1
            If (PMUsed > nombreDePM) Then Return pathing
            current = pathCell(i)
            child = pathCell(i + 1)
            pathing &= getOrientation(current, child) & cases(CInt(child))
        Next

        Return pathing
    End Function

    Private Function getChild(ByVal cell As Integer)

        Dim x = getCaseCoordonneeX("X", cell)
        Dim y = getCaseCoordonneeY("X", cell)
        Dim children As New ArrayList
        Dim temp
        Dim locx, locy

        If fight = False Then

            temp = cell - 29
            locx = getCaseCoordonneeX("X", temp)
            locy = getCaseCoordonneeY("X", temp)
            If temp > 1 And temp < 1024 And locx = x - 1 And locy = y - 1 And closelist.Contains(temp) = False Then
                children.Add(temp)
            End If

            temp = cell + 29
            locx = getCaseCoordonneeX("X", temp)
            locy = getCaseCoordonneeY("X", temp)
            If temp > 1 And temp < 1024 And locx = x + 1 And locy = y + 1 And closelist.Contains(temp) = False Then
                children.Add(temp)
            End If

        End If

        temp = cell - 15
        locx = getCaseCoordonneeX("X", temp)
        locy = getCaseCoordonneeY("X", temp)
        If temp > 1 And temp < 1024 And locx = x - 1 And locy = y And closelist.Contains(temp) = False Then
            children.Add(temp)
        End If

        temp = cell + 15
        locx = getCaseCoordonneeX("X", temp)
        locy = getCaseCoordonneeY("X", temp)
        If temp > 1 And temp < 1024 And locx = x + 1 And locy = y And closelist.Contains(temp) = False Then
            children.Add(temp)
        End If

        temp = cell - 14
        locx = getCaseCoordonneeX("X", temp)
        locy = getCaseCoordonneeY("X", temp)
        If temp > 1 And temp < 1024 And locx = x And locy = y - 1 And closelist.Contains(temp) = False Then
            children.Add(temp)
        End If

        temp = cell + 14
        locx = getCaseCoordonneeX("X", temp)
        locy = getCaseCoordonneeY("X", temp)
        If temp > 1 And temp < 1024 And locx = x And locy = y + 1 And closelist.Contains(temp) = False Then
            children.Add(temp)
        End If

        If fight = False Then

            temp = cell - 1
            locx = getCaseCoordonneeX("X", temp)
            locy = getCaseCoordonneeY("X", temp)
            If temp > 1 And temp < 1024 And locx = x - 1 And locy = y + 1 And closelist.Contains(temp) = False Then
                children.Add(temp)
            End If

            temp = cell + 1
            locx = getCaseCoordonneeX("X", temp)
            locy = getCaseCoordonneeY("X", temp)
            If temp > 1 And temp < 1024 And locx = x + 1 And locy = y - 1 And closelist.Contains(temp) = False Then
                children.Add(temp)
            End If

        End If

        Return children

    End Function

    Private Function getFpoint()

        Dim x As Integer = 9999
        Dim cell As Integer

        For Each item As Integer In openlist
            If closelist.Contains(item) = False Then
                If Flist(item) < x Then
                    x = Flist(item)
                    cell = item
                End If
            End If
        Next

        Return cell
    End Function

    Public Class loc8
        Public y As Integer = 0
        Public x As Integer = 0
    End Class

    Public Function getCaseCoordonneeX(ByVal mapHandler As String, ByVal nNum As Integer) As Integer
        Dim _loc4 = 15 'mapHandler.Length()
        Dim _loc5 = Math.Floor(nNum / (_loc4 * 2 - 1))
        Dim _loc6 = nNum - _loc5 * (_loc4 * 2 - 1)
        Dim _loc7 = _loc6 Mod _loc4
        Dim _loc8 As New loc8

        Dim y As Integer = _loc5 - _loc7
        Dim x As Integer = (nNum - (_loc4 - 1) * y) / _loc4
        Return x
    End Function

    Public Function getCaseCoordonneeY(ByVal mapHandler As String, ByVal nNum As Integer) As Integer
        Dim _loc4 = 15 'mapHandler.Length()
        Dim _loc5 = Math.Floor(nNum / (_loc4 * 2 - 1))
        Dim _loc6 = nNum - _loc5 * (_loc4 * 2 - 1)
        Dim _loc7 = _loc6 Mod _loc4
        Dim _loc8 As New loc8

        Dim y As Integer = _loc5 - _loc7
        Dim x As Integer = (nNum - (_loc4 - 1) * y) / _loc4
        Return y
    End Function

    Public Function goalDistance(ByVal mapHandler As String, ByVal nCell1 As Integer, ByVal nCell2 As Integer)

        Dim _loc5x = getCaseCoordonneeX(mapHandler, nCell1)
        Dim _loc5y = getCaseCoordonneeY(mapHandler, nCell1)
        Dim _loc6x = getCaseCoordonneeX(mapHandler, nCell2)
        Dim _loc6y = getCaseCoordonneeY(mapHandler, nCell2)
        Dim _loc7 = Math.Abs(_loc5x - _loc6x)
        Dim _loc8 = Math.Abs(_loc5y - _loc6y)

        Return (_loc7 + _loc8)

    End Function

    Public Function getOrientation(ByVal cell1 As Integer, ByVal cell2 As Integer)
        Select Case cell2 - cell1
            Case -29
                Return "g"
            Case 29
                Return "c"
            Case -1
                Return "e"
            Case 1
                Return "a"
            Case -15
                Return "f"
            Case 15
                Return "b"
            Case -14
                Return "h"
            Case 14
                Return "d"
        End Select
        Return "a"
    End Function


    Function getDirectionFromCoordinates(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal bAllDirections As Boolean)

        Dim _loc7 = Math.Atan2(y2 - y1, x2 - x1)
        If bAllDirections Then

            If (_loc7 >= -Math.PI / 8 AndAlso _loc7 < Math.PI / 8) Then

                Return (0)
            End If
            If (_loc7 >= Math.PI / 8 AndAlso _loc7 < Math.PI / 3) Then

                Return (1)
            End If
            If (_loc7 >= Math.PI / 3 AndAlso _loc7 < 2 * Math.PI / 3) Then

                Return (2)
            End If
            If (_loc7 >= 2 * Math.PI / 3 AndAlso _loc7 < 7 * Math.PI / 8) Then

                Return (3)
            End If
            If (_loc7 >= 7 * Math.PI / 8 OrElse _loc7 < -7 * Math.PI / 8) Then

                Return (4)
            End If
            If (_loc7 >= -7 * Math.PI / 8 AndAlso _loc7 < -2 * Math.PI / 3) Then

                Return (5)
            End If
            If (_loc7 >= -2 * Math.PI / 3 AndAlso _loc7 < -Math.PI / 3) Then

                Return (6)
            End If
            If (_loc7 >= -Math.PI / 3 AndAlso _loc7 < -Math.PI / 8) Then

                Return (7)
            End If

        Else

            If (_loc7 >= 0 AndAlso _loc7 < Math.PI / 2) Then

                Return (1)
            End If
            If (_loc7 >= Math.PI / 2 AndAlso _loc7 <= Math.PI) Then

                Return (3)
            End If
            If (_loc7 >= -Math.PI AndAlso _loc7 < -Math.PI / 2) Then

                Return (5)
            End If
            If (_loc7 >= -Math.PI / 2 AndAlso _loc7 < 0) Then

                Return (7)
            End If
        End If
        Return (1)
    End Function

    Private Function cleanPath(ByVal path As String) As String

        Dim cleanedPath As String = ""

        If (path.Length > 3) Then
            For i As Integer = 1 To path.Length Step 3
                If (Mid(path, i, 1) <> Mid(path, i + 3, 1)) Then
                    cleanedPath &= Mid(path, i, 3)
                End If
            Next
        Else
            cleanedPath = path
        End If

        Return cleanedPath

    End Function

End Class
