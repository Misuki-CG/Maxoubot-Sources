Module Declarations

    Public ipServeurLogin, versionJeu As String
    Public comptes As New List(Of Perso)
    Public listeDesObjets(13000) As String
    Public cases(2500) As String
    Public BloqueSpectateur, BloqueGroupe As Boolean
    Public DisconnectWhenFull As Boolean
    Public ChangerDeMap As Boolean, AuBoutDeCombats As Integer
    Public sortsMax(1024), sortsMin(1024) As Integer

    Public frmDebug As New FormDebug
    Public toDebug As Boolean = False

    Public addSmiley As Boolean = False, addChiffre As Boolean = True
    Public addSymbol As Boolean = False, addLettre As Boolean = False

    Public smileyList1() As String = {":", ";", ";-", ":-", "=", "='"}
    Public smileyList2 As String = "dD)]pP"

    Public lettre As String = "abcdefghijklmnopqrstuvwxyz"
    Public chiffre As String = "0123456789"
    Public symbole As String = "~#'-\_^+,?./§!°%¨$*"

End Module
