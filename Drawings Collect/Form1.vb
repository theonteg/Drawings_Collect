Imports EdmLib
Public Class Form1
	Dim vault As IEdmVault8 = New EdmVault5

	Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
		vault.LoginAuto(ComboVaults.Text, Me.Handle.ToInt32())
		If vault.IsLoggedIn = True Then
			ComboVaults.Visible = False
			Login.Visible = False
			ToolStripStatusLabel2.Text = "Logged in to " & vault.Name
		Else
			ToolStripStatusLabel2.Text = "Not Logged in"
			MsgBox("Δεν έχετε κάνει login", , "Login to Vault")
		End If
	End Sub



	Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		'Splash Screen με ιστορικό αλλαγών.
		If e.Control = True And e.KeyCode = Keys.I Then
			AboutBox1.Show()
            AboutBox1.TextBoxDescription.Text =
                    "V0.8.6 Show .stp, .stl, .step, .sat, files in tree" & vbCrLf & _
                    "V0.8.5 Adden menuitem show only drawings 'In sync with ERP'" & vbCrLf & _
                    "V0.8.3 Added click to search parents, click to open in tree" & vbCrLf & _
                    "V0.8.2 Added 'Used In' list, Fixed colouring in tree" & vbCrLf & _
                    "V0.8.1 Inserted Menu" & vbCrLf & _
                    "V0.7.7 Recieve Command Line parameters" & vbCrLf & _
                    "V0.7.6 Minor TreeList changes" & vbCrLf & _
                    "V0.7.4 Added TreeList View" & vbCrLf & _
                    "V0.7.3 Minor ui changes" & vbCrLf & _
                    "V0.7.2 Minor ui changes" & vbCrLf & _
                    "V0.7.1 Fixed treeview" & vbCrLf & _
                    "V0.7 Changed way to display results" & vbCrLf & _
                    "V0.6 When partno typed revision is autocopmleted." & vbCrLf & vbCrLf & _
                    "V0.5 Corrected bug when folder exists." & vbCrLf & _
                    "V0.4 Changed Name to MDC (Manufacturing Data Collector)" & vbCrLf & _
                    "V0.3 Search with enter key." & vbCrLf & _
                    "V0.2 Added PartNo, Issue, DescriptionEN in search results list. Fixed Tab Sequence. Update before app starts." & vbCrLf & _
                    "V0.1 Added autologin, Autoresize listview with window" & vbCrLf & _
                    "V0.0 First release"
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim views() As EdmViewInfo = {}
		'ComboLanguage.Items.Add("")
		ComboLanguage.Items.Add("GR")
		ComboLanguage.Items.Add("EN")
		ComboLanguage.SelectedIndex = 0
		TextboxCollectPath.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\MDC"
		vault.GetVaultViews(views, False)
		ComboVaults.Items.Clear()
		For Each View As EdmViewInfo In views
			ComboVaults.Items.Add(View.mbsVaultName)
		Next
		If ComboVaults.Items.Count > 0 Then
			ComboVaults.Text = ComboVaults.Items(0)
		End If

		MenuItem1.Checked = My.Settings.Menu1
		MenuItem2.Checked = My.Settings.Menu2


		Me.Text = "Manufacturing Data Collector - V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor '& "." & My.Application.Info.Version.Revision
		ListView2.Columns.Add("PartNo", 70)
		ListView2.Columns.Add("Rev", 35)
		ListView2.Columns.Add("Ver", 35)
		ListView2.Columns.Add("Description", 250)
		ListView2.Columns.Add("Description English", 250)
		ListView2.Columns.Add("Path", 0)

		ListView1.Columns.Add("File", 120)
		ListView1.Columns.Add("PartNo", 70)
		ListView1.Columns.Add("Rev", 35)
		ListView1.Columns.Add("Ver", 35)
		ListView1.Columns.Add("Description", 250)
		ListView1.Columns.Add("Description English", 250)
		ListView1.Columns.Add("Path", 0)

		MultiColumnTree1.Columns.Add("File")
		MultiColumnTree1.Columns.Add("PartNo")
		MultiColumnTree1.Columns.Add("Rev")
		MultiColumnTree1.Columns.Add("Ver")
		MultiColumnTree1.Columns.Add("Description")
		MultiColumnTree1.Columns.Add("Description English")
		MultiColumnTree1.Columns.Add("State")
		MultiColumnTree1.Columns.Add("Type")
		MultiColumnTree1.Columns.Add("Sub-Group")
		MultiColumnTree1.Columns.Add("Path")
		MultiColumnTree1.Columns.Item(0).Width = 300
		MultiColumnTree1.Columns.Item(1).Width = 70
		MultiColumnTree1.Columns.Item(2).Width = 35
		MultiColumnTree1.Columns.Item(3).Width = 40
		MultiColumnTree1.Columns.Item(4).Width = 200
		MultiColumnTree1.Columns.Item(5).Width = 200
		MultiColumnTree1.Columns.Item(6).Width = 100
		MultiColumnTree1.Columns.Item(7).Width = 100
		MultiColumnTree1.Columns.Item(8).Width = 100
		MultiColumnTree1.Columns.Item(9).Width = 250

		'Αυτόματο login με την είσοδο στο πρόγραμμα
		vault.LoginAuto(ComboVaults.Text, Me.Handle.ToInt32())
		If vault.IsLoggedIn = True Then
			ComboVaults.Visible = False
			Login.Visible = False
			ToolStripStatusLabel2.Text = "Logged in to " & vault.Name
		Else
			ToolStripStatusLabel2.Text = "Not Logged in"
			MsgBox("Δεν έχετε κάνει login", , "Login to Vault")
		End If

		Me.PartNo.Select()
		Me.ActiveControl = PartNo
	End Sub

	Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
		Me.Show()
		Dim returnValue, list As String()
		Dim check As Boolean
		check = False
		'returnValue = Environment.GetCommandLineArgs() 'Ανάγνωση των command line arguments
		returnValue = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
		If Not returnValue Is Nothing Then
			'if returnValue.lenght > 0 then
			list = returnValue(0).Split(",")
			PartNo.Text = list(0)
			populatePartno()
			PartNo.Enabled = False
			For Each item As ListViewItem In ListView2.Items
				If item.Text = list(0) And item.SubItems.Item(1).Text = list(1) Then
					item.Selected = True
					check = True
					Exit For
				End If
			Next
			If check = True Then
				DisplayTree()
				ListView2.Enabled = False
			End If
		End If

	End Sub

	Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
		ComboVaults.Visible = True
		Login.Visible = True
	End Sub

	Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
		'On Error GoTo ErrHand
		If PartNo.Text = "" Then
			Exit Sub
		End If
		Me.Cursor = Cursors.AppStarting
		populatePartno()
		Me.Cursor = Cursors.Arrow
		Exit Sub
