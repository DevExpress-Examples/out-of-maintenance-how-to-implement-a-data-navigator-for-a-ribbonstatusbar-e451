Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars.Ribbon

Namespace Navigator
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits RibbonForm
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private BarButtonFirst As DevExpress.XtraBars.BarButtonItem
		Private BarButtonPrev As DevExpress.XtraBars.BarButtonItem
		Private BarButtonNext As DevExpress.XtraBars.BarButtonItem
		Private BarButtonLast As DevExpress.XtraBars.BarButtonItem
		Private dataGridView1 As DataGridView
		Private column1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
		Private column2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
		Private bindingSource1 As BindingSource
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private BarButtonAdd As DevExpress.XtraBars.BarButtonItem
		Private BarButtonDelete As DevExpress.XtraBars.BarButtonItem
		Private BarButtonEndEdit As DevExpress.XtraBars.BarButtonItem
		Private BarButtonCancelEdit As DevExpress.XtraBars.BarButtonItem
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.BarButtonFirst = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonPrev = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonNext = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonLast = New DevExpress.XtraBars.BarButtonItem()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.column1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.column2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.BarButtonAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonEndEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.BarButtonCancelEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			' 
			' BarButtonFirst
			' 
			Me.BarButtonFirst.Caption = "First"
			Me.BarButtonFirst.Id = 0
			Me.BarButtonFirst.Name = "BarButtonFirst"
			' 
			' BarButtonPrev
			' 
			Me.BarButtonPrev.Caption = "Prev"
			Me.BarButtonPrev.Id = 1
			Me.BarButtonPrev.Name = "BarButtonPrev"
			' 
			' BarButtonNext
			' 
			Me.BarButtonNext.Caption = "Next"
			Me.BarButtonNext.Id = 2
			Me.BarButtonNext.Name = "BarButtonNext"
			' 
			' BarButtonLast
			' 
			Me.BarButtonLast.Caption = "Last"
			Me.BarButtonLast.Id = 3
			Me.BarButtonLast.Name = "BarButtonLast"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.column1DataGridViewTextBoxColumn, Me.column2DataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.bindingSource1
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 50)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.RowTemplate.Height = 24
			Me.dataGridView1.Size = New System.Drawing.Size(694, 275)
			Me.dataGridView1.TabIndex = 4
			' 
			' column1DataGridViewTextBoxColumn
			' 
			Me.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1"
			Me.column1DataGridViewTextBoxColumn.HeaderText = "Column1"
			Me.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn"
			' 
			' column2DataGridViewTextBoxColumn
			' 
			Me.column2DataGridViewTextBoxColumn.DataPropertyName = "Column2"
			Me.column2DataGridViewTextBoxColumn.HeaderText = "Column2"
			Me.column2DataGridViewTextBoxColumn.Name = "column2DataGridViewTextBoxColumn"
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationIcon = Nothing
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.BarButtonFirst, Me.BarButtonPrev, Me.BarButtonNext, Me.BarButtonLast, Me.BarButtonAdd, Me.BarButtonDelete, Me.BarButtonEndEdit, Me.BarButtonCancelEdit})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 4
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Size = New System.Drawing.Size(694, 50)
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			' 
			' BarButtonAdd
			' 
			Me.BarButtonAdd.Caption = "Add"
			Me.BarButtonAdd.Id = 0
			Me.BarButtonAdd.Name = "BarButtonAdd"
			' 
			' BarButtonDelete
			' 
			Me.BarButtonDelete.Caption = "Delete"
			Me.BarButtonDelete.Id = 1
			Me.BarButtonDelete.Name = "BarButtonDelete"
			' 
			' BarButtonEndEdit
			' 
			Me.BarButtonEndEdit.Caption = "EndEdit"
			Me.BarButtonEndEdit.Id = 2
			Me.BarButtonEndEdit.Name = "BarButtonEndEdit"
			' 
			' BarButtonCancelEdit
			' 
			Me.BarButtonCancelEdit.Caption = "CancelEdit"
			Me.BarButtonCancelEdit.Id = 3
			Me.BarButtonCancelEdit.Name = "BarButtonCancelEdit"
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonFirst)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonPrev)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonNext)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonLast)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonAdd)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonDelete)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonEndEdit)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.BarButtonCancelEdit)
			Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 298)
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			Me.ribbonStatusBar1.Size = New System.Drawing.Size(694, 27)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.ClientSize = New System.Drawing.Size(694, 325)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.StatusBar = Me.ribbonStatusBar1
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub CreateNavigator()
			Dim navigator As DevExpress.Demos.Navigator.XtraBarsDataNavigator
			navigator = New DevExpress.Demos.Navigator.XtraBarsDataNavigator()
			navigator.BindingContext = Me.BindingContext
			navigator.DataSource = bindingSource1
			navigator.BarManager = ribbonControl1.Manager

			' link buttons
			Dim link As DevExpress.Demos.Navigator.ButtonLink
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.First
			link.Button = BarButtonFirst
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Prev
			link.Button = BarButtonPrev
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Next
			link.Button = BarButtonNext
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Last
			link.Button = BarButtonLast
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Add
			link.Button = BarButtonAdd
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Delete
			link.Button = BarButtonDelete
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.EndEdit
			link.Button = BarButtonEndEdit
			link = navigator.Buttons.Add()
			link.ActionType = DevExpress.Demos.Navigator.ActionType.CancelEdit
			link.Button = BarButtonCancelEdit
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

			For i As Integer = 0 To 4
				dataTable1.Rows.Add(New Object() {"Item " & (i+1).ToString()})
			Next i

			ribbonControl1.ForceInitialize()
			CreateNavigator()
		End Sub
	End Class
End Namespace
