<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.ActionRapideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChargerConnecterTousLesBotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChargerTousLesBotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConencterTousLesBotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopertousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip
        Me.GestionDesComptesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChargerUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifierUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppriemrUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigurationGlobaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigurationGlobaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IntelligenceArtificielleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DofusAccountCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CréateurDePersonnageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Tab = New System.Windows.Forms.TabControl
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenu
        Me.Agrandir = New System.Windows.Forms.MenuItem
        Me.Quitter = New System.Windows.Forms.MenuItem
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActionRapideToolStripMenuItem
        '
        Me.ActionRapideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerConnecterTousLesBotsToolStripMenuItem, Me.ChargerTousLesBotsToolStripMenuItem, Me.ConencterTousLesBotsToolStripMenuItem, Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem, Me.StopertousToolStripMenuItem})
        Me.ActionRapideToolStripMenuItem.Image = CType(resources.GetObject("ActionRapideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActionRapideToolStripMenuItem.Name = "ActionRapideToolStripMenuItem"
        Me.ActionRapideToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ActionRapideToolStripMenuItem.Text = "Ação Rapida"
        '
        'ChargerConnecterTousLesBotsToolStripMenuItem
        '
        Me.ChargerConnecterTousLesBotsToolStripMenuItem.Image = CType(resources.GetObject("ChargerConnecterTousLesBotsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChargerConnecterTousLesBotsToolStripMenuItem.Name = "ChargerConnecterTousLesBotsToolStripMenuItem"
        Me.ChargerConnecterTousLesBotsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ChargerConnecterTousLesBotsToolStripMenuItem.Text = "Carregar é Juntar todos Bot"
        '
        'ChargerTousLesBotsToolStripMenuItem
        '
        Me.ChargerTousLesBotsToolStripMenuItem.Image = CType(resources.GetObject("ChargerTousLesBotsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChargerTousLesBotsToolStripMenuItem.Name = "ChargerTousLesBotsToolStripMenuItem"
        Me.ChargerTousLesBotsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ChargerTousLesBotsToolStripMenuItem.Text = "Carregar Todos bot"
        '
        'ConencterTousLesBotsToolStripMenuItem
        '
        Me.ConencterTousLesBotsToolStripMenuItem.Image = CType(resources.GetObject("ConencterTousLesBotsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConencterTousLesBotsToolStripMenuItem.Name = "ConencterTousLesBotsToolStripMenuItem"
        Me.ConencterTousLesBotsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ConencterTousLesBotsToolStripMenuItem.Text = "Connectar todos bot"
        '
        'DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem
        '
        Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Image = CType(resources.GetObject("DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Name = "DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem"
        Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem.Text = "Combat Solo"
        '
        'StopertousToolStripMenuItem
        '
        Me.StopertousToolStripMenuItem.Image = CType(resources.GetObject("StopertousToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopertousToolStripMenuItem.Name = "StopertousToolStripMenuItem"
        Me.StopertousToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.StopertousToolStripMenuItem.Text = "Parar Combats"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesComptesToolStripMenuItem, Me.ActionRapideToolStripMenuItem, Me.ConfigurationGlobaleToolStripMenuItem, Me.PluginsToolStripMenuItem, Me.SendToTrayToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(690, 24)
        Me.MenuPrincipal.TabIndex = 2
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'GestionDesComptesToolStripMenuItem
        '
        Me.GestionDesComptesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerUnCompteToolStripMenuItem, Me.AjouterUnCompteToolStripMenuItem, Me.ModifierUnCompteToolStripMenuItem, Me.SuppriemrUnCompteToolStripMenuItem})
        Me.GestionDesComptesToolStripMenuItem.Image = CType(resources.GetObject("GestionDesComptesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDesComptesToolStripMenuItem.Name = "GestionDesComptesToolStripMenuItem"
        Me.GestionDesComptesToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.GestionDesComptesToolStripMenuItem.Text = "Gestão de Contas"
        '
        'ChargerUnCompteToolStripMenuItem
        '
        Me.ChargerUnCompteToolStripMenuItem.Image = CType(resources.GetObject("ChargerUnCompteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChargerUnCompteToolStripMenuItem.Name = "ChargerUnCompteToolStripMenuItem"
        Me.ChargerUnCompteToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ChargerUnCompteToolStripMenuItem.Text = "Selecione uma Conta"
        '
        'AjouterUnCompteToolStripMenuItem
        '
        Me.AjouterUnCompteToolStripMenuItem.Image = CType(resources.GetObject("AjouterUnCompteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjouterUnCompteToolStripMenuItem.Name = "AjouterUnCompteToolStripMenuItem"
        Me.AjouterUnCompteToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AjouterUnCompteToolStripMenuItem.Text = "Adc uma conta"
        '
        'ModifierUnCompteToolStripMenuItem
        '
        Me.ModifierUnCompteToolStripMenuItem.Image = CType(resources.GetObject("ModifierUnCompteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifierUnCompteToolStripMenuItem.Name = "ModifierUnCompteToolStripMenuItem"
        Me.ModifierUnCompteToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ModifierUnCompteToolStripMenuItem.Text = "Modifique uma Conta"
        '
        'SuppriemrUnCompteToolStripMenuItem
        '
        Me.SuppriemrUnCompteToolStripMenuItem.Image = CType(resources.GetObject("SuppriemrUnCompteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuppriemrUnCompteToolStripMenuItem.Name = "SuppriemrUnCompteToolStripMenuItem"
        Me.SuppriemrUnCompteToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SuppriemrUnCompteToolStripMenuItem.Text = "Delete uma Conta"
        '
        'ConfigurationGlobaleToolStripMenuItem
        '
        Me.ConfigurationGlobaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationGlobaleToolStripMenuItem1, Me.IntelligenceArtificielleToolStripMenuItem})
        Me.ConfigurationGlobaleToolStripMenuItem.Image = CType(resources.GetObject("ConfigurationGlobaleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfigurationGlobaleToolStripMenuItem.Name = "ConfigurationGlobaleToolStripMenuItem"
        Me.ConfigurationGlobaleToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ConfigurationGlobaleToolStripMenuItem.Text = "Configuração"
        '
        'ConfigurationGlobaleToolStripMenuItem1
        '
        Me.ConfigurationGlobaleToolStripMenuItem1.Image = CType(resources.GetObject("ConfigurationGlobaleToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ConfigurationGlobaleToolStripMenuItem1.Name = "ConfigurationGlobaleToolStripMenuItem1"
        Me.ConfigurationGlobaleToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ConfigurationGlobaleToolStripMenuItem1.Text = "Configuração Global"
        '
        'IntelligenceArtificielleToolStripMenuItem
        '
        Me.IntelligenceArtificielleToolStripMenuItem.Image = CType(resources.GetObject("IntelligenceArtificielleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IntelligenceArtificielleToolStripMenuItem.Name = "IntelligenceArtificielleToolStripMenuItem"
        Me.IntelligenceArtificielleToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.IntelligenceArtificielleToolStripMenuItem.Text = "Inteligencia"
        '
        'PluginsToolStripMenuItem
        '
        Me.PluginsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DofusAccountCreatorToolStripMenuItem, Me.CréateurDePersonnageToolStripMenuItem})
        Me.PluginsToolStripMenuItem.Image = CType(resources.GetObject("PluginsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem"
        Me.PluginsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PluginsToolStripMenuItem.Text = "Plugins"
        '
        'DofusAccountCreatorToolStripMenuItem
        '
        Me.DofusAccountCreatorToolStripMenuItem.Image = CType(resources.GetObject("DofusAccountCreatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DofusAccountCreatorToolStripMenuItem.Name = "DofusAccountCreatorToolStripMenuItem"
        Me.DofusAccountCreatorToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DofusAccountCreatorToolStripMenuItem.Text = "Criar Conta dofus"
        '
        'CréateurDePersonnageToolStripMenuItem
        '
        Me.CréateurDePersonnageToolStripMenuItem.Image = CType(resources.GetObject("CréateurDePersonnageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CréateurDePersonnageToolStripMenuItem.Name = "CréateurDePersonnageToolStripMenuItem"
        Me.CréateurDePersonnageToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CréateurDePersonnageToolStripMenuItem.Text = "Criar um Personagem"
        '
        'SendToTrayToolStripMenuItem
        '
        Me.SendToTrayToolStripMenuItem.Image = CType(resources.GetObject("SendToTrayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendToTrayToolStripMenuItem.Name = "SendToTrayToolStripMenuItem"
        Me.SendToTrayToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.SendToTrayToolStripMenuItem.Text = "Minimizar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Image = CType(resources.GetObject("AideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AideToolStripMenuItem.Text = "Ajuda"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Image = CType(resources.GetObject("AProposToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AProposToolStripMenuItem.Text = "Sobre Nos"
        '
        'Tab
        '
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 24)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(690, 508)
        Me.Tab.TabIndex = 3
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Enabled = True
        Me.TimerRefresh.Interval = 200
        '
        'Tray
        '
        Me.Tray.Icon = CType(resources.GetObject("Tray.Icon"), System.Drawing.Icon)
        '
        'TrayMenu
        '
        Me.TrayMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Agrandir, Me.Quitter})
        '
        'Agrandir
        '
        Me.Agrandir.DefaultItem = True
        Me.Agrandir.Index = 0
        Me.Agrandir.Text = "Agrandir"
        '
        'Quitter
        '
        Me.Quitter.Index = 1
        Me.Quitter.Text = "Quitter"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 532)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(680, 500)
        Me.Name = "Form"
        Me.Text = "ManiacosBR BOTDOFUS [TRADUZIDO POR MANIACO]"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActionRapideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerConnecterTousLesBotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents GestionDesComptesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerUnCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierUnCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppriemrUnCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationGlobaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerTousLesBotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConencterTousLesBotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerRefresh As System.Windows.Forms.Timer
    Friend WithEvents IntelligenceArtificielleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationGlobaleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents Agrandir As System.Windows.Forms.MenuItem
    Friend WithEvents Quitter As System.Windows.Forms.MenuItem
    Friend WithEvents DémarrerDesCombatsSoloAvecTousElsBotsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopertousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PluginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DofusAccountCreatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CréateurDePersonnageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
