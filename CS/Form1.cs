using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraBars.Ribbon;

namespace Navigator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : RibbonForm
	{
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
		private DevExpress.XtraBars.BarButtonItem BarButtonFirst;
		private DevExpress.XtraBars.BarButtonItem BarButtonPrev;
        private DevExpress.XtraBars.BarButtonItem BarButtonNext;
        private DevExpress.XtraBars.BarButtonItem BarButtonLast;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem BarButtonAdd;
        private DevExpress.XtraBars.BarButtonItem BarButtonDelete;
        private DevExpress.XtraBars.BarButtonItem BarButtonEndEdit;
        private DevExpress.XtraBars.BarButtonItem BarButtonCancelEdit;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.BarButtonFirst = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonPrev = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonNext = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonLast = new DevExpress.XtraBars.BarButtonItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BarButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonEndEdit = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // BarButtonFirst
            // 
            this.BarButtonFirst.Caption = "First";
            this.BarButtonFirst.Id = 0;
            this.BarButtonFirst.Name = "BarButtonFirst";
            // 
            // BarButtonPrev
            // 
            this.BarButtonPrev.Caption = "Prev";
            this.BarButtonPrev.Id = 1;
            this.BarButtonPrev.Name = "BarButtonPrev";
            // 
            // BarButtonNext
            // 
            this.BarButtonNext.Caption = "Next";
            this.BarButtonNext.Id = 2;
            this.BarButtonNext.Name = "BarButtonNext";
            // 
            // BarButtonLast
            // 
            this.BarButtonLast.Caption = "Last";
            this.BarButtonLast.Id = 3;
            this.BarButtonLast.Name = "BarButtonLast";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1DataGridViewTextBoxColumn,
            this.column2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 275);
            this.dataGridView1.TabIndex = 4;
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "Column1";
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            // 
            // column2DataGridViewTextBoxColumn
            // 
            this.column2DataGridViewTextBoxColumn.DataPropertyName = "Column2";
            this.column2DataGridViewTextBoxColumn.HeaderText = "Column2";
            this.column2DataGridViewTextBoxColumn.Name = "column2DataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Table1";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = null;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarButtonFirst,
            this.BarButtonPrev,
            this.BarButtonNext,
            this.BarButtonLast,
            this.BarButtonAdd,
            this.BarButtonDelete,
            this.BarButtonEndEdit,
            this.BarButtonCancelEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(694, 50);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // BarButtonAdd
            // 
            this.BarButtonAdd.Caption = "Add";
            this.BarButtonAdd.Id = 0;
            this.BarButtonAdd.Name = "BarButtonAdd";
            // 
            // BarButtonDelete
            // 
            this.BarButtonDelete.Caption = "Delete";
            this.BarButtonDelete.Id = 1;
            this.BarButtonDelete.Name = "BarButtonDelete";
            // 
            // BarButtonEndEdit
            // 
            this.BarButtonEndEdit.Caption = "EndEdit";
            this.BarButtonEndEdit.Id = 2;
            this.BarButtonEndEdit.Name = "BarButtonEndEdit";
            // 
            // BarButtonCancelEdit
            // 
            this.BarButtonCancelEdit.Caption = "CancelEdit";
            this.BarButtonCancelEdit.Id = 3;
            this.BarButtonCancelEdit.Name = "BarButtonCancelEdit";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonFirst);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonPrev);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonNext);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonLast);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonAdd);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonDelete);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonEndEdit);
            this.ribbonStatusBar1.ItemLinks.Add(this.BarButtonCancelEdit);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 298);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(694, 27);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(694, 325);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void CreateNavigator() {
			DevExpress.Demos.Navigator.XtraBarsDataNavigator navigator;
			navigator = new DevExpress.Demos.Navigator.XtraBarsDataNavigator();
			navigator.BindingContext = this.BindingContext;
			navigator.DataSource = bindingSource1;
            navigator.BarManager = ribbonControl1.Manager;

			// link buttons
			DevExpress.Demos.Navigator.ButtonLink link;
			link = navigator.Buttons.Add();
			link.ActionType = DevExpress.Demos.Navigator.ActionType.First;
			link.Button = BarButtonFirst;
			link = navigator.Buttons.Add();
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Prev;
			link.Button = BarButtonPrev;
			link = navigator.Buttons.Add();
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Next;
			link.Button = BarButtonNext;
			link = navigator.Buttons.Add();
			link.ActionType = DevExpress.Demos.Navigator.ActionType.Last;
			link.Button = BarButtonLast;
            link = navigator.Buttons.Add();
            link.ActionType = DevExpress.Demos.Navigator.ActionType.Add;
            link.Button = BarButtonAdd;
            link = navigator.Buttons.Add();
            link.ActionType = DevExpress.Demos.Navigator.ActionType.Delete;
            link.Button = BarButtonDelete;
            link = navigator.Buttons.Add();
            link.ActionType = DevExpress.Demos.Navigator.ActionType.EndEdit;
            link.Button = BarButtonEndEdit;
            link = navigator.Buttons.Add();
            link.ActionType = DevExpress.Demos.Navigator.ActionType.CancelEdit;
            link.Button = BarButtonCancelEdit;
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			
			for(int i = 0; i < 5; i++)
				dataTable1.Rows.Add(new object[] {"Item " + (i+1).ToString()});

            ribbonControl1.ForceInitialize();            
            CreateNavigator();			
		}
	}
}
