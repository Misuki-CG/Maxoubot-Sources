Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO

''' <summary>
''' Classe de gestion des evenements
''' </summary>
''' <auteur>LEVEUGLE Damien [Elguevel]</auteur>
''' <remarks></remarks>
Public Class ElgSocketEventArgs
    Inherits EventArgs

    ' Attributs
    Private _Message As String
    Private _LaSocket As Socket

    ' Message
    Public ReadOnly Property Message() As String
        Get
            Return _Message
        End Get
    End Property

    ' Socket
    Public ReadOnly Property LaSocket() As Socket
        Get
            Return _LaSocket
        End Get
    End Property

    ''' <summary>
    ''' Constructeur par defaut
    ''' </summary>
    ''' <param name="Message">Message transmis</param>
    ''' <param name="LaSocket">Socket cliente</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Message As String, ByVal LaSocket As Socket)
        Me._Message = Message
        Me._LaSocket = LaSocket
    End Sub

    ''' <summary>
    ''' Constructeur surchargé
    ''' </summary>
    ''' <param name="LaSocket">Socket cliente</param>
    ''' <remarks>Fait appel au constructeur <c>Sub New(ByVal Message As String, ByVal LaSocket As Socket)</c></remarks>
    Public Sub New(ByVal LaSocket As Socket)
        MyClass.New("", LaSocket)
    End Sub

    ''' <summary>
    ''' Constructeur surchargé
    ''' </summary>
    ''' <param name="Message">Message transmis</param>
    ''' <remarks>Fait appel au constructeur <c>Sub New(ByVal Message As String, ByVal LaSocket As Socket)</c></remarks>
    Public Sub New(ByVal Message As String)
        MyClass.New(Message, Nothing)
    End Sub

End Class

''' <summary>
''' Class permettant la gestion des connexions vers le serveur
''' </summary>
''' <auteur>LEVEUGLE Damien</auteur>
''' <copyright>Elguevel Software 2008</copyright>
''' <version>1.0</version>
''' <remarks>Module client</remarks>
Public Class ElgSocketClient
    Implements IDisposable

#Region "Evenements"

    ' Delegué utilisé pour appel inter-thread
    Public Delegate Sub ElgSocketDelegate(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)

    ' Evenement des différentes actions de la classe
    Public Event OnReception(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)
    Public Event OnConnexion(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)
    Public Event OnDeconnexion(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)
    Public Event OnEnvoie(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)
    Public Event OnErreur(ByVal Sender As Object, ByVal Message As ElgSocketEventArgs)

#End Region

#Region "Champs"

    Private _Socket As Socket       ' Socket serveur (utilisé pour l'écoute)
    Private _Buffer(65536) As Byte   ' Buffer de données
    Private _Hote As String         ' Serveur auquel on se connect
    Private _Port As Integer        ' Port vers le serveur

#End Region

#Region "Proprietés"

    Public Property Hote() As String
        Get
            Return _Hote
        End Get
        Set(ByVal value As String)
            _Hote = value
        End Set
    End Property

    Public Property Port() As Integer
        Get
            Return _Port
        End Get
        Set(ByVal value As Integer)
            _Port = value
        End Set
    End Property

    ''' <summary>
    ''' Accesseur à la socket d'ecoute
    ''' </summary>
    ''' <value>Socket d'ecoute</value>    
    ''' <remarks>Cette socket ne devrait normalement jamais être utilisé en dehors de la classe</remarks>
    Public ReadOnly Property LaSocket() As Socket
        Get
            Return Me._Socket
        End Get
    End Property

    ''' <summary>
    ''' Connecté ou pas ?
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Connecter() As Boolean
        Get
            Return _Socket.Connected
        End Get
    End Property

#End Region

#Region "Methodes"

    ''' <summary>
    ''' Envoi une chaine au client
    ''' </summary>
    ''' <param name="Message">Chaine à envoyer vers le serveur</param>
    ''' <remarks></remarks>
    Public Sub Envoyer(ByVal Message As String)

        Message = Message & Chr(10) & Chr(0)

        Try

            If (Me._Socket.Connected) Then
                Dim ByteBuffer As Byte() = Encoding.UTF8.GetBytes(Message)
                Me._Socket.BeginSend(ByteBuffer, 0, ByteBuffer.Length, SocketFlags.None, AddressOf CallBackSender, Me._Socket)
                RaiseEvent OnEnvoie(Me, New ElgSocketEventArgs(Message, Me._Socket))
            Else
                RaiseEvent OnErreur(Me, New ElgSocketEventArgs("Bot non connecté !", Me._Socket))

            End If

        Catch ex As Exception
            RaiseEvent OnErreur(Me, New ElgSocketEventArgs(ex.Message, Nothing))

        End Try

    End Sub

    ''' <summary>
    ''' Se connecte / Se deconnecte
    ''' </summary>
    ''' <param name="Active">Active ou desactive la socket</param>
    ''' <remarks>METHODE A REVOIR</remarks>
    Public Sub Connexion(ByVal Active As Boolean)

        If (Active) Then
            LaSocket.BeginConnect(New IPEndPoint(IPAddress.Parse(_Hote), _Port), New AsyncCallback(AddressOf CallBackConnect), _Socket)
        Else
            Try
                _Socket.Shutdown(SocketShutdown.Both)
            Catch
            End Try
        End If

    End Sub

