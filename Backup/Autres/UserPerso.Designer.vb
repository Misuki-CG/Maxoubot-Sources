<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPerso
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPerso))
        Me.StatBarre = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.Vie = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.Exp = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.Pods = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.Kamas = New System.Windows.Forms.ToolStripTextBox
        Me.MenuPerso = New System.Windows.Forms.MenuStrip
        Me.ConnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeConnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeDéconnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TextPerso = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.TextChef = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.LabelEtat = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel
        Me.LabelStat = New System.Windows.Forms.ToolStripLabel
        Me.DeleteLog = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SendToChat = New System.Windows.Forms.TextBox
        Me.ChatBox = New System.Windows.Forms.RichTextBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupStats = New System.Windows.Forms.GroupBox
        Me.PlusAir = New System.Windows.Forms.Button
        Me.PlusEau = New System.Windows.Forms.Button
        Me.PlusFeu = New System.Windows.Forms.Button
        Me.PlusTerre = New System.Windows.Forms.Button
        Me.PlusSag = New System.Windows.Forms.Button
        Me.PlusVie = New System.Windows.Forms.Button
        Me.StatAir = New System.Windows.Forms.TextBox
        Me.StatEau = New System.Windows.Forms.TextBox
        Me.StatFeu = New System.Windows.Forms.TextBox
        Me.StatTerre = New System.Windows.Forms.TextBox
        Me.StatSag = New System.Windows.Forms.TextBox
        Me.StatVie = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Comp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupSpell = New System.Windows.Forms.GroupBox
        Me.UpSpell = New System.Windows.Forms.Button
        Me.CompSpell = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ListeInventaire = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.DeleteInventaire = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DestroyItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonnerAuChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DétruireObjetAutomatiquementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckAfk = New System.Windows.Forms.CheckBox
        Me.NumericLiaison = New System.Windows.Forms.NumericUpDown
        Me.CheckLiaisonFlood = New System.Windows.Forms.CheckBox
        Me.NivMax = New System.Windows.Forms.TextBox
        Me.NivMin = New System.Windows.Forms.TextBox
        Me.MessageToAdd = New System.Windows.Forms.TextBox
        Me.DelMessageMP = New System.Windows.Forms.Button
        Me.AddMessageMP = New System.Windows.Forms.Button
        Me.ListFloodMP = New System.Windows.Forms.ListView
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.NumFloodMP = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MPFlooder = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Flooder = New System.Windows.Forms.CheckBox
        Me.NumFlood = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TexteFlood = New System.Windows.Forms.TextBox
        Me.Secondes = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.CongigurerLesFinsDePhraseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage14 = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListePrix = New System.Windows.Forms.ListBox
        Me.DelItem = New System.Windows.Forms.Button
        Me.AddItem = New System.Windows.Forms.Button
        Me.ListeObjets = New System.Windows.Forms.ListBox
        Me.NumAchat = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Prix = New System.Windows.Forms.TextBox
        Me.Objets = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Echange = New System.Windows.Forms.CheckBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.BotChanvre = New System.Windows.Forms.CheckBox
        Me.BotBle = New System.Windows.Forms.CheckBox
        Me.BotOrge = New System.Windows.Forms.CheckBox
        Me.BotLin = New System.Windows.Forms.CheckBox
        Me.BotAvoine = New System.Windows.Forms.CheckBox
        Me.BotHoublon = New System.Windows.Forms.CheckBox
        Me.BotMalt = New System.Windows.Forms.CheckBox
        Me.BotRiz = New System.Windows.Forms.CheckBox
        Me.BotSeigle = New System.Windows.Forms.CheckBox
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.BotBambouSacre = New System.Windows.Forms.CheckBox
        Me.BotOrme = New System.Windows.Forms.CheckBox
        Me.BotBombouSombre = New System.Windows.Forms.CheckBox
        Me.BotCharme = New System.Windows.Forms.CheckBox
        Me.BotFrene = New System.Windows.Forms.CheckBox
        Me.BotKaliptus = New System.Windows.Forms.CheckBox
        Me.BotEbene = New System.Windows.Forms.CheckBox
        Me.BotChataignier = New System.Windows.Forms.CheckBox
        Me.BotMerisier = New System.Windows.Forms.CheckBox
        Me.BotNoyer = New System.Windows.Forms.CheckBox
        Me.BotChene = New System.Windows.Forms.CheckBox
        Me.BotBambou = New System.Windows.Forms.CheckBox
        Me.BotIf = New System.Windows.Forms.CheckBox
        Me.BotBombu = New System.Windows.Forms.CheckBox
        Me.BotErable = New System.Windows.Forms.CheckBox
        Me.BotOliviolet = New System.Windows.Forms.CheckBox
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.BotPandouille = New System.Windows.Forms.CheckBox
        Me.BotEdelweiss = New System.Windows.Forms.CheckBox
        Me.BotOrchideeFreyesque = New System.Windows.Forms.CheckBox
        Me.BotMentheSauvage = New System.Windows.Forms.CheckBox
        Me.BotTrefle = New System.Windows.Forms.CheckBox
        Me.BotChanvreAlchi = New System.Windows.Forms.CheckBox
        Me.BotLinAlchi = New System.Windows.Forms.CheckBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.BotDolomite = New System.Windows.Forms.CheckBox
        Me.BotOr = New System.Windows.Forms.CheckBox
        Me.BotBauxite = New System.Windows.Forms.CheckBox
        Me.BotArgent = New System.Windows.Forms.CheckBox
        Me.BotSilicate = New System.Windows.Forms.CheckBox
        Me.BotEtain = New System.Windows.Forms.CheckBox
        Me.BotManganese = New System.Windows.Forms.CheckBox
        Me.BotKobalte = New System.Windows.Forms.CheckBox
        Me.BotBronze = New System.Windows.Forms.CheckBox
        Me.BotCuivre = New System.Windows.Forms.CheckBox
        Me.BotFer = New System.Windows.Forms.CheckBox
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.PoissonsGeantsMer = New System.Windows.Forms.CheckBox
        Me.PoissonsGeantsRiviere = New System.Windows.Forms.CheckBox
        Me.GrosPoissonsMer = New System.Windows.Forms.CheckBox
        Me.GrosPoissonsRiviere = New System.Windows.Forms.CheckBox
        Me.PoissonsMer = New System.Windows.Forms.CheckBox
        Me.PoissonsRiviere = New System.Windows.Forms.CheckBox
        Me.PetitsPoissonsMer = New System.Windows.Forms.CheckBox
        Me.PetitsPoissonsRiviere = New System.Windows.Forms.CheckBox
        Me.ListeRessources = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.ListPlayers = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.ListMonster = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ChangerDeMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeMapHaut = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeMapBas = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeMapGauche = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeMapDroite = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.CoordsMap = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.RejoindreLeChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SendToSock = New System.Windows.Forms.TextBox
        Me.TextLog = New System.Windows.Forms.RichTextBox
        Me.AfficherLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NePasAfficherLeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatBarre.SuspendLayout()
        Me.MenuPerso.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupStats.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSpell.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.DeleteInventaire.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericLiaison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.AfficherLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatBarre
        '
        Me.StatBarre.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatBarre.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.StatBarre.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.Vie, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.Exp, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.Pods, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.Kamas})
        Me.StatBarre.Location = New System.Drawing.Point(0, 436)
        Me.StatBarre.Name = "StatBarre"
        Me.StatBarre.Size = New System.Drawing.Size(652, 25)
        Me.StatBarre.TabIndex = 4
        Me.StatBarre.Text = "StatBarre"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "Vida:"
        '
        'Vie
        '
        Me.Vie.Name = "Vie"
        Me.Vie.Size = New System.Drawing.Size(110, 22)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripLabel3.Text = "Experiencia:"
        '
        'Exp
        '
        Me.Exp.Name = "Exp"
        Me.Exp.Size = New System.Drawing.Size(110, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel4.Text = "Pods :"
        '
        'Pods
        '
        Me.Pods.Name = "Pods"
        Me.Pods.Size = New System.Drawing.Size(110, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel1.Text = "Kamas :"
        '
        'Kamas
        '
        Me.Kamas.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Kamas.Name = "Kamas"
        Me.Kamas.ReadOnly = True
        Me.Kamas.Size = New System.Drawing.Size(90, 25)
        '
        'MenuPerso
        '
        Me.MenuPerso.BackColor = System.Drawing.Color.White
        Me.MenuPerso.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnexionToolStripMenuItem, Me.ToolStripSeparator6, Me.TextPerso, Me.ToolStripSeparator7, Me.TextChef, Me.ToolStripSeparator4, Me.ToolStripLabel5, Me.LabelEtat, Me.ToolStripSeparator5, Me.ToolStripLabel6, Me.LabelStat})
        Me.MenuPerso.Location = New System.Drawing.Point(0, 0)
        Me.MenuPerso.Name = "MenuPerso"
        Me.MenuPerso.Size = New System.Drawing.Size(652, 27)
        Me.MenuPerso.TabIndex = 3
        Me.MenuPerso.Text = "MenuStrip1"
        '
        'ConnexionToolStripMenuItem
        '
        Me.ConnexionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeConnecterToolStripMenuItem, Me.SeDéconnecterToolStripMenuItem})
        Me.ConnexionToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnexionToolStripMenuItem.Image = CType(resources.GetObject("ConnexionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConnexionToolStripMenuItem.Name = "ConnexionToolStripMenuItem"
        Me.ConnexionToolStripMenuItem.Size = New System.Drawing.Size(91, 23)
        Me.ConnexionToolStripMenuItem.Text = "Conecção"
        '
        'SeConnecterToolStripMenuItem
        '
        Me.SeConnecterToolStripMenuItem.Image = CType(resources.GetObject("SeConnecterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeConnecterToolStripMenuItem.Name = "SeConnecterToolStripMenuItem"
        Me.SeConnecterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SeConnecterToolStripMenuItem.Text = "Se Conectar"
        '
        'SeDéconnecterToolStripMenuItem
        '
        Me.SeDéconnecterToolStripMenuItem.Enabled = False
        Me.SeDéconnecterToolStripMenuItem.Image = CType(resources.GetObject("SeDéconnecterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeDéconnecterToolStripMenuItem.Name = "SeDéconnecterToolStripMenuItem"
        Me.SeDéconnecterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SeDéconnecterToolStripMenuItem.Text = "Se Desconctar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 23)
        '
        'TextPerso
        '
        Me.TextPerso.BackColor = System.Drawing.Color.White
        Me.TextPerso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPerso.Name = "TextPerso"
        Me.TextPerso.ReadOnly = True
        Me.TextPerso.Size = New System.Drawing.Size(90, 23)
        Me.TextPerso.Text = "Personagem"
        Me.TextPerso.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 23)
        '
        'TextChef
        '
        Me.TextChef.BackColor = System.Drawing.Color.White
        Me.TextChef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextChef.Name = "TextChef"
        Me.TextChef.ReadOnly = True
        Me.TextChef.Size = New System.Drawing.Size(100, 23)
        Me.TextChef.Text = "Nenhum Lider"
        Me.TextChef.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(31, 20)
        Me.ToolStripLabel5.Text = "Info:"
        '
        'LabelEtat
        '
        Me.LabelEtat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEtat.ForeColor = System.Drawing.Color.Red
        Me.LabelEtat.Name = "LabelEtat"
        Me.LabelEtat.Size = New System.Drawing.Size(89, 20)
        Me.LabelEtat.Text = "Desconectado"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripLabel6.Text = "Status :"
        '
        'LabelStat
        '
        Me.LabelStat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStat.ForeColor = System.Drawing.Color.Red
        Me.LabelStat.Name = "LabelStat"
        Me.LabelStat.Size = New System.Drawing.Size(82, 20)
        Me.LabelStat.Text = "Desconctado"
        '
        'DeleteLog
        '
        Me.DeleteLog.Enabled = True
        Me.DeleteLog.Interval = 60000
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage14)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(652, 409)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(644, 380)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SendToChat)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ChatBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(638, 374)
        Me.SplitContainer2.SplitterDistance = 446
        Me.SplitContainer2.TabIndex = 0
        '
        'SendToChat
        '
        Me.SendToChat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendToChat.Location = New System.Drawing.Point(0, 351)
        Me.SendToChat.Name = "SendToChat"
        Me.SendToChat.Size = New System.Drawing.Size(443, 20)
        Me.SendToChat.TabIndex = 0
        '
        'ChatBox
        '
        Me.ChatBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatBox.BackColor = System.Drawing.Color.White
        Me.ChatBox.Location = New System.Drawing.Point(0, 0)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.ReadOnly = True
        Me.ChatBox.Size = New System.Drawing.Size(443, 345)
        Me.ChatBox.TabIndex = 0
        Me.ChatBox.Text = ""
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupStats)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupSpell)
        Me.SplitContainer3.Size = New System.Drawing.Size(188, 374)
        Me.SplitContainer3.SplitterDistance = 278
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupStats
        '
        Me.GroupStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupStats.Controls.Add(Me.PlusAir)
        Me.GroupStats.Controls.Add(Me.PlusEau)
        Me.GroupStats.Controls.Add(Me.PlusFeu)
        Me.GroupStats.Controls.Add(Me.PlusTerre)
        Me.GroupStats.Controls.Add(Me.PlusSag)
        Me.GroupStats.Controls.Add(Me.PlusVie)
        Me.GroupStats.Controls.Add(Me.StatAir)
        Me.GroupStats.Controls.Add(Me.StatEau)
        Me.GroupStats.Controls.Add(Me.StatFeu)
        Me.GroupStats.Controls.Add(Me.StatTerre)
        Me.GroupStats.Controls.Add(Me.StatSag)
        Me.GroupStats.Controls.Add(Me.StatVie)
        Me.GroupStats.Controls.Add(Me.PictureBox1)
        Me.GroupStats.Controls.Add(Me.Comp)
        Me.GroupStats.Controls.Add(Me.Label1)
        Me.GroupStats.Location = New System.Drawing.Point(0, 0)
        Me.GroupStats.Name = "GroupStats"
        Me.GroupStats.Size = New System.Drawing.Size(185, 275)
        Me.GroupStats.TabIndex = 10
        Me.GroupStats.TabStop = False
        Me.GroupStats.Text = "Caracteristicas"
        '
        'PlusAir
        '
        Me.PlusAir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusAir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusAir.Location = New System.Drawing.Point(157, 208)
        Me.PlusAir.Name = "PlusAir"
        Me.PlusAir.Size = New System.Drawing.Size(19, 20)
        Me.PlusAir.TabIndex = 15
        Me.PlusAir.Text = "+"
        Me.PlusAir.UseVisualStyleBackColor = True
        '
        'PlusEau
        '
        Me.PlusEau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusEau.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusEau.Location = New System.Drawing.Point(157, 177)
        Me.PlusEau.Name = "PlusEau"
        Me.PlusEau.Size = New System.Drawing.Size(19, 20)
        Me.PlusEau.TabIndex = 14
        Me.PlusEau.Text = "+"
        Me.PlusEau.UseVisualStyleBackColor = True
        '
        'PlusFeu
        '
        Me.PlusFeu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusFeu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusFeu.Location = New System.Drawing.Point(157, 146)
        Me.PlusFeu.Name = "PlusFeu"
        Me.PlusFeu.Size = New System.Drawing.Size(19, 20)
        Me.PlusFeu.TabIndex = 13
        Me.PlusFeu.Text = "+"
        Me.PlusFeu.UseVisualStyleBackColor = True
        '
        'PlusTerre
        '
        Me.PlusTerre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusTerre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusTerre.Location = New System.Drawing.Point(157, 115)
        Me.PlusTerre.Name = "PlusTerre"
        Me.PlusTerre.Size = New System.Drawing.Size(19, 20)
        Me.PlusTerre.TabIndex = 12
        Me.PlusTerre.Text = "+"
        Me.PlusTerre.UseVisualStyleBackColor = True
        '
        'PlusSag
        '
        Me.PlusSag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusSag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusSag.Location = New System.Drawing.Point(157, 84)
        Me.PlusSag.Name = "PlusSag"
        Me.PlusSag.Size = New System.Drawing.Size(19, 20)
        Me.PlusSag.TabIndex = 11
        Me.PlusSag.Text = "+"
        Me.PlusSag.UseVisualStyleBackColor = True
        '
        'PlusVie
        '
        Me.PlusVie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusVie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusVie.Location = New System.Drawing.Point(157, 52)
        Me.PlusVie.Name = "PlusVie"
        Me.PlusVie.Size = New System.Drawing.Size(19, 20)
        Me.PlusVie.TabIndex = 10
        Me.PlusVie.Text = "+"
        Me.PlusVie.UseVisualStyleBackColor = True
        '
        'StatAir
        '
        Me.StatAir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatAir.BackColor = System.Drawing.Color.White
        Me.StatAir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatAir.Location = New System.Drawing.Point(106, 208)
        Me.StatAir.Name = "StatAir"
        Me.StatAir.ReadOnly = True
        Me.StatAir.Size = New System.Drawing.Size(44, 20)
        Me.StatAir.TabIndex = 9
        Me.StatAir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatEau
        '
        Me.StatEau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatEau.BackColor = System.Drawing.Color.White
        Me.StatEau.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatEau.Location = New System.Drawing.Point(106, 177)
        Me.StatEau.Name = "StatEau"
        Me.StatEau.ReadOnly = True
        Me.StatEau.Size = New System.Drawing.Size(44, 20)
        Me.StatEau.TabIndex = 8
        Me.StatEau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatFeu
        '
        Me.StatFeu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatFeu.BackColor = System.Drawing.Color.White
        Me.StatFeu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatFeu.Location = New System.Drawing.Point(106, 146)
        Me.StatFeu.Name = "StatFeu"
        Me.StatFeu.ReadOnly = True
        Me.StatFeu.Size = New System.Drawing.Size(44, 20)
        Me.StatFeu.TabIndex = 7
        Me.StatFeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatTerre
        '
        Me.StatTerre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatTerre.BackColor = System.Drawing.Color.White
        Me.StatTerre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatTerre.Location = New System.Drawing.Point(106, 115)
        Me.StatTerre.Name = "StatTerre"
        Me.StatTerre.ReadOnly = True
        Me.StatTerre.Size = New System.Drawing.Size(44, 20)
        Me.StatTerre.TabIndex = 6
        Me.StatTerre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatSag
        '
        Me.StatSag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatSag.BackColor = System.Drawing.Color.White
        Me.StatSag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatSag.Location = New System.Drawing.Point(106, 84)
        Me.StatSag.Name = "StatSag"
        Me.StatSag.ReadOnly = True
        Me.StatSag.Size = New System.Drawing.Size(44, 20)
        Me.StatSag.TabIndex = 5
        Me.StatSag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatVie
        '
        Me.StatVie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatVie.BackColor = System.Drawing.Color.White
        Me.StatVie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatVie.Location = New System.Drawing.Point(106, 52)
        Me.StatVie.Name = "StatVie"
        Me.StatVie.ReadOnly = True
        Me.StatVie.Size = New System.Drawing.Size(44, 20)
        Me.StatVie.TabIndex = 4
        Me.StatVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 185)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Comp
        '
        Me.Comp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comp.BackColor = System.Drawing.Color.White
        Me.Comp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp.Location = New System.Drawing.Point(106, 20)
        Me.Comp.Name = "Comp"
        Me.Comp.ReadOnly = True
        Me.Comp.Size = New System.Drawing.Size(44, 20)
        Me.Comp.TabIndex = 2
        Me.Comp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Capital :"
        '
        'GroupSpell
        '
        Me.GroupSpell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupSpell.Controls.Add(Me.UpSpell)
        Me.GroupSpell.Controls.Add(Me.CompSpell)
        Me.GroupSpell.Controls.Add(Me.Label2)
        Me.GroupSpell.Location = New System.Drawing.Point(0, -1)
        Me.GroupSpell.Name = "GroupSpell"
        Me.GroupSpell.Size = New System.Drawing.Size(185, 93)
        Me.GroupSpell.TabIndex = 0
        Me.GroupSpell.TabStop = False
        Me.GroupSpell.Text = "Sort"
        '
        'UpSpell
        '
        Me.UpSpell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpSpell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpSpell.Location = New System.Drawing.Point(156, 24)
        Me.UpSpell.Name = "UpSpell"
        Me.UpSpell.Size = New System.Drawing.Size(19, 20)
        Me.UpSpell.TabIndex = 16
        Me.UpSpell.Text = "+"
        Me.UpSpell.UseVisualStyleBackColor = True
        '
        'CompSpell
        '
        Me.CompSpell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompSpell.BackColor = System.Drawing.Color.White
        Me.CompSpell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompSpell.Location = New System.Drawing.Point(106, 25)
        Me.CompSpell.Name = "CompSpell"
        Me.CompSpell.ReadOnly = True
        Me.CompSpell.Size = New System.Drawing.Size(44, 20)
        Me.CompSpell.TabIndex = 17
        Me.CompSpell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Capital Magias:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListeInventaire)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(644, 380)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Inventario"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListeInventaire
        '
        Me.ListeInventaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListeInventaire.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.ListeInventaire.ContextMenuStrip = Me.DeleteInventaire
        Me.ListeInventaire.FullRowSelect = True
        Me.ListeInventaire.Location = New System.Drawing.Point(3, 3)
        Me.ListeInventaire.Name = "ListeInventaire"
        Me.ListeInventaire.Size = New System.Drawing.Size(631, 377)
        Me.ListeInventaire.TabIndex = 0
        Me.ListeInventaire.UseCompatibleStateImageBehavior = False
        Me.ListeInventaire.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID Objeto"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Objetos"
        Me.ColumnHeader1.Width = 133
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantidade"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID do inventsrio"
        Me.ColumnHeader4.Width = 91
        '
        'DeleteInventaire
        '
        Me.DeleteInventaire.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestroyItemToolStripMenuItem, Me.DonnerAuChefToolStripMenuItem, Me.DétruireObjetAutomatiquementToolStripMenuItem})
        Me.DeleteInventaire.Name = "ContextMenuStrip1"
        Me.DeleteInventaire.Size = New System.Drawing.Size(268, 70)
        '
        'DestroyItemToolStripMenuItem
        '
        Me.DestroyItemToolStripMenuItem.Image = CType(resources.GetObject("DestroyItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DestroyItemToolStripMenuItem.Name = "DestroyItemToolStripMenuItem"
        Me.DestroyItemToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.DestroyItemToolStripMenuItem.Text = "Détruire l'objet"
        '
        'DonnerAuChefToolStripMenuItem
        '
        Me.DonnerAuChefToolStripMenuItem.Image = CType(resources.GetObject("DonnerAuChefToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DonnerAuChefToolStripMenuItem.Name = "DonnerAuChefToolStripMenuItem"
        Me.DonnerAuChefToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.DonnerAuChefToolStripMenuItem.Text = "Donner au chef"
        '
        'DétruireObjetAutomatiquementToolStripMenuItem
        '
        Me.DétruireObjetAutomatiquementToolStripMenuItem.CheckOnClick = True
        Me.DétruireObjetAutomatiquementToolStripMenuItem.Name = "DétruireObjetAutomatiquementToolStripMenuItem"
        Me.DétruireObjetAutomatiquementToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.DétruireObjetAutomatiquementToolStripMenuItem.Text = "Détruire objet automatiquement"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.MenuStrip2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(644, 380)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Flood"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckAfk)
        Me.GroupBox2.Controls.Add(Me.NumericLiaison)
        Me.GroupBox2.Controls.Add(Me.CheckLiaisonFlood)
        Me.GroupBox2.Controls.Add(Me.NivMax)
        Me.GroupBox2.Controls.Add(Me.NivMin)
        Me.GroupBox2.Controls.Add(Me.MessageToAdd)
        Me.GroupBox2.Controls.Add(Me.DelMessageMP)
        Me.GroupBox2.Controls.Add(Me.AddMessageMP)
        Me.GroupBox2.Controls.Add(Me.ListFloodMP)
        Me.GroupBox2.Controls.Add(Me.NumFloodMP)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.MPFlooder)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 226)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Canal Privado:"
        '
        'CheckAfk
        '
        Me.CheckAfk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckAfk.AutoSize = True
        Me.CheckAfk.Location = New System.Drawing.Point(430, 120)
        Me.CheckAfk.Name = "CheckAfk"
        Me.CheckAfk.Size = New System.Drawing.Size(92, 17)
        Me.CheckAfk.TabIndex = 85
        Me.CheckAfk.Text = "Ativar Anti-afk"
        Me.CheckAfk.UseVisualStyleBackColor = True
        '
        'NumericLiaison
        '
        Me.NumericLiaison.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericLiaison.Location = New System.Drawing.Point(558, 117)
        Me.NumericLiaison.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericLiaison.Name = "NumericLiaison"
        Me.NumericLiaison.Size = New System.Drawing.Size(40, 20)
        Me.NumericLiaison.TabIndex = 84
        Me.NumericLiaison.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckLiaisonFlood
        '
        Me.CheckLiaisonFlood.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckLiaisonFlood.AutoSize = True
        Me.CheckLiaisonFlood.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckLiaisonFlood.Location = New System.Drawing.Point(430, 79)
        Me.CheckLiaisonFlood.Name = "CheckLiaisonFlood"
        Me.CheckLiaisonFlood.Size = New System.Drawing.Size(187, 18)
        Me.CheckLiaisonFlood.TabIndex = 83
        Me.CheckLiaisonFlood.Text = "Enviar mensagens com outro bot "
        Me.CheckLiaisonFlood.UseVisualStyleBackColor = True
        '
        'NivMax
        '
        Me.NivMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NivMax.Location = New System.Drawing.Point(304, 185)
        Me.NivMax.Name = "NivMax"
        Me.NivMax.Size = New System.Drawing.Size(43, 20)
        Me.NivMax.TabIndex = 82
        Me.NivMax.Text = "200"
        Me.NivMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NivMin
        '
        Me.NivMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NivMin.Location = New System.Drawing.Point(254, 185)
        Me.NivMin.Name = "NivMin"
        Me.NivMin.Size = New System.Drawing.Size(44, 20)
        Me.NivMin.TabIndex = 81
        Me.NivMin.Text = "1"
        Me.NivMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MessageToAdd
        '
        Me.MessageToAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageToAdd.Location = New System.Drawing.Point(17, 185)
        Me.MessageToAdd.Name = "MessageToAdd"
        Me.MessageToAdd.Size = New System.Drawing.Size(231, 20)
        Me.MessageToAdd.TabIndex = 80
        Me.MessageToAdd.Text = "Salut %nom% ! Tu es %alignement% %level% !"
        '
        'DelMessageMP
        '
        Me.DelMessageMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelMessageMP.Enabled = False
        Me.DelMessageMP.Location = New System.Drawing.Point(423, 182)
        Me.DelMessageMP.Name = "DelMessageMP"
        Me.DelMessageMP.Size = New System.Drawing.Size(67, 21)
        Me.DelMessageMP.TabIndex = 79
        Me.DelMessageMP.Text = "Parar"
        Me.DelMessageMP.UseVisualStyleBackColor = True
        '
        'AddMessageMP
        '
        Me.AddMessageMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddMessageMP.Location = New System.Drawing.Point(357, 183)
        Me.AddMessageMP.Name = "AddMessageMP"
        Me.AddMessageMP.Size = New System.Drawing.Size(60, 21)
        Me.AddMessageMP.TabIndex = 78
        Me.AddMessageMP.Text = "Começar"
        Me.AddMessageMP.UseVisualStyleBackColor = True
        '
        'ListFloodMP
        '
        Me.ListFloodMP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListFloodMP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.ListFloodMP.ContextMenuStrip = Me.DeleteInventaire
        Me.ListFloodMP.FullRowSelect = True
        Me.ListFloodMP.Location = New System.Drawing.Point(17, 23)
        Me.ListFloodMP.Name = "ListFloodMP"
        Me.ListFloodMP.Size = New System.Drawing.Size(400, 156)
        Me.ListFloodMP.TabIndex = 71
        Me.ListFloodMP.UseCompatibleStateImageBehavior = False
        Me.ListFloodMP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Menssagens"
        Me.ColumnHeader19.Width = 222
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Niv. Min"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Niv. Max"
        '
        'NumFloodMP
        '
        Me.NumFloodMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumFloodMP.AutoSize = True
        Me.NumFloodMP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFloodMP.ForeColor = System.Drawing.Color.Black
        Me.NumFloodMP.Location = New System.Drawing.Point(533, 62)
        Me.NumFloodMP.Name = "NumFloodMP"
        Me.NumFloodMP.Size = New System.Drawing.Size(13, 14)
        Me.NumFloodMP.TabIndex = 70
        Me.NumFloodMP.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(433, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Numero de Envio:"
        '
        'MPFlooder
        '
        Me.MPFlooder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MPFlooder.AutoSize = True
        Me.MPFlooder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPFlooder.Location = New System.Drawing.Point(430, 41)
        Me.MPFlooder.Name = "MPFlooder"
        Me.MPFlooder.Size = New System.Drawing.Size(116, 18)
        Me.MPFlooder.TabIndex = 68
        Me.MPFlooder.Text = "Ativar flood em PM"
        Me.MPFlooder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Flooder)
        Me.GroupBox1.Controls.Add(Me.NumFlood)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TexteFlood)
        Me.GroupBox1.Controls.Add(Me.Secondes)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 113)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Canaux de base"
        '
        'Flooder
        '
        Me.Flooder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Flooder.AutoSize = True
        Me.Flooder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flooder.Location = New System.Drawing.Point(442, 43)
        Me.Flooder.Name = "Flooder"
        Me.Flooder.Size = New System.Drawing.Size(84, 18)
        Me.Flooder.TabIndex = 65
        Me.Flooder.Text = "Ativar Flood"
        Me.Flooder.UseVisualStyleBackColor = True
        '
        'NumFlood
        '
        Me.NumFlood.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumFlood.AutoSize = True
        Me.NumFlood.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFlood.ForeColor = System.Drawing.Color.Black
        Me.NumFlood.Location = New System.Drawing.Point(551, 64)
        Me.NumFlood.Name = "NumFlood"
        Me.NumFlood.Size = New System.Drawing.Size(13, 14)
        Me.NumFlood.TabIndex = 64
        Me.NumFlood.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(435, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 14)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Numero de Envio :"
        '
        'TexteFlood
        '
        Me.TexteFlood.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TexteFlood.BackColor = System.Drawing.Color.White
        Me.TexteFlood.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexteFlood.Location = New System.Drawing.Point(72, 53)
        Me.TexteFlood.Name = "TexteFlood"
        Me.TexteFlood.Size = New System.Drawing.Size(167, 20)
        Me.TexteFlood.TabIndex = 62
        Me.TexteFlood.Text = "Achete laine 20k/u !"
        '
        'Secondes
        '
        Me.Secondes.BackColor = System.Drawing.Color.White
        Me.Secondes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secondes.Location = New System.Drawing.Point(72, 24)
        Me.Secondes.Name = "Secondes"
        Me.Secondes.Size = New System.Drawing.Size(32, 20)
        Me.Secondes.TabIndex = 61
        Me.Secondes.Text = "10"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 70)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Todos os                secondes," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "envoyer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en canal général."
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.White
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CongigurerLesFinsDePhraseToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip2.TabIndex = 73
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CongigurerLesFinsDePhraseToolStripMenuItem
        '
        Me.CongigurerLesFinsDePhraseToolStripMenuItem.Name = "CongigurerLesFinsDePhraseToolStripMenuItem"
        Me.CongigurerLesFinsDePhraseToolStripMenuItem.Size = New System.Drawing.Size(171, 20)
        Me.CongigurerLesFinsDePhraseToolStripMenuItem.Text = "Configure para a sentença"
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.Label4)
        Me.TabPage14.Controls.Add(Me.ListePrix)
        Me.TabPage14.Controls.Add(Me.DelItem)
        Me.TabPage14.Controls.Add(Me.AddItem)
        Me.TabPage14.Controls.Add(Me.ListeObjets)
        Me.TabPage14.Controls.Add(Me.NumAchat)
        Me.TabPage14.Controls.Add(Me.Label31)
        Me.TabPage14.Controls.Add(Me.Prix)
        Me.TabPage14.Controls.Add(Me.Objets)
        Me.TabPage14.Controls.Add(Me.Label29)
        Me.TabPage14.Controls.Add(Me.Label28)
        Me.TabPage14.Controls.Add(Me.Echange)
        Me.TabPage14.Location = New System.Drawing.Point(4, 25)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Size = New System.Drawing.Size(644, 380)
        Me.TabPage14.TabIndex = 6
        Me.TabPage14.Text = "Comprar"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Kamas/Unidade"
        '
        'ListePrix
        '
        Me.ListePrix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListePrix.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ListePrix.FormattingEnabled = True
        Me.ListePrix.Items.AddRange(New Object() {"Lista Prix"})
        Me.ListePrix.Location = New System.Drawing.Point(243, 46)
        Me.ListePrix.Name = "ListePrix"
        Me.ListePrix.Size = New System.Drawing.Size(51, 108)
        Me.ListePrix.TabIndex = 78
        '
        'DelItem
        '
        Me.DelItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelItem.Location = New System.Drawing.Point(262, 172)
        Me.DelItem.Name = "DelItem"
        Me.DelItem.Size = New System.Drawing.Size(67, 21)
        Me.DelItem.TabIndex = 77
        Me.DelItem.Text = "Parar"
        Me.DelItem.UseVisualStyleBackColor = True
        '
        'AddItem
        '
        Me.AddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddItem.Location = New System.Drawing.Point(196, 172)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(60, 21)
        Me.AddItem.TabIndex = 76
        Me.AddItem.Text = "Começar"
        Me.AddItem.UseVisualStyleBackColor = True
        '
        'ListeObjets
        '
        Me.ListeObjets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListeObjets.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ListeObjets.FormattingEnabled = True
        Me.ListeObjets.Items.AddRange(New Object() {"Listaobjetos"})
        Me.ListeObjets.Location = New System.Drawing.Point(15, 46)
        Me.ListeObjets.Name = "ListeObjets"
        Me.ListeObjets.Size = New System.Drawing.Size(222, 108)
        Me.ListeObjets.TabIndex = 75
        '
        'NumAchat
        '
        Me.NumAchat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumAchat.AutoSize = True
        Me.NumAchat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumAchat.ForeColor = System.Drawing.Color.Black
        Me.NumAchat.Location = New System.Drawing.Point(585, 100)
        Me.NumAchat.Name = "NumAchat"
        Me.NumAchat.Size = New System.Drawing.Size(13, 14)
        Me.NumAchat.TabIndex = 74
        Me.NumAchat.Text = "0"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(449, 100)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(130, 14)
        Me.Label31.TabIndex = 73
        Me.Label31.Text = "Numeros de Menssagens"
        '
        'Prix
        '
        Me.Prix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Prix.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Prix.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prix.Location = New System.Drawing.Point(75, 200)
        Me.Prix.Name = "Prix"
        Me.Prix.Size = New System.Drawing.Size(48, 20)
        Me.Prix.TabIndex = 72
        Me.Prix.Text = "10"
        '
        'Objets
        '
        Me.Objets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Objets.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Objets.ForeColor = System.Drawing.Color.Black
        Me.Objets.FormattingEnabled = True
        Me.Objets.Location = New System.Drawing.Point(15, 172)
        Me.Objets.Name = "Objets"
        Me.Objets.Size = New System.Drawing.Size(175, 21)
        Me.Objets.TabIndex = 70
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(3, 203)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 14)
        Me.Label29.TabIndex = 71
        Me.Label29.Text = "Ajustar Preço"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(17, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 14)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Lista de Objetos:"
        '
        'Echange
        '
        Me.Echange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Echange.AutoSize = True
        Me.Echange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Echange.Location = New System.Drawing.Point(483, 70)
        Me.Echange.Name = "Echange"
        Me.Echange.Size = New System.Drawing.Size(80, 18)
        Me.Echange.TabIndex = 68
        Me.Echange.Text = "Ativar Chat"
        Me.Echange.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TabControl2)
        Me.TabPage5.Controls.Add(Me.ListeRessources)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(644, 380)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Colheita"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(302, 11)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(333, 359)
        Me.TabControl2.TabIndex = 22
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.BotChanvre)
        Me.TabPage8.Controls.Add(Me.BotBle)
        Me.TabPage8.Controls.Add(Me.BotOrge)
        Me.TabPage8.Controls.Add(Me.BotLin)
        Me.TabPage8.Controls.Add(Me.BotAvoine)
        Me.TabPage8.Controls.Add(Me.BotHoublon)
        Me.TabPage8.Controls.Add(Me.BotMalt)
        Me.TabPage8.Controls.Add(Me.BotRiz)
        Me.TabPage8.Controls.Add(Me.BotSeigle)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(325, 330)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Campones"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'BotChanvre
        '
        Me.BotChanvre.AutoSize = True
        Me.BotChanvre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotChanvre.Location = New System.Drawing.Point(18, 224)
        Me.BotChanvre.Name = "BotChanvre"
        Me.BotChanvre.Size = New System.Drawing.Size(108, 20)
        Me.BotChanvre.TabIndex = 18
        Me.BotChanvre.Text = "Bot Canhamo"
        Me.BotChanvre.UseVisualStyleBackColor = True
        '
        'BotBle
        '
        Me.BotBle.AutoSize = True
        Me.BotBle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBle.Location = New System.Drawing.Point(18, 16)
        Me.BotBle.Name = "BotBle"
        Me.BotBle.Size = New System.Drawing.Size(82, 20)
        Me.BotBle.TabIndex = 2
        Me.BotBle.Text = "Bot Trigo"
        Me.BotBle.UseVisualStyleBackColor = True
        '
        'BotOrge
        '
        Me.BotOrge.AutoSize = True
        Me.BotOrge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotOrge.Location = New System.Drawing.Point(18, 42)
        Me.BotOrge.Name = "BotOrge"
        Me.BotOrge.Size = New System.Drawing.Size(98, 20)
        Me.BotOrge.TabIndex = 3
        Me.BotOrge.Text = "Bot Cevada"
        Me.BotOrge.UseVisualStyleBackColor = True
        '
        'BotLin
        '
        Me.BotLin.AutoSize = True
        Me.BotLin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotLin.Location = New System.Drawing.Point(18, 120)
        Me.BotLin.Name = "BotLin"
        Me.BotLin.Size = New System.Drawing.Size(82, 20)
        Me.BotLin.TabIndex = 17
        Me.BotLin.Text = "Bot Linho"
        Me.BotLin.UseVisualStyleBackColor = True
        '
        'BotAvoine
        '
        Me.BotAvoine.AutoSize = True
        Me.BotAvoine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotAvoine.Location = New System.Drawing.Point(18, 68)
        Me.BotAvoine.Name = "BotAvoine"
        Me.BotAvoine.Size = New System.Drawing.Size(85, 20)
        Me.BotAvoine.TabIndex = 4
        Me.BotAvoine.Text = "Bot Aveia"
        Me.BotAvoine.UseVisualStyleBackColor = True
        '
        'BotHoublon
        '
        Me.BotHoublon.AutoSize = True
        Me.BotHoublon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotHoublon.Location = New System.Drawing.Point(18, 94)
        Me.BotHoublon.Name = "BotHoublon"
        Me.BotHoublon.Size = New System.Drawing.Size(81, 20)
        Me.BotHoublon.TabIndex = 6
        Me.BotHoublon.Text = "Bot Salto"
        Me.BotHoublon.UseVisualStyleBackColor = True
        '
        'BotMalt
        '
        Me.BotMalt.AutoSize = True
        Me.BotMalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotMalt.Location = New System.Drawing.Point(18, 198)
        Me.BotMalt.Name = "BotMalt"
        Me.BotMalt.Size = New System.Drawing.Size(75, 20)
        Me.BotMalt.TabIndex = 7
        Me.BotMalt.Text = "Bot Malt"
        Me.BotMalt.UseVisualStyleBackColor = True
        '
        'BotRiz
        '
        Me.BotRiz.AutoSize = True
        Me.BotRiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotRiz.Location = New System.Drawing.Point(18, 146)
        Me.BotRiz.Name = "BotRiz"
        Me.BotRiz.Size = New System.Drawing.Size(81, 20)
        Me.BotRiz.TabIndex = 15
        Me.BotRiz.Text = "Bot Arroz"
        Me.BotRiz.UseVisualStyleBackColor = True
        '
        'BotSeigle
        '
        Me.BotSeigle.AutoSize = True
        Me.BotSeigle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotSeigle.Location = New System.Drawing.Point(18, 172)
        Me.BotSeigle.Name = "BotSeigle"
        Me.BotSeigle.Size = New System.Drawing.Size(96, 20)
        Me.BotSeigle.TabIndex = 5
        Me.BotSeigle.Text = "Bot Centeio"
        Me.BotSeigle.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.BotBambouSacre)
        Me.TabPage9.Controls.Add(Me.BotOrme)
        Me.TabPage9.Controls.Add(Me.BotBombouSombre)
        Me.TabPage9.Controls.Add(Me.BotCharme)
        Me.TabPage9.Controls.Add(Me.BotFrene)
        Me.TabPage9.Controls.Add(Me.BotKaliptus)
        Me.TabPage9.Controls.Add(Me.BotEbene)
        Me.TabPage9.Controls.Add(Me.BotChataignier)
        Me.TabPage9.Controls.Add(Me.BotMerisier)
        Me.TabPage9.Controls.Add(Me.BotNoyer)
        Me.TabPage9.Controls.Add(Me.BotChene)
        Me.TabPage9.Controls.Add(Me.BotBambou)
        Me.TabPage9.Controls.Add(Me.BotIf)
        Me.TabPage9.Controls.Add(Me.BotBombu)
        Me.TabPage9.Controls.Add(Me.BotErable)
        Me.TabPage9.Controls.Add(Me.BotOliviolet)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(325, 330)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "Bûcheron"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'BotBambouSacre
        '
        Me.BotBambouSacre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotBambouSacre.AutoSize = True
        Me.BotBambouSacre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBambouSacre.Location = New System.Drawing.Point(158, 146)
        Me.BotBambouSacre.Name = "BotBambouSacre"
        Me.BotBambouSacre.Size = New System.Drawing.Size(140, 20)
        Me.BotBambouSacre.TabIndex = 25
        Me.BotBambouSacre.Text = "Bot Bambou Sacré"
        Me.BotBambouSacre.UseVisualStyleBackColor = True
        '
        'BotOrme
        '
        Me.BotOrme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotOrme.AutoSize = True
        Me.BotOrme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotOrme.Location = New System.Drawing.Point(158, 120)
        Me.BotOrme.Name = "BotOrme"
        Me.BotOrme.Size = New System.Drawing.Size(83, 20)
        Me.BotOrme.TabIndex = 24
        Me.BotOrme.Text = "Bot Orme"
        Me.BotOrme.UseVisualStyleBackColor = True
        '
        'BotBombouSombre
        '
        Me.BotBombouSombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotBombouSombre.AutoSize = True
        Me.BotBombouSombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBombouSombre.Location = New System.Drawing.Point(158, 94)
        Me.BotBombouSombre.Name = "BotBombouSombre"
        Me.BotBombouSombre.Size = New System.Drawing.Size(152, 20)
        Me.BotBombouSombre.TabIndex = 23
        Me.BotBombouSombre.Text = "Bot Bambou Sombre"
        Me.BotBombouSombre.UseVisualStyleBackColor = True
        '
        'BotCharme
        '
        Me.BotCharme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotCharme.AutoSize = True
        Me.BotCharme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotCharme.Location = New System.Drawing.Point(158, 68)
        Me.BotCharme.Name = "BotCharme"
        Me.BotCharme.Size = New System.Drawing.Size(97, 20)
        Me.BotCharme.TabIndex = 22
        Me.BotCharme.Text = "Bot Charme"
        Me.BotCharme.UseVisualStyleBackColor = True
        '
        'BotFrene
        '
        Me.BotFrene.AutoSize = True
        Me.BotFrene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotFrene.Location = New System.Drawing.Point(18, 16)
        Me.BotFrene.Name = "BotFrene"
        Me.BotFrene.Size = New System.Drawing.Size(85, 20)
        Me.BotFrene.TabIndex = 8
        Me.BotFrene.Text = "Bot Frêne"
        Me.BotFrene.UseVisualStyleBackColor = True
        '
        'BotKaliptus
        '
        Me.BotKaliptus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotKaliptus.AutoSize = True
        Me.BotKaliptus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotKaliptus.Location = New System.Drawing.Point(158, 42)
        Me.BotKaliptus.Name = "BotKaliptus"
        Me.BotKaliptus.Size = New System.Drawing.Size(97, 20)
        Me.BotKaliptus.TabIndex = 21
        Me.BotKaliptus.Text = "Bot Kaliptus"
        Me.BotKaliptus.UseVisualStyleBackColor = True
        '
        'BotEbene
        '
        Me.BotEbene.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotEbene.AutoSize = True
        Me.BotEbene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotEbene.Location = New System.Drawing.Point(158, 16)
        Me.BotEbene.Name = "BotEbene"
        Me.BotEbene.Size = New System.Drawing.Size(90, 20)
        Me.BotEbene.TabIndex = 20
        Me.BotEbene.Text = "Bot Ebène"
        Me.BotEbene.UseVisualStyleBackColor = True
        '
        'BotChataignier
        '
        Me.BotChataignier.AutoSize = True
        Me.BotChataignier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotChataignier.Location = New System.Drawing.Point(18, 42)
        Me.BotChataignier.Name = "BotChataignier"
        Me.BotChataignier.Size = New System.Drawing.Size(118, 20)
        Me.BotChataignier.TabIndex = 9
        Me.BotChataignier.Text = "Bot Châtaignier"
        Me.BotChataignier.UseVisualStyleBackColor = True
        '
        'BotMerisier
        '
        Me.BotMerisier.AutoSize = True
        Me.BotMerisier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotMerisier.Location = New System.Drawing.Point(18, 250)
        Me.BotMerisier.Name = "BotMerisier"
        Me.BotMerisier.Size = New System.Drawing.Size(98, 20)
        Me.BotMerisier.TabIndex = 19
        Me.BotMerisier.Text = "Bot Merisier"
        Me.BotMerisier.UseVisualStyleBackColor = True
        '
        'BotNoyer
        '
        Me.BotNoyer.AutoSize = True
        Me.BotNoyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotNoyer.Location = New System.Drawing.Point(18, 68)
        Me.BotNoyer.Name = "BotNoyer"
        Me.BotNoyer.Size = New System.Drawing.Size(87, 20)
        Me.BotNoyer.TabIndex = 10
        Me.BotNoyer.Text = "Bot Noyer"
        Me.BotNoyer.UseVisualStyleBackColor = True
        '
        'BotChene
        '
        Me.BotChene.AutoSize = True
        Me.BotChene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotChene.Location = New System.Drawing.Point(18, 94)
        Me.BotChene.Name = "BotChene"
        Me.BotChene.Size = New System.Drawing.Size(89, 20)
        Me.BotChene.TabIndex = 11
        Me.BotChene.Text = "Bot Chêne"
        Me.BotChene.UseVisualStyleBackColor = True
        '
        'BotBambou
        '
        Me.BotBambou.AutoSize = True
        Me.BotBambou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBambou.Location = New System.Drawing.Point(18, 224)
        Me.BotBambou.Name = "BotBambou"
        Me.BotBambou.Size = New System.Drawing.Size(101, 20)
        Me.BotBambou.TabIndex = 18
        Me.BotBambou.Text = "Bot Bambou"
        Me.BotBambou.UseVisualStyleBackColor = True
        '
        'BotIf
        '
        Me.BotIf.AutoSize = True
        Me.BotIf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotIf.Location = New System.Drawing.Point(18, 198)
        Me.BotIf.Name = "BotIf"
        Me.BotIf.Size = New System.Drawing.Size(56, 20)
        Me.BotIf.TabIndex = 16
        Me.BotIf.Text = "Bot If"
        Me.BotIf.UseVisualStyleBackColor = True
        '
        'BotBombu
        '
        Me.BotBombu.AutoSize = True
        Me.BotBombu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBombu.Location = New System.Drawing.Point(18, 120)
        Me.BotBombu.Name = "BotBombu"
        Me.BotBombu.Size = New System.Drawing.Size(93, 20)
        Me.BotBombu.TabIndex = 12
        Me.BotBombu.Text = "Bot Bombu"
        Me.BotBombu.UseVisualStyleBackColor = True
        '
        'BotErable
        '
        Me.BotErable.AutoSize = True
        Me.BotErable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotErable.Location = New System.Drawing.Point(18, 172)
        Me.BotErable.Name = "BotErable"
        Me.BotErable.Size = New System.Drawing.Size(90, 20)
        Me.BotErable.TabIndex = 14
        Me.BotErable.Text = "Bot Erable"
        Me.BotErable.UseVisualStyleBackColor = True
        '
        'BotOliviolet
        '
        Me.BotOliviolet.AutoSize = True
        Me.BotOliviolet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotOliviolet.Location = New System.Drawing.Point(18, 146)
        Me.BotOliviolet.Name = "BotOliviolet"
        Me.BotOliviolet.Size = New System.Drawing.Size(98, 20)
        Me.BotOliviolet.TabIndex = 13
        Me.BotOliviolet.Text = "Bot Oliviolet"
        Me.BotOliviolet.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.BotPandouille)
        Me.TabPage10.Controls.Add(Me.BotEdelweiss)
        Me.TabPage10.Controls.Add(Me.BotOrchideeFreyesque)
        Me.TabPage10.Controls.Add(Me.BotMentheSauvage)
        Me.TabPage10.Controls.Add(Me.BotTrefle)
        Me.TabPage10.Controls.Add(Me.BotChanvreAlchi)
        Me.TabPage10.Controls.Add(Me.BotLinAlchi)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(325, 330)
        Me.TabPage10.TabIndex = 2
        Me.TabPage10.Text = "Alchimiste"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'BotPandouille
        '
        Me.BotPandouille.AutoSize = True
        Me.BotPandouille.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotPandouille.Location = New System.Drawing.Point(18, 172)
        Me.BotPandouille.Name = "BotPandouille"
        Me.BotPandouille.Size = New System.Drawing.Size(114, 20)
        Me.BotPandouille.TabIndex = 24
        Me.BotPandouille.Text = "Bot Pandouille"
        Me.BotPandouille.UseVisualStyleBackColor = True
        '
        'BotEdelweiss
        '
        Me.BotEdelweiss.AutoSize = True
        Me.BotEdelweiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotEdelweiss.Location = New System.Drawing.Point(18, 146)
        Me.BotEdelweiss.Name = "BotEdelweiss"
        Me.BotEdelweiss.Size = New System.Drawing.Size(112, 20)
        Me.BotEdelweiss.TabIndex = 23
        Me.BotEdelweiss.Text = "Bot Edelweiss"
        Me.BotEdelweiss.UseVisualStyleBackColor = True
        '
        'BotOrchideeFreyesque
        '
        Me.BotOrchideeFreyesque.AutoSize = True
        Me.BotOrchideeFreyesque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotOrchideeFreyesque.Location = New System.Drawing.Point(18, 120)
        Me.BotOrchideeFreyesque.Name = "BotOrchideeFreyesque"
        Me.BotOrchideeFreyesque.Size = New System.Drawing.Size(173, 20)
        Me.BotOrchideeFreyesque.TabIndex = 22
        Me.BotOrchideeFreyesque.Text = "Bot Orchidée Freyesque"
        Me.BotOrchideeFreyesque.UseVisualStyleBackColor = True
        '
        'BotMentheSauvage
        '
        Me.BotMentheSauvage.AutoSize = True
        Me.BotMentheSauvage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotMentheSauvage.Location = New System.Drawing.Point(18, 94)
        Me.BotMentheSauvage.Name = "BotMentheSauvage"
        Me.BotMentheSauvage.Size = New System.Drawing.Size(152, 20)
        Me.BotMentheSauvage.TabIndex = 21
        Me.BotMentheSauvage.Text = "Bot Menthe Sauvage"
        Me.BotMentheSauvage.UseVisualStyleBackColor = True
        '
        'BotTrefle
        '
        Me.BotTrefle.AutoSize = True
        Me.BotTrefle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotTrefle.Location = New System.Drawing.Point(18, 68)
        Me.BotTrefle.Name = "BotTrefle"
        Me.BotTrefle.Size = New System.Drawing.Size(169, 20)
        Me.BotTrefle.TabIndex = 20
        Me.BotTrefle.Text = "Bot Trèfle à cinq feuilles"
        Me.BotTrefle.UseVisualStyleBackColor = True
        '
        'BotChanvreAlchi
        '
        Me.BotChanvreAlchi.AutoSize = True
        Me.BotChanvreAlchi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotChanvreAlchi.Location = New System.Drawing.Point(18, 42)
        Me.BotChanvreAlchi.Name = "BotChanvreAlchi"
        Me.BotChanvreAlchi.Size = New System.Drawing.Size(172, 20)
        Me.BotChanvreAlchi.TabIndex = 19
        Me.BotChanvreAlchi.Text = "Bot Chanvre (Alchimiste)"
        Me.BotChanvreAlchi.UseVisualStyleBackColor = True
        '
        'BotLinAlchi
        '
        Me.BotLinAlchi.AutoSize = True
        Me.BotLinAlchi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotLinAlchi.Location = New System.Drawing.Point(18, 16)
        Me.BotLinAlchi.Name = "BotLinAlchi"
        Me.BotLinAlchi.Size = New System.Drawing.Size(139, 20)
        Me.BotLinAlchi.TabIndex = 18
        Me.BotLinAlchi.Text = "Bot Lin (Alchimiste)"
        Me.BotLinAlchi.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.BotDolomite)
        Me.TabPage6.Controls.Add(Me.BotOr)
        Me.TabPage6.Controls.Add(Me.BotBauxite)
        Me.TabPage6.Controls.Add(Me.BotArgent)
        Me.TabPage6.Controls.Add(Me.BotSilicate)
        Me.TabPage6.Controls.Add(Me.BotEtain)
        Me.TabPage6.Controls.Add(Me.BotManganese)
        Me.TabPage6.Controls.Add(Me.BotKobalte)
        Me.TabPage6.Controls.Add(Me.BotBronze)
        Me.TabPage6.Controls.Add(Me.BotCuivre)
        Me.TabPage6.Controls.Add(Me.BotFer)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(325, 330)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Mineur"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'BotDolomite
        '
        Me.BotDolomite.AutoSize = True
        Me.BotDolomite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotDolomite.Location = New System.Drawing.Point(158, 16)
        Me.BotDolomite.Name = "BotDolomite"
        Me.BotDolomite.Size = New System.Drawing.Size(104, 20)
        Me.BotDolomite.TabIndex = 13
        Me.BotDolomite.Text = "Bot Dolomite"
        Me.BotDolomite.UseVisualStyleBackColor = True
        '
        'BotOr
        '
        Me.BotOr.AutoSize = True
        Me.BotOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotOr.Location = New System.Drawing.Point(18, 250)
        Me.BotOr.Name = "BotOr"
        Me.BotOr.Size = New System.Drawing.Size(64, 20)
        Me.BotOr.TabIndex = 12
        Me.BotOr.Text = "Bot Or"
        Me.BotOr.UseVisualStyleBackColor = True
        '
        'BotBauxite
        '
        Me.BotBauxite.AutoSize = True
        Me.BotBauxite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBauxite.Location = New System.Drawing.Point(18, 224)
        Me.BotBauxite.Name = "BotBauxite"
        Me.BotBauxite.Size = New System.Drawing.Size(94, 20)
        Me.BotBauxite.TabIndex = 11
        Me.BotBauxite.Text = "Bot Bauxite"
        Me.BotBauxite.UseVisualStyleBackColor = True
        '
        'BotArgent
        '
        Me.BotArgent.AutoSize = True
        Me.BotArgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotArgent.Location = New System.Drawing.Point(18, 198)
        Me.BotArgent.Name = "BotArgent"
        Me.BotArgent.Size = New System.Drawing.Size(89, 20)
        Me.BotArgent.TabIndex = 10
        Me.BotArgent.Text = "Bot Argent"
        Me.BotArgent.UseVisualStyleBackColor = True
        '
        'BotSilicate
        '
        Me.BotSilicate.AutoSize = True
        Me.BotSilicate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotSilicate.Location = New System.Drawing.Point(18, 172)
        Me.BotSilicate.Name = "BotSilicate"
        Me.BotSilicate.Size = New System.Drawing.Size(94, 20)
        Me.BotSilicate.TabIndex = 9
        Me.BotSilicate.Text = "Bot Silicate"
        Me.BotSilicate.UseVisualStyleBackColor = True
        '
        'BotEtain
        '
        Me.BotEtain.AutoSize = True
        Me.BotEtain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotEtain.Location = New System.Drawing.Point(18, 146)
        Me.BotEtain.Name = "BotEtain"
        Me.BotEtain.Size = New System.Drawing.Size(80, 20)
        Me.BotEtain.TabIndex = 8
        Me.BotEtain.Text = "Bot Etain"
        Me.BotEtain.UseVisualStyleBackColor = True
        '
        'BotManganese
        '
        Me.BotManganese.AutoSize = True
        Me.BotManganese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotManganese.Location = New System.Drawing.Point(18, 120)
        Me.BotManganese.Name = "BotManganese"
        Me.BotManganese.Size = New System.Drawing.Size(122, 20)
        Me.BotManganese.TabIndex = 7
        Me.BotManganese.Text = "Bot Manganèse"
        Me.BotManganese.UseVisualStyleBackColor = True
        '
        'BotKobalte
        '
        Me.BotKobalte.AutoSize = True
        Me.BotKobalte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotKobalte.Location = New System.Drawing.Point(18, 94)
        Me.BotKobalte.Name = "BotKobalte"
        Me.BotKobalte.Size = New System.Drawing.Size(96, 20)
        Me.BotKobalte.TabIndex = 6
        Me.BotKobalte.Text = "Bot Kobalte"
        Me.BotKobalte.UseVisualStyleBackColor = True
        '
        'BotBronze
        '
        Me.BotBronze.AutoSize = True
        Me.BotBronze.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotBronze.Location = New System.Drawing.Point(18, 68)
        Me.BotBronze.Name = "BotBronze"
        Me.BotBronze.Size = New System.Drawing.Size(92, 20)
        Me.BotBronze.TabIndex = 5
        Me.BotBronze.Text = "Bot Bronze"
        Me.BotBronze.UseVisualStyleBackColor = True
        '
        'BotCuivre
        '
        Me.BotCuivre.AutoSize = True
        Me.BotCuivre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotCuivre.Location = New System.Drawing.Point(18, 42)
        Me.BotCuivre.Name = "BotCuivre"
        Me.BotCuivre.Size = New System.Drawing.Size(88, 20)
        Me.BotCuivre.TabIndex = 4
        Me.BotCuivre.Text = "Bot Cuivre"
        Me.BotCuivre.UseVisualStyleBackColor = True
        '
        'BotFer
        '
        Me.BotFer.AutoSize = True
        Me.BotFer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotFer.Location = New System.Drawing.Point(18, 16)
        Me.BotFer.Name = "BotFer"
        Me.BotFer.Size = New System.Drawing.Size(70, 20)
        Me.BotFer.TabIndex = 3
        Me.BotFer.Text = "Bot Fer"
        Me.BotFer.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.PoissonsGeantsMer)
        Me.TabPage7.Controls.Add(Me.PoissonsGeantsRiviere)
        Me.TabPage7.Controls.Add(Me.GrosPoissonsMer)
        Me.TabPage7.Controls.Add(Me.GrosPoissonsRiviere)
        Me.TabPage7.Controls.Add(Me.PoissonsMer)
        Me.TabPage7.Controls.Add(Me.PoissonsRiviere)
        Me.TabPage7.Controls.Add(Me.PetitsPoissonsMer)
        Me.TabPage7.Controls.Add(Me.PetitsPoissonsRiviere)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(325, 330)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Pêcheur"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'PoissonsGeantsMer
        '
        Me.PoissonsGeantsMer.AutoSize = True
        Me.PoissonsGeantsMer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoissonsGeantsMer.Location = New System.Drawing.Point(18, 198)
        Me.PoissonsGeantsMer.Name = "PoissonsGeantsMer"
        Me.PoissonsGeantsMer.Size = New System.Drawing.Size(161, 20)
        Me.PoissonsGeantsMer.TabIndex = 11
        Me.PoissonsGeantsMer.Text = "Poissons géants (mer)"
        Me.PoissonsGeantsMer.UseVisualStyleBackColor = True
        '
        'PoissonsGeantsRiviere
        '
        Me.PoissonsGeantsRiviere.AutoSize = True
        Me.PoissonsGeantsRiviere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoissonsGeantsRiviere.Location = New System.Drawing.Point(18, 172)
        Me.PoissonsGeantsRiviere.Name = "PoissonsGeantsRiviere"
        Me.PoissonsGeantsRiviere.Size = New System.Drawing.Size(175, 20)
        Me.PoissonsGeantsRiviere.TabIndex = 10
        Me.PoissonsGeantsRiviere.Text = "Poissons géants (rivière)"
        Me.PoissonsGeantsRiviere.UseVisualStyleBackColor = True
        '
        'GrosPoissonsMer
        '
        Me.GrosPoissonsMer.AutoSize = True
        Me.GrosPoissonsMer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrosPoissonsMer.Location = New System.Drawing.Point(18, 146)
        Me.GrosPoissonsMer.Name = "GrosPoissonsMer"
        Me.GrosPoissonsMer.Size = New System.Drawing.Size(148, 20)
        Me.GrosPoissonsMer.TabIndex = 9
        Me.GrosPoissonsMer.Text = "Gros poissons (mer)"
        Me.GrosPoissonsMer.UseVisualStyleBackColor = True
        '
        'GrosPoissonsRiviere
        '
        Me.GrosPoissonsRiviere.AutoSize = True
        Me.GrosPoissonsRiviere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrosPoissonsRiviere.Location = New System.Drawing.Point(18, 120)
        Me.GrosPoissonsRiviere.Name = "GrosPoissonsRiviere"
        Me.GrosPoissonsRiviere.Size = New System.Drawing.Size(162, 20)
        Me.GrosPoissonsRiviere.TabIndex = 8
        Me.GrosPoissonsRiviere.Text = "Gros poissons (rivière)"
        Me.GrosPoissonsRiviere.UseVisualStyleBackColor = True
        '
        'PoissonsMer
        '
        Me.PoissonsMer.AutoSize = True
        Me.PoissonsMer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoissonsMer.Location = New System.Drawing.Point(18, 94)
        Me.PoissonsMer.Name = "PoissonsMer"
        Me.PoissonsMer.Size = New System.Drawing.Size(117, 20)
        Me.PoissonsMer.TabIndex = 7
        Me.PoissonsMer.Text = "Poissons (mer)"
        Me.PoissonsMer.UseVisualStyleBackColor = True
        '
        'PoissonsRiviere
        '
        Me.PoissonsRiviere.AutoSize = True
        Me.PoissonsRiviere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoissonsRiviere.Location = New System.Drawing.Point(18, 68)
        Me.PoissonsRiviere.Name = "PoissonsRiviere"
        Me.PoissonsRiviere.Size = New System.Drawing.Size(131, 20)
        Me.PoissonsRiviere.TabIndex = 6
        Me.PoissonsRiviere.Text = "Poissons (rivière)"
        Me.PoissonsRiviere.UseVisualStyleBackColor = True
        '
        'PetitsPoissonsMer
        '
        Me.PetitsPoissonsMer.AutoSize = True
        Me.PetitsPoissonsMer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetitsPoissonsMer.Location = New System.Drawing.Point(18, 42)
        Me.PetitsPoissonsMer.Name = "PetitsPoissonsMer"
        Me.PetitsPoissonsMer.Size = New System.Drawing.Size(152, 20)
        Me.PetitsPoissonsMer.TabIndex = 5
        Me.PetitsPoissonsMer.Text = "Petits poissons (mer)"
        Me.PetitsPoissonsMer.UseVisualStyleBackColor = True
        '
        'PetitsPoissonsRiviere
        '
        Me.PetitsPoissonsRiviere.AutoSize = True
        Me.PetitsPoissonsRiviere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetitsPoissonsRiviere.Location = New System.Drawing.Point(18, 16)
        Me.PetitsPoissonsRiviere.Name = "PetitsPoissonsRiviere"
        Me.PetitsPoissonsRiviere.Size = New System.Drawing.Size(166, 20)
        Me.PetitsPoissonsRiviere.TabIndex = 4
        Me.PetitsPoissonsRiviere.Text = "Petits poissons (rivière)"
        Me.PetitsPoissonsRiviere.UseVisualStyleBackColor = True
        '
        'ListeRessources
        '
        Me.ListeRessources.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListeRessources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListeRessources.FullRowSelect = True
        Me.ListeRessources.Location = New System.Drawing.Point(11, 11)
        Me.ListeRessources.MultiSelect = False
        Me.ListeRessources.Name = "ListeRessources"
        Me.ListeRessources.Size = New System.Drawing.Size(285, 359)
        Me.ListeRessources.TabIndex = 0
        Me.ListeRessources.UseCompatibleStateImageBehavior = False
        Me.ListeRessources.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Recursos"
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Caixa"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Estado"
        Me.ColumnHeader7.Width = 71
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.TabControl3)
        Me.TabPage11.Controls.Add(Me.MenuStrip1)
        Me.TabPage11.Location = New System.Drawing.Point(4, 25)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(644, 380)
        Me.TabPage11.TabIndex = 5
        Me.TabPage11.Text = "Mapa Atual"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage12)
        Me.TabControl3.Controls.Add(Me.TabPage13)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 27)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(644, 353)
        Me.TabControl3.TabIndex = 7
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.ListPlayers)
        Me.TabPage12.Location = New System.Drawing.Point(4, 25)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(636, 324)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Joueurs"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'ListPlayers
        '
        Me.ListPlayers.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListPlayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader11})
        Me.ListPlayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPlayers.FullRowSelect = True
        Me.ListPlayers.Location = New System.Drawing.Point(3, 3)
        Me.ListPlayers.Name = "ListPlayers"
        Me.ListPlayers.Size = New System.Drawing.Size(630, 318)
        Me.ListPlayers.TabIndex = 0
        Me.ListPlayers.UseCompatibleStateImageBehavior = False
        Me.ListPlayers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 73
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nome"
        Me.ColumnHeader9.Width = 103
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nivel"
        Me.ColumnHeader10.Width = 56
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Guilda"
        Me.ColumnHeader12.Width = 110
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Alinhamento"
        Me.ColumnHeader11.Width = 93
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.ListMonster)
        Me.TabPage13.Location = New System.Drawing.Point(4, 25)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(636, 327)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Monstres"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'ListMonster
        '
        Me.ListMonster.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListMonster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader18})
        Me.ListMonster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListMonster.FullRowSelect = True
        Me.ListMonster.Location = New System.Drawing.Point(3, 3)
        Me.ListMonster.Name = "ListMonster"
        Me.ListMonster.Size = New System.Drawing.Size(630, 321)
        Me.ListMonster.TabIndex = 1
        Me.ListMonster.UseCompatibleStateImageBehavior = False
        Me.ListMonster.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ID"
        Me.ColumnHeader13.Width = 73
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Case"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangerDeMapToolStripMenuItem, Me.ToolStripSeparator8, Me.CoordsMap, Me.ToolStripSeparator9, Me.RejoindreLeChefToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 27)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangerDeMapToolStripMenuItem
        '
        Me.ChangerDeMapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMapHaut, Me.ChangeMapBas, Me.ChangeMapGauche, Me.ChangeMapDroite})
        Me.ChangerDeMapToolStripMenuItem.Image = CType(resources.GetObject("ChangerDeMapToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangerDeMapToolStripMenuItem.Name = "ChangerDeMapToolStripMenuItem"
        Me.ChangerDeMapToolStripMenuItem.Size = New System.Drawing.Size(133, 23)
        Me.ChangerDeMapToolStripMenuItem.Text = "Selecionar Mapa"
        '
        'ChangeMapHaut
        '
        Me.ChangeMapHaut.Name = "ChangeMapHaut"
        Me.ChangeMapHaut.Size = New System.Drawing.Size(131, 22)
        Me.ChangeMapHaut.Text = "Haut"
        '
        'ChangeMapBas
        '
        Me.ChangeMapBas.Name = "ChangeMapBas"
        Me.ChangeMapBas.Size = New System.Drawing.Size(131, 22)
        Me.ChangeMapBas.Text = "Bas"
        '
        'ChangeMapGauche
        '
        Me.ChangeMapGauche.Name = "ChangeMapGauche"
        Me.ChangeMapGauche.Size = New System.Drawing.Size(131, 22)
        Me.ChangeMapGauche.Text = "Gauche"
        '
        'ChangeMapDroite
        '
        Me.ChangeMapDroite.Name = "ChangeMapDroite"
        Me.ChangeMapDroite.Size = New System.Drawing.Size(131, 22)
        Me.ChangeMapDroite.Text = "Droite"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 23)
        '
        'CoordsMap
        '
        Me.CoordsMap.BackColor = System.Drawing.Color.White
        Me.CoordsMap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordsMap.Name = "CoordsMap"
        Me.CoordsMap.ReadOnly = True
        Me.CoordsMap.Size = New System.Drawing.Size(80, 23)
        Me.CoordsMap.Text = "--, --"
        Me.CoordsMap.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 23)
        '
        'RejoindreLeChefToolStripMenuItem
        '
        Me.RejoindreLeChefToolStripMenuItem.Image = CType(resources.GetObject("RejoindreLeChefToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RejoindreLeChefToolStripMenuItem.Name = "RejoindreLeChefToolStripMenuItem"
        Me.RejoindreLeChefToolStripMenuItem.Size = New System.Drawing.Size(144, 23)
        Me.RejoindreLeChefToolStripMenuItem.Text = "Juntar-se Ao chefe"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SendToSock)
        Me.TabPage2.Controls.Add(Me.TextLog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(644, 380)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Log bot"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SendToSock
        '
        Me.SendToSock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendToSock.Location = New System.Drawing.Point(3, 357)
        Me.SendToSock.Name = "SendToSock"
        Me.SendToSock.Size = New System.Drawing.Size(635, 20)
        Me.SendToSock.TabIndex = 1
        '
        'TextLog
        '
        Me.TextLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextLog.BackColor = System.Drawing.Color.White
        Me.TextLog.ContextMenuStrip = Me.AfficherLog
        Me.TextLog.Location = New System.Drawing.Point(3, 3)
        Me.TextLog.Name = "TextLog"
        Me.TextLog.ReadOnly = True
        Me.TextLog.Size = New System.Drawing.Size(635, 348)
        Me.TextLog.TabIndex = 0
        Me.TextLog.Text = ""
        '
        'AfficherLog
        '
        Me.AfficherLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NePasAfficherLeLogToolStripMenuItem})
        Me.AfficherLog.Name = "AfficherLog"
        Me.AfficherLog.Size = New System.Drawing.Size(208, 26)
        '
        'NePasAfficherLeLogToolStripMenuItem
        '
        Me.NePasAfficherLeLogToolStripMenuItem.CheckOnClick = True
        Me.NePasAfficherLeLogToolStripMenuItem.Name = "NePasAfficherLeLogToolStripMenuItem"
        Me.NePasAfficherLeLogToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NePasAfficherLeLogToolStripMenuItem.Text = "Ne pas afficher le log"
        '
        'UserPerso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatBarre)
        Me.Controls.Add(Me.MenuPerso)
        Me.Name = "UserPerso"
        Me.Size = New System.Drawing.Size(652, 461)
        Me.StatBarre.ResumeLayout(False)
        Me.StatBarre.PerformLayout()
        Me.MenuPerso.ResumeLayout(False)
        Me.MenuPerso.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupStats.ResumeLayout(False)
        Me.GroupStats.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSpell.ResumeLayout(False)
        Me.GroupSpell.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.DeleteInventaire.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericLiaison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage14.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage13.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.AfficherLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatBarre As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Vie As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Exp As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Kamas As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MenuPerso As System.Windows.Forms.MenuStrip
    Friend WithEvents ConnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeConnecterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeDéconnecterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextPerso As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LabelEtat As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LabelStat As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeleteLog As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ChatBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SendToChat As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupStats As System.Windows.Forms.GroupBox
    Friend WithEvents PlusAir As System.Windows.Forms.Button
    Friend WithEvents PlusEau As System.Windows.Forms.Button
    Friend WithEvents PlusFeu As System.Windows.Forms.Button
    Friend WithEvents PlusTerre As System.Windows.Forms.Button
    Friend WithEvents PlusSag As System.Windows.Forms.Button
    Friend WithEvents PlusVie As System.Windows.Forms.Button
    Friend WithEvents StatAir As System.Windows.Forms.TextBox
    Friend WithEvents StatEau As System.Windows.Forms.TextBox
    Friend WithEvents StatFeu As System.Windows.Forms.TextBox
    Friend WithEvents StatTerre As System.Windows.Forms.TextBox
    Friend WithEvents StatSag As System.Windows.Forms.TextBox
    Friend WithEvents StatVie As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Comp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupSpell As System.Windows.Forms.GroupBox
    Friend WithEvents UpSpell As System.Windows.Forms.Button
    Friend WithEvents CompSpell As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextLog As System.Windows.Forms.RichTextBox
    Friend WithEvents SendToSock As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Flooder As System.Windows.Forms.CheckBox
    Friend WithEvents NumFlood As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TexteFlood As System.Windows.Forms.TextBox
    Friend WithEvents Secondes As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Pods As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TextChef As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents NumFloodMP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MPFlooder As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ListeInventaire As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteInventaire As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DestroyItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonnerAuChefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ListeRessources As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BotBle As System.Windows.Forms.CheckBox
    Friend WithEvents BotOrge As System.Windows.Forms.CheckBox
    Friend WithEvents BotSeigle As System.Windows.Forms.CheckBox
    Friend WithEvents BotAvoine As System.Windows.Forms.CheckBox
    Friend WithEvents BotHoublon As System.Windows.Forms.CheckBox
    Friend WithEvents BotMalt As System.Windows.Forms.CheckBox
    Friend WithEvents BotFrene As System.Windows.Forms.CheckBox
    Friend WithEvents BotChataignier As System.Windows.Forms.CheckBox
    Friend WithEvents BotNoyer As System.Windows.Forms.CheckBox
    Friend WithEvents BotChene As System.Windows.Forms.CheckBox
    Friend WithEvents BotBombu As System.Windows.Forms.CheckBox
    Friend WithEvents BotOliviolet As System.Windows.Forms.CheckBox
    Friend WithEvents BotErable As System.Windows.Forms.CheckBox
    Friend WithEvents BotRiz As System.Windows.Forms.CheckBox
    Friend WithEvents BotIf As System.Windows.Forms.CheckBox
    Friend WithEvents BotLin As System.Windows.Forms.CheckBox
    Friend WithEvents BotBambou As System.Windows.Forms.CheckBox
    Friend WithEvents BotMerisier As System.Windows.Forms.CheckBox
    Friend WithEvents BotEbene As System.Windows.Forms.CheckBox
    Friend WithEvents BotKaliptus As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents BotCharme As System.Windows.Forms.CheckBox
    Friend WithEvents BotBombouSombre As System.Windows.Forms.CheckBox
    Friend WithEvents BotOrme As System.Windows.Forms.CheckBox
    Friend WithEvents BotBambouSacre As System.Windows.Forms.CheckBox
    Friend WithEvents BotLinAlchi As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents BotFer As System.Windows.Forms.CheckBox
    Friend WithEvents BotChanvre As System.Windows.Forms.CheckBox
    Friend WithEvents BotChanvreAlchi As System.Windows.Forms.CheckBox
    Friend WithEvents BotTrefle As System.Windows.Forms.CheckBox
    Friend WithEvents DétruireObjetAutomatiquementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotMentheSauvage As System.Windows.Forms.CheckBox
    Friend WithEvents BotOrchideeFreyesque As System.Windows.Forms.CheckBox
    Friend WithEvents BotEdelweiss As System.Windows.Forms.CheckBox
    Friend WithEvents BotPandouille As System.Windows.Forms.CheckBox
    Friend WithEvents BotCuivre As System.Windows.Forms.CheckBox
    Friend WithEvents BotBronze As System.Windows.Forms.CheckBox
    Friend WithEvents BotKobalte As System.Windows.Forms.CheckBox
    Friend WithEvents BotManganese As System.Windows.Forms.CheckBox
    Friend WithEvents BotDolomite As System.Windows.Forms.CheckBox
    Friend WithEvents BotOr As System.Windows.Forms.CheckBox
    Friend WithEvents BotBauxite As System.Windows.Forms.CheckBox
    Friend WithEvents BotArgent As System.Windows.Forms.CheckBox
    Friend WithEvents BotSilicate As System.Windows.Forms.CheckBox
    Friend WithEvents BotEtain As System.Windows.Forms.CheckBox
    Friend WithEvents AfficherLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NePasAfficherLeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents PetitsPoissonsRiviere As System.Windows.Forms.CheckBox
    Friend WithEvents PetitsPoissonsMer As System.Windows.Forms.CheckBox
    Friend WithEvents PoissonsGeantsMer As System.Windows.Forms.CheckBox
    Friend WithEvents PoissonsGeantsRiviere As System.Windows.Forms.CheckBox
    Friend WithEvents GrosPoissonsMer As System.Windows.Forms.CheckBox
    Friend WithEvents GrosPoissonsRiviere As System.Windows.Forms.CheckBox
    Friend WithEvents PoissonsMer As System.Windows.Forms.CheckBox
    Friend WithEvents PoissonsRiviere As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangerDeMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeMapHaut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeMapBas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeMapGauche As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeMapDroite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CoordsMap As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents ListPlayers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RejoindreLeChefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMonster As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListePrix As System.Windows.Forms.ListBox
    Friend WithEvents DelItem As System.Windows.Forms.Button
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents ListeObjets As System.Windows.Forms.ListBox
    Friend WithEvents NumAchat As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Prix As System.Windows.Forms.TextBox
    Friend WithEvents Objets As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Echange As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListFloodMP As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NivMax As System.Windows.Forms.TextBox
    Friend WithEvents NivMin As System.Windows.Forms.TextBox
    Friend WithEvents MessageToAdd As System.Windows.Forms.TextBox
    Friend WithEvents DelMessageMP As System.Windows.Forms.Button
    Friend WithEvents AddMessageMP As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CongigurerLesFinsDePhraseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckLiaisonFlood As System.Windows.Forms.CheckBox
    Friend WithEvents NumericLiaison As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckAfk As System.Windows.Forms.CheckBox

End Class
