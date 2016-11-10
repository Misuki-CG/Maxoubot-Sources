Public Class FormConfig

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ValidConfig()
    End Sub

    Public Sub ValidConfig()
        versionJeu = Version.Text
        ipServeurLogin = IpLogin.Text
        WriteSettings()
        Me.Close()
    End Sub

    Private Sub FormConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Version.Text = versionJeu
        IpLogin.Text = ipServeurLogin
    End Sub

End Class