ErrHand:
		Dim ename As String
		Dim edesc As String
		Me.Cursor = Cursors.Arrow
		vault.GetErrorString(Err.Number, ename, edesc)
		MsgBox(ename + vbLf + edesc)


	End Sub

	Private Sub populatePartno()
		Dim search As IEdmSearch5
		Dim file As IEdmFile5
		Dim item As New ListViewItem()
		Dim temp(10), test As String
		Dim check As Boolean
		Dim verEnum As IEdmEnumeratorVersion5
		Dim pos As IEdmPos5
		Dim ver As IEdmRevision5
		Dim folder As IEdmFolder5
		folder = Nothing
		check = True
		ListView2.Items.Clear()
		ListView1.Items.Clear()
		TreeView1.Nodes.Clear()
		search = vault.CreateSearch
		search.AddVariable("PartNo", "%" & PartNo.Text)

        If MenuItem3.Checked = True Then
            search.State = "In Sync With ERP"
        End If
        search.FindHistoricStates = True
        Dim result, previousresult As IEdmSearchResult5
        previousresult = Nothing
        result = search.GetFirstResult
        While Not result Is Nothing
            check = True
            'temp(0) = Nothing
            'temp(1) = Nothing
            'temp(2) = Nothing
            file = result
            If Not previousresult Is Nothing Then
                If result.Path = previousresult.Path Then
                    check = False
                End If
            End If
            previousresult = result
            Select Case System.IO.Path.GetExtension(result.Name).ToLower
                Case ".sldprt", ".sldasm"
                    file.GetEnumeratorVariable.GetVar("PartNo", "@", temp(0))
                    file.GetEnumeratorVariable.GetVar("Revision", "@", temp(1))
                    file.GetEnumeratorVariable.GetVar("Description", "@", temp(2))
                Case Else
                    result = search.GetNextResult
                    Continue While
            End Select
            For Each listitem As ListViewItem In ListView2.Items
                If temp(0) Like listitem.Text And temp(1) Like listitem.SubItems.Item(1).Text And temp(2) Like listitem.SubItems.Item(2).Text Then
                    check = False
                End If
            Next
            If check = True Then
                'Προσθέτω και τα revision στη λίστα
                verEnum = file
                pos = verEnum.GetFirstRevisionPosition
                Dim poEnum As IEdmEnumeratorVariable7
                Dim oVarData As EdmGetVarData
                Dim aoVars() As Object
                Dim aoCfgs() As String
                Dim sMsg As String
                Dim iVarIdx As Integer
                Dim poVal As IEdmVariableValue6
                While Not pos.IsNull
                    item = New ListViewItem()
                    item.Text = temp(0)
                    sMsg = ""
                    ver = verEnum.GetNextRevision(pos)
                    poEnum = file.GetEnumeratorVariable
                    folder = vault.GetFolderFromPath(System.IO.Path.GetDirectoryName(result.Path))
                    poEnum.GetVersionVars(ver.VersionNo, folder.ID, aoVars, aoCfgs, oVarData)
                    iVarIdx = LBound(aoVars)
                    While (iVarIdx <= UBound(aoVars))
                        poVal = aoVars(iVarIdx)
                        Select Case poVal.VariableName
                            Case "Revision"
                                item.SubItems.Add(poVal.GetValue("@"))
                                item.SubItems.Add(ver.VersionNo)
                            Case "Description"
                                item.SubItems.Add(poVal.GetValue("@"))
                            Case "Description English"
                                item.SubItems.Add(poVal.GetValue("@"))
                                item.SubItems.Add(result.Path)
                        End Select
                        iVarIdx = iVarIdx + 1
                    End While
                    ListView2.Items.Insert(0, item)

                End While

            End If
            result = search.GetNextResult
        End While
    End Sub

	Private Sub CollectButton_Click(sender As Object, e As EventArgs) Handles CollectButton.Click
        On Error GoTo ErrHand
		If ListView2.SelectedItems.Count = 0 Then
			Exit Sub
		End If
		Dim file As IEdmFile5
		Dim rev, descrGR, descrEN, descr As String
		Dim folder As IEdmFolder5
		Dim ref As IEdmReference5
		Dim pos As IEdmPos5
		Dim items As New Microsoft.VisualBasic.Collection
        descr = ""
		folder = Nothing

		'Τρέχει ο αλγόριθμος και συλλέγει στο collection items τα αρχεία προς συλλογή
		If CheckBox1.Checked = False Then
			CollectFiles(items, ListView2.SelectedItems.Item(0).SubItems.Item(5).Text, ListView2.SelectedItems.Item(0).SubItems.Item(2).Text, 0)
		Else
			CollectFiles(items, ListView2.SelectedItems.Item(0).SubItems.Item(5).Text, ListView2.SelectedItems.Item(0).SubItems.Item(2).Text)
		End If

		'Γίνεται η συλλογή των αρχείων
		If items.Count > 0 Then
			Dim destFolder = ""
			file = vault.GetFileFromPath(ListView2.SelectedItems.Item(0).SubItems.Item(5).Text, folder)
            Select Case ComboLanguage.Text
                Case "EN"
                    descr = ListView2.SelectedItems.Item(0).SubItems.Item(4).Text
                Case "GR"
                    descr = ListView2.SelectedItems.Item(0).SubItems.Item(3).Text
            End Select
			destFolder = TextboxCollectPath.Text & "\" & System.IO.Path.GetFileNameWithoutExtension(file.Name) & " - Rev " & ListView2.SelectedItems.Item(0).SubItems.Item(1).Text & " - " & ComboLanguage.Text & " - " & descr & "\"
			If (Not System.IO.Directory.Exists(destFolder)) Then
				System.IO.Directory.CreateDirectory(destFolder)
				For Each temp In items
					file = vault.GetFileFromPath(temp, folder)
                    file.GetFileCopy(Me.Handle, 0)
                    ' Copy the file.
                    If Not System.IO.File.Exists(destFolder & file.Name) Then
                        System.IO.File.Copy(temp, destFolder & file.Name, True)
                    End If
				Next
				MsgBox("Τα σχέδια σώθηκαν στο φάκελο: " & destFolder)
			Else
				MsgBox("Ο φάκελος με τα αρχεία του συγκεκριμένου part υπάρχει ήδη. Η διαδικασία δεν ολοκληρώθηκε, διαγράψτε το φάκελο και ξαναπροσπαθήστε.")
			End If
		Else
			MsgBox("Δεν βρέθηκαν 'In sync with ERP' σχέδια για τα κριτήρια που δώσατε")
		End If
		Exit Sub