#End Region

#Region "Callbacks"

    ''' <summary>
    ''' Callback de connexion vers le serveur
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackConnect(ByVal async As IAsyncResult)

        Dim LaSocket As Socket = CType(async.AsyncState, Socket)

        Try
            LaSocket.EndConnect(async)
        Catch ex As Exception
            RaiseEvent OnErreur(Me, New ElgSocketEventArgs("Erreur de connexion au serveur"))
        End Try

        RaiseEvent OnConnexion(Me, New ElgSocketEventArgs("Connexion d'un client", LaSocket))

        Try
            ' Active la reception des messages
            LaSocket.BeginReceive(_Buffer, 0, _Buffer.Length, SocketFlags.None, New AsyncCallback(AddressOf CallBackReceive), LaSocket)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Socket.vb --> Connect()")
        End Try

    End Sub

    ''' <summary>
    ''' Callback declenché à la deconnexion
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackDisconnect(ByVal async As IAsyncResult)

        Dim LaSocket As Socket = CType(async.AsyncState, Socket)

        LaSocket.EndDisconnect(async)

        RaiseEvent OnDeconnexion(Me, New ElgSocketEventArgs("Deconnexion", LaSocket))

    End Sub

    ''' <summary>
    ''' Callback de reception des données
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackReceive(ByVal async As IAsyncResult)

        Dim LaSocket As Socket = CType(async.AsyncState, Socket)
        Dim read As Integer

        Try
            read = LaSocket.EndReceive(async)
        Catch ex As Exception
            read = -1
            Return
        End Try

        If (read > 0) Then
            Dim chaine As String = ""

            For i = 0 To read
                If (_Buffer(i) = 0) Then
                    RaiseEvent OnReception(Me, New ElgSocketEventArgs(chaine, LaSocket))
                    chaine = ""
                Else
                    chaine &= Chr(_Buffer(i))
                End If
            Next
            Try
                LaSocket.BeginReceive(_Buffer, 0, _Buffer.Length, SocketFlags.None, New AsyncCallback(AddressOf CallBackReceive), LaSocket)
            Catch ex As Exception
            End Try
        End If

    End Sub

    ''' <summary>
    ''' Callback d'envoi des données
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackSender(ByVal async As IAsyncResult)

        Try
            Dim LaSocket As Socket = CType(async.AsyncState, Socket)
            Dim bytesSent As Integer = LaSocket.EndSend(async)

        Catch e As Exception
            RaiseEvent OnErreur(Me, New ElgSocketEventArgs(e.Message))

        End Try

    End Sub

#End Region

#Region "Constructeurs"

    ''' <summary>
    ''' Constructeur par defaut
    ''' </summary>
    ''' <param name="Hote"></param>
    ''' <param name="Port"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Hote As String, ByVal Port As Integer)

        Me._Hote = Hote
        Me._Port = Port

        _Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP)

        Try
            _Socket.BeginConnect(New IPEndPoint(IPAddress.Parse(Hote), Port), New AsyncCallback(AddressOf CallBackConnect), _Socket)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RaiseEvent OnErreur(Me, New ElgSocketEventArgs(ex.Message))

        End Try

    End Sub

#End Region

#Region "IDisposable Support"

    ' Pour détecter les appels redondants
    Private disposedValue As Boolean = False

    ''' <summary>
    ''' IDisposable
    ''' </summary>
    ''' <param name="disposing"></param>
    ''' <remarks></remarks>
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)

        If (Not Me.disposedValue) Then

        End If

        ' Destruction de la socket d'ecoute
        If Me._Socket.Connected Then Me._Socket.Shutdown(SocketShutdown.Both)
        Me._Socket.Close()

        Me.disposedValue = True

    End Sub

    ' Ce code a été ajouté par Visual Basic pour permettre l'implémentation correcte du modèle pouvant être supprimé.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ne modifiez pas ce code. Ajoutez du code de nettoyage dans Dispose(ByVal disposing As Boolean) ci-dessus.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class

