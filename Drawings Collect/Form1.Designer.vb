<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Login = New System.Windows.Forms.Button()
        Me.ComboVaults = New System.Windows.Forms.ComboBox()
        Me.CollectButton = New System.Windows.Forms.Button()
        Me.PartNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboLanguage = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextboxCollectPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MultiColumnTree1 = New Ai.Control.MultiColumnTree()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(239, 628)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 23)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'ComboVaults
        '
        Me.ComboVaults.FormattingEnabled = True
        Me.ComboVaults.Location = New System.Drawing.Point(12, 630)
        Me.ComboVaults.Name = "ComboVaults"
        Me.ComboVaults.Size = New System.Drawing.Size(220, 21)
        Me.ComboVaults.TabIndex = 1
        '
        'CollectButton
        '
        Me.CollectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollectButton.Location = New System.Drawing.Point(862, 630)
        Me.CollectButton.Name = "CollectButton"
        Me.CollectButton.Size = New System.Drawing.Size(75, 23)
        Me.CollectButton.TabIndex = 6
        Me.CollectButton.Text = "Collect"
        Me.CollectButton.UseVisualStyleBackColor = True
        '
        'PartNo
        '
        Me.PartNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PartNo.Location = New System.Drawing.Point(3, 21)
        Me.PartNo.MaxLength = 8
        Me.PartNo.Name = "PartNo"
        Me.PartNo.Size = New System.Drawing.Size(100, 20)
        Me.PartNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PartNo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 664)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(947, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(83, 17)
        Me.ToolStripStatusLabel2.Text = "Not Logged In"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(715, 634)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(141, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Collect Sub-Items if Exist"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboLanguage
        '
        Me.ComboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboLanguage.FormattingEnabled = True
        Me.ComboLanguage.Location = New System.Drawing.Point(190, 19)
        Me.ComboLanguage.Name = "ComboLanguage"
        Me.ComboLanguage.Size = New System.Drawing.Size(52, 21)
        Me.ComboLanguage.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Language"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(109, 19)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 22)
        Me.Search.TabIndex = 1
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(572, 573)
        Me.TreeView1.TabIndex = 0
        '
        'TextboxCollectPath
        '
        Me.TextboxCollectPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextboxCollectPath.Location = New System.Drawing.Point(404, 633)
        Me.TextboxCollectPath.Name = "TextboxCollectPath"
        Me.TextboxCollectPath.ReadOnly = True
        Me.TextboxCollectPath.Size = New System.Drawing.Size(267, 20)
        Me.TextboxCollectPath.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 617)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Collect to Folder:"
        '
        'Browse
        '
        Me.Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browse.Location = New System.Drawing.Point(677, 631)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(28, 23)
        Me.Browse.TabIndex = 4
        Me.Browse.Text = "..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(3, 47)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(344, 289)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PartNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboLanguage)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Search)
        Me.SplitContainer1.Panel1MinSize = 255
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MultiColumnTree1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(926, 573)
        Me.SplitContainer1.SplitterDistance = 350
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Where Used:"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 364)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(344, 206)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'MultiColumnTree1
        '
        Me.MultiColumnTree1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.MultiColumnTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MultiColumnTree1.FullRowSelect = True
        Me.MultiColumnTree1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MultiColumnTree1.Indent = -1
        Me.MultiColumnTree1.Location = New System.Drawing.Point(0, 0)
        Me.MultiColumnTree1.Name = "MultiColumnTree1"
        Me.MultiColumnTree1.Padding = New System.Windows.Forms.Padding(1)
        Me.MultiColumnTree1.SelectedNode = Nothing
        Me.MultiColumnTree1.ShowColumnOptions = False
        Me.MultiColumnTree1.Size = New System.Drawing.Size(572, 573)
        Me.MultiColumnTree1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'MenuItem1
        '
        Me.MenuItem1.CheckOnClick = True
        Me.MenuItem1.Name = "MenuItem1"
        Me.MenuItem1.Size = New System.Drawing.Size(348, 22)
        Me.MenuItem1.Text = "Mark files not referenced in their latest version (Red)"
        '
        'MenuItem2
        '
        Me.MenuItem2.CheckOnClick = True
        Me.MenuItem2.Name = "MenuItem2"
        Me.MenuItem2.Size = New System.Drawing.Size(348, 22)
        Me.MenuItem2.Text = "Mark files missing drawings (Orange)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Checked = True
        Me.MenuItem3.CheckOnClick = True
        Me.MenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItem3.Name = "MenuItem3"
        Me.MenuItem3.Size = New System.Drawing.Size(348, 22)
        Me.MenuItem3.Text = "Show only drawings ""In Sync With ERP"""
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.CheckOnClick = True
        Me.MenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItem4.Name = "MenuItem4"
        Me.MenuItem4.Size = New System.Drawing.Size(348, 22)
        Me.MenuItem4.Text = "Show only manufacturing data documents"
        '
        'MenuItem5
        '
        Me.MenuItem5.CheckOnClick = True
        Me.MenuItem5.Name = "MenuItem5"
        Me.MenuItem5.Size = New System.Drawing.Size(348, 22)
        Me.MenuItem5.Text = "Show only latest revision version in search results"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 686)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextboxCollectPath)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CollectButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ComboVaults)
        Me.Controls.Add(Me.Login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(573, 458)
        Me.Name = "Form1"
        Me.Text = "Manufacturing Data Collector"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents ComboVaults As System.Windows.Forms.ComboBox
    Friend WithEvents CollectButton As System.Windows.Forms.Button
    Friend WithEvents PartNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextboxCollectPath As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MultiColumnTree1 As Ai.Control.MultiColumnTree
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.ToolStripMenuItem

End Class
