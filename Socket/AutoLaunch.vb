Imports System.Threading.Thread

Module AutoLaunch

    Private Delegate Sub ItemDelegate()
    Private Delegate Sub ItemDelegateSolo(ByVal index As Integer)

    Dim idPerso As Integer

    Public Sub AutoLauncher(ByVal index As Integer)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                .TabUtilisateur.Invoke(New ItemDelegateSolo(AddressOf AutoLauncher), index)
            Else
                .TabUtilisateur.ChatBox.AppendText("<BOT> Démarrage des combats automatiques" & vbCrLf)
                .autoLaunch = True
                .LaunchBattle()
                .TimerLaunch.Enabled = True
            End If

        End With

    End Sub

    Public Sub MultiLaunch(ByVal index As Integer)

        idPerso = index
        Dim Thread As New Threading.Thread(AddressOf MultiLauncher)
        Thread.Start()

    End Sub

    Public Sub MultiLauncher()

        With comptes(idPerso)

            If (.TabUtilisateur.InvokeRequired) Then
                .TabUtilisateur.Invoke(New ItemDelegate(AddressOf MultiLauncher))
            Else

                .TabUtilisateur.ChatBox.AppendText("<BOT> Début des invitations" & vbCrLf)

                For i As Integer = 0 To comptes.Count - 1
                    comptes(i).TabUtilisateur.TextChef.Text = "Chef: " & comptes(Form.Tab.SelectedIndex).TabUtilisateur.TextPerso.Text
                    comptes(i).idChef = comptes(Form.Tab.SelectedIndex).monIdDofus
                    comptes(i).nomChef = comptes(Form.Tab.SelectedIndex).monNom
                    comptes(i).joinChef = True

                    wait(200)
                    .sock.Envoyer("PI" & comptes(i).monNom)
                    wait(800)
                Next

                .TabUtilisateur.ChatBox.AppendText("<BOT> Fin des invitations, début des combats" & vbCrLf)
                .autoLaunch = True
                .LaunchBattle()
                .TimerLaunch.Enabled = True

            End If

        End With

    End Sub

    Public Sub StopLaunch(ByVal index As Integer)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                .TabUtilisateur.Invoke(New ItemDelegateSolo(AddressOf StopLaunch), index)
            Else
                .TabUtilisateur.ChatBox.AppendText("<BOT> Fin des combats" & vbCrLf)
                .autoLaunch = False
                .TimerLaunch.Enabled = False
            End If

        End With

    End Sub

    Public Sub StartJoin(ByVal index As Integer)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                .TabUtilisateur.Invoke(New ItemDelegateSolo(AddressOf StartJoin), index)
            Else
                .joinAll = True
                .TabUtilisateur.ChatBox.AppendText("<BOT> Rejointe de tous les combats" & vbCrLf)
            End If

        End With

    End Sub

    Public Sub StopJoin(ByVal index As Integer)

        With comptes(index)

            If (.TabUtilisateur.InvokeRequired) Then
                .TabUtilisateur.Invoke(New ItemDelegateSolo(AddressOf StopJoin), index)
            Else
                .joinAll = False
                .TabUtilisateur.ChatBox.AppendText("<BOT> Fin de la rejointe de tous les combats" & vbCrLf)
            End If

        End With

    End Sub


End Module