ErrHand:
		Dim ename As String
		Dim edesc As String
		vault.GetErrorString(Err.Number, ename, edesc)
		MsgBox(ename + vbLf + edesc)

	End Sub

	Private Sub CollectFiles(ByRef items As Microsoft.VisualBasic.Collection, path As String, ver As String, Optional ByVal allLevels As Integer = 1)
		Dim file As IEdmFile5
		Dim folder As IEdmFolder5
		Dim ref, ref2, ref3 As IEdmReference5
		Dim pos, pos2 As IEdmPos5
		Dim project As String
		If path = "" Then
			Exit Sub
		End If
		folder = Nothing
		project = ""
		file = vault.GetFileFromPath(path, folder)
		ref = file.GetReferenceTree(folder.ID, ver)

		'Εμφανίζονται πρώτα τα σχέδια στο δέντρο
		ref2 = ref
		pos = ref2.GetFirstParentPosition(ref2.VersionRef, False)
		While Not pos.IsNull
			ref2 = ref2.GetNextParent(pos)
			If System.IO.Path.GetExtension(ref2.File.Name).ToLower = ".slddrw" Then
				'If ref2.File.CurrentState.Name = "In Sync With ERP" Then
				ref3 = ref2.File.GetReferenceTree(folder.ID, ref2.VersionRef)
				pos2 = ref3.GetFirstParentPosition(ref2.VersionRef, False)
				If getVariable(ref3, "Language") = ComboLanguage.Text Then
					While Not pos2.IsNull
						ref3 = ref3.GetNextParent(pos2)
                        If ref3.File.CurrentState.Name = "In Sync With ERP" Or MenuItem3.Checked = False Then
                            items.Add(ref3.FoundPath)
                        End If
					End While
				End If
				'End If
			End If
		End While

		If allLevels = 1 Then 'Αν έχω επιλέξει να αναλύσει το δέντρο σε βάθος
			'Έπειτα τυπώνονται τα εξαρτήματα
			pos = ref.GetFirstChildPosition(project, False, True, 0)
			While Not pos.IsNull
				ref = ref.GetNextChild(pos)
				'If ref.File.CurrentState.Name = "In Sync With ERP" Then
				CollectFiles(items, ref.FoundPath, ref.VersionRef)
				'End If
			End While
		End If
	End Sub

	Private Sub DisplayTree()
		'On Error GoTo ErrHand
		If PartNo.Text = "" Then
			Exit Sub
		End If
		Dim temp As String
		Dim tempNode As TreeNode
		Dim ver
		Me.Cursor = Cursors.AppStarting
		'		TreeView1.Nodes.Clear()
		MultiColumnTree1.Nodes.Clear()

		temp = ""
		tempNode = Nothing
		PopulateParents(ListView2.SelectedItems.Item(0).SubItems.Item(5).Text, ListView2.SelectedItems.Item(0).SubItems.Item(2).Text)
		PopulateTree(TreeView1, tempNode, ListView2.SelectedItems.Item(0).SubItems.Item(5).Text, ListView2.SelectedItems.Item(0).SubItems.Item(2).Text)
		'		TreeView1.ExpandAll()
		MultiColumnTree1.expandAll()

		Me.Cursor = Cursors.Arrow
		Exit Sub
