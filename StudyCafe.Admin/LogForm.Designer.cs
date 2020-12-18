
namespace StudyCafe.Admin
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbeSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.grdLog = new DevExpress.XtraGrid.GridControl();
            this.bdsLog = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSomething = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.검색조 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.검색조)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbeSearch);
            this.layoutControl1.Controls.Add(this.grdLog);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(793, 490);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbeSearch
            // 
            this.cbeSearch.Location = new System.Drawing.Point(63, 12);
            this.cbeSearch.Name = "cbeSearch";
            this.cbeSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSearch.Properties.Items.AddRange(new object[] {
            "All",
            "User",
            "Login",
            "Logout",
            "CheckIn",
            "ChecOut",
            "DisplayedItem"});
            this.cbeSearch.Size = new System.Drawing.Size(331, 24);
            this.cbeSearch.StyleController = this.layoutControl1;
            this.cbeSearch.TabIndex = 5;
            this.cbeSearch.SelectedIndexChanged += new System.EventHandler(this.cbeSearch_SelectedIndexChanged);
            // 
            // grdLog
            // 
            this.grdLog.DataSource = this.bdsLog;
            this.grdLog.Location = new System.Drawing.Point(12, 40);
            this.grdLog.MainView = this.gridView1;
            this.grdLog.Name = "grdLog";
            this.grdLog.Size = new System.Drawing.Size(769, 438);
            this.grdLog.TabIndex = 4;
            this.grdLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLog
            // 
            this.bdsLog.DataSource = typeof(StudyCafe.Data.Log);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogID,
            this.colKind,
            this.colDate,
            this.colTime,
            this.colWho,
            this.colSomething,
            this.colDo});
            this.gridView1.GridControl = this.grdLog;
            this.gridView1.Name = "gridView1";
            // 
            // colLogID
            // 
            this.colLogID.FieldName = "LogID";
            this.colLogID.MinWidth = 25;
            this.colLogID.Name = "colLogID";
            this.colLogID.Visible = true;
            this.colLogID.VisibleIndex = 0;
            this.colLogID.Width = 94;
            // 
            // colKind
            // 
            this.colKind.FieldName = "Kind";
            this.colKind.MinWidth = 25;
            this.colKind.Name = "colKind";
            this.colKind.Visible = true;
            this.colKind.VisibleIndex = 1;
            this.colKind.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 94;
            // 
            // colTime
            // 
            this.colTime.FieldName = "Time";
            this.colTime.MinWidth = 25;
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 3;
            this.colTime.Width = 94;
            // 
            // colWho
            // 
            this.colWho.FieldName = "Who";
            this.colWho.MinWidth = 25;
            this.colWho.Name = "colWho";
            this.colWho.Visible = true;
            this.colWho.VisibleIndex = 4;
            this.colWho.Width = 94;
            // 
            // colSomething
            // 
            this.colSomething.FieldName = "Something";
            this.colSomething.MinWidth = 25;
            this.colSomething.Name = "colSomething";
            this.colSomething.Visible = true;
            this.colSomething.VisibleIndex = 5;
            this.colSomething.Width = 94;
            // 
            // colDo
            // 
            this.colDo.FieldName = "Do";
            this.colDo.MinWidth = 25;
            this.colDo.Name = "colDo";
            this.colDo.Visible = true;
            this.colDo.VisibleIndex = 6;
            this.colDo.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.검색조});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(793, 490);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdLog;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(773, 442);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(386, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(387, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // 검색조
            // 
            this.검색조.Control = this.cbeSearch;
            this.검색조.Location = new System.Drawing.Point(0, 0);
            this.검색조.Name = "검색조";
            this.검색조.Size = new System.Drawing.Size(386, 28);
            this.검색조.TextSize = new System.Drawing.Size(39, 18);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 490);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LogForm";
            this.Text = "LogForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.검색조)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSearch;
        private DevExpress.XtraGrid.GridControl grdLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem 검색조;
        private System.Windows.Forms.BindingSource bdsLog;
        private DevExpress.XtraGrid.Columns.GridColumn colLogID;
        private DevExpress.XtraGrid.Columns.GridColumn colKind;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colWho;
        private DevExpress.XtraGrid.Columns.GridColumn colSomething;
        private DevExpress.XtraGrid.Columns.GridColumn colDo;
    }
}