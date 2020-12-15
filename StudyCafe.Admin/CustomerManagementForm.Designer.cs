﻿
namespace StudyCafe.Admin
{
    partial class CustomerManagementForm
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.bdsUser = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainLockerTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainStudyRoomTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainSeatTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckInStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPictureID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLockers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReports = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudyRooms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lCLSSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ppmMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCLSSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppmMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.checkEdit3);
            this.layoutControl1.Controls.Add(this.checkEdit2);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.grdUser);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseSkinIndents = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(681, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "검색";
            // 
            // checkEdit3
            // 
            this.checkEdit3.EditValue = true;
            this.checkEdit3.Location = new System.Drawing.Point(487, 34);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "전화번호 검색";
            this.checkEdit3.Size = new System.Drawing.Size(111, 24);
            this.checkEdit3.StyleController = this.layoutControl1;
            this.checkEdit3.TabIndex = 6;
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(392, 34);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "이름 검색";
            this.checkEdit2.Size = new System.Drawing.Size(85, 24);
            this.checkEdit2.StyleController = this.layoutControl1;
            this.checkEdit2.TabIndex = 6;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(305, 34);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "ID 검색";
            this.checkEdit1.Size = new System.Drawing.Size(77, 24);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 6;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(52, 34);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(243, 24);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 5;
            // 
            // grdUser
            // 
            this.grdUser.DataSource = this.bdsUser;
            this.grdUser.Location = new System.Drawing.Point(5, 74);
            this.grdUser.MainView = this.gridView1;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(790, 371);
            this.grdUser.TabIndex = 4;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsUser
            // 
            this.bdsUser.DataSource = typeof(StudyCafe.Data.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colPhoneNumber,
            this.colName,
            this.colRemainLockerTime,
            this.colRemainStudyRoomTime,
            this.colRemainSeatTime,
            this.colAdmin,
            this.colCheckInStatus,
            this.colPictureID,
            this.colInvoices,
            this.colLockers,
            this.colLogs,
            this.colPicture,
            this.colReports,
            this.colSeats,
            this.colStudyRooms});
            this.gridView1.GridControl = this.grdUser;
            this.gridView1.Name = "gridView1";
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.MinWidth = 25;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            this.colUserID.Width = 94;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 25;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 1;
            this.colPhoneNumber.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 94;
            // 
            // colRemainLockerTime
            // 
            this.colRemainLockerTime.FieldName = "RemainLockerTime";
            this.colRemainLockerTime.MinWidth = 25;
            this.colRemainLockerTime.Name = "colRemainLockerTime";
            this.colRemainLockerTime.Visible = true;
            this.colRemainLockerTime.VisibleIndex = 3;
            this.colRemainLockerTime.Width = 94;
            // 
            // colRemainStudyRoomTime
            // 
            this.colRemainStudyRoomTime.FieldName = "RemainStudyRoomTime";
            this.colRemainStudyRoomTime.MinWidth = 25;
            this.colRemainStudyRoomTime.Name = "colRemainStudyRoomTime";
            this.colRemainStudyRoomTime.Visible = true;
            this.colRemainStudyRoomTime.VisibleIndex = 4;
            this.colRemainStudyRoomTime.Width = 94;
            // 
            // colRemainSeatTime
            // 
            this.colRemainSeatTime.FieldName = "RemainSeatTime";
            this.colRemainSeatTime.MinWidth = 25;
            this.colRemainSeatTime.Name = "colRemainSeatTime";
            this.colRemainSeatTime.Visible = true;
            this.colRemainSeatTime.VisibleIndex = 5;
            this.colRemainSeatTime.Width = 94;
            // 
            // colAdmin
            // 
            this.colAdmin.FieldName = "Admin";
            this.colAdmin.MinWidth = 25;
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.Visible = true;
            this.colAdmin.VisibleIndex = 6;
            this.colAdmin.Width = 94;
            // 
            // colCheckInStatus
            // 
            this.colCheckInStatus.FieldName = "CheckInStatus";
            this.colCheckInStatus.MinWidth = 25;
            this.colCheckInStatus.Name = "colCheckInStatus";
            this.colCheckInStatus.Visible = true;
            this.colCheckInStatus.VisibleIndex = 7;
            this.colCheckInStatus.Width = 94;
            // 
            // colPictureID
            // 
            this.colPictureID.FieldName = "PictureID";
            this.colPictureID.MinWidth = 25;
            this.colPictureID.Name = "colPictureID";
            this.colPictureID.Visible = true;
            this.colPictureID.VisibleIndex = 8;
            this.colPictureID.Width = 94;
            // 
            // colInvoices
            // 
            this.colInvoices.FieldName = "Invoices";
            this.colInvoices.MinWidth = 25;
            this.colInvoices.Name = "colInvoices";
            this.colInvoices.Visible = true;
            this.colInvoices.VisibleIndex = 9;
            this.colInvoices.Width = 94;
            // 
            // colLockers
            // 
            this.colLockers.FieldName = "Lockers";
            this.colLockers.MinWidth = 25;
            this.colLockers.Name = "colLockers";
            this.colLockers.Visible = true;
            this.colLockers.VisibleIndex = 10;
            this.colLockers.Width = 94;
            // 
            // colLogs
            // 
            this.colLogs.FieldName = "Logs";
            this.colLogs.MinWidth = 25;
            this.colLogs.Name = "colLogs";
            this.colLogs.Visible = true;
            this.colLogs.VisibleIndex = 11;
            this.colLogs.Width = 94;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.MinWidth = 25;
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 12;
            this.colPicture.Width = 94;
            // 
            // colReports
            // 
            this.colReports.FieldName = "Reports";
            this.colReports.MinWidth = 25;
            this.colReports.Name = "colReports";
            this.colReports.Visible = true;
            this.colReports.VisibleIndex = 13;
            this.colReports.Width = 94;
            // 
            // colSeats
            // 
            this.colSeats.FieldName = "Seats";
            this.colSeats.MinWidth = 25;
            this.colSeats.Name = "colSeats";
            this.colSeats.Visible = true;
            this.colSeats.VisibleIndex = 14;
            this.colSeats.Width = 94;
            // 
            // colStudyRooms
            // 
            this.colStudyRooms.FieldName = "StudyRooms";
            this.colStudyRooms.MinWidth = 25;
            this.colStudyRooms.Name = "colStudyRooms";
            this.colStudyRooms.Visible = true;
            this.colStudyRooms.VisibleIndex = 15;
            this.colStudyRooms.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUser;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(800, 381);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lCLSSearch,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 69);
            this.layoutControlGroup1.Text = "검색";
            // 
            // lCLSSearch
            // 
            this.lCLSSearch.Control = this.textEdit1;
            this.lCLSSearch.Location = new System.Drawing.Point(0, 0);
            this.lCLSSearch.Name = "lCLSSearch";
            this.lCLSSearch.Size = new System.Drawing.Size(297, 37);
            this.lCLSSearch.Text = "검색명";
            this.lCLSSearch.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(297, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(87, 37);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEdit2;
            this.layoutControlItem4.Location = new System.Drawing.Point(384, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(95, 37);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit3;
            this.layoutControlItem2.Location = new System.Drawing.Point(479, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(121, 37);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(673, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(121, 37);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(600, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(73, 37);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ppmMenu
            // 
            this.ppmMenu.Name = "ppmMenu";
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomerManagementForm";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.CustomerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCLSSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppmMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl grdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lCLSSearch;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bdsUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainLockerTime;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainStudyRoomTime;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainSeatTime;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckInStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPictureID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colLockers;
        private DevExpress.XtraGrid.Columns.GridColumn colLogs;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colReports;
        private DevExpress.XtraGrid.Columns.GridColumn colSeats;
        private DevExpress.XtraGrid.Columns.GridColumn colStudyRooms;
        private DevExpress.XtraBars.PopupMenu ppmMenu;
    }
}