ErrHand:
		Dim ename As String
		Dim edesc As String
		vault.GetErrorString(Err.Number, ename, edesc)
		Me.Cursor = Cursors.Arrow
		MsgBox(ename + vbLf + edesc)
	End Sub

	Private Sub PopulateParents(path As String, ver As String)
		Dim file As IEdmFile5
		Dim folder As IEdmFolder5
		Dim ref As IEdmReference5
		Dim pos As IEdmPos5
		Dim item As New ListViewItem()
		If path = "" Then
			Exit Sub
		End If
		folder = Nothing
		ListView1.Items.Clear()
		file = vault.GetFileFromPath(path, folder)
		ref = file.GetReferenceTree(folder.ID, ver)
		pos = ref.GetFirstParentPosition(ref.VersionRef, False)
		While Not pos.IsNull
			ref = ref.GetNextParent(pos)
			If System.IO.Path.GetExtension(ref.File.Name).ToLower = ".sldasm" Or System.IO.Path.GetExtension(ref.File.Name).ToLower = ".sldprt" Then
				item = New ListViewItem()
				item.Text = ref.Name
				item.SubItems.Add(getVariable(ref, "PartNo"))
				item.SubItems.Add(getVariable(ref, "Revision"))
				item.SubItems.Add(ref.VersionRef & "/" & ref.File.CurrentVersion)
				item.SubItems.Add(getVariable(ref, "Description"))
				item.SubItems.Add(getVariable(ref, "Description English"))
				item.SubItems.Add(ref.FoundPath)
				ListView1.Items.Add(item)
			End If
		End While

	End Sub

	Private Sub PopulateTree(ByRef tree As TreeView, ByVal treenode As TreeNode, path As String, ver As String, Optional ByVal temp As Ai.Control.TreeNode = Nothing)
		Dim file As IEdmFile5
		Dim folder As IEdmFolder5
		Dim ref, ref2, ref3 As IEdmReference5
		Dim pos, pos2 As IEdmPos5
		Dim project As String
		Dim item As New ListViewItem()
		Dim temp2, temp3 As Ai.Control.TreeNode
        Dim check As Boolean
        Dim extension As String
        extension = ""
		If path = "" Then
			Exit Sub
		End If
		folder = Nothing
		project = ""
		file = vault.GetFileFromPath(path, folder)
		ref = file.GetReferenceTree(folder.ID, ver)
		If temp Is Nothing Then
			temp = MultiColumnTree1.Nodes.Add(file.Name)
			temp.SubItems.Add(getVariable(ref, "PartNo"))
			temp.SubItems.Add(getVariable(ref, "Revision"))
			temp.SubItems.Add(ref.VersionRef & "/" & ref.File.CurrentVersion)
			temp.SubItems.Add(getVariable(ref, "Description"))
			temp.SubItems.Add(getVariable(ref, "Description English"))
			temp.SubItems.Add(ref.File.CurrentState.Name)
			temp.SubItems.Add(typeName(getVariable(ref, "Component Type")))
			temp.SubItems.Add(getVariable(ref, "Component Type Subgroup"))
			temp.SubItems.Add(ref.FoundPath)
		End If

		'Εμφανίζονται πρώτα τα σχέδια στο δέντρο
		ref2 = ref
		pos = ref2.GetFirstParentPosition(ref2.VersionRef, False)
		check = False
		While Not pos.IsNull
            ref2 = ref2.GetNextParent(pos)
            extension = System.IO.Path.GetExtension(ref2.File.Name).ToLower
            If (extension = ".slddrw" And getVariable(ref2, "Language") = ComboLanguage.Text) Or extension = ".step" Or extension = ".stp" Or extension = ".stl" Or extension = ".sat" Or extension = ".docm" Then
                temp2 = temp.Nodes.Add(ref2.Name)
                temp2.SubItems.Add(getVariable(ref2, "PartNo"))
                temp2.SubItems.Add(getVariable(ref2, "Revision"))
                temp2.SubItems.Add(ref2.VersionRef & "/" & ref2.File.CurrentVersion)
                If ref2.VersionRef <> ref2.File.CurrentVersion And MenuItem1.Checked = True Then
                    temp2.Color = Color.DarkRed
                    temp2.NodeFont = New Font(temp2.NodeFont, FontStyle.Bold)
                End If
                temp2.SubItems.Add(getVariable(ref2, "Description"))
                temp2.SubItems.Add(getVariable(ref2, "Description English"))
                temp2.SubItems.Add(ref2.File.CurrentState.Name)
                temp2.SubItems.Add(typeName(getVariable(ref2, "Component Type")))
                temp2.SubItems.Add(getVariable(ref2, "Component Type Subgroup"))
                temp2.SubItems.Add(ref2.FoundPath)
                temp.expandAll()
                ref3 = ref2.File.GetReferenceTree(folder.ID, ref2.VersionRef)
                pos2 = ref3.GetFirstParentPosition(ref2.VersionRef, False)
                While Not pos2.IsNull
                    ref3 = ref3.GetNextParent(pos2)
                    If ref3.File.CurrentState.Name = "In Sync With ERP" Or MenuItem3.Checked = False Then
                        check = True
                        temp3 = temp2.Nodes.Add(ref3.Name)
                        temp3.SubItems.Add(getVariable(ref3, "PartNo"))
                        temp3.SubItems.Add(getVariable(ref3, "Revision"))
                        temp3.SubItems.Add(ref3.VersionRef & "/" & ref3.File.CurrentVersion)
                        temp3.SubItems.Add(getVariable(ref3, "Description"))
                        temp3.SubItems.Add(getVariable(ref3, "Description English"))
                        temp3.SubItems.Add(ref3.File.CurrentState.Name)
                        temp3.SubItems.Add(typeName(getVariable(ref3, "Component Type")))
                        temp3.SubItems.Add(getVariable(ref3, "Component Type Subgroup"))
                        temp3.SubItems.Add(ref3.FoundPath)
                        temp2.expandAll()
                        temp3.Color = Color.DarkGreen
                        'temp3.NodeFont = New Font(temp3.NodeFont, FontStyle.Bold)
                    End If
                End While
            End If
        End While
		If check = False And MenuItem2.Checked = True Then
			temp.NodeFont = New Font(temp.NodeFont, FontStyle.Bold)
			temp.Color = Color.DarkOrange
		End If

		'Έπειτα τυπώνονται τα εξαρτήματα
		pos = ref.GetFirstChildPosition(project, False, True, 0)
		While Not pos.IsNull
			ref = ref.GetNextChild(pos)
			'Εμφανίζω μόνο τα part που είναι manufactured και όχι τα purchased και virtual
			If typeName(getVariable(ref, "Component Type")) = "Manufactured" Then
				temp2 = temp.Nodes.Add(ref.Name)
				temp2.SubItems.Add(getVariable(ref, "PartNo"))
				temp2.SubItems.Add(getVariable(ref, "Revision"))
				temp2.SubItems.Add(ref.VersionRef & "/" & ref.File.CurrentVersion)
				If ref.VersionRef <> ref.File.CurrentVersion And MenuItem1.Checked = True Then
					temp2.Color = Color.DarkRed
					temp2.NodeFont = New Font(temp2.NodeFont, FontStyle.Bold)
				End If
				temp2.SubItems.Add(getVariable(ref, "Description"))
				temp2.SubItems.Add(getVariable(ref, "Description English"))
				temp2.SubItems.Add(ref.File.CurrentState.Name)
				temp2.SubItems.Add(typeName(getVariable(ref, "Component Type")))
				temp2.SubItems.Add(getVariable(ref, "Component Type Subgroup"))
				temp2.SubItems.Add(ref.FoundPath)
				temp.expandAll()
				PopulateTree(tree, Nothing, ref.FoundPath, ref.VersionRef, temp2)
			End If
		End While

	End Sub

	Private Function getVariable(ref As IEdmReference5, variable As String) As String
		Dim temp
		temp = ""
		Select Case System.IO.Path.GetExtension(ref.File.Name).ToLower
			Case ".pdf", ".docm", ".docx", ".doc", ".step"
				ref.File.GetEnumeratorVariable.GetVar(variable, "", temp)
			Case ".dxf"
				ref.File.GetEnumeratorVariable.GetVar(variable, "model", temp)
			Case ".slddrw", ".sldprt", ".sldasm"
				ref.File.GetEnumeratorVariable.GetVar(variable, "@", temp)
		End Select
		Return temp
	End Function

	''' <summary>
	''' Returns Component Type Name Of Given Id
	''' </summary>
	''' <param name="id">Component Type Id</param>
	''' <remarks></remarks>
	Private Function typeName(id)
		Select Case id
			Case "1"
				Return "Manufactured"
			Case "2"
				Return "Purchaced"
			Case "3"
				Return "Virtual"
			Case Else
				Return id
		End Select
	End Function

	Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
		FolderBrowserDialog1.ShowDialog()
		If FolderBrowserDialog1.SelectedPath <> "" Then
			TextboxCollectPath.Text = FolderBrowserDialog1.SelectedPath
		End If
	End Sub

	Private Sub PartNo_KeyDown(sender As Object, e As KeyEventArgs) Handles PartNo.KeyDown
		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			'Προσθέτω τα revision του part στο combobox
			Search_Click(sender, New System.EventArgs())
		End If
	End Sub

	Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
		Dim part
		part = ListView2.SelectedItems.Item(0).Text
		DisplayTree()

	End Sub

	Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		'Για αυτόματο resize του listview ταυτόχρονα με το παράθυρο
		SplitContainer1.Width = Me.Width - 38
		SplitContainer1.Height = Me.Height - 122
	End Sub

	Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
		ListView2.Width = SplitContainer1.Panel1.Width - 8
		ListView1.Width = SplitContainer1.Panel1.Width - 8
		ListView1.Height = SplitContainer1.Height - 367
	End Sub

	Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
		ListView2.Width = SplitContainer1.Panel1.Width - 8
		ListView1.Width = SplitContainer1.Panel1.Width - 8
	End Sub

	Private Sub ComboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLanguage.SelectedIndexChanged
		If ListView2.SelectedItems.Count > 0 Then
			DisplayTree()
		End If
	End Sub


	Private Sub MenuItem1_Click(sender As Object, e As EventArgs) Handles MenuItem1.Click
        My.Settings.Menu1 = MenuItem1.Checked
    End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub

	Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MenuItem2.Click
        My.Settings.Menu2 = MenuItem2.Checked
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        My.Settings.Menu3 = MenuItem3.Checked
    End Sub

	Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
		PartNo.Text = ListView1.SelectedItems.Item(0).SubItems.Item(1).Text
		ListView1.Items.Clear()
		ListView2.Items.Clear()
		MultiColumnTree1.Nodes.Clear()
		Search_Click(sender, New System.EventArgs())

	End Sub

	Private Sub MultiColumnTree1_DoubleClick(sender As Object, e As EventArgs) Handles MultiColumnTree1.DoubleClick
		'MsgBox(MultiColumnTree1.SelectedNode.SubItems.Item(9).Value)
		Dim file As IEdmFile5
		file = vault.GetFileFromPath(MultiColumnTree1.SelectedNode.SubItems.Item(9).Value)
		file.GetFileCopy(Me.Handle, 0, 0)
		Process.Start(MultiColumnTree1.SelectedNode.SubItems.Item(9).Value)
	End Sub

End Class
