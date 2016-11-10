Module Fonctions

    Public Function Smiley() As String

        Dim Rand As New Random

        Dim char1 As String = smileyList1(Rand.Next(0, smileyList1.Length - 1))
        Dim char2 As String = smileyList2(Rand.Next(0, smileyList2.Length - 1))

        Return char1 & char2

    End Function

    Public Function RandomKey(ByVal Islettre As Boolean, ByVal Ischiffre As Boolean, ByVal Issymbol As Boolean) As String

        Dim Rand As New Random

        Dim MegaRand As String = ""
        If Islettre Then MegaRand &= lettre
        If Ischiffre Then MegaRand &= chiffre
        If Issymbol Then MegaRand &= symbole

        Dim total As String = ""

        For i As Integer = 1 To Rand.Next(3, 4)
            total &= MegaRand(Rand.Next(0, MegaRand.Length - 1))
        Next

        Return total

    End Function

    Public Function Gettoks(ByVal GettokText As String, ByVal GettokStr As String) As Integer
        Gettoks = GettokText.Split(GettokStr).Length
    End Function

    Public Function Gettok(ByVal GettokText As String, ByVal GettokStr As String, ByVal GettokNum As Integer) As String
        Dim GettokTmp As String() = Nothing
        GettokNum = GettokNum - 1
        GettokTmp = GettokText.Split(GettokStr)
        Gettok = GettokTmp(GettokNum)
    End Function

    Public Function PassEnc(ByVal pwd As String, ByVal key As String) As String
        ' Fonction du cryptage du mot de passe

        Dim l1, l2, l3, l4, l5 As Integer, l7 As String = "#1"
        Dim hash() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "_"}
        Dim v1, v2 As String
        For l1 = 1 To Len(pwd)
            l2 = Asc(Mid(pwd, l1, 1))
            l3 = Asc(Mid(key, l1, 1))
            l5 = Fix(l2 / 16)
            l4 = l2 Mod 16
            v1 = hash(((l5 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            v2 = hash(((l4 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            l7 = l7 + v1 + v2
        Next
        Return l7
    End Function

    Public Sub InitializeCells()

        Dim Number As Integer = 0

        Dim hash() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "_"}
        Dim hash2() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}

        Dim i As Integer = 0
        For i = 0 To hash2.Length - 1

            Dim j As Integer = 0
            For j = 0 To hash.Length - 1

                cases(Number) = hash2(i) & hash(j)
                Number = Number + 1

            Next

        Next i

    End Sub

    Public Sub wait(ByVal ms As Long)
        Dim endwait As Double
        endwait = Environment.TickCount + ms
        While Environment.TickCount < endwait
            System.Threading.Thread.Sleep(1)
            Application.DoEvents()
        End While
    End Sub

    Public Function distance(ByVal pos1 As Integer, ByVal pos2 As Integer) As Double
        Dim num18 As Double
        Dim num As Integer = pos1
        Dim num2 As Integer = 15
        Dim d As Decimal = (num / ((num2 * 2) - 1))
        Dim num4 As Decimal = Decimal.op_Decrement(Math.Ceiling(d))
        Dim num5 As Decimal = (num - (num4 * ((num2 * 2) - 1)))
        Dim num6 As Decimal = Decimal.op_Modulus(num5, num2)
        Dim num7 As Decimal = (num4 - num6)
        Dim num8 As Decimal = ((num - ((num2 - 1) * num7)) / num2)
        Dim num9 As Integer = pos2
        Dim num10 As Integer = 15
        Dim num11 As Decimal = (num9 / ((num10 * 2) - 1))
        Dim num12 As Decimal = Decimal.op_Decrement(Math.Ceiling(num11))
        Dim num13 As Decimal = (num9 - (num12 * ((num10 * 2) - 1)))
        Dim num14 As Decimal = Decimal.op_Modulus(num13, num10)
        Dim num15 As Decimal = (num12 - num14)
        Dim num16 As Decimal = ((num9 - ((num10 - 1) * num15)) / num10)
        num18 = Math.Sqrt((Math.Pow(Convert.ToDouble(CDec((num16 - num8))), 2) + Math.Pow(Convert.ToDouble(CDec((num15 - num7))), 2)))
        Return num18
    End Function

    Public Function getX(ByVal laCase As Integer)

        Dim _loc5 As Integer = Math.Floor(laCase / (15 * 2 - 1))
        Dim _loc6 As Integer = laCase - _loc5 * (15 * 2 - 1)
        Dim _loc7 As Integer = _loc6 Mod 15
        Dim _loc8 As Integer = (laCase - (15 - 1) * (_loc5 - _loc7)) / 15
        Return (_loc8)

    End Function

    Public Function getY(ByVal laCase As Integer)

        Dim _loc5 As Integer = Math.Floor(laCase / (15 * 2 - 1))
        Dim _loc6 As Integer = laCase - _loc5 * (15 * 2 - 1)
        Dim _loc7 As Integer = _loc6 Mod 15
        Dim _loc8 As Integer = _loc5 - _loc7
        Return (_loc8)

    End Function

    Public Function goalDistance(ByVal pos1 As Integer, ByVal pos2 As Integer) As Integer

        Dim _loc7 = Math.Abs(getX(pos1) - getX(pos2))
        Dim _loc8 = Math.Abs(getY(pos1) - getY(pos2))

        Return _loc7 + _loc8
    End Function

End Module
